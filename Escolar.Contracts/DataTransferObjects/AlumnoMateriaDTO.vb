Namespace DataTransferObjects
    Public Class AlumnoMateriaDTO
        Private _matricula As Integer
        Private _clave As String

        Public Property Matricula() As Integer
            Get
                Return _matricula
            End Get
            Set(ByVal value As Integer)
                _matricula = value
            End Set
        End Property

        Public Property Clave() As String
            Get
                Return _clave
            End Get
            Set(ByVal value As String)
                _clave = value
            End Set
        End Property
    End Class
End Namespace

