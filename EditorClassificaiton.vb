Public Class EditorClassificaiton
    Private Sub EditorClassificaiton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'TradeStatisticsDataSet.users' table. You can move, or remove it, as needed.
            Me.UsersTableAdapter.Fill(Me.TradeStatisticsDataSet.users)
            Lbl_UserName.Text = Class1.U_Name
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    'Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
    '    If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
    '        If Me.DataGridView1.IsCurrentCellDirty Then
    '            If Me.DataGridView1.Columns(2).c = CheckState  Not IsNumeric(e.FormattedValue) Then
    '                e.Cancel = True
    '                MsgBox("Please Enter Numeric Values Only")
    '            End If

    '        End If
    '    End If

    'End Sub



    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        ''EditorDashboard.Refresh()
        SupervisorDashboard.Dispose()
        SupervisorDashboard.Show()

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim opt As Integer = MessageBox.Show("Are You Sure to Log Out ?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If opt = 6 Then
            Application.Exit()
            End
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        'MessageBox.Show("Error:  " & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"
            MsgBox("error")
            e.ThrowException = False
        End If

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Me.UsersTableAdapter.UpdateUserClass(Me.DataGridView1.CurrentRow.Cells("UserClass").Value, Class1.U_Name,
                                             Me.DataGridView1.CurrentRow.Cells(0).Value, Me.DataGridView1.CurrentRow.Cells(1).Value)
    End Sub

    Private Sub EditorClassificaiton_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SupervisorDashboard.Show()
    End Sub
End Class