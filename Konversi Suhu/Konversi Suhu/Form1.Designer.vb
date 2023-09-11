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
        VsSuhu = New VScrollBar()
        TxtCelcius = New TextBox()
        TxtFarenheit = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(251, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 22)
        Label1.TabIndex = 0
        Label1.Text = "konversi Celcius Ke Fahrenheit"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' VsSuhu
        ' 
        VsSuhu.Location = New Point(348, 66)
        VsSuhu.Name = "VsSuhu"
        VsSuhu.Size = New Size(27, 139)
        VsSuhu.TabIndex = 1
        ' 
        ' TxtCelcius
        ' 
        TxtCelcius.Location = New Point(222, 116)
        TxtCelcius.Name = "TxtCelcius"
        TxtCelcius.Size = New Size(100, 23)
        TxtCelcius.TabIndex = 2
        ' 
        ' TxtFarenheit
        ' 
        TxtFarenheit.Location = New Point(444, 116)
        TxtFarenheit.Name = "TxtFarenheit"
        TxtFarenheit.Size = New Size(100, 23)
        TxtFarenheit.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(232, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 22)
        Label2.TabIndex = 4
        Label2.Text = "Celcius"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(454, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 22)
        Label3.TabIndex = 5
        Label3.Text = "Farenheit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtFarenheit)
        Controls.Add(TxtCelcius)
        Controls.Add(VsSuhu)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Konversi Suhu Aplikasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents VsSuhu As VScrollBar
    Friend WithEvents TxtCelcius As TextBox
    Friend WithEvents TxtFarenheit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
