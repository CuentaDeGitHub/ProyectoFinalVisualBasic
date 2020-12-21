Public Class FormularioShell
    Dim r As New Random()
    Dim arreglo As Integer()
    Dim stopwatch As Stopwatch = New Stopwatch()

    Public Sub CrearArreglo(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        ReDim arreglo(0 To tamaño - 1)
        For i As Integer = 0 To arreglo.Length - 1 Step +1
            arreglo(i) = r.Next(minimo, maximo)
        Next
    End Sub
    Public Function ImprimirArreglo() As String
        Dim arreglostring As String = ""
        arreglostring = arreglostring & arreglo(0)
        For i As Integer = 1 To arreglo.Length - 1 Step +1
            arreglostring = arreglostring & "," & arreglo(i)
        Next
        Return arreglostring
    End Function
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            Dim tamaño As Integer = txTamaño.Text
            Dim minimo As Integer = txtMin.Text
            Dim maximo As Integer = txtMax.Text
            If (tamaño <= 0) Then
                MessageBox.Show("El tamaño no puede ser menor o igual a 0")
                Return
            End If

            If (maximo <= minimo) Then
                MessageBox.Show("El maximo no puede ser igual o menor que el minimo")
                Return
            End If

            txtMin.Clear()
            txtMax.Clear()
            txTamaño.Clear()
            CrearArreglo(tamaño, minimo, maximo)
            lblOriginal.Text = ImprimirArreglo()
            OrdenarShell()
            lblOrdenado.Text = ImprimirArreglo()

        Catch ex As Exception
            MessageBox.Show("Introduzca datos validos")
        End Try
    End Sub
    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Dim tamaño As Integer = r.Next(1, 18)
        Dim minimo As Integer = r.Next(0, 50)
        Dim maximo As Integer = r.Next(minimo, 100)
        CrearArreglo(tamaño, minimo, maximo)
        lblOriginal.Text = ImprimirArreglo()
        OrdenarShell()
        lblOrdenado.Text = ImprimirArreglo()
    End Sub

    Public Sub OrdenarShell()
        stopwatch.Restart()
        Dim salto As Integer = 0
        Dim sw As Integer = 0
        Dim auxiliar As Integer = 0
        Dim e As Integer = 0
        Dim pasadas As Integer = 0
        salto = arreglo.Length / 2

        While (salto > 0)
            sw = 1
            While (sw <> 0)
                sw = 0
                e = 1
                While e <= arreglo.Length - salto
                    If arreglo(e - 1) > arreglo(e - 1 + salto) Then
                        auxiliar = arreglo(e - 1 + salto)
                        arreglo(e - 1 + salto) = arreglo(e - 1)
                        arreglo(e - 1) = auxiliar
                        sw = 1
                    End If
                    e = e + 1
                    pasadas = pasadas + 1

                End While
            End While
            salto = salto / 2
        End While
        stopwatch.Stop()
        lblTiempo.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        lblIteraciones.Text = pasadas & ""


    End Sub
End Class