Public Class formularioCola
    Dim n As Nodo
    Dim miCola As New Cola
    Private Sub formularioCola_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnEncolar_Click(sender As Object, e As EventArgs) Handles btnEncolar.Click
        Try
            Dim dato As Integer = txtDato.Text
            n = New Nodo()
            n.Dato = dato
            miCola.Encolar(n)
            txtDato.Clear()
            lblCola.Text = miCola.ToString()
        Catch ex As Exception
            MessageBox.Show("Error al convertir el dato a entero")
        End Try
    End Sub

    Private Sub btnDesencolar_Click(sender As Object, e As EventArgs) Handles btnDesencolar.Click
        miCola.Desencolar()
        lblCola.Text = miCola.ToString()
    End Sub

    Private Sub btnFrente_Click(sender As Object, e As EventArgs) Handles btnFrente.Click
        MessageBox.Show("El dato al frente de la cola es : " & miCola.Font())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Dialogo As New FolderBrowserDialog
            If (Dialogo.ShowDialog() = DialogResult.OK) Then
                Dim dato As String = lblCola.Text
                Dim nombreDelArchivo As String
                If (txtArchivo.Text = "") Then
                    nombreDelArchivo = "Cola"
                Else
                    nombreDelArchivo = txtArchivo.Text
                End If
                Dim ruta As String = Dialogo.SelectedPath & "\\" & nombreDelArchivo & ".txt"
                FileIO.FileSystem.WriteAllText(ruta, dato, False)
                MessageBox.Show("Datos guardados en el archivo : " & nombreDelArchivo & ".txt")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar la cola")

        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim Seleccionar As New OpenFileDialog
            If (Seleccionar.ShowDialog() = DialogResult.OK) Then
                miCola.Head = Nothing
                miCola.Tail = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = FileIO.FileSystem.ReadAllText(ruta)
                Dim Cola() As String = linea.Split(",")
                Dim contador As Integer = 0
                For Each i As String In Cola
                    n = New Nodo
                    n.Dato = Cola(contador)
                    miCola.Encolar(n)
                    contador = contador + 1
                Next

                lblCola.Text = miCola.ToString()


            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la cola")
            miCola.Head = Nothing
            miCola.Tail = Nothing
            lblCola.Text = miCola.ToString()
        End Try
    End Sub

    Private Sub btnEliminarCola_Click(sender As Object, e As EventArgs) Handles btnEliminarCola.Click
        miCola.Head = Nothing
        miCola.Tail = Nothing
        lblCola.Text = miCola.ToString()
        MessageBox.Show("Cola eliminada")
    End Sub
End Class