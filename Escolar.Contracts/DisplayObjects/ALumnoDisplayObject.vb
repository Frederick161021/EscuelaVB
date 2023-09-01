Namespace DisplayObjects
    Public Class ALumnoDisplayObject
        Private _matricula As Integer
        Private _nombrecompleto As String
        Private _nombrecarrera As String

        Public Property Matricula() As Integer
            Get
                Return _matricula
            End Get
            Set(ByVal value As Integer)
                _matricula = value
            End Set
        End Property

        Public Property NombreCompleto() As String
            Get
                Return _nombrecompleto
            End Get
            Set(ByVal value As String)
                _nombrecompleto = value
            End Set
        End Property

        Public Property NombreCarrera() As String
            Get
                Return _nombrecarrera
            End Get
            Set(ByVal value As String)
                _nombrecarrera = value
            End Set
        End Property
    End Class
End Namespace
