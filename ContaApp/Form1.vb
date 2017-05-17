Public Class Form1

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

    End Sub
End Class
