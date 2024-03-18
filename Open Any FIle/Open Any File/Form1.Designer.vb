<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        LbFilePath = New Label()
        GroupBox1 = New GroupBox()
        BtnBrowse = New Button()
        BtnExcel = New Button()
        BtnWord = New Button()
        BtnNotepad = New Button()
        Label2 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        BtnPPT = New Button()
        BtnCode = New Button()
        BtnUnzip = New Button()
        BtnPDF = New Button()
        BtnImage = New Button()
        BtnAudio = New Button()
        BtnVideo = New Button()
        BtnAccess = New Button()
        BtnVisio = New Button()
        BtnProject = New Button()
        Button1 = New Button()
        BtnGitbash = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(258, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 23)
        Label1.TabIndex = 0
        Label1.Text = "Open Any File Exe"
        ' 
        ' LbFilePath
        ' 
        LbFilePath.AutoSize = True
        LbFilePath.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LbFilePath.Location = New Point(258, 84)
        LbFilePath.Name = "LbFilePath"
        LbFilePath.Size = New Size(190, 17)
        LbFilePath.TabIndex = 1
        LbFilePath.Text = "Click the browse to locate a file"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(240, 115)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(502, 87)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "local Disk Path"
        ' 
        ' BtnBrowse
        ' 
        BtnBrowse.Location = New Point(240, 208)
        BtnBrowse.Name = "BtnBrowse"
        BtnBrowse.Size = New Size(75, 23)
        BtnBrowse.TabIndex = 3
        BtnBrowse.Text = "browse"
        BtnBrowse.UseVisualStyleBackColor = True
        ' 
        ' BtnExcel
        ' 
        BtnExcel.Location = New Point(220, 292)
        BtnExcel.Name = "BtnExcel"
        BtnExcel.Size = New Size(75, 23)
        BtnExcel.TabIndex = 4
        BtnExcel.Text = "Excel"
        BtnExcel.UseVisualStyleBackColor = True
        ' 
        ' BtnWord
        ' 
        BtnWord.Location = New Point(300, 292)
        BtnWord.Name = "BtnWord"
        BtnWord.Size = New Size(75, 23)
        BtnWord.TabIndex = 5
        BtnWord.Text = "Word"
        BtnWord.UseVisualStyleBackColor = True
        ' 
        ' BtnNotepad
        ' 
        BtnNotepad.Location = New Point(381, 292)
        BtnNotepad.Name = "BtnNotepad"
        BtnNotepad.Size = New Size(75, 23)
        BtnNotepad.TabIndex = 6
        BtnNotepad.Text = "Notepad"
        BtnNotepad.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(230, 252)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 7
        Label2.Text = "Open With"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' BtnPPT
        ' 
        BtnPPT.Location = New Point(462, 292)
        BtnPPT.Name = "BtnPPT"
        BtnPPT.Size = New Size(75, 23)
        BtnPPT.TabIndex = 8
        BtnPPT.Text = "PPT"
        BtnPPT.UseVisualStyleBackColor = True
        ' 
        ' BtnCode
        ' 
        BtnCode.Location = New Point(543, 292)
        BtnCode.Name = "BtnCode"
        BtnCode.Size = New Size(75, 23)
        BtnCode.TabIndex = 9
        BtnCode.Text = "Code"
        BtnCode.UseVisualStyleBackColor = True
        ' 
        ' BtnUnzip
        ' 
        BtnUnzip.Location = New Point(219, 334)
        BtnUnzip.Name = "BtnUnzip"
        BtnUnzip.Size = New Size(75, 23)
        BtnUnzip.TabIndex = 10
        BtnUnzip.Text = "Rar/zip"
        BtnUnzip.UseVisualStyleBackColor = True
        ' 
        ' BtnPDF
        ' 
        BtnPDF.Location = New Point(300, 334)
        BtnPDF.Name = "BtnPDF"
        BtnPDF.Size = New Size(75, 23)
        BtnPDF.TabIndex = 11
        BtnPDF.Text = "PDF"
        BtnPDF.UseVisualStyleBackColor = True
        ' 
        ' BtnImage
        ' 
        BtnImage.Location = New Point(381, 334)
        BtnImage.Name = "BtnImage"
        BtnImage.Size = New Size(75, 23)
        BtnImage.TabIndex = 12
        BtnImage.Text = "Image"
        BtnImage.UseVisualStyleBackColor = True
        ' 
        ' BtnAudio
        ' 
        BtnAudio.Location = New Point(462, 334)
        BtnAudio.Name = "BtnAudio"
        BtnAudio.Size = New Size(75, 23)
        BtnAudio.TabIndex = 13
        BtnAudio.Text = "Audio"
        BtnAudio.UseVisualStyleBackColor = True
        ' 
        ' BtnVideo
        ' 
        BtnVideo.Location = New Point(543, 334)
        BtnVideo.Name = "BtnVideo"
        BtnVideo.Size = New Size(75, 23)
        BtnVideo.TabIndex = 14
        BtnVideo.Text = "Video"
        BtnVideo.UseVisualStyleBackColor = True
        ' 
        ' BtnAccess
        ' 
        BtnAccess.Location = New Point(219, 377)
        BtnAccess.Name = "BtnAccess"
        BtnAccess.Size = New Size(75, 23)
        BtnAccess.TabIndex = 15
        BtnAccess.Text = "Access"
        BtnAccess.UseVisualStyleBackColor = True
        ' 
        ' BtnVisio
        ' 
        BtnVisio.Location = New Point(300, 377)
        BtnVisio.Name = "BtnVisio"
        BtnVisio.Size = New Size(75, 23)
        BtnVisio.TabIndex = 16
        BtnVisio.Text = "Visio"
        BtnVisio.UseVisualStyleBackColor = True
        ' 
        ' BtnProject
        ' 
        BtnProject.Location = New Point(381, 377)
        BtnProject.Name = "BtnProject"
        BtnProject.Size = New Size(75, 23)
        BtnProject.TabIndex = 17
        BtnProject.Text = "Project"
        BtnProject.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(462, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 18
        Button1.Text = "Project"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnGitbash
        ' 
        BtnGitbash.Location = New Point(543, 377)
        BtnGitbash.Name = "BtnGitbash"
        BtnGitbash.Size = New Size(75, 23)
        BtnGitbash.TabIndex = 19
        BtnGitbash.Text = "Git Bash"
        BtnGitbash.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(861, 450)
        Controls.Add(BtnGitbash)
        Controls.Add(Button1)
        Controls.Add(BtnProject)
        Controls.Add(BtnVisio)
        Controls.Add(BtnAccess)
        Controls.Add(BtnVideo)
        Controls.Add(BtnAudio)
        Controls.Add(BtnImage)
        Controls.Add(LbFilePath)
        Controls.Add(BtnPDF)
        Controls.Add(BtnUnzip)
        Controls.Add(BtnCode)
        Controls.Add(BtnPPT)
        Controls.Add(Label2)
        Controls.Add(BtnNotepad)
        Controls.Add(BtnWord)
        Controls.Add(BtnExcel)
        Controls.Add(BtnBrowse)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Aplikasi Baca File"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LbFilePath As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnWord As Button
    Friend WithEvents BtnNotepad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnPPT As Button
    Friend WithEvents BtnCode As Button
    Friend WithEvents BtnUnzip As Button
    Friend WithEvents BtnPDF As Button
    Friend WithEvents BtnImage As Button
    Friend WithEvents BtnAudio As Button
    Friend WithEvents BtnVideo As Button
    Friend WithEvents BtnAccess As Button
    Friend WithEvents BtnVisio As Button
    Friend WithEvents BtnProject As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnGitbash As Button

End Class
