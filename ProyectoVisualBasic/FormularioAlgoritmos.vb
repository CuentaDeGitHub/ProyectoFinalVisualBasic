Public Class FormularioAlgoritmos
    Private Sub btnCounting_Click(sender As Object, e As EventArgs) Handles btnCounting.Click
        Dim FormCounting As New FormularioCountingSort()
        FormCounting.Show()
    End Sub

    Private Sub btnBubble_Click(sender As Object, e As EventArgs) Handles btnBubble.Click
        Dim Burbuja As New FormularioBurbuja()
        Burbuja.Show()
    End Sub

    Private Sub btnCocktail_Click(sender As Object, e As EventArgs) Handles btnCocktail.Click
        Dim CockTail As New FormularioCockTail()
        CockTail.Show()
    End Sub

    Private Sub btnShell_Click(sender As Object, e As EventArgs) Handles btnShell.Click
        Dim Shell As New FormularioShell()
        Shell.Show()
    End Sub

    Private Sub btnRadix_Click(sender As Object, e As EventArgs) Handles btnRadix.Click
        Dim Radix As New FormularioRadix()
        Radix.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Insertion As New Formularioinsertion()
        Insertion.Show()
    End Sub
End Class