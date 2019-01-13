<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolumeKubus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VolumeKubus))
        Me.DelBut = New System.Windows.Forms.Button()
        Me.HslBut = New System.Windows.Forms.Button()
        Me.QtBut = New System.Windows.Forms.Button()
        Me.SSKbsBox = New System.Windows.Forms.TextBox()
        Me.SSKbsLBL = New System.Windows.Forms.Label()
        Me.HslVlKbsBox = New System.Windows.Forms.TextBox()
        Me.HslVlPrsgLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DelBut
        '
        Me.DelBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBut.Location = New System.Drawing.Point(127, 91)
        Me.DelBut.Name = "DelBut"
        Me.DelBut.Size = New System.Drawing.Size(75, 23)
        Me.DelBut.TabIndex = 105
        Me.DelBut.Text = "Delete"
        Me.DelBut.UseVisualStyleBackColor = True
        '
        'HslBut
        '
        Me.HslBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslBut.Location = New System.Drawing.Point(15, 91)
        Me.HslBut.Name = "HslBut"
        Me.HslBut.Size = New System.Drawing.Size(75, 23)
        Me.HslBut.TabIndex = 104
        Me.HslBut.Text = "Hasil"
        Me.HslBut.UseVisualStyleBackColor = True
        '
        'QtBut
        '
        Me.QtBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtBut.Location = New System.Drawing.Point(241, 91)
        Me.QtBut.Name = "QtBut"
        Me.QtBut.Size = New System.Drawing.Size(75, 23)
        Me.QtBut.TabIndex = 103
        Me.QtBut.Text = "Quit"
        Me.QtBut.UseVisualStyleBackColor = True
        '
        'SSKbsBox
        '
        Me.SSKbsBox.Location = New System.Drawing.Point(102, 40)
        Me.SSKbsBox.Name = "SSKbsBox"
        Me.SSKbsBox.Size = New System.Drawing.Size(100, 20)
        Me.SSKbsBox.TabIndex = 102
        '
        'SSKbsLBL
        '
        Me.SSKbsLBL.AutoSize = True
        Me.SSKbsLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSKbsLBL.Location = New System.Drawing.Point(12, 42)
        Me.SSKbsLBL.Name = "SSKbsLBL"
        Me.SSKbsLBL.Size = New System.Drawing.Size(38, 17)
        Me.SSKbsLBL.TabIndex = 101
        Me.SSKbsLBL.Text = "Sisi :"
        '
        'HslVlKbsBox
        '
        Me.HslVlKbsBox.Location = New System.Drawing.Point(511, 42)
        Me.HslVlKbsBox.Name = "HslVlKbsBox"
        Me.HslVlKbsBox.Size = New System.Drawing.Size(100, 20)
        Me.HslVlKbsBox.TabIndex = 107
        '
        'HslVlPrsgLBL
        '
        Me.HslVlPrsgLBL.AutoSize = True
        Me.HslVlPrsgLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslVlPrsgLBL.Location = New System.Drawing.Point(394, 42)
        Me.HslVlPrsgLBL.Name = "HslVlPrsgLBL"
        Me.HslVlPrsgLBL.Size = New System.Drawing.Size(106, 17)
        Me.HslVlPrsgLBL.TabIndex = 106
        Me.HslVlPrsgLBL.Text = "Hasil Volume :"
        '
        'VolumeKubus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(880, 376)
        Me.Controls.Add(Me.HslVlKbsBox)
        Me.Controls.Add(Me.HslVlPrsgLBL)
        Me.Controls.Add(Me.DelBut)
        Me.Controls.Add(Me.HslBut)
        Me.Controls.Add(Me.QtBut)
        Me.Controls.Add(Me.SSKbsBox)
        Me.Controls.Add(Me.SSKbsLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VolumeKubus"
        Me.Text = "VolumeKubus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DelBut As Button
    Friend WithEvents HslBut As Button
    Friend WithEvents QtBut As Button
    Friend WithEvents SSKbsBox As TextBox
    Friend WithEvents SSKbsLBL As Label
    Friend WithEvents HslVlKbsBox As TextBox
    Friend WithEvents HslVlPrsgLBL As Label
End Class
