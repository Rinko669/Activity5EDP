Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into characters_info values('" _
                & .characteridtxt.Text & "', '" _
                & .characternametxt.Text & "', '" _
                & .sextxt.Text & "', '" _
                & .regiontxt.Text & "', '" _
                & .idofarchontxt.Text & "')"
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
            .characteridtxt.Text = vbNullString
            .characternametxt.Text = ""
            .sextxt.Text = ""
            .regiontxt.Text = ""
            .idofarchontxt.Text = ""
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try

                strSQL = "UPDATE characters_info SET Characters_ID = '" _
                & .characteridtxt.Text & "', " _
                & "Name = '" & .characternametxt.Text & "', " _
                & "Sex = '" & .sextxt.Text & "', " _
                & "Region = '" & .regiontxt.Text & "', " _
                & "Id_of_Archon = '" & .idofarchontxt.Text & "' " _
                & "WHERE Characters_ID = '" & .characteridtxt.Text & "'"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                Dim answer As MsgBoxResult
                answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
                If answer = MsgBoxResult.Yes Then
                    strSQL = "Delete from characters_info" _
                                    & " where Characters_ID = '" _
                                    & .characteridtxt.Text & "'"
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
        Dim form2 As New Form2
        Archons.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class