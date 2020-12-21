Public Class Pila
    Protected _top As Nodo
    Public Property Top As Nodo
        Get
            Return _top
        End Get
        Set(ByVal value As Nodo)
            _top = value
        End Set
    End Property

    Public Property Count As Integer
        Get
            Dim c As Integer
            Dim t As Nodo
            t = _top
            While t IsNot Nothing
                c = c + 1
                t = t.Siguiente
            End While
            Return c
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Sub New()
        _top = Nothing
    End Sub

    Sub Push(ByVal n As Nodo)
        n.Siguiente = _top
        _top = n
    End Sub

    Function Pop() As Nodo
        Dim Regreso As Nodo
        Regreso = _top
        If (_top IsNot Nothing) Then
            _top = _top.Siguiente
        End If
        Return Regreso
    End Function

    Public Overrides Function ToString() As String
        Dim stringPila As String
        Dim t As Nodo
        t = _top
        stringPila = ""
        If (t IsNot Nothing) Then
            stringPila += t.ToString
            t = t.Siguiente
            While (t IsNot Nothing)
                stringPila += "," & t.ToString
                t = t.Siguiente
            End While

            Return stringPila
        End If
        Return "La cola esta vacia"
    End Function
End Class
