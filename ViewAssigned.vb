Public Class ViewAssigned

    Private Sub ViewAssigned_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet.SupervisorWork)

        'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        'Class1.previousMonth = Month(previousDate)
        'Class1.preYear = Year(previousDate)
        'Class1.previousYear = Class1.preYear.ToString()
        'Class1.previousYear = Class1.previousYear.Substring(2, 2)

        LblValImp.Text = Me.ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        LblImpAssigned.Text = Me.ImportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
        LblImpRem.Text = Me.ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        LblValExp.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        LblExpAssigned.Text = Me.ExportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
        LblExpRem.Text = Me.ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        Me.SupervisorWorkTableAdapter.FillBy99(TradeStatisticsDataSet.SupervisorWork, Class1.YY, Class1.MM, Class1.tT)
        Me.SupervisorWorkDataGridView.DataSource = Me.SupervisorWorkBindingSource
        Me.SupervisorWorkDataGridView.Refresh()

    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs)

        Try
            SupervisorWorkBindingSource.Filter = "UserName Like '%" & TextBoxSearch.Text & "%'"
        Catch abc As Exception
            MessageBox.Show("Sorry! Searched User_Name does not Exist.")
        End Try
    End Sub

    Private Sub TextBoxSearch_Enter(sender As Object, e As EventArgs) Handles TextBoxSearch.Enter
        TextBoxSearch.Text = ""
    End Sub

    Private Sub TextBoxSearch_Click(sender As Object, e As EventArgs) Handles TextBoxSearch.Click
        AddHandler TextBoxSearch.TextChanged, AddressOf TextBoxSearch_TextChanged
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        SupervisorDashboard.Show()
        Me.Close() ''Added by me
    End Sub

    Private Sub ViewAssigned_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ''Application.Exit()
        ''End
    End Sub

    Private Sub TextBoxSearch_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

    End Sub

    Private Sub LblAssExp_Click(sender As Object, e As EventArgs) Handles LblAssExp.Click

    End Sub
End Class