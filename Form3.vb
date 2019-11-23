Imports System.Data
Imports Oracle.DataAccess.Client 'ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types



Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "Delete from librarymain_db where s_name = '" & TextBox6.Text & "' and b_name='" & TextBox1.Text & "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "update table librarymain_db set status=Returned where s_name = '" & TextBox6.Text & "' and b_name='" & TextBox1.Text & "'"

        cmd.CommandText = "Delete from library where s_name = '" & TextBox6.Text & "' and b_name='" & TextBox1.Text & "'"

        rowsupdated = cmd.ExecuteNonQuery()

        If (rowsupdated <> 0) Then
            MessageBox.Show("Return Complete")
            Me.Visible = False
            Form2.Visible = True
        Else
            MessageBox.Show("Return incomplete")
        End If
        conn.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form5.Visible = True
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class

