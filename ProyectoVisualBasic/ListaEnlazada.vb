Public Class ListaEnlazada
    Protected _head As Nodo
    Public Property Head As Nodo
        Get
            Return _head
        End Get
        Set(ByVal value As Nodo)
            _head = value
        End Set
    End Property

    Public Sub New()
        _head = Nothing
    End Sub

    Public Sub Borrar(ByVal dato As Integer)
        If (_head IsNot Nothing) Then
            If (_head.Dato = dato) Then
                _head = _head.Siguiente
                Return
            End If
            Dim h As New Nodo()
            h = _head
            While (h.Siguiente IsNot Nothing)
                If (h.Siguiente.Dato = dato) Then
                    h.Siguiente = h.Siguiente.Siguiente
                    Return
                End If
                h = h.Siguiente
            End While
            MessageBox.Show("El dato no fue encontado dentro de la lista")
        End If
    End Sub

    Public Sub Agregar(ByVal n As Nodo)
        If (_head Is Nothing) Then
            _head = n
            Return
        End If
        If (n.Dato < _head.Dato) Then
            n.Siguiente = _head
            _head = n
            Return
        End If
        Dim h As Nodo
        h = _head
        While (h.Siguiente IsNot Nothing)
            If (h.Siguiente.Dato > n.Dato) Then
                Exit While
            End If
            h = h.Siguiente
        End While
        If (h.Siguiente IsNot Nothing) Then
            n.Siguiente = h.Siguiente
            h.Siguiente = n
            Return
        End If
        h.Siguiente = n
    End Sub

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim h As Nodo = _head
        If (h IsNot Nothing) Then
            lista = lista & h.ToString()
            h = h.Siguiente
            While (h IsNot Nothing)
                lista = lista & "," & h.ToString()
                h = h.Siguiente
            End While
            Return lista
        End If
        Return "La lista esta vacia"
    End Function

    Public Function Buscar(ByVal a As Integer) As Boolean
        Dim h As Nodo = _head
        If h IsNot Nothing Then
            While (h IsNot Nothing)
                If (h.Dato = a) Then
                    Return True
                End If
                h = h.Siguiente
            End While
        End If
        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        Dim h As Nodo = _head
        While h IsNot Nothing
            contador = contador + 1
            h = h.Siguiente
        End While
        Return contador
    End Function
End Class
