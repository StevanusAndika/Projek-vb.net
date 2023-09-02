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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtSelisih = New TextBox()
        DateLahir = New DateTimePicker()
        DateSekarang = New DateTimePicker()
        BtnHitung = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 15)
        Label1.TabIndex = 0
        Label1.Text = "APLIKASI HITUNG SELISIH UMUR DENGAN VB.NET"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 1
        Label2.Text = "TAHUN LAHIR"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 15)
        Label3.TabIndex = 2
        Label3.Text = "TAHUN SEKARANG"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(70, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 3
        Label4.Text = "SELISIH"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TxtSelisih
        ' 
        TxtSelisih.Location = New Point(199, 160)
        TxtSelisih.Name = "TxtSelisih"
        TxtSelisih.Size = New Size(247, 23)
        TxtSelisih.TabIndex = 4
        ' 
        ' DateLahir
        ' 
        DateLahir.Location = New Point(199, 94)
        DateLahir.Name = "DateLahir"
        DateLahir.Size = New Size(252, 23)
        DateLahir.TabIndex = 5
        ' 
        ' DateSekarang
        ' 
        DateSekarang.Location = New Point(199, 126)
        DateSekarang.Name = "DateSekarang"
        DateSekarang.Size = New Size(252, 23)
        DateSekarang.TabIndex = 6
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(199, 227)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(75, 23)
        BtnHitung.TabIndex = 7
        BtnHitung.Text = "Hitung"
        BtnHitung.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(314, 227)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(75, 23)
        BtnKeluar.TabIndex = 8
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnHitung)
        Controls.Add(DateSekarang)
        Controls.Add(DateLahir)
        Controls.Add(TxtSelisih)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "APLIKASI HITUNG SELISIH UMUR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSelisih As TextBox
    Friend WithEvents DateLahir As DateTimePicker
    Friend WithEvents DateSekarang As DateTimePicker
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnKeluar As Button
End Class
