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
        Me.lbfecha = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lbcuenta = New System.Windows.Forms.Label()
        Me.cmbcuenta = New System.Windows.Forms.ComboBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.lbmonto = New System.Windows.Forms.Label()
        Me.lbtransaccion = New System.Windows.Forms.Label()
        Me.cmbtransaccion = New System.Windows.Forms.ComboBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbfecha
        '
        Me.lbfecha.AutoSize = True
        Me.lbfecha.Location = New System.Drawing.Point(12, 9)
        Me.lbfecha.Name = "lbfecha"
        Me.lbfecha.Size = New System.Drawing.Size(40, 13)
        Me.lbfecha.TabIndex = 3
        Me.lbfecha.Text = "Fecha:"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(15, 26)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(87, 20)
        Me.txtfecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(64, 53)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(87, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'lbcuenta
        '
        Me.lbcuenta.AutoSize = True
        Me.lbcuenta.Location = New System.Drawing.Point(171, 53)
        Me.lbcuenta.Name = "lbcuenta"
        Me.lbcuenta.Size = New System.Drawing.Size(44, 13)
        Me.lbcuenta.TabIndex = 7
        Me.lbcuenta.Text = "Cuenta:"
        '
        'cmbcuenta
        '
        Me.cmbcuenta.FormattingEnabled = True
        Me.cmbcuenta.Location = New System.Drawing.Point(221, 50)
        Me.cmbcuenta.Name = "cmbcuenta"
        Me.cmbcuenta.Size = New System.Drawing.Size(258, 21)
        Me.cmbcuenta.TabIndex = 8
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(64, 89)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(87, 20)
        Me.txtmonto.TabIndex = 10
        '
        'lbmonto
        '
        Me.lbmonto.AutoSize = True
        Me.lbmonto.Location = New System.Drawing.Point(15, 89)
        Me.lbmonto.Name = "lbmonto"
        Me.lbmonto.Size = New System.Drawing.Size(40, 13)
        Me.lbmonto.TabIndex = 9
        Me.lbmonto.Text = "Monto:"
        '
        'lbtransaccion
        '
        Me.lbtransaccion.AutoSize = True
        Me.lbtransaccion.Location = New System.Drawing.Point(171, 89)
        Me.lbtransaccion.Name = "lbtransaccion"
        Me.lbtransaccion.Size = New System.Drawing.Size(69, 13)
        Me.lbtransaccion.TabIndex = 11
        Me.lbtransaccion.Text = "Transaccion:"
        '
        'cmbtransaccion
        '
        Me.cmbtransaccion.FormattingEnabled = True
        Me.cmbtransaccion.Location = New System.Drawing.Point(246, 89)
        Me.cmbtransaccion.Name = "cmbtransaccion"
        Me.cmbtransaccion.Size = New System.Drawing.Size(121, 21)
        Me.cmbtransaccion.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(394, 89)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(24, 147)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(551, 190)
        Me.dgvDatos.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 349)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.cmbtransaccion)
        Me.Controls.Add(Me.lbtransaccion)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.lbmonto)
        Me.Controls.Add(Me.cmbcuenta)
        Me.Controls.Add(Me.lbcuenta)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.lbfecha)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbfecha As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lbcuenta As System.Windows.Forms.Label
    Friend WithEvents cmbcuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents lbmonto As System.Windows.Forms.Label
    Friend WithEvents lbtransaccion As System.Windows.Forms.Label
    Friend WithEvents cmbtransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView

End Class
