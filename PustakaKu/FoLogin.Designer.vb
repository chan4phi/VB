<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoLogin
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
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btbtl = New System.Windows.Forms.Button()
        Me.tbusr = New System.Windows.Forms.TextBox()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(50, 115)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 23)
        Me.btlogin.TabIndex = 0
        Me.btlogin.Text = "Masuk"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'btbtl
        '
        Me.btbtl.Location = New System.Drawing.Point(179, 115)
        Me.btbtl.Name = "btbtl"
        Me.btbtl.Size = New System.Drawing.Size(75, 23)
        Me.btbtl.TabIndex = 1
        Me.btbtl.Text = "Batal"
        Me.btbtl.UseVisualStyleBackColor = True
        '
        'tbusr
        '
        Me.tbusr.Location = New System.Drawing.Point(101, 22)
        Me.tbusr.Name = "tbusr"
        Me.tbusr.Size = New System.Drawing.Size(169, 20)
        Me.tbusr.TabIndex = 2
        '
        'tbpass
        '
        Me.tbpass.Location = New System.Drawing.Point(101, 58)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.tbpass.Size = New System.Drawing.Size(169, 20)
        Me.tbpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'FoLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 165)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbpass)
        Me.Controls.Add(Me.tbusr)
        Me.Controls.Add(Me.btbtl)
        Me.Controls.Add(Me.btlogin)
        Me.Name = "FoLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btlogin As Button
    Friend WithEvents btbtl As Button
    Friend WithEvents tbusr As TextBox
    Friend WithEvents tbpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
