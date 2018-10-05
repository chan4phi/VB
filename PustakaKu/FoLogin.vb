Imports System.Data
Imports System.Data.SqlClient
Public Class FoLogin
    Private Sub btbtl_Click(sender As Object, e As EventArgs) Handles btbtl.Click
        Application.Exit()
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String

        Try
            Call OpenKoneskis()
            query = "select * from Pengguna where UserID= '" & tbusr.Text & "' and Password= '" & tbpass.Text & "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows() Then
                Me.Hide()
                Fmain.Show()
            Else
                MsgBox("Anda Memasukkan data yang salah", vbCritical, "Pesan")
            End If
            dr.Close()
            Call TutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class