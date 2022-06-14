Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Re

    Private Sub Re_Load_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If MessageBox.Show("Are you sure to close this Form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Dim obj As Assign = New Assign()
            obj.Show()
        'Else
        '    e.Cancel = True


        'End If
    End Sub
    Private Sub Re_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Class1.FromRec
        TextBox2.Text = Class1.ToRec

        Dim clas As String = Class1.UserClass
        If (clas = "Imports") Then



            Me.SupervisorWorkTableAdapter1.FillBy(Me.TradeStatisticsDataSet1.SupervisorWork, Class1.U_Id, 1)
            'Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
            'Me.DataGridView1.Refresh()

        End If

        If (clas = "Exports") Then

            Me.SupervisorWorkTableAdapter1.FillBy(Me.TradeStatisticsDataSet1.SupervisorWork, Class1.U_Id, 3)
            'Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
            'Me.DataGridView1.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim trty As String

            If Class1.tT = 1 Then

                trty = "Imports"
            End If

            If Class1.tT = 3 Then

                trty = "Exports"
            End If

            If TextBox3.Text = ”” Then

                MessageBox.Show("Enter Range")
                Exit Sub
            End If

            If TextBox4.Text = ”” Then

                MessageBox.Show("Enter Range")
                Exit Sub
            End If
            'If 3 < 4 Then
            '    MessageBox.Show("hey")
            'End If

            If Convert.ToInt32(TextBox4.Text) < Convert.ToInt32(TextBox1.Text) Then

                MessageBox.Show("Enter Valid Range")
                Exit Sub
            End If

            If Convert.ToInt32(TextBox3.Text) > Convert.ToInt32(TextBox2.Text) Then

                MessageBox.Show("Enter Valid Range")
                Exit Sub
            End If

            Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString

            Dim sqlCon = New SqlConnection(connectionString)

            Dim reader As SqlDataReader
            Dim reader1 As SqlDataReader
            Dim reader2 As SqlDataReader
            sqlCon.Open()
            Dim query As String
            Dim userid As Int32 = Class1.U_Id
            Dim total As Int32 = Convert.ToInt32(TextBox3.Text) - Convert.ToInt32(TextBox4.Text)
            Dim r As Int32 = Class1.completed
            Dim re As Int32 = total - r

            query = "update SupervisorWork set FromRec='" & Convert.ToInt32(Trim(TextBox4.Text)) & "', ToRec='" & Convert.ToInt32(Trim(TextBox3.Text)) & "' ,Total='" & Convert.ToInt32(total.ToString()) & "' , Remaining='" & Convert.ToInt32(re.ToString()) & "' where ( userID='" & userid & "' and FromRec='" & Convert.ToInt32(Trim(TextBox1.Text)) & "' and ToRec='" & Convert.ToInt32(Trim(TextBox2.Text)) & "' )"
            Dim Command = New SqlCommand(query, sqlCon)
            reader = Command.ExecuteReader
            sqlCon.Close()
            sqlCon.Open()
            Dim nr As Int32 = Convert.ToInt32(TextBox3.Text) + 1
            Dim query1 As String = "Insert into ReleasedRecord(FromRec,ToRec,ReleasedUserId,TT) values('" & nr & "' ,'" & Convert.ToInt32(TextBox2.Text) & "', '" & userid & "' ,'" & trty & "') "
            Dim Command1 = New SqlCommand(query1, sqlCon)
            reader1 = Command1.ExecuteReader
            Class1.FromRec = nr
            Class1.ToRec = Convert.ToInt32(TextBox2.Text)

            sqlCon.Close()
            sqlCon.Open()
            Dim userr As Integer = 0
            Dim query3 As String = "update ImportData set usr='" & userr & "'  where (usr='" & userid & "' and SNO >= '" & nr & "'  and SNO <=  '" & Convert.ToInt32(Trim(TextBox2.Text)) & "' ) "
            Dim Command2 = New SqlCommand(query3, sqlCon)
            reader2 = Command2.ExecuteReader
            sqlCon.Close()

            'Dim obj As Assign = New Assign()
            'obj.Show()

            MessageBox.Show("Data Updated Successfully")
            TextBox3.Text = ""
            TextBox4.Text = ""
            Me.Close()
            'Assign.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        'End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        'Call Assign.Show()
        Assign.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            If TextBox3.Text = ”” Then

                MessageBox.Show("Enter Range")
                Exit Sub
            End If

            If TextBox4.Text = ”” Then

                MessageBox.Show("Enter Range")
                Exit Sub
            End If


            Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString

            Dim sqlCon = New SqlConnection(connectionString)

            Dim reader As SqlDataReader

            sqlCon.Open()

            Dim userid As Int32 = Class1.U_Id
            Dim total As Int32 = Convert.ToInt32(TextBox3.Text) - Convert.ToInt32(TextBox4.Text)
            Dim r As Int32 = Class1.completed
            Dim re As Int32 = total - r



            Dim nr As Int32 = Convert.ToInt32(TextBox3.Text) + 1
            Dim query As String = "Insert into SupervisorWork(userID,UserName,YY,MM,TT,FromRec,ToRec,Total) values('" & Class1.U_Id & "' ,'" & Class1.U_Name & "' ,'" & Class1.YY & "', '" & Class1.MM & "', '" & Class1.tT & "', '" & Convert.ToInt32(TextBox4.Text) & "', '" & Convert.ToInt32(TextBox3.Text) & "' , '" & total & "')  where userID='" & userid & "' "
            Dim Command = New SqlCommand(query, sqlCon)
            reader = Command.ExecuteReader
            Class1.FromRec = nr
            Class1.ToRec = Convert.ToInt32(TextBox2.Text)
            MessageBox.Show("Data Inserted Successfully")
            TextBox3.Text = ""
            TextBox4.Text = ""
            sqlCon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    'Private Sub BtnBack_Click(sender As Object, e As EventArgs)
    '    SupervisorDashboard.Show()
    'End Sub
End Class