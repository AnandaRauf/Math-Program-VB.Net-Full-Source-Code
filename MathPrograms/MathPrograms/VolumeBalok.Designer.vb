<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolumeBalok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VolumeBalok))
        Me.DelBlkBut = New System.Windows.Forms.Button()
        Me.HslButBlk = New System.Windows.Forms.Button()
        Me.QtBlkBut = New System.Windows.Forms.Button()
        Me.HslVlBlkBox = New System.Windows.Forms.TextBox()
        Me.TngBlkBox = New System.Windows.Forms.TextBox()
        Me.LbrBlkBox = New System.Windows.Forms.TextBox()
        Me.PnjgBlkBox = New System.Windows.Forms.TextBox()
        Me.HslLsBlkLBL = New System.Windows.Forms.Label()
        Me.TngBlkLBL = New System.Windows.Forms.Label()
        Me.LbrBlkLBL = New System.Windows.Forms.Label()
        Me.PnjgBlkLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DelBlkBut
        '
        Me.DelBlkBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBlkBut.Location = New System.Drawing.Point(136, 195)
        Me.DelBlkBut.Name = "DelBlkBut"
        Me.DelBlkBut.Size = New System.Drawing.Size(75, 23)
        Me.DelBlkBut.TabIndex = 70
        Me.DelBlkBut.Text = "Delete"
        Me.DelBlkBut.UseVisualStyleBackColor = True
        '
        'HslButBlk
        '
        Me.HslButBlk.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslButBlk.Location = New System.Drawing.Point(12, 195)
        Me.HslButBlk.Name = "HslButBlk"
        Me.HslButBlk.Size = New System.Drawing.Size(75, 23)
        Me.HslButBlk.TabIndex = 69
        Me.HslButBlk.Text = "Hasil"
        Me.HslButBlk.UseVisualStyleBackColor = True
        '
        'QtBlkBut
        '
        Me.QtBlkBut.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtBlkBut.Location = New System.Drawing.Point(240, 195)
        Me.QtBlkBut.Name = "QtBlkBut"
        Me.QtBlkBut.Size = New System.Drawing.Size(75, 23)
        Me.QtBlkBut.TabIndex = 68
        Me.QtBlkBut.Text = "Quit"
        Me.QtBlkBut.UseVisualStyleBackColor = True
        '
        'HslVlBlkBox
        '
        Me.HslVlBlkBox.Location = New System.Drawing.Point(129, 154)
        Me.HslVlBlkBox.Name = "HslVlBlkBox"
        Me.HslVlBlkBox.Size = New System.Drawing.Size(100, 20)
        Me.HslVlBlkBox.TabIndex = 67
        '
        'TngBlkBox
        '
        Me.TngBlkBox.Location = New System.Drawing.Point(102, 109)
        Me.TngBlkBox.Name = "TngBlkBox"
        Me.TngBlkBox.Size = New System.Drawing.Size(100, 20)
        Me.TngBlkBox.TabIndex = 66
        '
        'LbrBlkBox
        '
        Me.LbrBlkBox.Location = New System.Drawing.Point(102, 68)
        Me.LbrBlkBox.Name = "LbrBlkBox"
        Me.LbrBlkBox.Size = New System.Drawing.Size(100, 20)
        Me.LbrBlkBox.TabIndex = 65
        '
        'PnjgBlkBox
        '
        Me.PnjgBlkBox.Location = New System.Drawing.Point(114, 30)
        Me.PnjgBlkBox.Name = "PnjgBlkBox"
        Me.PnjgBlkBox.Size = New System.Drawing.Size(100, 20)
        Me.PnjgBlkBox.TabIndex = 64
        '
        'HslLsBlkLBL
        '
        Me.HslLsBlkLBL.AutoSize = True
        Me.HslLsBlkLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HslLsBlkLBL.Location = New System.Drawing.Point(12, 154)
        Me.HslLsBlkLBL.Name = "HslLsBlkLBL"
        Me.HslLsBlkLBL.Size = New System.Drawing.Size(83, 17)
        Me.HslLsBlkLBL.TabIndex = 63
        Me.HslLsBlkLBL.Text = "Hasil Luas :"
        '
        'TngBlkLBL
        '
        Me.TngBlkLBL.AutoSize = True
        Me.TngBlkLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TngBlkLBL.Location = New System.Drawing.Point(12, 112)
        Me.TngBlkLBL.Name = "TngBlkLBL"
        Me.TngBlkLBL.Size = New System.Drawing.Size(65, 17)
        Me.TngBlkLBL.TabIndex = 62
        Me.TngBlkLBL.Text = "Tinggi  :"
        '
        'LbrBlkLBL
        '
        Me.LbrBlkLBL.AutoSize = True
        Me.LbrBlkLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbrBlkLBL.Location = New System.Drawing.Point(12, 70)
        Me.LbrBlkLBL.Name = "LbrBlkLBL"
        Me.LbrBlkLBL.Size = New System.Drawing.Size(51, 17)
        Me.LbrBlkLBL.TabIndex = 61
        Me.LbrBlkLBL.Text = "Lebar :"
        '
        'PnjgBlkLBL
        '
        Me.PnjgBlkLBL.AutoSize = True
        Me.PnjgBlkLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnjgBlkLBL.Location = New System.Drawing.Point(12, 30)
        Me.PnjgBlkLBL.Name = "PnjgBlkLBL"
        Me.PnjgBlkLBL.Size = New System.Drawing.Size(73, 17)
        Me.PnjgBlkLBL.TabIndex = 60
        Me.PnjgBlkLBL.Text = "Panjang  :"
        '
        'VolumeBalok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(907, 408)
        Me.Controls.Add(Me.DelBlkBut)
        Me.Controls.Add(Me.HslButBlk)
        Me.Controls.Add(Me.QtBlkBut)
        Me.Controls.Add(Me.HslVlBlkBox)
        Me.Controls.Add(Me.TngBlkBox)
        Me.Controls.Add(Me.LbrBlkBox)
        Me.Controls.Add(Me.PnjgBlkBox)
        Me.Controls.Add(Me.HslLsBlkLBL)
        Me.Controls.Add(Me.TngBlkLBL)
        Me.Controls.Add(Me.LbrBlkLBL)
        Me.Controls.Add(Me.PnjgBlkLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VolumeBalok"
        Me.Text = "VolumeBalok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DelBlkBut As Button
    Friend WithEvents HslButBlk As Button
    Friend WithEvents QtBlkBut As Button
    Friend WithEvents HslVlBlkBox As TextBox
    Friend WithEvents TngBlkBox As TextBox
    Friend WithEvents LbrBlkBox As TextBox
    Friend WithEvents PnjgBlkBox As TextBox
    Friend WithEvents HslLsBlkLBL As Label
    Friend WithEvents TngBlkLBL As Label
    Friend WithEvents LbrBlkLBL As Label
    Friend WithEvents PnjgBlkLBL As Label
End Class
