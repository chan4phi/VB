<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fbuku
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
        Me.tbjubuk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbpengarang = New System.Windows.Forms.ComboBox()
        Me.cbpenerbit = New System.Windows.Forms.ComboBox()
        Me.tbstok = New System.Windows.Forms.TextBox()
        Me.tbsinopsis = New System.Windows.Forms.TextBox()
        Me.btadd = New System.Windows.Forms.Button()
        Me.LVbuku = New System.Windows.Forms.ListView()
        Me.cmsLV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btupdt = New System.Windows.Forms.Button()
        Me.tbtemp = New System.Windows.Forms.TextBox()
        Me.cmsLV.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbjubuk
        '
        Me.tbjubuk.Location = New System.Drawing.Point(113, 16)
        Me.tbjubuk.Name = "tbjubuk"
        Me.tbjubuk.Size = New System.Drawing.Size(314, 20)
        Me.tbjubuk.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Judul Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pengarang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sinopsis"
        '
        'cbpengarang
        '
        Me.cbpengarang.FormattingEnabled = True
        Me.cbpengarang.Location = New System.Drawing.Point(113, 48)
        Me.cbpengarang.Name = "cbpengarang"
        Me.cbpengarang.Size = New System.Drawing.Size(228, 21)
        Me.cbpengarang.TabIndex = 6
        '
        'cbpenerbit
        '
        Me.cbpenerbit.FormattingEnabled = True
        Me.cbpenerbit.Location = New System.Drawing.Point(113, 85)
        Me.cbpenerbit.Name = "cbpenerbit"
        Me.cbpenerbit.Size = New System.Drawing.Size(228, 21)
        Me.cbpenerbit.TabIndex = 7
        '
        'tbstok
        '
        Me.tbstok.Location = New System.Drawing.Point(113, 119)
        Me.tbstok.Name = "tbstok"
        Me.tbstok.Size = New System.Drawing.Size(100, 20)
        Me.tbstok.TabIndex = 8
        '
        'tbsinopsis
        '
        Me.tbsinopsis.Location = New System.Drawing.Point(113, 152)
        Me.tbsinopsis.Multiline = True
        Me.tbsinopsis.Name = "tbsinopsis"
        Me.tbsinopsis.Size = New System.Drawing.Size(375, 75)
        Me.tbsinopsis.TabIndex = 9
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(27, 243)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(75, 23)
        Me.btadd.TabIndex = 11
        Me.btadd.Text = "add"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'LVbuku
        '
        Me.LVbuku.ContextMenuStrip = Me.cmsLV
        Me.LVbuku.Location = New System.Drawing.Point(26, 283)
        Me.LVbuku.Name = "LVbuku"
        Me.LVbuku.Size = New System.Drawing.Size(549, 229)
        Me.LVbuku.TabIndex = 12
        Me.LVbuku.UseCompatibleStateImageBehavior = False
        '
        'cmsLV
        '
        Me.cmsLV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cmsLV.Name = "cmsLV"
        Me.cmsLV.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'btupdt
        '
        Me.btupdt.Location = New System.Drawing.Point(26, 243)
        Me.btupdt.Name = "btupdt"
        Me.btupdt.Size = New System.Drawing.Size(75, 23)
        Me.btupdt.TabIndex = 13
        Me.btupdt.Text = "Update"
        Me.btupdt.UseVisualStyleBackColor = True
        '
        'tbtemp
        '
        Me.tbtemp.Location = New System.Drawing.Point(431, 85)
        Me.tbtemp.Name = "tbtemp"
        Me.tbtemp.Size = New System.Drawing.Size(100, 20)
        Me.tbtemp.TabIndex = 14
        Me.tbtemp.Visible = False
        '
        'fbuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 535)
        Me.Controls.Add(Me.tbtemp)
        Me.Controls.Add(Me.btupdt)
        Me.Controls.Add(Me.LVbuku)
        Me.Controls.Add(Me.btadd)
        Me.Controls.Add(Me.tbsinopsis)
        Me.Controls.Add(Me.tbstok)
        Me.Controls.Add(Me.cbpenerbit)
        Me.Controls.Add(Me.cbpengarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbjubuk)
        Me.Name = "fbuku"
        Me.Text = "Buku"
        Me.cmsLV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbjubuk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbpengarang As System.Windows.Forms.ComboBox
    Friend WithEvents cbpenerbit As System.Windows.Forms.ComboBox
    Friend WithEvents tbstok As System.Windows.Forms.TextBox
    Friend WithEvents tbsinopsis As System.Windows.Forms.TextBox
    Friend WithEvents btadd As System.Windows.Forms.Button
    Friend WithEvents LVbuku As System.Windows.Forms.ListView
    Friend WithEvents cmsLV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btupdt As System.Windows.Forms.Button
    Friend WithEvents tbtemp As System.Windows.Forms.TextBox

End Class
