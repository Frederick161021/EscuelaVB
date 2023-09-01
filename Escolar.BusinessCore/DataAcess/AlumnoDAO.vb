Imports System.Data.SqlClient
Imports Escolar.Contracts.DataTransferObjects
Imports Escolar.Contracts.Enums
Imports Escolar.Contracts.DisplayObjects

Namespace DataAcess
    Public Class AlumnoDAO
        Inherits DataAcessObjectBase

        Private Const SP_INSERT = "spAlumnoInsert"
        Private Const SP_GETBYID = "spAlumnoGetById"
        Private Const SP_UPDATE = "spALumnoUpdate"
        Private Const SP_DELETE = "spAlumnoDelete"
        Private Const SP_LISTA = "spALumnoGetLista"
        Private Const SP_GETLISTCONCARRERA = "spAlumnoGetConCarrera"

        Public Sub Insert(ByVal dto As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, dto.matricula, SqlDbType.Int)
            addParameter(AlumnoEnum.nombre.ToString, dto.nombre, SqlDbType.VarChar)
            addParameter(AlumnoEnum.apellido.ToString, dto.apellido, SqlDbType.VarChar)
            addParameter(AlumnoEnum.carrera.ToString, dto.carrera, SqlDbType.VarChar)

            Execute(SP_INSERT)
        End Sub

        Public Function GetByMatricula(ByVal matricula As Integer) As AlumnoDTO

            addParameter(AlumnoEnum.matricula.ToString, matricula, SqlDbType.Int)

            addOutParameter(AlumnoEnum.nombre.ToString, "", SqlDbType.VarChar, 50)
            addOutParameter(AlumnoEnum.apellido.ToString, "", SqlDbType.VarChar, 100)
            addOutParameter(AlumnoEnum.carrera.ToString, "", SqlDbType.VarChar, 10)

            Execute(SP_GETBYID)

            Dim dto As AlumnoDTO = New AlumnoDTO()

            If comando.Parameters(AlumnoEnum.nombre.ToString).Value Is DBNull.Value Then
                dto.isValid = False
            Else
                dto.isValid = True
                dto.nombre = CStr(OutputParameter(AlumnoEnum.nombre.ToString))
                dto.apellido = CStr(OutputParameter(AlumnoEnum.apellido.ToString))
                dto.carrera = CStr(OutputParameter(AlumnoEnum.carrera.ToString))
            End If
            Return dto
        End Function

        Public Sub Update(ByVal dto As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, dto.matricula, SqlDbType.Int)
            addParameter(AlumnoEnum.nombre.ToString, dto.nombre, SqlDbType.VarChar)
            addParameter(AlumnoEnum.apellido.ToString, dto.apellido, SqlDbType.VarChar)
            addParameter(AlumnoEnum.carrera.ToString, dto.carrera, SqlDbType.VarChar)

            Execute(SP_UPDATE)
        End Sub

        Public Sub eleminar(ByVal matricula As Integer)
            addParameter(AlumnoEnum.matricula.ToString, matricula, SqlDbType.Int)
            Execute(SP_DELETE)
        End Sub

        Public Function consultar() As DataTable
            Dim resultados As DataSet
            resultados = ExecuteResultSet(SP_LISTA)
            Return resultados.Tables(0)
        End Function

        Public Function AlumnoGetConCarrera() As List(Of ALumnoDisplayObject)
            Dim resultados As DataSet
            resultados = ExecuteResultSet(SP_GETLISTCONCARRERA)

            Dim lista As New List(Of AlumnoDisplayObject)

            Dim display As AlumnoDisplayObject

            For Each row As DataRow In resultados.Tables(0).Rows()
                display = New AlumnoDisplayObject()
                display.Matricula = CStr(row(AlumnoEnum.matricula.ToString))
                display.NombreCompleto = CStr(row(AlumnoEnum.nombrecompleto.ToString))
                display.NombreCarrera = CStr(row(AlumnoEnum.nombrecarrera.ToString))

                lista.Add(display)
            Next

            Return lista
        End Function

    End Class
End Namespace

