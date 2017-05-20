Public Class formLibroDiario
    Dim Partidas As New ArrayList()
    Dim movimientos As New ArrayList()
    Dim partida As New Hashtable()
    Dim movimiento As New Hashtable()
    Dim DebeTotal As Double = 0
    Dim HaberTotal As Double = 0
    Dim ContMovs As Integer = 0
    Dim ContPartida As Integer = 1
    Dim fecha As Date
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
        lbcontpartida.Text = ContPartida
        'cmbcodigo.Items.Add("1105")
        'mbcuenta.Items.Add("Caja")
        llenarCombos()


    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim codigo As String
        Dim cuenta As String
        Dim monto As Double
        Dim debe As Double
        Dim haber As Double
          
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
            monto = Double.Parse(txtmonto.Text.Trim)
        If (cmbtransaccion.SelectedItem.ToString = "CARGAR") Then
            debe = monto
        Else
            haber = monto
        End If
           

        dgvDatos.Rows(ContMovs).Cells(0).Value = codigo
        dgvDatos.Rows(ContMovs).Cells(0).ReadOnly = True
        dgvDatos.Rows(ContMovs).Cells(1).Value = cuenta
        dgvDatos.Rows(ContMovs).Cells(1).ReadOnly = True
        If (cmbtransaccion.SelectedItem.ToString = "CARGAR") Then
            dgvDatos.Rows(ContMovs).Cells(3).ReadOnly = True
        Else
            dgvDatos.Rows(ContMovs).Cells(2).ReadOnly = True
        End If

        dgvDatos.Rows(ContMovs).Cells(2).Value = debe
            dgvDatos.Rows(ContMovs).Cells(3).Value = haber


        
        ContMovs = ContMovs + 1
        cmbcodigo.SelectedIndex = -1
        cmbcuenta.SelectedIndex = -1
        cmbtransaccion.SelectedIndex = -1
        'txtfecha.Text = Nothing
        txtmonto.Text = Nothing


    End Sub

    Private Sub cmbcuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcuenta.SelectedIndexChanged
        cmbcodigo.SelectedIndex = cmbcuenta.SelectedIndex
    End Sub

    Private Sub cmbcodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodigo.SelectedIndexChanged
        cmbcuenta.SelectedIndex = cmbcodigo.SelectedIndex
    End Sub

    Private Sub llenarCombos()
        cmbcodigo.Items.Add("1.")
        cmbcuenta.Items.Add("ACTIVO")
        cmbcodigo.Items.Add("1.1.")
        cmbcuenta.Items.Add("ACTIVO CORRIENTE")
        cmbcodigo.Items.Add("1.1.1.")
        cmbcuenta.Items.Add("CAJA, BANCOS")
        cmbcodigo.Items.Add("1.1.1.10")
        cmbcuenta.Items.Add("CAJA GENERAL")
        cmbcodigo.Items.Add("1.1.1.20")
        cmbcuenta.Items.Add("CUENTA CONTROL")
        cmbcodigo.Items.Add("1.1.1.21")
        cmbcuenta.Items.Add("BANCO GYT")
        cmbcodigo.Items.Add("1.1.1.22")
        cmbcuenta.Items.Add("BANCO INDUSTRIAL")
        cmbcodigo.Items.Add("1.1.1.23")
        cmbcuenta.Items.Add("BANCO AGROMERCANTIL")
        cmbcodigo.Items.Add("1.1.2.")
        cmbcuenta.Items.Add("CTAS Y DTOS X COB CLIENTES")
        cmbcodigo.Items.Add("1.1.2.01")
        cmbcuenta.Items.Add("CLIENTES CIUDAD")
        cmbcodigo.Items.Add("1.1.2.02")
        cmbcuenta.Items.Add("CLIENTES INTERIOR")
        cmbcodigo.Items.Add("1.1.3.")
        cmbcuenta.Items.Add("(-)PROV CTAS INCOBRABLES")
        cmbcodigo.Items.Add("1.1.3.01")
        cmbcuenta.Items.Add("(-)PROV CTAS INCOBR CLIENTES")
        cmbcodigo.Items.Add("1.1.4.")
        cmbcuenta.Items.Add("OTRAS CUENTAS POR COBRAR")
        cmbcodigo.Items.Add("1.1.4.01")
        cmbcuenta.Items.Add("ANTICIPOS DE SUELDOS")
        cmbcodigo.Items.Add("1.1.4.02")
        cmbcuenta.Items.Add("ANTICIPOS A PROVEEDORES")
        cmbcodigo.Items.Add("1.1.5.")
        cmbcuenta.Items.Add("INVENTARIO DE SUMINIST. Y MATERIALES")
        cmbcodigo.Items.Add("1.1.5.01")
        cmbcuenta.Items.Add("SUMIN Y MATERLS DE OFICINA")
        cmbcodigo.Items.Add("1.1.6.")
        cmbcuenta.Items.Add("IMPUESTOS ANTICIPADOS")
        cmbcodigo.Items.Add("1.1.6.01")
        cmbcuenta.Items.Add("RETENCIONES EN LA FUENTE")
        cmbcodigo.Items.Add("1.1.6.02")
        cmbcuenta.Items.Add("ANTICIPOS DE IMPUESTO A LA RENTA")
        cmbcodigo.Items.Add("1.1.6.03")
        cmbcuenta.Items.Add("IVA EN COMPRAS")
        cmbcodigo.Items.Add("1.1.7.")
        cmbcuenta.Items.Add("INVENTARIOS DE PRODUCT. TERMINADOS")
        cmbcodigo.Items.Add("1.1.7.01")
        cmbcuenta.Items.Add("EQUIPO DE MONTAÑA")
        cmbcodigo.Items.Add("1.1.8.")
        cmbcuenta.Items.Add("OTROS ACTIVOS CORRIENTES")
        cmbcodigo.Items.Add("1.1.8.01")
        cmbcuenta.Items.Add("ARRIENDOS PAGADOS POR ANTICIPADO")
        cmbcodigo.Items.Add("1.1.8.02")
        cmbcuenta.Items.Add("PUBLICIDAD PAGADA POR ANTICIPADO")
        cmbcodigo.Items.Add("1.2.")
        cmbcuenta.Items.Add("ACTIVO FIJO")
        cmbcodigo.Items.Add("1.2.1.")
        cmbcuenta.Items.Add("TERRENOS, EDIFICIOS E INSTALACIONES")
        cmbcodigo.Items.Add("1.2.1.01")
        cmbcuenta.Items.Add("TERRENO")
        cmbcodigo.Items.Add("1.2.2.")
        cmbcuenta.Items.Add("MAQUIN, MUEBLES, ENSERES Y EQUIPO")
        cmbcodigo.Items.Add("1.2.2.01")
        cmbcuenta.Items.Add("MUEBLES Y ENSERES")
        cmbcodigo.Items.Add("1.2.2.02")
        cmbcuenta.Items.Add("EQUIPO DE OFICINA")
        cmbcodigo.Items.Add("1.2.3.")
        cmbcuenta.Items.Add("VEHICULOS")
        cmbcodigo.Items.Add("1.2.3.01")
        cmbcuenta.Items.Add("VEHICULOS")
        cmbcodigo.Items.Add("1.2.4.")
        cmbcuenta.Items.Add("OTROS ACTIVOS FIJOS")
        cmbcodigo.Items.Add("1.2.4.01")
        cmbcuenta.Items.Add("DERECHOS DE AUTOR")
        cmbcodigo.Items.Add("1.2.5.")
        cmbcuenta.Items.Add("(-)DEPRECIACION ACUMULADA")
        cmbcodigo.Items.Add("1.2.5.01")
        cmbcuenta.Items.Add("(-)DEPRECIACION ACUMULADA")
        cmbcodigo.Items.Add("1.3.")
        cmbcuenta.Items.Add("ACTIVOS NO CORRIENTES")
        cmbcodigo.Items.Add("1.3.1.")
        cmbcuenta.Items.Add("GASTOS DE ORGANIZAC. Y CONSTITUCION")
        cmbcodigo.Items.Add("1.3.1.01")
        cmbcuenta.Items.Add("GASTOS DE ORGANIZAC. Y CONSTITUCION")
        cmbcodigo.Items.Add("1.3.2.")
        cmbcuenta.Items.Add("GASTOS INVESTIGACION, EXPL Y OTROS")
        cmbcodigo.Items.Add("1.3.2.01")
        cmbcuenta.Items.Add("INVESTIGACION DE MERCADOS")
        cmbcodigo.Items.Add("1.3.3.")
        cmbcuenta.Items.Add("OTROS ACTIVOS NO CORRIENTES")
        cmbcodigo.Items.Add("1.3.3.01")
        cmbcuenta.Items.Add("DEPOSITOS EN GARANTIA")
        cmbcodigo.Items.Add("1.3.4.")
        cmbcuenta.Items.Add("(-)AMORTIZACION ACUMULADA")
        cmbcodigo.Items.Add("1.3.4.01")
        cmbcuenta.Items.Add("(-)AMORTIZACION ACUMULADA")
        cmbcodigo.Items.Add("2 ")
        cmbcuenta.Items.Add("PASIVO")
        cmbcodigo.Items.Add("2.1.")
        cmbcuenta.Items.Add("PASIVO CORRIENTE")
        cmbcodigo.Items.Add("2.1.1.")
        cmbcuenta.Items.Add("CUENTAS POR PAGAR")
        cmbcodigo.Items.Add("2.1.1.01")
        cmbcuenta.Items.Add("PROVEEDORES")
        cmbcodigo.Items.Add("2.1.1.02")
        cmbcuenta.Items.Add("SUELDOS POR PAGAR")
        cmbcodigo.Items.Add("2.1.2.")
        cmbcuenta.Items.Add("DOCUMENTOS POR PAGAR")
        cmbcodigo.Items.Add("2.1.2.01")
        cmbcuenta.Items.Add("DOCUMENTOS POR PAGAR")
        cmbcodigo.Items.Add("2.1.3.")
        cmbcuenta.Items.Add("PROV SOCIALES POR PAGAR")
        cmbcodigo.Items.Add("2.1.3.01")
        cmbcuenta.Items.Add("DECIMO TERCER SUELDO")
        cmbcodigo.Items.Add("2.1.3.02")
        cmbcuenta.Items.Add("DECIMO CUARTO SUELDO")
        cmbcodigo.Items.Add("2.1.3.03")
        cmbcuenta.Items.Add("VACACIONES")
        cmbcodigo.Items.Add("2.1.4.")
        cmbcuenta.Items.Add("OBLIGAC: IESS E IMPUESTOS")
        cmbcodigo.Items.Add("2.1.4.01")
        cmbcuenta.Items.Add("APORTE PATRONAL")
        cmbcodigo.Items.Add("2.1.4.02")
        cmbcuenta.Items.Add("APORTE INDIVIDUAL")
        cmbcodigo.Items.Add("2.1.4.03")
        cmbcuenta.Items.Add("FONDO DE RESERVA")
        cmbcodigo.Items.Add("2.1.4.04")
        cmbcuenta.Items.Add("RETENCIONES A EMPLEADOS")
        cmbcodigo.Items.Add("2.1.4.05")
        cmbcuenta.Items.Add("RETENC. FUENTE 1%")
        cmbcodigo.Items.Add("2.1.4.06")
        cmbcuenta.Items.Add("RETENC. FUENTE 2%")
        cmbcodigo.Items.Add("2.1.4.07")
        cmbcuenta.Items.Add("RETENC. FUENTE 8%")
        cmbcodigo.Items.Add("2.1.4.08")
        cmbcuenta.Items.Add("RETENC. FUENTE 25%")
        cmbcodigo.Items.Add("2.1.4.09")
        cmbcuenta.Items.Add("IVA EN VENTAS")
        cmbcodigo.Items.Add("2.1.4.10")
        cmbcuenta.Items.Add("RETENC. IVA 30%")
        cmbcodigo.Items.Add("2.1.4.11")
        cmbcuenta.Items.Add("RETENC. IVA 70%")
        cmbcodigo.Items.Add("2.1.4.12")
        cmbcuenta.Items.Add("RETENC. IVA 100%")
        cmbcodigo.Items.Add("2.1.4.13")
        cmbcuenta.Items.Add("PRESTAMOS QUIROGRAFARIOS IESS")
        cmbcodigo.Items.Add("2.1.5.")
        cmbcuenta.Items.Add("OTROS PASIVOS CORRIENTES")
        cmbcodigo.Items.Add("2.1.5.01")
        cmbcuenta.Items.Add("COBROS ANTICIPADOS")
        cmbcodigo.Items.Add("2.2.")
        cmbcuenta.Items.Add("PASIVO LARGO PLAZO-NO CORRIENTE")
        cmbcodigo.Items.Add("2.2.1.")
        cmbcuenta.Items.Add("CTAS Y DTOS X PAG-LARGO PLAZO")
        cmbcodigo.Items.Add("2.2.1.01")
        cmbcuenta.Items.Add("PRESTAMO BCO PICHINCHA LARGO PLAZO")
        cmbcodigo.Items.Add("2.2.2.")
        cmbcuenta.Items.Add("OTROS PASIVOS A LARGO PLAZO")
        cmbcodigo.Items.Add("3.")
        cmbcuenta.Items.Add("PATRIMONIO")
        cmbcodigo.Items.Add("3.1.")
        cmbcuenta.Items.Add("PATRIMONIO NETO")
        cmbcodigo.Items.Add("3.1.1.")
        cmbcuenta.Items.Add("CAPITAL SUSCRITO Y/O ASIGNADO")
        cmbcodigo.Items.Add("3.1.1.01")
        cmbcuenta.Items.Add("CAPITAL")
        cmbcodigo.Items.Add("3.1.2.")
        cmbcuenta.Items.Add("RESERVAS")
        cmbcodigo.Items.Add("3.1.2.01")
        cmbcuenta.Items.Add("RESERVA LEGAL")
        cmbcodigo.Items.Add("3.1.2.02")
        cmbcuenta.Items.Add("OTRAS RESERVAS")
        cmbcodigo.Items.Add("3.1.3.")
        cmbcuenta.Items.Add("UTILIDADES/PERDIDAS ACUMULADAS")
        cmbcodigo.Items.Add("3.1.3.01")
        cmbcuenta.Items.Add("UTIL/PERD ACUM EJERCICIOS ANTERIORES")
        cmbcodigo.Items.Add("3.1.3.02")
        cmbcuenta.Items.Add("RESULTADOS PRESENTE EJERCICIO")
        cmbcodigo.Items.Add("4.")
        cmbcuenta.Items.Add("INGRESOS")
        cmbcodigo.Items.Add("4.1.")
        cmbcuenta.Items.Add("INGRESOS OPERACIONALES")
        cmbcodigo.Items.Add("4.1.1.")
        cmbcuenta.Items.Add("VENTAS GRAVADAS CON IVA")
        cmbcodigo.Items.Add("4.1.1.01")
        cmbcuenta.Items.Add("VENTAS DE SERVICIOS")
        cmbcodigo.Items.Add("4.1.1.02")
        cmbcuenta.Items.Add("ALQUILER EQUIPO DE MONTAÑA")
        cmbcodigo.Items.Add("4.1.2.")
        cmbcuenta.Items.Add("VENTAS EXC DE IVA O NO GRABADAS")
        cmbcodigo.Items.Add("4.1.2.01")
        cmbcuenta.Items.Add("VENTAS EXCENTAS DE IVA")
        cmbcodigo.Items.Add("4.1.3.")
        cmbcuenta.Items.Add("EXPORTACIONES")
        cmbcodigo.Items.Add("4.1.3.01")
        cmbcuenta.Items.Add("EXPORTACIONES")
        cmbcodigo.Items.Add("4.1.4.")
        cmbcuenta.Items.Add("(-)DEVOL Y DESCUENTOS EN VENTAS")
        cmbcodigo.Items.Add("4.1.4.01")
        cmbcuenta.Items.Add("(-)DEVOL Y DESCUENTOS EN VENTAS")
        cmbcodigo.Items.Add("4.2.")
        cmbcuenta.Items.Add("INGRESOS NO OPERACIONALES")
        cmbcodigo.Items.Add("4.2.1.")
        cmbcuenta.Items.Add("OTROS INGRESOS")
        cmbcodigo.Items.Add("4.2.1.01")
        cmbcuenta.Items.Add("INTERESES GANADOS")
        cmbcodigo.Items.Add("4.2.1.02")
        cmbcuenta.Items.Add("UTILIDAD EN VENTA DE ACTIVOS FIJOS")
        cmbcodigo.Items.Add("4.2.1.03")
        cmbcuenta.Items.Add("OTRAS RENTAS")
        cmbcodigo.Items.Add("5.")
        cmbcuenta.Items.Add("GASTOS")
        cmbcodigo.Items.Add("5.1.")
        cmbcuenta.Items.Add("COSTO DE VENTAS")
        cmbcodigo.Items.Add("5.1.1.")
        cmbcuenta.Items.Add("COSTO DE VENTAS")
        cmbcodigo.Items.Add("5.1.1.01")
        cmbcuenta.Items.Add("COSTO DE VENTAS")
        cmbcodigo.Items.Add("5.2.")
        cmbcuenta.Items.Add("GASTOS DE ADMINIST Y VTAS")
        cmbcodigo.Items.Add("5.2.1.")
        cmbcuenta.Items.Add("SUELD/SAL/BEN SOC E INDEM")
        cmbcodigo.Items.Add("5.2.1.01")
        cmbcuenta.Items.Add("SUELDOS Y SALARIOS")
        cmbcodigo.Items.Add("5.2.1.02")
        cmbcuenta.Items.Add("DECIMO TERCER SUELDO")
        cmbcodigo.Items.Add("5.2.1.03")
        cmbcuenta.Items.Add("DECIMO CUARTO SUELDO")
        cmbcodigo.Items.Add("5.2.1.04")
        cmbcuenta.Items.Add("VACACIONES")
        cmbcodigo.Items.Add("5.2.1.05")
        cmbcuenta.Items.Add("FONDO DE RESERVA")
        cmbcodigo.Items.Add("5.2.1.06")
        cmbcuenta.Items.Add("GASTO APORTE PATRONAL")
        cmbcodigo.Items.Add("5.2.2.")
        cmbcuenta.Items.Add("COMISIONES EN VTAS Y PUBL")
        cmbcodigo.Items.Add("5.2.2.01")
        cmbcuenta.Items.Add("COMISIONES EN VENTAS")
        cmbcodigo.Items.Add("5.2.2.02")
        cmbcuenta.Items.Add("PUBLICIDAD")
        cmbcodigo.Items.Add("5.2.3.")
        cmbcuenta.Items.Add("GASTOS DE GESTION")
        cmbcodigo.Items.Add("5.2.3.01")
        cmbcuenta.Items.Add("GESTIONES VARIAS")
        cmbcodigo.Items.Add("5.2.4.")
        cmbcuenta.Items.Add("AGUA, LUZ, TELEFONO, TELEX Y FAX")
        cmbcodigo.Items.Add("5.2.4.01")
        cmbcuenta.Items.Add("AGUA")
        cmbcodigo.Items.Add("5.2.4.02")
        cmbcuenta.Items.Add("LUZ")
        cmbcodigo.Items.Add("5.2.4.03")
        cmbcuenta.Items.Add("TELEFONOS Y FAX")
        cmbcodigo.Items.Add("5.2.4.04")
        cmbcuenta.Items.Add("INTERNET")
        cmbcodigo.Items.Add("5.2.5.")
        cmbcuenta.Items.Add("IMPUESTOS, CONTRIBUCIONES Y OTROS")
        cmbcodigo.Items.Add("5.2.5.01")
        cmbcuenta.Items.Add("IMPUESTOS FISCALES Y MUNICIP.")
        cmbcodigo.Items.Add("5.2.5.02")
        cmbcuenta.Items.Add("CONTRIB. SUPERINT. DE CIAS.")
        cmbcodigo.Items.Add("5.2.6.")
        cmbcuenta.Items.Add("DEPREC DE BIENES Y AMORT.")
        cmbcodigo.Items.Add("5.2.6.01")
        cmbcuenta.Items.Add("DEPRECIACION DE MUEB Y ENS.")
        cmbcodigo.Items.Add("5.2.6.02")
        cmbcuenta.Items.Add("DEPRECIACION EQUIPOS DE OFIC.")
        cmbcodigo.Items.Add("5.2.6.03")
        cmbcuenta.Items.Add("AMORTIZACIONES")
        cmbcodigo.Items.Add("5.2.7.")
        cmbcuenta.Items.Add("CTAS INCOB Y BAJA DE INV.")
        cmbcodigo.Items.Add("5.2.7.01")
        cmbcuenta.Items.Add("CUENTAS INCOBRABLES")
        cmbcodigo.Items.Add("5.2.8.")
        cmbcuenta.Items.Add("INTERESES Y COMISIONES")
        cmbcodigo.Items.Add("5.2.8.01")
        cmbcuenta.Items.Add("GASTO INTERESES")
        cmbcodigo.Items.Add("5.2.8.02")
        cmbcuenta.Items.Add("COMISIONES BANCARIAS")
        cmbcodigo.Items.Add("5.2.9.")
        cmbcuenta.Items.Add("OTROS GTOS DE ADM Y VTAS.")
        cmbcodigo.Items.Add("5.2.9.01")
        cmbcuenta.Items.Add("GASTOS DE VIAJE")
        cmbcodigo.Items.Add("5.2.9.02")
        cmbcuenta.Items.Add("ARRIENDOS")
        cmbcodigo.Items.Add("5.2.9.03")
        cmbcuenta.Items.Add("SERVICIOS DE HOSPEDAJE")
        cmbcodigo.Items.Add("5.2.9.04")
        cmbcuenta.Items.Add("TRANSPORTE")
        cmbcodigo.Items.Add("5.3.")
        cmbcuenta.Items.Add("GASTOS NO OPERACIONALES")
        cmbcodigo.Items.Add("5.3.1.")
        cmbcuenta.Items.Add("PERDIDA EN VTA DE ACTIVOS")
        cmbcodigo.Items.Add("5.3.1.01")
        cmbcuenta.Items.Add("PERDIDA EN VTA DE ACTIVOS FIJ.")
        cmbcodigo.Items.Add("5.3.2.")
        cmbcuenta.Items.Add("OTROS GASTOS NO OPERACNLS")
        cmbcodigo.Items.Add("5.3.2.01")
        cmbcuenta.Items.Add("MANTENIMIENTO DE OFICINAS")






    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If Not dgvDatos.CurrentRow.IsNewRow Then
            dgvDatos.Rows.Remove(dgvDatos.CurrentRow)
            ContMovs = ContMovs - 1
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        DebeTotal = 0
        HaberTotal = 0
        If (txtfecha.Text = "" Or txtfecha.Text.Trim = Nothing) Then
            MsgBox("Debe ingresar una fecha para guardar la partida")
            Return
        End If
        If (txtcomentario.Text = "" Or txtcomentario.Text.Trim = Nothing) Then
            MsgBox("Debe ingresar un comentario para guardar la partida")
            Return
        End If
        Try
            fecha = Convert.ToDateTime(txtfecha.Text.Trim)
            Console.WriteLine("'{0}' converts to {1}.", txtfecha.Text.Trim, fecha)
        Catch ex As FormatException
            Console.WriteLine(ex.Message)
            MsgBox("Debe ingresar un formato de fecha correcto")
            Return
        End Try

        For index As Integer = 0 To (ContMovs - 1)
            DebeTotal = DebeTotal + dgvDatos.Rows(index).Cells(2).Value
            HaberTotal = HaberTotal + dgvDatos.Rows(index).Cells(3).Value
        Next

        Console.WriteLine("DebeTotal:" & DebeTotal)
        Console.WriteLine("HaberTotal:" & HaberTotal)
        If (DebeTotal <> HaberTotal) Then
            MsgBox("La partida no esta cuadrada, debe cuadrarla para guardar")
            Return
        End If

        For index As Integer = 0 To (ContMovs - 1)
            movimiento.Add("CODIGO", dgvDatos.Rows(index).Cells(0).Value)
            movimiento.Add("CUENTA", dgvDatos.Rows(index).Cells(1).Value)
            movimiento.Add("DEBE", dgvDatos.Rows(index).Cells(2).Value)
            movimiento.Add("HABER", dgvDatos.Rows(index).Cells(3).Value)
            movimientos.Add(movimiento)
            movimiento.Clear()
        Next
        ContPartida = ContPartida + 1
        lbcontpartida.Text = ContPartida
        partida.Add("FECHA", fecha)
        partida.Add("MOVIMIENTOS", movimientos)
        partida.Add("COMENTARIO", txtcomentario.Text.Trim)
        partida.Add("DEBETOTAL", DebeTotal)
        partida.Add("HABERTOTAL", HaberTotal)

        Partidas.Add(partida)

        ContMovs = 0
        partida.Clear()
        movimientos.Clear()
        dgvDatos.Rows.Clear()
        dgvDatos.RowCount = 30
        txtfecha.Text = Nothing
        txtcomentario.Text = Nothing

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        ContMovs = 0
        partida.Clear()
        movimientos.Clear()
        dgvDatos.Rows.Clear()
        dgvDatos.RowCount = 30
        txtfecha.Text = Nothing

        cmbcodigo.SelectedIndex = -1
        cmbcuenta.SelectedIndex = -1
        cmbtransaccion.SelectedIndex = -1
       txtmonto.Text = Nothing

    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        ' Displays a SaveFileDialog so the user can save the Image
        ' assigned to Button2.
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel |*.xlsx"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.
        If saveFileDialog1.FileName <> "" Then
              Console.WriteLine("ruta: "&saveFileDialog1.FileName)


            ' Saves the Image via a FileStream created by the OpenFile method.
            ' Dim fs As System.IO.FileStream = CType _
            ' (saveFileDialog1.OpenFile(), System.IO.FileStream)
            ' Saves the Image in the appropriate ImageFormat based upon the
            ' file type selected in the dialog box.
            ' NOTE that the FilterIndex property is one-based.
            '  Select Case saveFileDialog1.FilterIndex
            '   Case 1
            ' Me.button2.Image.Save(fs, _
            ' System.Drawing.Imaging.ImageFormat.Jpeg)

            '   Case 2
            ' Me.button2.Image.Save(fs, _
            ' System.Drawing.Imaging.ImageFormat.Bmp)

            ' Case 3
            '  Me.button2.Image.Save(fs, _
            ' System.Drawing.Imaging.ImageFormat.Gif)
            ' End Select

            'fs.Close()
        End If
    End Sub
End Class
