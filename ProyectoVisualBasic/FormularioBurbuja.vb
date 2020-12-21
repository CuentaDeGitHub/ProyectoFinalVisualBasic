Public Class FormularioBurbuja
    Dim aux As Integer
    Dim comparaciones As Integer
    Dim intercambios As Integer
    Dim lista As Integer()
    Dim r As New Random()
    Dim stopwatch As Stopwatch = New Stopwatch()


    Private Sub FormularioBurbuja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupBox1.Visible = False
    End Sub


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
            intercambios = 0
            comparaciones = 0
            OrdenarArreglo(tamaño, minimo, maximo)

        Catch ex As Exception
            MessageBox.Show("Introduzca datos validos")
        End Try
    End Sub

    Public Sub OrdenarArreglo(ByVal tamaño As Integer, ByVal minimo As Integer, ByVal maximo As Integer)
        groupBox1.Visible = True
        ReDim lista(0 To tamaño - 1)
        For i As Integer = 0 To lista.Length - 1 Step +1
            lista(i) = r.Next(minimo, maximo)
        Next
        lblArregloOriginal.Text = MostrarLista()

        stopwatch.Restart()
        For i As Integer = i To lista.Length - 1 Step +1
            For j As Integer = 0 To lista.Length - 2 Step +1
                comparaciones = comparaciones + 1
                If (lista(j) > lista(j + 1)) Then
                    aux = lista(j)
                    lista(j) = lista(j + 1)
                    lista(j + 1) = aux
                    intercambios = intercambios + 1
                End If
            Next
        Next
        stopwatch.Stop()


        lblArregloOrdenado.Text = MostrarLista()
        lblTiempo.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
        lblComparaciones.Text = comparaciones & ""
        lblIntercambios.Text = intercambios & ""



    End Sub

    Public Function MostrarLista() As String
        Dim arreglostring As String = ""
        arreglostring = arreglostring & lista(0)
        For i As Integer = 1 To lista.Length - 1 Step +1
            arreglostring = arreglostring & "," & lista(i)
        Next
        Return arreglostring

    End Function

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        Dim tamaño As Integer = r.Next(1, 18)
        Dim minimo As Integer = r.Next(0, 50)
        Dim maximo As Integer = r.Next(minimo, 100)
        intercambios = 0
        comparaciones = 0
        OrdenarArreglo(tamaño, minimo, maximo)
    End Sub
End Class