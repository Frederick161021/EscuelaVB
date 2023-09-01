Namespace DataTransferObjects
    Public Class EscuelaDTO
        Private _nombre As String
        Private _escuelaid As Integer

        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property EscuelaID() As Integer
            Get
                Return _escuelaid
            End Get
            Set(ByVal value As Integer)
                _escuelaid = value
            End Set
        End Property
    End Class
End Namespace
