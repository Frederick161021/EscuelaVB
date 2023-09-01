Imports Escolar.Contracts.Services
Imports Escolar.BusinessCore.DomainObjects
Imports Escolar.Contracts.DataTransferObjects

Public Class Form3

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        Dim servicio As IEscuela = New EscuelaDomainObject
        Dim dto As EscuelaDTO = New EscuelaDTO
        dto.Nombre = TextNombre.Text
        Try
            servicio.Agregar(dto)
            TextID.Text = dto.EscuelaID
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try

    End Sub
End Class