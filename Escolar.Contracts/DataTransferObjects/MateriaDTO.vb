Namespace DataTransferObjects
    Public Class MateriaDTO
        Private _clave As String
        Private _nombre As String
        Private _creditos As Integer
        Private _isValid As Boolean

        Public Property Clave() As String
            Get
                Return _clave
            End Get
            Set(ByVal value As String)
                _clave = value
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

        Public Property Creditos() As Integer
            Get
                Return _creditos
            End Get
            Set(ByVal value As Integer)
                _creditos = value
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
