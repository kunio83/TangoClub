Imports System.Data.SqlClient
Public Class frmListados
    Dim con As New SqlConnection

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        con.Open()
        Dim Busc As New SqlDataAdapter("SELECT * FROM TangoClub WHERE " & cmbItem.Text & " LIKE '%' + '" & txtbusq.Text & "' + '%' ORDER BY " & cmbItem.Text, con)
        Dim Tabla As New DataTable
        Busc.Fill(Tabla)
        dtgInfo.DataSource = Tabla
        dtgInfo.Refresh()
        con.Close()
    End Sub

    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(local);Initial Catalog=TangoClubCatalogo;Integrated Security=True"
        con.Open()
        Dim Nomcol As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'TangoClub'", con)
        Dim resul As SqlDataReader = Nomcol.ExecuteReader
        While resul.Read()
            cmbItem.Items.Add(CStr(resul("COLUMN_NAME")))
        End While
        con.Close()
    End Sub
End Class