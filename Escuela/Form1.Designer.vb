<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.LabelMatricula = New System.Windows.Forms.Label
        Me.LabelNombre = New System.Windows.Forms.Label
        Me.Apellido = New System.Windows.Forms.Label
        Me.Carrera = New System.Windows.Forms.Label
        Me.TextMatricula = New System.Windows.Forms.TextBox
        Me.TextNombre = New System.Windows.Forms.TextBox
        Me.TextApellido = New System.Windows.Forms.TextBox
        Me.TextCarrera = New System.Windows.Forms.TextBox
        Me.ButtonAgregar = New System.Windows.Forms.Button
        Me.ButtonActualizar = New System.Windows.Forms.Button
        Me.ButtonEliminar = New System.Windows.Forms.Button
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView
        Me.ButtonConsultar = New System.Windows.Forms.Button
        Me.ButtonBuscar = New System.Windows.Forms.Button
        Me.ButtonAgregarMaterias = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxMateria = New System.Windows.Forms.ComboBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.dvgMaterias = New System.Windows.Forms.DataGridView
        Me.ButtonConMateria = New System.Windows.Forms.Button
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelMatricula
        '
        Me.LabelMatricula.AutoSize = True
        Me.LabelMatricula.Location = New System.Drawing.Point(79, 59)
        Me.LabelMatricula.Name = "LabelMatricula"
        Me.LabelMatricula.Size = New System.Drawing.Size(50, 13)
        Me.LabelMatricula.TabIndex = 0
        Me.LabelMatricula.Text = "Matricula"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(79, 108)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombre.TabIndex = 1
        Me.LabelNombre.Text = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.AutoSize = True
        Me.Apellido.Location = New System.Drawing.Point(79, 165)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(44, 13)
        Me.Apellido.TabIndex = 2
        Me.Apellido.Text = "Apellido"
        '
        'Carrera
        '
        Me.Carrera.AutoSize = True
        Me.Carrera.Location = New System.Drawing.Point(79, 216)
        Me.Carrera.Name = "Carrera"
        Me.Carrera.Size = New System.Drawing.Size(41, 13)
        Me.Carrera.TabIndex = 3
        Me.Carrera.Text = "Carrera"
        '
        'TextMatricula
        '
        Me.TextMatricula.Location = New System.Drawing.Point(169, 56)
        Me.TextMatricula.Name = "TextMatricula"
        Me.TextMatricula.Size = New System.Drawing.Size(208, 20)
        Me.TextMatricula.TabIndex = 4
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(169, 108)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(342, 20)
        Me.TextNombre.TabIndex = 5
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(169, 165)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(342, 20)
        Me.TextApellido.TabIndex = 6
        '
        'TextCarrera
        '
        Me.TextCarrera.Location = New System.Drawing.Point(169, 216)
        Me.TextCarrera.Name = "TextCarrera"
        Me.TextCarrera.Size = New System.Drawing.Size(342, 20)
        Me.TextCarrera.TabIndex = 7
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(42, 274)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(78, 23)
        Me.ButtonAgregar.TabIndex = 8
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonActualizar.Location = New System.Drawing.Point(158, 274)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(78, 23)
        Me.ButtonActualizar.TabIndex = 9
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(275, 274)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(78, 23)
        Me.ButtonEliminar.TabIndex = 10
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Location = New System.Drawing.Point(63, 342)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.Size = New System.Drawing.Size(518, 218)
        Me.dgvAlumnos.TabIndex = 11
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonConsultar.Location = New System.Drawing.Point(388, 274)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(78, 23)
        Me.ButtonConsultar.TabIndex = 12
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonBuscar.Location = New System.Drawing.Point(406, 56)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(78, 23)
        Me.ButtonBuscar.TabIndex = 13
        Me.ButtonBuscar.Text = "..."
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'ButtonAgregarMaterias
        '
        Me.ButtonAgregarMaterias.Location = New System.Drawing.Point(709, 277)
        Me.ButtonAgregarMaterias.Name = "ButtonAgregarMaterias"
        Me.ButtonAgregarMaterias.Size = New System.Drawing.Size(125, 21)
        Me.ButtonAgregarMaterias.TabIndex = 14
        Me.ButtonAgregarMaterias.Text = "Agregar Materia"
        Me.ButtonAgregarMaterias.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(706, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Materias:"
        '
        'ComboBoxMateria
        '
        Me.ComboBoxMateria.FormattingEnabled = True
        Me.ComboBoxMateria.Location = New System.Drawing.Point(709, 208)
        Me.ComboBoxMateria.Name = "ComboBoxMateria"
        Me.ComboBoxMateria.Size = New System.Drawing.Size(263, 21)
        Me.ComboBoxMateria.TabIndex = 16
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'dvgMaterias
        '
        Me.dvgMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMaterias.Location = New System.Drawing.Point(645, 345)
        Me.dvgMaterias.Name = "dvgMaterias"
        Me.dvgMaterias.Size = New System.Drawing.Size(368, 214)
        Me.dvgMaterias.TabIndex = 17
        '
        'ButtonConMateria
        '
        Me.ButtonConMateria.Location = New System.Drawing.Point(885, 277)
        Me.ButtonConMateria.Name = "ButtonConMateria"
        Me.ButtonConMateria.Size = New System.Drawing.Size(87, 20)
        Me.ButtonConMateria.TabIndex = 18
        Me.ButtonConMateria.Text = "Consultar"
        Me.ButtonConMateria.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 614)
        Me.Controls.Add(Me.ButtonConMateria)
        Me.Controls.Add(Me.dvgMaterias)
        Me.Controls.Add(Me.ComboBoxMateria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAgregarMaterias)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.TextCarrera)
        Me.Controls.Add(Me.TextApellido)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextMatricula)
        Me.Controls.Add(Me.Carrera)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelMatricula)
        Me.Name = "Form1"
        Me.Text = "Escuela"
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMatricula As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents Apellido As System.Windows.Forms.Label
    Friend WithEvents Carrera As System.Windows.Forms.Label
    Friend WithEvents TextMatricula As System.Windows.Forms.TextBox
    Friend WithEvents TextNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextApellido As System.Windows.Forms.TextBox
    Friend WithEvents TextCarrera As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonConsultar As System.Windows.Forms.Button
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonAgregarMaterias As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMateria As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents dvgMaterias As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonConMateria As System.Windows.Forms.Button

End Class
