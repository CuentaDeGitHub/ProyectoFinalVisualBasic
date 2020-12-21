Public Class ListaCircDoble
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

    Public Sub Agregar(ByVal n As NodoDoble)
        Dim h As NodoDoble = _head
        If _head Is Nothing Then
            _head = n
            _head.Anterior = _head
            _head.Siguiente = _head
            Return
        End If

        If n.Dato < _head.Dato Then
            _head.Anterior.Siguiente = n
            n.Anterior = _head.Anterior
            n.Siguiente = _head
            _head.Anterior = n
            _head = n
            Return
        End If

        Do
            If n.Dato < h.Siguiente.Dato Then
                Exit Do
            End If
            h = h.Siguiente
        Loop While h IsNot _head

        If n.Dato < h.Siguiente.Dato Then
            h.Siguiente.Anterior = n
            n.Anterior = h
            n.Siguiente = h.Siguiente
            h.Siguiente = n
        Else
            n.Siguiente = h
            n.Anterior = h.Anterior
            h.Anterior.Siguiente = n
            h.Anterior = n
        End If
    End Sub

    Public Function Buscar(ByVal a As Integer) As Boolean
        Dim h As NodoDoble = _head
        If h IsNot Nothing Then
            Do
                If h.Dato = a Then
                    Return True
                End If
            Loop While h IsNot _head
        End If
        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        If _head IsNot Nothing Then
            Dim h As NodoDoble = _head
            Do
                contador = contador + 1
                h = h.Siguiente
            Loop While h IsNot _head
        End If
        Return contador
    End Function

    Public Sub Eliminar(ByVal a As Integer)
        Dim h As NodoDoble = _head
        While h.Siguiente IsNot _head
            If h.Dato = a Then
                Exit While
            End If
            h = h.Siguiente
        End While

        h.Anterior.Siguiente = h.Siguiente
        h.Siguiente.Anterior = h.Anterior
        If h Is _head Then
            _head = _head.Siguiente
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim StringLista As String = ""
        Dim h As NodoDoble = _head
        If h IsNot Nothing Then
            StringLista = StringLista & h.Dato
            h = h.Siguiente
            While (h IsNot _head)
                StringLista = StringLista & "," & h.Dato
                h = h.Siguiente
            End While
            Return StringLista
        End If
        Return "La lista esta vacia"
    End Function
End Class
