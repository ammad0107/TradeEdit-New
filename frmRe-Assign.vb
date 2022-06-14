Public Class frmRe_Assign
    Private Sub SupervisorWorkDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frmRe_Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Refresh()


        With Me.DataGridView1
            .Columns("ToRec").ReadOnly = True
        End With
        Dim userClass = ""
        If Class1.tT = 3 Then
            userClass = "Exports"
        Else
            If Class1.tT = 1 Then userClass = "Imports"
        End If
        ''Me.DataGridView1.DataSource = Me.UsersTableAdapter.FillBy1(Me.TradeStatisticsDataSet.users, userClass)
        'MsgBox("tbl :: " & Class1.table)
        'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        'Class1.previousMonth = Month(previousDate)
        'Class1.preYear = Year(previousDate)
        'Class1.previousYear = Class1.preYear.ToString()
        'Class1.previousYear = Class1.previousYear.Substring(2, 2)

        'Me.TxtBoxYear.Text = Class1.preYear
        'Me.TxtBoxMonth.Text = Class1.previousMonth


        ''   LblValImp.Text = Me.ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        '' LblImpAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, 1)

        '' LblImpRem.Text = Me.ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        '' LblValExp.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        ''LblExpAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, 3)

        ''''        LblExpRem.Text = Me.ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        'If Class1.table = "ImportData" Then
        '    LblRcdTot.Text = ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        '    LblAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, Class1.tT)
        '    If LblAssigned.Text = "" Then
        '        Me.LblRemaining.Text = LblRcdTot.Text ''   ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)
        '        Me.LblAssigned.Text = 0
        '    Else LblRemaining.Text = LblRcdTot.Text - LblAssigned.Text
        '    End If

        '    LblRemaining.Text = LblRcdTot.Text - LblAssigned.Text   ''ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        '    'RemainingFrom.Text = ImportDataTableAdapter.Start_Val(Class1.YY, Class1.MM)
        '    'RemainingTo.Text = ImportDataTableAdapter.Ending_Val(Class1.YY, Class1.MM)
        '    'AssignedFrom.Text = ImportDataTableAdapter.AssignedFrom(Class1.YY, Class1.MM)
        '    'AssignedTo.Text = ImportDataTableAdapter.AssignedTo(Class1.YY, Class1.MM)

        '    If LblRemaining.Text > 0 Then
        '        DataGridView1.Enabled = True
        '        '' BtnAssign.Enabled = True
        '    End If

        'ElseIf Class1.table = "ExportData" Then
        '    LblRcdTot.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        '    LblAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, Class1.tT)
        '    If LblAssigned.Text = "" Then
        '        Me.LblAssigned.Text = 0
        '        Me.LblRemaining.Text = LblRcdTot.Text   ''   ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)
        '    Else LblRemaining.Text = LblRcdTot.Text - LblAssigned.Text
        '    End If
        '    'Me.RemainingFrom.Text = ExportDataTableAdapter.Start_Val(Class1.YY, Class1.MM)
        '    'Me.RemainingTo.Text = ExportDataTableAdapter.Ending_Val(Class1.YY, Class1.MM)
        '    'AssignedFrom.Text = Me.ExportDataTableAdapter.AssignedFrom(Class1.YY, Class1.MM)
        '    'AssignedTo.Text = Me.ExportDataTableAdapter.AssignedTo(Class1.YY, Class1.MM)

        'If Me.LblRemaining.Text > 0 Then
        '        Me.DataGridView1.Enabled = True
        '        '' Me.BtnAssign.Enabled = True
        '    End If

        'End If
        'Me.UsersTableAdapter.FillByUsers(Me.TradeStatisticsDataSet.users, Class1.YY, Class1.MM)
        '''  End If
        'With DgvUser
        '    If Me.LblRemaining.Text > 0 Then
        '        .Rows(0).Cells("FromRecord").Value = LblAssigned.Text + 1  ''RemainingFrom.Text
        '        Class1.GetFromVal = LblAssigned.Text + 1 ''RemainingFrom.Text
        '        .Rows(0).Cells("ToRecord").ReadOnly = False
        '    End If

        '' End With
        'If Me.LblRcdTot.Text = Me.LblAssigned.Text Then
        '    MsgBox("All Work is Assigned.")
        '    ''Me.DgvUser.Enabled = False
        '    Exit Sub
        'End If

        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.SupervisorWork' table. You can move, or remove it, as needed.
        Me.SupervisorWorkTableAdapter.FillBy99(TradeStatisticsDataSet.SupervisorWork, Class1.YY, Class1.MM, Class1.tT)
        Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
        Me.DataGridView1.Refresh()

        ''Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet.SupervisorWork)

    End Sub

    Private Sub BtnclrAssign_Click(sender As Object, e As EventArgs)
        ''Me.SupervisorWorkTableAdapter.ReAssignQuery1((Class1.YY, Class1.MM, Class1.tT)
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        SupervisorDashboard.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LblRcdTotal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblAssigned_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblTRecords_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblRemaining_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblRcdTot_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnreAssgn_Click(sender As Object, e As EventArgs) Handles BtnreAssgn.Click
        With Me.DataGridView1
            Dim selected = .SelectedRows.Count
            Dim idx = .CurrentRow.Index
            If idx < 0 Or selected > 1 Then
                MsgBox("Kindly Select one Row to re-Assign the Work")
                Exit Sub
            Else
                Class1.ToRec = .Rows(idx).Cells("ToRec").Value()
                Class1.FromRec = .Rows(idx).Cells("FromRec").Value() + .Rows(idx).Cells("Completed").Value
                Class1.oldfrom = .Rows(idx).Cells("FromRec").Value()
                Class1.cnt = Class1.ToRec - Class1.FromRec + 1
                Class1.U_Name = .Rows(idx).Cells("UserName").Value
                frmUsers.ShowDialog()
                Me.Hide()
                '' Class1.U_Id = .Rows(idx).Cells("UserID").Value()
                ''Class1.U_Name = .Rows(idx).Cells("UserName").Value()

                Dim FromRec1 As Integer = .Rows(idx).Cells("FromRec").Value() + .Rows(idx).Cells("Completed").Value
                '' If .Rows(idx).Cells("ToRec").Value() <= 0 Or .Rows(idx).Cells("FromRec").Value <= 0 Then Exit For
                ''If Class1.cnt >= 1 And FromRec1 <> 0 And Class1.ToRec <> 0 Then
                '' Me.SupervisorWorkTableAdapter.InsertQuery(Class1.U_Id, Class1.beCharaUsr, FromRec1, Class1.ToRec, Class1.cnt, Class1.YY, Class1.MM, Class1.tT)
                ''Temporary comment
                ''Me.SupervisorWorkTableAdapter.ReAssignQuery1(.Rows(idx).Cells("Complete").ToString, Class1.YY, Class1.MM, Class1.tT, Class1.U_Name)
                ''If Class1.tT = 1 Then
                ''Me.ImportDataTableAdapter.InsertUsersinImportsData(Class1.U_Id, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                ''Me.ImportDataTableAdapter.UpdateCompletedRec(Class1.U_Id, Class1.YY, Class1.MM)
                ''Me.ImportDataTableAdapter.UpdateRemaining(Class1.U_Id, Class1.YY, Class1.MM)
                ''ElseIf Class1.tT = 3 Then
                ''  Me.ExportDataTableAdapter.InsertUsersinExportsData(Class1.U_Id, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                ''Me.ExportDataTableAdapter.UpdateCompletedRec(Class1.U_Id, Class1.YY, Class1.MM)
                ''Me.ExportDataTableAdapter.UpdateRemaining(Class1.U_Id, Class1.YY, Class1.MM)
                ''End If
                '' End If
                '' Next
            End If
        End With
        ''MsgBox("Work re-assigned Successfully")

        ''Me.Controls.Clear() 'removes all the controls on the form

        ''InitializeComponent() 'load all he controls again
        ''frmRe_Assign_Load(e, e) 'Load everything in your form load event again
        'Catch
        '    MsgBox("Invalid Assignment")
        'End Try

    End Sub
End Class