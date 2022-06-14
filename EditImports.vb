Imports System.Configuration
Imports System.Data.SqlClient

Public Class EditImports

    Dim rowind As Integer = Class1.rowindx
    Dim colind As Integer = Class1.colindx
    Dim tblUser = New DataTable



    Public Function GetUser(CNT As Integer, HS As Integer) As DataTable

        Class1.ao = 0
        Class1.bo = 0
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString
        Dim mon As Integer = Me.ImportDataTableAdapter.MonthForUnitValueImport()
        Dim year As Integer = Me.ImportDataTableAdapter.YearForUnitValueImport()
        Dim con = New SqlConnection(connectionString)
        'Using con = New SqlConnection("TradeEdit.My.MySettings.TradeStatisticsConnectionString")
        Using cmd = New SqlCommand("select * from ImportSummary where CNT= @cnt and HS=@hs and YY=@yy and MM=@mm", con)
            cmd.Parameters.AddWithValue("@cnt", CNT)
            cmd.Parameters.AddWithValue("@hs", HS)
            Dim Tyear As Integer = year.ToString.Substring(2, 2)
            cmd.Parameters.AddWithValue("@yy", Tyear)
            cmd.Parameters.AddWithValue("@mm", mon)
            Dim da = New SqlDataAdapter(cmd)
            tblUser = New DataTable
            'Dim tblUser As DataTable

            'Dim row As Integer = tblUser
            da.Fill(tblUser)
            If tblUser Is Nothing Then
                'MessageBox.Show("no data")
            End If
            Return tblUser
            con.Close()
            'If tblUser.Rows.Count <> 0 Then
            '    Return tblUser(0)
            'Else
            '    Return Nothing
            'End If
        End Using
        'End Using
    End Function
    Private Sub EditImports_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'If Class1.RoundforFlag = 1 Then
        '        Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
        '    End If

        'If Class1.RoundforFlag = 1 Then
        '        Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
        '    End If
        Lbl_UserName.Text = Class1.U_Name

        'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        'Class1.previousMonth = Month(previousDate)
        'Class1.preYear = Year(previousDate)
        'Clas s1.previousYear = Class1.preYear.ToString()
        'Class1.previousYear = Class1.previousYear.Substring(2, 2)


        Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)
        LblValImp.Text = DgvImp.Rows.Count
        Dim Month As String = Class1.MonthName(Class1.MM)
        Me.lblMonthYear.Text = "    " & Month & " 20" & Class1.YY

        DgvImp.Columns(8).DefaultCellStyle.Format = "#,###"
        DgvImp.Columns(9).DefaultCellStyle.Format = "#,###"
        'Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
        'Me.DgvImp.Rows[0].IsSelected= True

        DgvImp.ClearSelection()
        DgvImp.Rows(rowind).Cells(colind).Selected = True
        If Class1.lastSavedIndexflag = 1 Then
            DgvImp.ClearSelection()
            'Dim r = Class1.rowindx
            'Dim c = Class1.colindx
            Dim r = rowind
            Dim c = 0

            'DgvImp.CurrentCell = Me.ro.Cells(0)
            'DgvImp.Rows(r).Selected = True
            Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c)
            'DgvImp.Rows(r).Cells(c - 1).Selected = True
            'DgvImp.SelectedRows(9).Selected = True
            'updatevalue = 0
            Class1.lastSavedIndexflag = 0
            'Class1.FormulaIndexPos = 0
        End If
        If Class1.FormulaIndexPos = 1 Then
            DgvImp.ClearSelection()
            'DgvImp.ClearSelection()
            'Dim r = Class1.rowindx
            'Dim c = Class1.colindx
            Dim r = rowind
            Dim c = colind
            Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c)
            'DgvImp.CurrentCell = Me.ro.Cells(0)
            'DgvImp.Rows(r).Selected = True
            'Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c - 1)
            'DgvImp.Rows(r).Cells(c - 1).Selected = True
            'DgvImp.SelectedRows(9).Selected = True
            updatevalue = 0
            Class1.formulaflag = 0
            Class1.FormulaIndexPos = 0
            'Class1.replaceflag = 0
            'Class1.roundFormulaIndex = 0

        End If
        If Class1.roundFormulaIndex = 1 Then
            DgvImp.ClearSelection()
            'DgvImp.ClearSelection()
            'Dim r = Class1.rowindx
            'Dim c = Class1.colindx
            Dim r = rowind
            Dim c = colind
            Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c)
            'DgvImp.CurrentCell = Me.ro.Cells(0)
            'DgvImp.Rows(r).Selected = True
            'Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c - 1)
            'DgvImp.Rows(r).Cells(c - 1).Selected = True
            'DgvImp.SelectedRows(9).Selected = True
            updatevalue = 0

            Class1.replaceflag = 0
            Class1.roundFormulaIndex = 0

        End If

        If Class1.IndexPos = 1 Then
            DgvImp.ClearSelection()
            'Dim r = Class1.rowindx
            'Dim c = Class1.colindx
            Dim r = rowind
            Dim c = colind
            'Dim r = Class1.Hsrowindx
            'Dim c = Class1.Hscolindx
            If Class1.HscodeIndex = 1 Then

                Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c)
                Class1.HscodeIndex = 0
            Else
                'DgvImp.CurrentCell = Me.ro.Cells(0)
                'DgvImp.Rows(r).Selected = True
                Me.DgvImp.CurrentCell = DgvImp.Rows(r).Cells(c)

            End If

            'DgvImp.Rows(r).Cells(c - 1).Selected = True
            'DgvImp.SelectedRows(9).Selected = True
            'updatevalue = 0
            Class1.IndexPos = 0
            Class1.HsCodeCP = 0

            'Class1.code = 0
        End If
        'To color unmatched Countries and HS codes, but the time to load will be a bit increased. Decide to use or not.
        'With DgvImp
        '    Dim Cnt As Integer
        '    Dim Hs As Integer
        '    Dim CountCNT As Integer
        '    Dim CountHS As Integer
        '    For i As Integer = 0 To .Rows.Count - 1
        '        Cnt = .CurrentRow.Cells("ExpCNT").Value.ToString()
        '        Hs = .CurrentRow.Cells("ExpHs").Value.ToString()
        '        CountCNT = Me.CountryTableAdapter.CheckCNT(Cnt)
        '        CountHS = Me.HscodeTableAdapter.CheckHS(Hs)
        '        If CountCNT = 0 Then
        '            .CurrentRow.Cells("ExpCNT").Style.BackColor = Color.Red
        '            .CurrentRow.Cells("ExpCNT").Style.ForeColor = Color.White
        '        End If
        '        If CountHS = 0 Then
        '            .CurrentRow.Cells("ExpHs").Style.BackColor = Color.Red
        '            .CurrentRow.Cells("ExpHs").Style.ForeColor = Color.White
        '        End If
        '    Next
        'End With
        For i = 0 To 11


            Dim dc As DataGridViewColumn = DgvImp.Columns(i)
            'dc.HeaderCell.Style.BackColor = Color.FromArgb(196, 196, 196)

            'dc.HeaderCell.Style.ForeColor = Color.FromArgb(0, 0, 0)
            dc.HeaderCell.Style.Font = New Font("Arial", 12, FontStyle.Bold)
        Next i
        'AddHandler DgvImp.CellContentClick, AddressOf DgvImp_CellClick
        TextBoxSearch.Text = Class1.hssearchbox
        TextBox1.Text = Class1.CntSearchbox
    End Sub
    Public Sub refresh()
        'MessageBox.Show("hello")

    End Sub

    Private Sub DgvImp_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvImp.CellFormatting
        'For i = 0 To Me.DataGridView1.Rows.Count - 1

        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)

        'rowind = e.RowIndex
        'colind = e.ColumnIndex
        If (e.ColumnIndex = 11) Then
            If (Me.DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "Y") Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Red 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Yellow
            ElseIf (Me.DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "N") Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.White 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Red
            End If
            ' Next
        End If

        'refresh()
    End Sub




    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "Exports") Then

            'Try
            '    Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%' and hs like '%" & TextBoxSearch.Text & "%'"
            'Catch abc As Exception
            '    MessageBox.Show("Sorry! Searched User_Name does Not Exist.")HsDesc
            'End Try
            Try
                Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%' and HsDesc like '%" & TextBox2.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
            End Try
        End If
        If (userclass = "Imports") Then
            Try
                'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
                'Me.ImportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%'"
                Me.ImportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%'"
                'WHERE City =' " & cboCity.text & " ' AND AreaCode LIKE ' " & txtAreacode.text & " ' 
            Catch abc As Exception
                'MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
            End Try


            'Try
            '    'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
            '    Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBoxSearch.Text & "%'"
            'Catch abc As Exception
            '    MessageBox.Show("Sorry! Searched HS_Name does not Exist.")
            'End Try

        End If


    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'MessageBox.Show(Class1.rowindx)
        Me.SupervisorWorkTableAdapter.InsertLastWorkingRecordTrack(Class1.rowindx, Class1.GetUserID, Class1.YY, Class1.MM)
        If DgvImp.Rows.Count > 0 Then
            Me.ImportDataTableAdapter.UpdateCompletedRec(Class1.GetUserID, Class1.YY, Class1.MM)
            Me.ImportDataTableAdapter.UpdateRemaining(Class1.GetUserID, Class1.YY, Class1.MM)
        End If
        Me.Hide()
        ''EditorDashboard.Refresh()
        EditorDashboard.Dispose()
        EditorDashboard.Show()
    End Sub

    Private Sub EditImports_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.SupervisorWorkTableAdapter.InsertLastWorkingRecordTrack(Class1.rowindx, Class1.GetUserID, Class1.YY, Class1.MM)
        If DgvImp.Rows.Count > 0 Then
            Me.ImportDataTableAdapter.UpdateCompletedRec(Class1.GetUserID, Class1.YY, Class1.MM)
            Me.ImportDataTableAdapter.UpdateRemaining(Class1.GetUserID, Class1.YY, Class1.MM)
        End If
        'MessageBox.Show(Class1.rowindx)
        'Application.Exit()
        '''' End
        '''
        EditorDashboard.Show()
    End Sub


    Private Sub DgvImp_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvImp.CellEndEdit
        With DgvImp
            'Class1.rowindx = 0
            'Class1.colindx = 0

            Dim flg As Boolean
            flg = True
            If e.RowIndex <= .Rows.Count - 1 Then

                If e.ColumnIndex = .Columns.IndexOf(.Columns("ImpCNT")) Then

                    Dim country As String
                    Dim updatedcountry As String
                    Dim GetExpRowRecNo1 As Integer = .CurrentRow.Cells("ImpSNo").Value()
                    Dim GetExpCntry As String = .CurrentCell.FormattedValue

                    Dim CheckCNT As Integer = Me.CountryTableAdapter.CheckCNT(GetExpCntry)
                    country = Me.ImportDataTableAdapter.GetCountry(GetExpRowRecNo1, Class1.YY, Class1.MM)
                    Dim oldcountry = Me.ImportDataTableAdapter.GetOldCOuntry(GetExpRowRecNo1, Class1.YY, Class1.MM)
                    updatedcountry = Me.ImportDataTableAdapter.GetUpdatedCountry(GetExpCntry)
                    If CheckCNT > 0 Then
                        Me.ImportDataTableAdapter.UpdateCountry(GetExpCntry, GetExpRowRecNo1, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo1, Class1.YY, Class1.MM)
                        DgvImp.Rows(e.RowIndex).Cells(11).Value = Status
                        DgvImp.Rows(e.RowIndex).Cells(5).Value = updatedcountry

                        If CheckCNT < 1 Then
                            DgvImp.Rows(e.RowIndex).Cells(5).Value = country

                            Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        End If
                    Else
                        '.CancelEdit()
                        MsgBox("The Entered CountryCode does not Exist")
                        DgvImp.Rows(e.RowIndex).Cells(5).Value = country
                        DgvImp.Rows(e.RowIndex).Cells(4).Value = oldcountry
                        flg = False
                    End If

                End If

                If e.ColumnIndex = .Columns.IndexOf(.Columns("ImpTT")) Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNo").Value()
                    Dim GetExpTT As String = .CurrentCell.Value
                    Dim tradetype As Integer = Me.ImportDataTableAdapter.GetTradeType(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim CheckTT As Integer = Me.ImportDataTableAdapter.CheckTradeTypeExp(GetExpTT)
                    If CheckTT > 0 Then
                        If GetExpTT = 1 Or GetExpTT = 2 Then

                            Me.ImportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                            Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                            DgvImp.Rows(e.RowIndex).Cells(11).Value = Status
                        Else
                            DgvImp.Rows(e.RowIndex).Cells(2).Value = tradetype
                        End If
                        Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    Else
                        '.CancelEdit()
                        MsgBox("The Entered Trade Type does not Exist in our database")
                        DgvImp.Rows(e.RowIndex).Cells(2).Value = tradetype
                        flg = False

                    End If
                End If


                If e.ColumnIndex = .Columns.IndexOf(.Columns("ImpQty")) Then


                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNo").Value()
                    Dim GetExpQty As Integer = .CurrentCell.Value


                    'If (GetExpQty <= 0) Then
                    '    .CancelEdit()
                    'End If
                    If (GetExpQty >= 0) Then



                        Me.ImportDataTableAdapter.UpdateQuantity(GetExpQty, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)

                        Dim unitvalue As Integer = Me.ImportDataTableAdapter.UpdateUnitValue(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvImp.Rows(e.RowIndex).Cells(11).Value = Status
                        DgvImp.Rows(e.RowIndex).Cells(9).Value = unitvalue
                        DgvImp.Rows(e.RowIndex).Cells(7).Value = GetExpQty
                        ''''''''refill and update Gridview
                        'Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
                        ''   Me.DgvImp.Refresh()
                        Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    End If

                End If

                'Me.ImportDataTableAdapter.UpdateUnsureRec(GetExpRowRecNo, GetExpRowRecNo, Class1.YY, Class1.MM)
                'Me.ImportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                'Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)

                'Dim unitvalue As Integer = Me.ImportDataTableAdapter.UpdateUnitValue(GetExpRowRecNo)
                'Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo)
                'DgvImp.Rows(e.RowIndex).Cells(10).Value = Status
                'DgvImp.Rows(e.RowIndex).Cells(8).Value = unitvalue
                '''''''''refill and update Gridview
                ''Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
                ''   Me.DgvImp.Refresh()
                'Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                '    End If


                If e.ColumnIndex = .Columns.IndexOf(.Columns("ImpHs")) Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNo").Value()
                    Dim GetExpHS As String = .CurrentCell.Value
                    Dim CheckHS As Integer = Me.HscodeTableAdapter.CheckHS(GetExpHS)
                    Dim HS As String = Me.ImportDataTableAdapter.GetHsCode(GetExpHS)
                    Dim hsdesc As String = Me.ImportDataTableAdapter.GetOldHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim hsid As Integer = Me.ImportDataTableAdapter.GetOldHsId(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim oldUnit As String = Me.ImportDataTableAdapter.GetOldHsUnit(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim updatedUnit As String = Me.ImportDataTableAdapter.GetUpdatedHSUnit(GetExpHS)

                    If CheckHS > 0 Then
                        Me.ImportDataTableAdapter.UpdateHsCode(GetExpHS, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUnitHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Dim Status As String = Me.ImportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvImp.Rows(e.RowIndex).Cells(11).Value = Status

                        DgvImp.Rows(e.RowIndex).Cells(12).Value = HS
                        DgvImp.Rows(e.RowIndex).Cells(6).Value = updatedUnit
                        If CheckHS < 1 Then
                            DgvImp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                            DgvImp.Rows(e.RowIndex).Cells(6).Value = oldUnit

                            Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        End If

                        Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)

                    Else
                        .CancelEdit()
                        MsgBox("The Entered HS-Code does not Exist in our database")
                        DgvImp.Rows(e.RowIndex).Cells(10).Value = hsid
                        DgvImp.Rows(e.RowIndex).Cells(6).Value = oldUnit
                        DgvImp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                        'flg = False
                    End If
                End If


            End If
            '.CancelEdit()
        End With

    End Sub
    Public Sub func()
        With DgvImp
            Try
                Label13.Text = ""
                Label17.Visible = False
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
                Label15.Visible = True
                'Label17.Visible = False

                For Each Cell As DataGridViewCell In DgvImp.SelectedCells

                    Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("ImpHs").Value()


                    Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("ImpCNT").Value()
                    Label7.Text = ""
                    Label13.Text = ""
                    Label14.Text = ""

                    Label15.Text = ""

                    If (HSforSummaryUVEx <> 99100000) Then
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

                            'this will caclacua





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
                            'Dim a As Integer = QtySum / tblUser.Rows.Count
                            'Dim b As Integer = PKRSum / tblUser.Rows.Count


                            Class1.ao = QtySum / tblUser.Rows.Count
                            If Class1.ao = 0 Then
                                Label17.Visible = False
                                Label7.Text = ""
                                Label13.Text = ""
                                Label14.Text = ""
                                Label12.Text = ""
                                Label15.Text = ""

                            End If
                            Class1.bo = PKRSum / tblUser.Rows.Count
                            'Label13.Text = QtySum / tblUser.Rows.Count
                            'Label14.Text = PKRSum / tblUser.Rows.Count

                            Try

                                'Dim Month As String = Class1.MonthName(Class1.MM)
                                'Dim mon As ULong = Me.ImportDataTableAdapter.MonthForUnitValueImport()
                                'Dim year As ULong = Me.ImportDataTableAdapter.YearForUnitValueImport()
                                Dim Month As String = ""
                                Month = Class1.MonthName(Class1.MM)
                                Dim mon As ULong = 0
                                mon = Me.ImportDataTableAdapter.MonthForUnitValueImport()

                                Dim year As ULong = 0
                                year = Me.ImportDataTableAdapter.YearForUnitValueImport()

                                Label15.Text = Math.Round((Class1.bo / Class1.ao), 2)
                                Label16.Visible = False
                                Dim monforUnitvalue As String = ""
                                monforUnitvalue = Class1.MonthName(mon)
                                Label14.Text = monforUnitvalue
                                Label13.Text = year





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


                    End If
                Next

                If tblUser.Rows.Count = 0 Then

                    Label16.Visible = False
                    Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("ImpHs").Value()
                    Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("ImpCNT").Value()

                    If (HSforSummaryUVEx <> 99100000) Then
                        Class1.getPreviousYearUnitValue(CntforSummaryVuEx, HSforSummaryUVEx, 1)

                        If Class1.tblUs.Rows.Count <> 0 Then

                            If ((Class1.tblUs.Rows(i).Item(4)) <> 0) Then
                                Label15.Text = Class1.tblUs.Rows(i).Item(4)
                                Label13.Text = "Yearly"
                                Label16.Visible = False
                                Label14.Text = ""
                                Label12.Text = "Unit Value"
                            End If

                            If ((Class1.tblUs.Rows(i).Item(5)) <> 0) Then
                                Label16.Visible = False
                                Label15.Text = Class1.tblUs.Rows(i).Item(5)
                                Label13.Text = "Yearly"
                                Label14.Text = ""
                                Label12.Text = "Unit Value"
                                'Label15.Text = "Unit Value not Found"
                            End If

                        End If
                    End If



                    If Class1.tblUs.Rows.Count = 0 Then

                        Label7.Text = ""
                        Label13.Text = ""
                        Label14.Text = ""
                        Label12.Text = ""
                        Label15.Text = ""
                        Label16.Visible = True

                    End If





                    'Label17.Visible = True

                End If

                Dim HSSummaryUVEx As Integer = .CurrentRow.Cells("ImpHs").Value()
                If (HSSummaryUVEx = 99100000) Then

                    Label7.Text = ""
                    Label13.Text = ""
                    Label14.Text = ""
                    Label12.Text = ""
                    Label16.Visible = True
                    Label15.Text = ""

                End If

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
    Private Function TradeTypeTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub DgvImp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvImp.CellContentClick
        With DgvImp
            'Try


            '    For Each Cell As DataGridViewCell In DgvImp.SelectedCells

            '        Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("HSDataGridViewTextBoxColumn").Value()
            '        Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("CNTDataGridViewTextBoxColumn").Value()
            '        'Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
            '        'Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
            '        'Dim datatable As New DataTable


            '        'If tblUser.Rows.Count <> 0 Then
            '        '    Return tblUser(0)
            '        'Else
            '        '    Return Nothing
            '        'End If






            '        Dim QtySum As ULong = 0
            '        Dim PKRSum As ULong = 0
            '        GetUser(CntforSummaryVuEx, HSforSummaryUVEx)
            '        For i = 0 To tblUser.Rows.Count - 1
            '            'MessageBox.Show(tblUser.Rows(i).Item(9))
            '            'MessageBox.Show(tblUser.Rows(i).Item(10))
            '            Class1.QtyArray(i) = tblUser.Rows(i).Item(7)
            '            Class1.PKRArray(i) = tblUser.Rows(i).Item(8)





            '            If Cell.Value.ToString() = "".ToString() Then
            '                QtySum = Class1.QtyArray(i) + 0
            '                PKRSum = Class1.PKRArray(i) + 0
            '                'sumflag = 0

            '            Else
            '                QtySum = QtySum + Class1.QtyArray(i)
            '                PKRSum = PKRSum + Class1.PKRArray(i)
            '                'If Cell.Value.ToString = "" Then
            '                '        SumValue = SumValue + 0
            '                '    End If

            '                'sumflag = 0
            '            End If
            '            Dim a As Integer = QtySum / tblUser.Rows.Count
            '            Dim b As Integer = PKRSum / tblUser.Rows.Count
            '            'Label13.Text = QtySum / tblUser.Rows.Count
            '            'Label14.Text = PKRSum / tblUser.Rows.Count

            '            Try
            '                Label11.Text = b / a
            '            Catch ex As Exception

            '            End Try







            '        Next


            '        'Label13.Text = HSforSummaryUVEx
            '        'Label14.Text = CntforSummaryVuEx

            '        'Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
            '        'Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()
            '        'Dim yy = Class1.YY
            '        'Dim mm = Class1.MM
            '        'Dim constring As String = "Data Source=DESKTOP-AHDEUJI\SQLEXPRESS;Initial Catalog=TradeStatistics;User id = sa;password=data@123"
            '        'Using con As New SqlConnection(constring)
            '        '    Using cmd As New SqlCommand("SELECT SNO, QTY, PKR FROM ExportSummary WHERE (YY =18) AND (MM = 7) ", con)
            '        '        cmd.CommandType = CommandType.Text
            '        '        Using sda As New SqlDataAdapter(cmd)
            '        '            Using dt As New DataTable()
            '        '                sda.Fill(dt)
            '        '                'dataGridView1.DataSource = dt
            '        '            End Using
            '        '        End Using
            '        '    End Using
            '        'End Using



            '    Next

            'Catch ex As Exception

            'End Try
            '    For Each Cell As DataGridViewCell In DgvExp.SelectedCells
            '        HSforSummaryUVEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
            '        CntforSummaryVuEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value



            '        Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
            '        Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()

            '    Next
            'Catch ex As Exception
            'Label12.Visible = False
            'Label13.Visible = False
            'Label14.Visible = False
            'Label15.Visible = False
            'Label17.Visible = False
            func()
        End With

    End Sub

    'Private Sub DgvImp_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DgvImp.CellValidating
    '    If e.ColumnIndex = 8 Or e.ColumnIndex = 5 Or e.ColumnIndex = 3 Or e.ColumnIndex = 1 Then
    '        If Me.DgvImp.IsCurrentCellDirty Then
    '            If Not IsNumeric(e.FormattedValue) Then
    '                e.Cancel = True
    '                MsgBox("Please Enter Numeric Values Only")
    '            End If

    '        End If
    '    End If




    'End Sub


    Public Function GetCheckedRows1(
        ByVal GridView As DataGridView,
        ByVal ColumnName As String) As List(Of DataGridViewRow)
        Return _
            (
                From SubRows In
                    (
                        From Rows In GridView.Rows.Cast(Of DataGridViewRow)()
                        Where Not Rows.IsNewRow
                    ).ToList
                Where CBool(SubRows.Cells(ColumnName).Value) = True
            ).ToList
    End Function
    Dim sumflag As Integer = 0
    Dim countflag As Integer = 0
    Private Sub DgvImp_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DgvImp.CellValidating
        rowind = e.RowIndex
        colind = e.ColumnIndex
        Dim newinteger As Integer

        'func()
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

        If e.ColumnIndex = 9 Or e.ColumnIndex = 6 Or e.ColumnIndex = 4 Or e.ColumnIndex = 2 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then
            If Me.DgvImp.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                    MsgBox("Please Enter Numeric Values Only")
                End If

                If Not Integer.TryParse(e.FormattedValue.ToString(), newinteger) OrElse newinteger < 0 Then
                    e.Cancel = True
                    DgvImp.Rows(e.RowIndex).ErrorText = "the value must be a non-negative integer"
                    MsgBox("Negative Numbers are not allowed")
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
        If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
            sumflag = 1

        End If

        If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
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

        If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Then
            sumflag = 0
            Label4.Text = ""
            Label11.Text = ""

        End If






    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "Exports") Then


            Try
                Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched User_Name does not Exist.")
            End Try
        End If
        If (userclass = "Imports") Then
            Try
                'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
                Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
                Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%' and hs like '%" & TextBoxSearch.Text & "%'"
            Catch abc As Exception
                'MessageBox.Show("Sorry! Searched User_Name does not Exist.")
            End Try


        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Dim RowVal As Integer
    Dim i As Integer
    Dim cb As Integer
    Dim selectedCellCount As Integer
    Dim GetImpRowRecNo As Integer
    Dim updatevalue As Integer = 0


    Private Sub DgvImp_SelectionChanged(sender As Object, e As EventArgs) Handles DgvImp.SelectionChanged
        With DgvImp

            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label17.Visible = False

            If (Class1.Isclear <> 1) Then
                Class1.Isclear = 0






                Try
                    'If (.CurrentCell.FormattedValue.IsNumeric = False) Then

                    '    Return
                    'End If
                    'Class1.singleRoundValue = .CurrentCell.FormattedValue
                    'func()
                    If Class1.replaceflag = 1 Then
                        selectedCellCount = DgvImp.GetCellCount(DataGridViewElementStates.Selected)

                        For i = 0 To selectedCellCount - 1
                            RowVal = DgvImp.SelectedCells(i).Value.ToString

                            'RowVal = DgvImp.SelectedCells(i)..ToString
                            'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                            Class1.rowindx = DgvImp.CurrentRow.Index
                            Class1.colindx = DgvImp.Columns("ImpQty").Index
                            'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                            'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                            Dim p11 = DgvImp.CurrentCell.RowIndex
                            Dim p = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(1).Value
                            Dim p1 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(7).Value
                            Dim p2 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(8).Value
                            Class1.ValueArray(i) = p2
                            Class1.RowNoArray(i) = p
                            Class1.QtyArray(i) = p1

                            cb = selectedCellCount - 1
                            Class1.SelectedCellCount = cb
                            'MessageBox.Show(Class1.ValueArray(i))
                            'MessageBox.Show(Class1.RowNoArray(i))


                        Next i
                        Class1.HsCodeCP = 0



                    End If
                    If Class1.HsCodeCP = 1 Then
                        selectedCellCount = DgvImp.GetCellCount(DataGridViewElementStates.Selected)
                        'sumflag = 0
                        'Class1.replaceflag = 0
                        'MessageBox.Show(Class1.ValueArray(i))
                        'MessageBox.Show(Class1.RowNoArray(i))

                        For i = 0 To selectedCellCount - 1
                            RowVal = DgvImp.SelectedCells(i).Value.ToString

                            'RowVal = DgvImp.SelectedCells(i)..ToString
                            'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                            Class1.rowindx = DgvImp.CurrentRow.Index
                            Class1.colindx = DgvImp.Columns("ImpHs").Index
                            'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                            'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                            Dim p11 = DgvImp.CurrentCell.RowIndex
                            Dim p = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(1).Value
                            Dim p1 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(10).Value
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
                    'Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    'Class1.rowindx = e.RowIndex
                    'Class1.colindx = e.ColumnIndex
                    If sumflag = 1 Then
                        Dim SumValue As ULong = 0
                        Dim ct As ULong = 0
                        Dim sumv As Integer
                        Dim sumv9 As Integer
                        Dim p7 As Integer
                        Dim p9 As Integer
                        Dim res As Integer
                        For Each Cell As DataGridViewCell In DgvImp.SelectedCells

                            Try


                                For i = 0 To selectedCellCount - 1
                                    p7 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(7).Value
                                    sumv = sumv + p7

                                    p9 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(8).Value
                                    'If p9 = "".ToString() Then
                                    '    MessageBox.Show(p9.ToString())
                                    'End If
                                    sumv9 = sumv9 + p9
                                    res = sumv9 / sumv
                                    Label11.Text = res.ToString()



                                Next i
                            Catch ex As Exception

                            End Try
                            If Cell.Value.ToString() = "".ToString() Then
                                SumValue = SumValue + 0
                                ct = ct + 0
                                'sumflag = 0

                            Else
                                SumValue = SumValue + Cell.Value
                                If Cell.Value.ToString = "" Then
                                    SumValue = SumValue + 0
                                End If
                                ct = ct + 1
                                'sumflag = 0
                            End If
                        Next

                        Label4.Text = SumValue
                        'Label11.Text = SumValue / ct
                        'Label9.Text = ct



                        selectedCellCount = DgvImp.GetCellCount(DataGridViewElementStates.Selected)

                        'MessageBox.Show(Class1.ValueArray(i))
                        'MessageBox.Show(Class1.RowNoArray(i))

                        For i = 0 To selectedCellCount - 1
                            RowVal = DgvImp.SelectedCells(i).Value.ToString

                            'RowVal = DgvImp.SelectedCells(i)..ToString
                            'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                            Class1.rowindx = DgvImp.CurrentRow.Index
                            Class1.colindx = DgvImp.Columns("ImpQty").Index
                            'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                            'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                            Dim p11 = DgvImp.CurrentCell.RowIndex
                            Dim p = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(1).Value
                            Dim p1 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(7).Value
                            Dim p2 = DgvImp.Rows(DgvImp.SelectedCells(i).RowIndex).Cells(8).Value
                            'Dim p1 = DgvImp.Rows(i).Cells(6).Value.ToString
                            'GetImpRowRecNo = DgvImp.CurrentRow.Cells("ImpSNO").Value()
                            'GetImpRowRecNo = DgvImp.SelectedRows(0).Cells("ImpSNO").Value
                            'RowVal = DgvImp.CurrentRow.Cells("ImpQty").Value()
                            'RowVal = DgvImp.SelectedRows(0).Cells("ImpVal").Value
                            'GetImpRowRecNo = DgvImp.SelectedRows(0).Cells(0).Value

                            'GetImpRowRecNo = Convert.ToInt32(DgvImp.Rows[2].Cells[0].Value.ToString())
                            'DgvImp.SelectedCells(""
                            Class1.ValueArray(i) = p2
                            Class1.RowNoArray(i) = p
                            Class1.QtyArray(i) = p1

                            cb = selectedCellCount - 1
                            Class1.SelectedCellCount = cb
                            'MessageBox.Show(Class1.ValueArray(i))
                            'MessageBox.Show(Class1.RowNoArray(i))


                        Next i
                        Class1.formulaflag = 0
                    End If




                    If countflag = 1 Then

                        Dim ct As ULong = 0

                        For Each Cell As DataGridViewCell In DgvImp.SelectedCells
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
                    'Class1.rowindx = DgvImp.CurrentRow.Index
                Catch ex As Exception

                End Try
                'Class1.Isclear = 0
                'End If
            End If
            If (Class1.Isclear = 1) Then
                Class1.Isclear = 0
            End If
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With DgvImp
            .CurrentCell.Style.BackColor = Color.Blue
            .CurrentCell.Style.ForeColor = Color.White
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With DgvImp
            .CurrentCell.Style.BackColor = Color.Silver
            .CurrentCell.Style.ForeColor = Color.Black
        End With
    End Sub

    Private Sub DgvImp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvImp.CellClick
        With DgvImp
            Try
                Label11.Text = ""
                func()

                'Label17.Visible = False
                Class1.rowindx = e.RowIndex
                If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

                    'Reference the GridView Row.
                    Dim row As DataGridViewRow = DgvImp.Rows(e.RowIndex)

                    'Set the CheckBox  .
                    row.Cells("UnsureRec").Value = Convert.ToBoolean(row.Cells("UnsureRec").EditedFormattedValue)
                    Dim GetExpRowRecNo1 As Integer = .CurrentRow.Cells("ImpSNo").Value()
                    Dim CS As String = Convert.ToString(Me.ImportDataTableAdapter.CheckStatus(GetExpRowRecNo1))
                    'If CS = True And Class1.UnRec = 0 Or Class1.UnRec = 1 Then
                    If CS = "" Then
                        'row.Cells("UnsureRec").Value = False
                        'Me.ImportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ImportDataTableAdapter.SetStatus(1, GetExpRowRecNo1)
                        'Class1.UnRec = 1
                        'Exit Sub
                    End If
                    'If row.Cells("UnsureRec").Value = False Then
                    '    MessageBox.Show(" checked now")
                    '    Exit Sub
                    If CS = "True" Then
                        'row.Cells("UnsureRec").Value = True
                        Me.ImportDataTableAdapter.SetStatus(0, GetExpRowRecNo1)
                        'Class1.UnSRec = 1
                        Exit Sub
                    End If

                    'End If
                    'If CheckBox is checked, display Message Box.
                    'If Convert.ToBoolean(row.Cells("UnsureRec").Value) Then
                    '    MessageBox.Show(("Selected ID: " & row.Cells(12).Value))
                    'End If
                End If
                'MessageBox.Show("single click cell click")
                'DgvImp.ClearSelection()

                'If sumflag = 1 Then
                '    Dim SumValue As Integer


                '    For Each Cell As DataGridViewCell In DgvImp.SelectedCells
                '        If Cell.Value.ToString() = "".ToString() Then
                '            SumValue = SumValue + 0
                '            'sumflag = 0

                '        Else
                '            SumValue = SumValue + Cell.Value
                '            'sumflag = 0
                '        End If
                '    Next

                '    Label4.Text = SumValue
                'End If


                If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
                    sumflag = 1
                    Try


                        Label4.Text = .CurrentCell.Value
                    Catch ex As Exception

                    End Try
                End If

                If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
                    countflag = 1
                    Try


                        'Label9.Text = .CurrentCell.Value
                    Catch ex As Exception

                    End Try
                End If

                If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Then
                    sumflag = 0
                    Label4.Text = ""
                End If

            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub DgvImp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvImp.CellDoubleClick
        With DgvImp

            func()
            'If e.ColumnIndex = 7 Then
            '    Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
            '    Class1.rowindx = e.RowIndex
            '    Class1.colindx = e.ColumnIndex
            '    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNo").Value()
            '    Dim val As Integer = .CurrentRow.Cells("ImpVal").Value()
            '    Class1.value = val
            '    Class1.tT = 1
            '    Class1.replaceflag = 0
            '    Class1.formulaflag = 0
            '    Class1.IndexPos = 0
            '    'Class1.SinlgeROundFOrmula = 1
            '    Class1.RecNo = GetExpRowRecNo
            '    RoundFormula.Show()
            '    Me.Close()

            'End If

        End With

    End Sub

    Private Sub Replace_Click(sender As Object, e As EventArgs) Handles Replace.Click
        With DgvImp
            Class1.hssearchbox = TextBoxSearch.Text
            Class1.CntSearchbox = TextBox1.Text
            'Replace Button
            Try
                selectedCellCount = DgvImp.GetCellCount(DataGridViewElementStates.Selected)
                If selectedCellCount < 2 Then
                    Exit Sub
                End If

                DgvImp.Rows(rowind).Cells(colind).Selected = True

                If Class1.HsCodeCP = 1 Then
                    Class1.tT = 1
                    Me.Close()

                    RoundFormula.Show()

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


                        Class1.tT = 1
                        'Class1.RecNo = GetExpRowRecNo

                        Class1.formulaflag = 1
                        Me.Close()
                        RoundFormula.Show()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If

                    If Class1.roundFormulaIndex = 1 Then

                        Class1.tT = 1
                        'Class1.RecNo = GetExpRowRecNo
                        Class1.roundFormulaIndex = 1
                        Me.Close()
                        RoundFormula.Show()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If

                End If
            Catch ex As Exception

            End Try

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With DgvImp

            Class1.hssearchbox = TextBoxSearch.Text
            Class1.CntSearchbox = TextBox1.Text
            'Replace Button

            Try


                Class1.formulaflag = 0
                Class1.FormulaIndexPos = 0
                Class1.roundFormulaIndex = 1
                selectedCellCount = DgvImp.GetCellCount(DataGridViewElementStates.Selected)
                If selectedCellCount < 2 Then
                    Exit Sub
                End If

                If (colind = 7) Then
                    'If updatevalue = 1 Then
                    If Class1.replaceflag = 1 Then

                        Class1.tT = 1
                        'Class1.RecNo = GetExpRowRecNo
                        Class1.replaceflag = 1
                        Me.Close()
                        RoundFormula.Show()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If
                End If
            Catch ex As Exception

            End Try
            'MessageBox.Show("double click")
            'Try

            '    If updatevalue = 1 Then
            '        'If e.ColumnIndex = 6 Then
            '        '    Me.DgvImp.CurrentCell = DgvImp.Rows(e.RowIndex).Cells(e.ColumnIndex)
            '        '    Class1.rowindx = e.RowIndex
            '        '    Class1.colindx = e.ColumnIndex
            '        'Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ImpSNo").Value()
            '        'Dim val As Integer = .CurrentRow.Cells("ImpQty").Value()
            '        'Class1.value = val
            '        Class1.tT = 1
            '        'Class1.RecNo = GetExpRowRecNo
            '        Class1.formulaflag = 1
            '        RoundFormula.Show()
            '        Me.Close()
            '        updatevalue = 0

            '    End If
            'Catch ex As Exception

            'End Try

        End With
    End Sub

    'Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
    '    TextBox1.Text = ""
    '    TextBox2.Text = ""
    '    TextBoxSearch.Text = ""
    '    TextBox3.Text = ""
    '    Class1.Isclear = 1
    '    Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Class1.Isclear = 1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxSearch.Text = ""
        TextBox3.Text = ""
        TextBoxSearch.Text = ""
        Class1.hssearchbox = ""
        Class1.CntSearchbox = ""
        Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "Exports") Then


            Try
                Me.ExportDataBindingSource.Filter = "HsDesc Like '%" & TextBox2.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched Description does not Exist.")
            End Try
        End If
        If (userclass = "Imports") Then
            Try
                'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
                Me.ImportDataBindingSource.Filter = "HsDesc Like '%" & TextBox2.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched Description does not Exist.")
            End Try


            'Try
            '    'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
            '    Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBoxSearch.Text & "%'"
            'Catch abc As Exception
            '    MessageBox.Show("Sorry! Searched HS_Name does not Exist.")
            'End Try

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DgvImp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DgvImp.KeyPress
        'func()
    End Sub

    Private Sub DgvImp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvImp.CellEnter

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'Try
        '    'If TextBox3.Text = 0 Then
        '    '    TextBox3.Text = "True"
        '    'End If
        '    Me.ImportDataBindingSource.Filter = "UnSRec Like '%" & TextBox3.Text & "%'"
        'Catch abc As Exception
        '    MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
        '    TextBox3.Text = ""
        'End Try

        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "Exports") Then


            Try
                Me.ExportDataBindingSource.Filter = "UnSRec Like '%" & TextBox3.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched Description does not Exist.")
            End Try
        End If
        If (userclass = "Imports") Then
            Try
                'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
                Me.ImportDataBindingSource.Filter = "UnSRec Like '%" & TextBox3.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched Description does not Exist.")
            End Try


            'Try
            '    'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
            '    Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBoxSearch.Text & "%'"
            'Catch abc As Exception
            '    MessageBox.Show("Sorry! Searched HS_Name does not Exist.")
            'End Try

        End If


        'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
        '

    End Sub

    Private Sub lblMonthYear_Click(sender As Object, e As EventArgs) Handles lblMonthYear.Click

    End Sub

    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub LblHeading_Click(sender As Object, e As EventArgs) Handles LblHeading.Click

    End Sub

    Private Sub DgvImp_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvImp.KeyDown


        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label17.Visible = False

        'func()
    End Sub

    Private Sub DgvImp_Enter(sender As Object, e As EventArgs) Handles DgvImp.Enter
        'func()
    End Sub
End Class