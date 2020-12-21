Public Class ListaDoble
    Protected _head As NodoDoble
    Public Property Head As NodoDoble
        Get
            Return _head
        End Get
        Set(ByVal value As NodoDoble)
            _head = value
        End Set
    End Property

    Public Sub New()
        _head = Nothing
    End Sub

    Public Sub Insertar(ByVal n As NodoDoble)
        If _head Is Nothing Then
            _head = n
            Return
        End If

        If n.Dato < _head.Dato Then
            n.Siguiente = _head
            _head.Anterior = n
            _head = n
            Return
        End If

        Dim h As NodoDoble = _head

        While h.Siguiente IsNot Nothing
            If h.Siguiente.Dato > n.Dato Then
                Exit While
            End If
            h = h.Siguiente
        End While

        n.Siguiente = h.Siguiente
        n.Anterior = h
        If h.Siguiente IsNot Nothing Then
            h.Siguiente.Anterior = n
        End If
        h.Siguiente = n
    End Sub

    Public Sub Eliminar(ByVal dato As Integer)
        If _head IsNot Nothing Then
            If _head.Dato = dato Then
                _head = _head.Siguiente
                _head.Anterior = Nothing
                Return
            End If

            Dim h As NodoDoble = _head
            While h.Siguiente IsNot Nothing
                If h.Siguiente.Dato = dato Then
                    Exit While
                End If
                h = h.Siguiente
            End While

            If h.Siguiente.Siguiente Is Nothing Then
                h.Siguiente = Nothing
            Else
                h.Siguiente = h.Siguiente.Siguiente
                h.Siguiente.Anterior = h
            End If
        End If
    End Sub

    Public Function BuscarDato(ByVal dato As Integer) As Boolean
        Dim h As NodoDoble = _head
        If h IsNot Nothing Then

            While h IsNot Nothing
                If h.Dato = dato Then
                    Return True
                End If
                h = h.Siguiente
            End While
        End If
        Return False
    End Function

    Public Function ContadorNodos() As Integer
        Dim contador As Integer = 0
        Dim h As NodoDoble = _head
        While (h IsNot Nothing)
            contador = contador + 1
            h = h.Siguiente
        End While
        Return contador
    End Function

    Public Overrides Function ToString() As String
        Dim lista As String = ""
        Dim h As NodoDoble = _head
        If h IsNot Nothing Then
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
End Class
