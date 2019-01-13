<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LuasPermukaanKerucut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LuasPermukaanKerucut))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SGRSPBOX = New System.Windows.Forms.TextBox()
        Me.SGRPKrct = New System.Windows.Forms.Label()
        Me.HslLsPrmknKrctBox = New System.Windows.Forms.TextBox()
        Me.HslLsPrmknKrctLBL = New System.Windows.Forms.Label()
        Me.QtKrctBut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DelKrctBut = New System.Windows.Forms.Button()
        Me.HslKrctBut = New System.Windows.Forms.Button()
        Me.rJariJariKrctBox = New System.Windows.Forms.TextBox()
        Me.PhiKrctBox = New System.Windows.Forms.TextBox()
        Me.rJariJariKrctLBL = New System.Windows.Forms.Label()
        Me.PhiKrctLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 17)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "* Rumus Mencari S / Garis Pelukis : s = √(r² + t²)"
        '
        'SGRSPBOX
        '
        Me.SGRSPBOX.Location = New System.Drawing.Point(136, 115)
        Me.SGRSPBOX.Name = "SGRSPBOX"
        Me.SGRSPBOX.Size = New System.Drawing.Size(100, 20)
        Me.SGRSPBOX.TabIndex = 95
        '
        'SGRPKrct
        '
        Me.SGRPKrct.AutoSize = True
        Me.SGRPKrct.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGRPKrct.Location = New System.Drawing.Point(12, 115)
        Me.SGRPKrct.Name = "SGRPKrct"
        Me.SGRPKrct.Size = New System.Drawing.Size(118, 17)
        Me.SGRPKrct.TabIndex = 94
        Me.SGRPKrct.Text = "s / garis pelukis:"
        '
        'HslLsPrmknKrctBox
        '
        Me.HslLsPrmknKrctBox.Location = New System.Drawing.Point(664, 37)
        Me.HslLsPrmknKrctBox.Name = "HslLsPrmknKrctBox"
        Me.HslLsPrmknKrctBox.Size = New System.Drawing.Size(100, 20)
        Me.HslLsPrmknKrctBox.TabIndex = 93
        '
        'HslLsPrmknKrctLBL
        '
        Me.HslLsPrmknKrctLBL.AutoSize = True
        Me.HslLsPrmknKrctLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslLsPrmknKrctLBL.Location = New System.Drawing.Point(500, 37)
        Me.HslLsPrmknKrctLBL.Name = "HslLsPrmknKrctLBL"
        Me.HslLsPrmknKrctLBL.Size = New System.Drawing.Size(162, 17)
        Me.HslLsPrmknKrctLBL.TabIndex = 92
        Me.HslLsPrmknKrctLBL.Text = "Hasil Luas Permukaan :"
        '
        'QtKrctBut
        '
        Me.QtKrctBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtKrctBut.Location = New System.Drawing.Point(266, 147)
        Me.QtKrctBut.Name = "QtKrctBut"
        Me.QtKrctBut.Size = New System.Drawing.Size(75, 23)
        Me.QtKrctBut.TabIndex = 91
        Me.QtKrctBut.Text = "Quit"
        Me.QtKrctBut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "* π / Phi  = 22/7 atau 3,14"
        '
        'DelKrctBut
        '
        Me.DelKrctBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelKrctBut.Location = New System.Drawing.Point(142, 147)
        Me.DelKrctBut.Name = "DelKrctBut"
        Me.DelKrctBut.Size = New System.Drawing.Size(75, 23)
        Me.DelKrctBut.TabIndex = 89
        Me.DelKrctBut.Text = "Delete"
        Me.DelKrctBut.UseVisualStyleBackColor = True
        '
        'HslKrctBut
        '
        Me.HslKrctBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslKrctBut.Location = New System.Drawing.Point(12, 147)
        Me.HslKrctBut.Name = "HslKrctBut"
        Me.HslKrctBut.Size = New System.Drawing.Size(75, 23)
        Me.HslKrctBut.TabIndex = 88
        Me.HslKrctBut.Text = "Hasil"
        Me.HslKrctBut.UseVisualStyleBackColor = True
        '
        'rJariJariKrctBox
        '
        Me.rJariJariKrctBox.Location = New System.Drawing.Point(117, 74)
        Me.rJariJariKrctBox.Name = "rJariJariKrctBox"
        Me.rJariJariKrctBox.Size = New System.Drawing.Size(100, 20)
        Me.rJariJariKrctBox.TabIndex = 87
        '
        'PhiKrctBox
        '
        Me.PhiKrctBox.Location = New System.Drawing.Point(84, 34)
        Me.PhiKrctBox.Name = "PhiKrctBox"
        Me.PhiKrctBox.Size = New System.Drawing.Size(100, 20)
        Me.PhiKrctBox.TabIndex = 86
        '
        'rJariJariKrctLBL
        '
        Me.rJariJariKrctLBL.AutoSize = True
        Me.rJariJariKrctLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJariJariKrctLBL.Location = New System.Drawing.Point(12, 74)
        Me.rJariJariKrctLBL.Name = "rJariJariKrctLBL"
        Me.rJariJariKrctLBL.Size = New System.Drawing.Size(99, 17)
        Me.rJariJariKrctLBL.TabIndex = 85
        Me.rJariJariKrctLBL.Text = "r / Jari - Jari :"
        '
        'PhiKrctLBL
        '
        Me.PhiKrctLBL.AutoSize = True
        Me.PhiKrctLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhiKrctLBL.Location = New System.Drawing.Point(12, 34)
        Me.PhiKrctLBL.Name = "PhiKrctLBL"
        Me.PhiKrctLBL.Size = New System.Drawing.Size(66, 17)
        Me.PhiKrctLBL.TabIndex = 84
        Me.PhiKrctLBL.Text = "π / Phi  :"
        '
        'LuasPermukaanKerucut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(927, 372)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SGRSPBOX)
        Me.Controls.Add(Me.SGRPKrct)
        Me.Controls.Add(Me.HslLsPrmknKrctBox)
        Me.Controls.Add(Me.HslLsPrmknKrctLBL)
        Me.Controls.Add(Me.QtKrctBut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DelKrctBut)
        Me.Controls.Add(Me.HslKrctBut)
        Me.Controls.Add(Me.rJariJariKrctBox)
        Me.Controls.Add(Me.PhiKrctBox)
        Me.Controls.Add(Me.rJariJariKrctLBL)
        Me.Controls.Add(Me.PhiKrctLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LuasPermukaanKerucut"
        Me.Text = "LuasPermukaanKerucut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents SGRSPBOX As TextBox
    Friend WithEvents SGRPKrct As Label
    Friend WithEvents HslLsPrmknKrctBox As TextBox
    Friend WithEvents HslLsPrmknKrctLBL As Label
    Friend WithEvents QtKrctBut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DelKrctBut As Button
    Friend WithEvents HslKrctBut As Button
    Friend WithEvents rJariJariKrctBox As TextBox
    Friend WithEvents PhiKrctBox As TextBox
    Friend WithEvents rJariJariKrctLBL As Label
    Friend WithEvents PhiKrctLBL As Label
End Class
