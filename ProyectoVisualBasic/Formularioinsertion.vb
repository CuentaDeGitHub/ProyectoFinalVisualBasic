Public Class Formularioinsertion

    Dim comparaciones As Integer
    Dim arreglo As Integer()
    Dim r As New Random()
    Dim stopwatch As Stopwatch = New Stopwatch()
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            Dim tamaño As Integer = txtTamaño.Text
            Dim minimo As Integer = txtMinimo.Text
            Dim maximo As Integer = txtMaximo.Text
            If (tamaño <= 0) Then
                MessageBox.Show("El tamaño no puede ser menor o igual a 0")
                Return
            End If

            If (maximo <= minimo) Then
                MessageBox.Show("El maximo no puede ser igual o menor que el minimo")
                Return
            End If

            txtMinimo.Clear()
            txtMaximo.Clear()
            txtTamaño.Clear()
            crearArreglo(tamaño, minimo, maximo)
            Ordenar(arreglo)

        Catch ex As Exception
            MessageBox.Show("Introduzca datos validos")
        End Try
    End Sub

    Public Sub Ordenar(ByVal arreglo() As Integer)
        lblArregloOriginal.Text = MostrarLista()
        comparaciones = 0
        stopwatch.Restart()

        Dim n As Integer = arreglo.Length
        For i As Integer = 1 To n - 1
            Dim key As Integer = arreglo(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso arreglo(j) > key
                comparaciones += 1
                arreglo(j + 1) = arreglo(j)
                j = j - 1
            End While
            arreglo(j + 1) = key
        Next

        stopwatch.Stop()
        lblArregloOrdenado.Text = MostrarLista()
        lblTiempo.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        lblComparaciones.Text = Integer.Parse(comparaciones)


    End Sub

    Public Sub crearArreglo(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        ReDim arreglo(0 To tamaño - 1)
        For i As Integer = 0 To arreglo.Length - 1 Step +1
            arreglo(i) = r.Next(minimo, maximo)
        Next
    End Sub

    Public Function MostrarLista() As String
        Dim arreglostring As String = ""
        arreglostring = arreglostring & arreglo(0)
        For i As Integer = 1 To arreglo.Length - 1 Step +1
            arreglostring = arreglostring & "," & arreglo(i)
        Next
        Return arreglostring

    End Function

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Dim tamaño As Integer = r.Next(1, 18)
        Dim minimo As Integer = r.Next(0, 50)
        Dim maximo As Integer = r.Next(minimo, 100)
        crearArreglo(tamaño, minimo, maximo)
        Ordenar(arreglo)
    End Sub
End Class