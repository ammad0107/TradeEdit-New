Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class ReassignWork
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            'If TextBox1.Text = ”” Then

            '    MessageBox.Show("Enter Range")
            '    Exit Sub
            'End If

            'If TextBox2.Text = ”” Then

            '    MessageBox.Show("Enter Range")
            '    Exit Sub
            'End If


            Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString

            Dim sqlCon = New SqlConnection(connectionString)

            Dim reader As SqlDataReader

            sqlCon.Open()



            Dim userid As Int32 = ComboBox1.SelectedValue
            Dim total As Int32 = Convert.ToInt32(TextBox3.Text) - Convert.ToInt32(TextBox4.Text)
            Dim r As Int32 = Class1.completed
            Dim re As Int32 = total - r

            Dim nr As Int32 = Convert.ToInt32(TextBox4.Text)
            Dim torec As Int32 = Convert.ToInt32(TextBox3.Text)
            Dim query As String = "Insert into SupervisorWork(userID,UserName,YY,MM,TT,FromRec,ToRec,Total) values('" & ComboBox1.SelectedValue & "' ,'" & ComboBox1.Text & "' ,'" & Class1.YY & "', '" & Class1.MM & "', '" & Class1.tT & "', '" & Convert.ToInt32(TextBox4.Text) & "', '" & Convert.ToInt32(TextBox3.Text) & "' , '" & total & "')   "
            Dim Command = New SqlCommand(query, sqlCon)
            reader = Command.ExecuteReader
            Class1.FromRec = nr
            Class1.ToRec = torec

            sqlCon.Close()

            If Class1.tT = 1 Then
                Me.ImportDataTableAdapter1.InsertUsersinImportsData(userid, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                Me.ImportDataTableAdapter1.UpdateCompletedRec(userid, Class1.YY, Class1.MM)
                Me.ImportDataTableAdapter1.UpdateRemaining(userid, Class1.YY, Class1.MM)
            ElseIf Class1.tT = 3 Then
                Me.ExportDataTableAdapter1.InsertUsersinExportsData(userid, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                Me.ExportDataTableAdapter1.UpdateCompletedRec(userid, Class1.YY, Class1.MM)
                Me.ExportDataTableAdapter1.UpdateRemaining(userid, Class1.YY, Class1.MM)
            End If
            sqlCon.Open()
            Dim query2 As String = "delete from ReleasedRecord where FromRec='" & Convert.ToInt32(TextBox4.Text) & "' and ToRec= '" & Convert.ToInt32(TextBox3.Text) & "'"
            Dim Command1 = New SqlCommand(query2, sqlCon)
            Dim reader1 As SqlDataReader
            reader1 = Command1.ExecuteReader
            sqlCon.Close()
            Dim obj As Assign = New Assign()
            obj.Show()
            MessageBox.Show("Data Inserted Successfully")
            TextBox3.Text = ""
            TextBox4.Text = ""





            sqlCon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub ReassignWork_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If MessageBox.Show("Are you sure to close this Form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Dim obj As Assign = New Assign()
            obj.Show()
        'Else
        '    e.Cancel = True


        'End If
    End Sub
    Private Sub ReassignWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.SupervisorWork' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'TradeStatisticsDataSet2.users' table. You can move, or remove it, as needed.

        Dim clas As String = Class1.UserClass
        If (clas = "Imports") Then
            Me.UsersTableAdapter1.FillBy(Me.TradeStatisticsDataSet2.users, "Imports")

            Dim message As String = "UserName: " & ComboBox1.Text
            message += Environment.NewLine
            message += "userID: " & ComboBox1.SelectedValue
            'MessageBox.Show(message)
            Me.SupervisorWorkTableAdapter.FillBy(Me.TradeStatisticsDataSet.SupervisorWork, ComboBox1.SelectedValue, 1)
            ComboBox1.SelectedIndex = -1
            ComboBox1.Text = "Select Employee Name"
        End If

        If (clas = "Exports") Then
            Me.UsersTableAdapter1.FillBy(Me.TradeStatisticsDataSet2.users, "Exports")
            'Me.SupervisorWorkTableAdapter.FillBy(Me.TradeStatisticsDataSet.SupervisorWork, 10, 3)
            Dim message As String = "UserName: " & ComboBox1.Text
            message += Environment.NewLine
            message += "userID: " & ComboBox1.SelectedValue
            'MessageBox.Show(message)
            Me.SupervisorWorkTableAdapter.FillBy(Me.TradeStatisticsDataSet.SupervisorWork, ComboBox1.SelectedValue, 3)
        End If

        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.TradeStatisticsDataSet.users)
        TextBox4.Text = Class1.FromRec
        TextBox3.Text = Class1.ToRec

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.UsersTableAdapter1.FillBy(Me.TradeStatisticsDataSet2.users, ClasToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        'Try
        '    Me.UsersTableAdapter1.FillBy(Me.TradeStatisticsDataSet2.users, ClasToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim clas As String = Class1.UserClass
        If (clas = "Imports") Then


            Dim message As String = "UserName: " & ComboBox1.Text
            message += Environment.NewLine
            message += "userID: " & ComboBox1.SelectedValue
            'MessageBox.Show(message)
            Me.SupervisorWorkTableAdapter.FillBy(Me.TradeStatisticsDataSet.SupervisorWork, ComboBox1.SelectedValue, 1)

        End If


        If (clas = "Exports") Then


            Dim message As String = "UserName: " & ComboBox1.Text
            message += Environment.NewLine
            message += "userID: " & ComboBox1.SelectedValue
            'MessageBox.Show(message)
            Me.SupervisorWorkTableAdapter.FillBy(Me.TradeStatisticsDataSet.SupervisorWork, ComboBox1.SelectedValue, 3)

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class