<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarisanAritmatika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarisanAritmatika))
        Me.UAwalLbl = New System.Windows.Forms.Label()
        Me.UAWALBOX = New System.Windows.Forms.TextBox()
        Me.UAkhirLBL = New System.Windows.Forms.Label()
        Me.UAKHIRBOX = New System.Windows.Forms.TextBox()
        Me.UTengahLBL = New System.Windows.Forms.Label()
        Me.UTENGAHBOX = New System.Windows.Forms.TextBox()
        Me.HasilLBL = New System.Windows.Forms.Label()
        Me.HslBARBOX = New System.Windows.Forms.TextBox()
        Me.HasilButBAR = New System.Windows.Forms.Button()
        Me.DelButBAR = New System.Windows.Forms.Button()
        Me.QtButBAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UAwalLbl
        '
        Me.UAwalLbl.AutoSize = True
        Me.UAwalLbl.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UAwalLbl.Location = New System.Drawing.Point(12, 20)
        Me.UAwalLbl.Name = "UAwalLbl"
        Me.UAwalLbl.Size = New System.Drawing.Size(60, 17)
        Me.UAwalLbl.TabIndex = 1
        Me.UAwalLbl.Text = "U Awal :"
        '
        'UAWALBOX
        '
        Me.UAWALBOX.Location = New System.Drawing.Point(79, 20)
        Me.UAWALBOX.Name = "UAWALBOX"
        Me.UAWALBOX.Size = New System.Drawing.Size(100, 20)
        Me.UAWALBOX.TabIndex = 2
        '
        'UAkhirLBL
        '
        Me.UAkhirLBL.AutoSize = True
        Me.UAkhirLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UAkhirLBL.Location = New System.Drawing.Point(12, 63)
        Me.UAkhirLBL.Name = "UAkhirLBL"
        Me.UAkhirLBL.Size = New System.Drawing.Size(68, 17)
        Me.UAkhirLBL.TabIndex = 3
        Me.UAkhirLBL.Text = "U Akhir :"
        '
        'UAKHIRBOX
        '
        Me.UAKHIRBOX.Location = New System.Drawing.Point(86, 60)
        Me.UAKHIRBOX.Name = "UAKHIRBOX"
        Me.UAKHIRBOX.Size = New System.Drawing.Size(100, 20)
        Me.UAKHIRBOX.TabIndex = 4
        '
        'UTengahLBL
        '
        Me.UTengahLBL.AutoSize = True
        Me.UTengahLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UTengahLBL.Location = New System.Drawing.Point(12, 105)
        Me.UTengahLBL.Name = "UTengahLBL"
        Me.UTengahLBL.Size = New System.Drawing.Size(84, 17)
        Me.UTengahLBL.TabIndex = 5
        Me.UTengahLBL.Text = "U Tengah  :"
        '
        'UTENGAHBOX
        '
        Me.UTENGAHBOX.Location = New System.Drawing.Point(102, 102)
        Me.UTENGAHBOX.Name = "UTENGAHBOX"
        Me.UTENGAHBOX.Size = New System.Drawing.Size(100, 20)
        Me.UTENGAHBOX.TabIndex = 6
        '
        'HasilLBL
        '
        Me.HasilLBL.AutoSize = True
        Me.HasilLBL.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasilLBL.Location = New System.Drawing.Point(12, 147)
        Me.HasilLBL.Name = "HasilLBL"
        Me.HasilLBL.Size = New System.Drawing.Size(54, 17)
        Me.HasilLBL.TabIndex = 7
        Me.HasilLBL.Text = "Hasil  :"
        '
        'HslBARBOX
        '
        Me.HslBARBOX.Location = New System.Drawing.Point(72, 147)
        Me.HslBARBOX.Name = "HslBARBOX"
        Me.HslBARBOX.Size = New System.Drawing.Size(100, 20)
        Me.HslBARBOX.TabIndex = 8
        '
        'HasilButBAR
        '
        Me.HasilButBAR.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasilButBAR.Location = New System.Drawing.Point(15, 210)
        Me.HasilButBAR.Name = "HasilButBAR"
        Me.HasilButBAR.Size = New System.Drawing.Size(75, 23)
        Me.HasilButBAR.TabIndex = 17
        Me.HasilButBAR.Text = "Hasil"
        Me.HasilButBAR.UseVisualStyleBackColor = True
        '
        'DelButBAR
        '
        Me.DelButBAR.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelButBAR.Location = New System.Drawing.Point(127, 210)
        Me.DelButBAR.Name = "DelButBAR"
        Me.DelButBAR.Size = New System.Drawing.Size(75, 23)
        Me.DelButBAR.TabIndex = 18
        Me.DelButBAR.Text = "Delete"
        Me.DelButBAR.UseVisualStyleBackColor = True
        '
        'QtButBAR
        '
        Me.QtButBAR.Font = New System.Drawing.Font("Trajan Pro 3", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtButBAR.Location = New System.Drawing.Point(247, 210)
        Me.QtButBAR.Name = "QtButBAR"
        Me.QtButBAR.Size = New System.Drawing.Size(75, 23)
        Me.QtButBAR.TabIndex = 19
        Me.QtButBAR.Text = "Quit"
        Me.QtButBAR.UseVisualStyleBackColor = True
        '
        'BarisanAritmatika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1054, 432)
        Me.Controls.Add(Me.QtButBAR)
        Me.Controls.Add(Me.DelButBAR)
        Me.Controls.Add(Me.HasilButBAR)
        Me.Controls.Add(Me.HslBARBOX)
        Me.Controls.Add(Me.HasilLBL)
        Me.Controls.Add(Me.UTENGAHBOX)
        Me.Controls.Add(Me.UTengahLBL)
        Me.Controls.Add(Me.UAKHIRBOX)
        Me.Controls.Add(Me.UAkhirLBL)
        Me.Controls.Add(Me.UAWALBOX)
        Me.Controls.Add(Me.UAwalLbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BarisanAritmatika"
        Me.Text = "BarisanAritmatika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UAwalLbl As Label
    Friend WithEvents UAWALBOX As TextBox
    Friend WithEvents UAkhirLBL As Label
    Friend WithEvents UAKHIRBOX As TextBox
    Friend WithEvents UTengahLBL As Label
    Friend WithEvents UTENGAHBOX As TextBox
    Friend WithEvents HasilLBL As Label
    Friend WithEvents HslBARBOX As TextBox
    Friend WithEvents HasilButBAR As Button
    Friend WithEvents DelButBAR As Button
    Friend WithEvents QtButBAR As Button
End Class
