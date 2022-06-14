Public Class SetUnitValueForSummary
    Private Sub CmbYY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbYY.SelectedIndexChanged

    End Sub

    Private Sub LblExports_Click(sender As Object, e As EventArgs) Handles LblExports.Click

    End Sub

    Private Sub SetUnitValueForSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet3.Months' table. You can move, or remove it, as needed.
        Me.MonthsTableAdapter1.Fill(Me.TradeStatisticsDataSet3.Months)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.Months' table. You can move, or remove it, as needed.
        Me.MonthsTableAdapter.Fill(Me.TradeStatisticsDataSet.Months)
        CmbMM.SelectedIndex = -1
        CmbMM.SelectedText = "Select a Month"

        CmbYY.SelectedIndex = -1
        CmbYY.SelectedText = "Select a Year"


        ComboBox1.SelectedIndex = -1
        ComboBox1.SelectedText = "Select a Year"


        ComboBox2.SelectedIndex = -1
        ComboBox2.SelectedText = "Select a Month"
        'Me.ImportSummaryTableAdapter1.Fill(Me.TradeStatisticsDataSet.ImportSummary, Class1.YY, Class1.MM)

        Dim Impmon As Integer = Me.ImportDataTableAdapter1.MonthForUnitValueImport()
        Dim Impyear As Integer = Me.ImportDataTableAdapter1.YearForUnitValueImport()

        Dim Expmon As Integer = Me.ExportDataTableAdapter1.MonthForUnitValueExport()
        Dim Expyear As Integer = Me.ExportDataTableAdapter1.YearForUnitValueExport()
        Dim mname As String = MonthName(Impmon)
        Label7.Text = Impyear
        Label6.Text = mname


        Dim mnameExp As String = MonthName(Expmon)
        Label10.Text = Expyear
        Label11.Text = mnameExp
        'Me.ExportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportSummary, Expyear, Expmon)
        'Me.ImportSummaryTableAdapter1.Fill(Me.TradeStatisticsDataSet.ImportSummary, Impyear, Impmon)
        'CmbMM.SelectedText = Expmon
        'CmbYY.SelectedText = Expyear

        'ComboBox2.SelectedText = Impmon
        'ComboBox1.SelectedText = Impyear

    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles BtnSummary.Click
        If Me.CmbMM.Text = "" Or CmbMM.SelectedIndex < 0 Then
            MsgBox("Please Select Month for Export Summary")
            Me.CmbMM.Focus()
        ElseIf Me.CmbYY.Text = "" Or CmbYY.SelectedIndex < 0 Then
            MsgBox("Please Select Year for Export Summary")
            Me.CmbYY.Focus()
        Else
            Class1.Year = Me.CmbYY.Text
            Class1.Year = Class1.Year.ToString()
            Class1.YY = Class1.Year.ToString.Substring(2, 2)
            Class1.MM = Me.CmbMM.SelectedValue

            'Me.ImportSummaryTableAdapter1.UpdateUnitValueforSummary(Class1.YY, 3, Class1.MM)
            Me.ImportSummaryTableAdapter1.UpdateUnitValueforSummary(Class1.Year, 3, Class1.MM)
            MsgBox("Data Updated Successfully")

            Dim Expmon As Integer = Me.ExportDataTableAdapter1.MonthForUnitValueExport()
            Dim Expyear As Integer = Me.ExportDataTableAdapter1.YearForUnitValueExport()

            Dim mname As String = MonthName(Expmon)
            Label11.Text = Expyear
            Label10.Text = mname
            'CmbYY.SelectedIndex = -1
            'CmbMM.SelectedIndex = -1
            Me.ExportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportSummary, Class1.YY, Class1.MM)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ComboBox2.Text = "" Or ComboBox2.SelectedIndex < 0 Then
            MsgBox("Please Select Month for Import Summary")
            Me.ComboBox2.Focus()
        ElseIf Me.ComboBox1.Text = "" Or ComboBox1.SelectedIndex < 0 Then
            MsgBox("Please Select Year for Import Summary")
            Me.ComboBox1.Focus()
        Else

            Class1.Year = Me.ComboBox1.Text
            Class1.Year = Class1.Year.ToString()
            Class1.YY = Class1.Year.ToString.Substring(2, 2)
            Class1.MM = Me.ComboBox2.SelectedValue
            'Me.ImportSummaryTableAdapter1.UpdateUnitValueforSummary(Class1.YY, 1, Class1.MM)
            Me.ImportSummaryTableAdapter1.UpdateUnitValueforSummary(Class1.Year, 1, Class1.MM)
            MsgBox("Data Updated Successfully")

            Dim Impmon As Integer = Me.ImportDataTableAdapter1.MonthForUnitValueImport()
            Dim Impyear As Integer = Me.ImportDataTableAdapter1.YearForUnitValueImport()

            Dim mname As String = MonthName(Impmon)
            Label7.Text = Impyear
            Label6.Text = mname

            'ComboBox1.SelectedIndex = -1
            'ComboBox2.SelectedIndex = -1
            Me.ImportSummaryTableAdapter1.Fill(Me.TradeStatisticsDataSet.ImportSummary, Class1.YY, Class1.MM)

        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        SupervisorDashboard.Show()
        Me.Close()
    End Sub

    Private Sub SetUnitValueForSummary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub SetUnitValueForSummary_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SupervisorDashboard.Show()
        'Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class