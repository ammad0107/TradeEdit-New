Public Class frmVwEditRec_imp
    Private Sub LblTitleBar_Click(sender As Object, e As EventArgs)

    End Sub

    Public Property stringpass As String

    Private Sub LblImp_Click(sender As Object, e As EventArgs) Handles LblImp.Click

    End Sub

    Private Sub LblHeading_Click(sender As Object, e As EventArgs) Handles LblHeading.Click

    End Sub

    Private Sub LblValImp_Click(sender As Object, e As EventArgs) Handles LblValImp.Click

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "2") Then
            Try
                Me.ExportDataBindingSource.Filter = "UserName Like '%" & TextBoxSearch.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched User_Name does not Exist.")
            End Try
        End If
        If (userclass = "1") Then
            Try
                Me.ImportDataBindingSource.Filter = "UserName Like '%" & TextBoxSearch.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched User_Name does not Exist.")
            End Try
        End If


    End Sub

    Private Sub ImportDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImportDataBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImportDataBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.ImportDataBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.TradeStatisticsDataSet)

    End Sub
    'Dim tradeTy As Int32
    'Public Sub New(tt As Int32)
    '    InitializeComponent()
    '    tradeTy = tt

    'End Sub
    Public StrVariable As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim userclass As String = StrVariable
        Dim label As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        'userclass = "2"

        If userclass = "2" Then
            'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ExportData' table. You can move, or remove it, as needed.
            'Me.ExportDataTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportData)
            Me.ExportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ExportData, Class1.MM, Class1.YY)
            Me.DataGridView1.DataSource = Me.ExportDataBindingSource
            'Me.ImportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ImportData, Class1.MM, Class1.YY)
            Me.LblValImp.Text = Me.DataGridView1.Rows.Count
            Me.Label3.Text = "EXPORT"
            userclass = "0"
        End If
        'MessageBox.Show(tradeTy.ToString())
        'Dim userclass As String = Class1.UserClass
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.Hscode' table. You can move, or remove it, as needed.
        'Me.HscodeTableAdapter.Fill(Me.TradeStatisticsDataSet.Hscode)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.Country' table. You can move, or remove it, as needed.
        'Me.CountryTableAdapter1.Fill(Me.TradeStatisticsDataSet.Country)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ImportData' table. You can move, or remove it, as needed.
        '' Me.ImportDataTableAdapter.Fill(Me.TradeStatisticsDataSet.ImportData)
        If userclass = "1" Then
            Me.ImportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ImportData, Class1.MM, Class1.YY)

            Me.LblValImp.Text = Me.DataGridView1.Rows.Count
            Me.Label3.Text = "IMPORT"
            '    'Me.DataGridView1.AutoResizeColumns()
            'Me.DataGridView1.DataSource = Me.ExportDataBindingSource
            '    'Me.DataGridView1.Refresh()
            'End If
            'For i = 0 To Me.DataGridView1.Rows.Count - 1
            '    If (Me.ImportDataBindingSource.Current("Updated").ToString = "Y") Then
            '        Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Yellow
            '    ElseIf (Me.ImportDataBindingSource.Current("Updated").ToString = "N") Then
            '        Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Red
            userclass = "0"
        End If
        'Next
    End Sub

    'New method to save data

    Private Sub DgvImp_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        With DataGridView1


            Dim userclass As String = StrVariable
            Dim Obj As New SupervisorDashboard
            userclass = SupervisorDashboard.TradeType
            'userclass = "1"

            'Export
            If userclass = "2" Then

                If e.RowIndex <= .Rows.Count - 1 Then
                    ''              MsgBox(.Columns("ImpCNT").Index.ToString)


                    If e.ColumnIndex = .Columns("ImpCNT").Index Then
                        Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetExpCntry As String = .CurrentCell.FormattedValue
                        Dim CheckCNT As Integer = Me.CountryTableAdapter1.CheckCNT(GetExpCntry)
                        If CheckCNT > 0 Then
                            Me.ExportDataTableAdapter.UpdateCountry(GetExpCntry, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                            ''''''''refill and update Gridview
                            ''Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                            '' Me.DgvImp.Refresh()
                            Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        Else
                            .CancelEdit()
                            '.CurrentCell.Style.BackColor = Color.Red
                            '.CurrentCell.Style.ForeColor = Color.White
                            MsgBox("The Entered CountryCode does not Exist")
                        End If
                    End If
                    If e.ColumnIndex = .Columns("ImpQty").Index Then
                        Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetExpQty As Integer = .CurrentCell.Value
                        Me.ExportDataTableAdapter.UpdateQuantity(GetExpQty, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                        ''''''''refill and update Gridview
                        'Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                        'Me.DataGridView1.Refresh()
                        Me.ExportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ExportData, Class1.MM, Class1.YY)
                        Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    End If



                    If e.ColumnIndex = .Columns("ImpTT").Index Then
                        Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetExpTT As String = .CurrentCell.Value

                        Dim CheckTT As Integer = Me.ExportDataTableAdapter.CheckTradeTypeExp(GetExpTT)
                        If GetExpTT = 3 Or GetExpTT = 4 Then
                            'If CheckTT > 0 Then
                            Me.ExportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                            'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)
                            '''''''''refill and update Gridview
                            '''
                            Me.ExportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ExportData, Class1.MM, Class1.YY)
                            'Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                            ''  Me.DgvImp.Refresh()
                            Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        Else
                            .CancelEdit()
                            '.CurrentCell.Style.BackColor = Color.Red
                            '.CurrentCell.Style.ForeColor = Color.White
                            MsgBox("The Entered Trade Type does not Exist in our database")
                        End If
                    End If




                    If e.ColumnIndex = .Columns("ImpHs").Index Then
                        Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetExpHS As String = .CurrentCell.Value
                        Dim CheckHS As Integer = Me.HscodeTableAdapter.CheckHS(GetExpHS)
                        If CheckHS > 0 Then
                            Me.ExportDataTableAdapter.UpdateHsCode(GetExpHS, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportDataTableAdapter.UpdateUnitHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                            ''''''''refill and update Gridview
                            'Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                            ''  Me.DgvImp.Refresh()
                            Me.ExportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ExportData, Class1.MM, Class1.YY)
                            Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        Else
                            .CancelEdit()
                            '.CurrentCell.Style.BackColor = Color.Red
                            '.CurrentCell.Style.ForeColor = Color.White
                            MsgBox("The Entered HS-Code does not Exist in our database")
                            userclass = "0"
                        End If
                    End If
                End If

            End If
            If userclass = "1" Then
                'import
                If e.RowIndex <= .Rows.Count - 1 Then
                    ''              MsgBox(.Columns("ImpCNT").Index.ToString)
                    If e.ColumnIndex = .Columns("ImpCNT").Index Then
                        Dim GetImpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetImpCntry As String = .CurrentCell.FormattedValue
                        Dim CheckCNT As Integer = Me.CountryTableAdapter1.CheckCNT(GetImpCntry)
                        If CheckCNT > 0 Then
                            Me.ImportDataTableAdapter.UpdateCountry(GetImpCntry, GetImpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)
                            ''''''''refill and update Gridview
                            ''Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                            '' Me.DgvImp.Refresh()
                            Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        Else
                            .CancelEdit()
                            '.CurrentCell.Style.BackColor = Color.Red
                            '.CurrentCell.Style.ForeColor = Color.White
                            MsgBox("The Entered CountryCode does not Exist")
                        End If
                    End If
                    If e.ColumnIndex = .Columns("ImpQty").Index Then
                        Dim GetImpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetImpQty As Integer = .CurrentCell.Value
                        Me.ImportDataTableAdapter.UpdateQuantity(GetImpQty, GetImpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUnitVal(GetImpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)
                        ''''''''refill and update Gridview
                        'Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                        'Me.DataGridView1.Refresh()
                        Me.ImportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ImportData, Class1.MM, Class1.YY)
                        Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    End If



                    If e.ColumnIndex = .Columns("ImpTT").Index Then
                        Dim GetImpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetImpTT As String = .CurrentCell.Value

                        Dim CheckTT As Integer = Me.ImportDataTableAdapter.CheckTradeType(GetImpTT)
                        If GetImpTT = 1 Or GetImpTT = 2 Then
                            'If CheckTT > 0 Then
                            Me.ImportDataTableAdapter.UpdateTradeType(GetImpTT, GetImpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)
                            'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)
                            '''''''''refill and update Gridview
                            '''
                            Me.ImportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ImportData, Class1.MM, Class1.YY)
                            'Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                            ''  Me.DgvImp.Refresh()
                            Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        Else
                            .CancelEdit()
                            '.CurrentCell.Style.BackColor = Color.Red
                            '.CurrentCell.Style.ForeColor = Color.White
                            MsgBox("The Entered Trade Type does not Exist in our database")
                        End If
                    End If


                    If e.ColumnIndex = .Columns("ImpHs").Index Then
                        Dim GetImpRowRecNo As Integer = .CurrentRow.Cells("ImpSNO").Value()
                        Dim GetImpHS As String = .CurrentCell.Value
                        Dim CheckHS As Integer = Me.HscodeTableAdapter.CheckHS(GetImpHS)
                        If CheckHS > 0 Then
                            Me.ImportDataTableAdapter.UpdateHsCode(GetImpHS, GetImpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter.UpdateUnitHsDesc(GetImpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)
                            ''''''''refill and update Gridview
                            'Me.ImportDataTableAdapter.FillBy1(Me.TradeStatisticsDataSet.ImportData, Class1.YY, Class1.MM)
                            ''  Me.DgvImp.Refresh()
                            Me.ImportDataTableAdapter.EditorRec(Me.TradeStatisticsDataSet.ImportData, Class1.MM, Class1.YY)
                            Me.DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        Else
                            .CancelEdit()
                            '.CurrentCell.Style.BackColor = Color.Red
                            '.CurrentCell.Style.ForeColor = Color.White
                            MsgBox("The Entered HS-Code does not Exist in our database")
                            userclass = "0"
                        End If
                    End If
                End If
            End If
        End With

    End Sub

    'method



    Private Sub TextBoxSearch_Enter(sender As Object, e As EventArgs) Handles TextBoxSearch.Enter
        AddHandler TextBoxSearch.TextChanged, AddressOf TextBoxSearch_TextChanged
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        SupervisorDashboard.Show()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        'For i = 0 To Me.DataGridView1.Rows.Count - 1
        If (e.ColumnIndex = 12) Then
            If (Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "Y") Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Red 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Yellow
            ElseIf (Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "N") Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.White 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Red
            End If
            ' Next
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = Class1.TradeType
        If (userclass = "Exports") Then
            Try
                Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBox2.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
            End Try


        End If
        If (userclass = "Imports") Then
            Try
                Me.ImportDataBindingSource.Filter = "hs Like '%" & TextBox2.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
            End Try


        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = Class1.TradeType
        'Dim tt As Int32
        'userclass = Class1.TradeType
        If (userclass = "Exports") Then
            Try
                Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched Country does not Exist.")
            End Try


        End If
        If (userclass = "Imports") Then
            Try
                Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched Country does not Exist.")
            End Try


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        SupervisorDashboard.Show()
        Me.Close() ''Added by me
    End Sub

    Private Sub frmVwEditRec_imp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SupervisorDashboard.Show()
    End Sub
End Class