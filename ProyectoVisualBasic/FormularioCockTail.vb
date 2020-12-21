Public Class FormularioCockTail
    Dim arreglo As Integer()
    Dim tamaño As Integer
    Dim minimo As Integer
    Dim maximo As Integer
    Dim stopwatch As Stopwatch = New Stopwatch()
    Dim r As New Random()
    Private Sub FormularioCockTail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Function ImprimirArreglo(ByVal ParamArray arreglo() As Integer) As String
        Dim arreglostring As String = ""
        arreglostring = arreglostring & arreglo(0)
        For i As Integer = 1 To arreglo.Length - 1 Step +1
            arreglostring = arreglostring & "," & arreglo(i)
        Next
        Return arreglostring
    End Function

    Public Sub Ordenar()
        stopwatch = New Stopwatch()
        stopwatch.Restart()
        Dim derecha As Integer = arreglo.Length - 1
        Dim izquierda As Integer = 0
        Dim ultimo As Integer = 0
        Dim auxiliar As Integer = 0
        Dim comparaciones As Integer = 0
        Dim intercambios As Integer = 0

        Do
            For i As Integer = izquierda To derecha - 1 Step +1
                comparaciones = comparaciones + 1
                If arreglo(i) > arreglo(i + 1) Then
                    auxiliar = arreglo(i)
                    arreglo(i) = arreglo(i + 1)
                    arreglo(i + 1) = auxiliar
                    ultimo = i
                    intercambios = intercambios + 1
                End If
            Next

            derecha = ultimo

            For j As Integer = derecha To izquierda + 1 Step -1
                comparaciones = comparaciones - 1
                If (arreglo(j - 1) > arreglo(j)) Then
                    auxiliar = arreglo(j)
                    arreglo(j) = arreglo(j - 1)
                    arreglo(j - 1) = auxiliar
                    ultimo = j
                    intercambios = intercambios + 1
                End If
            Next

            izquierda = ultimo

        Loop While izquierda < derecha
        stopwatch.Stop()
        lblComparaciones.Text = comparaciones & ""
        lblIntercambios.Text = intercambios & ""
        lblTiempo.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
    End Sub

    Public Sub CrearArreglo(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        ReDim arreglo(tamaño - 1)
        For i As Integer = 0 To arreglo.Length - 1 Step +1
            arreglo(i) = r.Next(minimo, maximo)
        Next


    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            Dim maximo As Integer = txtMax.Text
            Dim minimo As Integer = txtMin.Text
            Dim tamaño As Integer = txTamaño.Text
            If minimo < 0 Then
                MessageBox.Show("El minimo no puede ser menor que 0")
                Return
            End If

            If tamaño < 0 Then

                MessageBox.Show("El tamaño no puede ser un numero negativo")
                Return
            End If

            If maximo <= minimo Then

                MessageBox.Show("El maximo debe de ser mayor que el minimo")
                Return
            End If
            txtMax.Clear()
            txtMin.Clear()
            txTamaño.Clear()
            CrearArreglo(tamaño, minimo, maximo)
            lblOriginal.Text = ImprimirArreglo(arreglo)
            Ordenar()
            lblOrdenado.Text = ImprimirArreglo(arreglo)

        Catch ex As Exception
            MessageBox.Show("Introduzca datos validos")
        End Try
    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Dim tamaño As Integer = r.Next(3, 20)
        Dim minimo As Integer = r.Next(0, 5)
        Dim maximo As Integer = r.Next(minimo, 25)
        CrearArreglo(tamaño, minimo, maximo)
        lblOriginal.Text = ImprimirArreglo(arreglo)
        Ordenar()
        lblOrdenado.Text = ImprimirArreglo(arreglo)
        txtMax.Clear()
        txtMin.Clear()
        txTamaño.Clear()
    End Sub
End Class