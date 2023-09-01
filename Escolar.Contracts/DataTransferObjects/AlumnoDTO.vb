Namespace DataTransferObjects
    Public Class AlumnoDTO
        Private _matricula As Integer
        Private _nombre As String
        Private _apellido As String
        Private _carrera As String
        Private _isValid As Boolean

        Public Property Matricula() As Integer
            Get
                Return _matricula
            End Get
            Set(ByVal value As Integer)
                _matricula = value
            End Set
        End Property

        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property Apellido() As String
            Get
                Return _apellido
            End Get
            Set(ByVal value As String)
                _apellido = value
            End Set
        End Property

        Public Property Carrera() As String
            Get
                Return _carrera
            End Get
            Set(ByVal value As String)
                _carrera = value
            End Set
        End Property

        Public Property IsValid() As Boolean
            Get
                Return _isValid
            End Get
            Set(ByVal value As Boolean)
                _isValid = value
            End Set
        End Property
    End Class
End Namespace
