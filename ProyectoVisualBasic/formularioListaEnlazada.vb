Public Class formularioListaEnlazada
    Dim n As Nodo
    Dim miListaEnlazada As New ListaEnlazada
    Private Sub formularioListaEnlazada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub btnIntroducir_Click(sender As Object, e As EventArgs) Handles btnIntroducir.Click

        Try
            Dim resultado As Boolean = miListaEnlazada.Buscar(txtDato.Text)
            If resultado = False Then
                Dim n As New Nodo()
                n.Dato = txtDato.Text
                miListaEnlazada.Agregar(n)
                lblListaEnlazada.Text = miListaEnlazada.ToString()
                txtDato.Clear()
                Return
            End If
            MessageBox.Show("El dato ya existe dentro de la lista")
            txtDato.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido")
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim resultado As Boolean = miListaEnlazada.Buscar(txtBorrar.Text)
            If resultado = False Then
                MessageBox.Show("El dato no se encuentra dentro de la lista")
                txtBorrar.Clear()
                Return
            End If
            miListaEnlazada.Borrar(txtBorrar.Text)
            lblListaEnlazada.Text = miListaEnlazada.ToString()
            txtBorrar.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un numero valido para eliminar")
        End Try


    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de elementos dentro de la lista : " & miListaEnlazada.ContarNodos())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Dialogo As New FolderBrowserDialog()
            If Dialogo.ShowDialog() = DialogResult.OK Then
                Dim dato As String = lblListaEnlazada.Text
                Dim nombreDelArchivo As String
                If txtArchivo.Text = "" Then
                    nombreDelArchivo = "ListaEnlazada"
                Else
                    nombreDelArchivo = txtArchivo.Text
                End If
                Dim ruta As String = Dialogo.SelectedPath & "\\" & nombreDelArchivo & ".txt"
                FileIO.FileSystem.WriteAllText(ruta, dato, False)
                MessageBox.Show("Datos guardados en el archivo : " & nombreDelArchivo & ".txt")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar la lista")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim resultado As Boolean = miListaEnlazada.Buscar(txtBuscar.Text)
            If resultado = True Then
                MessageBox.Show("El dato se encuentra dentro de la lista")
                txtBuscar.Clear()
                Return
            End If
            MessageBox.Show("El dato no se encuentra dentro de la lista")
            txtBuscar.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido para buscar")
            txtBuscar.Clear()
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim Seleccionar As New OpenFileDialog
            If Seleccionar.ShowDialog = DialogResult.OK Then
                miListaEnlazada.Head = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = FileIO.FileSystem.ReadAllText(ruta)
                Dim Lista() As String = linea.Split(",")
                Dim contador As Integer = 0
                For Each i As String In Lista
                    n = New Nodo()
                    n.Dato = Lista(contador)
                    miListaEnlazada.Agregar(n)
                    contador = contador + 1
                Next
                lblListaEnlazada.Text = miListaEnlazada.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista")
            miListaEnlazada.Head = Nothing
            lblListaEnlazada.Text = miListaEnlazada.ToString()
        End Try
    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        miListaEnlazada.Head = Nothing
        lblListaEnlazada.Text = miListaEnlazada.ToString()
        MessageBox.Show("Lista eliminadda")
    End Sub
End Class