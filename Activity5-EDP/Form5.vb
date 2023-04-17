
Imports MySql.Data.MySqlClient

Public Class Vision
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into characters_archon values('" _
                & .visionidtxt.Text & "', '" _
                & .visionnametxt.Text & "', '" _
                & .charactertxt.Text & "')"
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
            .visionidtxt.Text = vbNullString
            .visionnametxt.Text = ""
            .charactertxt.Text = ""
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE characters_vision SET vision_id= '" _
                 & .visionidtxt.Text & "', " _
& "vision_name= '" & .visionnametxt.Text & "', " _
& "Characters_ID = '" & .charactertxt.Text & "' " _
& "WHERE vision_id = '" & .visionidtxt.Text & "'"
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
                    strSQL = "Delete from characters_vision" _
                                    & " where vision_id = '" _
                                    & .visionidtxt.Text & "'"
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
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Weapons.Show()
    End Sub
End Class