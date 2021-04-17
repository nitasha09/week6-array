Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNamaHari(9) As String
        Dim n As Integer

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"
        strNamaHari(7) = "Nitasha"


        For n = 0 To 9
            lstbox.Items.Add(strNamaHari(n))
        Next


    End Sub
End Class
