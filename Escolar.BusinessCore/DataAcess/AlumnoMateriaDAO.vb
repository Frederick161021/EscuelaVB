Imports Escolar.Contracts.DataTransferObjects
Imports Escolar.Contracts.Enums
Imports System.Data.SqlClient

Namespace DataAcess
    Public Class AlumnoMateriaDAO
        Inherits DataAcessObjectBase

        Private Const SP_INSERT = "spAlumnoMateriaInsert"
        Private Const SP_LISTA = "spAlumnoMateriaGetLista"

        Public Sub Insert(ByVal dto As AlumnoMateriaDTO)
            addParameter(AlumnoMateriaEnum.matricula.ToString, dto.Matricula, SqlDbType.Int)
            addParameter(AlumnoMateriaEnum.clave.ToString, dto.Clave, SqlDbType.VarChar)

            Execute(SP_INSERT)
        End Sub


        Public Function consultar(ByVal matricula As Integer) As DataTable
            addParameter(AlumnoMateriaEnum.matricula.ToString, matricula, SqlDbType.Int)
            Execute(SP_LISTA)

            Dim resultados As DataSet
            resultados = New DataSet()

            Dim adaptador As SqlDataAdapter
            adaptador = New SqlDataAdapter()
            adaptador.SelectCommand = comando

            adaptador.Fill(resultados, MateriaEnum.nombre.ToString)

            Return resultados.Tables(MateriaEnum.nombre.ToString)
        End Function
    End Class
End Namespace
