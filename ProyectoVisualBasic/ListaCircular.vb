Public Class ListaCircular
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

    Public Sub Agregar(ByVal n As Nodo)
        If _head Is Nothing Then
            _head = n
            n.Siguiente = n
            Return
        End If

        Dim h As Nodo = _head
        If n.Dato < _head.Dato Then
            While h.Siguiente IsNot _head
                h = h.Siguiente

            End While
            h.Siguiente = n
            n.Siguiente = _head
            _head = n
            Return
        End If

        While h.Siguiente IsNot _head
            If n.Dato < h.Siguiente.Dato Then
                Exit While
            End If
            h = h.Siguiente
        End While
        n.Siguiente = h.Siguiente
        h.Siguiente = n
    End Sub

    Public Sub Borrar(ByVal dato As Integer)
        Dim h As Nodo = _head
        If _head IsNot Nothing Then


            If _head.Dato = dato Then
                While h.Siguiente IsNot _head
                    h = h.Siguiente
                End While
                _head = _head.Siguiente
                h.Siguiente = _head
                Return
            End If

            While (h.Siguiente.Dato <> dato)
                h = h.Siguiente
            End While
            h.Siguiente = h.Siguiente.Siguiente
        End If
    End Sub

    Public Function BuscarDato(ByVal dato As Integer) As Boolean
        Dim h As Nodo = _head
        If h IsNot Nothing Then
            Do
                If h.Dato = dato Then
                    Return True
                End If
                h = h.Siguiente
            Loop While h IsNot _head
        End If
        Return False
    End Function

    Public Function ContarNodos() As Integer
        Dim contador As Integer = 0
        Dim h As Nodo = _head
        Do
            contador = contador + 1
            h = h.Siguiente
        Loop While h IsNot _head
        Return contador
    End Function

    Public Overrides Function ToString() As String
        Dim StringLista As String = ""
        Dim h As Nodo = _head
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
