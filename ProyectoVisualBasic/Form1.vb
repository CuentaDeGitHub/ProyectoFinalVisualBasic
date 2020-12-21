Public Class Form1

    Private Sub btnPila_Click(sender As Object, e As EventArgs) Handles btnPila.Click
        Dim formularioPila As New formularioPila
        formularioPila.Show()
    End Sub

    Private Sub btnCola_Click(sender As Object, e As EventArgs) Handles btnCola.Click
        Dim formularioCola As New formularioCola
        formularioCola.Show()
    End Sub

    Private Sub btnListaEnlazada_Click(sender As Object, e As EventArgs) Handles btnListaEnlazada.Click
        Dim formularioListaEnlazada As New formularioListaEnlazada
        formularioListaEnlazada.Show()
    End Sub

    Private Sub btnListaCirculard_Click(sender As Object, e As EventArgs) Handles btnListaCirculard.Click
        Dim formularioDeListaCircular As New formularioListaCircular
        formularioDeListaCircular.Show()
    End Sub

    Private Sub btnListaDoble_Click(sender As Object, e As EventArgs) Handles btnListaDoble.Click
        Dim formularioDeListaDoble As New FormularioListaDoble
        formularioDeListaDoble.Show()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Close()
    End Sub

    Private Sub btnListaCircDoble_Click(sender As Object, e As EventArgs) Handles btnListaCircDoble.Click
        Dim formularioListaCircDoble As New FormularioListaCircularDoble()
        formularioListaCircDoble.Show()
    End Sub

    Private Sub btnArbol_Click(sender As Object, e As EventArgs) Handles btnArbol.Click
        Dim arbol As New FormularioArbol()
        arbol.Show()
    End Sub

    Private Sub btnGrafo_Click(sender As Object, e As EventArgs) Handles btnGrafo.Click
        Dim grafo As New FormularioGrafo()
        grafo.Show()
    End Sub
End Class
