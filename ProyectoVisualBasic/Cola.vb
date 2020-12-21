Public Class Cola
    Protected _head As Nodo
    Protected _tail As Nodo
    Public Property Head As Nodo
        Get
            Return _head
        End Get
        Set(ByVal value As Nodo)
            _head = value
        End Set
    End Property

    Public Property Tail As Nodo
        Get
            Return _tail
        End Get
        Set(ByVal value As Nodo)
            _tail = value
        End Set
    End Property

    Public Sub New()
        _head = Nothing
        _tail = Nothing
    End Sub

    Public Sub Encolar(ByVal n As Nodo)
        If _head Is Nothing Then
            _head = n
            _tail = n
            Return
        End If
        _tail.Siguiente = n
        _tail = n
    End Sub

    Public Sub Desencolar()
        If Head IsNot Nothing Then
            If _head Is _tail Then
                _head = Nothing
                _tail = Nothing
                Return
            End If
            _head = _head.Siguiente
        End If

    End Sub
    Public Function Font() As Integer
        Return _head.Dato
    End Function

    Public Overrides Function ToString() As String
        Dim stringCola As String = ""
        Dim h As Nodo = _head
        If h IsNot Nothing Then
            stringCola = stringCola & h.ToString()
            h = h.Siguiente
            While (h IsNot Nothing)
                stringCola = stringCola & "," & h.ToString()
                h = h.Siguiente
            End While
            Return stringCola
        End If
        Return "La cola esta vacia"
    End Function
End Class
