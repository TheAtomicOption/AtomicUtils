Public Class IDVB_MAIN
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btn_QUIT As System.Windows.Forms.Button
    Friend WithEvents ctl_FindFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_FindFolder As System.Windows.Forms.Button
    Friend WithEvents txt_CurrentFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Extensions As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ctl_CharsToOverWriteNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Insert As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ctl_FirstCharSkipNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lst_output As System.Windows.Forms.ListBox
    Friend WithEvents btn_Insert As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_underscore As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TText As System.Windows.Forms.ToolTip
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBTop As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btn_QUIT = New System.Windows.Forms.Button
        Me.txt_CurrentFolder = New System.Windows.Forms.TextBox
        Me.ctl_FindFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.btn_FindFolder = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Extensions = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Insert = New System.Windows.Forms.TextBox
        Me.ctl_CharsToOverWriteNum = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ctl_FirstCharSkipNum = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lst_output = New System.Windows.Forms.ListBox
        Me.btn_Insert = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_underscore = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TText = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.CBTop = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_QUIT
        '
        Me.btn_QUIT.Location = New System.Drawing.Point(592, 48)
        Me.btn_QUIT.Name = "btn_QUIT"
        Me.btn_QUIT.Size = New System.Drawing.Size(72, 24)
        Me.btn_QUIT.TabIndex = 0
        Me.btn_QUIT.Text = "Quit"
        Me.TText.SetToolTip(Me.btn_QUIT, "Run scared like the little bitch you are")
        '
        'txt_CurrentFolder
        '
        Me.txt_CurrentFolder.Location = New System.Drawing.Point(8, 16)
        Me.txt_CurrentFolder.Name = "txt_CurrentFolder"
        Me.txt_CurrentFolder.Size = New System.Drawing.Size(576, 20)
        Me.txt_CurrentFolder.TabIndex = 1
        Me.txt_CurrentFolder.Text = ""
        Me.TText.SetToolTip(Me.txt_CurrentFolder, "This is where you're at")
        '
        'ctl_FindFolder
        '
        Me.ctl_FindFolder.ShowNewFolderButton = False
        '
        'btn_FindFolder
        '
        Me.btn_FindFolder.Location = New System.Drawing.Point(592, 16)
        Me.btn_FindFolder.Name = "btn_FindFolder"
        Me.btn_FindFolder.Size = New System.Drawing.Size(72, 24)
        Me.btn_FindFolder.TabIndex = 2
        Me.btn_FindFolder.Text = "Browse..."
        Me.TText.SetToolTip(Me.btn_FindFolder, "Find that special place")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current Folder:"
        '
        'txt_Extensions
        '
        Me.txt_Extensions.Location = New System.Drawing.Point(264, 56)
        Me.txt_Extensions.Name = "txt_Extensions"
        Me.txt_Extensions.Size = New System.Drawing.Size(184, 20)
        Me.txt_Extensions.TabIndex = 5
        Me.txt_Extensions.Text = ".mp3,.wma,.ogg,.wav"
        Me.TText.SetToolTip(Me.txt_Extensions, "Extensions To Rename [Comma Separated; Blank for all]")
        '
        'Label2
        '
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(192, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Extensions:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txt_Insert
        '
        Me.txt_Insert.Location = New System.Drawing.Point(8, 32)
        Me.txt_Insert.Name = "txt_Insert"
        Me.txt_Insert.Size = New System.Drawing.Size(440, 20)
        Me.txt_Insert.TabIndex = 7
        Me.txt_Insert.Text = ""
        '
        'ctl_CharsToOverWriteNum
        '
        Me.ctl_CharsToOverWriteNum.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64"})
        Me.ctl_CharsToOverWriteNum.Location = New System.Drawing.Point(264, 88)
        Me.ctl_CharsToOverWriteNum.MaxDropDownItems = 20
        Me.ctl_CharsToOverWriteNum.MaxLength = 3
        Me.ctl_CharsToOverWriteNum.Name = "ctl_CharsToOverWriteNum"
        Me.ctl_CharsToOverWriteNum.Size = New System.Drawing.Size(40, 21)
        Me.ctl_CharsToOverWriteNum.TabIndex = 8
        Me.ctl_CharsToOverWriteNum.Tag = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(112, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "characters; overwrite the next"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(304, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "characters."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Skip the first"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ctl_FirstCharSkipNum
        '
        Me.ctl_FirstCharSkipNum.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64"})
        Me.ctl_FirstCharSkipNum.Location = New System.Drawing.Point(72, 88)
        Me.ctl_FirstCharSkipNum.MaxDropDownItems = 20
        Me.ctl_FirstCharSkipNum.MaxLength = 3
        Me.ctl_FirstCharSkipNum.Name = "ctl_FirstCharSkipNum"
        Me.ctl_FirstCharSkipNum.Size = New System.Drawing.Size(40, 21)
        Me.ctl_FirstCharSkipNum.TabIndex = 12
        Me.ctl_FirstCharSkipNum.Tag = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Text to Insert:"
        '
        'lst_output
        '
        Me.lst_output.HorizontalScrollbar = True
        Me.lst_output.Location = New System.Drawing.Point(8, 168)
        Me.lst_output.Name = "lst_output"
        Me.lst_output.Size = New System.Drawing.Size(656, 108)
        Me.lst_output.TabIndex = 14
        '
        'btn_Insert
        '
        Me.btn_Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Insert.Location = New System.Drawing.Point(368, 88)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(80, 24)
        Me.btn_Insert.TabIndex = 15
        Me.btn_Insert.Text = "Do It!"
        Me.TText.SetToolTip(Me.btn_Insert, "Careful: There's no undo!")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = ""
        Me.TText.SetToolTip(Me.TextBox1, "This is the number of characters in the box above")
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "# of Insert Chars"
        '
        'btn_underscore
        '
        Me.btn_underscore.Location = New System.Drawing.Point(16, 56)
        Me.btn_underscore.Name = "btn_underscore"
        Me.btn_underscore.Size = New System.Drawing.Size(80, 23)
        Me.btn_underscore.TabIndex = 18
        Me.btn_underscore.Text = """_"" to "" """
        Me.TText.SetToolTip(Me.btn_underscore, "Convert underscore to space")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = """-"" to "" - """
        Me.TText.SetToolTip(Me.Button1, "Add breathing room for your dashes")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Capitalize"
        Me.TText.SetToolTip(Me.Button2, "Capitalize that shit")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_underscore)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 120)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quick Fixes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ctl_CharsToOverWriteNum)
        Me.GroupBox2.Controls.Add(Me.ctl_FirstCharSkipNum)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_Insert)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_Insert)
        Me.GroupBox2.Controls.Add(Me.txt_Extensions)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(128, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 120)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fuck Up Your File Names"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(592, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Output:"
        '
        'CBTop
        '
        Me.CBTop.Location = New System.Drawing.Point(592, 128)
        Me.CBTop.Name = "CBTop"
        Me.CBTop.Size = New System.Drawing.Size(64, 16)
        Me.CBTop.TabIndex = 24
        Me.CBTop.Text = "On Top"
        Me.TText.SetToolTip(Me.CBTop, "Always On Top")
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(592, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 24)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "About"
        '
        'IDVB_MAIN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 280)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBTop)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lst_output)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_FindFolder)
        Me.Controls.Add(Me.txt_CurrentFolder)
        Me.Controls.Add(Me.btn_QUIT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "IDVB_MAIN"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Filename Fixer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim StartDir As String
    Private Sub IDVB_MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load current directory on startup
        StartDir = IO.Directory.GetCurrentDirectory()
        txt_CurrentFolder.Text = StartDir
        'set skip and over write numbers to 0 by default
        ctl_CharsToOverWriteNum.SelectedIndex = 0
        ctl_FirstCharSkipNum.SelectedIndex = 0
    End Sub
    Private Sub btn_QUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_QUIT.Click
        MyBase.Close()
    End Sub

    Private Sub btn_FindFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FindFolder.Click
        'show folder select dialog, update displayed path
        ctl_FindFolder.SelectedPath = StartDir
        If ctl_FindFolder.ShowDialog = DialogResult.OK Then
            txt_CurrentFolder.Text() = ctl_FindFolder.SelectedPath()
            StartDir = ctl_FindFolder.SelectedPath()
        End If
        'IO.Directory.SetCurrentDirectory(txt_CurrentFolder.Text())
    End Sub

    Function DirTest() As Boolean
        'Returns True if given directory is invalid.
        If Not IO.Directory.Exists(txt_CurrentFolder.Text) Then
            MsgBox("Directory Not Found. Directory is inaccessable or does not exist.", MsgBoxStyle.Exclamation, "Error: 001")
            Return True
        End If
        'Set current working directory to the target directory.
        StartDir = txt_CurrentFolder.Text
        'Try
        'IO.Directory.SetCurrentDirectory(txt_CurrentFolder.Text())
        'Catch ex As Exception
        '    MsgBox("Unable to access directory. Directory is inaccessable or does not exist.", MsgBoxStyle.Exclamation, "Error: 002")
        '   Return True
        '  End Try
        Return False
    End Function

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click
        'insert text into specified files:
        Dim i, j, k As Integer
        Dim NewFilename, SkippedChars, Directory As String
        'Abort and give error if the directory does not exist
        If DirTest() Then
            Exit Sub
        End If
        'get filenames and list of extensions.
        Dim Filenames() As String = IO.Directory.GetFiles(StartDir)
        Dim FileExtensions() As String = txt_Extensions.Text.ToLower().Split(","c)
        FileExtensions.Sort(FileExtensions)
        'array's to hold filenames that already exist, so they can be renamed later
        'as in adding 'test' to the files filename.txt and testfilename.txt
        'ensures that filename.txt is renamed after testfilename.txt
        Dim RenameLater() As String
        Dim PauseIndex() As Integer
        i = FileExtensions.BinarySearch(FileExtensions, Filenames(i).Substring(Filenames(i).LastIndexOf(".")))
        'renameing loop
        For i = 0 To Filenames.GetUpperBound(0)
            Try 'Try catches errors when the index of substring is greater than the filename length
                '###
                'If executes when file extention matches a filetype list 
                'item or when the filetype list is empty
                'And requires file to be unhidden, nonsystem, nondirectory, 
                'nontemporary, and not offline.
                If ((FileExtensions.BinarySearch(FileExtensions, Filenames(i).Substring(Filenames(i).LastIndexOf(".")).ToLower) > -1) Or (txt_Extensions.Text = "")) _
                     And (IO.File.GetAttributes(Filenames(i)) <> (IO.FileAttributes.Offline _
                     And IO.FileAttributes.Temporary _
                     And IO.FileAttributes.System _
                     And IO.FileAttributes.Directory _
                     And IO.FileAttributes.Hidden)) Then
                    'Get current filename
                    NewFilename = Filenames(i)
                    'seperate directory from filename
                    lst_output.Items.Add("Processing File: " & Filenames(i))
                    Directory = NewFilename.Substring(0, NewFilename.LastIndexOf("\"))
                    NewFilename = NewFilename.Substring(NewFilename.LastIndexOf("\"))
                    'reset skipped character string
                    SkippedChars = ""

                    'if the number of skipped characters is longer than the filname
                    'append the insert phrase to the end of the filename without
                    'changing the extension.
                    If CInt(ctl_FirstCharSkipNum.SelectedItem) < NewFilename.Length Then
                        For j = 0 To CInt(ctl_FirstCharSkipNum.SelectedIndex)
                            SkippedChars &= NewFilename.Chars(j)
                        Next
                    Else
                        SkippedChars = NewFilename.Substring(0, NewFilename.LastIndexOf(".") - 1)
                    End If
                    'set new filname
                    NewFilename = NewFilename.Substring(SkippedChars.Length + ctl_CharsToOverWriteNum.SelectedIndex)
                    NewFilename = SkippedChars & txt_Insert.Text & NewFilename
                    'if file already exists add file to list of files to be renamed later.
                    'else rename file now.
                    If IO.File.Exists(Directory & NewFilename) Then
                        ReDim Preserve RenameLater(k)
                        ReDim Preserve PauseIndex(k)
                        RenameLater(k) = Directory & NewFilename
                        PauseIndex(k) = i
                        k += 1
                        lst_output.Items.Add("Put file in rename line: " & RenameLater(k - 1))
                    Else
                        IO.File.Move(Filenames(i), Directory & NewFilename)
                        lst_output.Items.Add("Renamed file to: " & Directory & NewFilename)
                    End If
                End If
            Catch ex As Exception
                MsgBox("The File:" & Chr(13) & Filenames(i) & Chr(13) & "Could not be renamed.", MsgBoxStyle.Exclamation, "Error: 005")
            End Try
        Next
        'rename files whose new names already existed but are now available.
        Do While k > 0
            k -= 1
            Try
                IO.File.Move(Filenames(PauseIndex(k)), RenameLater(k))
                lst_output.Items.Add("Renamed list file to: " & RenameLater(k))
            Catch ex As IO.IOException
                MsgBox("Error Renameing File." & Chr(13) & " Cannot Rename file to a file that already exists.", MsgBoxStyle.Exclamation, "Error: 003")
            End Try
        Loop
    End Sub

    Private Sub btn_underscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_underscore.Click
        'Convert Underscores to spaces
        If DirTest() Then
            Exit Sub
        End If
        'get filenames and list of extensions.
        Dim Filenames() As String = IO.Directory.GetFiles(StartDir)
        Dim FileExtensions() As String = txt_Extensions.Text.ToLower().Split(","c)
        'counters for loops
        Dim i, j As Integer
        Dim NewFilename, Directory As String
        For i = 0 To Filenames.GetUpperBound(0)
            Try 'Try catches errors when the index of substring is greater than the filename length
                If (((FileExtensions.BinarySearch(FileExtensions, Filenames(i).Substring(Filenames(i).LastIndexOf(".")).ToLower) > -1) Or (txt_Extensions.Text = ""))) And (IO.File.GetAttributes(Filenames(i)) <> (IO.FileAttributes.System And IO.FileAttributes.Directory And IO.FileAttributes.Hidden)) Then
                    NewFilename = Filenames(i)
                    'seperate directory from filename and reset skipped character array.
                    lst_output.Items.Add("Processing File: " & Filenames(i))
                    Directory = NewFilename.Substring(0, NewFilename.LastIndexOf("\"))
                    NewFilename = NewFilename.Substring(NewFilename.LastIndexOf("\")).Replace("_", " ")
                    'if file exists, save for renameing later.
                    If IO.File.Exists(Directory & NewFilename) Then
                        lst_output.Items.Add("Could not rename file. File already exists.")
                    Else
                        IO.File.Move(Filenames(i), Directory & NewFilename)
                        lst_output.Items.Add("Renamed file to: " & Directory & NewFilename)
                    End If
                End If
            Catch ex As ArgumentOutOfRangeException
                MsgBox("A file is was shorter than" & Chr(13) & "the number of characters to overwrite.", MsgBoxStyle.Exclamation, "Error: 004")
            End Try
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Add spaces around dashes.
        If DirTest() Then
            Exit Sub
        End If
        'get filenames and list of extensions.
        Dim Filenames() As String = IO.Directory.GetFiles(StartDir)
        Dim FileExtensions() As String = txt_Extensions.Text.ToLower().Split(","c)
        FileExtensions.Sort(FileExtensions)
        'counters for loops
        Dim i, j As Integer
        Dim NewFilename, Directory As String
        For i = 0 To Filenames.GetUpperBound(0)
            Try 'Try catches errors when the index of substring is greater than the filename length
                If (((FileExtensions.BinarySearch(FileExtensions, Filenames(i).Substring(Filenames(i).LastIndexOf(".")).ToLower) > -1) Or (txt_Extensions.Text = ""))) And (IO.File.GetAttributes(Filenames(i)) <> (IO.FileAttributes.System And IO.FileAttributes.Directory And IO.FileAttributes.Hidden)) Then
                    NewFilename = Filenames(i)
                    'seperate directory from filename and reset skipped character array.
                    lst_output.Items.Add("Processing File: " & Filenames(i))
                    Directory = NewFilename.Substring(0, NewFilename.LastIndexOf("\"))
                    NewFilename = NewFilename.Substring(NewFilename.LastIndexOf("\")).Replace("-", " - ")
                    'if file exists, save for renameing later.
                    If IO.File.Exists(Directory & NewFilename) Then
                        lst_output.Items.Add("Could not rename file. File already exists.")
                    Else
                        IO.File.Move(Filenames(i), Directory & NewFilename)
                        lst_output.Items.Add("Renamed file to: " & Directory & NewFilename)
                    End If
                End If
            Catch ex As ArgumentOutOfRangeException
                MsgBox("A file is was shorter than the number" & Chr(13) & "of characters to overwrite.", MsgBoxStyle.Exclamation, "Error: 004")
            End Try
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Capitalize button
        If DirTest() Then
            Exit Sub
        End If
        'get filenames and list of extensions.
        Dim Filenames() As String = IO.Directory.GetFiles(StartDir)
        Dim FileExtensions() As String = txt_Extensions.Text.ToLower().Split(","c)
        FileExtensions.Sort(FileExtensions)
        'counters for loops
        Dim i, j As Integer
        Dim NFN, Directory, letter As String
        For i = 0 To Filenames.GetUpperBound(0)
            Try 'Try catches errors when the index of substring is greater than the filename length
                If (((FileExtensions.BinarySearch(FileExtensions, Filenames(i).Substring(Filenames(i).LastIndexOf(".")).ToLower) > -1) Or (txt_Extensions.Text = ""))) And (IO.File.GetAttributes(Filenames(i)) <> (IO.FileAttributes.System And IO.FileAttributes.Directory And IO.FileAttributes.Hidden)) Then
                    NFN = Filenames(i)
                    'seperate directory from filename and reset skipped character array.
                    lst_output.Items.Add("Processing File: " & Filenames(i))
                    Directory = NFN.Substring(0, NFN.LastIndexOf("\"))
                    NFN = NFN.Substring(NFN.LastIndexOf("\"))
                    'capitalize letters of all first words
                    NFN = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(NFN)
                    'extension to lower case
                    NFN = NFN.Substring(0, NFN.Length - 3) & (NFN.ToLower).Chars(NFN.Length - 3) & NFN.Substring(NFN.Length - 2)
                    IO.File.Move(Filenames(i), Directory & NFN)
                    lst_output.Items.Add("Renamed file to: " & Directory & NFN)
                End If

            Catch ex As ArgumentOutOfRangeException
                MsgBox("A file is was shorter than the number" & Chr(13) & "of characters to overwrite.", MsgBoxStyle.Exclamation, "Error: 004")
            End Try
        Next
    End Sub

    Private Sub txt_Insert_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Insert.TextChanged
        'show text character length
        TextBox1.Text = txt_Insert.TextLength
    End Sub

    Private Sub txt_CurrentFolder_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CurrentFolder.DoubleClick
        'select directory path when d-clicked.
        txt_CurrentFolder.SelectAll()
    End Sub

    Private Sub CBTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTop.CheckedChanged
        If CBTop.Checked = True Then
            MyBase.TopMost = True
        Else
            MyBase.TopMost = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Filename Fixer" & Chr(10) & "©Copyright 2006 Benjamin Roth" & Chr(10) _
        & "This program is free for personal use", MsgBoxStyle.Exclamation, "About This Awesome Program")
    End Sub
End Class
