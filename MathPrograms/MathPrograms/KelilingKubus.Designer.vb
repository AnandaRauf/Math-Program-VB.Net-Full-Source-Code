<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelilingKubus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KelilingKubus))
        Me.HslKlKbsBox = New System.Windows.Forms.TextBox()
        Me.HslKlPrsgLBL = New System.Windows.Forms.Label()
        Me.DelBut = New System.Windows.Forms.Button()
        Me.HslBut = New System.Windows.Forms.Button()
        Me.QtBut = New System.Windows.Forms.Button()
        Me.SSKbsBox = New System.Windows.Forms.TextBox()
        Me.SSKbsLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HslKlKbsBox
        '
        Me.HslKlKbsBox.Location = New System.Drawing.Point(511, 34)
        Me.HslKlKbsBox.Name = "HslKlKbsBox"
        Me.HslKlKbsBox.Size = New System.Drawing.Size(100, 20)
        Me.HslKlKbsBox.TabIndex = 114
        '
        'HslKlPrsgLBL
        '
        Me.HslKlPrsgLBL.AutoSize = True
        Me.HslKlPrsgLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslKlPrsgLBL.Location = New System.Drawing.Point(394, 34)
        Me.HslKlPrsgLBL.Name = "HslKlPrsgLBL"
        Me.HslKlPrsgLBL.Size = New System.Drawing.Size(111, 17)
        Me.HslKlPrsgLBL.TabIndex = 113
        Me.HslKlPrsgLBL.Text = "Hasil Keliling :"
        '
        'DelBut
        '
        Me.DelBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBut.Location = New System.Drawing.Point(127, 83)
        Me.DelBut.Name = "DelBut"
        Me.DelBut.Size = New System.Drawing.Size(75, 23)
        Me.DelBut.TabIndex = 112
        Me.DelBut.Text = "Delete"
        Me.DelBut.UseVisualStyleBackColor = True
        '
        'HslBut
        '
        Me.HslBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslBut.Location = New System.Drawing.Point(15, 83)
        Me.HslBut.Name = "HslBut"
        Me.HslBut.Size = New System.Drawing.Size(75, 23)
        Me.HslBut.TabIndex = 111
        Me.HslBut.Text = "Hasil"
        Me.HslBut.UseVisualStyleBackColor = True
        '
        'QtBut
        '
        Me.QtBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtBut.Location = New System.Drawing.Point(241, 83)
        Me.QtBut.Name = "QtBut"
        Me.QtBut.Size = New System.Drawing.Size(75, 23)
        Me.QtBut.TabIndex = 110
        Me.QtBut.Text = "Quit"
        Me.QtBut.UseVisualStyleBackColor = True
        '
        'SSKbsBox
        '
        Me.SSKbsBox.Location = New System.Drawing.Point(102, 32)
        Me.SSKbsBox.Name = "SSKbsBox"
        Me.SSKbsBox.Size = New System.Drawing.Size(100, 20)
        Me.SSKbsBox.TabIndex = 109
        '
        'SSKbsLBL
        '
        Me.SSKbsLBL.AutoSize = True
        Me.SSKbsLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSKbsLBL.Location = New System.Drawing.Point(12, 34)
        Me.SSKbsLBL.Name = "SSKbsLBL"
        Me.SSKbsLBL.Size = New System.Drawing.Size(38, 17)
        Me.SSKbsLBL.TabIndex = 108
        Me.SSKbsLBL.Text = "Sisi :"
        '
        'KelilingKubus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1033, 393)
        Me.Controls.Add(Me.HslKlKbsBox)
        Me.Controls.Add(Me.HslKlPrsgLBL)
        Me.Controls.Add(Me.DelBut)
        Me.Controls.Add(Me.HslBut)
        Me.Controls.Add(Me.QtBut)
        Me.Controls.Add(Me.SSKbsBox)
        Me.Controls.Add(Me.SSKbsLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KelilingKubus"
        Me.Text = "KelilingKubus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HslKlKbsBox As TextBox
    Friend WithEvents HslKlPrsgLBL As Label
    Friend WithEvents DelBut As Button
    Friend WithEvents HslBut As Button
    Friend WithEvents QtBut As Button
    Friend WithEvents SSKbsBox As TextBox
    Friend WithEvents SSKbsLBL As Label
End Class
