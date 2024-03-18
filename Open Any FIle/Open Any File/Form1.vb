Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        OpenFileDialog1.ShowDialog()
        LbFilePath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        Dim excelPath As String = "C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE"
        If System.IO.File.Exists(excelPath) Then
            Process.Start(excelPath, LbFilePath.Text)
        Else
            MessageBox.Show("Error: Microsoft Excel tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnWord_Click(sender As Object, e As EventArgs) Handles BtnWord.Click
        Try
            Dim wordPath As String = "C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE"
            If System.IO.File.Exists(wordPath) Then
                Process.Start(wordPath, """" & LbFilePath.Text & """")
            Else
                MessageBox.Show("Error: Microsoft Word tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Failed to open the file with Microsoft Word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNotepad_Click(sender As Object, e As EventArgs) Handles BtnNotepad.Click
        Try
            ' Mencoba membuka file dengan Notepad
            Process.Start("notepad.exe", LbFilePath.Text)
        Catch ex As Exception
            ' Menampilkan pesan kesalahan jika Notepad tidak ditemukan
            MessageBox.Show("Error:Notepad tidak ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub BtnCode_Click(sender As Object, e As EventArgs) Handles BtnCode.Click
        Try
            Dim vsCodePath As String = "C:\Users\Stevanus\AppData\Local\Programs\Microsoft VS Code\Code.exe" ' Sesuaikan dengan lokasi instalasi VS Code di komputer Anda
            If System.IO.File.Exists(vsCodePath) Then
                Process.Start(vsCodePath, """" & LbFilePath.Text & """")
            Else
                MessageBox.Show("Error: Visual Studio Code tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Gagal membuka file dengan Visual Studio Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPPT_Click(sender As Object, e As EventArgs) Handles BtnPPT.Click
        Try
            Dim PPTPath As String = "C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE"
            If System.IO.File.Exists(PPTPath) Then
                Process.Start(PPTPath, """" & LbFilePath.Text & """")
            Else
                MessageBox.Show("Error: Microsoft Power point tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Failed to open the file with Microsoft Power Point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUnzip_Click(sender As Object, e As EventArgs) Handles BtnUnzip.Click
        Try
            ' Lokasi eksekutor WinRAR
            Dim rarPath As String = "C:\Program Files\WinRAR\WinRAR.exe" ' Sesuaikan dengan lokasi instalasi WinRAR di komputer Anda

            ' Periksa apakah WinRAR ada di lokasi yang ditentukan
            If System.IO.File.Exists(rarPath) Then
                ' Lokasi tempat Anda ingin mengekstrak file
                Dim extractPath As String = "C:\Temp\" ' Sesuaikan dengan lokasi ekstraksi yang Anda inginkan

                ' Periksa apakah direktori ekstraksi ada atau tidak, jika tidak, buat satu
                If Not System.IO.Directory.Exists(extractPath) Then
                    System.IO.Directory.CreateDirectory(extractPath)
                End If

                ' Memanggil WinRAR dengan parameter untuk mengekstrak file
                Dim arguments As String = "x """ & LbFilePath.Text & """ """ & extractPath & """"
                Process.Start(rarPath, arguments)
            Else
                MessageBox.Show("Error: WinRAR tidak ada dalam sistem Anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Gagal mengekstrak file RAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click
        Try
            ' Path untuk Google Chrome atau Microsoft Edge
            Dim browserPath = ""

            ' Periksa apakah Google Chrome terpasang
            If IO.File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
                browserPath = "C:\Program Files\Google\Chrome\Application\chrome.exe"
            ElseIf IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
                browserPath = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            End If

            ' Jika Google Chrome tidak ada, coba Microsoft Edge
            If browserPath = "" AndAlso IO.File.Exists("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then
                browserPath = "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
            ElseIf browserPath = "" AndAlso IO.File.Exists("C:\Program Files\Microsoft\Edge\Application\msedge.exe") Then
                browserPath = "C:\Program Files\Microsoft\Edge\Application\msedge.exe"
            End If

            ' Jika browser ditemukan, buka PDF menggunakan browser tersebut
            If browserPath <> "" Then
                Process.Start(browserPath, """" & LbFilePath.Text & """")
            Else
                MessageBox.Show("Error: Google Chrome atau Microsoft Edge tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Gagal membuka file PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnImage_Click(sender As Object, e As EventArgs) Handles BtnImage.Click
        Try
            ' Path untuk Google Chrome
            Dim chromePath As String = ""

            ' Periksa apakah Google Chrome terpasang
            If IO.File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
                chromePath = "C:\Program Files\Google\Chrome\Application\chrome.exe"
            ElseIf IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
                chromePath = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            End If

            ' Jika Google Chrome terdeteksi, buka gambar dengan Google Chrome
            If chromePath <> "" Then
                Process.Start(chromePath, "file:///" & LbFilePath.Text)
            Else
                MessageBox.Show("Error: Google Chrome tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Gagal membuka gambar dengan Google Chrome.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAudio_Click(sender As Object, e As EventArgs) Handles BtnAudio.Click
        Try
            ' Path untuk Google Chrome
            Dim chromePath As String = ""

            ' Periksa apakah Google Chrome terpasang
            If IO.File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
                chromePath = "C:\Program Files\Google\Chrome\Application\chrome.exe"
            ElseIf IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
                chromePath = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            End If

            ' Jika Google Chrome terdeteksi, buka audio dengan Google Chrome
            If chromePath <> "" Then
                Process.Start(chromePath, "file:///" & LbFilePath.Text)
            Else
                MessageBox.Show("Error: Google Chrome tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Gagal membuka audio dengan Google Chrome.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnVideo_Click(sender As Object, e As EventArgs) Handles BtnVideo.Click
        Try
            ' Path untuk Google Chrome
            Dim chromePath As String = ""

            ' Periksa apakah Google Chrome terpasang
            If IO.File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then
                chromePath = "C:\Program Files\Google\Chrome\Application\chrome.exe"
            ElseIf IO.File.Exists("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
                chromePath = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            End If

            ' Jika Google Chrome terdeteksi, buka video dengan Google Chrome
            If chromePath <> "" Then
                Process.Start(chromePath, "file:///" & LbFilePath.Text)
            Else
                MessageBox.Show("Error: Google Chrome tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Gagal membuka video dengan Google Chrome.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAccess_Click(sender As Object, e As EventArgs) Handles BtnAccess.Click
        Dim AccessPath As String = "C:\Program Files\Microsoft Office\root\Office16\MSACCESS.EXE"
        If System.IO.File.Exists(AccessPath) Then
            Process.Start(AccessPath, LbFilePath.Text)
        Else
            MessageBox.Show("Error: Microsoft Access tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnVisio_Click(sender As Object, e As EventArgs) Handles BtnVisio.Click
        Dim VisioPath As String = "C:\Program Files\Microsoft Office\root\Office16\VISIO.EXE"
        If System.IO.File.Exists(VisioPath) Then
            Process.Start(VisioPath, LbFilePath.Text)
        Else
            MessageBox.Show("Error: Microsoft visio tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnProject_Click(sender As Object, e As EventArgs) Handles BtnProject.Click
        Dim ProjectPath = "C:\Program Files\Microsoft Office\root\Office16\WINPROJ.EXE"
        If IO.File.Exists(ProjectPath) Then
            Process.Start(ProjectPath, LbFilePath.Text)
        Else
            MessageBox.Show("Error: Microsoft Project tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnGitbash_Click(sender As Object, e As EventArgs) Handles BtnGitbash.Click
        Dim ProjectPath = "C:\Program Files\Git\git-bash.exe"
        If IO.File.Exists(ProjectPath) Then
            Process.Start(ProjectPath, LbFilePath.Text)
        Else
            MessageBox.Show("Error: Git bash tidak ada dalam sistem anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class


