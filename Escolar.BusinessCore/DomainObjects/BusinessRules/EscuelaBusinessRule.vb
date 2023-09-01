Namespace DomainObjects.BusinessRules
    Public Class EscuelaBusinessRule
        Public Shared Sub NoPuedeIniciarConW(ByVal nombre As String)
            If nombre.StartsWith("W") Or nombre.StartsWith("w") Then
                Throw New Exception("Las escuelas no puede iniciar con W")
            End If
        End Sub
    End Class
End Namespace
