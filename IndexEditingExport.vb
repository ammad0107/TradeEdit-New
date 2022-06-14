Public Class IndexEditingExport
    Private Sub IndexEditingExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            Dim basemonth = Class1.BaseMonth
            'Class1.YY = Class1.Year
            Dim baseyear = Class1.BaseYear.ToString.Substring(2, 2)
            'Class1.NewbaseMonth = ComboBox2.Text
            Dim basetype = Class1.BaseType
            Label2.Text = basetype + " BASE"
            Dim tradetype = Class1.TradeType
            Dim month As Integer = Class1.MonthNametoInteger(basemonth)
            'Me.DataGridView1.Rows(e.RowIndex).Cells("SERIALDataGridViewTextBoxColumn").Value = (e.RowIndex + 1).ToString()
            'Me.Index_exportTableAdapter1.
            Me.Index_exportTableAdapter1.Fill(Me.TradeStatisticsDataSet.index_export, baseyear, month, basetype)
            If (basetype = "NEW") Then
                DataGridView1.Columns(0).Visible = True

                For i = 0 To DataGridView1.Rows.Count - 2
                    'data(e)
                    Me.DataGridView1.Rows(i).Cells("SERIALDataGridViewTextBoxColumn").Value = (i + 1).ToString()

                Next i
                'DataGridView1.Columns(0).autoincrement = True
            End If

            If (basetype = "OLD") Then
                DataGridView1.Columns(0).Visible = True
            End If
            LblHeading.Visible = True
            LblValExp.Text = DataGridView1.Rows.Count - 1
        End With
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        'Try
        Me.IndexexportBindingSource.Filter = "CODE Like '%" & TextBoxSearch.Text & "%'"
        '    'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%' "
        '    'Me.ExportDataBindingSource.Filter = "hs Like '%" & TextBoxSearch.Text & "%' and CNT like '%" & TextBox1.Text & "%'"
        'Catch abc As Exception
        '    'MessageBox.Show("Sorry! Searched HS_Code does not Exist.")
        'End Try
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        Try


            If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        Try


            If e.ColumnIndex = 9 Then
                If Me.DataGridView1.IsCurrentCellDirty Then
                    If Not IsNumeric(e.FormattedValue) Then
                        e.Cancel = True
                        MsgBox("Please Enter Numeric Values Only")
                    End If

                End If
            End If

            If e.ColumnIndex = 9 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
                sumflag = 1


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        With DataGridView1

            Try


                If e.RowIndex <= .Rows.Count - 1 Then

                    Dim month As Integer = Class1.MonthNametoInteger(Class1.BaseMonth)

                    If e.ColumnIndex = .Columns.IndexOf(.Columns("QUANTITY1DataGridViewTextBoxColumn")) Then


                        Dim YY As Integer = .CurrentRow.Cells("YYDataGridViewTextBoxColumn").Value()
                        Dim MM As Integer = .CurrentRow.Cells("MMDataGridViewTextBoxColumn").Value()
                        Dim CODE As String = .CurrentRow.Cells("CODEDataGridViewTextBoxColumn").Value()
                        Dim BASE As String = .CurrentRow.Cells("BASEDataGridViewTextBoxColumn").Value()

                        Dim GetQty As Integer = .CurrentCell.Value
                        Me.Index_exportTableAdapter.UpdateQuantityIndexExport(GetQty, YY, MM, CODE, BASE)
                        Me.Index_exportTableAdapter.UpdateUnitValIndexExport(YY, MM, CODE, BASE)

                        Try


                            Dim unitvalue As Integer = Me.Index_exportTableAdapter.GetunitValueIndexExport(YY, MM, CODE, BASE)
                            DataGridView1.Rows(e.RowIndex).Cells(11).Value = unitvalue
                        Catch ex As Exception

                        End Try

                    End If

                End If
            Catch ex As Exception

            End Try
        End With
    End Sub
    Dim sumflag As Integer = 0
    Dim RowVal As Integer
    Dim selectedCellCount As Integer
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        'Dim IndexEditingImport = New IndexEditingImport()
        'IndexEditingImport.Close()
        EditorDashboard.Dispose()
        EditorDashboard.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try


            If e.ColumnIndex = 9 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
                sumflag = 1


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try


            If sumflag = 1 Then
                Dim SumValue As Integer = 0
                Dim ct As ULong = 0

                For Each Cell As DataGridViewCell In DataGridView1.SelectedCells
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
                Label11.Text = SumValue / ct

                selectedCellCount = DataGridView1.GetCellCount(DataGridViewElementStates.Selected)




                'Next i
                Class1.formulaflag = 0
                Label9.Text = ct
                'sumflag = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub data(e As DataGridViewRowPostPaintEventArgs)
        With DataGridView1

            Me.DataGridView1.Rows(e.RowIndex).Cells("SERIALDataGridViewTextBoxColumn").Value = (e.RowIndex + 1).ToString()
        End With
    End Sub
    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        'With DataGridView1
        '    If (Class1.BaseType = "NEW") Then
        '        Me.DataGridView1.Rows(e.RowIndex).Cells("SERIALDataGridViewTextBoxColumn").Value = (e.RowIndex + 1).ToString()
        '    End If


        'End With

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class