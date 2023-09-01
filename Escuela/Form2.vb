Imports Escolar.Contracts.Services
Imports Escolar.BusinessCore.DomainObjects
Imports Escolar.Contracts.DataTransferObjects

Public Class Form2

    Private Const NoClave As String = "La clave no existe"

    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click
        Dim servicio As IMateria = New MateriaDomainObject

        Dim dto As MateriaDTO = New MateriaDTO
        dto.Clave = TextClave.Text
        dto.Nombre = TextNombre.Text
        dto.Creditos = TextCreditos.Text

        servicio.Agregar(dto)
    End Sub

    Private Sub ButtonActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualizar.Click
        Dim servicio As IMateria = New MateriaDomainObject
        Dim dto As MateriaDTO = New MateriaDTO
        dto.Clave = TextClave.Text
        dto.Nombre = TextNombre.Text
        dto.Creditos = TextCreditos.Text

        servicio.Actualizar(dto)
    End Sub

    Private Sub ButtonEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim servicio As IMateria = New MateriaDomainObject
        servicio.Eliminar(TextClave.Text)
    End Sub

    Private Sub ButtonConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConsultar.Click
        Dim servicio As IMateria = New MateriaDomainObject
        dgvMateria.DataSource = servicio.Consultar()
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Dim servicio As IMateria = New MateriaDomainObject
        Dim dto As MateriaDTO = New MateriaDTO
        dto = servicio.Buscar(TextClave.Text)

        If Not dto.IsValid Then
            MessageBox.Show(NoClave)
        Else
            TextNombre.Text = dto.Nombre
            TextCreditos.Text = dto.Creditos
        End If
    End Sub
End Class