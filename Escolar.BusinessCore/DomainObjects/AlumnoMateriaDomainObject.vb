Imports Escolar.Contracts.Services
Imports Escolar.BusinessCore.DataAcess

Namespace DomainObject
    Public Class AlumnoMateriaDomainObject
        Implements IAlumnoMateria


        Public Sub Agregar(ByVal dto As Contracts.DataTransferObjects.AlumnoMateriaDTO) Implements Contracts.Services.IAlumnoMateria.Agregar
            Dim dao As AlumnoMateriaDAO = New AlumnoMateriaDAO
            dao.Insert(dto)
        End Sub

        Public Function Consultar(ByVal matricula As Integer) As System.Data.DataTable Implements Contracts.Services.IAlumnoMateria.Consultar
            Dim dao As AlumnoMateriaDAO = New AlumnoMateriaDAO
            Return dao.consultar(matricula)
        End Function
    End Class
End Namespace
