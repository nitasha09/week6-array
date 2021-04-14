Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim strNamaHari(6) As String
        Dim n As Integer

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"

        Array.Reverse(strNamaHari)
        For n = 0 To 6
            lstbox.Items.Add(strNamaHari(n))
        Next
    End Sub
End Class
