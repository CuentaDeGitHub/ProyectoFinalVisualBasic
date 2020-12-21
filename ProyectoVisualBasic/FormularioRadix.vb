Public Class FormularioRadix
    Dim arreglo As Integer()
    Dim r As New Random()
    Dim stopwatch As New Stopwatch()
    Dim tamaño As Integer
    Dim minimo As Integer
    Dim maximo As Integer

    Private Sub FormularioRadix_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function ImprimirArreglo() As String
        Dim arreglostring As String = ""
        arreglostring = arreglostring & arreglo(0)
        For i As Integer = 1 To arreglo.Length - 1 Step +1
            arreglostring = arreglostring & "," & arreglo(i)
        Next
        Return arreglostring
    End Function

    Public Sub CrearArreglo(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        ReDim arreglo(0 To tamaño - 1)
        For i As Integer = 0 To arreglo.Length - 1 Step +1
            arreglo(i) = r.Next(minimo, maximo)
        Next
    End Sub

    Public Sub RadixAlterno(ByRef arreglo As Integer())
        stopwatch.Restart()
        Dim i As Integer, j As Integer
        Dim temp As Integer() = New Integer(arreglo.Length - 1) {}

        For shift As Integer = 31 To -1 + 1 Step -1
            j = 0

            For i = 0 To arreglo.Length - 1
                Dim move As Boolean = (arreglo(i) << shift) >= 0

                If If(shift = 0, Not move, move) Then
                    arreglo(i - j) = arreglo(i)
                Else
                    temp(j) = arreglo(i)
                    j += 1
                End If
            Next

            Array.Copy(temp, 0, arreglo, arreglo.Length - j, j)
        Next
        stopwatch.Stop()
        lblTiempo.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
    End Sub
    Public Sub OrdenaRadiz()
        stopwatch.Start()
        Dim aux As Integer() = New Integer(arreglo.Length - 1) {}
        Dim count As Integer() = New Integer(1 << minimo) {}
        Dim pref As Integer() = New Integer(1 << minimo) {}
        Dim groups As Integer = CInt(Math.Ceiling(CDbl(maximo) / CDbl(minimo)))
        Dim mask As Integer = (1 << minimo) - 1

        Dim c As Integer = 0, shift As Integer = 0

        While c < groups
            For j As Integer = 0 To count.Length - 1
                count(j) = 0
            Next

            For i As Integer = 0 To arreglo.Length - 1
                count(arreglo(i) >> shift And mask) += 1
            Next

            pref(0) = 0

            For i As Integer = 1 To count.Length - 1
                pref(i) = pref(i - 1) + count(i - 1)
            Next

            For i As Integer = 0 To arreglo.Length - 1
                aux(Math.Min(Threading.Interlocked.Increment(pref(arreglo(i) >> shift And mask)), pref(arreglo(i) >> shift And mask) - 1)) = arreglo(i)
            Next

            aux.CopyTo(arreglo, 0)
            c += 1
            shift += minimo
        End While
        stopwatch.[Stop]()
        Dim time As String = stopwatch.Elapsed.TotalMilliseconds & " ms"
        lblTiempo.Text = time


    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            tamaño = txtTamaño.Text
            minimo = txtMinimo.Text
            maximo = txtMaximo.Text
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
            CrearArreglo(tamaño, minimo, maximo)
            lblArregloOriginal.Text = ImprimirArreglo()
            RadixAlterno(arreglo)
            lblArregloOrdenado.Text = ImprimirArreglo()

        Catch ex As Exception
            MessageBox.Show("Introduzca datos validos")
        End Try
    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        tamaño = r.Next(1, 18)
        minimo = r.Next(0, 50)
        maximo = r.Next(minimo, 100)
        CrearArreglo(tamaño, minimo, maximo)
        lblArregloOriginal.Text = ImprimirArreglo()
        RadixAlterno(arreglo)
        lblArregloOrdenado.Text = ImprimirArreglo()
    End Sub
End Class