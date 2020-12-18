Public Class FShowRecords

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day12,13,14\Student Information System\Student Information System\Student Information System\bin\Debug\Student_Data.accdb")

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FShowRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_Info_DBDataSet.Info_Table' table. You can move, or remove it, as needed.
        'Me.Info_TableTableAdapter.Fill(Me.Student_Info_DBDataSet.Info_Table)
        Try
            Dim sql As String = "Select * from Info_Table"

            con.Open()
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            Dim adptr As New OleDb.OleDbDataAdapter(sql, con)
            Dim ds As New DataSet
            Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
            adptr.Fill(ds, "Info_Table")

            DataGridView.DataSource = ds.Tables(0)

            DataGridView.Refresh()

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()

        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class