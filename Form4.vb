Imports System.Data
Imports Oracle.DataAccess.Client 'ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types

Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox6.Text = Form2.TextBox1.Text
        TextBox7.Text = Form2.TextBox2.Text
        TextBox1.Text = Form2.TextBox3.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oradb As String = "Data Source=licetorcl;User Id=it5021;Password=licet;"
        Dim conn As New OracleConnection(oradb)
        Dim rowsupdated As Integer
        conn.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = "Insert into library values('" & TextBox6.Text & "'," & Val(TextBox7.Text) & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "Insert into librarymain_db values('" & TextBox6.Text & "'," & Val(TextBox7.Text) & ",'" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','Borrowed')"
        rowsupdated = cmd.ExecuteNonQuery()

        If (rowsupdated = 0) Then
            MessageBox.Show("Book Borrow Unsuccessful")
        Else
            MessageBox.Show("Book Borrow Successful")
            Me.Visible = False
            Form2.Visible = True
        End If
        conn.Dispose()
    End Sub


    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form5.Visible = True
    End Sub

    
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class