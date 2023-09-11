Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Event handler untuk saat form dimuat.
        ' Tidak ada kode yang dijalankan dalam event ini.
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Event handler untuk saat Label1 diklik.
        ' Tidak ada kode yang dijalankan dalam event ini.
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Event handler untuk saat Label3 diklik.
        ' Tidak ada kode yang dijalankan dalam event ini.
    End Sub

    Private Sub VsSuhu_Scroll(sender As Object, e As ScrollEventArgs) Handles VsSuhu.Scroll
        ' Event handler untuk saat TrackBar VsSuhu digeser.
        ' Di bawah ini, kita melakukan beberapa tindakan:

        ' Mengatur nilai minimum dan maksimum dari TrackBar VsSuhu.
        Me.VsSuhu.Minimum = 0
        Me.VsSuhu.Maximum = 109

        ' Memperbarui nilai yang ditampilkan di TextBox TxtCelcius dengan nilai dari TrackBar VsSuhu.
        Me.TxtCelcius.Text = Me.VsSuhu.Value.ToString

        ' Menghitung suhu dalam Fahrenheit dan menampilkannya di TextBox TxtFarenheit.
        Dim nilaiF As Double = (9 / 5 * Me.VsSuhu.Value) + 32
        Me.TxtFarenheit.Text = nilaiF.ToString
    End Sub

    Private Sub TxtCelcius_TextChanged(sender As Object, e As EventArgs) Handles TxtCelcius.TextChanged
        ' Event handler untuk saat teks dalam TextBox TxtCelcius berubah.
        ' Di bawah ini, kita melakukan beberapa tindakan:

        ' Mengambil nilai Celcius yang dimasukkan oleh pengguna dari TextBox.
        Dim nilaiC As Double
        Dim nilaiF As Double
        nilaiC = Me.TxtCelcius.Text

        ' Menghitung suhu dalam Fahrenheit berdasarkan nilai Celcius yang dimasukkan.
        nilaiF = (9 / 5 * nilaiC + 32)

        ' Jika nilai Celcius yang dimasukkan kurang dari 0, maka program keluar.
        If nilaiC < 0 Then
            Exit Sub
        End If

        ' Memperbarui nilai TrackBar VsSuhu dan TextBox TxtFarenheit.
        Me.VsSuhu.Value = nilaiC
        Me.TxtFarenheit.Text = nilaiF.ToString
    End Sub

    Private Sub TxtFarenheit_TextChanged(sender As Object, e As EventArgs) Handles TxtFarenheit.TextChanged
        ' Event handler untuk saat teks dalam TextBox TxtFarenheit berubah.
        ' Di bawah ini, kita melakukan beberapa tindakan:

        ' Mengambil nilai Fahrenheit yang dimasukkan oleh pengguna dari TextBox.
        Dim nilaiC As Double
        Dim nilaiF As Double
        nilaiF = Me.TxtCelcius.Text

        ' Menghitung suhu dalam Celcius berdasarkan nilai Fahrenheit yang dimasukkan.
        nilaiC = (nilaiF - 32) * 5 / 9

        ' Jika nilai Celcius yang dihitung kurang dari 0, maka program keluar.
        If nilaiC < 0 Then
            Exit Sub
        End If

        ' Tidak ada tindakan lain yang diambil dalam event ini.
    End Sub
End Class
