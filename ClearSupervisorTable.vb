Public Class ClearSupervisorTable
    Private Sub ClearSupervisorTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet5.SupervisorWork' table. You can move, or remove it, as needed.
        Me.SupervisorWorkTableAdapter3.Fill(Me.TradeStatisticsDataSet5.SupervisorWork)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet4.SupervisorWork' table. You can move, or remove it, as needed.
        Me.SupervisorWorkTableAdapter2.Fill(Me.TradeStatisticsDataSet4.SupervisorWork)
        'TODO: This line of code loads data into the 'SupervisorExport.SupervisorWork' table. You can move, or remove it, as needed.
        'Me.SupervisorWorkTableAdapter1.Fill(Me.SupervisorExport.SupervisorWork)
        'Me.SupervisorWorkTableAdapter1.FillBy(Me.SupervisorExport.SupervisorWork, 3)
        ''TODO: This line of code loads data into the 'TradeStatisticsDataSet1.SupervisorWork' table. You can move, or remove it, as needed.
        ''SupervisorWorkDataGridView.DataMember = Me.SupervisorWorkTableAdapter.FillBy3(Me.TradeStatisticsDataSet1.SupervisorWork)
        ''DataGridView1.DataMember = Me.SupervisorWorkTableAdapter.FillBy4(Me.TradeStatisticsDataSet1.SupervisorWork)
        ''Me.SupervisorWorkTableAdapter.FillBy3(Me.TradeStatisticsDataSet1.SupervisorWork, 1)

        'Me.SupervisorWorkTableAdapter1.FillBy1(Me.SupervisorExport.SupervisorWork, 1)
        ''DataGridView1.DataSource = Me.SupervisorWorkTableAdapter.FillBy4(Me.TradeStatisticsDataSet1.SupervisorWork, 3)
        ''Me.DataGridView1.DataSource = SupervisorWorkBindingSource
        '''Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1, Val(Me.TextBox1.Text))
        ''Me.SupervisorWorkTableAdapter.GetImportDataSupervisorWork()
        ''SupervisorWorkDataGridView.DataSource = Me.SupervisorWorkTableAdapter.GetImportDataSupervisorWork()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SupervisorWorkTableAdapter.DeleteImportData()
        Me.SupervisorWorkTableAdapter.DeleteReleasedRecord("Imports")
        Me.SupervisorWorkTableAdapter.DeleteRecordTracker(1)
        SupervisorWorkDataGridView.ClearSelection()
        'SupervisorWorkDataGridView.Rows.Clear()
        SupervisorWorkDataGridView.DataSource = ""
        'Me.SupervisorWorkTableAdapter.DeleteSuperVisorWorkData()
        'InitializeComponent() 'load all he controls again
        'ClearSupervisorTable_Load(e, e) 'Load everything in your form load event again
        'Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet1.SupervisorWork)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SupervisorWorkTableAdapter.DeleteExportData()
        Me.SupervisorWorkTableAdapter.DeleteReleasedRecord("Exports")
        Me.SupervisorWorkTableAdapter.DeleteRecordTracker(3)
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ""
        'InitializeComponent() 'load all he controls again
        'ClearSupervisorTable_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupervisorWork1TableAdapter.FillBy(Me.TradeStatisticsDataSet.SupervisorWork1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupervisorWork1TableAdapter.FillBy1(Me.TradeStatisticsDataSet.SupervisorWork1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupervisorWork1TableAdapter.FillBy2(Me.TradeStatisticsDataSet.SupervisorWork1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy3ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupervisorWork1TableAdapter.FillBy3(Me.TradeStatisticsDataSet.SupervisorWork1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy4ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SupervisorWork1TableAdapter.FillBy4(Me.TradeStatisticsDataSet1.SupervisorWork1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        SupervisorDashboard.Show()
        Me.Close()
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Try
            Me.SupervisorWorkBindingSource1.Filter = "UserName Like '%" & TextBoxSearch.Text & "%'"
        Catch abc As Exception
            MessageBox.Show("Sorry! Searched UserName does not Exist.")
        End Try
    End Sub

    Private Sub ClearSupervisorTable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SupervisorDashboard.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.SupervisorWorkTableAdapter.DeleteImportData()
        Me.SupervisorWorkTableAdapter.DeleteReleasedRecord("Imports")
        Me.SupervisorWorkTableAdapter.DeleteRecordTracker(1)
        SupervisorWorkDataGridView.ClearSelection()
        'SupervisorWorkDataGridView.Rows.Clear()
        SupervisorWorkDataGridView.DataSource = ""
        'Me.SupervisorWorkTableAdapter.DeleteSuperVisorWorkData()
        'InitializeComponent() 'load all he controls again
        'ClearSupervisorTable_Load(e, e) 'Load everything in your form load event again
        'Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet1.SupervisorWork)


        Me.SupervisorWorkTableAdapter.DeleteExportData()
        Me.SupervisorWorkTableAdapter.DeleteReleasedRecord("Exports")
        Me.SupervisorWorkTableAdapter.DeleteRecordTracker(3)
        DataGridView1.ClearSelection()
        DataGridView1.DataSource = ""
        'InitializeComponent() 'load all he controls again
        'ClearSupervisorTable_Load(e, e) 'Load everything in your form load event again
    End Sub
End Class