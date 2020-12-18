Imports System.Text.RegularExpressions

Public Class FAddRecord

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day12,13,14\Student Information System\Student Information System\Student Information System\bin\Debug\Student_Data.accdb")

    Dim fnm As String = ""
    Dim lnm As String = ""
    Dim gndr As String = ""
    Dim eml As String = ""
    Dim adrs As String = ""
    Dim Phn As Long
    Dim dob As Date
    Dim age As Integer
    Dim ValidFnm As Boolean = False
    Dim ValidLnm As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComBoxGndr.SelectedItem = ComBoxGndr.Items.Item(0)

    End Sub
    '
    Private Sub TxtFName_TextChanged(sender As Object, e As EventArgs) Handles TxtFName.TextChanged
        For i As Integer = 0 To TxtFName.Text.Length - 1

            If Not TxtFName.Text = "" And Char.IsLetter(CChar(TxtFName.Text.ElementAt(i))) Then

                ValidFnm = True
            Else
                ValidFnm = False
                MessageBox.Show("Please enter some letter.")
            End If
        Next

    End Sub

    Private Sub TxtLName_TextChanged(sender As Object, e As EventArgs) Handles TxtLName.TextChanged
        If Not TxtLName.Text = "" Then
            For i As Integer = 0 To TxtLName.Text.Length - 1

                If Char.IsLetter(CChar(TxtLName.Text.ElementAt(i))) Then

                    ValidLnm = True
                Else
                    ValidLnm = False
                    MessageBox.Show("Please enter some letter.")
                End If
            Next
            '
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTPckr.ValueChanged

        dob = DTPckr.Value.Date

    End Sub

    Private Sub TxtPhn_TextChanged(sender As Object, e As EventArgs) Handles TxtPhn.TextChanged

        For i As Integer = 0 To TxtPhn.Text.Length - 1

            If Not TxtPhn.Text = "" And Not Char.IsDigit(CChar(TxtPhn.Text.ElementAt(i))) Then

                MessageBox.Show("Please enter some digit.")
            End If
        Next
    End Sub

    Private Sub TxtAdrs_TextChanged(sender As Object, e As EventArgs) Handles TxtAdrs.TextChanged
        If Not TxtAdrs.Text = "" Then
            adrs = TxtAdrs.Text

        End If
    End Sub
    '
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        'Validation of all fields

        If ValidFnm Then
            fnm = TxtFName.Text

            If ValidLnm Then
                lnm = TxtLName.Text

                If ((Today.Year - dob.Year) > 2) Then
                    age = Today.Year - dob.Year

                    If TxtPhn.Text.Length = 10 Then

                        Phn = TxtPhn.Text

                        Dim pattern As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")

                        If TxtEml.Text = "" Or ((Not TxtEml.Text = "") And pattern.IsMatch(TxtEml.Text)) Then

                            eml = TxtEml.Text

                            If Not TxtAdrs.Text = "" Then

                                Try
                                    Dim sql As String = "INSERT INTO Info_Table (First_Name, 
                                                               Last_Name,Gender,Date_of_Birth,Age, Phone_no, Email_Id,Address ) 
                                                               Values (?, ?, ?, ?,?,?,?,?)"

                                    Dim cmd As New OleDb.OleDbCommand
                                    con.Open()

                                    cmd.Connection = con
                                    cmd.CommandText = sql

                                    cmd.Parameters.AddWithValue("@p1", fnm)
                                    cmd.Parameters.AddWithValue("@p2", lnm)
                                    cmd.Parameters.AddWithValue("@p4", ComBoxGndr.SelectedItem)
                                    cmd.Parameters.AddWithValue("@p5", dob.ToString)
                                    cmd.Parameters.AddWithValue("@p6", age)
                                    cmd.Parameters.AddWithValue("@p7", TxtPhn.Text)
                                    cmd.Parameters.AddWithValue("@p8", eml)
                                    cmd.Parameters.AddWithValue("@p9", adrs)

                                    Dim i = cmd.ExecuteNonQuery
                                    If i > 0 Then
                                        MsgBox("New record has been inserted successfully!")
                                        TxtFName.Text = ""
                                        TxtLName.Text = ""
                                        ComBoxGndr.SelectedItem = ComBoxGndr.Items.Item(0)
                                        DTPckr.Value = DTPckr.MaxDate
                                        TxtPhn.Text = ""
                                        TxtEml.Text = ""
                                        TxtAdrs.Text = ""
                                        con.Close()

                                    Else
                                        MsgBox("No record has been inserted successfully!")

                                    End If
                                    con.Close()

                                Catch ex As Exception
                                    MsgBox(ex.Message)

                                Finally
                                    con.Close()

                                End Try
                            Else
                                MessageBox.Show("Address is required.")
                            End If

                        Else
                            MessageBox.Show("Please enter a valid Email address ")

                        End If

                    Else
                        MessageBox.Show("PLease enter a 10 digit no. ")

                    End If

                Else
                    MessageBox.Show("Please enter a date of birth of 3 or more years before.")

                End If

            Else
                MessageBox.Show("Please enter a valid Last Name.")
            End If

        Else
            MessageBox.Show("Please enter a valid First Name.")

        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class