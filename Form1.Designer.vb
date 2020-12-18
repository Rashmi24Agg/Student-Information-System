<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadBtnView = New System.Windows.Forms.RadioButton()
        Me.RadBtnAdd = New System.Windows.Forms.RadioButton()
        Me.RadBtnUpdate = New System.Windows.Forms.RadioButton()
        Me.RadBtnDelete = New System.Windows.Forms.RadioButton()
        Me.BtnnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Information System"
        '
        'RadBtnView
        '
        Me.RadBtnView.AutoCheck = False
        Me.RadBtnView.AutoSize = True
        Me.RadBtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnView.Location = New System.Drawing.Point(68, 159)
        Me.RadBtnView.Name = "RadBtnView"
        Me.RadBtnView.Size = New System.Drawing.Size(114, 20)
        Me.RadBtnView.TabIndex = 1
        Me.RadBtnView.TabStop = True
        Me.RadBtnView.Text = "Show Records"
        Me.RadBtnView.UseVisualStyleBackColor = True
        '
        'RadBtnAdd
        '
        Me.RadBtnAdd.AutoCheck = False
        Me.RadBtnAdd.AutoSize = True
        Me.RadBtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnAdd.Location = New System.Drawing.Point(265, 159)
        Me.RadBtnAdd.Name = "RadBtnAdd"
        Me.RadBtnAdd.Size = New System.Drawing.Size(99, 20)
        Me.RadBtnAdd.TabIndex = 2
        Me.RadBtnAdd.TabStop = True
        Me.RadBtnAdd.Text = "Add Record"
        Me.RadBtnAdd.UseVisualStyleBackColor = True
        '
        'RadBtnUpdate
        '
        Me.RadBtnUpdate.AutoCheck = False
        Me.RadBtnUpdate.AutoSize = True
        Me.RadBtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnUpdate.Location = New System.Drawing.Point(68, 226)
        Me.RadBtnUpdate.Name = "RadBtnUpdate"
        Me.RadBtnUpdate.Size = New System.Drawing.Size(119, 20)
        Me.RadBtnUpdate.TabIndex = 3
        Me.RadBtnUpdate.TabStop = True
        Me.RadBtnUpdate.Text = "Update Record"
        Me.RadBtnUpdate.UseVisualStyleBackColor = True
        '
        'RadBtnDelete
        '
        Me.RadBtnDelete.AutoCheck = False
        Me.RadBtnDelete.AutoSize = True
        Me.RadBtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBtnDelete.Location = New System.Drawing.Point(265, 226)
        Me.RadBtnDelete.Name = "RadBtnDelete"
        Me.RadBtnDelete.Size = New System.Drawing.Size(114, 20)
        Me.RadBtnDelete.TabIndex = 4
        Me.RadBtnDelete.TabStop = True
        Me.RadBtnDelete.Text = "Delete Record"
        Me.RadBtnDelete.UseVisualStyleBackColor = True
        '
        'BtnnExit
        '
        Me.BtnnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnnExit.Location = New System.Drawing.Point(162, 305)
        Me.BtnnExit.Name = "BtnnExit"
        Me.BtnnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnnExit.TabIndex = 5
        Me.BtnnExit.Text = "Exit"
        Me.BtnnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 375)
        Me.Controls.Add(Me.BtnnExit)
        Me.Controls.Add(Me.RadBtnDelete)
        Me.Controls.Add(Me.RadBtnUpdate)
        Me.Controls.Add(Me.RadBtnAdd)
        Me.Controls.Add(Me.RadBtnView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadBtnView As RadioButton
    Friend WithEvents RadBtnAdd As RadioButton
    Friend WithEvents RadBtnUpdate As RadioButton
    Friend WithEvents RadBtnDelete As RadioButton
    Friend WithEvents BtnnExit As Button
End Class
