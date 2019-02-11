Imports System.Data.SqlClient

Public Class Usuario
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String = "Data Source=.;Initial Catalog=Chequeo_de_Vehiculos;Integrated Security=True"
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim comanda As String = "select * from Usuarios where Usuario = '" & txtUsuario.Text & "' and contraseña = '" & txtContraseña.Text & "'"

        Try
            da = New SqlDataAdapter(comanda, conexion)
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                MenuPrincipal.Show()
                Me.Hide()
            Else
                MsgBox("El Usuario o Contraseña Son incorrecto")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
