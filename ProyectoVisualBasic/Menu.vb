Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formularioEstrctura As New Form1()
        formularioEstrctura.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FormAlgoritmos As New FormularioAlgoritmos()
        FormAlgoritmos.Show()
    End Sub
End Class