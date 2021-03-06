﻿Public Class formularioListaCircular
    Dim n As Nodo
    Dim miListaCircular As New ListaCircular()
    Private Sub formularioListaCircular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            Dim resultado As Boolean = miListaCircular.BuscarDato(txtDato.Text)
            If resultado = False Then
                n = New Nodo()
                n.Dato = txtDato.Text
                miListaCircular.Agregar(n)
                lblLista.Text = miListaCircular.ToString()
                txtDato.Clear()
            Else
                MessageBox.Show("El dato ya se encuentra dentro de la lista")
            End If
            txtDato.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido")
            txtDato.Clear()
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            Dim dato As Integer = txtDatoBorrar.Text
            Dim resultado As Boolean = miListaCircular.BuscarDato(dato)
            If resultado = False Then
                MessageBox.Show("El dato no se encuentra dentro de la lista")
            Else
                miListaCircular.Borrar(dato)
                lblLista.Text = miListaCircular.ToString()
            End If
            txtDatoBorrar.Clear()
        Catch ex As Exception
            MessageBox.Show("Introduzca un dato valido para borrar")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dato As Integer = txtDatoBuscar.Text
        Dim resultado As Boolean = miListaCircular.BuscarDato(dato)
        If (resultado = True) Then
            MessageBox.Show("El dato se encuentra dentro de la lista")
        Else
            MessageBox.Show("El dato no se encuentra dentro de la lista")
        End If
        txtDatoBuscar.Clear()
    End Sub

    Private Sub btnEliminarLista_Click(sender As Object, e As EventArgs) Handles btnEliminarLista.Click
        miListaCircular.Head = Nothing
        lblLista.Text = miListaCircular.ToString()
        MessageBox.Show("Cola circular eliminada")
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        MessageBox.Show("Numero de nodos en la lista : " & miListaCircular.ContarNodos())
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        Try
            Dim Dialogo As New FolderBrowserDialog()
            If Dialogo.ShowDialog() = DialogResult.OK Then
                Dim dato As String = lblLista.Text
                Dim nombreDelArchivo As String
                If txtArchivo.Text = "" Then
                    nombreDelArchivo = "ListaCircular"
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
                miListaCircular.Head = Nothing
                Dim ruta As String = Seleccionar.FileName
                Dim linea As String = FileIO.FileSystem.ReadAllText(ruta)
                Dim Lista() As String = linea.Split(",")
                Dim contador As Integer = 0
                For Each i As String In Lista
                    n = New Nodo()
                    n.Dato = Lista(contador)
                    miListaCircular.Agregar(n)
                    contador = contador + 1
                Next

                lblLista.Text = miListaCircular.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista")
            miListaCircular.Head = Nothing
            lblLista.Text = miListaCircular.ToString()
        End Try
    End Sub
End Class