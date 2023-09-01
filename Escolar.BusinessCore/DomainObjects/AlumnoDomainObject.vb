Imports Escolar.BusinessCore.DataAcess
Imports Escolar.Contracts.DataTransferObjects
Imports Escolar.Contracts.Services

Namespace DomainObjects

    Public Class AlumnoDomainObject
        Implements IAlumno


        Public Sub Agregar(ByVal dto As AlumnoDTO) Implements IAlumno.Agregar
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.Insert(dto)
        End Sub

        Public Sub Actualizar(ByVal dto As AlumnoDTO) Implements IAlumno.Actualizar
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.Update(dto)
        End Sub

        Public Function Buscar(ByVal matricula As Integer) As AlumnoDTO Implements IAlumno.Buscar
            Dim dao As AlumnoDAO = New AlumnoDAO
            Dim dto As AlumnoDTO = dao.GetByMatricula(matricula)
            Return dto
        End Function

        Public Function Consultar() As System.Data.DataTable Implements IAlumno.Consultar
            Dim dao As AlumnoDAO = New AlumnoDAO
            Return dao.consultar
        End Function

        Public Sub Eleminar(ByVal matricula As Integer) Implements IAlumno.Eliminar
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.eleminar(matricula)
        End Sub

        Public Function AlumnoGetConCarrera() As System.Collections.Generic.List(Of Contracts.DisplayObjects.ALumnoDisplayObject) Implements Contracts.Services.IAlumno.AlumnoGetConCarrera
            Dim dao As AlumnoDAO = New AlumnoDAO
            Return dao.AlumnoGetConCarrera()
        End Function
    End Class
End Namespace