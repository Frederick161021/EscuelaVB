Imports Escolar.Contracts.Services
Imports Escolar.BusinessCore.DataAcess
Imports Escolar.Contracts.DataTransferObjects

Namespace DomainObjects
    Public Class MateriaDomainObject
        Implements IMateria

        Public Sub Actualizar(ByVal dto As Contracts.DataTransferObjects.MateriaDTO) Implements Contracts.Services.IMateria.Actualizar
            Dim dao As MateriaDAO = New MateriaDAO
            dao.Update(dto)
        End Sub

        Public Sub Agregar(ByVal dto As Contracts.DataTransferObjects.MateriaDTO) Implements Contracts.Services.IMateria.Agregar
            Dim dao As MateriaDAO = New MateriaDAO
            dao.Insert(dto)
        End Sub

        Public Function Buscar(ByVal Clave As Integer) As Contracts.DataTransferObjects.MateriaDTO Implements Contracts.Services.IMateria.Buscar
            Dim dao As MateriaDAO = New MateriaDAO
            Dim dto As MateriaDTO = dao.GetByClave(Clave)
            Return dto
        End Function

        Public Function Consultar() As System.Data.DataTable Implements Contracts.Services.IMateria.Consultar
            Dim dao As MateriaDAO = New MateriaDAO
            Return dao.consultar
        End Function

        Public Sub Eliminar(ByVal matricula As Integer) Implements Contracts.Services.IMateria.Eliminar
            Dim dao As MateriaDAO = New MateriaDAO
            dao.eleminar(matricula)
        End Sub
    End Class
End Namespace
