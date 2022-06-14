Public Class Assign
    Public Sub Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet1.ReleasedRecord' table. You can move, or remove it, as needed.

        Dim tradetype As String
        If (Class1.tT = 1) Then
            tradetype = "Imports"
            Dim t As Int32 = 8
            Label9.Text = "Import Data Assignment"
        End If




        If (Class1.tT = 3) Then
            tradetype = "Exports"
            Label9.Text = "Export Data Assignment"
        End If

        Me.ReleasedRecordTableAdapter.Fill(Me.TradeStatisticsDataSet1.ReleasedRecord, tradetype)
        'ReAssign Is done here
        'Me.Controls.Clear() 'removes all the controls on the form

        ''InitializeComponent() 'load all he controls again
        ''Assign_Load(e, e) 'Load everything in your form load event again

        Me.Refresh()

        Me.BtnAssign.Enabled = False
        Me.DgvUser.Enabled = False


        With DgvUser
            .Columns("ToRecord").ReadOnly = True
        End With
        'MsgBox("tbl :: " & Class1.table)
        'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        'Class1.previousMonth = Month(previousDate)
        'Class1.preYear = Year(previousDate)
        'Class1.previousYear = Class1.preYear.ToString()
        'Class1.previousYear = Class1.previousYear.Substring(2, 2)

        'Me.TxtBoxYear.Text = Class1.preYear
        'Me.TxtBoxMonth.Text = Class1.previousMonth


        LblValImp.Text = Me.ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)

        'LblImpAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, 1)
        LblImpAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCntForRecNo(Class1.YY, Class1.MM, 1)
        'here made another method Like assigned count of supervisor work

        LblImpRem.Text = Me.ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        LblValExp.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        'LblExpAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, 3)
        LblExpAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCntForRecNo(Class1.YY, Class1.MM, 3)
        LblExpRem.Text = Me.ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        If Class1.table = "ImportData" Then
            LblRcdTot.Text = ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
            'LblAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, Class1.tT)
            LblAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCntForRecNo(Class1.YY, Class1.MM, Class1.tT)
            'change here as wel
            If LblAssigned.Text = "" Then
                Me.LblRemaining.Text = LblRcdTot.Text ''   ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)
                Me.LblAssigned.Text = 0
            Else LblRemaining.Text = LblRcdTot.Text - LblAssigned.Text
                '/// Here assigned sohold be 2000 instead Of 1200
            End If

            LblRemaining.Text = LblRcdTot.Text - LblAssigned.Text   ''ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

            'RemainingFrom.Text = ImportDataTableAdapter.Start_Val(Class1.YY, Class1.MM)
            'RemainingTo.Text = ImportDataTableAdapter.Ending_Val(Class1.YY, Class1.MM)
            'AssignedFrom.Text = ImportDataTableAdapter.AssignedFrom(Class1.YY, Class1.MM)
            'AssignedTo.Text = ImportDataTableAdapter.AssignedTo(Class1.YY, Class1.MM)

            If LblRemaining.Text > 0 Then
                DgvUser.Enabled = True
                BtnAssign.Enabled = True
            End If

        ElseIf Class1.table = "ExportData" Then
            LblRcdTot.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
            'LblAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCnt(Class1.YY, Class1.MM, Class1.tT)
            LblAssigned.Text = Me.SupervisorWorkTableAdapter.AssignedCntForRecNo(Class1.YY, Class1.MM, Class1.tT)

            If LblAssigned.Text = "" Then
                Me.LblAssigned.Text = 0
                Me.LblRemaining.Text = LblRcdTot.Text   ''   ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)
            Else LblRemaining.Text = LblRcdTot.Text - LblAssigned.Text
            End If
            'Me.RemainingFrom.Text = ExportDataTableAdapter.Start_Val(Class1.YY, Class1.MM)
            'Me.RemainingTo.Text = ExportDataTableAdapter.Ending_Val(Class1.YY, Class1.MM)
            'AssignedFrom.Text = Me.ExportDataTableAdapter.AssignedFrom(Class1.YY, Class1.MM)
            'AssignedTo.Text = Me.ExportDataTableAdapter.AssignedTo(Class1.YY, Class1.MM)

            If Me.LblRemaining.Text > 0 Then
                Me.DgvUser.Enabled = True
                Me.BtnAssign.Enabled = True
            End If

        End If
        Me.UsersTableAdapter.FillByUsers(Me.TradeStatisticsDataSet.users, Class1.UserClass, Class1.YY, Class1.MM)
        'Me.DgvUser.DataSource = Me.UsersBindingSource  'added by me 
        ''  End If
        With DgvUser
            If Me.LblRemaining.Text > 0 Then
                .Rows(0).Cells(2).Value = Val(LblAssigned.Text) + 1  ''RemainingFrom.Text
                Class1.GetFromVal = LblAssigned.Text + 1 ''RemainingFrom.Text
                .Rows(0).Cells("ToRecord").ReadOnly = False
            End If

        End With
        If Me.LblRcdTot.Text = Me.LblAssigned.Text Then
            MsgBox("All Work is Assigned.")
            Me.DgvUser.Enabled = False
            'Exit Sub
        End If



        'StartPosition here


        'Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet.SupervisorWork)

        ''Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        ''Class1.previousMonth = Month(previousDate)
        ''Class1.preYear = Year(previousDate)
        ''Class1.previousYear = Class1.preYear.ToString()
        ''Class1.previousYear = Class1.previousYear.Substring(2, 2)

        'LblValImp.Text = Me.ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        'LblImpAssigned.Text = Me.ImportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
        'LblImpRem.Text = Me.ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        'LblValExp.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        'LblExpAssigned.Text = Me.ExportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
        'LblExpRem.Text = Me.ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        'Me.SupervisorWorkTableAdapter.FillBy99(TradeStatisticsDataSet.SupervisorWork, Class1.YY, Class1.MM, Class1.tT)
        'Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
        'Me.DataGridView1.Refresh()
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

        Me.SupervisorWorkTableAdapter.FillBy99(TradeStatisticsDataSet.SupervisorWork, Class1.YY, Class1.MM, Class1.tT)
        Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
        Me.DataGridView1.Refresh()
        'End here


    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs)

        'If Me.comboTT.Text = "" Then
        '    MsgBox("Please Select TradeType")
        '    Me.comboTT.Focus()
        'Else
        '    Class1.TradeType = Me.comboTT.Text
        '    If Class1.TradeType = "Imports" Then
        '        Class1.table = "ImportData"
        '    ElseIf Class1.TradeType = "Exports" Then
        '        Class1.table = "ExportData"
        '    End If
        'If Class1.table = "ImportData" Then
        '    LblRcdTot.Text = ImportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        '    LblAssigned.Text = ImportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
        '    LblRemaining.Text = ImportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        '    RemainingFrom.Text = ImportDataTableAdapter.Start_Val(Class1.YY, Class1.MM)
        '    RemainingTo.Text = ImportDataTableAdapter.Ending_Val(Class1.YY, Class1.MM)
        '    AssignedFrom.Text = ImportDataTableAdapter.AssignedFrom(Class1.YY, Class1.MM)
        '    AssignedTo.Text = ImportDataTableAdapter.AssignedTo(Class1.YY, Class1.MM)

        '    If LblRemaining.Text > 0 Then
        '        DgvUser.Enabled = True
        '        BtnAssign.Enabled = True
        '    End If

        'ElseIf Class1.table = "ExportData" Then
        '    LblRcdTot.Text = Me.ExportDataTableAdapter.Count_Total(Class1.YY, Class1.MM)
        '    LblAssigned.Text = Me.ExportDataTableAdapter.Count_Assigned(Class1.YY, Class1.MM)
        '    Me.LblRemaining.Text = ExportDataTableAdapter.Count_NotAssigned(Class1.YY, Class1.MM)

        '    Me.RemainingFrom.Text = ExportDataTableAdapter.Start_Val(Class1.YY, Class1.MM)
        '    Me.RemainingTo.Text = ExportDataTableAdapter.Ending_Val(Class1.YY, Class1.MM)
        '    AssignedFrom.Text = Me.ExportDataTableAdapter.AssignedFrom(Class1.YY, Class1.MM)
        '    AssignedTo.Text = Me.ExportDataTableAdapter.AssignedTo(Class1.YY, Class1.MM)

        '    If Me.LblRemaining.Text > 0 Then
        '        Me.DgvUser.Enabled = True
        '        Me.BtnAssign.Enabled = True
        '    End If

        'End If
        'Me.UsersTableAdapter.FillByUsers(Me.TradeStatisticsDataSet.users, Class1.YY, Class1.MM)
        '  End If
        'With DgvUser
        '    .Rows(0).Cells("FromRecord").Value = RemainingFrom.Text
        '    Class1.GetFromVal = RemainingFrom.Text
        '    .Rows(0).Cells("ToRecord").ReadOnly = False

        'End With
        'If Me.LblRemaining.Text = 0 Then
        '    MsgBox("Data does not exist in our database for the selected period (Year, Month, and TradeType).")
        'End If
    End Sub
    Private Sub BtnAssign_Click(sender As Object, e As EventArgs) Handles BtnAssign.Click
        'Try
        With DgvUser
            For i As Integer = 0 To .Rows.Count - 1
                Class1.U_Id = .Rows(i).Cells("userID").Value()
                Class1.U_Name = .Rows(i).Cells("UserName").Value()
                Class1.FromRec = .Rows(i).Cells("FromRecord").Value()
                Class1.ToRec = .Rows(i).Cells("ToRecord").Value()
                Class1.cnt = Class1.ToRec - Class1.FromRec + 1
                If .Rows(i).Cells("ToRecord").Value() <= 0 Or .Rows(i).Cells("FromRecord").Value <= 0 Then Exit For
                If Class1.cnt >= 1 And Class1.FromRec <> 0 And Class1.ToRec <> 0 Then

                    Me.SupervisorWorkTableAdapter.InsertIntoRecordTrack(Class1.ToRec, Class1.YY, Class1.MM, Class1.tT)
                    Me.SupervisorWorkTableAdapter.InsertQuery(Class1.U_Id, Class1.U_Name, Class1.FromRec, Class1.ToRec, Class1.cnt, Class1.YY, Class1.MM, Class1.tT)
                    If Class1.tT = 1 Then
                        Me.ImportDataTableAdapter.InsertUsersinImportsData(Class1.U_Id, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateCompletedRec(Class1.U_Id, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateRemaining(Class1.U_Id, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.InsertLatestRecordNumber(Class1.ToRec, 1)
                    ElseIf Class1.tT = 3 Then
                        Me.ExportDataTableAdapter.InsertUsersinExportsData(Class1.U_Id, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateCompletedRec(Class1.U_Id, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateRemaining(Class1.U_Id, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.InsertLatestRecordNumber(Class1.ToRec, 3)
                    End If
                End If
            Next
        End With
        MsgBox("Work Assigned Successfully")

        Me.Controls.Clear() 'removes all the controls on the form

        InitializeComponent() 'load all he controls again
        Assign_Load(e, e) 'Load everything in your form load event again
        'Catch
        '    MsgBox("Invalid Assignment")
        'End Try

    End Sub

    'Private Sub Assign_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    ''Application.Exit()
    '    ''End
    '    Me.Close()
    'End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ''Me.Refresh()
        'Me.Hide()
        Class1.BakFrmAssign = True
        Class1.Asstot = Me.LblRcdTot.Text
        Class1.AssRem = Me.LblRemaining.Text
        Class1.assAss = Me.LblAssigned.Text
        Me.Close()
        SupervisorDashboard.Show()
        '''''ADDED BY ME

    End Sub
    Private Sub DgvUser_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DgvUser.RowValidating
        Try
            With DgvUser
                If e.RowIndex <= .Rows.Count - 1 Then
                    If e.ColumnIndex = .Columns("ToRecord").Index Then
                        If .CurrentCell.Value <> vbNullString Then
                            Dim getRowIndex As Integer = .CurrentCell.RowIndex
                            Class1.From = .Rows(getRowIndex).Cells("FromRecord").Value()
                            'If CDec(.CurrentCell.Value) < CDec(RemainingFrom.Text) Or CDec(.CurrentCell.Value) > CDec(RemainingTo.Text) Then
                            '    MsgBox("Value not in Range")
                            '    .CurrentCell.Value = ""
                            '    .CancelEdit()
                            'ElseIf CDec(.CurrentCell.Value) < CDec(Class1.From) Then
                            '    MsgBox("Value should be greater than or equal to From Rec")
                            '    .CurrentCell.Value = ""
                            '    .CancelEdit()
                            If CDec(.CurrentCell.Value) <= CDec(LblAssigned.Text) Or CDec(.CurrentCell.Value) > CDec(LblRcdTot.Text) Then
                                MsgBox("Value not in Range")
                                .CurrentCell.Value = ""
                                .CancelEdit()
                            ElseIf CDec(.CurrentCell.Value) <= CDec(LblAssigned.Text) Then
                                MsgBox("Value should be greater than or equal to From Rec")
                                .CurrentCell.Value = ""
                                .CancelEdit()

                            Else
                                If e.RowIndex + 1 < .Rows.Count Then
                                    Class1.GetToRowIndex = e.RowIndex
                                    Class1.GetToVal = .CurrentCell.Value
                                    .Rows(e.RowIndex + 1).ReadOnly = False
                                    If Class1.GetToVal + 1 <= LblRemaining.Text Then
                                        Class1.GetFromVal = Class1.GetToVal + 1
                                        .Rows(e.RowIndex + 1).Cells("FromRecord").Value = Class1.GetToVal + 1
                                    End If
                                End If
                                If e.RowIndex = .Rows.Count - 1 Then
                                    If CDec(.CurrentCell.Value) <> (CDec(LblRcdTot.Text)) Then ''CDec(RemainingTo.Text) Then
                                        MsgBox("Val" & CDec(.CurrentCell.Value) & "lbl..." & (CDec(LblRcdTot.Text)))
                                        MsgBox("All remaining records must be assigned to last editor")
                                        .CurrentCell.Value = ""
                                        .CancelEdit()
                                    Else
                                        Class1.GetToVal = CDec(.CurrentCell.Value)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End With
        Catch
            MsgBox("Error Cell Validation")
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub LblRcdTotal_Click(sender As Object, e As EventArgs) Handles LblRcdTotal.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            If e.RowIndex <= .Rows.Count - 1 Then
                ''              MsgBox(.Columns("ImpCNT").Index.ToString)


                If e.ColumnIndex = .Columns("Edit").Index Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("Edit").Value()
                    Dim GetExpCntry As String = .CurrentCell.FormattedValue

                End If

            End If

        End With
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        With DataGridView1

            If e.RowIndex <= .Rows.Count - 1 Then
                ''              MsgBox(.Columns("ImpCNT").Index.ToString)


                If e.ColumnIndex = .Columns("Edit").Index Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("Edit").Value()
                    Dim GetExpCntry As String = .CurrentCell.FormattedValue

                End If

            End If

        End With
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        With DataGridView1

            If e.RowIndex > -1 Then
                If e.ColumnIndex = .Columns("Edit").Index Then
                    Class1.U_Name = .CurrentRow.Cells("DataGridViewTextBoxColumn1").Value()
                    Class1.total = .CurrentRow.Cells("Total").Value()
                    Class1.completed = .CurrentRow.Cells("Completed").Value()
                    Class1.remain = .CurrentRow.Cells("Remaining").Value()
                    Class1.tT = .CurrentRow.Cells("TT").Value()
                    Class1.FromRec = .CurrentRow.Cells("FromRec").Value()
                    Class1.ToRec = .CurrentRow.Cells("ToRec").Value()
                    Class1.U_Id = .CurrentRow.Cells("UID").Value()
                    'Dim username As String = .CurrentRow.Cells("DataGridViewTextBoxColumn1").Value()
                    'Me.Hide()
                    Me.Close()
                    Re.Show()

                    'MsgBox("Data".Concat(e.RowIndex, DataGridView1.Rows.Count))
                    'Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("Edit").Value()
                    'Dim GetExpCntry As String = .CurrentCell.FormattedValue

                End If



            End If
        End With
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

    End Sub

    Private Sub DataGridView1_Enter(sender As Object, e As EventArgs) Handles DataGridView1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        With DataGridView2

            If e.RowIndex > -1 Then
                If e.ColumnIndex = .Columns("ReAssignWk").Index Then
                    Class1.FromRec = .CurrentRow.Cells("FromRecDataGridViewTextBoxColumn").Value()
                    Class1.ToRec = .CurrentRow.Cells("ToRecDataGridViewTextBoxColumn").Value()
                    ReassignWork.Show()
                End If


            End If

        End With
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.SupervisorWorkTableAdapter.FillBy1(Me.TradeStatisticsDataSet.SupervisorWork)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy2ToolStripButton.Click
        Try
            Me.SupervisorWorkTableAdapter.FillBy2(Me.TradeStatisticsDataSet.SupervisorWork)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        With DataGridView2
            If e.RowIndex > -1 Then
                If e.ColumnIndex = .Columns("ReAssignWk").Index Then
                    Class1.FromRec = .CurrentRow.Cells("FromRecDataGridViewTextBoxColumn").Value()
                    Class1.ToRec = .CurrentRow.Cells("ToRecDataGridViewTextBoxColumn").Value()
                    Me.Close()
                    SupervisorDashboard.Show()



                End If


            End If
        End With
    End Sub

    Private Sub DgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUser.CellContentClick

    End Sub

    Private Sub Assign_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SupervisorDashboard.Show()
    End Sub
End Class