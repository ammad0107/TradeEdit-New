Imports System.ComponentModel

Public Class frmUsers
    Public Shared olduser As String
    'Public Shared oldFrom As Integer
    Public Shared oldTo As String
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TradeStatisticsDataSet)

    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''çode from assign form
        Me.Refresh()
        olduser = Class1.U_Name
        'oldFrom = Class1.FromRec
        oldTo = Class1.ToRec
        '' Me.BtnAssign.Enabled = False
        Me.DgvUser.Enabled = False
        With DgvUser
            .Columns("ToRecord").ReadOnly = True
        End With
        Me.LblAssigned.Text = 0
        Me.LblRemaining.Text = Class1.cnt
        Me.LblRcdTot.Text = Class1.ToRec
        Me.lblFrom.Text = Class1.FromRec
        Me.lblTo.Text = Class1.ToRec
        If LblRemaining.Text > 0 Then
            DgvUser.Enabled = True
            ''BtnAssign.Enabled = True

        End If
        Me.UsersTableAdapter.becharaUser(Me.TradeStatisticsDataSet.users, Class1.UserClass, Class1.U_Name)
        Me.DgvUser.DataSource = Me.UsersBindingSource  'added by me 
        ''  End If
        With DgvUser
            If Me.LblRemaining.Text > 0 Then
                .Rows(0).Cells(2).Value = Class1.FromRec  ''RemainingFrom.Text
                '' Class1.GetFromVal = LblAssigned.Text + 1 ''RemainingFrom.Text
                .Rows(0).Cells("ToRecord").ReadOnly = False
            End If

        End With
        If Me.LblRcdTot.Text = Me.LblAssigned.Text Then
            MsgBox("All Work is Assigned.")
            Me.DgvUser.Enabled = False
            Exit Sub
        End If


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        'Class1.beCharaUsr = Me.ComboBox1.Text
        'Class1.U_Id = Me.UsersBindingSource.Current("userID").ToString
        'Me.Close()
        ''If Me.LblRemaining.Text = 0 Then
        With DgvUser
            For i As Integer = 0 To .Rows.Count - 1
                Class1.U_Id = .Rows(i).Cells("userID").Value()
                Class1.U_Name = .Rows(i).Cells("UserName").Value()
                Class1.FromRec = .Rows(i).Cells("FromRecord").Value()
                Class1.ToRec = .Rows(i).Cells("ToRecord").Value()
                Class1.cnt = Class1.ToRec - Class1.FromRec + 1
                If .Rows(i).Cells("ToRecord").Value() <= 0 Or .Rows(i).Cells("FromRecord").Value <= 0 Then Exit For
                If Class1.cnt >= 1 And Class1.FromRec <> 0 And Class1.ToRec <> 0 Then
                    Me.SupervisorWorkTableAdapter.ReAssignQry(Class1.U_Id, Class1.U_Name, Class1.FromRec, Class1.ToRec, Class1.cnt, Class1.YY, Class1.MM, Class1.tT)
                    If Class1.tT = 1 Then
                        Me.ImportDataTableAdapter.InsertUsersinImportsData(Class1.U_Id, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                        ''Me.ImportDataTableAdapter.UpdateCompletedRec(Class1.U_Id, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateRemainingImport_ReAssgin(Class1.U_Id, Class1.YY, Class1.MM, Class1.FromRec, Class1.ToRec)
                        Me.ImportDataTableAdapter.updateRemainingImport_reassign2(olduser, Class1.YY, Class1.MM, Class1.oldfrom, oldTo)

                    ElseIf Class1.tT = 3 Then
                        Me.ExportDataTableAdapter.InsertUsersinExportsData(Class1.U_Id, Class1.FromRec, Class1.ToRec, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateCompletedRec(Class1.U_Id, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateRemaining(Class1.U_Id, Class1.YY, Class1.MM)
                    End If
                End If
            Next
        End With
        MsgBox("Work Assigned Successfully")
        Me.Close()

        'Me.Controls.Clear() 'removes all the controls on the form

        'InitializeComponent() 'load all he controls again
        'frmUsers_Load(e, e) 'Load everything in your form load event again
        ''' Else
        ''   MsgBox("Sorry You can not leave this page before Re-Assignment of all the reords", MsgBoxStyle.DefaultButton1)
        '' Me.BtnCancel.Enabled = False
        ''End If
        'Catch
        '    MsgBox("Invalid Assignment")
        'End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblRcdTot_Click(sender As Object, e As EventArgs) Handles LblRcdTot.Click

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
                            If .Rows(e.RowIndex + 1).Cells("FromRecord").Value = "" Then
                                MsgBox("Value can not be NULL")
                                .Rows(e.RowIndex + 1).Cells("FromRecord").Value = ""
                                .CancelEdit()

                            ElseIf CDec(.CurrentCell.Value) <= CDec(LblAssigned.Text) Or CDec(.CurrentCell.Value) > CDec(LblRcdTot.Text) Then
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
                                            ''MsgBox("Val" & CDec(.CurrentCell.Value) & "lbl..." & (CDec(LblRcdTot.Text)))
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
        ''Catch
        ''MsgBox("Error Cell Validation")
        ''''End Try

    End Sub

    Private Sub PictureBoxPBS_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUser.CellContentClick

    End Sub

    Private Sub DgvUser_Validating(sender As Object, e As CancelEventArgs) Handles DgvUser.Validating

    End Sub
End Class