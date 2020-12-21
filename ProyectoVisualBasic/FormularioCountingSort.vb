Public Class FormularioCountingSort
    Dim r As New Random()
    Dim valorMayor As Integer = 0
    Dim arregloInicial As Integer()
    Dim arregloAuxiliar As Integer()
    Dim arregloOrdenado As Integer()
    Dim stopwatch As Stopwatch = New Stopwatch()
    Private Sub FormularioCountingSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupBox1.Visible = False

    End Sub

    Public Function ImprimirArreglo(ByVal ParamArray arreglo() As Integer) As String
        Dim arreglostring As String = ""
        arreglostring = arreglostring & arreglo(0)
        For i As Integer = 1 To arreglo.Length - 1 Step +1
            arreglostring = arreglostring & "," & arreglo(i)
        Next
        Return arreglostring
    End Function

    Public Sub OrdernarEInvertir(tamaño As Integer, minimo As Integer, maximo As Integer)
        ReDim arregloInicial(0 To tamaño - 1)
        For i As Integer = 0 To arregloInicial.Length - 1 Step +1
            arregloInicial(i) = r.Next(minimo, maximo)
        Next
        lblOriginal.Text = ImprimirArreglo(arregloInicial)

        stopwatch.Restart()
        For i As Integer = 0 To arregloInicial.Length - 1 Step +1
            If arregloInicial(i) > valorMayor Then
                valorMayor = arregloInicial(i)
            End If
        Next

        ReDim arregloAuxiliar(0 To valorMayor)
        Dim posicion As Integer

        For i As Integer = 0 To arregloInicial.Length - 1 Step +1
            posicion = arregloInicial(i)
            arregloAuxiliar(posicion) = arregloAuxiliar(posicion) + 1
        Next
        lblMovimientos.Text = ImprimirArreglo(arregloAuxiliar)

        Dim anterior As Integer = 0
        For i As Integer = 1 To arregloAuxiliar.Length - 1 Step +1
            anterior = arregloAuxiliar(i - 1)
            arregloAuxiliar(i) = arregloAuxiliar(i) + anterior
        Next

        Dim uhh As Integer = arregloAuxiliar.Length - 1
        While (uhh <> 0)
            arregloAuxiliar(uhh) = arregloAuxiliar(uhh - 1)
            uhh = uhh - 1
        End While
        arregloAuxiliar(0) = 0

        ReDim arregloOrdenado(0 To tamaño - 1)

        Dim valor As Integer = 0

        For i As Integer = 0 To arregloInicial.Length - 1 Step +1
            valor = arregloInicial(i)
            posicion = arregloAuxiliar(valor)
            arregloOrdenado(posicion) = valor
            arregloAuxiliar(valor) = arregloAuxiliar(valor) + 1
        Next

        stopwatch.Stop()

        lblOrdenado.Text = ImprimirArreglo(arregloOrdenado)
        Array.Reverse(arregloOrdenado)
        lblInvertido.Text = ImprimirArreglo(arregloOrdenado)
        lblMovimientos.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() & " Milisegundos"
    End Sub

    Private Sub btnCrearArreglo_Click(sender As Object, e As EventArgs) Handles btnCrearArreglo.Click
        Try
            Dim minimo As Integer = txtMin.Text
            Dim maximo As Integer = txtMax.Text
        Dim tamaño As Integer = txTamaño.Text
        If minimo < 0 Then
            MessageBox.Show("El minimo no puede ser menor a 0")
            Return
        End If
        If (tamaño < 0) Then
            MessageBox.Show("El tamaño no puede ser menor que 0")
            Return
        End If
        If (tamaño <= 0) Then
            MessageBox.Show("El maximo debe de ser mayor que el minimo")
            Return
        End If

        txtMax.Clear()
        txtMin.Clear()
        txTamaño.Clear()

        OrdernarEInvertir(tamaño, minimo, maximo)
        groupBox1.Visible = True
        Catch ex As Exception
        MessageBox.Show("Bruh")
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim tamaño As Integer = r.Next(1, 18)
        Dim minimo As Integer = r.Next(0, 50)
        Dim maximo As Integer = r.Next(minimo, 100)
        txtMin.Clear()
        txtMax.Clear()
        txTamaño.Clear()
        OrdernarEInvertir(tamaño, minimo, maximo)
        groupBox1.Visible = True
    End Sub
End Class