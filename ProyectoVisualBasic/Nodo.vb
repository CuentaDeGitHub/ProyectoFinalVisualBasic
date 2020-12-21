Public Class Nodo
    Protected _dato As Integer
    Protected _siguiente As Nodo
    Protected _anterior As Nodo

    Public Property Dato As Integer
        Get
            Return _dato
        End Get
        Set(ByVal value As Integer)
            _dato = value
        End Set
    End Property
    Public Property Siguiente As Nodo
        Get
            Return _siguiente
        End Get
        Set(ByVal value As Nodo)
            _siguiente = value
        End Set
    End Property

    Public Sub New()
        _dato = 0
        _siguiente = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return _dato & ""
    End Function
End Class
