Public Class FormularioListaDoble
    Dim n As NodoDoble
    Dim miLista As New ListaDoble()
    Private Sub FormularioListaDoble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim resultado As Boolean = miLista.BuscarDato(txtDato.Text)
            If (resultado = False) Then
                n = New NodoDoble
                n.Dato = txtDato.Text
                miLista.Insertar(n)
                lblLista.Text = miLista.ToString()
                txtDato.Clear()
                Return
            End If
            MessageBox.Show("El dato ya existe en la lista")
            txtDato.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido")
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim resultado As Boolean = miLista.BuscarDato(txtDatoBorrar.Text)
            If (resultado = True) Then
                miLista.Eliminar(txtDatoBorrar.Text)
                lblLista.Text = miLista.ToString()
            Else
                MessageBox.Show("El dato no se encuentra dentro de la lista")
            End If
            txtDatoBorrar.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim resultado As Boolean = miLista.BuscarDato(txtDatoBuscar.Text)
            If resultado = True Then
                MessageBox.Show("El dato se encuentra dentro de la lista")
            Else
                MessageBox.Show("El dato no se encuentra dentro de la lista")
            End If
            txtDatoBuscar.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de elementos dentro de la lista : " & miLista.ContadorNodos())
    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        miLista.Head = Nothing
        lblLista.Text = miLista.ToString()
        MessageBox.Show("Lista doble eliminada")
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        Try
            Dim Dialogo As New FolderBrowserDialog()
            If Dialogo.ShowDialog() = DialogResult.OK Then
                Dim dato As String = lblLista.Text
                Dim nombreDelArchivo As String
                If txtArchivo.Text = "" Then
                    nombreDelArchivo = "ListaDoble"
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
                    miLista.Insertar(n)
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

    Private Sub groupBox2_Enter(sender As Object, e As EventArgs) Handles groupBox2.Enter

    End Sub
End Class