Imports System.Configuration
Imports System.Data.SqlClient

Public Class EditExportSummary
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Try
            'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%'"
            Me.ExportSummaryBindingSource.Filter = "HS Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%' "
            'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%'"
        Catch abc As Exception
            'MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            'Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"

            'Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
            Me.ExportSummaryBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%' and HS like '%" & TextBoxSearch.Text & "%'"
        Catch abc As Exception
            'MessageBox.Show("Sorry! Searched Country does not Exist.")
        End Try
    End Sub

    Private Sub EditExportSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ExportSummary' table. You can move, or remove it, as needed.
            Me.ExportSummaryTableAdapter.FillBy222(Me.TradeStatisticsDataSet.ExportSummary, Class1.YY, Class1.MM)
            'Me.ExportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportSummary)
            Lbl_UserName.Text = Class1.U_Name
            Dim Month As String = Class1.MonthName(Class1.MM)
            Me.Label10.Text = "    " & Month & " 20" & Class1.YY





            DgvExp.ClearSelection()
            DgvExp.Rows(rowind).Cells(colind).Selected = True
            If Class1.lastSavedIndexflag = 1 Then
                DgvExp.ClearSelection()
                'Dim r = Class1.rowindx
                'Dim c = Class1.colindx
                Dim r = rowind
                Dim c = 0

                'DgvImp.CurrentCell = Me.ro.Cells(0)
                'DgvImp.Rows(r).Selected = True
                Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c)
                'DgvImp.Rows(r).Cells(c - 1).Selected = True
                'DgvImp.SelectedRows(9).Selected = True
                'updatevalue = 0
                Class1.lastSavedIndexflag = 0
                'Class1.FormulaIndexPos = 0
            End If
            If Class1.FormulaIndexPos = 1 Then
                DgvExp.ClearSelection()
                'DgvExp.ClearSelection()
                'Dim r = Class1.rowindx
                'Dim c = Class1.colindx
                Dim r = rowind
                Dim c = colind
                Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c)
                'DgvImp.CurrentCell = Me.ro.Cells(0)
                'DgvImp.Rows(r).Selected = True
                'Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c - 1)
                'DgvImp.Rows(r).Cells(c - 1).Selected = True
                'DgvImp.SelectedRows(9).Selected = True
                updatevalue = 0
                Class1.formulaflag = 0
                Class1.FormulaIndexPos = 0
                'Class1.replaceflag = 0
                'Class1.roundFormulaIndex = 0

            End If
            If Class1.roundFormulaIndex = 1 Then
                DgvExp.ClearSelection()
                'DgvExp.ClearSelection()
                'Dim r = Class1.rowindx
                'Dim c = Class1.colindx
                Dim r = rowind
                Dim c = colind
                Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c)
                'DgvImp.CurrentCell = Me.ro.Cells(0)
                'DgvImp.Rows(r).Selected = True
                'Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c - 1)
                'DgvImp.Rows(r).Cells(c - 1).Selected = True
                'DgvImp.SelectedRows(9).Selected = True
                updatevalue = 0

                Class1.replaceflag = 0
                Class1.roundFormulaIndex = 0

            End If

            If Class1.IndexPos = 1 Then
                DgvExp.ClearSelection()
                'Dim r = Class1.rowindx
                'Dim c = Class1.colindx
                Dim r = rowind
                Dim c = colind

                If Class1.HscodeIndex = 1 Then

                    Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c)
                    Class1.HscodeIndex = 0
                Else
                    'DgvImp.CurrentCell = Me.ro.Cells(0)
                    'DgvImp.Rows(r).Selected = True
                    Me.DgvExp.CurrentCell = DgvExp.Rows(r).Cells(c)

                End If
                Class1.IndexPos = 0
                Class1.HsCodeCP = 0

                'Class1.code = 0
            End If



        Catch ex As Exception

        End Try




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.ExportSummaryBindingSource.Filter = "hsdesc Like '%" & TextBox2.Text & "%'"
    End Sub
    Dim HSforSummaryUVEx As Integer
    Dim CntforSummaryVuEx As Integer
    Private Sub DgvExp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellContentClick
        'Try
        With DgvExp
            Try


                For Each Cell As DataGridViewCell In DgvExp.SelectedCells

                    Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("HSDataGridViewTextBoxColumn").Value()
                    Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("CNTDataGridViewTextBoxColumn").Value()
                    'Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
                    'Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
                    'Dim datatable As New DataTable


                    'If tblUser.Rows.Count <> 0 Then
                    '    Return tblUser(0)
                    'Else
                    '    Return Nothing
                    'End If






                    Dim QtySum As ULong = 0
                    Dim PKRSum As ULong = 0
                    GetUser(CntforSummaryVuEx, HSforSummaryUVEx)
                    For i = 0 To tblUser.Rows.Count - 1
                        'MessageBox.Show(tblUser.Rows(i).Item(9))
                        'MessageBox.Show(tblUser.Rows(i).Item(10))
                        Class1.QtyArray(i) = tblUser.Rows(i).Item(7)
                        Class1.PKRArray(i) = tblUser.Rows(i).Item(8)





                        If Cell.Value.ToString() = "".ToString() Then
                            QtySum = Class1.QtyArray(i) + 0
                            PKRSum = Class1.PKRArray(i) + 0
                            'sumflag = 0

                        Else
                            QtySum = QtySum + Class1.QtyArray(i)
                            PKRSum = PKRSum + Class1.PKRArray(i)
                            'If Cell.Value.ToString = "" Then
                            '        SumValue = SumValue + 0
                            '    End If

                            'sumflag = 0
                        End If
                        Dim a As Integer = QtySum / tblUser.Rows.Count
                        Dim b As Integer = PKRSum / tblUser.Rows.Count
                        'Label13.Text = QtySum / tblUser.Rows.Count
                        'Label14.Text = PKRSum / tblUser.Rows.Count

                        Try
                            Label11.Text = b / a
                        Catch ex As Exception

                        End Try







                    Next


                    'Label13.Text = HSforSummaryUVEx
                    'Label14.Text = CntforSummaryVuEx

                    'Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
                    'Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()
                    'Dim yy = Class1.YY
                    'Dim mm = Class1.MM
                    'Dim constring As String = "Data Source=DESKTOP-AHDEUJI\SQLEXPRESS;Initial Catalog=TradeStatistics;User id = sa;password=data@123"
                    'Using con As New SqlConnection(constring)
                    '    Using cmd As New SqlCommand("SELECT SNO, QTY, PKR FROM ExportSummary WHERE (YY =18) AND (MM = 7) ", con)
                    '        cmd.CommandType = CommandType.Text
                    '        Using sda As New SqlDataAdapter(cmd)
                    '            Using dt As New DataTable()
                    '                sda.Fill(dt)
                    '                'dataGridView1.DataSource = dt
                    '            End Using
                    '        End Using
                    '    End Using
                    'End Using



                Next

            Catch ex As Exception

            End Try
            '    For Each Cell As DataGridViewCell In DgvExp.SelectedCells
            '        HSforSummaryUVEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
            '        CntforSummaryVuEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value



            '        Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
            '        Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()

            '    Next
            'Catch ex As Exception
        End With
        'End Try
    End Sub

    Private Sub DgvExp_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellEndEdit
        With DgvExp
            'Class1.rowindx = 0
            'Class1.colindx = 0

            Dim flg As Boolean
            flg = True
            If e.RowIndex <= .Rows.Count - 1 Then

                'If e.ColumnIndex = .Columns.IndexOf(.Columns("CNT")) Then
                If e.ColumnIndex = 6 Then

                    Dim country As String
                    Dim updatedcountry As String
                    Dim GetExpRowRecNo1 As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpCntry As String = .CurrentCell.FormattedValue
                    Dim CheckCNT As Integer = Me.CountryTableAdapter.CheckCNT(GetExpCntry)
                    'country = Me.ImportDataTableAdapter1.GetCountry(GetExpRowRecNo1)
                    'Dim oldcountry = Me.ImportDataTableAdapter.GetOldCOuntry(GetExpRowRecNo1)


                    Dim oldcountry = Me.ExportSummaryTableAdapter.GetOldCntForExpSum(GetExpRowRecNo1, Class1.YY, Class1.MM)

                    'updatedcountry = Me.ImportDataTableAdapter1.GetUpdatedCountry(GetExpCntry)
                    'updatedcountry = Me.ImportDataTableAdapter.GetUpdatedCountrySummary(GetExpCntry)

                    If CheckCNT > 0 Then

                        'Me.ImportDataTableAdapter1.UpdateCountryImportSummary(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)
                        Me.ExportSummaryTableAdapter.UpdateCountryExportSummary(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateCountrySummary(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo1)
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = GetExpCntry
                        Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        If CheckCNT < 1 Then
                            DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                            Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        End If
                    Else
                        '.CancelEdit()
                        MsgBox("The Entered CountryCode does not Exist")
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'DgvExp.Rows(e.RowIndex).Cells(4).Value = oldcountry
                        flg = False
                    End If

                End If

                If e.ColumnIndex = 3 Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpTT As String = .CurrentCell.Value

                    'Dim tradetype As Integer = Me.ImportDataTableAdapter.GetTradeType(GetExpRowRecNo)
                    Dim tradetype As Integer = Me.ExportSummaryTableAdapter.GetTradeTypeExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)


                    Dim CheckTT As Integer = Me.ExportDataTableAdapter.CheckTradeTypeExp(GetExpTT)
                    'Dim CheckTT As Integer = Me.ImportDataTableAdapter.CheckTradeTypeExpSummary(GetExpTT)

                    If CheckTT > 0 Then
                        If GetExpTT = 3 Or GetExpTT = 4 Then

                            'Me.ImportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportSummaryTableAdapter.UpdatetradeTypeExportSummary(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                            DgvExp.Rows(e.RowIndex).Cells(3).Value = GetExpTT
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Else
                            DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            .CancelEdit()
                        End If
                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    Else
                        .CancelEdit()
                        Dim hsid As Integer = Me.ExportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = hsid
                        MsgBox("The Entered Trade Type does not Exist in our database")
                        DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype
                        flg = False

                    End If
                End If


                If e.ColumnIndex = 7 Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpQty As Integer = .CurrentCell.Value
                    Me.ExportSummaryTableAdapter.UpdateQuantityExportSummary(GetExpQty, GetExpRowRecNo, Class1.YY, Class1.MM)
                    'Me.ImportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                    'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Try
                        Dim unitvalue As Integer = Me.ExportSummaryTableAdapter.GetOldQuantityExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                        'DgvExp.Rows(e.RowIndex).Cells(11).Value = Status
                        'DgvExp.Rows(e.RowIndex).Cells(9).Value = unitvalue




                        DgvExp.Rows(e.RowIndex).Cells(7).Value = GetExpQty
                        Dim unitval As Integer = Me.ExportSummaryTableAdapter.GetUnitValueExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)





                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        ''''''''refill and update Gridview
                        'Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
                        ''   Me.DgvImp.Refresh()



                        'DgvExp.Rows(e.RowIndex).Cells(14).ReadOnly = False
                        DgvExp.Rows(e.RowIndex).Cells(9).Value = unitval
                    Catch ex As Exception
                        DgvExp.Rows(e.RowIndex).Cells(9).Value = 0
                    End Try
                    Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                End If



                ''Me.ImportDataTableAdapter.UpdateUnsureRec(GetExpRowRecNo, GetExpRowRecNo, Class1.YY, Class1.MM)
                ''Me.ImportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                ''Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)

                ''Dim unitvalue As Integer = Me.ImportDataTableAdapter.UpdateUnitValue(GetExpRowRecNo)
                ''Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                ''DgvImp.Rows(e.RowIndex).Cells(10).Value = Status
                ''DgvImp.Rows(e.RowIndex).Cells(8).Value = unitvalue
                ''''''''''refill and update Gridview
                '''Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
                '''   Me.DgvImp.Refresh()
                ''Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ''    End If


                If e.ColumnIndex = 10 Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpHS As String = .CurrentCell.Value
                    Dim CheckHS As Integer = Me.HscodeTableAdapter.CheckHS(GetExpHS)
                    'Dim HS As String = Me.ImportDataTableAdapter.GetHsCode(GetExpHS)
                    'Dim hsdesc As String = Me.ImportDataTableAdapter.GetOldHsDesc(GetExpRowRecNo)
                    Dim hsid As Integer = Me.ExportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim oldUnitDesc As String = Me.ExportSummaryTableAdapter.GetOldHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim updatedUnitDesc As String = Me.ExportSummaryTableAdapter.GetUpdatedHSDesc(GetExpHS)

                    Dim oldUnit As String = Me.ExportSummaryTableAdapter.GetOldHsUnitExpSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim updatedUnit As String = Me.ExportSummaryTableAdapter.GetUpdatedHsUnitExportSummary(GetExpHS)

                    If CheckHS > 0 Then
                        Me.ExportSummaryTableAdapter.UpdateExportCountryHsCode(GetExpHS, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                        Me.ExportSummaryTableAdapter.UpdateUnitHsDescExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                        'Me.ImportDataTableAdapter.UpdateUnitHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = GetExpHS
                        DgvExp.Rows(e.RowIndex).Cells(12).Value = updatedUnitDesc
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                        DgvExp.Rows(e.RowIndex).Cells(11).Value = updatedUnit
                        'DgvExp.Rows(e.RowIndex).Cells(6).Value = updatedUnit
                        If CheckHS < 1 Then
                            .CancelEdit()
                            MsgBox("The Entered HS-Code does not Exist in our database")
                            'DgvExp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                            DgvExp.Rows(e.RowIndex).Cells(10).Value = Me.ExportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        End If

                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)

                    Else
                        .CancelEdit()
                        MsgBox("The Entered HS-Code does not Exist in our database")
                        'DgvExp.Rows(e.RowIndex).Cells(10).Value = hsid
                        'DgvExp.Rows(e.RowIndex).Cells(6).Value = oldUnit
                        'DgvExp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ExportSummaryTableAdapter.GetUpdatedStatusExportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'flg = False
                    End If
                End If


            End If
            '.CancelEdit()
        End With
    End Sub
    Dim sumflag As Integer = 0
    Dim countflag As Integer = 0
    Dim rowind As Integer = Class1.rowindx
    Dim colind As Integer = Class1.colindx
    Dim RowVal As Integer
    Dim i As Integer
    Dim cb As Integer
    Dim selectedCellCount As Integer
    Dim GetImpRowRecNo As Integer
    Dim updatevalue As Integer = 0
    Private Sub DgvExp_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DgvExp.CellValidating










        rowind = e.RowIndex
        colind = e.ColumnIndex

        'Save row n col index in table And on load make load
        'RemoveHandler DgvImp.CurrentCellDirtyStateChanged,
        '    AddressOf DgvImp_CurrentCellDirtyStateChanged
        'If TypeOf DgvImp.CurrentCell Is DataGridViewCheckBoxCell Then
        '    DgvImp.EndEdit()
        '    Dim Checked As Boolean = CType(DgvImp.CurrentCell.Value, Boolean)
        '    If Checked Then
        '        MessageBox.Show("You have checked")
        '    Else
        '        MessageBox.Show("You have un-checked")
        '    End If
        'End If
        'AddHandler DataGridView1.CurrentCellDirtyStateChanged,
        '    AddressOf DataGridView1SelectAll_CurrentCellDirtyStateChanged

        'Dim rowsCheckedList As List(Of DataGridViewRow) =
        'Dim ret As Boolean = Convert.ToBoolean(GetCheckedRows1(DgvImp, "UnsureRec"))

        If e.ColumnIndex = 3 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 7 Then
            If Me.DgvExp.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                    MsgBox("Please Enter Numeric Values Only")
                End If

            End If
        End If
        'If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
        '    sumflag = 1
        'End If

        'If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 9 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
        '    sumflag = 0

        'End If

        'If e.ColumnIndex = 12 Then
        '    'Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNo").Value()
        '    'Dim GetExpQty As Integer = .CurrentCell.Value
        '    If DgvImp.Rows(e.RowIndex).Cells(12).Value = True Then
        '        MessageBox.Show(“Yay”)
        '    End If
        'End If
        If e.ColumnIndex = 7 Or e.ColumnIndex = 9 Then
            sumflag = 1

        End If

        If e.ColumnIndex = 9 Or e.ColumnIndex = 7 Then
            countflag = 1

        End If

        If e.ColumnIndex = 7 Then
            'updatevalue = 1
            'Class1.formulaflag = 1
            'Class1.FormulaIndexPos = 1
            updatevalue = 1
            Class1.formulaflag = 1
            Class1.FormulaIndexPos = 1
            Class1.replaceflag = 1

        End If

        If e.ColumnIndex = 10 Then
            Class1.HsCodeCP = 1
            Class1.IndexPos = 1
            Class1.formulaflag = 0
            Class1.FormulaIndexPos = 0
            Class1.replaceflag = 0
        End If

        If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 8 Or e.ColumnIndex = 5 Or e.ColumnIndex = 12 Then
            'If e.ColumnIndex = 1 Or e.ColumnIndex = 0 Or e.ColumnIndex = 2 Or e.ColumnIndex = 4 Or e.ColumnIndex = 3 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Or e.ColumnIndex = 12 Or e.ColumnIndex = 5 Or e.ColumnIndex = 13 Then
            sumflag = 0
            Label4.Text = ""
            'Label11.Text = ""

        End If




    End Sub
    Dim tblUser = New DataTable
    Public Function GetUser(CNT As Integer, HS As Integer) As DataTable

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString

        Dim con = New SqlConnection(connectionString)
        'Using con = New SqlConnection("TradeEdit.My.MySettings.TradeStatisticsConnectionString")
        Using cmd = New SqlCommand("select * from ExportSummary where CNT= @cnt and HS=@hs", con)
            cmd.Parameters.AddWithValue("@cnt", CNT)
            cmd.Parameters.AddWithValue("@hs", HS)
            Dim da = New SqlDataAdapter(cmd)
            tblUser = New DataTable
            'Dim row As Integer = tblUser
            da.Fill(tblUser)
            Return tblUser
            'If tblUser.Rows.Count <> 0 Then
            '    Return tblUser(0)
            'Else
            '    Return Nothing
            'End If
        End Using
        'End Using
    End Function




    Private Sub DgvExp_SelectionChanged(sender As Object, e As EventArgs) Handles DgvExp.SelectionChanged

        Try


            For Each Cell As DataGridViewCell In DgvExp.SelectedCells
                Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(10).Value
                Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
                'Dim datatable As New DataTable


                'If tblUser.Rows.Count <> 0 Then
                '    Return tblUser(0)
                'Else
                '    Return Nothing
                'End If






                Dim QtySum As ULong = 0
                Dim PKRSum As ULong = 0
                GetUser(CntforSummaryVuEx, HSforSummaryUVEx)
                For i = 0 To tblUser.Rows.Count - 1
                    'MessageBox.Show(tblUser.Rows(i).Item(9))
                    'MessageBox.Show(tblUser.Rows(i).Item(10))
                    Class1.QtyArray(i) = tblUser.Rows(i).Item(7)
                    Class1.PKRArray(i) = tblUser.Rows(i).Item(8)





                    If Cell.Value.ToString() = "".ToString() Then
                        QtySum = Class1.QtyArray(i) + 0
                        PKRSum = Class1.PKRArray(i) + 0
                        'sumflag = 0

                    Else
                        QtySum = QtySum + Class1.QtyArray(i)
                        PKRSum = PKRSum + Class1.PKRArray(i)
                        'If Cell.Value.ToString = "" Then
                        '        SumValue = SumValue + 0
                        '    End If

                        'sumflag = 0
                    End If
                    Dim a As Integer = QtySum / tblUser.Rows.Count
                    Dim b As Integer = PKRSum / tblUser.Rows.Count
                    'Label13.Text = QtySum / tblUser.Rows.Count
                    'Label14.Text = PKRSum / tblUser.Rows.Count

                    Try
                        Label11.Text = b / a
                    Catch ex As Exception

                    End Try







                Next


                'Label13.Text = HSforSummaryUVEx
                'Label14.Text = CntforSummaryVuEx

                'Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
                'Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()
                'Dim yy = Class1.YY
                'Dim mm = Class1.MM
                'Dim constring As String = "Data Source=DESKTOP-AHDEUJI\SQLEXPRESS;Initial Catalog=TradeStatistics;User id = sa;password=data@123"
                'Using con As New SqlConnection(constring)
                '    Using cmd As New SqlCommand("SELECT SNO, QTY, PKR FROM ExportSummary WHERE (YY =18) AND (MM = 7) ", con)
                '        cmd.CommandType = CommandType.Text
                '        Using sda As New SqlDataAdapter(cmd)
                '            Using dt As New DataTable()
                '                sda.Fill(dt)
                '                'dataGridView1.DataSource = dt
                '            End Using
                '        End Using
                '    End Using
                'End Using



            Next

        Catch ex As Exception

        End Try
        If sumflag = 1 Then
            Dim SumValue As ULong = 0
            Dim ct As ULong = 0

            For Each Cell As DataGridViewCell In DgvExp.SelectedCells


                If Cell.Value.ToString() = "".ToString() Then
                    SumValue = SumValue + 0
                    ct = ct + 0
                    'sumflag = 0

                Else

                    Try


                        SumValue = SumValue + Cell.Value
                        If Cell.Value.ToString = "" Then
                            SumValue = SumValue + 0
                        End If
                    Catch ex As Exception

                    End Try
                    ct = ct + 1
                    'sumflag = 0
                End If
            Next

            Label4.Text = SumValue
            Label7.Text = SumValue / ct
            'Label9.Text = ct



            selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)

            'MessageBox.Show(Class1.ValueArray(i))
            'MessageBox.Show(Class1.RowNoArray(i))

            For i = 0 To selectedCellCount - 1
                'RowVal = DgvExp.SelectedCells(i).Value.ToString

                'RowVal = DgvImp.SelectedCells(i)..ToString
                'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                Class1.rowindx = DgvExp.CurrentRow.Index
                Class1.colindx = DgvExp.Columns("QTYDataGridViewTextBoxColumn").Index
                'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                Dim p11 = DgvExp.CurrentCell.RowIndex
                Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(0).Value
                Dim p1 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value






                'Dim p2 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(8).Value
                'Dim p1 = DgvExp.Rows(i).Cells(6).Value.ToString
                'GetImpRowRecNo = DgvImp.CurrentRow.Cells("ImpSNO").Value()
                'GetImpRowRecNo = DgvImp.SelectedRows(0).Cells("ImpSNO").Value
                'RowVal = DgvImp.CurrentRow.Cells("ImpQty").Value()
                'RowVal = DgvImp.SelectedRows(0).Cells("ImpVal").Value
                'GetImpRowRecNo = DgvImp.SelectedRows(0).Cells(0).Value

                'GetImpRowRecNo = Convert.ToInt32(DgvImp.Rows[2].Cells[0].Value.ToString())
                'DgvImp.SelectedCells(""
                'Class1.ValueArray(i) = p2
                Class1.RowNoArray(i) = p
                Class1.QtyArray(i) = p1

                cb = selectedCellCount - 1
                Class1.SelectedCellCount = cb
                'MessageBox.Show(Class1.ValueArray(i))
                'MessageBox.Show(Class1.RowNoArray(i))


            Next i
            Class1.formulaflag = 0
        End If

        If Class1.HsCodeCP = 1 Then
            selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)
            'sumflag = 0
            'Class1.replaceflag = 0
            'MessageBox.Show(Class1.ValueArray(i))
            'MessageBox.Show(Class1.RowNoArray(i))

            For i = 0 To selectedCellCount - 1
                'RowVal = DgvExp.SelectedCells(i).Value.ToString

                'RowVal = DgvImp.SelectedCells(i)..ToString
                'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                Class1.rowindx = DgvExp.CurrentRow.Index
                Class1.colindx = DgvExp.Columns("HSDataGridViewTextBoxColumn").Index
                'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                Dim p11 = DgvExp.CurrentCell.RowIndex
                Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(0).Value
                Dim p1 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(10).Value
                'Dim p2 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(7).Value
                'Dim p1 = DgvImp.Rows(i).Cells(6).Value.ToString
                'GetImpRowRecNo = DgvImp.CurrentRow.Cells("ImpSNO").Value()
                'GetImpRowRecNo = DgvImp.SelectedRows(0).Cells("ImpSNO").Value
                'RowVal = DgvImp.CurrentRow.Cells("ImpQty").Value()
                'RowVal = DgvImp.SelectedRows(0).Cells("ImpVal").Value
                'GetImpRowRecNo = DgvImp.SelectedRows(0).Cells(0).Value

                'GetImpRowRecNo = Convert.ToInt32(DgvImp.Rows[2].Cells[0].Value.ToString())
                'DgvImp.SelectedCells(""
                'Class1.ValueArray(i) = p2
                Class1.RowNoArray(i) = p
                Class1.QtyArray(i) = p1

                cb = selectedCellCount - 1
                Class1.SelectedCellCount = cb
                'MessageBox.Show(Class1.ValueArray(i))
                'MessageBox.Show(Class1.RowNoArray(i))


            Next i


            Class1.HsCodeCP = 0

        End If

        If countflag = 1 Then

            Dim ct As ULong = 0

            For Each Cell As DataGridViewCell In DgvExp.SelectedCells
                If Cell.Value.ToString() = "".ToString() Then
                    'MessageBox.Show(ct)
                    ct = ct + 0
                    'sumflag = 0

                Else
                    'MessageBox.Show(ct)
                    ct = ct + 1
                    'sumflag = 0
                End If
            Next


            Label9.Text = ct
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Replace_Click(sender As Object, e As EventArgs) Handles Replace.Click
        With DgvExp
            'Replace Button
            Try
                Class1.tT = 3
                Class1.ExportSummaryFlag = 1
                selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)
                If selectedCellCount < 2 Then
                    Exit Sub
                End If

                DgvExp.Rows(rowind).Cells(colind).Selected = True

                If Class1.HsCodeCP = 1 Then
                    'Class1.tT = 1
                    'Me.Close()
                    SummaryCalculations.Show()
                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Dispose()
                End If
                If (colind = 7) Then


                    'DgvImp.SelectedRows(9).Selected = True
                    'If Class1.formulaflag = 1 Then
                    '    DgvImp.ClearSelection()
                    '    'Dim r = Class1.rowindx
                    '    'Dim c = Class1.colindx
                    '    Dim r = rowind
                    '    Dim c = colind

                    '    'DgvImp.CurrentCell = Me.ro.Cells(0)
                    '    'DgvImp.Rows(r).Selected = True
                    '    Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c - 1)
                    'DgvImp.Rows(r).Cells(c - 1).Selected = True



                    If updatevalue = 1 Then


                        'Class1.tT = 1
                        'Class1.RecNo = GetExpRowRecNo

                        Class1.formulaflag = 1
                        'Me.Close()
                        SummaryCalculations.Show()

                        'SummaryCalculations.Show()
                        'Dim obj As EditExportSummary = New EditExportSummary()
                        'obj.Dispose()
                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If

                    If Class1.roundFormulaIndex = 1 Then

                        'Class1.tT = 1
                        'Class1.RecNo = GetExpRowRecNo
                        Class1.roundFormulaIndex = 1
                        'Me.Close()
                        SummaryCalculations.Show()
                        'Dim obj As EditExportSummary = New EditExportSummary()
                        'obj.Dispose()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If

                End If
            Catch ex As Exception

            End Try

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With DgvExp
            'Replace Button
            Try

                Class1.formulaflag = 0
                Class1.FormulaIndexPos = 0
                Class1.roundFormulaIndex = 1
                selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)
                If selectedCellCount < 2 Then
                    Exit Sub
                End If

                If (colind = 7) Then
                    'If updatevalue = 1 Then
                    If Class1.replaceflag = 1 Then

                        Class1.tT = 3
                        'Class1.RecNo = GetExpRowRecNo
                        Class1.replaceflag = 1
                        Me.Close()
                        SummaryCalculations.Show()


                        'SummaryCalculations.Show()
                        'Dim obj As EditExportSummary = New EditExportSummary()
                        'obj.Dispose()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If
                End If
            Catch ex As Exception

            End Try


        End With
    End Sub

    Private Sub DgvExp_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellContentDoubleClick
        With DgvExp
            'MessageBox.Show("double click")

            If e.ColumnIndex = 7 Then
                Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                Class1.rowindx = e.RowIndex
                Class1.colindx = e.ColumnIndex
                Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                Dim val As Integer = .CurrentRow.Cells("ExpVal").Value()
                Class1.value = val
                Class1.tT = 3
                Class1.replaceflag = 0
                Class1.formulaflag = 0
                Class1.IndexPos = 0
                Class1.RecNo = GetExpRowRecNo
                'RoundFormula.Show()
                Me.Close()
                SummaryCalculations.Show()
                'Dim obj As EditExportSummary = New EditExportSummary()
                'obj.Dispose()
            End If

        End With
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        SupervisorDashboard.Show()
        Me.Close() ''Added by me
    End Sub

    Private Sub EditExportSummary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SupervisorDashboard.Show()
    End Sub

    Private Sub DgvExp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellClick

        'Try

        Try


            For Each Cell As DataGridViewCell In DgvExp.SelectedCells
                Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(10).Value
                Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
                'Dim datatable As New DataTable


                'If tblUser.Rows.Count <> 0 Then
                '    Return tblUser(0)
                'Else
                '    Return Nothing
                'End If






                Dim QtySum As ULong = 0
                Dim PKRSum As ULong = 0
                GetUser(CntforSummaryVuEx, HSforSummaryUVEx)
                For i = 0 To tblUser.Rows.Count - 1
                    'MessageBox.Show(tblUser.Rows(i).Item(9))
                    'MessageBox.Show(tblUser.Rows(i).Item(10))
                    Class1.QtyArray(i) = tblUser.Rows(i).Item(7)
                    Class1.PKRArray(i) = tblUser.Rows(i).Item(8)





                    If Cell.Value.ToString() = "".ToString() Then
                        QtySum = Class1.QtyArray(i) + 0
                        PKRSum = Class1.PKRArray(i) + 0
                        'sumflag = 0

                    Else
                        QtySum = QtySum + Class1.QtyArray(i)
                        PKRSum = PKRSum + Class1.PKRArray(i)
                        'If Cell.Value.ToString = "" Then
                        '        SumValue = SumValue + 0
                        '    End If

                        'sumflag = 0
                    End If
                    Dim a As Integer = QtySum / tblUser.Rows.Count
                    Dim b As Integer = PKRSum / tblUser.Rows.Count
                    'Label13.Text = QtySum / tblUser.Rows.Count
                    'Label14.Text = PKRSum / tblUser.Rows.Count

                    Try
                        Label11.Text = b / a
                    Catch ex As Exception

                    End Try







                Next


                'Label13.Text = HSforSummaryUVEx
                'Label14.Text = CntforSummaryVuEx

                'Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
                'Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()
                'Dim yy = Class1.YY
                'Dim mm = Class1.MM
                'Dim constring As String = "Data Source=DESKTOP-AHDEUJI\SQLEXPRESS;Initial Catalog=TradeStatistics;User id = sa;password=data@123"
                'Using con As New SqlConnection(constring)
                '    Using cmd As New SqlCommand("SELECT SNO, QTY, PKR FROM ExportSummary WHERE (YY =18) AND (MM = 7) ", con)
                '        cmd.CommandType = CommandType.Text
                '        Using sda As New SqlDataAdapter(cmd)
                '            Using dt As New DataTable()
                '                sda.Fill(dt)
                '                'dataGridView1.DataSource = dt
                '            End Using
                '        End Using
                '    End Using
                'End Using



            Next

        Catch ex As Exception

        End Try
        '    For Each Cell As DataGridViewCell In DgvExp.SelectedCells
        '        Dim HSforSummaryUVEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
        '        Dim CntforSummaryVuEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value

        '        Label13.Text = HSforSummaryUVEx
        '        Label14.Text = CntforSummaryVuEx

        '        Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
        '        Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()

        '    Next
        'Catch ex As Exception

        'End Try
    End Sub
End Class