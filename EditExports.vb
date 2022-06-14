Imports System.Configuration
Imports System.Data.SqlClient

Public Class EditExports



    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "Exports") Then
            Try
                'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%'"
                Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%' "
                'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%'"
            Catch abc As Exception
                'MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
            End Try


        End If
        If (userclass = "Imports") Then
            Try
                Me.ImportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%'"
            Catch abc As Exception
                MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
            End Try


        End If


    End Sub


    Public Sub DgvExp_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvExp.CellFormatting
        'For i = 0 To Me.DataGridView1.Rows.Count - 1
        With DgvExp
            '    'If e.CellStyle.ForeColor = Color.Silver Then
            '    '    MessageBox.Show("helli")
            '    'End If
            '    If highligh = 1 Then
            If (e.ColumnIndex = 11) Then

                If (Me.DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "Y") Then
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.BackColor = Color.Red 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Yellow
                ElseIf (Me.DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "") Then
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.BackColor = Color.White 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Red
                    'MessageBox.Show("he")
                End If
            End If





            '            'Dim cancelhighlight As Integer
            '            '.CurrentCell.Style.BackColor = Color.Blue
            '            '.CurrentCell.Style.ForeColor = Color.White


            '            Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()

            '            Me.ExportDataTableAdapter.UpdateHighlight(GetExpRowRecNo, Class1.YY, Class1.MM)

            '        End If
            '    End If


            '    If (e.ColumnIndex = 10) Then
            '        If (Me.DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "Y") Then
            '            e.CellStyle.ForeColor = Color.Black
            '            e.CellStyle.BackColor = Color.Red 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Yellow
            '        ElseIf (Me.DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper = "N") Then
            '            e.CellStyle.ForeColor = Color.Black
            '            e.CellStyle.BackColor = Color.White 'Me.DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.Red
            '            'MessageBox.Show("he")
            '        End If
            '        ' Next
            '    End If
        End With
    End Sub
    'Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        'If TextBox3.Text = 0 Then
    '        '    TextBox3.Text = "True"
    '        'End If
    '        Me.ExportDataBindingSource.Filter = "UnSRec Like '%" & TextBox3.Text & "%'"
    '    Catch abc As Exception
    '        MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
    '    End Try

    '    'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
    '    '

    'End Sub

    Dim rowind As Integer = Class1.rowindx
    Dim colind As Integer = Class1.colindx

    Dim tblUser = New DataTable
    Public Function GetUser(CNT As Integer, HS As Integer) As DataTable

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("TradeEdit.My.MySettings.TradeStatisticsConnectionString").ConnectionString
        Dim mon As Integer = Me.ExportDataTableAdapter.MonthForUnitValueExport()
        Dim year As Integer = Me.ExportDataTableAdapter.YearForUnitValueExport()
        Dim con = New SqlConnection(connectionString)
        'Using con = New SqlConnection("TradeEdit.My.MySettings.TradeStatisticsConnectionString")
        Using cmd = New SqlCommand("select * from ExportSummary where CNT= @cnt and HS=@hs  and YY=@yy and MM=@mm", con)
            cmd.Parameters.AddWithValue("@cnt", CNT)
            cmd.Parameters.AddWithValue("@hs", HS)
            Dim Tyear As Integer = year.ToString.Substring(2, 2)
            cmd.Parameters.AddWithValue("@yy", Tyear)
            cmd.Parameters.AddWithValue("@mm", mon)
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

    Public Sub EditExports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            'If Class1.RoundforFlag = 1 Then
            '        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
            '    End If

            Lbl_UserName.Text = Class1.U_Name

            'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
            'Class1.previousMonth = Month(previousDate)
            'Class1.preYear = Year(previousDate)
            'Clas s1.previousYear = Class1.preYear.ToString()
            'Class1.previousYear = Class1.previousYear.Substring(2, 2)


            Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
            LblValExp.Text = DgvExp.Rows.Count
            Dim Month As String = Class1.MonthName(Class1.MM)
            Me.lblMonthYear.Text = "    " & Month & " 20" & Class1.YY
            'lblMonthYear.Text = "ghghgh"
            'Me.lblMonthYear.Text = "Year ::::  " & Class1.YY & "  Month ::::  " & Class1.MM
            DgvExp.Columns(9).DefaultCellStyle.Format = "#,###"
            DgvExp.Columns(8).DefaultCellStyle.Format = "#,###"
            'Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
            'Me.DgvExp.Rows[0].IsSelected= True
            If (Class1.searchcontrol <> 1) Then

                DgvExp.ClearSelection()
                DgvExp.Rows(rowind).Cells(colind).Selected = True
            End If
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
            'To color unmatched Countries and HS codes, but the time to load will be a bit increased. Decide to use or not.
            'With DgvExp
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
            TextBoxSearch.Text = Class1.hssearchbox
            TextBox1.Text = Class1.CntSearchbox

        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.SupervisorWorkTableAdapter1.InsertLastWorkingRecordTrack(Class1.rowindx, Class1.GetUserID, Class1.YY, Class1.MM)
        If DgvExp.Rows.Count > 0 Then
            Me.ExportDataTableAdapter.UpdateCompletedRec(Class1.GetUserID, Class1.YY, Class1.MM)
            Me.ExportDataTableAdapter.UpdateRemaining(Class1.GetUserID, Class1.YY, Class1.MM)
        End If
        Me.Hide()
        EditorDashboard.Dispose()
        EditorDashboard.Show()
    End Sub
    Private Sub EditExports_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.SupervisorWorkTableAdapter1.InsertLastWorkingRecordTrack(Class1.rowindx, Class1.GetUserID, Class1.YY, Class1.MM)
        If DgvExp.Rows.Count > 0 Then
            Me.ExportDataTableAdapter.UpdateCompletedRec(Class1.GetUserID, Class1.YY, Class1.MM)
            Me.ExportDataTableAdapter.UpdateRemaining(Class1.GetUserID, Class1.YY, Class1.MM)
        End If
        EditorDashboard.Show()
        'Application.Exit()
        ''End
    End Sub
    Private Sub LabelNote_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub func()
        With DgvExp
            Try
                Label13.Text = ""
                Label17.Visible = False
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
                Label7.Visible = True
                For Each Cell As DataGridViewCell In DgvExp.SelectedCells

                    Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("ExpHs").Value()
                    Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("ExpCNT").Value()
                    'Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
                    'Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
                    'Dim datatable As New DataTable
                    Label7.Text = ""
                    Label13.Text = ""
                    Label14.Text = ""
                    'Label12.Text = ""

                    If (HSforSummaryUVEx <> 99100000) Then

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
                                'Label17.Visible = True

                            End If
                            Class1.bo = PKRSum / tblUser.Rows.Count
                            'Label13.Text = QtySum / tblUser.Rows.Count
                            'Label14.Text = PKRSum / tblUser.Rows.Count

                            Try
                                Dim Month As String = Class1.MonthName(Class1.MM)

                                Dim mon As Integer = Me.ExportDataTableAdapter.MonthForUnitValueExport()
                                Dim year As Integer = Me.ExportDataTableAdapter.YearForUnitValueExport()


                                'Dim mon As ULong = Me.ExportDataTableAdapter.MonthForUnitValueImport()
                                'Dim year As ULong = Me.ExportDataTableAdapter.YearForUnitValueImport()
                                Label12.Text = "Unit Value"
                                Label7.Text = Math.Round((Class1.bo / Class1.ao), 2)
                                Dim monforUnitvalue As String = Class1.MonthName(mon)
                                Label13.Text = monforUnitvalue
                                Label14.Text = year
                                Label16.Visible = False




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
                    'Label17.Visible = True
                    Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("ExpHs").Value()
                    Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("ExpCNT").Value()
                    If (HSforSummaryUVEx <> 99100000) Then
                        Class1.getPreviousYearUnitValue(CntforSummaryVuEx, HSforSummaryUVEx, 3)

                        If Class1.tblUs.Rows.Count <> 0 Then


                            If ((Class1.tblUs.Rows(i).Item(4)) <> 0) Then
                                Label7.Text = Class1.tblUs.Rows(i).Item(4)
                                Label16.Visible = False
                                Label13.Text = ""
                                Label14.Text = "Yearly"
                                Label12.Text = "Unit Value"
                            End If
                            If ((Class1.tblUs.Rows(i).Item(5)) <> 0) Then
                                Label7.Text = Class1.tblUs.Rows(i).Item(5)
                                Label13.Text = ""
                                Label16.Visible = False
                                Label14.Text = "Yearly"
                                Label12.Text = "Unit Value"
                            End If

                        End If
                    End If

                    If Class1.tblUs.Rows.Count = 0 Then

                            Label7.Text = ""
                            Label13.Text = ""
                            Label14.Text = ""
                            Label12.Text = ""
                            Label16.Visible = True
                        End If

                    End If

                    Dim HSSummaryUVEx As Integer = .CurrentRow.Cells("ExpHs").Value()
                Dim CntSummaryVuEx As Integer = .CurrentRow.Cells("ExpCNT").Value()

                If (HSSummaryUVEx = 99100000) Then

                    Label7.Text = ""
                    Label13.Text = ""
                    Label14.Text = ""
                    Label12.Text = ""
                    Label16.Visible = True
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

    'Public Sub func()
    '    With DgvExp
    '        Try


    '            For Each Cell As DataGridViewCell In DgvExp.SelectedCells

    '                Dim HSforSummaryUVEx As Long = .CurrentRow.Cells("ExpHs").Value()
    '                Dim CntforSummaryVuEx As Long = .CurrentRow.Cells("ExpCNT").Value()
    '                'Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
    '                'Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
    '                'Dim datatable As New DataTable


    '                'If tblUser.Rows.Count <> 0 Then
    '                '    Return tblUser(0)
    '                'Else
    '                '    Return Nothing
    '                'End If






    '                Dim QtySum As ULong = 0
    '                Dim PKRSum As ULong = 0
    '                GetUser(CntforSummaryVuEx, HSforSummaryUVEx)
    '                For i = 0 To tblUser.Rows.Count - 1
    '                    'MessageBox.Show(tblUser.Rows(i).Item(9))
    '                    'MessageBox.Show(tblUser.Rows(i).Item(10))
    '                    Class1.QtyArray(i) = tblUser.Rows(i).Item(7)
    '                    Class1.PKRArray(i) = tblUser.Rows(i).Item(8)

    '                    'this will caclacua





    '                    If Cell.Value.ToString() = "".ToString() Then
    '                        QtySum = Class1.QtyArray(i) + 0
    '                        PKRSum = Class1.PKRArray(i) + 0
    '                        'sumflag = 0

    '                    Else
    '                        QtySum = QtySum + Class1.QtyArray(i)
    '                        PKRSum = PKRSum + Class1.PKRArray(i)
    '                        'If Cell.Value.ToString = "" Then
    '                        '        SumValue = SumValue + 0
    '                        '    End If

    '                        'sumflag = 0
    '                    End If
    '                    Dim a As Long = QtySum / tblUser.Rows.Count
    '                    If a = 0 Then
    '                        Label17.Visible = True

    '                    End If
    '                    Dim b As Long = PKRSum / tblUser.Rows.Count
    '                    'Label13.Text = QtySum / tblUser.Rows.Count
    '                    'Label14.Text = PKRSum / tblUser.Rows.Count

    '                    Try
    '                        Dim Month As String = Class1.MonthName(Class1.MM)

    '                        Dim mon As Integer = Me.ExportDataTableAdapter.MonthForUnitValueExport()
    '                        Dim year As Integer = Me.ExportDataTableAdapter.YearForUnitValueExport()
    '                        Dim monforUnitvalue As String = Class1.MonthName(mon)

    '                        Label7.Text = b / a
    '                        Label13.Text = monforUnitvalue
    '                        Label14.Text = year
    '                    Catch ex As Exception

    '                    End Try







    '                Next


    '                'Label13.Text = HSforSummaryUVEx
    '                'Label14.Text = CntforSummaryVuEx

    '                'Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
    '                'Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()
    '                'Dim yy = Class1.YY
    '                'Dim mm = Class1.MM
    '                'Dim constring As String = "Data Source=DESKTOP-AHDEUJI\SQLEXPRESS;Initial Catalog=TradeStatistics;User id = sa;password=data@123"
    '                'Using con As New SqlConnection(constring)
    '                '    Using cmd As New SqlCommand("SELECT SNO, QTY, PKR FROM ExportSummary WHERE (YY =18) AND (MM = 7) ", con)
    '                '        cmd.CommandType = CommandType.Text
    '                '        Using sda As New SqlDataAdapter(cmd)
    '                '            Using dt As New DataTable()
    '                '                sda.Fill(dt)
    '                '                'dataGridView1.DataSource = dt
    '                '            End Using
    '                '        End Using
    '                '    End Using
    '                'End Using



    '            Next

    '        Catch ex As Exception

    '        End Try
    '        '    For Each Cell As DataGridViewCell In DgvExp.SelectedCells
    '        '        HSforSummaryUVEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
    '        '        CntforSummaryVuEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value



    '        '        Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
    '        '        Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()

    '        '    Next
    '        'Catch ex As Exception
    '    End With

    'End Sub
    Private Sub DgvExp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Try
        'With DgvExp
        '    Try
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label7.Visible = False
        Label17.Visible = False
        'func()
        '        For Each Cell As DataGridViewCell In DgvExp.SelectedCells

        '            Dim HSforSummaryUVEx As Integer = .CurrentRow.Cells("HSDataGridViewTextBoxColumn").Value()
        '            Dim CntforSummaryVuEx As Integer = .CurrentRow.Cells("CNTDataGridViewTextBoxColumn").Value()
        '            'Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
        '            'Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
        '            'Dim datatable As New DataTable


        '            'If tblUser.Rows.Count <> 0 Then
        '            '    Return tblUser(0)
        '            'Else
        '            '    Return Nothing
        '            'End If






        '            Dim QtySum As ULong = 0
        '            Dim PKRSum As ULong = 0
        '            GetUser(CntforSummaryVuEx, HSforSummaryUVEx)
        '            For i = 0 To tblUser.Rows.Count - 1
        '                'MessageBox.Show(tblUser.Rows(i).Item(9))
        '                'MessageBox.Show(tblUser.Rows(i).Item(10))
        '                Class1.QtyArray(i) = tblUser.Rows(i).Item(7)
        '                Class1.PKRArray(i) = tblUser.Rows(i).Item(8)

        '                'this will caclacua





        '                If Cell.Value.ToString() = "".ToString() Then
        '                    QtySum = Class1.QtyArray(i) + 0
        '                    PKRSum = Class1.PKRArray(i) + 0
        '                    'sumflag = 0

        '                Else
        '                    QtySum = QtySum + Class1.QtyArray(i)
        '                    PKRSum = PKRSum + Class1.PKRArray(i)
        '                    'If Cell.Value.ToString = "" Then
        '                    '        SumValue = SumValue + 0
        '                    '    End If

        '                    'sumflag = 0
        '                End If
        '                Dim a As Integer = QtySum / tblUser.Rows.Count
        '                Dim b As Integer = PKRSum / tblUser.Rows.Count
        '                'Label13.Text = QtySum / tblUser.Rows.Count
        '                'Label14.Text = PKRSum / tblUser.Rows.Count

        '                Try
        '                    Label11.Text = b / a
        '                Catch ex As Exception

        '                End Try







        '            Next


        '            'Label13.Text = HSforSummaryUVEx
        '            'Label14.Text = CntforSummaryVuEx

        '            'Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
        '            'Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()
        '            'Dim yy = Class1.YY
        '            'Dim mm = Class1.MM
        '            'Dim constring As String = "Data Source=DESKTOP-AHDEUJI\SQLEXPRESS;Initial Catalog=TradeStatistics;User id = sa;password=data@123"
        '            'Using con As New SqlConnection(constring)
        '            '    Using cmd As New SqlCommand("SELECT SNO, QTY, PKR FROM ExportSummary WHERE (YY =18) AND (MM = 7) ", con)
        '            '        cmd.CommandType = CommandType.Text
        '            '        Using sda As New SqlDataAdapter(cmd)
        '            '            Using dt As New DataTable()
        '            '                sda.Fill(dt)
        '            '                'dataGridView1.DataSource = dt
        '            '            End Using
        '            '        End Using
        '            '    End Using
        '            'End Using



        '        Next

        '    Catch ex As Exception

        '    End Try
        '    '    For Each Cell As DataGridViewCell In DgvExp.SelectedCells
        '    '        HSforSummaryUVEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
        '    '        CntforSummaryVuEx = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value



        '    '        Dim MonthforSummaryEx = Me.ExportSummaryTableAdapter.GetMonthForUnitSummary()
        '    '        Dim YearforSummaryEx = Me.ExportSummaryTableAdapter.GetYearForUnitSummary()

        '    '    Next
        '    'Catch ex As Exception
        'End With


        '    For Each Cell As DataGridViewCell In DgvExp.SelectedCells
        '        Dim HSforSummaryUVEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
        '        Dim CntforSummaryVuEx As Integer = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(6).Value
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
    End Sub
    Private Sub DgvExp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
        'Label12.Visible = False
        'Label13.Visible = False
        'Label14.Visible = False
        'Label7.Visible = False
        'Label17.Visible = False
        func()
    End Sub
    Public Sub DgvExp_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellValueChanged
        'Class1.rowindx = 0
        'Class1.colindx = 0
        Dim flg As Boolean
        flg = True
        'Dim ind As Integer
        ''  
        '' MsgBox(DgvExp.Columns.IndexOf(DgvExp.Columns("ExpHs")).ToString)
        With DgvExp
            Dim country As String
            Dim updatedcountry As String
            If e.RowIndex <= .Rows.Count - 1 Then

                If e.ColumnIndex = .Columns.IndexOf(.Columns("ExpCNT")) Then


                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()
                    Dim GetExpCntry As String = .CurrentCell.FormattedValue
                    Dim CheckCNT As Integer = Me.CountryTableAdapter.CheckCNT(GetExpCntry)

                    country = Me.ExportDataTableAdapter.GetCountry(GetExpRowRecNo, Class1.YY, Class1.MM)
                    updatedcountry = Me.ExportDataTableAdapter.GetUpdatedCountry(GetExpCntry)

                    Dim oldcountry = Me.ExportDataTableAdapter.GetOldCountry(GetExpRowRecNo, Class1.YY, Class1.MM)
                    If CheckCNT > 0 Then
                        Me.ExportDataTableAdapter.UpdateCountry(GetExpCntry, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = updatedcountry

                        Dim Status As String = Me.ExportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(11).Value = Status
                        If CheckCNT < 1 Then
                            DgvExp.Rows(e.RowIndex).Cells(5).Value = country

                            Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        End If
                    Else
                        .CancelEdit()
                        MsgBox("The Entered CountryCode does not Exist")
                        DgvExp.Rows(e.RowIndex).Cells(5).Value = country
                        'DgvImp.Rows(e.RowIndex).Cells(4).Value = country
                        DgvExp.Rows(e.RowIndex).Cells(4).Value = oldcountry

                        flg = False
                    End If

                End If

                If e.ColumnIndex = .Columns.IndexOf(.Columns("ExpTT")) Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()
                    Dim GetExpTT As String = .CurrentCell.Value

                    Dim tradetype As Integer = Me.ExportDataTableAdapter.GetTradeType(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim CheckTT As Integer = Me.ExportDataTableAdapter.CheckTradeTypeExp(GetExpTT)
                    If CheckTT > 0 Then
                        If GetExpTT = 3 Or GetExpTT = 4 Then

                            Me.ExportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                            Me.ExportDataTableAdapter.UpdateUpdatedRec(GetExpRowRecNo, Class1.YY, Class1.MM)
                            Dim Status As String = Me.ExportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                            DgvExp.Rows(e.RowIndex).Cells(11).Value = Status
                        Else
                            DgvExp.Rows(e.RowIndex).Cells(2).Value = tradetype
                            '.CancelEdit()
                        End If
                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    Else

                        MsgBox("The Entered Trade Type does not Exist in our database")
                        DgvExp.Rows(e.RowIndex).Cells(2).Value = tradetype
                        flg = False
                        .CancelEdit()
                    End If
                End If


                If e.ColumnIndex = .Columns.IndexOf(.Columns("ExpQty")) Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()
                    Dim GetExpQty As Integer = .CurrentCell.Value

                    'If (GetExpQty <= 0) Then
                    '    .CancelEdit()

                    'End If


                    If (GetExpQty >= 0) Then



                        Me.ExportDataTableAdapter.UpdateQuantity(GetExpQty, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUnitVal(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)

                        Dim unitvalue As Integer = Me.ExportDataTableAdapter.GetUnitValue(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(9).Value = unitvalue
                        Dim Status As String = Me.ExportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(11).Value = Status
                        ''''''''refill and update Gridview
                        'Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
                        ''   Me.DgvExp.Refresh()
                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    End If
                End If
                'startr
                'If e.ColumnIndex = .Columns.IndexOf(.Columns("ExpCNT")) Then


                'Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()
                '    Dim GetExpCntry As String = .CurrentCell.FormattedValue
                '    Dim CheckCNT As Integer = Me.CountryTableAdapter.CheckCNT(GetExpCntry)

                '    country = Me.ExportDataTableAdapter.GetCountry(GetExpRowRecNo)
                '    updatedcountry = Me.ExportDataTableAdapter.GetUpdatedCountry(GetExpCntry)
                '    If CheckCNT > 0 Then
                '        Me.ExportDataTableAdapter.UpdateCountry(GetExpCntry, GetExpRowRecNo, Class1.YY, Class1.MM)
                '        Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                '        DgvExp.Rows(e.RowIndex).Cells(4).Value = updatedcountry
                '        If CheckCNT < 1 Then
                '            DgvExp.Rows(e.RowIndex).Cells(4).Value = country

                '            Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                '        End If
                '    Else
                '        .CancelEdit()
                '        MsgBox("The Entered CountryCode does not Exist")
                '        DgvExp.Rows(e.RowIndex).Cells(4).Value = country
                '        flg = False
                '    End If

                'End If


                If e.ColumnIndex = .Columns.IndexOf(.Columns("ExpHs")) Then
                    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()
                    Dim GetExpHS As String = .CurrentCell.Value
                    Dim CheckHS As Integer = Me.HscodeTableAdapter.CheckHS(GetExpHS)

                    Dim HS As String = Me.ExportDataTableAdapter.GetHsCode(GetExpHS)

                    Dim hsdesc As String = Me.ExportDataTableAdapter.GetOldHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim hsid As Integer = Me.ExportDataTableAdapter.GetoldHSid(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim oldUnit As String = Me.ExportDataTableAdapter.GetOldHsUnit(GetExpRowRecNo, Class1.YY, Class1.MM)
                    Dim updatedUnit As String = Me.ExportDataTableAdapter.GetUpdatedHsUnit(GetExpHS)

                    If CheckHS > 0 Then
                        Me.ExportDataTableAdapter.UpdateHsCode(GetExpHS, GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUnitHsDesc(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Me.ExportDataTableAdapter.UpdateUpdated(GetExpRowRecNo, Class1.YY, Class1.MM)
                        Dim Status As String = Me.ExportDataTableAdapter.GetUpdatedStatus(GetExpRowRecNo, Class1.YY, Class1.MM)
                        DgvExp.Rows(e.RowIndex).Cells(11).Value = Status
                        DgvExp.Rows(e.RowIndex).Cells(12).Value = HS
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = updatedUnit
                        If CheckHS < 1 Then
                            DgvExp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                            DgvExp.Rows(e.RowIndex).Cells(6).Value = oldUnit

                            Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
                        End If

                        Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)

                    Else
                        .CancelEdit()
                        MsgBox("The Entered HS-Code does not Exist in our database")
                        DgvExp.Rows(e.RowIndex).Cells(10).Value = hsid
                        DgvExp.Rows(e.RowIndex).Cells(6).Value = oldUnit
                        DgvExp.Rows(e.RowIndex).Cells(12).Value = hsdesc
                        flg = False
                    End If
                End If


            End If
            '.CancelEdit()
        End With
        'Me.DgvExp.Refresh()


    End Sub
    Private Sub LblNote2_Click(sender As Object, e As EventArgs) Handles LblNote2.Click

    End Sub
    Public Sub DgvExp_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellContentClick
        'Label12.Visible = False
        'Label13.Visible = False
        'Label14.Visible = False
        'Label7.Visible = False
        'Label17.Visible = False
        func()
        'MessageBox.Show("cell content click")
        'MessageBox.Show(DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
    End Sub


    Private Sub LblExp_Click(sender As Object, e As EventArgs) Handles LblExp.Click

    End Sub
    Dim sumflag As Integer = 0
    Public Sub DgvExp_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DgvExp.CellValidating
        rowind = e.RowIndex
        colind = e.ColumnIndex
        Dim newInteger As Integer
        If e.ColumnIndex = 9 Or e.ColumnIndex = 6 Or e.ColumnIndex = 4 Or e.ColumnIndex = 2 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then
            If Me.DgvExp.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                    MsgBox("Please Enter Numeric Values Only")
                End If


                If Not Integer.TryParse(e.FormattedValue.ToString(), newInteger) OrElse newInteger < 0 Then
                    e.Cancel = True
                    DgvExp.Rows(e.RowIndex).ErrorText = "the value must be a non-negative integer"
                    MsgBox("Negative Numbers are not allowed")
                End If

                'If Not IsNumeric(e.FormattedValue < 0) Then
                '    e.Cancel = True
                '    MsgBox("Please Enter Numeric Values Only")
                'End If

            End If
        End If
        If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
            sumflag = 1
            'Class1.formulaflag = 1
        End If

        If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Then
            sumflag = 0
            Label4.Text = ""
        End If

        If e.ColumnIndex = 10 Then
            Class1.HsCodeCP = 1
            Class1.IndexPos = 1
            Class1.formulaflag = 0
            Class1.FormulaIndexPos = 0
            Class1.replaceflag = 0

        End If

        If e.ColumnIndex = 7 Then
            updatevalue = 1
            Class1.formulaflag = 1
            Class1.FormulaIndexPos = 1
            Class1.replaceflag = 1

        End If
    End Sub
    Dim RowVal As Integer
    Dim i As Integer
    Dim cb As Integer
    Dim selectedCellCount As Integer
    Dim GetImpRowRecNo As Integer
    Dim updatevalue As Integer = 0
    Public Sub DgvExp_Selectionchanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvExp.SelectionChanged

        With DgvExp

            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label7.Visible = False
            Label17.Visible = False
            Try
                If (Class1.Isclear <> 1) Then
                    Class1.Isclear = 0
                    'func()
                    'selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)
                    'If selectedCellCount < 2 Then
                    '    MessageBox.Show("hre")
                    '    MessageBox.Show(selectedCellCount)
                    '    Exit Sub
                    'End If
                    If Class1.replaceflag = 1 Then
                        selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)

                        'MessageBox.Show(Class1.ValueArray(i))
                        'MessageBox.Show(Class1.RowNoArray(i))

                        For i = 0 To selectedCellCount - 1
                            RowVal = DgvExp.SelectedCells(i).Value.ToString

                            'RowVal = DgvImp.SelectedCells(i)..ToString
                            'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                            Class1.rowindx = DgvExp.CurrentRow.Index
                            Class1.colindx = DgvExp.Columns("ExpQty").Index
                            'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                            'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                            Dim p11 = DgvExp.CurrentCell.RowIndex
                            Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(1).Value

                            Dim p1 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
                            'p1 = quantity

                            Dim p2 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(8).Value
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
                        selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)

                        'MessageBox.Show(Class1.ValueArray(i))
                        'MessageBox.Show(Class1.RowNoArray(i))

                        For i = 0 To selectedCellCount - 1
                            RowVal = DgvExp.SelectedCells(i).Value.ToString

                            'RowVal = DgvImp.SelectedCells(i)..ToString
                            'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                            Class1.rowindx = DgvExp.CurrentRow.Index
                            Class1.colindx = DgvExp.Columns("ExpHs").Index
                            'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                            'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                            Dim p11 = DgvExp.CurrentCell.RowIndex
                            Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(1).Value
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
                    If sumflag = 1 Then
                        Dim SumValue As Integer = 0
                        Dim ct As ULong = 0

                        For Each Cell As DataGridViewCell In DgvExp.SelectedCells

                            Try


                                For i = 0 To selectedCellCount - 1
                                    Dim p22 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
                                    Dim sumv As Integer = sumv + p22
                                    Label11.Text = sumv



                                Next i
                            Catch ex As Exception

                            End Try


                            If Cell.Value.ToString() = "".ToString() Then
                                SumValue = SumValue + 0
                                'sumflag = 0
                                ct = ct + 0

                            Else

                                SumValue = SumValue + Cell.Value
                                If Cell.Value.ToString = "" Then
                                    SumValue = SumValue + 0
                                End If
                                ct = ct + 1
                                'SumValue = SumValue + Cell.Value
                                ''sumflag = 0
                            End If
                        Next

                        Label4.Text = SumValue
                        'Label11.Text = SumValue / ct

                        selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)

                        'MessageBox.Show(Class1.ValueArray(i))
                        'MessageBox.Show(Class1.RowNoArray(i))

                        For i = 0 To selectedCellCount - 1
                            RowVal = DgvExp.SelectedCells(i).Value.ToString

                            'RowVal = DgvImp.SelectedCells(i)..ToString
                            'Dim p = DgvImp.Rows(i).Cells(0).Value.ToString
                            Class1.rowindx = DgvExp.CurrentRow.Index
                            Class1.colindx = DgvExp.Columns("ExpQty").Index
                            'Class1.colindx = DgvImp.CurrentCellAddress.ToString()
                            'DgvImp.SelectedRows(Class1 .rowindx).Selected=True
                            Dim p11 = DgvExp.CurrentCell.RowIndex
                            Dim p = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(1).Value
                            Dim p1 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(7).Value
                            Dim p2 = DgvExp.Rows(DgvExp.SelectedCells(i).RowIndex).Cells(8).Value
                            Class1.ValueArray(i) = p2
                            Class1.RowNoArray(i) = p
                            Class1.QtyArray(i) = p1

                            cb = selectedCellCount - 1
                            Class1.SelectedCellCount = cb
                            'MessageBox.Show(Class1.ValueArray(i))
                            'MessageBox.Show(Class1.RowNoArray(i))


                        Next i
                        Class1.formulaflag = 0
                        Label9.Text = ct
                        'sumflag = 0
                    End If

                    Try
                        If (Class1.searchcontrol <> 1) Then
                            'Class1.rowindx = DgvExp.CurrentRow.Index
                        End If
                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception

            End Try


            If (Class1.Isclear = 1) Then
                Class1.Isclear = 0
            End If

        End With


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Me.DataGridView1.SearchController.SearchColumns.Add("User Name")
        Dim userclass As String
        Dim Obj As New SupervisorDashboard
        userclass = SupervisorDashboard.TradeType
        If (userclass = "Exports") Then
            Try
                'Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"

                'Me.ImportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%'"
                Me.ExportDataBindingSource.Filter = "CNT Like '%" & TextBox1.Text & "%' and hs like '%" & TextBoxSearch.Text & "%'"
            Catch abc As Exception
                'MessageBox.Show("Sorry! Searched Country does not Exist.")
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Dim CHeckForHighlight As Integer
    Dim value As Integer
    Dim rowindex As Integer
    Dim columnindex As Integer
    Private Sub DgvExp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellClick
        With DgvExp
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            Label7.Visible = False
            Label17.Visible = False
            Label11.Text = ""
            func()
            Class1.rowindx = e.RowIndex
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

                'Reference the GridView Row.
                Dim row As DataGridViewRow = DgvExp.Rows(e.RowIndex)

                'Set the CheckBox selection.
                row.Cells("UnSRec").Value = Convert.ToBoolean(row.Cells("UnSRec").EditedFormattedValue)
                Dim GetExpRowRecNo1 As Integer = .CurrentRow.Cells("ExpSNo").Value()
                'Dim CS As String = Convert.ToString(Me.ImportDataTableAdapter.CheckStatus(GetExpRowRecNo1))
                Dim CS As String = Convert.ToString(Me.ExportDataTableAdapter.GetUpdatedStatusExport(GetExpRowRecNo1))
                'If CS = True And Class1.UnRec = 0 Or Class1.UnRec = 1 Then
                If CS = "" Then
                    'row.Cells("UnsureRec").Value = False
                    'Me.ImportDataTableAdapter.UpdateTradeType(GetExpTT, GetExpRowRecNo, Class1.YY, Class1.MM)
                    Me.ExportDataTableAdapter.UpdateStatusExport(1, GetExpRowRecNo1)
                    'Class1.UnRec = 1
                    'Exit Sub
                End If
                'If row.Cells("UnsureRec").Value = False Then
                '    MessageBox.Show(" checked now")
                '    Exit Sub
                If CS = "True" Then
                    'row.Cells("UnsureRec").Value = True
                    Me.ExportDataTableAdapter.UpdateStatusExport(0, GetExpRowRecNo1)
                    'Class1.UnSRec = 1
                    Exit Sub
                End If

                'End If
                'If CheckBox is checked, display Message Box.
                'If Convert.ToBoolean(row.Cells("UnsureRec").Value) Then
                '    MessageBox.Show(("Selected ID: " & row.Cells(12).Value))
                'End If
            End If

            If e.ColumnIndex = 8 Or e.ColumnIndex = 6 Or e.ColumnIndex = 3 Or e.ColumnIndex = 1 Then
                'e.CellStyle.ForeColor = Color.Black

                'Dim FGAll As Color = DgvExp.DefaultCellStyle.ForeColor
                Dim BGAll As Color = DgvExp.DefaultCellStyle.BackColor


                Dim colr As String
                colr = BGAll.ToString()

                Dim BGAll1 As Color = .CurrentCell.Style.BackColor
                Dim bgg As String = BGAll1.ToString()


                'col = DgvExp.CurrentCell.Style.ForeColor
                'col = .CurrentCell.Style.ForeColor
                If colr = "Color [Window]" Then
                    value = 1
                End If





                If DgvExp.DefaultCellStyle.BackColor = Color.Silver Then
                    value = 2
                End If
                CHeckForHighlight = 1
            End If
            If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
                sumflag = 1

                Try


                    Label4.Text = .CurrentCell.Value
                Catch ex As Exception

                End Try
            End If

            If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Then
                sumflag = 0
                Label4.Text = ""
            End If

            'value = (DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
            'rowindex = (DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).ColumnIndex.ToString())
            'columnindex = (DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex).RowIndex.ToString())
            'func()
        End With
    End Sub

    Private Sub DgvExp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DgvExp.PreviewKeyDown
        'MessageBox.Show("hell2o")
    End Sub

    Private Sub DgvExp_DragOver(sender As Object, e As DragEventArgs) Handles DgvExp.DragOver
        'MessageBox.Show("drag")
    End Sub

    Private Sub DgvExp_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvExp.KeyDown
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label7.Visible = False
        Label17.Visible = False




    End Sub

    Private Sub DgvExp_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvExp.CellMouseUp
        'MessageBox.Show("mouseup")
    End Sub

    Private Sub DgvExp_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvExp.CellMouseDown
        'MessageBox.Show("mousedown")
        'For Each cell As DataGridViewCell In DgvExp.SelectedCells
        '    If cell.ColumnIndex = theIndexOfTheDesiredColumn Then
        '        dblTotal += Double.Parse(cell.Value.ToString)
        '    End If
        'Next
    End Sub

    Private Sub DgvExp_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles DgvExp.CellParsing
        'MessageBox.Show("mouseparsing")

    End Sub
    Dim highligh As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With DgvExp
            highligh = 1


        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With DgvExp
            .CurrentCell.Style.BackColor = Color.Silver
            .CurrentCell.Style.ForeColor = Color.Black
        End With
    End Sub

    Private Sub DgvExp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellDoubleClick
        With DgvExp
            'MessageBox.Show("double click")

            'If e.ColumnIndex = 7 Then
            '    Me.DgvExp.CurrentCell = DgvExp.Rows(e.RowIndex).Cells(e.ColumnIndex)
            '    Class1.rowindx = e.RowIndex
            '    Class1.colindx = e.ColumnIndex
            '    Dim GetExpRowRecNo As Integer = .CurrentRow.Cells("ExpSNo").Value()
            '    Dim val As Integer = .CurrentRow.Cells("ExpVal").Value()
            '    Class1.value = val
            '    Class1.tT = 3
            '    Class1.replaceflag = 0
            '    Class1.formulaflag = 0
            '    Class1.IndexPos = 0
            '    Class1.RecNo = GetExpRowRecNo
            '    RoundFormula.Show()
            '    Me.Close()

            'End If

            func()

        End With
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Try
            'If TextBox3.Text = 0 Then
            '    TextBox3.Text = "True"
            'End If


            Me.ExportDataBindingSource.Filter = "UnSRec Like '%" & TextBox5.Text & "%'"
        Catch abc As Exception
            MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
        End Try
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

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxSearch.Text = ""
        Class1.CntSearchbox = ""
        TextBoxSearch.Text = ""
        Class1.hssearchbox = ""
        TextBox5.Text = ""
        Class1.searchcontrol = 1
        'DgvExp.Rows.Clear()
        'DgvExp.DataSource = Nothing
        'DgvExp.DataSource = Nothing
        'DgvExp.Clear()
        Class1.Isclear = 1
        'EditExports_Load(sender, e)
        Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
        'DgvExp.DataSource = Me.ExportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ExportData, Class1.GetUserID, Class1.YY, Class1.MM)
    End Sub
    'Dim updatevalue As Integer = 0
    Private Sub Replace_Click(sender As Object, e As EventArgs) Handles Replace.Click
        With DgvExp
            Class1.hssearchbox = TextBoxSearch.Text
            Class1.CntSearchbox = TextBox1.Text
            selectedCellCount = DgvExp.GetCellCount(DataGridViewElementStates.Selected)
            If selectedCellCount < 2 Then
                Exit Sub
            End If

            'Replace Button
            Try

                If Class1.HsCodeCP = 1 Then
                    Class1.tT = 3
                    Class1.HsCodeCP = 1
                    RoundFormula.Show()

                    Me.Close()
                End If
                If (colind = 7) Then
                    'If updatevalue = 1 Then
                    If Class1.formulaflag = 1 Then

                        Class1.tT = 3
                        'Class1.RecNo = GetExpRowRecNo
                        Class1.formulaflag = 1
                        Me.Close()
                        RoundFormula.Show()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If

                    If Class1.roundFormulaIndex = 1 Then

                        Class1.tT = 3
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
        With DgvExp
            'Replace Button
            Try
                Class1.hssearchbox = TextBoxSearch.Text
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
                        RoundFormula.Show()


                        'Me.ImportDataTableAdapter.FillByUser(Me.TradeStatisticsDataSet.ImportData, Class1.GetUserID, Class1.YY, Class1.MM)



                    End If
                End If
            Catch ex As Exception

            End Try


        End With
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs)


        'Me.ImportDataBindingSource.Filter = "hs Like '%" ,"CNT Like '%" & TextBoxSearch.Text & "%'"  & TextBoxSearch.Text & "%'"
        '

    End Sub

    'Private Sub TextBox3_TextChanged_2(sender As Object, e As EventArgs)
    '    Try
    '        'If TextBox3.Text = 0 Then
    '        '    TextBox3.Text = "True"
    '        'End If
    '        Me.ImportDataBindingSource.Filter = "UnSRec Like '%" & TextBox3.Text & "%'"
    '    Catch abc As Exception
    '        MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
    '    End Try
    'End Sub

    'Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        'If TextBox3.Text = 0 Then
    '        '    TextBox3.Text = "True"
    '        'End If
    '        Me.ImportDataBindingSource.Filter = "UnSRec Like '%" & TextBox4.Text & "%'"
    '    Catch abc As Exception
    '        MessageBox.Show("Sorry! Searched User_Name does Not Exist.")
    '    End Try
    'End Sub



    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBoxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSearch.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub DgvExp_Enter(sender As Object, e As EventArgs) Handles DgvExp.Enter
        'func()
    End Sub

    Private Sub DgvExp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvExp.CellEnter
        'func()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class