Imports MySql.Data.MySqlClient

Public Class Weapons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into signature_weapons values('" _
                & .weapid.Text & "', '" _
                & .weapname.Text & "', '" _
                & .charid.Text & "', '" _
                & .weaptype.Text & "', '" _
                & .price.Text & "')"
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
            .weapid.Text = vbNullString
            .weapname.Text = ""
            .charid.Text = ""
            .weaptype.Text = ""
            .price.Text = ""
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try

                strSQL = "UPDATE signature_weapons SET weapon_id = '" _
                & .weapid.Text & "', " _
                & "weapon_name= '" & .weapname.Text & "', " _
                & "Character_ID= '" & .charid.Text & "', " _
                & "type_of_weapon = '" & .weaptype.Text & "', " _
                & "weapon_price = '" & .price.Text & "' " _
                & "WHERE weapon_id = '" & .weapid.Text & "'"
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
                    strSQL = "Delete from signature_weapons" _
                                    & " where weapon_id= '" _
                                    & .weapid.Text & "'"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Level.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class