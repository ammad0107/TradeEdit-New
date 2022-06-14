Public Class SupervisorDashboard
    Private Sub SupervisorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.SupervisorWork' table. You can move, or remove it, as needed.
        Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet.SupervisorWork)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.users' table. You can move, or remove it, as needed.
        ''''Me.UsersTableAdapter.Fill(Me.TradeStatisticsDataSet.users)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.Months' table. You can move, or remove it, as needed.
        Me.MonthsTableAdapter.Fill(Me.TradeStatisticsDataSet.Months)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ImportSummary' table. You can move, or remove it, as needed.
        ''  Me.ImportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ImportSummary)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ExportSummary' table. You can move, or remove it, as needed.
        ''  Me.ExportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportSummary)
        If (Class1.Role = "superadmin") Then
            Button1.Visible = True
            Button4.Visible = True
        End If
        Lbl_UserName.Text = Class1.U_Name
        ''End If
        Assign.Close()
        'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        'Class1.previousMonth = Month(previousDate)
        'Class1.preYear = Year(previousDate)
        'Class1.previousYear = Class1.preYear.ToString()
        'Class1.previousYear = Class1.previousYear.Substring(2, 2)


    End Sub



    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.Controls.Clear()
        'Application.Exit()
        '
        'End
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim opt As Integer = MessageBox.Show("Are You Sure to Log Out ?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If opt = 6 Then
            Application.Exit()
            End
        End If
    End Sub

    Private Sub ImportDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ImportDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TradeStatisticsDataSet)

    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles BtnSummary.Click
        Dim tot As Decimal
        Dim flgRec As Boolean
        flgRec = False
        tot = 0
        If Me.CmbYY.Text = "" Then
            MsgBox("Please Select Year")
            Me.CmbYY.Focus()
        ElseIf Me.CmbMM.Text = "" Then
            MsgBox("Please Select Month")
            Me.CmbMM.Focus()
        Else
            Class1.Year = Me.CmbYY.Text
            Class1.Year = Class1.Year.ToString()
            Class1.YY = Class1.Year.ToString.Substring(2, 2)
            Class1.MM = Me.CmbMM.SelectedValue
            ''Checking Data is still open for editing or not ,summary generated or not
            If Me.ImportSummaryTableAdapter.IsSummary(Class1.YY, Class1.MM) > 0 Then
                Me.lblimpFinal.Visible = True
                MsgBox("Sorry Import Data for month " & Class1.MM & "and Year" & Class1.YY & " is finalized/summary generated,no record for editing")
                'Exit Sub
                Me.lblimpFinal.Text = "Import Data already finalized"
            Else
                '' Showing Total counts
                flgRec = True
                Me.BtnImpAssign.Enabled = True
                Me.BtnImpViewAssigned.Enabled = True
                Me.btnEditorImport.Enabled = True
                Me.btnReAssign_Imp.Enabled = True
                Me.btnEditRec_Imp.Enabled = True
                Me.btnEditRec_Exp.Enabled = True
                Me.Button3.Enabled = True
                Me.Button2.Enabled = True
                Me.btnexpAssign.Enabled = True
                Me.btnReAsgn_Exp.Enabled = True
                Me.btnExpViewAssigned.Enabled = True
                LblValImp.Text = Me.ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
                LblImpAssigned.Text = Me.ImportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
                LblImpRem.Text = Me.ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)
            End If
            ''Checking Data is still open for editing or not ,summary generated or not
            If Me.ExportSummaryTableAdapter.IsSummary(Class1.YY, Class1.MM) > 0 Then
                Me.lblExpFinal.Visible = True
                MsgBox("Sorry Export Data for month " & Class1.MM & "and Year" & Class1.YY & " is finalized/summary generated,no record for editing")
                Me.lblExpFinal.Text = "Export Data already finalized"
                Exit Sub
            Else
                '' Showing Total counts
                flgRec = True
                Me.btnexpAssign.Enabled = True
                Me.btnExpViewAssigned.Enabled = True
                LblValExp.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
                LblExpAssigned.Text = Me.ExportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
                LblExpRem.Text = Me.ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)
            End If
            If flgRec = False Then Me.BtnImpAssign.Enabled = False And Me.BtnImpViewAssigned.Enabled = False
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblimpFinal.Click

    End Sub



    Private Sub BtnImpAssign_Click(sender As Object, e As EventArgs) Handles BtnImpAssign.Click
        Class1.tT = 1 'import 
        Class1.table = "ImportData"
        Class1.UserClass = "Imports"
        Me.Hide()
        Assign.Show()
        ''Me.Close()

    End Sub

    Private Sub BtnImpViewAssigned_Click(sender As Object, e As EventArgs) Handles BtnImpViewAssigned.Click
        Class1.tT = 1 'import 
        Class1.table = "ImportData"
        Me.Hide()
        ViewAssigned.Show()

    End Sub

    Private Sub BtnexpAssign_Click(sender As Object, e As EventArgs) Handles btnexpAssign.Click
        Class1.tT = 3
        Class1.table = "ExportData"
        Class1.UserClass = "Exports"
        Me.Hide()
        '' Assign.Close()
        Assign.Show()
        '' Me.Close()

    End Sub

    Private Sub BtnExpViewAssigned_Click(sender As Object, e As EventArgs) Handles btnExpViewAssigned.Click
        Class1.tT = 3
        Class1.table = "ExportData"
        Me.Hide()
        ViewAssigned.Show()

    End Sub

    Private Sub SupervisorDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Class1.BakFrmAssign = True Then
            If Class1.tT = 1 Then
                Me.LblValImp.Text = Class1.Asstot
                Me.LblImpRem.Text = Class1.AssRem
                Me.LblImpAssigned.Text = Class1.assAss
            ElseIf Class1.tT = 3 Then
                Me.LblValExp.Text = Class1.Asstot
                Me.LblExpRem.Text = Class1.AssRem
                Me.LblExpAssigned.Text = Class1.assAss


            End If
            BtnSummary.PerformClick()  ''for user coming from assign form so that will update summary automatically
            Class1.BakFrmAssign = False
        End If
    End Sub

    Private Sub btnEditorImport_Click(sender As Object, e As EventArgs) Handles btnEditorImport.Click
        Me.Hide()
        EditorClassificaiton.Show()
    End Sub

    Private Sub btnReAssign_Imp_Click(sender As Object, e As EventArgs) Handles btnReAssign_Imp.Click
        Class1.tT = 1
        Class1.UserClass = "Imports"
        Me.Hide()
        frmRe_Assign.Show()
    End Sub
    Public TradeType As String

    Private Sub btnEditRec_Imp_Click(sender As Object, e As EventArgs) Handles btnEditRec_Imp.Click


        TradeType = "1"
        Dim Obj As New frmVwEditRec_imp
        Class1.TradeType = "Imports"
        Obj.StrVariable = TradeType.ToString()
        Me.Hide()
        frmVwEditRec_imp.Show()
    End Sub

    Private Sub btnReAsgn_Exp_Click(sender As Object, e As EventArgs) Handles btnReAsgn_Exp.Click
        Class1.tT = 3
        Class1.UserClass = "Exports"
        Me.Hide()
        frmRe_Assign.Show()

    End Sub



    Private Sub btnEditRec_Exp_Click(sender As Object, e As EventArgs) Handles btnEditRec_Exp.Click
        'Dim TradeType As String
        TradeType = "2"
        Dim Obj As New frmVwEditRec_imp
        Obj.StrVariable = TradeType.ToString()
        Class1.TradeType = "Exports"




        frmVwEditRec_imp.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim result As DialogResult = MessageBox.Show("Do You Want TO delete Supervisor Table??", "Clear SuperVisor Table Data", MessageBoxButtons.YesNoCancel)
        'If result = DialogResult.Cancel Then
        '    'MessageBox.Show("Cancel pressed")
        'ElseIf result = DialogResult.No Then
        '    'MessageBox.Show("No pressed")
        'ElseIf result = DialogResult.Yes Then
        '    Me.SupervisorWorkTableAdapter.DeleteSuperVisorWorkData()
        '    MessageBox.Show("Supervisor Table Cleared")
        '    Button1.Enabled = False
        'End If

        ClearSupervisorTable.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditImportSummary.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditExportSummary.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetUnitValueForSummary.Show()
        Me.Hide()
    End Sub

    Private Sub SupervisorDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginTrade.Show()
    End Sub
End Class