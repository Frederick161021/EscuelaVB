Imports Escolar.Contracts.DataTransferObjects
Imports Escolar.Contracts.Enums
Imports System.Data.SqlClient

Namespace DataAcess
    Public Class MateriaDAO
        Inherits DataAcessObjectBase

        Private Const SP_INSERT = "spMateriaInsert"
        Private Const SP_GETBYCLAVE = "spMateriaGetByClave"
        Private Const SP_UPDATE = "spMateriaUpdate"
        Private Const SP_DELETE = "spMateriaDelete"
        Private Const SP_LISTA = "spMateriaGetLista"

        Public Sub Insert(ByVal dto As MateriaDTO)
            addParameter(MateriaEnum.clave.ToString, dto.Clave, SqlDbType.VarChar)
            addParameter(MateriaEnum.nombre.ToString, dto.Nombre, SqlDbType.VarChar)
            addParameter(MateriaEnum.creditos.ToString, dto.Creditos, SqlDbType.Int)

            Execute(SP_INSERT)
        End Sub

        Public Function GetByClave(ByVal clave As String) As MateriaDTO

            addParameter(MateriaEnum.clave.ToString, clave, SqlDbType.VarChar)

            addOutParameter(MateriaEnum.nombre.ToString, "", SqlDbType.VarChar, 100)
            addOutParameter(MateriaEnum.creditos.ToString, "", SqlDbType.Int, Integer.MaxValue)

            Execute(SP_GETBYCLAVE)

            Dim dto As MateriaDTO = New MateriaDTO()

            If comando.Parameters(MateriaEnum.nombre.ToString).Value Is DBNull.Value Then
                dto.IsValid = False
            Else
                dto.IsValid = True
                dto.Nombre = CStr(OutputParameter(MateriaEnum.nombre.ToString))
                dto.Creditos = CStr(OutputParameter(MateriaEnum.creditos.ToString))
            End If
            Return dto
        End Function

        Public Sub Update(ByVal dto As MateriaDTO)

            addParameter(MateriaEnum.clave.ToString, dto.Clave, SqlDbType.VarChar)
            addParameter(MateriaEnum.nombre.ToString, dto.Nombre, SqlDbType.VarChar)
            addParameter(MateriaEnum.creditos.ToString, dto.Creditos, SqlDbType.Int)

            Execute(SP_UPDATE)
        End Sub

        Public Sub eleminar(ByVal Clave As Integer)
            addParameter(MateriaEnum.clave.ToString, Clave, SqlDbType.VarChar)
            Execute(SP_DELETE)
        End Sub

        Public Function consultar() As DataTable

            Execute(SP_LISTA)

            Dim resultados As DataSet = New DataSet()

            Dim adaptador As SqlDataAdapter = New SqlDataAdapter()
            adaptador.SelectCommand = comando

            adaptador.Fill(resultados, MateriaEnum.nombre.ToString)

            Return resultados.Tables(MateriaEnum.nombre.ToString)
        End Function
    End Class
End Namespace
