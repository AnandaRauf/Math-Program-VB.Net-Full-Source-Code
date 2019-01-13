<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureGroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserLbl = New System.Windows.Forms.Label()
        Me.PassLbl = New System.Windows.Forms.Label()
        Me.UserBox = New System.Windows.Forms.TextBox()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.LogBut = New System.Windows.Forms.Button()
        Me.QuitBut = New System.Windows.Forms.Button()
        Me.PictureGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureGroupBox
        '
        Me.PictureGroupBox.Controls.Add(Me.PictureBox1)
        Me.PictureGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.PictureGroupBox.Name = "PictureGroupBox"
        Me.PictureGroupBox.Size = New System.Drawing.Size(520, 298)
        Me.PictureGroupBox.TabIndex = 0
        Me.PictureGroupBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 279)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UserLbl
        '
        Me.UserLbl.AutoSize = True
        Me.UserLbl.Font = New System.Drawing.Font("Trajan Pro 3", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLbl.Location = New System.Drawing.Point(19, 331)
        Me.UserLbl.Name = "UserLbl"
        Me.UserLbl.Size = New System.Drawing.Size(89, 19)
        Me.UserLbl.TabIndex = 1
        Me.UserLbl.Text = "Username :"
        '
        'PassLbl
        '
        Me.PassLbl.AutoSize = True
        Me.PassLbl.Font = New System.Drawing.Font("Trajan Pro 3", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassLbl.Location = New System.Drawing.Point(19, 369)
        Me.PassLbl.Name = "PassLbl"
        Me.PassLbl.Size = New System.Drawing.Size(90, 19)
        Me.PassLbl.TabIndex = 2
        Me.PassLbl.Text = "Password :"
        '
        'UserBox
        '
        Me.UserBox.Location = New System.Drawing.Point(115, 329)
        Me.UserBox.Name = "UserBox"
        Me.UserBox.Size = New System.Drawing.Size(203, 20)
        Me.UserBox.TabIndex = 3
        '
        'PassBox
        '
        Me.PassBox.Location = New System.Drawing.Point(115, 369)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(316, 20)
        Me.PassBox.TabIndex = 4
        '
        'LogBut
        '
        Me.LogBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogBut.Location = New System.Drawing.Point(19, 420)
        Me.LogBut.Name = "LogBut"
        Me.LogBut.Size = New System.Drawing.Size(75, 23)
        Me.LogBut.TabIndex = 5
        Me.LogBut.Text = "Login"
        Me.LogBut.UseVisualStyleBackColor = True
        '
        'QuitBut
        '
        Me.QuitBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitBut.Location = New System.Drawing.Point(373, 420)
        Me.QuitBut.Name = "QuitBut"
        Me.QuitBut.Size = New System.Drawing.Size(75, 23)
        Me.QuitBut.TabIndex = 6
        Me.QuitBut.Text = "Quit"
        Me.QuitBut.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(799, 455)
        Me.Controls.Add(Me.QuitBut)
        Me.Controls.Add(Me.LogBut)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserBox)
        Me.Controls.Add(Me.PassLbl)
        Me.Controls.Add(Me.UserLbl)
        Me.Controls.Add(Me.PictureGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.PictureGroupBox.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureGroupBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UserLbl As Label
    Friend WithEvents PassLbl As Label
    Friend WithEvents UserBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents LogBut As Button
    Friend WithEvents QuitBut As Button
End Class
