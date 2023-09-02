Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim jumlah_tahun, jumlah_tahun2 As Integer
        jumlah_tahun = DateDiff("yyyy", DateLahir.Value, Now)
        jumlah_tahun2 = DateDiff("yyyy", DateSekarang.Value, Now)
        TxtSelisih.Text = jumlah_tahun - jumlah_tahun2





    End Sub

    Private Sub DateLahir_ValueChanged(sender As Object, e As EventArgs) Handles DateLahir.ValueChanged

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class
