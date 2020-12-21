
Public Class formularioPila
    Dim n As Nodo
    Dim miPila As New Pila
    Private Sub formularioPila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub



    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Try
            Dim dato As Integer = txtDato.Text
            n = New Nodo()
            n.Dato = dato
            miPila.Push(n)
            txtDato.Clear()
            lblPila.Text = miPila.ToString

        Catch ex As Exception
            txtDato.Clear()
            MessageBox.Show("Error al convertir el dato a entero")
        End Try

    End Sub

    Private Sub lblPila_Click(sender As Object, e As EventArgs) Handles lblPila.Click

    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        n = New Nodo()
        n = miPila.Pop
        MessageBox.Show("Dato eliminado de la pila " & n.Dato)
        lblPila.Text = miPila.ToString()

    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        MessageBox.Show("Numero de elementos en la pila : " & miPila.Count)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Dialogo As New FolderBrowserDialog
            If (Dialogo.ShowDialog() = DialogResult.OK) Then
                Dim dato As String = lblPila.Text
                Dim nombreDelArchivo As String
                If (txtArchivo.Text = "") Then
                    nombreDelArchivo = "Pila"
                Else
                    nombreDelArchivo = txtArchivo.Text
                End If
                Dim ruta As String = Dialogo.SelectedPath & "\\" & nombreDelArchivo & ".txt"
                FileIO.FileSystem.WriteAllText(ruta, dato, False)
                MessageBox.Show("Datos guardados en el archivo : " & nombreDelArchivo & ".txt")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar la pila")
        End Try


    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try

            Dim Seleccionar As New OpenFileDialog
            If (Seleccionar.ShowDialog() = DialogResult.OK) Then
                miPila.Top = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = FileIO.FileSystem.ReadAllText(ruta)
                Dim Pila() As String = linea.Split(",")
                Dim contador As Integer = Pila.Length - 1
                For Each i As String In Pila
                    n = New Nodo
                    n.Dato = Pila(contador)
                    miPila.Push(n)
                    contador = contador - 1
                Next
                lblPila.Text = miPila.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la pila")
            miPila.Top = Nothing
            lblPila.Text = miPila.ToString()
        End Try
    End Sub

    Private Sub btnEliminarCola_Click(sender As Object, e As EventArgs) Handles btnEliminarCola.Click
        miPila.Top = Nothing
        lblPila.Text = miPila.ToString()
        MessageBox.Show("Pila eliminada")
    End Sub
End Class