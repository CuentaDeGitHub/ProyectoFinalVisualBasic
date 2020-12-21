Public Class NodoDoble
    Protected _dato As Integer
    Protected _siguiente As NodoDoble
    Protected _anterior As NodoDoble

    Public Property Dato As Integer
        Get
            Return _dato
        End Get
        Set(ByVal value As Integer)
            _dato = value
        End Set
    End Property
    Public Property Siguiente As NodoDoble
        Get
            Return _siguiente
        End Get
        Set(ByVal value As NodoDoble)
            _siguiente = value
        End Set
    End Property

    Public Property Anterior As NodoDoble
        Get
            Return _anterior
        End Get
        Set(ByVal value As NodoDoble)
            _anterior = value
        End Set
    End Property


    Public Sub New()
        _dato = 0
        _siguiente = Nothing
        _anterior = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return _dato & ""
    End Function
End Class
