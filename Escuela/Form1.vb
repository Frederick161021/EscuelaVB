Imports System.Text
Imports System.IO
Imports Escolar.BusinessCore.DomainObjects
Imports Escolar.Contracts.DataTransferObjects
Imports Escolar.Contracts.Services
Imports Escolar.BusinessCore.DomainObject


Public Class Form1
    Private Const NoMatricula = "La matricula no existe"


    Private Sub ButtonAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregar.Click

        Dim servicio As IAlumno = New AlumnoDomainObject

        Dim dto As AlumnoDTO = New AlumnoDTO
        dto.matricula = TextMatricula.Text
        dto.nombre = TextNombre.Text
        dto.apellido = TextApellido.Text
        dto.carrera = TextCarrera.Text

        servicio.Agregar(dto)
    End Sub

    Private Sub ButtonActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualizar.Click
        Dim servicio As IAlumno = New AlumnoDomainObject

        Dim dto As AlumnoDTO = New AlumnoDTO
        dto.matricula = TextMatricula.Text
        dto.nombre = TextNombre.Text
        dto.apellido = TextApellido.Text
        dto.carrera = TextCarrera.Text

        servicio.Actualizar(dto)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEliminar.Click
        Dim servicio As IAlumno = New AlumnoDomainObject
        servicio.Eliminar(TextMatricula.Text)
    End Sub

    Private Sub ButtonConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConsultar.Click
        Dim servicio As IAlumno = New AlumnoDomainObject
        dgvAlumnos.DataSource = servicio.AlumnoGetConCarrera
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Dim servicio As IAlumno = New AlumnoDomainObject
        Dim dto As AlumnoDTO = New AlumnoDTO
        dto = servicio.Buscar(TextMatricula.Text)

        If Not dto.isValid Then
            MessageBox.Show(NoMatricula)
        Else
            TextNombre.Text = dto.nombre
            TextApellido.Text = dto.apellido
            TextCarrera.Text = dto.carrera
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarMaterias()
    End Sub

    Public Sub cargarMaterias()
        Dim servicio As IMateria = New MateriaDomainObject
        ComboBoxMateria.DataSource = servicio.Consultar()
        ComboBoxMateria.DisplayMember = Escolar.Contracts.Enums.MateriaEnum.nombre.ToString
        ComboBoxMateria.ValueMember = Escolar.Contracts.Enums.MateriaEnum.clave.ToString
    End Sub

    Private Sub ButtonAgregarMaterias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarMaterias.Click
        Dim dto As AlumnoMateriaDTO = New AlumnoMateriaDTO
        dto.Clave = ComboBoxMateria.SelectedValue
        dto.Matricula = TextMatricula.Text
        Dim servicio As IAlumnoMateria = New AlumnoMateriaDomainObject
        servicio.Agregar(dto)
    End Sub

    Private Sub ButtonConMateria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConMateria.Click
        Dim servicio As IAlumnoMateria = New AlumnoMateriaDomainObject
        dvgMaterias.DataSource = servicio.Consultar(TextMatricula.Text)
    End Sub
End Class
