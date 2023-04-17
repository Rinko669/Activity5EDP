Imports System.IO

Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog.ShowDialog()

        ' If the user selected a file, read it into a DataTable and bind it to the DataGridView.
        If openFileDialog.FileName <> "" Then
            Dim dt As New DataTable()
            Dim fileReader As New StreamReader(openFileDialog.FileName)
            Dim line As String = fileReader.ReadLine()
            Dim columns As String() = line.Split(",")
            For Each column As String In columns
                dt.Columns.Add(column.Trim())
            Next
            While Not fileReader.EndOfStream
                line = fileReader.ReadLine()
                Dim fields As String() = line.Split(",")
                dt.Rows.Add(fields)
            End While
            fileReader.Close()
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class