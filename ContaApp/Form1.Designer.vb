﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLibroDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLibroDiario))
        Me.lbfecha = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbcuenta = New System.Windows.Forms.Label()
        Me.cmbcuenta = New System.Windows.Forms.ComboBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.lbmonto = New System.Windows.Forms.Label()
        Me.lbtransaccion = New System.Windows.Forms.Label()
        Me.cmbtransaccion = New System.Windows.Forms.ComboBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.cmbcodigo = New System.Windows.Forms.ComboBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.lbcomentario = New System.Windows.Forms.Label()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lbPartida = New System.Windows.Forms.Label()
        Me.lbcontpartida = New System.Windows.Forms.Label()
        Me.btnexport = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbfecha
        '
        Me.lbfecha.AutoSize = True
        Me.lbfecha.Location = New System.Drawing.Point(60, 12)
        Me.lbfecha.Name = "lbfecha"
        Me.lbfecha.Size = New System.Drawing.Size(40, 13)
        Me.lbfecha.TabIndex = 3
        Me.lbfecha.Text = "Fecha:"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(109, 12)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(87, 20)
        Me.txtfecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo:"
        '
        'lbcuenta
        '
        Me.lbcuenta.AutoSize = True
        Me.lbcuenta.Location = New System.Drawing.Point(216, 63)
        Me.lbcuenta.Name = "lbcuenta"
        Me.lbcuenta.Size = New System.Drawing.Size(44, 13)
        Me.lbcuenta.TabIndex = 7
        Me.lbcuenta.Text = "Cuenta:"
        '
        'cmbcuenta
        '
        Me.cmbcuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbcuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcuenta.FormattingEnabled = True
        Me.cmbcuenta.Location = New System.Drawing.Point(266, 60)
        Me.cmbcuenta.Name = "cmbcuenta"
        Me.cmbcuenta.Size = New System.Drawing.Size(258, 21)
        Me.cmbcuenta.TabIndex = 8
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(109, 99)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(87, 20)
        Me.txtmonto.TabIndex = 10
        '
        'lbmonto
        '
        Me.lbmonto.AutoSize = True
        Me.lbmonto.Location = New System.Drawing.Point(60, 99)
        Me.lbmonto.Name = "lbmonto"
        Me.lbmonto.Size = New System.Drawing.Size(40, 13)
        Me.lbmonto.TabIndex = 9
        Me.lbmonto.Text = "Monto:"
        '
        'lbtransaccion
        '
        Me.lbtransaccion.AutoSize = True
        Me.lbtransaccion.Location = New System.Drawing.Point(216, 99)
        Me.lbtransaccion.Name = "lbtransaccion"
        Me.lbtransaccion.Size = New System.Drawing.Size(69, 13)
        Me.lbtransaccion.TabIndex = 11
        Me.lbtransaccion.Text = "Transaccion:"
        '
        'cmbtransaccion
        '
        Me.cmbtransaccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbtransaccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtransaccion.FormattingEnabled = True
        Me.cmbtransaccion.Location = New System.Drawing.Point(291, 99)
        Me.cmbtransaccion.Name = "cmbtransaccion"
        Me.cmbtransaccion.Size = New System.Drawing.Size(121, 21)
        Me.cmbtransaccion.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(439, 99)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDatos.Location = New System.Drawing.Point(24, 147)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(551, 190)
        Me.dgvDatos.TabIndex = 14
        '
        'cmbcodigo
        '
        Me.cmbcodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbcodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcodigo.FormattingEnabled = True
        Me.cmbcodigo.Location = New System.Drawing.Point(110, 59)
        Me.cmbcodigo.Name = "cmbcodigo"
        Me.cmbcodigo.Size = New System.Drawing.Size(86, 21)
        Me.cmbcodigo.TabIndex = 15
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(520, 99)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 16
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'lbcomentario
        '
        Me.lbcomentario.AutoSize = True
        Me.lbcomentario.Location = New System.Drawing.Point(21, 359)
        Me.lbcomentario.Name = "lbcomentario"
        Me.lbcomentario.Size = New System.Drawing.Size(63, 13)
        Me.lbcomentario.TabIndex = 17
        Me.lbcomentario.Text = "Comentario:"
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(90, 359)
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.Size = New System.Drawing.Size(291, 44)
        Me.txtcomentario.TabIndex = 18
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(408, 347)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(89, 36)
        Me.btnguardar.TabIndex = 19
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(506, 347)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(89, 36)
        Me.btncancelar.TabIndex = 20
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'lbPartida
        '
        Me.lbPartida.AutoSize = True
        Me.lbPartida.Location = New System.Drawing.Point(436, 19)
        Me.lbPartida.Name = "lbPartida"
        Me.lbPartida.Size = New System.Drawing.Size(43, 13)
        Me.lbPartida.TabIndex = 21
        Me.lbPartida.Text = "Partida:"
        '
        'lbcontpartida
        '
        Me.lbcontpartida.AutoSize = True
        Me.lbcontpartida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcontpartida.ForeColor = System.Drawing.Color.Red
        Me.lbcontpartida.Location = New System.Drawing.Point(485, 14)
        Me.lbcontpartida.Name = "lbcontpartida"
        Me.lbcontpartida.Size = New System.Drawing.Size(19, 20)
        Me.lbcontpartida.TabIndex = 22
        Me.lbcontpartida.Text = "0"
        '
        'btnexport
        '
        Me.btnexport.Image = CType(resources.GetObject("btnexport.Image"), System.Drawing.Image)
        Me.btnexport.Location = New System.Drawing.Point(474, 389)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(50, 46)
        Me.btnexport.TabIndex = 23
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'formLibroDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 435)
        Me.Controls.Add(Me.btnexport)
        Me.Controls.Add(Me.lbcontpartida)
        Me.Controls.Add(Me.lbPartida)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.lbcomentario)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.cmbcodigo)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.cmbtransaccion)
        Me.Controls.Add(Me.lbtransaccion)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.lbmonto)
        Me.Controls.Add(Me.cmbcuenta)
        Me.Controls.Add(Me.lbcuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.lbfecha)
        Me.Name = "formLibroDiario"
        Me.Text = "Libro de Diario"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbfecha As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbcuenta As System.Windows.Forms.Label
    Friend WithEvents cmbcuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents lbmonto As System.Windows.Forms.Label
    Friend WithEvents lbtransaccion As System.Windows.Forms.Label
    Friend WithEvents cmbtransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcodigo As System.Windows.Forms.ComboBox
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents lbcomentario As System.Windows.Forms.Label
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents lbPartida As System.Windows.Forms.Label
    Friend WithEvents lbcontpartida As System.Windows.Forms.Label
    Friend WithEvents btnexport As System.Windows.Forms.Button

End Class
