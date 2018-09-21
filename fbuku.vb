Imports System.Data.SqlClient
Public Class fbuku

    Private Sub fbuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneskis()
        Dim cmd, cmd2 As SqlCommand
        Dim dr, dr2 As SqlDataReader
        Dim strsql, sql2 As String

        Try
            strsql = "select * from Pengarang"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader
            cbpengarang.Items.Clear()
            Do While dr.Read
                cbpengarang.Items.Add(dr("PengarangID") & " - " & dr("NamaPengarang"))
            Loop
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Call TutupKoneksi()
        Try
            Call OpenKoneskis()
            sql2 = "select * from Penerbit"
            cmd2 = New SqlCommand(sql2, conn)
            dr2 = cmd2.ExecuteReader
            cbpenerbit.Items.Clear()
            Do While dr2.Read
                cbpenerbit.Items.Add(dr2("PenerbitID") & " - " & dr2("NamaPenerbit"))
            Loop
            dr2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Call TutupKoneksi()
    End Sub

    Private Sub tbadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbadd.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim pngrng As Array = cbpengarang.Text.Split("-")
        Dim uid As String
        Dim pnrbt As Array = cbpenerbit.Text.Split("-")
        Try
            
            Call OpenKoneskis()
            Dim query_id As String = "select max(BukuID)+1 as MXID from Buku"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "insert into Buku (BukuID, PengarangID, penerbit, judul, sinopsis, stok) values ( " & uid & ",  '" & pngrng(0) & "', '" & pnrbt(0) & "', '" & tbjubuk.Text & "', '" & tbsinopsis.Text & "', '" & tbstok.Text & "'))"

            cmd = New SqlCommand(query, conn)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Call TutupKoneksi()
    End Sub
End Class
