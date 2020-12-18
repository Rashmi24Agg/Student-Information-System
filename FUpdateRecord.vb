Imports System.Text.RegularExpressions

Public Class FUpdateRecord

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day12,13,14\Student Information System\Student Information System\Student Information System\bin\Debug\Student_Data.accdb")
    Dim dob As Date
    Dim age As Integer
    Dim ValidFnm As Boolean = False
    Dim ValidLnm As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub
    Private Sub FUpdateRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            con.Open()
            Dim sql As String = "Select Roll_no from Info_Table"
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

            While reader.Read
                ComBoxRolNo.Items.Add(reader(0).ToString)
            End While

            reader.Close()

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()

        End Try

    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click

        If Not ComBoxRolNo.SelectedItem = Nothing Then

            TxtFName.Enabled = True
            TxtLName.Enabled = True
            ComBoxGndr.Enabled = True
            DTPckr.Enabled = True
            TxtPhn.Enabled = True
            TxtEml.Enabled = True
            TxtAdrs.Enabled = True
            BtnSave.Enabled = True

            Try
                Dim q As String = " SELECT * FROM Info_Table WHERE Roll_no =" & CInt(ComBoxRolNo.SelectedItem) & ""
                Dim cmd As New OleDb.OleDbCommand(q, con)
                con.Open()
                Dim rdr As OleDb.OleDbDataReader = cmd.ExecuteReader

                While rdr.Read()

                    TxtFName.Text = rdr("First_Name")
                    TxtLName.Text = rdr("Last_Name")
                    ComBoxGndr.SelectedItem = rdr("Gender")
                    DTPckr.Text = rdr("Date_of_Birth")
                    TxtPhn.Text = rdr("Phone_no")
                    TxtEml.Text = rdr("Email_Id")
                    TxtAdrs.Text = rdr("Address")

                End While

                rdr.Close()
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()

            End Try
        Else
            MessageBox.Show("Please select a roll no. first.")

        End If

    End Sub

    Private Sub TxtFName_TextChanged(sender As Object, e As EventArgs) Handles TxtFName.TextChanged

        If Not TxtFName.Text = "" Then
            For i As Integer = 0 To TxtFName.Text.Length - 1

                If Char.IsLetter(CChar(TxtFName.Text.ElementAt(i))) Then

                    ValidFnm = True
                Else
                    ValidFnm = False
                    MessageBox.Show("Please enter some letter.")
                End If
            Next
        End If

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

        Else
            ValidLnm = True
        End If

    End Sub


    Private Sub DTPckr_ValueChanged(sender As Object, e As EventArgs) Handles DTPckr.ValueChanged

        dob = DTPckr.Value.Date

    End Sub

    Private Sub TxtPhn_TextChanged(sender As Object, e As EventArgs) Handles TxtPhn.TextChanged

        For i As Integer = 0 To TxtPhn.Text.Length - 1

            If Not TxtPhn.Text = "" And Not Char.IsDigit(CChar(TxtPhn.Text.ElementAt(i))) Then

                MessageBox.Show("Please enter some digit.")
            End If
        Next

    End Sub



    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click


        'Validation of all fields 

        If ValidFnm And (Not TxtFName.Text = "") Then

            If ValidLnm Then

                If ((Today.Year - dob.Year) > 2) Then

                    age = Today.Year - dob.Year

                    If TxtPhn.Text.Length = 10 Then

                        Dim pattern As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")

                        If TxtEml.Text = "" Or ((Not TxtEml.Text = "") And pattern.IsMatch(TxtEml.Text)) Then

                            If Not TxtAdrs.Text = "" Then

                                'Updating Values 

                                Dim q As String = "UPDATE Info_Table SET First_Name =@fnm,Last_Name=@lnm,Gender=@g,Date_of_Birth=@dob,Phone_no=@no,Email_Id=@eml,Address=@adrs WHERE Roll_no =" & CInt(ComBoxRolNo.SelectedItem) & ""
                                Dim cmd As New OleDb.OleDbCommand()
                                cmd.Connection = con
                                cmd.CommandText = q

                                con.Open()
                                cmd.Parameters.AddWithValue("@fnm", TxtFName.Text)
                                cmd.Parameters.AddWithValue("@lnm", TxtLName.Text)
                                cmd.Parameters.AddWithValue("@g", ComBoxGndr.SelectedItem)
                                cmd.Parameters.AddWithValue("@dob", dob)
                                cmd.Parameters.AddWithValue("@phn", TxtPhn.Text)
                                cmd.Parameters.AddWithValue("@eml", TxtEml.Text)
                                cmd.Parameters.AddWithValue("@adrs", TxtAdrs.Text)

                                Try

                                    Dim i = cmd.ExecuteNonQuery()

                                    If (i > 0) Then

                                        MsgBox("Record has been updated successfully!")
                                        TxtFName.Text = ""
                                        TxtLName.Text = ""
                                        ComBoxGndr.SelectedItem = ComBoxGndr.Items.Item(0)
                                        DTPckr.Value = DTPckr.MaxDate
                                        TxtPhn.Text = ""
                                        TxtEml.Text = ""
                                        TxtAdrs.Text = ""

                                    Else
                                        MsgBox("No record has been inserted successfully!")

                                    End If
                                    con.Close()

                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)

                                Finally
                                    con.Close()

                                End Try
                            Else
                                MessageBox.Show("Address is required.")

                            End If
                        Else
                            MsgBox("Please enter a valid Email address ")

                        End If

                    Else
                        MessageBox.Show("Please enter a 10 digit number.")

                    End If

                Else
                    MessageBox.Show("Please enter a Date Of birth Of 3 Or more years before.")

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