// ChecksumDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Checksum.h"
#include "ChecksumDlg.h"
#include ".\checksumdlg.h"
#include <string.h>
#include <stdio.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// CChecksumDlg dialog



CChecksumDlg::CChecksumDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CChecksumDlg::IDD, pParent)
	, m_path(_T(""))
	, m_dosswizzle(FALSE)
	, m_2BSwitch(FALSE)
	, m_4BSwitch(FALSE)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CChecksumDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);

	DDX_Control(pDX, IDC_OUTPUT, m_Output);
	DDX_Check(pDX, IDC_DOSSWIZZLE, m_dosswizzle);
	DDX_Control(pDX, IDC_SELECTFILE1, m_selectfile);
	DDX_Check(pDX, IDC_2BSwitch, m_2BSwitch);
	DDX_Check(pDX, IDC_4BSwitch, m_4BSwitch);
}

BEGIN_MESSAGE_MAP(CChecksumDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_CHECKSUM, OnBnClickedChecksum)
	ON_BN_CLICKED(IDC_DOSSWIZZLE, OnBnClickedDosswizzle)
	ON_BN_CLICKED(IDC_2BSwitch, OnBnClicked2bswitch)
END_MESSAGE_MAP()


// CChecksumDlg message handlers

BOOL CChecksumDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CChecksumDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CChecksumDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CChecksumDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

