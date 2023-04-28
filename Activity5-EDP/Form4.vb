Imports MySql.Data.MySqlClient

Public Class Archons
    Dim cmd As New MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into characters_archon values('" _
                & .archonidtxt.Text & "', '" _
                & .archonnametext.Text & "', '" _
                & .sextxt.Text & "', '" _
                & .characteridtxt.Text & "', '" _
                & .charactername.Text & "', '" _
                & .archidtxt.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .archonidtxt.Text = vbNullString
            .archonnametext.Text = ""
            .sextxt.Text = ""
            .characteridtxt.Text = ""
            .charactername.Text = ""
            .archidtxt.Text = ""
        End With
    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try

                strSQL = "UPDATE characters_archon SET Arch_ID = '" _
                & .archonidtxt.Text & "', " _
                & "Archon_Name= '" & .archonidtxt.Text & "', " _
                & "Sex = '" & .sextxt.Text & "', " _
                & "Character_ID = '" & .characteridtxt.Text & "', " _
                & "character_name = '" & .charactername.Text & "' " _
                & "Archon_id = '" & .archidtxt.Text & "' " _
                & "WHERE Characters_ID = '" & .archonidtxt.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strSQL = "Delete from character_archon" _
                                    & " where Arch_ID = '" _
                                    & .archonidtxt.Text & "'"
                    'MsgBox(strSQL)
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    mycmd.ExecuteNonQuery()
                    MsgBox("Record Successfully Deleted")
                    Call Clear_Boxes()
                End If

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Form5_Click(sender As Object, e As EventArgs) Handles Form5.Click
        Dim form2 As New Form2
        Vision.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(currentDate.ToString)
        Call importToExcel(Me.DataGridView1, "report2.xlsx")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Connect_to_DB()
        Dim myadapter As New MySqlDataAdapter
        Dim mytable As New DataTable
        Dim mygrid As New BindingSource


        Try
            Dim myquery As String
            myquery = "select * from genshin.characters_archon"
            cmd = New MySqlCommand(myquery, myconn)
            myadapter.SelectCommand = cmd
            myadapter.Fill(mytable)
            mygrid.DataSource = mytable
            DataGridView1.DataSource = mygrid
            myadapter.Update(mytable)

            myconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try

    End Sub
End Class