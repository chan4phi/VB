Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module modkon
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source=MIKEHAHN;" &
                            "Initial Catalog=dbPerpus;" &
                            "Persist Security Info=True;" &
                            "UID=sa;PWD=m3ll1s4m4y4"

    Public Sub OpenKoneskis()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal: " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub TutupKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Error " & ex.ToString)
            End Try
        End If

    End Sub
End Module
