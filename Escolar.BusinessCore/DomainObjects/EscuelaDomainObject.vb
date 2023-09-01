Imports Escolar.Contracts.Services
Imports Escolar.BusinessCore.DataAcess


Namespace DomainObjects
    Public Class EscuelaDomainObject
        Implements IEscuela

        Public Sub Agregar(ByVal dto As Contracts.DataTransferObjects.EscuelaDTO) Implements Contracts.Services.IEscuela.Agregar
            BusinessRules.EscuelaBusinessRule.NoPuedeIniciarConW(dto.Nombre)
            Dim dao As EscuelaDAO = New EscuelaDAO()
            dao.Insert(dto)
        End Sub
    End Class
End Namespace
