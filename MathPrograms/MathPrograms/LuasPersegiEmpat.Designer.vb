<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LuasPersegiEmpat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LuasPersegiEmpat))
        Me.HslLsPrsgBox = New System.Windows.Forms.TextBox()
        Me.HslLsPrsgLBL = New System.Windows.Forms.Label()
        Me.DelPrsgBut = New System.Windows.Forms.Button()
        Me.HslButPrsg = New System.Windows.Forms.Button()
        Me.QtPrsgBut = New System.Windows.Forms.Button()
        Me.SSPrsgBox = New System.Windows.Forms.TextBox()
        Me.SSPrsgLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HslLsPrsgBox
        '
        Me.HslLsPrsgBox.Location = New System.Drawing.Point(129, 72)
        Me.HslLsPrsgBox.Name = "HslLsPrsgBox"
        Me.HslLsPrsgBox.Size = New System.Drawing.Size(100, 20)
        Me.HslLsPrsgBox.TabIndex = 95
        '
        'HslLsPrsgLBL
        '
        Me.HslLsPrsgLBL.AutoSize = True
        Me.HslLsPrsgLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslLsPrsgLBL.Location = New System.Drawing.Point(12, 72)
        Me.HslLsPrsgLBL.Name = "HslLsPrsgLBL"
        Me.HslLsPrsgLBL.Size = New System.Drawing.Size(83, 17)
        Me.HslLsPrsgLBL.TabIndex = 94
        Me.HslLsPrsgLBL.Text = "Hasil Luas :"
        '
        'DelPrsgBut
        '
        Me.DelPrsgBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelPrsgBut.Location = New System.Drawing.Point(139, 126)
        Me.DelPrsgBut.Name = "DelPrsgBut"
        Me.DelPrsgBut.Size = New System.Drawing.Size(75, 23)
        Me.DelPrsgBut.TabIndex = 93
        Me.DelPrsgBut.Text = "Delete"
        Me.DelPrsgBut.UseVisualStyleBackColor = True
        '
        'HslButPrsg
        '
        Me.HslButPrsg.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslButPrsg.Location = New System.Drawing.Point(15, 126)
        Me.HslButPrsg.Name = "HslButPrsg"
        Me.HslButPrsg.Size = New System.Drawing.Size(75, 23)
        Me.HslButPrsg.TabIndex = 92
        Me.HslButPrsg.Text = "Hasil"
        Me.HslButPrsg.UseVisualStyleBackColor = True
        '
        'QtPrsgBut
        '
        Me.QtPrsgBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtPrsgBut.Location = New System.Drawing.Point(243, 126)
        Me.QtPrsgBut.Name = "QtPrsgBut"
        Me.QtPrsgBut.Size = New System.Drawing.Size(75, 23)
        Me.QtPrsgBut.TabIndex = 91
        Me.QtPrsgBut.Text = "Quit"
        Me.QtPrsgBut.UseVisualStyleBackColor = True
        '
        'SSPrsgBox
        '
        Me.SSPrsgBox.Location = New System.Drawing.Point(102, 28)
        Me.SSPrsgBox.Name = "SSPrsgBox"
        Me.SSPrsgBox.Size = New System.Drawing.Size(100, 20)
        Me.SSPrsgBox.TabIndex = 90
        '
        'SSPrsgLBL
        '
        Me.SSPrsgLBL.AutoSize = True
        Me.SSPrsgLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSPrsgLBL.Location = New System.Drawing.Point(12, 30)
        Me.SSPrsgLBL.Name = "SSPrsgLBL"
        Me.SSPrsgLBL.Size = New System.Drawing.Size(38, 17)
        Me.SSPrsgLBL.TabIndex = 89
        Me.SSPrsgLBL.Text = "Sisi :"
        '
        'LuasPersegiEmpat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(973, 402)
        Me.Controls.Add(Me.HslLsPrsgBox)
        Me.Controls.Add(Me.HslLsPrsgLBL)
        Me.Controls.Add(Me.DelPrsgBut)
        Me.Controls.Add(Me.HslButPrsg)
        Me.Controls.Add(Me.QtPrsgBut)
        Me.Controls.Add(Me.SSPrsgBox)
        Me.Controls.Add(Me.SSPrsgLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LuasPersegiEmpat"
        Me.Text = "LuasPersegiEmpat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HslLsPrsgBox As TextBox
    Friend WithEvents HslLsPrsgLBL As Label
    Friend WithEvents DelPrsgBut As Button
    Friend WithEvents HslButPrsg As Button
    Friend WithEvents QtPrsgBut As Button
    Friend WithEvents SSPrsgBox As TextBox
    Friend WithEvents SSPrsgLBL As Label
End Class
