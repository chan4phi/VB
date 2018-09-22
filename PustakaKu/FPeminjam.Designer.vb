<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPeminjam
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.LVpmnjm = New System.Windows.Forms.ListView()
        Me.tbAlmt = New System.Windows.Forms.TextBox()
        Me.tbNoTelp = New System.Windows.Forms.TextBox()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.CMSlv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSlv.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Telpon"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(94, 22)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(199, 20)
        Me.tbNama.TabIndex = 4
        '
        'LVpmnjm
        '
        Me.LVpmnjm.Location = New System.Drawing.Point(12, 165)
        Me.LVpmnjm.Name = "LVpmnjm"
        Me.LVpmnjm.Size = New System.Drawing.Size(623, 207)
        Me.LVpmnjm.TabIndex = 5
        Me.LVpmnjm.UseCompatibleStateImageBehavior = False
        '
        'tbAlmt
        '
        Me.tbAlmt.Location = New System.Drawing.Point(94, 63)
        Me.tbAlmt.Multiline = True
        Me.tbAlmt.Name = "tbAlmt"
        Me.tbAlmt.Size = New System.Drawing.Size(199, 64)
        Me.tbAlmt.TabIndex = 6
        '
        'tbNoTelp
        '
        Me.tbNoTelp.Location = New System.Drawing.Point(94, 133)
        Me.tbNoTelp.Name = "tbNoTelp"
        Me.tbNoTelp.Size = New System.Drawing.Size(199, 20)
        Me.tbNoTelp.TabIndex = 7
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(465, 78)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 8
        Me.btSimpan.Text = "Button1"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'CMSlv
        '
        Me.CMSlv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.CMSlv.Name = "CMSlv"
        Me.CMSlv.Size = New System.Drawing.Size(153, 70)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'FPeminjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 384)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.tbNoTelp)
        Me.Controls.Add(Me.tbAlmt)
        Me.Controls.Add(Me.LVpmnjm)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPeminjam"
        Me.Text = "FPeminjam"
        Me.CMSlv.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents LVpmnjm As System.Windows.Forms.ListView
    Friend WithEvents tbAlmt As System.Windows.Forms.TextBox
    Friend WithEvents tbNoTelp As System.Windows.Forms.TextBox
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents CMSlv As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
