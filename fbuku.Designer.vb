﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.tbadd = New System.Windows.Forms.Button()
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
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(113, 243)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 10
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'tbadd
        '
        Me.tbadd.Location = New System.Drawing.Point(383, 243)
        Me.tbadd.Name = "tbadd"
        Me.tbadd.Size = New System.Drawing.Size(75, 23)
        Me.tbadd.TabIndex = 11
        Me.tbadd.Text = "add"
        Me.tbadd.UseVisualStyleBackColor = True
        '
        'fbuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 297)
        Me.Controls.Add(Me.tbadd)
        Me.Controls.Add(Me.btsimpan)
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
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents tbadd As System.Windows.Forms.Button

End Class
