<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LabelClave = New System.Windows.Forms.Label
        Me.LabelNombre = New System.Windows.Forms.Label
        Me.LabelCreditos = New System.Windows.Forms.Label
        Me.dgvMateria = New System.Windows.Forms.DataGridView
        Me.TextClave = New System.Windows.Forms.TextBox
        Me.TextNombre = New System.Windows.Forms.TextBox
        Me.TextCreditos = New System.Windows.Forms.TextBox
        Me.ButtonBuscar = New System.Windows.Forms.Button
        Me.ButtonAgregar = New System.Windows.Forms.Button
        Me.ButtonActualizar = New System.Windows.Forms.Button
        Me.ButtonEliminar = New System.Windows.Forms.Button
        Me.ButtonConsultar = New System.Windows.Forms.Button
        CType(Me.dgvMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelClave
        '
        Me.LabelClave.AutoSize = True
        Me.LabelClave.Location = New System.Drawing.Point(34, 32)
        Me.LabelClave.Name = "LabelClave"
        Me.LabelClave.Size = New System.Drawing.Size(37, 13)
        Me.LabelClave.TabIndex = 0
        Me.LabelClave.Text = "Clave:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(34, 88)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(47, 13)
        Me.LabelNombre.TabIndex = 1
        Me.LabelNombre.Text = "Nombre:"
        '
        'LabelCreditos
        '
        Me.LabelCreditos.AutoSize = True
        Me.LabelCreditos.Location = New System.Drawing.Point(34, 152)
        Me.LabelCreditos.Name = "LabelCreditos"
        Me.LabelCreditos.Size = New System.Drawing.Size(48, 13)
        Me.LabelCreditos.TabIndex = 2
        Me.LabelCreditos.Text = "Creditos:"
        '
        'dgvMateria
        '
        Me.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMateria.Location = New System.Drawing.Point(37, 243)
        Me.dgvMateria.Name = "dgvMateria"
        Me.dgvMateria.Size = New System.Drawing.Size(425, 169)
        Me.dgvMateria.TabIndex = 3
        '
        'TextClave
        '
        Me.TextClave.Location = New System.Drawing.Point(117, 29)
        Me.TextClave.Name = "TextClave"
        Me.TextClave.Size = New System.Drawing.Size(143, 20)
        Me.TextClave.TabIndex = 4
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(117, 81)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(278, 20)
        Me.TextNombre.TabIndex = 5
        '
        'TextCreditos
        '
        Me.TextCreditos.Location = New System.Drawing.Point(117, 149)
        Me.TextCreditos.Name = "TextCreditos"
        Me.TextCreditos.Size = New System.Drawing.Size(143, 20)
        Me.TextCreditos.TabIndex = 6
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(298, 25)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(97, 26)
        Me.ButtonBuscar.TabIndex = 7
        Me.ButtonBuscar.Text = ". . ."
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(37, 199)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(97, 26)
        Me.ButtonAgregar.TabIndex = 8
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(149, 199)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(97, 26)
        Me.ButtonActualizar.TabIndex = 9
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(262, 199)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(97, 26)
        Me.ButtonEliminar.TabIndex = 10
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.Location = New System.Drawing.Point(365, 199)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(97, 26)
        Me.ButtonConsultar.TabIndex = 11
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 446)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.TextCreditos)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextClave)
        Me.Controls.Add(Me.dgvMateria)
        Me.Controls.Add(Me.LabelCreditos)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelClave)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvMateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelClave As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelCreditos As System.Windows.Forms.Label
    Friend WithEvents dgvMateria As System.Windows.Forms.DataGridView
    Friend WithEvents TextClave As System.Windows.Forms.TextBox
    Friend WithEvents TextNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextCreditos As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonAgregar As System.Windows.Forms.Button
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonConsultar As System.Windows.Forms.Button
End Class
