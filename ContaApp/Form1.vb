Public Class formLibroDiario
    Dim Partidas As New ArrayList()
    Dim partida As New Hashtable()
    Dim DebeTotal As Double = 0
    Dim HaberTotal As Double = 0
    Dim ContMovs As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbfecha.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvDatos.ColumnCount = 4
        dgvDatos.RowCount = 30
        dgvDatos.ColumnHeadersHeight = 200
        dgvDatos.Columns(0).HeaderText = "CODIGO"
        dgvDatos.Columns(0).Width = 50
        dgvDatos.Columns(1).HeaderText = "DESCRIPCION DE LA CUENTA"
        dgvDatos.Columns(1).Width = 250
        dgvDatos.Columns(2).HeaderText = "DEBE"
        dgvDatos.Columns(2).Width = 100
        dgvDatos.Columns(3).HeaderText = "HABER"
        dgvDatos.Columns(3).Width = 100


        cmbtransaccion.Items.Add("CARGAR")
        cmbtransaccion.Items.Add("ABONAR")

        cmbcodigo.Items.Add("1105")
        cmbcuenta.Items.Add("Caja")


    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim movimientos As New Hashtable()
        Dim codigo As String
        Dim cuenta As String
        Dim monto As Double
        Dim debe As Double
        Dim haber As Double
          If (txtfecha.Text = "" Or txtfecha.Text.Trim = Nothing) Then
                MsgBox("Debe ingresar una fecha")
                Return
            End If
            If (cmbcodigo.SelectedIndex = -1) Then
            MsgBox("Debe ingresar un valor en el codigo")
            Return
            End If
            If (cmbcuenta.SelectedIndex = -1) Then
            MsgBox("Debe ingresar una cuenta")
            Return
            End If
            If (txtmonto.Text = "" Or txtmonto.Text = Nothing) Then
            MsgBox("Debe ingresar un monto")
            Return
            End If
            If (cmbtransaccion.SelectedIndex = -1) Then
            MsgBox("Debe seleccionar una transaccion")
            Return
            End If

            codigo = cmbcodigo.SelectedItem.ToString
            cuenta = cmbcuenta.SelectedItem.ToString
            monto = Double.Parse(txtmonto.Text)
            If (cmbtransaccion.SelectedText = "CARGAR") Then
                debe = monto
            Else
                haber = monto
            End If
            movimientos.Add("CODIGO", codigo)
            movimientos.Add("CUENTA", cuenta)
            movimientos.Add("DEBE", debe)
        movimientos.Add("HABER", haber)


            dgvDatos.Rows(ContMovs).Cells(0).Value = codigo
            dgvDatos.Rows(ContMovs).Cells(1).Value = cuenta
            dgvDatos.Rows(ContMovs).Cells(2).Value = debe
            dgvDatos.Rows(ContMovs).Cells(3).Value = haber



        ContMovs = ContMovs + 1


    End Sub

    Private Sub cmbcuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcuenta.SelectedIndexChanged
        cmbcodigo.SelectedIndex = cmbcuenta.SelectedIndex
    End Sub

    Private Sub cmbcodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodigo.SelectedIndexChanged
        cmbcuenta.SelectedIndex = cmbcodigo.SelectedIndex
    End Sub

    Private Sub llenarCombos()
        cmbcodigo.Items.Add("1105")
        cmbcuenta.Items.Add("Caja")


    End Sub
End Class
