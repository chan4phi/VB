Imports System.Data.SqlClient
Public Class FPeminjam
    Private Sub FPeminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fmain
        lihat_list_pmjnm()
        btubah.Visible = False
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
        btubah.Visible = False

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
        btSimpan.Visible = False
        btubah.Visible = True


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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        btSimpan.Visible = False
        btubah.Visible = True
        Dim mbrid As String

        Try
            mbrid = LVpmnjm.SelectedItems(0).Text

            Call OpenKoneskis()

            Dim query As String = "select * from Peminjam where peminjamID= '" + mbrid + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            tbid.Text = mbrid
            tbNama.Text = dr("NamaPeminjam")
            tbAlmt.Text = dr("Alamat")
            tbNoTelp.Text = dr("NoTelp")
            dr.Close()
            Call TutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btubah_Click(sender As Object, e As EventArgs) Handles btubah.Click
        Dim cm As SqlCommand
        Dim query As String
        Dim dr As SqlDataReader

        Try
            Call OpenKoneskis()
            query = "update Peminjam set NamaPeminjam = '" & tbNama.Text & "', Alamat = '" & tbAlmt.Text & "', NoTelp= '" & tbNoTelp.Text & "' where peminjamID= '" & tbid.Text & "'"
            cm = New SqlCommand(query, conn)
            dr = cm.ExecuteReader
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Call TutupKoneksi()

        MsgBox("Data berhasil di ubah")
        btubah.Visible = False
        btSimpan.Visible = True
        LVpmnjm.Clear()
        Call kosong()
        lihat_list_pmjnm()
    End Sub
    Private Sub kosong()
        tbAlmt.Text = ""
        tbNama.Text = ""
        tbNoTelp.Text = ""
        tbid.Text = ""
    End Sub
End Class