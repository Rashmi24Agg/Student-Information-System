<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAddRecord
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LFName = New System.Windows.Forms.Label()
        Me.LLstName = New System.Windows.Forms.Label()
        Me.LGender = New System.Windows.Forms.Label()
        Me.LDoB = New System.Windows.Forms.Label()
        Me.LPhoneNo = New System.Windows.Forms.Label()
        Me.LEmailId = New System.Windows.Forms.Label()
        Me.LAdrs = New System.Windows.Forms.Label()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.TxtPhn = New System.Windows.Forms.TextBox()
        Me.TxtEml = New System.Windows.Forms.TextBox()
        Me.TxtAdrs = New System.Windows.Forms.RichTextBox()
        Me.DTPckr = New System.Windows.Forms.DateTimePicker()
        Me.ComBoxGndr = New System.Windows.Forms.ComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(144, 545)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LFName
        '
        Me.LFName.AutoSize = True
        Me.LFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFName.Location = New System.Drawing.Point(116, 81)
        Me.LFName.Name = "LFName"
        Me.LFName.Size = New System.Drawing.Size(73, 16)
        Me.LFName.TabIndex = 1
        Me.LFName.Text = "First Name"
        '
        'LLstName
        '
        Me.LLstName.AutoSize = True
        Me.LLstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLstName.Location = New System.Drawing.Point(116, 140)
        Me.LLstName.Name = "LLstName"
        Me.LLstName.Size = New System.Drawing.Size(73, 16)
        Me.LLstName.TabIndex = 2
        Me.LLstName.Text = "Last Name"
        '
        'LGender
        '
        Me.LGender.AutoSize = True
        Me.LGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGender.Location = New System.Drawing.Point(116, 202)
        Me.LGender.Name = "LGender"
        Me.LGender.Size = New System.Drawing.Size(53, 16)
        Me.LGender.TabIndex = 3
        Me.LGender.Text = "Gender"
        '
        'LDoB
        '
        Me.LDoB.AutoSize = True
        Me.LDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDoB.Location = New System.Drawing.Point(116, 273)
        Me.LDoB.Name = "LDoB"
        Me.LDoB.Size = New System.Drawing.Size(80, 16)
        Me.LDoB.TabIndex = 4
        Me.LDoB.Text = "Date of Birth"
        '
        'LPhoneNo
        '
        Me.LPhoneNo.AutoSize = True
        Me.LPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPhoneNo.Location = New System.Drawing.Point(116, 326)
        Me.LPhoneNo.Name = "LPhoneNo"
        Me.LPhoneNo.Size = New System.Drawing.Size(71, 16)
        Me.LPhoneNo.TabIndex = 5
        Me.LPhoneNo.Text = "Phone No."
        '
        'LEmailId
        '
        Me.LEmailId.AutoSize = True
        Me.LEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmailId.Location = New System.Drawing.Point(116, 390)
        Me.LEmailId.Name = "LEmailId"
        Me.LEmailId.Size = New System.Drawing.Size(56, 16)
        Me.LEmailId.TabIndex = 6
        Me.LEmailId.Text = "Email Id"
        '
        'LAdrs
        '
        Me.LAdrs.AutoSize = True
        Me.LAdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAdrs.Location = New System.Drawing.Point(116, 467)
        Me.LAdrs.Name = "LAdrs"
        Me.LAdrs.Size = New System.Drawing.Size(59, 16)
        Me.LAdrs.TabIndex = 7
        Me.LAdrs.Text = "Address"
        '
        'TxtFName
        '
        Me.TxtFName.Location = New System.Drawing.Point(293, 77)
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(205, 20)
        Me.TxtFName.TabIndex = 8
        '
        'TxtLName
        '
        Me.TxtLName.Location = New System.Drawing.Point(293, 140)
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(205, 20)
        Me.TxtLName.TabIndex = 9
        '
        'TxtPhn
        '
        Me.TxtPhn.Location = New System.Drawing.Point(293, 326)
        Me.TxtPhn.Name = "TxtPhn"
        Me.TxtPhn.Size = New System.Drawing.Size(205, 20)
        Me.TxtPhn.TabIndex = 12
        '
        'TxtEml
        '
        Me.TxtEml.Location = New System.Drawing.Point(293, 390)
        Me.TxtEml.Name = "TxtEml"
        Me.TxtEml.Size = New System.Drawing.Size(205, 20)
        Me.TxtEml.TabIndex = 13
        '
        'TxtAdrs
        '
        Me.TxtAdrs.Location = New System.Drawing.Point(293, 453)
        Me.TxtAdrs.Name = "TxtAdrs"
        Me.TxtAdrs.Size = New System.Drawing.Size(205, 58)
        Me.TxtAdrs.TabIndex = 14
        Me.TxtAdrs.Text = ""
        '
        'DTPckr
        '
        Me.DTPckr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPckr.Location = New System.Drawing.Point(293, 273)
        Me.DTPckr.MaxDate = New Date(2017, 8, 31, 0, 0, 0, 0)
        Me.DTPckr.Name = "DTPckr"
        Me.DTPckr.Size = New System.Drawing.Size(205, 21)
        Me.DTPckr.TabIndex = 15
        Me.DTPckr.Value = New Date(2017, 8, 31, 0, 0, 0, 0)
        '
        'ComBoxGndr
        '
        Me.ComBoxGndr.FormattingEnabled = True
        Me.ComBoxGndr.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.ComBoxGndr.Location = New System.Drawing.Point(293, 201)
        Me.ComBoxGndr.Name = "ComBoxGndr"
        Me.ComBoxGndr.Size = New System.Drawing.Size(121, 21)
        Me.ComBoxGndr.TabIndex = 16
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(293, 546)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FAddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 624)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ComBoxGndr)
        Me.Controls.Add(Me.DTPckr)
        Me.Controls.Add(Me.TxtAdrs)
        Me.Controls.Add(Me.TxtEml)
        Me.Controls.Add(Me.TxtPhn)
        Me.Controls.Add(Me.TxtLName)
        Me.Controls.Add(Me.TxtFName)
        Me.Controls.Add(Me.LAdrs)
        Me.Controls.Add(Me.LEmailId)
        Me.Controls.Add(Me.LPhoneNo)
        Me.Controls.Add(Me.LDoB)
        Me.Controls.Add(Me.LGender)
        Me.Controls.Add(Me.LLstName)
        Me.Controls.Add(Me.LFName)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FAddRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents LFName As Label
    Friend WithEvents LLstName As Label
    Friend WithEvents LGender As Label
    Friend WithEvents LDoB As Label
    Friend WithEvents LPhoneNo As Label
    Friend WithEvents LEmailId As Label
    Friend WithEvents LAdrs As Label
    Friend WithEvents TxtFName As TextBox
    Friend WithEvents TxtLName As TextBox
    Friend WithEvents TxtPhn As TextBox
    Friend WithEvents TxtEml As TextBox
    Friend WithEvents TxtAdrs As RichTextBox
    Friend WithEvents DTPckr As DateTimePicker
    Friend WithEvents ComBoxGndr As ComboBox
    Friend WithEvents BtnClose As Button
End Class
