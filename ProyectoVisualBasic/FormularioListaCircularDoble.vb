Public Class FormularioListaCircularDoble
    Dim n As NodoDoble
    Dim miLista As New ListaCircDoble()
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            Dim dato As Integer = txtDato.Text
            Dim resultado As Boolean = miLista.Buscar(dato)
            If (resultado = False) Then
                n = New NodoDoble()
                n.Dato = dato
                miLista.Agregar(n)
                lblLista.Text = miLista.ToString()
                txtDato.Clear()
                Return
            End If
            MessageBox.Show("El dato ya se encuentra dentro de la cola")
            txtDato.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido")
            txtDato.Clear()
        End Try
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de elementos en la lista : " & miLista.ContarNodos())
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim dato As Integer = txtDatoBorrar.Text
            Dim resultado As Boolean = miLista.Buscar(dato)
            If resultado = True Then
                miLista.Eliminar(dato)
                lblLista.Text = miLista.ToString()
            Else
                MessageBox.Show("El dato no se encuentra dentro de la lista")
            End If
            txtDatoBorrar.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido")
            txtDatoBorrar.Clear()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dato As Integer = txtDatoBuscar.Text
            Dim resultado As Boolean = miLista.Buscar(dato)
            If resultado = True Then
                MessageBox.Show("El dato se encuentra dentro de la lista")
            Else
                MessageBox.Show("El dato no se encuentra dentro de la lista")
            End If
            txtDatoBuscar.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido")
            txtDatoBuscar.Clear()
        End Try
    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        miLista.Head = Nothing
        MessageBox.Show("Lista eliminada")
        lblLista.Text = miLista.ToString()
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        Try
            Dim Dialogo As New FolderBrowserDialog()
            If Dialogo.ShowDialog() = DialogResult.OK Then
                Dim dato As String = lblLista.Text
                Dim nombreDelArchivo As String
                If txtArchivo.Text = "" Then
                    nombreDelArchivo = "ListaCircDoble"
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

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim Seleccionar As New OpenFileDialog
            If Seleccionar.ShowDialog = DialogResult.OK Then
                miLista.Head = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = FileIO.FileSystem.ReadAllText(ruta)
                Dim Lista() As String = linea.Split(",")
                Dim contador As Integer = 0
                For Each i As String In Lista
                    n = New NodoDoble()
                    n.Dato = Lista(contador)
                    miLista.Agregar(n)
                    contador = contador + 1
                Next

                lblLista.Text = miLista.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista")
            miLista.Head = Nothing
            lblLista.Text = miLista.ToString()
        End Try
    End Sub

    Private Sub FormularioListaCircularDoble_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class