Imports System.Configuration
Imports System.Data.SqlClient

Public Class EditImportSummary
    Private Sub EditImportSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            'If Class1.tT = 3 Then
            '    Exit Sub
            'End If
            'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ImportSummary' table. You can move, or remove it, as needed.
            'Dim i As Integer = Me.ImportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ImportSummary, Class1.YY, Class1.MM)
            'Dim i As Integer = Me.ImportSummaryTableAdapter.FillBy222(Me.TradeStatisticsDataSet.ImportSummary, Class1.YY, Class1.MM)
            Dim i As Integer = Me.ImportSummaryTableAdapter.FillBy222(Me.TradeStatisticsDataSet.ImportSummary, Class1.YY, Class1.MM)
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
    Dim rowind As Integer = Class1.rowindx
    Dim colind As Integer = Class1.colindx
    Dim updatevalue As Integer = 0
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Try
            'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%'"
            Me.ImportSummaryBindingSource.Filter = "HS Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%' "
            'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%'"
        Catch abc As Exception
            'MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            'Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"

            'Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
            Me.ImportSummaryBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%' and HS like '%" & TextBoxSearch.Text & "%'"
        Catch abc As Exception
            'MessageBox.Show("Sorry! Searched Country does not Exist.")
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Me.ImportSummaryBindingSource.Filter = "hsdesc Like '%" & TextBox2.Text & "%'"
        Catch abc As Exception
            MessageBox.Show("Sorry! Searched Description does not Exist.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxSearch.Text = ""
    End Sub



    'Public Function undone(sno As Integer, month As Integer, year As Integer, columnid As Integer, oldvalue As Integer, newvalue As Integer, tradetype As Integer) As DataTable


    '    Me.ImportSummaryTableAdapter.InsertinUndone(sno, month, year, columnid, oldvalue, newvalue, tradetype)

    'End Function
    'Public Function insertintoundone(row As Integer, month As Integer, year As Integer, columnindex As Integer, newvalue As Integer, oldvalue As Integer, tradetype As Integer)
    '    Dim checkSno As Integer = Me.ImportSummaryTableAdapter.CheckSnoNumberAvailability(row, Class1.YY, Class1.MM, 1)
    '    If (checkSno < 0) Then
    '        undone(row, Class1.MM, Class1.YY, columnindex, oldvalue, newvalue, 1)

    '    End If

    '    If (checkSno >= 0) Then
    '        ImportSummaryTableAdapter.undone(newvalue, oldvalue, 1, Class1.MM, Class1.YY, row)

    '    End If
    'End Function

    Public Function GetUser(CNT As Integer, HS As Integer) As DataTable

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString

        Dim con = New SqlConnection(connectionString)
        'Using con = New SqlConnection("TradeEdit.My.MySettings.TradeStatisticsConnectionString")
        Using cmd = New SqlCommand("select * from ImportSummary where CNT= @cnt and HS=@hs", con)
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
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click



        'Me.Hide()
        SupervisorDashboard.Show()
        Me.Close() ''Added by me
    End Sub
    Dim HSforSummaryUVEx As Integer
    Dim CntforSummaryVuEx As Integer
    Dim tblUser = New DataTable
    Private Sub DgvExp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellContentClick
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
                        Class1.QtyArray(i) = tblUser.Rows(i).Item(7) 'qty
                        Class1.PKRArray(i) = tblUser.Rows(i).Item(8)  'pkr





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
    End Sub

    Private Sub DgvExp_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellEndEdit
        With DgvExp
            'Class1.rowindx = 0
            'Class1.colindx = 0

            Dim flg As Boolean
            flg = True
            If e.RowIndex <= .Rows.Count - 1 Then

                'If e.ColumnIndex = .Columns.IndexOf(.Columns("CNT")) Then
                If e.ColumnIndex = 6 Then        'country code

                    Dim country As String
                    Dim updatedcountry As String
                    Dim GetExpRowRecNo1 As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpCntry As String = .CurrentCell.FormattedValue
                    Dim CheckCNT As Integer = Me.CountryTableAdapter.CheckCNT(GetExpCntry)
                    'country = Me.ImportDataTableAdapter1.GetCountry(GetExpRowRecNo1)
                    'Dim oldcountry = Me.ImportDataTableAdapter.GetOldCOuntry(GetExpRowRecNo1)


                    Dim oldcountry = Me.ImportDataTableAdapter1.ImportSummaryGetOldCountry(GetExpRowRecNo1, Class1.YY, Class1.MM)

                    updatedcountry = Me.ImportDataTableAdapter1.GetUpdatedCountry(GetExpCntry)
                    'updatedcountry = Me.ImportDataTableAdapter.GetUpdatedCountrySummary(GetExpCntry)

                    If CheckCNT > 0 Then

                        'Me.ImportDataTableAdapter1.UpdateCountryImportSummary(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter1.UpdateCountryImportSummary(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)

                        'start here


                        'insertintoundone(GetExpRowRecNo1, Class1.MM, Class1.YY, e.ColumnIndex, "", GetExpCntry, Class1.TradeType)

                        'End here

                        'Dim checkSno As Integer = Me.ImportSummaryTableAdapter.CheckSnoNumberAvailability(GetExpRowRecNo1, Class1.YY, Class1.MM, 1)
                        'If (checkSno < 0) Then
                        '    undone(GetExpRowRecNo1, Class1.MM, Class1.YY, e.ColumnIndex, "", GetExpCntry, Class1.TradeType)

                        'End If

                        'If (checkSno >= 0) Then
                        '    ImportSummaryTableAdapter.undone("", "", 1, Class1.MM, Class1.YY, GetExpRowRecNo1)

                        'End If

                        'fds
                        'Me.ImportDataTableAdapter.UpdateCountrySummary(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo1)

                        DgvExp.Rows(e.RowIndex).Cells(6).Value = GetExpCntry    'country code
                            Me.ImportSummaryTableAdapter.UpdatedUpdatedImportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        'cell(5)=Updated column(Y) 
                        If CheckCNT < 1 Then
                                DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry   'country code

                                Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                            End If
                        Else
                            '.CancelEdit()
                            MsgBox("The Entered CountryCode does not Exist")
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry    'country code
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)

                        'reverting start here
                        Dim tradetype As Integer = Me.ImportDataTableAdapter1.GetTradeTypeImportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype        'trade type

                        'revert back to old values
                        Dim hsid As Integer = Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = hsid

                        Dim unitvalue As Integer = Me.ImportSummaryTableAdapter.GetOldQuantity(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(7).Value = unitvalue


                        'DgvExp.Rows(e.RowIndex).Cells(6).Value = unitvalue



                        'End here



                        'DgvExp.Rows(e.RowIndex).Cells(4).Value = oldcountry
                        flg = False
                    End If

                End If

                If e.ColumnIndex = 3 Then       'trade type
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpTT As String = .CurrentCell.Value

                    'Dim tradetype As Integer = Me.ImportDataTableAdapter.GetTradeType(GetExpRowRecNo)
                    Dim tradetype As Integer = Me.ImportDataTableAdapter1.GetTradeTypeImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)


                    Dim CheckTT As Integer = Me.ImportDataTableAdapter1.CheckTradeTypeExp(GetExpTT)
                    'Dim CheckTT As Integer = Me.ImportDataTableAdapter.CheckTradeTypeExpSummary(GetExpTT)

                    If CheckTT > 0 Then
                        If GetExpTT = 1 Or GetExpTT = 2 Then

                            'Me.ImportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter1.UpdateTradeTypeImportSummary(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportSummaryTableAdapter.UpdatedUpdatedImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                            DgvExp.Rows(e.RowIndex).Cells(3).Value = GetExpTT       'trade type
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            'cell(5)=updated (Y)
                        Else
                            DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype     'trade type
                            '.CancelEdit()
                        End If
                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    Else
                        .CancelEdit()
                        MsgBox("The Entered Trade Type does not Exist in our database")
                        DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype        'trade type

                        'revert back to old values
                        Dim hsid As Integer = Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = hsid

                        Dim unitvalue As Integer = Me.ImportSummaryTableAdapter.GetOldQuantity(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(7).Value = unitvalue

                        Dim oldcountry = Me.ImportDataTableAdapter1.ImportSummaryGetOldCountry(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry
                        'DgvExp.Rows(e.RowIndex).Cells(6).Value = unitvalue




                        'End reverting

                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        flg = False

                    End If
                End If


                If e.ColumnIndex = 7 Then         'quantity
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpQty As Integer = .CurrentCell.Value
                    Me.ImportDataTableAdapter1.UpdateQuantityImportSummary(GetExpQty, GetExpRowRecNo, Class1.YY, Class1.MM)
                    'Me.ImportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                    'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)

                    Dim unitvalue As Integer = Me.ImportSummaryTableAdapter.GetOldQuantity(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Me.ImportSummaryTableAdapter.UpdatedUpdatedImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                    'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                    'DgvExp.Rows(e.RowIndex).Cells(11).Value = Status
                    'DgvExp.Rows(e.RowIndex).Cells(9).Value = unitvalue
                    DgvExp.Rows(e.RowIndex).Cells(7).Value = GetExpQty              'quantity
                    DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                    'cell(5)=updated

                    Try


                        Dim unitval As Integer = Me.ImportSummaryTableAdapter.GetUnitValueImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        ''''''''refill and update Gridview
                        'Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
                        ''   Me.DgvImp.Refresh()
                        DgvExp.Rows(e.RowIndex).Cells(9).Value = unitval            'unit value
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


                If e.ColumnIndex = 10 Then       'hs code
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
                    Dim GetExpHS As String = .CurrentCell.Value
                    Dim CheckHS As Integer = Me.HscodeTableAdapter.CheckHS(GetExpHS)
                    'Dim HS As String = Me.ImportDataTableAdapter.GetHsCode(GetExpHS)
                    'Dim hsdesc As String = Me.ImportDataTableAdapter.GetOldHsDesc(GetExpRowRecNo)
                    Dim hsid As Integer = Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                    Dim hsi As String = Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim oldUnitDesc As String = Me.ImportSummaryTableAdapter.GetOldHsDesc(GetExpRowRecNo)
                    Dim updatedUnitDesc As String = Me.ImportSummaryTableAdapter.GetUpdatedHsDesc(GetExpHS)
                    Dim updatedUnit As String = Me.ImportSummaryTableAdapter.GetUpdatedUnitHsImportSummary(GetExpHS)
                    If CheckHS > 0 Then
                        Me.ImportSummaryTableAdapter.UpdateImportSummaryHsCode(GetExpHS, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportSummaryTableAdapter.UpdatedUpdatedImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUnitHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = GetExpHS              'hs code
                        DgvExp.Rows(e.RowIndex).Cells(12).Value = updatedUnitDesc      ' hs desc
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        ' updated column(y)
                        DgvExp.Rows(e.RowIndex).Cells(11).Value = updatedUnit         'unit(kg,dozen etc)
                        'DgvExp.Rows(e.RowIndex).Cells(12).Value = HS
                        'DgvExp.Rows(e.RowIndex).Cells(6).Value = updatedUnit
                        If CheckHS < 1 Then
                            .CancelEdit()
                            MsgBox("The Entered HS-Code does not Exist in our database")
                            'DgvExp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                            DgvExp.Rows(e.RowIndex).Cells(10).Value = Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            'cell(7)=hs code
                            Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                            'reverting start here
                            Dim tradetype As Integer = Me.ImportDataTableAdapter1.GetTradeTypeImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                            DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype        'trade type

                            'revert back to old values


                            Dim unitvalue As Integer = Me.ImportSummaryTableAdapter.GetOldQuantity(GetExpRowRecNo, Class1.YY, Class1.MM)
                            DgvExp.Rows(e.RowIndex).Cells(7).Value = unitvalue


                            'DgvExp.Rows(e.RowIndex).Cells(6).Value = unitvalue

                            Dim oldcountry = Me.ImportDataTableAdapter1.ImportSummaryGetOldCountry(GetExpRowRecNo, Class1.YY, Class1.MM)
                            DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry


                            Dim oldhsdescription = Me.ImportSummaryTableAdapter.GetoldHSDescription(hsi)
                            Dim oldhsUnitt = Me.ImportSummaryTableAdapter.GetOldHsUnitForImportSummary(hsi)
                            DgvExp.Rows(e.RowIndex).Cells(12).Value = oldhsdescription
                            DgvExp.Rows(e.RowIndex).Cells(11).Value = oldhsUnitt

                            Dim unitval As Integer = Me.ImportSummaryTableAdapter.GetUnitValueImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                            DgvExp.Rows(e.RowIndex).Cells(9).Value = unitval
                            'End here



                        End If

                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)

                    Else
                        .CancelEdit()
                        MsgBox("The Entered HS-Code does not Exist in our database")
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        'cell(7)=hs code
                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = Me.ImportSummaryTableAdapter.GetUpdatedStatusImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                        'reverting start here
                        Dim tradetype As Integer = Me.ImportDataTableAdapter1.GetTradeTypeImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(3).Value = tradetype        'trade type

                        'revert back to old values

                        Dim unitvalue As Integer = Me.ImportSummaryTableAdapter.GetOldQuantity(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(7).Value = UnitValue


                        'DgvExp.Rows(e.RowIndex).Cells(6).Value = unitvalue
                        Dim oldcountry = Me.ImportDataTableAdapter1.ImportSummaryGetOldCountry(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = oldcountry

                        'Me.ImportSummaryTableAdapter.GetOldHsIDImportSummary(GetExpRowRecNo)
                        Dim oldhsdescription = Me.ImportSummaryTableAdapter.GetoldHSDescription(hsi)
                        Dim oldhsUnitt = Me.ImportSummaryTableAdapter.GetOldHsUnitForImportSummary(hsi)
                        DgvExp.Rows(e.RowIndex).Cells(12).Value = oldhsdescription
                        DgvExp.Rows(e.RowIndex).Cells(11).Value = oldhsUnitt

                        Dim unitval As Integer = Me.ImportSummaryTableAdapter.GetUnitValueImportSummary(GetExpRowRecNo, Class1.YY, Class1.MM)

                        DgvExp.Rows(e.RowIndex).Cells(9).Value = unitval
                        'End here
                    End If
                End If


            End If
            '.CancelEdit()
        End With
    End Sub
    Dim sumflag As Integer = 0
    Dim countflag As Integer = 0
    Private Sub DgvExp_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DgvExp.CellValidating

        rowind = e.RowIndex
        colind = e.ColumnIndex
        If e.ColumnIndex = 3 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 7 Then  ' 3=tt, 6=cnt, 7=hs code, 9=qty
            If Me.DgvExp.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                    MsgBox("Please Enter Numeric Values Only")
                End If

            End If
        End If


        If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then           'qty
            sumflag = 1

        End If

        If e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then         '9=qty, 7=hs code
            countflag = 1

        End If

        If e.ColumnIndex = 7 Then            'qty
            'updatevalue = 1
            'Class1.formulaflag = 1
            'Class1.FormulaIndexPos = 1
            updatevalue = 1
            Class1.formulaflag = 1
            Class1.FormulaIndexPos = 1
            Class1.replaceflag = 1

        End If

        If e.ColumnIndex = 10 Then          'hs code
            Class1.HsCodeCP = 1
            Class1.IndexPos = 1
            Class1.formulaflag = 0
            Class1.FormulaIndexPos = 0
            Class1.replaceflag = 0
        End If

        If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 10 Or e.ColumnIndex = 5 Or e.ColumnIndex = 12 Then
            sumflag = 0
            Label4.Text = ""
            'Label11.Text = ""
            '0=sno,   1=yy,    2=mm,    3=tt,    4=rt,      6=country,        7=hs code,      10=pkr ,      12=dollar,    5=updated(Y),      13=sdr
        End If
    End Sub

    Private Sub DgvExp_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvExp.CellFormatting
        'If (e.ColumnIndex = 10) Then
        '    If (Me.DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "Y") Then
        '        e.CellStyle.ForeColor = Color.Black
        '        e.CellStyle.BackColor = Color.Red 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Yellow
        '    ElseIf (Me.DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "N") Then
        '        e.CellStyle.ForeColor = Color.Black
        '        e.CellStyle.BackColor = Color.White 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Red
        '    End If
        '    ' Next
        'End If
    End Sub
    Dim RowVal As Integer
    Dim cb As Integer
    Private Sub DgvExp_SelectionChanged(sender As Object, e As EventArgs) Handles DgvExp.SelectionChanged
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
                'recently commented code above

                'RowVal = DgvImp.SelectedCells(i)..ToString
                'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                Class1.rowindx = DgvExp.CurrentRow.Index
                Class1.colindx = DgvExp.Columns("QTYDataGridViewTextBoxColumn").Index
                'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                Dim p11 = DgvExp.CurrentCell.RowIndex
                Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(0).Value      'sno
                Dim p1 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value     'qty
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
                Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(0).Value     'sno
                Dim p1 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(10).Value     'hs code
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
            sumflag = 0
        End If
    End Sub
    Dim selectedCellCount As Integer
    Private Sub Replace_Click(sender As Object, e As EventArgs) Handles Replace.Click
        With DgvExp
            'Replace Button
            Try
                Class1.tT = 1
                Class1.ImportSummaryFlag = 1
                selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)
                If selectedCellCount < 2 Then
                    Exit Sub
                End If

                DgvExp.Rows(rowind).Cells(colind).Selected = True

                If Class1.HsCodeCP = 1 Then
                    'Class1.tT = 1

                    'Me.Close()
                    SummaryCalculations.Show()
                    'Dim obj As EditImportSummary = New EditImportSummary()
                    'obj.Close()


                End If
                If (colind = 7) Then              'qty


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

                        'Class1.formulaflag = 1
                        'Me.Close()
                        'SummaryCalculations.Show()
                        'Me.Close()

                        SummaryCalculations.Show()
                        'Dim obj As EditImportSummary = New EditImportSummary()
                        'obj.Close()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If

                    If Class1.roundFormulaIndex = 1 Then

                        'Class1.tT = 1
                        'Class1.RecNo = GetExpRowRecNo
                        Class1.roundFormulaIndex = 1
                        'Me.Close()
                        'SummaryCalculations.Show()
                        'Me.Close()
                        SummaryCalculations.Show()
                        'Dim obj As EditImportSummary = New EditImportSummary()
                        'obj.Close()

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

            'If e.ColumnIndex = 7 Then
            '    Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
            '    Class1.rowindx = e.RowIndex
            '    Class1.colindx = e.ColumnIndex
            '    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("SNODataGridViewTextBoxColumn").Value()
            '    Dim val As Integer = .CurrentRow.Cells("QTYDataGridViewTextBoxColumnl").Value()
            '    Class1.value = val
            '    Class1.tT = 1
            '    Class1.replaceflag = 0
            '    Class1.formulaflag = 0
            '    Class1.IndexPos = 0
            '    Class1.RecNo = GetExpRowRecNo
            '    RoundFormula.Show()
            '    Me.Close()

            'End If

        End With
    End Sub

    Private Sub EditImportSummary_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SupervisorDashboard.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class