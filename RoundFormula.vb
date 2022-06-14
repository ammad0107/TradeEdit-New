Public Class RoundFormula
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RoundFormula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ExportSummary' table. You can move, or remove it, as needed.
        Me.ExportSummaryTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportSummary, Class1.YY, Class1.MM)
        'TODO: This line of code loads data into the 'HSCombo.hscode' table. You can move, or remove it, as needed.
        Me.HscodeTableAdapter.Fill(Me.HSCombo.hscode)
        'TODO: This line of code loads data into the 'HSCode._hscode' table. You can move, or remove it, as needed.
        'Me.HscodeTableAdapter.Fill(Me.HSCode._hscode)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ImportData' table. You can move, or remove it, as needed.
        'Me.ImportDataTableAdapter.Fill(Me.TradeStatisticsDataSet.ImportData)
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.ExportData' table. You can move, or remove it, as needed.
        'Me.ExportDataTableAdapter.Fill(Me.TradeStatisticsDataSet.ExportData)
        Label2.Text = Class1.value.ToString()
        Label4.Text = "Note: 
         Please wait after clicking button, while data is loading"

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
        'Label4.Text = " Data is loading"
        'Label4.Text = "Please wait while data is loading!!!!!"
        Button1.Visible = False
        NumericUpDown1.Visible = False
        ComboBox1.Visible = False
        Dim inqq As String = Trim(NumericUpDown1.Text)
        'Dim inqq1 As String = Trim(NumericUpDown1.Text)
        Dim intValue As Long
        Dim r As Double
        Try






            If Class1.HsCodeCP = 1 Then
                Dim query As String
                For i = 0 To Class1.SelectedCellCount


                    Dim hs As String = ComboBox1.SelectedValue.ToString()
                    Dim CheckHS As Integer = Me.ImportDataTableAdapter.CheckkHS(ComboBox1.SelectedValue.ToString())

                    If CheckHS > 0 Then





                        If Class1.tT = 3 Then



                            Me.ExportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                            Me.ExportDataTableAdapter.UpdateUnitHsDesc(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                            'Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                        End If

                        If Class1.tT = 1 Then

                            Me.ImportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                            Me.ImportDataTableAdapter.UpdateUnitHsDesc(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                            'Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                        End If
                    Else


                        MsgBox("The Entered HS-Code does not Exist in our database")


                    End If



                Next i
                If Class1.tT = 1 Then
                    Me.Close()


                End If
                If Class1.tT = 3 Then
                    Me.Close()


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



                If NumericUpDown1.Text > 1000000000000 Then
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



                If NumericUpDown1.Text > 1000000000000 Then
                    Exit Sub

                End If


                For i = 0 To Class1.SelectedCellCount



                    'Replace on export
                    If Class1.tT = 3 Then

                        Me.ExportDataTableAdapter.UpdateQuantity(Convert.ToInt32(NumericUpDown1.Text), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)



                    End If

                    'Replace on import
                    If Class1.tT = 1 Then



                        Me.ImportDataTableAdapter.UpdateQuantity(Convert.ToInt32(NumericUpDown1.Text), Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)


                    End If
                Next i

                If Class1.tT = 1 Then
                    Me.Close()
                End If

                If Class1.tT = 3 Then
                    Me.Close()
                End If

            End If




            If Class1.replaceflag = 1 Or Class1.value <> 0 Then
                For i = 0 To Class1.SelectedCellCount

                    'general calculation of formula
                    TextboxValue = Convert.ToInt32(NumericUpDown1.Text)
                    Dim result As Long
                    If (Class1.value <> 0) Then
                        result = Convert.ToInt32(Class1.value / Convert.ToInt32(NumericUpDown1.Text))
                        r = Math.Ceiling(result)



                        'RoundFormula on export if any value Is found zero
                        If Class1.tT = 3 Then

                            Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
                            'Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
                            'Me.ExportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)

                        End If

                        'RoundFormula on import if any value Is found zero
                        If Class1.tT = 1 Then

                            Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
                            'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
                            'Me.ImportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)

                        End If

                        Class1.value = 0
                    Else
                        result = Convert.ToInt64(Class1.ValueArray(i).ToString()) / Convert.ToInt64(NumericUpDown1.Text)
                    End If


                    r = Math.Ceiling(result)


                    'applying formula on export
                    If Class1.tT = 3 Then

                        Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

                    End If

                    'applying formula on import
                    If Class1.tT = 1 Then



                        Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
                        'Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)


                    End If
                Next i
            End If

            If Class1.tT = 1 Then
                Me.Close()


            End If
            If Class1.tT = 3 Then
                Me.Close()


            End If
        Catch ex As Exception
            NumericUpDown1.Text = ""

        End Try

    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        'TextboxValue = 0
        'NumericUpDown1.Text = ""

    End Sub
    Private Sub RoundFormula_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Class1.tT = 3 Then
            Dim obj As EditExports = New EditExports()
            obj.Show()
        End If
        If Class1.tT = 1 Then
            Dim obj As EditImports = New EditImports()
            obj.Show()
        End If
    End Sub

    Private Sub ExportDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ExportDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TradeStatisticsDataSet)

    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter

        'Dim intValue As Integer
        'Dim r As Double
        'Try


        '    'MessageBox.Show(Class1.RowNoArray(0))
        '    'MessageBox.Show(Class1.ValueArray(0))
        '    'MessageBox.Show(Class1.RowNoArray(1))
        '    'MessageBox.Show(Class1.ValueArray(1))
        '    'MessageBox.Show(Class1.RowNoArray(2))
        '    'MessageBox.Show(Class1.ValueArray(2))



        '    If Class1.HsCodeCP = 1 Then

        '        For i = 0 To Class1.SelectedCellCount


        '            Dim hs As String = ComboBox1.SelectedValue.ToString()
        '            Dim CheckHS As Integer = Me.ImportDataTableAdapter.CheckkHS(ComboBox1.SelectedValue.ToString())
        '            'Dim CheckHS1 As Integer = Me.HscodeTableAdapter.CheckHS(GetImpHS)
        '            If CheckHS > 0 Then
        '                'If 0 > 0 Then

        '                If Class1.tT = 3 Then

        '                    'Me.ExportDataTableAdapter.UpdateQuantity(ComboBox1.SelectedValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                    Me.ExportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                End If

        '                If Class1.tT = 1 Then

        '                    'Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                End If
        '            Else

        '                '.CurrentCell.Style.BackColor = Color.Red
        '                '.CurrentCell.Style.ForeColor = Color.White
        '                MsgBox("The Entered HS-Code does not Exist in our database")


        '            End If



        '        Next i
        '        'If Class1.tT = 1 Then
        '        '    Me.Close()
        '        '    'Dim obj As EditImports = New EditImports()
        '        '    'obj.Show()

        '        'End If
        '        'If Class1.tT = 3 Then
        '        '    Me.Close()
        '        '    'Dim obj As EditExports = New EditExports()
        '        '    'obj.Show()

        '        'End If

        '    End If

        '    'End here


        '    If Class1.replaceflag = 1 Then
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text <= 0 Then
        '            Exit Sub

        '        End If



        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If

        '    End If
        '    If Class1.formulaflag = 1 Then
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text <= 0 Then
        '            Exit Sub

        '        End If



        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If


        '        For i = 0 To Class1.SelectedCellCount

        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.ValueArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.ValueArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.ValueArray(2))



        '            'MessageBox.Show(Class1.ValueArray(i))

        '            If i = 0 Then
        '                TextboxValue = TextBox1.Text
        '            End If


        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.formulaflag = 0
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()


        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)

        '                'Class1.formulaflag = 0
        '                'Dim obj As EditImports = New EditImports()
        '                'obj.Show()



        '            End If
        '        Next i

        '        If Class1.tT = 1 Then
        '            Me.Close()
        '            'Dim obj As EditImports = New EditImports()
        '            'obj.Show()

        '        End If
        '        If Class1.tT = 3 Then
        '            Me.Close()
        '            'Dim obj As EditExports = New EditExports()
        '            'obj.Show()

        '        End If

        '    End If




        '    If Class1.replaceflag = 1 Then
        '        For i = 0 To Class1.SelectedCellCount
        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.QtyArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.QtyArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.QtyArray(2))
        '            'If (Class1.ValueArray(i) = "") Then
        '            '    Class1.ValueArray(i) = 0
        '            'End If
        '            TextboxValue = Convert.ToInt32(TextBox1.Text)
        '            Dim result As Integer = Convert.ToInt32(Class1.QtyArray(i).ToString()) / Convert.ToInt32(TextboxValue)
        '            r = Math.Ceiling(result)
        '            'Dim r1 As Double = Convert.ToInt32(Math.Ceiling(result))

        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.replaceflag = 0



        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '                'Class1.replaceflag = 0
        '                'Me.Close()
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()

        '            End If
        '        Next i
        '    End If

        '    If Class1.tT = 1 Then
        '        Me.Close()
        '        'Dim obj As EditImports = New EditImports()
        '        'obj.Show()

        '    End If
        '    If Class1.tT = 3 Then
        '        Me.Close()
        '        'Dim obj As EditExports = New EditExports()
        '        'obj.Show()

        '    End If
        'Catch ex As Exception

        'End Try

        'Dim intValue As Integer
        'Dim r As Double
        'Try


        '    ''MessageBox.Show(Class1.RowNoArray(0))
        '    'MessageBox.Show(Class1.ValueArray(0))
        '    ''MessageBox.Show(Class1.RowNoArray(1))
        '    'MessageBox.Show(Class1.ValueArray(1))
        '    ''MessageBox.Show(Class1.RowNoArray(2))
        '    'MessageBox.Show(Class1.ValueArray(2))
        '    If TextBox1.Text = "" Then
        '        Exit Sub
        '    End If

        '    If TextBox1.Text < 0 Then
        '        Exit Sub

        '    End If

        '    If TextBox1.Text > 1000000 Then
        '        Exit Sub

        '    End If
        '    If Class1.formulaflag = 1 Then

        '        For i = 0 To Class1.SelectedCellCount

        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.ValueArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.ValueArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.ValueArray(2))



        '            'MessageBox.Show(Class1.ValueArray(i))

        '            If i = 0 Then
        '                TextboxValue = TextBox1.Text
        '            End If

        '            If TextBox1.Text = 0 Then
        '                'Dim result As Integer = Convert.ToInt32(Class1.ValueArray(i).ToString()) / Convert.ToInt32(TextboxValue)
        '                'r = Math.Ceiling(result)
        '                ''Dim r1 As Double = Convert.ToInt32(Math.Ceiling(result))
        '            End If
        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.formulaflag = 0
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()


        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)

        '                'Class1.formulaflag = 0
        '                'Dim obj As EditImports = New EditImports()
        '                'obj.Show()



        '            End If
        '        Next i

        '        If Class1.tT = 1 Then
        '            Me.Close()
        '            'Dim obj As EditImports = New EditImports()
        '            'obj.Show()

        '        End If
        '        If Class1.tT = 3 Then
        '            Me.Close()
        '            'Dim obj As EditExports = New EditExports()
        '            'obj.Show()

        '        End If

        '    End If




        '    If Class1.replaceflag = 1 Then
        '        If Class1.tT = 3 Then

        '            'Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '            Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '            Me.ExportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '            Class1.replaceflag = 0



        '        End If


        '        If Class1.tT = 1 Then

        '            'Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '            Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '            Me.ImportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '            Class1.replaceflag = 0
        '            Me.Close()
        '            Dim obj As EditImports = New EditImports()
        '            obj.Show()

        '        End If

        '    End If


        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        'If e.KeyCode = Keys.Enter Then
        '    Dim intValue As Integer
        '    Dim r As Double
        '    Try


        '        ''MessageBox.Show(Class1.RowNoArray(0))
        '        'MessageBox.Show(Class1.ValueArray(0))
        '        ''MessageBox.Show(Class1.RowNoArray(1))
        '        'MessageBox.Show(Class1.ValueArray(1))
        '        ''MessageBox.Show(Class1.RowNoArray(2))
        '        'MessageBox.Show(Class1.ValueArray(2))
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text < 0 Then
        '            Exit Sub

        '        End If

        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If
        '        If Class1.formulaflag = 1 Then

        '            For i = 0 To Class1.SelectedCellCount

        '                'MessageBox.Show(Class1.RowNoArray(0))
        '                'MessageBox.Show(Class1.ValueArray(0))
        '                'MessageBox.Show(Class1.RowNoArray(1))
        '                'MessageBox.Show(Class1.ValueArray(1))
        '                'MessageBox.Show(Class1.RowNoArray(2))
        '                'MessageBox.Show(Class1.ValueArray(2))



        '                'MessageBox.Show(Class1.ValueArray(i))

        '                If i = 0 Then
        '                    TextboxValue = TextBox1.Text
        '                End If

        '                If TextBox1.Text = 0 Then
        '                    'Dim result As Integer = Convert.ToInt32(Class1.ValueArray(i).ToString()) / Convert.ToInt32(TextboxValue)
        '                    'r = Math.Ceiling(result)
        '                    ''Dim r1 As Double = Convert.ToInt32(Math.Ceiling(result))
        '                End If
        '                If Class1.tT = 3 Then

        '                    Me.ExportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    'Class1.formulaflag = 0
        '                    'Dim obj As EditExports = New EditExports()
        '                    'obj.Show()


        '                End If


        '                If Class1.tT = 1 Then

        '                    Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)

        '                    'Class1.formulaflag = 0
        '                    'Dim obj As EditImports = New EditImports()
        '                    'obj.Show()



        '                End If
        '            Next i

        '            If Class1.tT = 1 Then
        '                Me.Close()
        '                'Dim obj As EditImports = New EditImports()
        '                'obj.Show()

        '            End If
        '            If Class1.tT = 3 Then
        '                Me.Close()
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()

        '            End If

        '        End If




        '        If Class1.replaceflag = 1 Then
        '            If Class1.tT = 3 Then

        '                'Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '                Class1.replaceflag = 0



        '            End If


        '            If Class1.tT = 1 Then

        '                'Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '                Class1.replaceflag = 0
        '                Me.Close()
        '                Dim obj As EditImports = New EditImports()
        '                obj.Show()

        '            End If

        '        End If


        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        'Dim intValue As Integer
        'Dim r As Double
        'Try


        '    'MessageBox.Show(Class1.RowNoArray(0))
        '    'MessageBox.Show(Class1.ValueArray(0))
        '    'MessageBox.Show(Class1.RowNoArray(1))
        '    'MessageBox.Show(Class1.ValueArray(1))
        '    'MessageBox.Show(Class1.RowNoArray(2))
        '    'MessageBox.Show(Class1.ValueArray(2))



        '    If Class1.HsCodeCP = 1 Then

        '        For i = 0 To Class1.SelectedCellCount


        '            Dim hs As String = ComboBox1.SelectedValue.ToString()
        '            Dim CheckHS As Integer = Me.ImportDataTableAdapter.CheckkHS(ComboBox1.SelectedValue.ToString())
        '            'Dim CheckHS1 As Integer = Me.HscodeTableAdapter.CheckHS(GetImpHS)
        '            If CheckHS > 0 Then
        '                'If 0 > 0 Then

        '                If Class1.tT = 3 Then

        '                    'Me.ExportDataTableAdapter.UpdateQuantity(ComboBox1.SelectedValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                    Me.ExportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                End If

        '                If Class1.tT = 1 Then

        '                    'Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                End If
        '            Else

        '                '.CurrentCell.Style.BackColor = Color.Red
        '                '.CurrentCell.Style.ForeColor = Color.White
        '                MsgBox("The Entered HS-Code does not Exist in our database")


        '            End If



        '        Next i
        '        'If Class1.tT = 1 Then
        '        '    Me.Close()
        '        '    'Dim obj As EditImports = New EditImports()
        '        '    'obj.Show()

        '        'End If
        '        'If Class1.tT = 3 Then
        '        '    Me.Close()
        '        '    'Dim obj As EditExports = New EditExports()
        '        '    'obj.Show()

        '        'End If

        '    End If

        '    'End here


        '    If Class1.replaceflag = 1 Then
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text <= 0 Then
        '            Exit Sub

        '        End If



        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If

        '    End If
        '    If Class1.formulaflag = 1 Then
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text <= 0 Then
        '            Exit Sub

        '        End If



        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If


        '        For i = 0 To Class1.SelectedCellCount

        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.ValueArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.ValueArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.ValueArray(2))



        '            'MessageBox.Show(Class1.ValueArray(i))

        '            If i = 0 Then
        '                TextboxValue = TextBox1.Text
        '            End If


        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.formulaflag = 0
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()


        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)

        '                'Class1.formulaflag = 0
        '                'Dim obj As EditImports = New EditImports()
        '                'obj.Show()



        '            End If
        '        Next i

        '        If Class1.tT = 1 Then
        '            Me.Close()
        '            'Dim obj As EditImports = New EditImports()
        '            'obj.Show()

        '        End If
        '        If Class1.tT = 3 Then
        '            Me.Close()
        '            'Dim obj As EditExports = New EditExports()
        '            'obj.Show()

        '        End If

        '    End If




        '    If Class1.replaceflag = 1 Then
        '        For i = 0 To Class1.SelectedCellCount
        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.QtyArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.QtyArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.QtyArray(2))
        '            'If (Class1.ValueArray(i) = "") Then
        '            '    Class1.ValueArray(i) = 0
        '            'End If
        '            TextboxValue = Convert.ToInt32(TextBox1.Text)
        '            Dim result As Integer = Convert.ToInt32(Class1.QtyArray(i).ToString()) / Convert.ToInt32(TextboxValue)
        '            r = Math.Ceiling(result)
        '            'Dim r1 As Double = Convert.ToInt32(Math.Ceiling(result))

        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.replaceflag = 0



        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '                'Class1.replaceflag = 0
        '                'Me.Close()
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()

        '            End If
        '        Next i
        '    End If

        '    If Class1.tT = 1 Then
        '        Me.Close()
        '        'Dim obj As EditImports = New EditImports()
        '        'obj.Show()

        '    End If
        '    If Class1.tT = 3 Then
        '        Me.Close()
        '        'Dim obj As EditExports = New EditExports()
        '        'obj.Show()

        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub Button1_Enter(sender As Object, e As EventArgs) Handles Button1.Enter
        'Dim intValue As Integer
        'Dim r As Double
        'Try


        '    'MessageBox.Show(Class1.RowNoArray(0))
        '    'MessageBox.Show(Class1.ValueArray(0))
        '    'MessageBox.Show(Class1.RowNoArray(1))
        '    'MessageBox.Show(Class1.ValueArray(1))
        '    'MessageBox.Show(Class1.RowNoArray(2))
        '    'MessageBox.Show(Class1.ValueArray(2))



        '    If Class1.HsCodeCP = 1 Then

        '        For i = 0 To Class1.SelectedCellCount


        '            Dim hs As String = ComboBox1.SelectedValue.ToString()
        '            Dim CheckHS As Integer = Me.ImportDataTableAdapter.CheckkHS(ComboBox1.SelectedValue.ToString())
        '            'Dim CheckHS1 As Integer = Me.HscodeTableAdapter.CheckHS(GetImpHS)
        '            If CheckHS > 0 Then
        '                'If 0 > 0 Then

        '                If Class1.tT = 3 Then

        '                    'Me.ExportDataTableAdapter.UpdateQuantity(ComboBox1.SelectedValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                    Me.ExportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                End If

        '                If Class1.tT = 1 Then

        '                    'Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateHsCode(ComboBox1.SelectedValue.ToString(), Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    'Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                    Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)

        '                End If
        '            Else

        '                '.CurrentCell.Style.BackColor = Color.Red
        '                '.CurrentCell.Style.ForeColor = Color.White
        '                MsgBox("The Entered HS-Code does not Exist in our database")


        '            End If



        '        Next i
        '        'If Class1.tT = 1 Then
        '        '    Me.Close()
        '        '    'Dim obj As EditImports = New EditImports()
        '        '    'obj.Show()

        '        'End If
        '        'If Class1.tT = 3 Then
        '        '    Me.Close()
        '        '    'Dim obj As EditExports = New EditExports()
        '        '    'obj.Show()

        '        'End If

        '    End If

        '    'End here


        '    If Class1.replaceflag = 1 Then
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text <= 0 Then
        '            Exit Sub

        '        End If



        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If

        '    End If
        '    If Class1.formulaflag = 1 Then
        '        If TextBox1.Text = "" Then
        '            Exit Sub
        '        End If

        '        If TextBox1.Text <= 0 Then
        '            Exit Sub

        '        End If



        '        If TextBox1.Text > 1000000 Then
        '            Exit Sub

        '        End If


        '        For i = 0 To Class1.SelectedCellCount

        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.ValueArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.ValueArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.ValueArray(2))



        '            'MessageBox.Show(Class1.ValueArray(i))

        '            If i = 0 Then
        '                TextboxValue = TextBox1.Text
        '            End If


        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.formulaflag = 0
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()


        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(TextboxValue, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Me.ImportDataTableAdapter.UpdateUpdated(GetImpRowRecNo, Class1.YY, Class1.MM)

        '                'Class1.formulaflag = 0
        '                'Dim obj As EditImports = New EditImports()
        '                'obj.Show()



        '            End If
        '        Next i

        '        If Class1.tT = 1 Then
        '            Me.Close()
        '            'Dim obj As EditImports = New EditImports()
        '            'obj.Show()

        '        End If
        '        If Class1.tT = 3 Then
        '            Me.Close()
        '            'Dim obj As EditExports = New EditExports()
        '            'obj.Show()

        '        End If

        '    End If




        '    If Class1.replaceflag = 1 Then
        '        For i = 0 To Class1.SelectedCellCount
        '            'MessageBox.Show(Class1.RowNoArray(0))
        '            'MessageBox.Show(Class1.QtyArray(0))
        '            'MessageBox.Show(Class1.RowNoArray(1))
        '            'MessageBox.Show(Class1.QtyArray(1))
        '            'MessageBox.Show(Class1.RowNoArray(2))
        '            'MessageBox.Show(Class1.QtyArray(2))
        '            'If (Class1.ValueArray(i) = "") Then
        '            '    Class1.ValueArray(i) = 0
        '            'End If
        '            TextboxValue = Convert.ToInt32(TextBox1.Text)
        '            Dim result As Integer = Convert.ToInt32(Class1.QtyArray(i).ToString()) / Convert.ToInt32(TextboxValue)
        '            r = Math.Ceiling(result)
        '            'Dim r1 As Double = Convert.ToInt32(Math.Ceiling(result))

        '            If Class1.tT = 3 Then

        '                Me.ExportDataTableAdapter.UpdateQuantity(r, Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUnitVal(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                Me.ExportDataTableAdapter.UpdateUpdated(Class1.RowNoArray(i), Class1.YY, Class1.MM)
        '                'Class1.replaceflag = 0



        '            End If


        '            If Class1.tT = 1 Then

        '                Me.ImportDataTableAdapter.UpdateQuantity(r, Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUnitVal(Class1.RecNo, Class1.YY, Class1.MM)
        '                Me.ImportDataTableAdapter.UpdateUpdated(Class1.RecNo, Class1.YY, Class1.MM)
        '                'Class1.replaceflag = 0
        '                'Me.Close()
        '                'Dim obj As EditExports = New EditExports()
        '                'obj.Show()

        '            End If
        '        Next i
        '    End If

        '    If Class1.tT = 1 Then
        '        Me.Close()
        '        'Dim obj As EditImports = New EditImports()
        '        'obj.Show()

        '    End If
        '    If Class1.tT = 3 Then
        '        Me.Close()
        '        'Dim obj As EditExports = New EditExports()
        '        'obj.Show()

        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) 
        'Me.Hide()
        '''EditorDashboard.Refresh()
        'If (Class1.tT = 1) Then
        '    EditImportSummary.Dispose()
        '    EditImportSummary.Show()
        'End If

        'If (Class1.tT = 3) Then
        '    EditExportSummary.Dispose()
        '    EditExportSummary.Show()
        'End If

    End Sub
End Class