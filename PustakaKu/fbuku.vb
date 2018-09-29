Imports System.Data.SqlClient
Public Class fbuku

    Private Sub fbuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneskis()
        Dim cmd, cmd2 As SqlCommand
        Dim dr, dr2 As SqlDataReader
        Dim strsql, sql2 As String
        btupdt.Visible = False
        btsimpan.Visible = False
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
        lihat_list_buku()
    End Sub

    Private Sub btadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btadd.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim pngrng As Array = cbpengarang.Text.Split("-")
        Dim uid As String
        Dim pnrbt As Array = cbpenerbit.Text.Split("-")
        Dim cek As Boolean = False


        Call OpenKoneskis()
        Dim query_id As String = "select max(BukuID)+1 as MXID from Buku"
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        uid = dr("MXID")
        dr.Close()

        If (IsNumeric(tbstok.Text)) Then
            cek = True
        End If

        If (cek = False) Then
            MsgBox("data input tidak sesuai")
            Exit Sub
        End If
        Try
            query = "insert into Buku (BukuID, Judul, Pengarang, Stok, Penerbit, Sinopsis) values ( " & uid & ", '" & tbjubuk.Text & "',  '" & pngrng(0) & "', '" & tbstok.Text & "', '" & pnrbt(0) & "', '" & tbsinopsis.Text & "')"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            MsgBox("Data Berhasil diSimpan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Call bersih()
        LVbuku.Clear()
        lihat_list_buku()
        Call TutupKoneksi()
    End Sub

    Private Sub bersih()
        tbjubuk.Text = ""
        cbpenerbit.Text = ""
        cbpengarang.Text = ""
        tbstok.Text = ""
        tbsinopsis.Text = ""

    End Sub

    Private Sub lihat_list_buku()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVbuku.View = View.Details
        LVbuku.columns.add("No", 50)
        LVbuku.Columns.Add("Judul Buku", 300)
        LVbuku.Columns.Add("Pengarang", 150)
        LVbuku.Columns.Add("Penerbit", 200)

        Try
            Call OpenKoneskis()
            Dim query_id As String = "select * from Buku"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVbuku.Items.Add(dr("BukuID"))
                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("Judul"))
                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("Pengarang"))
                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("Penerbit"))
            Loop
            dr.Close()

            Call TutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim idbuku As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        idbuku = LVbuku.SelectedItems(0).Text

        Try
            Call OpenKoneskis()
            Dim query As String = "delete from Buku where BukuID= '" + idbuku + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call TutupKoneksi()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MsgBox("Data berhasil di hapus")
        LVbuku.Clear()
        lihat_list_buku()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idbuku As String
        btadd.Visible = False
        btupdt.Visible = True

        Try
            idbuku = LVbuku.SelectedItems(0).Text

            Call OpenKoneskis()
            Dim query As String = " select Buku.*, Pengarang.PengarangID, Penerbit.NamaPenerbit, " & _
                "Pengarang.NamaPengarang, Penerbit.PenerbitID from Buku " & _
                "LEFT JOIN Penerbit on PenerbitID=Buku.Penerbit " & _
                "LEFT JOIN Pengarang on Pengarang.PengarangID=Buku.Pengarang where Buku.BukuID = '" + idbuku + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            tbjubuk.Text = dr("Judul")
            cbpengarang.Text = dr("PengarangID") & "-" & dr("NamaPengarang")
            cbpenerbit.Text = dr("PenerbitID") & "-" & dr("NamaPenerbit")
            tbstok.Text = dr("Stok")
            tbsinopsis.Text = dr("Sinopsis")
            tbtemp.Text = dr("BukuID")
            dr.Close()
            Call TutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btupdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdt.Click
        btadd.Visible = True
        btupdt.Visible = False

        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim pngrng As Array = cbpengarang.Text.Split("-")
        Dim pnrbt As Array = cbpenerbit.Text.Split("-")
        Try
            Call OpenKoneskis()
            query = "update Buku set Judul = '" & tbjubuk.Text & "', Pengarang = '" & pngrng(0) & "', Penerbit = '" & pnrbt(0) & "' ,Stok = '" & tbstok.Text & "', Sinopsis = '" & tbsinopsis.Text & "' where bukuID = '" & tbtemp.Text & "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call TutupKoneksi()
            LVbuku.Clear()
            lihat_list_buku()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click

    End Sub
End Class
