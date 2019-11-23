
Public Class Form1

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "Febin Thomas" And TextBox2.Text = "111" And TextBox3.Text = "abcd" Then

            Form2.Visible = True
            Form5.Visible = True
            Me.Visible = False

        ElseIf TextBox1.Text = "Ragu Raman" And TextBox2.Text = "222" And TextBox3.Text = "efgh" Then

            Form2.Show()
            Form5.Show()
            Me.Visible = False
        Else
            MsgBox("Incorrect Username or Password")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class


