Imports Escolar.Contracts.DisplayObjects
Imports Escolar.Contracts.Enums
Imports Escolar.Contracts.DataTransferObjects

Namespace DataAcess
    Public Class EscuelaDAO
        Inherits DataAcessObjectBase

        Private Const SP_INSERT = "spEscuelaInsert"

        Public Sub Insert(ByVal dto As EscuelaDTO)
            addOutParameter(EscuelaEnum.escuelaid.ToString, 0, SqlDbType.Int, Integer.MaxValue)
            addParameter(EscuelaEnum.nombre.ToString, dto.Nombre, SqlDbType.VarChar)
            Execute(SP_INSERT)
            dto.EscuelaID = CInt(OutputParameter(EscuelaEnum.escuelaid.ToString))
        End Sub
    End Class
End Namespace
