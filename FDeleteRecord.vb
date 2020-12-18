Imports System.Text.RegularExpressions

Public Class FDeleteRecord
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day12,13,14\Student Information System\Student Information System\Student Information System\bin\Debug\Student_Data.accdb")

    Private Sub FDeleteRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim sql As String = "Select Roll_no from Info_Table"
            Dim cmd As New OleDb.OleDbCommand(sql, con)

            con.Open()
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

            While reader.Read
                ComBox.Items.Add(reader(0))
            End While

            reader.Close()

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()

        End Try
    End Sub

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        Dim dlgr As DialogResult = MessageBox.Show("Records will be delted permanently.Are you sure you want to delete?", "Warning Message", MessageBoxButtons.YesNo)

        If (dlgr = DialogResult.Yes) Then
            Try
                Dim sql As String = "DELETE * FROM Info_Table WHERE Roll_no=?"
                con.Open()
                Dim cmd As New OleDb.OleDbCommand(sql, con)
                cmd.Parameters.AddWithValue("@rollno", ComBox.SelectedItem)
                cmd.ExecuteNonQuery()
                ComBox.Text = ""
                ComBox.Items.Clear()
                MessageBox.Show("Record Deleted")
                con.Close()

            Catch ex As Exception

                'con.Close()
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try

            Try
                con.Open()

                Dim sql As String = "Select Roll_no from Info_Table"

                Dim cmd As New OleDb.OleDbCommand(sql, con)

                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

                While reader.Read
                    ComBox.Items.Add(reader(0))
                    ComBox.SelectedItem = ComBox.Items.Item(0)

                End While

                reader.Close()

                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                con.Close()

            End Try
        Else
            Exit Sub
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()


    End Sub


End Class