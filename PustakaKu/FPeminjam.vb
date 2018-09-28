Imports System.Data.SqlClient
Public Class FPeminjam
    Private Sub FPeminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lihat_list_pmjnm()
    End Sub
    Private Sub lihat_list_pmjnm()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVpmnjm.View = View.Details
        LVpmnjm.Columns.Add("No", 50)
        LVpmnjm.Columns.Add("Nama", 300)
        LVpmnjm.Columns.Add("Alamat", 150)
        LVpmnjm.Columns.Add("No_Telp", 200)

        Try
            Call OpenKoneskis()
            Dim query_id As String = "select * from Peminjam"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVpmnjm.Items.Add(dr("peminjamID"))
                LVpmnjm.Items(LVpmnjm.Items.Count - 1).SubItems.Add(dr("NamaPeminjam"))
                LVpmnjm.Items(LVpmnjm.Items.Count - 1).SubItems.Add(dr("Alamat"))
                LVpmnjm.Items(LVpmnjm.Items.Count - 1).SubItems.Add(dr("NoTelp"))
            Loop
            dr.Close()

            Call TutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub berih()
        tbNama.Text = ""
        tbAlmt.Text = ""
        tbNoTelp.Text = ""
    End Sub

    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String


        Call OpenKoneskis()
        Dim query_id As String = "select max(peminjamID)+1 as MXID from Peminjam"
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        uid = dr("MXID")
        dr.Close()

        Try
            query = "insert into Peminjam (peminjamID, NamaPeminjam, Alamat, NoTelp) values ( " & uid & ", '" & tbNama.Text & "',  '" & tbAlmt.Text & "', '" & tbNoTelp.Text & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            MsgBox("Data Berhasil diSimpan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Call berih()
        LVpmnjm.Clear()
        lihat_list_pmjnm()
        Call TutupKoneksi()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim idmmbr As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        idmmbr = LVpmnjm.SelectedItems(0).Text

        Try
            Call OpenKoneskis()
            Dim query As String = "delete from Peminjam where peminjamID= '" + idmmbr + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call TutupKoneksi()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MsgBox("Data berhasil di hapus")
        LVpmnjm.Clear()
        lihat_list_pmjnm()
    End Sub
End Class