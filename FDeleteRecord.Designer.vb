<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDeleteRecord
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
        Me.ComBox = New System.Windows.Forms.ComboBox()
        Me.LSlctRolNo = New System.Windows.Forms.Label()
        Me.BtnDlt = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComBox
        '
        Me.ComBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBox.FormattingEnabled = True
        Me.ComBox.Location = New System.Drawing.Point(109, 121)
        Me.ComBox.Name = "ComBox"
        Me.ComBox.Size = New System.Drawing.Size(164, 24)
        Me.ComBox.TabIndex = 0
        '
        'LSlctRolNo
        '
        Me.LSlctRolNo.AutoSize = True
        Me.LSlctRolNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSlctRolNo.Location = New System.Drawing.Point(121, 67)
        Me.LSlctRolNo.Name = "LSlctRolNo"
        Me.LSlctRolNo.Size = New System.Drawing.Size(157, 16)
        Me.LSlctRolNo.TabIndex = 1
        Me.LSlctRolNo.Text = "Please Select a Roll No. "
        '
        'BtnDlt
        '
        Me.BtnDlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDlt.Location = New System.Drawing.Point(71, 298)
        Me.BtnDlt.Name = "BtnDlt"
        Me.BtnDlt.Size = New System.Drawing.Size(75, 23)
        Me.BtnDlt.TabIndex = 2
        Me.BtnDlt.Text = "Delete"
        Me.BtnDlt.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(198, 298)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Cancel"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FDeleteRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 407)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDlt)
        Me.Controls.Add(Me.LSlctRolNo)
        Me.Controls.Add(Me.ComBox)
        Me.Name = "FDeleteRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComBox As ComboBox
    Friend WithEvents LSlctRolNo As Label
    Friend WithEvents BtnDlt As Button
    Friend WithEvents BtnClose As Button
End Class
