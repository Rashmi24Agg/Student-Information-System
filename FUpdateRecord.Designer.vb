<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUpdateRecord
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
        Me.ComBoxRolNo = New System.Windows.Forms.ComboBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LFnm = New System.Windows.Forms.Label()
        Me.LLnm = New System.Windows.Forms.Label()
        Me.LGndr = New System.Windows.Forms.Label()
        Me.LDob = New System.Windows.Forms.Label()
        Me.LPhone = New System.Windows.Forms.Label()
        Me.LEml = New System.Windows.Forms.Label()
        Me.LAdrs = New System.Windows.Forms.Label()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.TxtAdrs = New System.Windows.Forms.TextBox()
        Me.TxtEml = New System.Windows.Forms.TextBox()
        Me.TxtPhn = New System.Windows.Forms.TextBox()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.ComBoxGndr = New System.Windows.Forms.ComboBox()
        Me.DTPckr = New System.Windows.Forms.DateTimePicker()
        Me.LSlctRolNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComBoxRolNo
        '
        Me.ComBoxRolNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxRolNo.FormattingEnabled = True
        Me.ComBoxRolNo.Location = New System.Drawing.Point(49, 164)
        Me.ComBoxRolNo.Name = "ComBoxRolNo"
        Me.ComBoxRolNo.Size = New System.Drawing.Size(121, 24)
        Me.ComBoxRolNo.TabIndex = 0
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.Location = New System.Drawing.Point(236, 165)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(75, 23)
        Me.BtnShow.TabIndex = 1
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(477, 563)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(236, 563)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LFnm
        '
        Me.LFnm.AutoSize = True
        Me.LFnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFnm.Location = New System.Drawing.Point(410, 116)
        Me.LFnm.Name = "LFnm"
        Me.LFnm.Size = New System.Drawing.Size(73, 16)
        Me.LFnm.TabIndex = 4
        Me.LFnm.Text = "First Name"
        '
        'LLnm
        '
        Me.LLnm.AutoSize = True
        Me.LLnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLnm.Location = New System.Drawing.Point(410, 172)
        Me.LLnm.Name = "LLnm"
        Me.LLnm.Size = New System.Drawing.Size(73, 16)
        Me.LLnm.TabIndex = 5
        Me.LLnm.Text = "Last Name"
        '
        'LGndr
        '
        Me.LGndr.AutoSize = True
        Me.LGndr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGndr.Location = New System.Drawing.Point(410, 229)
        Me.LGndr.Name = "LGndr"
        Me.LGndr.Size = New System.Drawing.Size(53, 16)
        Me.LGndr.TabIndex = 6
        Me.LGndr.Text = "Gender"
        '
        'LDob
        '
        Me.LDob.AutoSize = True
        Me.LDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDob.Location = New System.Drawing.Point(410, 288)
        Me.LDob.Name = "LDob"
        Me.LDob.Size = New System.Drawing.Size(80, 16)
        Me.LDob.TabIndex = 7
        Me.LDob.Text = "Date of Birth"
        '
        'LPhone
        '
        Me.LPhone.AutoSize = True
        Me.LPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPhone.Location = New System.Drawing.Point(410, 345)
        Me.LPhone.Name = "LPhone"
        Me.LPhone.Size = New System.Drawing.Size(65, 16)
        Me.LPhone.TabIndex = 8
        Me.LPhone.Text = "Phone no"
        '
        'LEml
        '
        Me.LEml.AutoSize = True
        Me.LEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEml.Location = New System.Drawing.Point(410, 400)
        Me.LEml.Name = "LEml"
        Me.LEml.Size = New System.Drawing.Size(56, 16)
        Me.LEml.TabIndex = 9
        Me.LEml.Text = "Email Id"
        '
        'LAdrs
        '
        Me.LAdrs.AutoSize = True
        Me.LAdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAdrs.Location = New System.Drawing.Point(410, 457)
        Me.LAdrs.Name = "LAdrs"
        Me.LAdrs.Size = New System.Drawing.Size(59, 16)
        Me.LAdrs.TabIndex = 10
        Me.LAdrs.Text = "Address"
        '
        'TxtFName
        '
        Me.TxtFName.Enabled = False
        Me.TxtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFName.Location = New System.Drawing.Point(527, 113)
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(198, 22)
        Me.TxtFName.TabIndex = 11
        '
        'TxtAdrs
        '
        Me.TxtAdrs.Enabled = False
        Me.TxtAdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdrs.Location = New System.Drawing.Point(527, 457)
        Me.TxtAdrs.Name = "TxtAdrs"
        Me.TxtAdrs.Size = New System.Drawing.Size(198, 22)
        Me.TxtAdrs.TabIndex = 12
        '
        'TxtEml
        '
        Me.TxtEml.Enabled = False
        Me.TxtEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEml.Location = New System.Drawing.Point(527, 400)
        Me.TxtEml.Name = "TxtEml"
        Me.TxtEml.Size = New System.Drawing.Size(198, 22)
        Me.TxtEml.TabIndex = 13
        '
        'TxtPhn
        '
        Me.TxtPhn.Enabled = False
        Me.TxtPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhn.Location = New System.Drawing.Point(527, 345)
        Me.TxtPhn.Name = "TxtPhn"
        Me.TxtPhn.Size = New System.Drawing.Size(198, 22)
        Me.TxtPhn.TabIndex = 14
        '
        'TxtLName
        '
        Me.TxtLName.Enabled = False
        Me.TxtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLName.Location = New System.Drawing.Point(527, 172)
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(198, 22)
        Me.TxtLName.TabIndex = 17
        '
        'ComBoxGndr
        '
        Me.ComBoxGndr.Enabled = False
        Me.ComBoxGndr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxGndr.FormattingEnabled = True
        Me.ComBoxGndr.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.ComBoxGndr.Location = New System.Drawing.Point(527, 229)
        Me.ComBoxGndr.Name = "ComBoxGndr"
        Me.ComBoxGndr.Size = New System.Drawing.Size(121, 24)
        Me.ComBoxGndr.TabIndex = 18
        '
        'DTPckr
        '
        Me.DTPckr.Enabled = False
        Me.DTPckr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPckr.Location = New System.Drawing.Point(527, 288)
        Me.DTPckr.MaxDate = New Date(2017, 8, 31, 0, 0, 0, 0)
        Me.DTPckr.Name = "DTPckr"
        Me.DTPckr.Size = New System.Drawing.Size(200, 22)
        Me.DTPckr.TabIndex = 19
        Me.DTPckr.Value = New Date(2017, 8, 31, 0, 0, 0, 0)
        '
        'LSlctRolNo
        '
        Me.LSlctRolNo.AutoSize = True
        Me.LSlctRolNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSlctRolNo.Location = New System.Drawing.Point(104, 113)
        Me.LSlctRolNo.Name = "LSlctRolNo"
        Me.LSlctRolNo.Size = New System.Drawing.Size(146, 16)
        Me.LSlctRolNo.TabIndex = 20
        Me.LSlctRolNo.Text = "Please Select Roll No. "
        '
        'FUpdateRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 640)
        Me.Controls.Add(Me.LSlctRolNo)
        Me.Controls.Add(Me.DTPckr)
        Me.Controls.Add(Me.ComBoxGndr)
        Me.Controls.Add(Me.TxtLName)
        Me.Controls.Add(Me.TxtPhn)
        Me.Controls.Add(Me.TxtEml)
        Me.Controls.Add(Me.TxtAdrs)
        Me.Controls.Add(Me.TxtFName)
        Me.Controls.Add(Me.LAdrs)
        Me.Controls.Add(Me.LEml)
        Me.Controls.Add(Me.LPhone)
        Me.Controls.Add(Me.LDob)
        Me.Controls.Add(Me.LGndr)
        Me.Controls.Add(Me.LLnm)
        Me.Controls.Add(Me.LFnm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.ComBoxRolNo)
        Me.Name = "FUpdateRecord"
        Me.Text = "Update Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComBoxRolNo As ComboBox
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LFnm As Label
    Friend WithEvents LLnm As Label
    Friend WithEvents LGndr As Label
    Friend WithEvents LDob As Label
    Friend WithEvents LPhone As Label
    Friend WithEvents LEml As Label
    Friend WithEvents LAdrs As Label
    Friend WithEvents TxtFName As TextBox
    Friend WithEvents TxtAdrs As TextBox
    Friend WithEvents TxtEml As TextBox
    Friend WithEvents TxtPhn As TextBox
    Friend WithEvents TxtLName As TextBox
    Friend WithEvents ComBoxGndr As ComboBox
    Friend WithEvents DTPckr As DateTimePicker
    Friend WithEvents LSlctRolNo As Label
End Class
