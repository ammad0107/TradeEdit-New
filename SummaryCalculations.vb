Public Class SummaryCalculations
    Private Sub SummaryCalculations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HsDesc.hscode' table. You can move, or remove it, as needed.
        Me.HscodeTableAdapter2.Fill(Me.HsDesc.hscode)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ImportData' table. You can move, or remove it, as needed.
        'Me.ImportDataTableAdapter.Fill(Me.TradeStatisticsDataSet.ImportData)
        ''TODO: This line of code loads data into the 'TradeStatisticsDataSet.ImportSummary' table. You can move, or remove it, as needed.
        'Me.ImportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ImportSummary)
        ''TODO: This line of code loads data into the 'TradeStatisticsDataSet.ExportSummary' table. You can move, or remove it, as needed.
        'Me.ExportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportSummary)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.Hscode' table. You can move, or remove it, as needed.
        'Me.HscodeTableAdapter.Fill(Me.TradeStatisticsDataSet.Hscode)
        Label2.Text = Class1.value.ToString()
        Dim sno As Integer = Class1.RecNo
        If Class1.HsCodeCP = 1 Then
            Class1.formulaflag = 0
            Class1.FormulaIndexPos = 0
            ComboBox1.Visible = True
            NumericUpDown1.Visible = False
        End If

        If Class1.formulaflag = 1 Or Class1.roundFormulaIndex = 1 Then
            Class1.IndexPos = 0
            Class1.HsCodeCP = 0
            NumericUpDown1.Visible = True
            ComboBox1.Visible = False
        End If

        Try

        Catch ex As Exception
            'TextboxValue = Convert.ToInt32(NumericUpDown1.Text)
        End Try

    End Sub
    Dim TextboxValue As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inqq As String = Trim(NumericUpDown1.Text)
        'Dim inqq1 As String = Trim(NumericUpDown1.Text)
        Dim intValue As Integer
        Dim r As Double
        Try






            If Class1.HsCodeCP = 1 Then

                For i = 0 To Class1.SelectedCellCount


                    Dim hs As String = ComboBox1.SelectedValue.ToString()
                    Dim CheckHS As Integer = Me.ImportDataTableAdapter.CheckkHS(ComboBox1.SelectedValue.ToString())
                    'Dim CheckHS1 As Integer = Me.HscodeTableAdapter.CheckHS(GetImpHS)
                    If CheckHS > 0 Then
                        'If 0 > 0 Then


                        If Class1.ExportSummaryFlag = 1 Or Class1.ImportSummaryFlag = 1 Then
                            If Class1.tT = 3 Then

                                'Me.ExportDataTableAdapter.UpdateQuantity(ComboBox1.SelectedValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)

                                Me.ExportSummaryTableAdapter.UpdateHsCodeExportSummary(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                'Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                Me.ExportSummaryTableAdapter.UpdateUnitHDescExportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                            End If

                            If Class1.tT = 1 Then

                                'Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                Me.ImportSummaryTableAdapter.UpdateImportSummaryHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                Me.ImportSummaryTableAdapter.UpdateUnitHDescImportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                                Me.ImportSummaryTableAdapter.UpdatedUpdatedImportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                            End If
                        End If




                        'If Class1.tT = 3 Then

                        '    'Me.ExportDataTableAdapter.UpdateQuantity(ComboBox1.SelectedValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)

                        '    Me.ExportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    'Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    Me.ExportDataTableAdapter.UpdateUnitHsDesc(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                        'End If

                        'If Class1.tT = 1 Then

                        '    'Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    Me.ImportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    Me.ImportDataTableAdapter.UpdateUnitHsDesc(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        '    Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                        'End If
                    Else

                        '.CurrentCell.Style.BackColor = Color.Red
                        '.CurrentCell.Style.ForeColor = Color.White
                        MsgBox("The Entered HS-Code does not Exist in our database")


                    End If



                Next i
                If Class1.tT = 1 Then
                    'Me.Close()
                    'Dim obj As EditImportSummary = New EditImportSummary()
                    'obj.Show()
                    'Dim sum As SummaryCalculations = New SummaryCalculations()
                    'sum.Dispose()
                    'Dim obj As EditImportSummary = New EditImportSummary()
                    'obj.Show()

                    'Dim obj1 As EditImportSummary = New EditImportSummary()
                    'obj1.Show()
                    Dim sum As SummaryCalculations = New SummaryCalculations()
                    sum.Close()

                End If
                If Class1.tT = 3 Then
                    'Me.Close()
                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Show()

                    'Dim obj2 As EditImportSummary = New EditImportSummary()
                    'obj2.Show()
                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Show()

                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Show()
                    Dim sum As SummaryCalculations = New SummaryCalculations()
                    sum.Close()
                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Show()
                    'Dim sum As SummaryCalculations = New SummaryCalculations()
                    'sum.Dispose()

                End If

            End If

            'End here
            If Class1.value <> 0 Then
                Class1.replaceflag = 0
                Class1.formulaflag = 0
            End If


            If Class1.replaceflag = 1 Or Class1.value <> 0 Then
                If NumericUpDown1.Text = "" Then
                    Exit Sub
                End If

                If NumericUpDown1.Text < 0 Then
                    Exit Sub

                End If



                If NumericUpDown1.Text > 1000000 Then
                    Exit Sub

                End If

            End If
            If Class1.formulaflag = 1 Then
                If NumericUpDown1.Text = "" Then
                    Exit Sub
                End If

                If NumericUpDown1.Text < 0 Then
                    Exit Sub

                End If



                If NumericUpDown1.Text > 1000000 Then
                    Exit Sub

                End If


                For i = 0 To Class1.SelectedCellCount

                    'MessageBox.Show(Class1.RowNoArray(0))
                    'MessageBox.Show(Class1.ValueArray(0))
                    'MessageBox.Show(Class1.RowNoArray(1))
                    'MessageBox.Show(Class1.ValueArray(1))
                    'MessageBox.Show(Class1.RowNoArray(2))
                    'MessageBox.Show(Class1.ValueArray(2))



                    'MessageBox.Show(Class1.ValueArray(i))

                    'If i = 0 Then
                    '    TextboxValue = NumericUpDown1.Text
                    'End If


                    If Class1.tT = 3 Then

                        Me.ExportSummaryTableAdapter.UpdateQuantityExportSummary(Convert.ToInt32(NumericUpDown1.Text), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        Me.ExportSummaryTableAdapter.UpdateUnitHsDescExportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Class1.formulaflag = 0
                        'Dim obj As EditExports = New EditExports()
                        'obj.Show()


                    End If


                    If Class1.tT = 1 Then

                        Me.ImportDataTableAdapter.UpdateQuantityImportSummary(Convert.ToInt32(NumericUpDown1.Text), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        Me.ImportSummaryTableAdapter.UpdateUnitHsDescImportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        Me.ImportSummaryTableAdapter.UpdatedUpdatedImportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)

                        'Class1.formulaflag = 0
                        'Dim obj As EditImports = New EditImports()
                        'obj.Show()



                    End If
                Next i

                If Class1.tT = 1 Then
                    'Me.Close()
                    'Dim obj As EditImportSummary = New EditImportSummary()
                    'obj.Show()

                    'Dim obj1 As EditImportSummary = New EditImportSummary()
                    'obj1.Show()
                    Dim sum As SummaryCalculations = New SummaryCalculations()
                    sum.Close()

                End If
                If Class1.tT = 3 Then
                    'Me.Close()
                    'Dim obj2 As EditExportSummary = New EditExportSummary()
                    'obj2.Show()
                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Show()

                    'Dim obj As EditExportSummary = New EditExportSummary()
                    'obj.Show()
                    Dim sum As SummaryCalculations = New SummaryCalculations()
                    sum.Close()


                End If

            End If


            'XComment start

            'If Class1.replaceflag = 1 Or Class1.value <> 0 Then
            '    For i = 0 To Class1.SelectedCellCount
            '        'MessageBox.Show(Class1.RowNoArray(0))
            '        'MessageBox.Show(Class1.QtyArray(0))
            '        'MessageBox.Show(Class1.RowNoArray(1))
            '        'MessageBox.Show(Class1.QtyArray(1))
            '        'MessageBox.Show(Class1.RowNoArray(2))
            '        'MessageBox.Show(Class1.QtyArray(2))
            '        'If (Class1.ValueArray(i) = "") Then
            '        '    Class1.ValueArray(i) = 0
            '        'End If


            '        TextboxValue = Convert.ToInt32(NumericUpDown1.Text)
            '        Dim result As Integer
            '        If (Class1.value <> 0) Then
            '            result = Convert.ToInt32(Class1.value / Convert.ToInt32(NumericUpDown1.Text))
            '            r = Math.Ceiling(result)
            '            If Class1.tT = 3 Then

            '                Me.ExportSummaryTableAdapter.UpdateQuantityExportSummary(r, Class1.RecNo, Class1.YY, Class1.MM)
            '                Me.ExportSummaryTableAdapter.UpdateUnitHsDescExportSummary(Class1.RecNo, Class1.YY, Class1.MM)
            '                Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(Class1.RecNo, Class1.YY, Class1.MM)
            '                'Class1.replaceflag = 0



            '            End If


            '            'If Class1.tT = 1 Then

            '            '    Me.ImportSummaryTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
            '            '    Me.ImportSummaryTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
            '            '    Me.ImportSummaryTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
            '            '    'Class1.replaceflag = 0
            '            '    'Me.Close()
            '            '    'Dim obj As EditExports = New EditExports()
            '            '    'obj.Show()

            '            'End If

            '            Class1.value = 0
            '        Else
            '            result = Convert.ToInt32(Class1.ValueArray(i).ToString()) / Convert.ToInt32(NumericUpDown1.Text)
            '        End If

            '        'here
            '        r = Math.Ceiling(result)
            '        'Dim r1 As Double = Convert.ToInt32(Math.Ceiling(result))

            '        If Class1.tT = 3 Then

            '            Me.ExportSummaryTableAdapter.UpdateQuantityExportSummary(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
            '            Me.ExportSummaryTableAdapter.UpdateUnitHsDescExportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
            '            Me.ExportSummaryTableAdapter.UpdateUpdateExportSummary(Class1.RowNoArray(i), Class1.YY, Class1.MM)
            '            'Class1.replaceflag = 0



            '        End If


            '        If Class1.tT = 1 Then

            '            Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
            '            Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
            '            Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
            '            'Class1.replaceflag = 0
            '            'Me.Close()
            '            'Dim obj As EditExports = New EditExports()
            '            'obj.Show()

            '        End If
            '    Next i
            'End If


            'XComment end
            If Class1.tT = 1 Then
                Me.Close()
                'Dim obj As EditImports = New EditImports()
                'obj.Show()

            End If
            If Class1.tT = 3 Then
                Me.Close()
                'Dim obj As EditExportSummary = New EditExportSummary()   uncomment for editing app
                'obj.Show()

            End If
        Catch ex As Exception
            NumericUpDown1.Text = ""

        End Try

        If Class1.ExportSummaryFlag = 1 Then
            EditExportSummary.Close()
            EditExportSummary.Show()
            Class1.ExportSummaryFlag = 0

        End If

        If Class1.ImportSummaryFlag = 1 Then
            EditImportSummary.Close()
            EditImportSummary.Show()
            Class1.ImportSummaryFlag = 0

        End If
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.HscodeTableAdapter1.FillBy(Me.HSCombo.hscode)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SummaryCalculations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'EditImportSummary.Show()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        ''EditorDashboard.Refresh()
        If (Class1.tT = 1) Then
            'EditImportSummary.Dispose()
            EditImportSummary.Show()
        End If

        If (Class1.tT = 3) Then
            'EditExportSummary.Dispose()
            EditExportSummary.Show()
        End If

    End Sub
End Class