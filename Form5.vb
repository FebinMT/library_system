Imports System.Data
Imports Oracle.DataAccess.Client 'ODP.NET Oracle managed provider
Imports Oracle.DataAccess.Types
Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim oradb As String = "Data Source=licetorcl;User Id=it5021;Password=licet;"
        Dim conn As New OracleConnection(oradb)
        Dim ColumnCount As Integer
        conn.Open()
        Dim cmd As New OracleCommand
        cmd.Connection = conn
        cmd.CommandText = "select * from library"
        cmd.CommandType = CommandType.Text
        Dim dr As OracleDataReader = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            With Me.DataGridView1
                .Rows.Clear()
                ColumnCount = dr.FieldCount
                For i As Integer = 0 To ColumnCount - 1
                    .Columns.Add(dr.GetName(i), dr.GetName(i))
                Next
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader


                While dr.Read
                    'get all row values into an array
                    Dim objCells(ColumnCount - 1) As Object
                    dr.GetValues(objCells)
                    'add array as a row to grid
                    .Rows.Add(objCells)
                End While
            End With
        Else
            'display message if no rows found
            MessageBox.Show("No Members in the Library")
            Me.DataGridView1.Rows.Clear()

        End If
        'clear up the resources
        dr.Close()

        conn.Dispose()


    End Sub

    
End Class
