Imports MySql.Data.MySqlClient

Public Class Level
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into character_lvl values('" _
                & .lvlid.Text & "', '" _
                & .charalvl.Text & "', '" _
                & .uniqid.Text & "')"
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
            .lvlid.Text = vbNullString
            .charalvl.Text = ""
            .uniqid.Text = ""
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try

                strSQL = "UPDATE character_level SET character_lvl_id = '" _
                & .lvlid.Text & "', " _
                & "character_lvl= '" & .charalvl.Text & "', " _
                & "unique_id= '" & .uniqid.Text & "', " _
                & "WHERE character_lvl_id = '" & .lvlid.Text & "'"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strSQL = "Delete from character_level" _
                                    & " where character_lvl_id = '" _
                                    & .lvlid.Text & "'"
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Weapons.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class

