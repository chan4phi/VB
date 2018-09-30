<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerbitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukuToolStripMenuItem, Me.PeminjamToolStripMenuItem, Me.PengarangToolStripMenuItem, Me.PenerbitToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1116, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'PeminjamToolStripMenuItem
        '
        Me.PeminjamToolStripMenuItem.Name = "PeminjamToolStripMenuItem"
        Me.PeminjamToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PeminjamToolStripMenuItem.Text = "Peminjam"
        '
        'PengarangToolStripMenuItem
        '
        Me.PengarangToolStripMenuItem.Name = "PengarangToolStripMenuItem"
        Me.PengarangToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.PengarangToolStripMenuItem.Text = "Pengarang"
        '
        'PenerbitToolStripMenuItem
        '
        Me.PenerbitToolStripMenuItem.Name = "PenerbitToolStripMenuItem"
        Me.PenerbitToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.PenerbitToolStripMenuItem.Text = "Penerbit"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'Fmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 512)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fmain"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenerbitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
End Class
