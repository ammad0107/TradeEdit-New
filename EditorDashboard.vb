Public Class EditorDashboard
    Private Sub EditorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.Months' table. You can move, or remove it, as needed.
        Me.MonthsTableAdapter.Fill(Me.TradeStatisticsDataSet.Months)

        Lbl_UserName.Text = Class1.U_Name
        If (Class1.Role = "indexeditor") Then
            Label1.Visible = False
            LblImports.Visible = False
            LblExports.Visible = False
            LblImp.Visible = False

            LblExp.Visible = False

            LblRemExp.Visible = False
            LblImpComp.Visible = False
            LblImpRem.Visible = False

            LblExpComp.Visible = False
            LblExpRem.Visible = False
            LblValImp.Visible = False
            LblValExp.Visible = False
            LblRemImp.Visible = False
            LblCompExp.Visible = False
            LblCompImp.Visible = False

            ComboBox1.SelectedIndex = -1
            ComboBox1.Text = "Select Base"

            CmbMM.SelectedIndex = -1
            CmbMM.Text = "Select Month"

            CmbYY.SelectedIndex = -1
            CmbYY.Text = "Select Year"

            ComboBox2.SelectedIndex = -1
            ComboBox2.Text = "Select Trade Type"

        Else
            Label4.Visible = False
            'Label5.Visible = False
            CmbMM.Visible = False
            CmbYY.Visible = False
            'ComboBox2.Visible = False
            ComboBox1.Visible = False
            'Label2.Visible = False
            'Label3.Visible = False
            LblMM.Visible = False
            LblYY.Visible = False
            Label2.Visible = False
            ComboBox2.Visible = False



        End If
        'Dim previousDate As Date = DateTime.Now.AddMonths(-1)
        'Class1.previousMonth = Month(previousDate)
        'Class1.preYear = Year(previousDate)
        'Class1.previousYear = Class1.preYear.ToString()
        'Class1.previousYear = Class1.previousYear.Substring(2, 2)

        'Me.LblValImp.Text = Me.ImportDataTableAdapter.CountByUser(Class1.GetUserID, Class1.YY, Class1.MM)
        'Me.LblValExp.Text = Me.ExportDataTableAdapter.CountByUser(Class1.GetUserID, Class1.YY, Class1.MM)

        'Get month and year.
        If Me.SupervisorWorkTableAdapter.FillRec_usr(Me.TradeStatisticsDataSet.SupervisorWork, Class1.GetUserID) > 0 Then
            Class1.MM = Me.SupervisorWorkBindingSource.Current("MM1").ToString
            'Class1.Mon = Me.SupervisorWorkBindingSource.Current("MM1").ToString
            Class1.YY = Me.SupervisorWorkBindingSource.Current("YY1").ToString
            'Class1.YY = Me.SupervisorWorkBindingSource.Current("YY").ToString
            Class1.tT = Me.SupervisorWorkBindingSource.Current("TT1").ToString
            ''MsgBox(Class1.MM & Class1.YY & Class1.tT & Class1.GetUserID)


        Else

            If (Class1.Role <> "indexeditor") Then
                MsgBox("No Records for Editing")
            End If
            Exit Sub
            End If

            If Class1.tT = 1 Then
            SupervisorDashboard.TradeType = "Imports"

        ElseIf Class1.tT = 3 Then
            SupervisorDashboard.TradeType = "Exports"
        End If

        Me.LblValImp.Text = Me.SupervisorWorkTableAdapter.EditorAsgnCnt(1, Class1.GetUserID)
        Me.LblValExp.Text = Me.SupervisorWorkTableAdapter.EditorAsgnCnt(3, Class1.GetUserID)

        LblImpComp.Text = Me.SupervisorWorkTableAdapter.GetCompImp(Class1.GetUserID)
        LblImpRem.Text = Me.SupervisorWorkTableAdapter.GetRemImp(Class1.GetUserID)
        LblExpComp.Text = Me.SupervisorWorkTableAdapter.GetCompExp(Class1.GetUserID)
        LblExpRem.Text = Me.SupervisorWorkTableAdapter.GetRemExp(Class1.GetUserID)

    End Sub

    Private Sub BtnEditImp_Click(sender As Object, e As EventArgs) Handles BtnEditImp.Click


        'Class1.BaseValue =
        If (Class1.Role = "indexeditor") Then

            If CmbMM.SelectedIndex > -1 And CmbYY.SelectedIndex > -1 And ComboBox1.SelectedIndex > -1 And ComboBox2.SelectedIndex > -1 Then


                Class1.BaseMonth = CmbMM.Text
                Class1.BaseYear = CmbYY.SelectedItem
                'Class1.NewbaseMonth = ComboBox2.Text
                Class1.BaseType = ComboBox1.Text
                Class1.TradeType = ComboBox2.Text
                If Class1.TradeType = "Import " Then
                    Me.Hide()
                    IndexEditingImport.Show()
                ElseIf Class1.TradeType = "Export" Then
                    Me.Hide()
                    IndexEditingExport.Show()
                End If
            End If
        End If
        If Class1.tT = 1 Then
            Me.Hide()
            EditImports.Show()
        ElseIf Class1.tT = 3 Then
            Me.Hide()
            EditExports.Show()
        End If
    End Sub


    Private Sub EditorDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        LoginTrade.Show()
        End
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Try


            Dim opt As Integer = MessageBox.Show("Are You Sure to Log Out ?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If opt = 6 Then
                Application.Exit()
                End
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImportDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ImportDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TradeStatisticsDataSet)

    End Sub

    Private Sub LblImports_Click(sender As Object, e As EventArgs) Handles LblImports.Click

    End Sub

    Private Sub Lbl_UserName_Click(sender As Object, e As EventArgs) Handles Lbl_UserName.Click

    End Sub
End Class