int CChecksumDlg::Check (CString *pm_path)
{
	//init variables for storing sums
	unsigned char s1,s2,s3;		//used for Dos Swizzleing
    unsigned long sum8 = 0;		//stores 8bit cksum
    unsigned long sum16 = 0;		//stores 16bit cksm
    unsigned long sum32 = 0;		//stores 32bit cksm
    unsigned int crc8 = 0;		//stores 8bit crc
	unsigned int crc8t = 0;		//stores 8bit crc
	unsigned int crc16, crc16t,l16,h16,x16;
	unsigned int counter = 0;
	//char with pointer for conversion and output of results
	char *ptemp;
	char temp[9]; //hex number will have 0-8 plus null termination.
	ptemp = &temp[0];

	//init int variable for holding bytes read.
	unsigned char idata[2049], *pidata;
	//init pointer to data variable for data retrieval functions.
	pidata = &idata[0];
	//init counter variables for calculating checksum.
	int x, ncnt, ofcnt;
	bool bFlag = false;
	//init DWORD variable and pointer to keep track of bytes read.
	DWORD bRead = 1;
	DWORD *pbRead;
	pbRead = &bRead;
	x = 0;
	ncnt  = 0;
	ofcnt = 0;
	crc16 = 0;
	crc16t = l16 = h16 = x16 = 0;
	
	HANDLE hFile = CreateFile(*pm_path, //File to open
		GENERIC_READ,	//Open for reading
		0,				//do not share
		NULL,			//no ecurity
		OPEN_EXISTING,  //Open Existing file only
		NULL,			//attributes unimportant
		NULL);			//no attribute template

	m_Output.InsertString(0,*pm_path);
  if (hFile == INVALID_HANDLE_VALUE)
    {
      //If File not opened warn and return
		m_Output.InsertString(0,"Unable to open File:");
      return(-2);
    }
	m_Output.InsertString(0,"Reading from file:");
	

	//set whole array to 0
	counter = 0;
	do
    /* Dont use a char size variable to check for EOF, use int.
       Because binary files could appear to have a false EOF
       if the compare does not include the sign extend. */
	{

		ReadFile(hFile,pidata,2048,pbRead,NULL);


		if (bRead == 0)
		  {
			  bFlag = true;
			  break;//if statement with flag ensures sum is run to end of file.
		  }

		while (counter < 2048) //Begin Buffer Dump
		{
			if (*pidata < 0) //negative number count--shouldn't work with char?
				{
					ncnt++;
				}
			if (m_dosswizzle == 1) //Dos swizzle from ron's cksm. --probably doesn't work right.
			{

				s3 = ((*pidata ^ ~0xff) << 4) | 
					((*pidata ^ ~0xff) >> 4);
				*pidata = s3;	
			}
			if (m_2BSwitch == 1)
			{
				sum8 += *(pidata + 1);
				sum16 += *(pidata+1)<<(8*(x%2));
				sum32 += *(pidata+1)<<(8*(x%4));
				x++;
				sum8 += *pidata;
				sum16 += *pidata<<(8*(x%2));
				sum32 += *pidata<<(8*(x%4));
				counter ++;
				pidata++;

			}
			else if (m_4BSwitch == 1)
			{
				sum8 += *(pidata + 3);
				sum16 += *(pidata+3)<<(8*(x%2));
				sum32 += *(pidata+3)<<(8*(x%4));
				x++;
				sum8 += *(pidata+2);
				sum16 += *(pidata+2)<<(8*(x%2));
				sum32 += *(pidata+2)<<(8*(x%4));
				x++;
				sum8 += *(pidata + 1);
				sum16 += *(pidata+1)<<(8*(x%2));
				sum32 += *(pidata+1)<<(8*(x%4));
				x++;
				sum8 += *pidata;
				sum16 += *pidata<<(8*(x%2));
				sum32 += *pidata<<(8*(x%4));
				counter +=3;
				pidata += 3;
			}
			else
			{
			sum8 += *pidata;				//bitwise AND each byte with sum8
			
			sum16 += *pidata<<(8*(x%2));	//bitwise AND each 2 bytes with sum16
			sum32 += *pidata<<(8*(x%4));	//bitwise AND each 4 bytes with sum32
			}
			/* ignore CRC
			crc8   =  (crc8<<1 ) + (crc8>>31) + *pidata;
			crc8t  = ((crc8t<<1 ) & 0x7FFFFFFF) + ((crc8t>>30) & 0x00000001) + *pidata;
			if ( crc8t > 0x7FFFFFFF )
			{ 
				ofcnt++; 
			}
			crc16 += *pidata;
			crc16t = (l16 & 1) + (crc16 & 1); 
			l16 = (l16 >>1) + (crc16 >>1) + (crc16t >>1);
			l16 = (l16 <<1) + (l16 >>31) + (crc16t &1);
			*/
			x++; //count total bytes
			counter ++; //count buffer location 
			pidata++;

		}  //End Buffer Dump
	pidata = &idata[0];
	counter = 0;
    } while (bRead !=0 );
	
	
	CloseHandle(hFile);
	
	itoa(x,ptemp,10);
	m_Output.InsertString(0,ptemp);
	m_Output.InsertString(0,"Bytes         : ");

	itoa(sum8,ptemp,16);
	m_Output.InsertString(0,ptemp);
	m_Output.InsertString(0,"8-bit Checksum : ");

	itoa(sum16,ptemp,16);
	m_Output.InsertString(0,ptemp);
	m_Output.InsertString(0,"16-bit Checksum: ");


	itoa(sum32,ptemp,16);
	m_Output.InsertString(0,ptemp);
	m_Output.InsertString(0,"32-bit Checksum: ");

	m_Output.InsertString(0,"End Check Function");
  //printf(" The negative number count is: %d \n", ncnt);
  //printf(" The file length in bytes is: %d \n", x);
  //printf(" The file addressing goes from 0 to 0x%08x \n",(x-1));
  //printf(" The simple 8bit checksum is: 0x%08x \n", sum8);
  //printf(" \n");
  //printf(" The 16bit little endian checksum is: 0x%08x \n", sum16);
  //printf(" The 32bit little endian checksum is: 0x%08x \n", sum32);
  //printf(" \n");
  //printf(" the l16 = 0x%08x \n", l16);
  //printf(" \n");
  /*  printf(" The 8/32 bit SL CRC is: %08x \n", crc8);
  printf(" The 8/31 bit SL CRC is: %08x \n", crc8t);
  printf(" The 8/31 bit SL CRC overflow count is: %04x \n", ofcnt);*/
  return(0);
}
void CChecksumDlg::OnBnClickedChecksum()
{

	/*   This is tested code for dealing with the edit box.
	CString test;
	m_Path.GetWindowText(test);
	MessageBox(test);
	test = "d";
	m_Path.SetWindowText(test);
		m_Output.ResetContent();
	m_Output.AddString("hi");
	m_Output.AddString("there");
	*/

	//UpdateData puts window text into member CString variable

	UpdateData(1);
	m_Output.InsertString(0,"-----------Begin Checksum Attempt-------------------");
	m_Output.InsertString(0,m_path);
	m_path = m_selectfile.get_FileName();
	CString *pm_path = &m_path;
	Check(pm_path);
	m_Output.InsertString(0,"-----------End Checksum Attempt-------------------");




}



void CChecksumDlg::OnBnClickedDosswizzle()
{
	UpdateData(1);	
}
BEGIN_EVENTSINK_MAP(CChecksumDlg, CDialog)
	ON_EVENT(CChecksumDlg, IDC_SELECTFILE1, 1, SelectionCompleteSelectfile1, VTS_NONE)
END_EVENTSINK_MAP()

void CChecksumDlg::SelectionCompleteSelectfile1()
{

}

void CChecksumDlg::OnBnClicked2bswitch()
{
	UpdateData(1);
}
