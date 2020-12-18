Public Class Form1


    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day12,13,14\Student Information System\Student Information System\Student Information System\bin\Debug\Student_Data.accdb")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RadBtnView.Checked = False
        'RadBtnView.Enabled = True

        ' RadBtnView.CanSelect = False
        RadBtnAdd.AutoCheck = True
        RadBtnView.AutoCheck = True
        RadBtnDelete.AutoCheck = True
        RadBtnUpdate.AutoCheck = True
        Try
            con.Open()


            con.Close() ' If con.State = ConnectionState.Open Then
            ' MsgBox("Connected")
            ' Else
            ' MsgBox("Not Connected!")

            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub RadBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnView.CheckedChanged
        If RadBtnView.Checked Then
            Dim ShowForm As FShowRecords
            ShowForm = New FShowRecords
            ShowForm.Show()

        End If
        RadBtnView.Checked = False
    End Sub

    Private Sub RadBtnAdd_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnAdd.CheckedChanged

        If RadBtnAdd.Checked Then
            Dim AddForm As New FAddRecord
            AddForm.Show()

        End If
        RadBtnAdd.Checked = False
    End Sub

    Private Sub RadBtnUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnUpdate.CheckedChanged

        If RadBtnUpdate.Checked Then
            Dim UpdtForm As New FUpdateRecord
            UpdtForm.Show()


        End If
        RadBtnUpdate.Checked = False

    End Sub

    Private Sub RadBtnDelete_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnDelete.CheckedChanged

        If RadBtnDelete.Checked Then
            Dim UpdtForm As New FDeleteRecord
            UpdtForm.Show()
            RadBtnDelete.Checked = False

        End If
        RadBtnDelete.Checked = False
    End Sub

    Private Sub BtnnExit_Click(sender As Object, e As EventArgs) Handles BtnnExit.Click
        Me.Close()
    End Sub
End Class
