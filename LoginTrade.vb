Public Class LoginTrade

    Private Sub LoginTrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TradeStatisticsDataSet.SupervisorWork' table. You can move, or remove it, as needed.
        Me.SupervisorWorkTableAdapter.Fill(Me.TradeStatisticsDataSet.SupervisorWork)

        Me.UsersTableAdapter.Fill(Me.TradeStatisticsDataSet.users)
        Me.TextBoxUserName.Text = ""
        Me.TextBoxPassword.Text = ""
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TradeStatisticsDataSet)

    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If Me.TextBoxUserName.Text = "" Then
            MsgBox("Please Enter User_Name")
            Me.TextBoxUserName.Focus()
        ElseIf Me.TextBoxPassword.Text = "" Then
            MsgBox("Please Enter Password")
            Me.TextBoxPassword.Focus()
        Else
            If Me.UsersTableAdapter.GetUser1(Me.TradeStatisticsDataSet.users, Me.TextBoxUserName.Text, Me.TextBoxPassword.Text) > 0 Then
                ''Class_Variables.UserName = Me.me.TxtUsrName.Text
                Class1.U_Name = Me.TextBoxUserName.Text
                Class1.Password = Me.TextBoxPassword.Text
                Class1.userCount = Me.UsersTableAdapter.UserCount(Class1.U_Name, Class1.Password)
                Dim Role As String = UsersBindingSource.Current("Role")
                'Dim UserClass As String = UsersBindingSource.Current("Userclass")
                Class1.Role = Role
                ''Class1.UserID = UsersBindingSource.Current("userID")
                Me.UsersTableAdapter.GetUserId(Me.TradeStatisticsDataSet.users, Class1.U_Name, Class1.Password) '''get id of that user
                Class1.GetUserID = Me.UsersBindingSource.Current("userID")
                If Class1.Role = "ADMIN" Then
                    SupervisorDashboard.Show()
                    Me.Hide()

                ElseIf Class1.Role = "superadmin" Then
                    SupervisorDashboard.Show()
                    Me.Hide()

                ElseIf Class1.Role = "indexeditor" Then
                    EditorDashboard.Show()
                    Me.Hide()

                ElseIf Class1.Role = "editor" Then
                    Class1.rowindx = Me.SupervisorWorkTableAdapter.GetLastRowNumber(Class1.GetUserID)
                    Class1.lastSavedIndexflag = 1
                    Class1.HscodeIndex = 1
                    EditorDashboard.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid User_Name or Password", MsgBoxStyle.OkOnly, "invalid user")
                    Me.TextBoxUserName.Text = ""
                    Me.TextBoxPassword.Text = ""
                    Me.TextBoxUserName.Focus()
                End If
            End If
        End If

        ''''''fcggggggggggggggggggggggg

        'Class1.Role = ""
        'If Me.TextBoxUserName.Text = "" Then
        '    MsgBox("Enter User_Name..", MsgBoxStyle.Critical)
        '    Me.TextBoxUserName.Focus()
        'ElseIf Me.TextBoxPassword.Text = "" Then
        '    MsgBox("Enter Password..", MsgBoxStyle.Critical)
        '    Me.TextBoxPassword.Focus()
        'Else
        '    Class1.U_Name = Me.TextBoxUserName.Text
        '    Class1.Password = Me.TextBoxPassword.Text
        '    Class1.userCount = Me.UsersTableAdapter.UserCount(Class1.U_Name, Class1.Password)
        '    If Class1.userCount <= 0 Then
        '        MsgBox("Login Failed. Enter valid User_Name and Password!")
        '        Me.TextBoxUserName.Text = ""
        '        Me.TextBoxPassword.Text = ""
        '        Me.TextBoxUserName.Focus()
        '    ElseIf Class1.userCount > 1 Then
        '        MsgBox("Duplicate User_Name and Password!")
        '        Me.TextBoxUserName.Text = ""
        '        Me.TextBoxPassword.Text = ""
        '        Me.TextBoxUserName.Focus()
        '    Else
        '        Class1.Role = Me.UsersTableAdapter.UserRole(Class1.U_Name, Class1.Password)
        '        Class1.GetUserID = Me.UsersTableAdapter.GetUserId(Class1.U_Name, Class1.Password)
        '        If Class1.Role = "ADMIN" Then
        '            SupervisorDashboard.Show()
        '            Me.Hide()
        '        ElseIf Class1.Role = "editor" Then
        '            EditorDashboard.Show()
        '            Me.Hide()
        '        Else
        '            Me.Show()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Application.Exit()
        End
    End Sub

    Private Sub TextBoxUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserName.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If keyascii = Keys.Back Then
            Exit Sub
        ElseIf keyascii = Keys.Return Then
            SendKeys.Send(vbTab)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        'Dim keyascii As Short = Asc(e.KeyChar)
        'If keyascii = Keys.Back Then
        '    Exit Sub
        'ElseIf keyascii = Keys.Return Then
        '    SendKeys.Send(vbTab)
        '    e.Handled = True
        'End If
        'If TextBoxPassword.Text.Trim().Length() >= 7 Then
        '    'If TextBoxPassword.Text.Length = 6 Then
        '    If Me.TextBoxUserName.Text = "" Then
        '        MsgBox("Please Enter User_Name")
        '        Me.TextBoxUserName.Focus()
        '    ElseIf Me.TextBoxPassword.Text = "" Then
        '        MsgBox("Please Enter Password")
        '        Me.TextBoxPassword.Focus()
        '    Else
        '        If Me.UsersTableAdapter.GetUser1(Me.TradeStatisticsDataSet.users, Me.TextBoxUserName.Text, Me.TextBoxPassword.Text) > 0 Then
        '            ''Class_Variables.UserName = Me.me.TxtUsrName.Text
        '            Class1.U_Name = Me.TextBoxUserName.Text
        '            Class1.Password = Me.TextBoxPassword.Text
        '            Class1.userCount = Me.UsersTableAdapter.UserCount(Class1.U_Name, Class1.Password)
        '            Dim Role As String = UsersBindingSource.Current("Role")
        '            'Dim UserClass As String = UsersBindingSource.Current("Userclass")
        '            Class1.Role = Role
        '            ''Class1.UserID = UsersBindingSource.Current("userID")
        '            Me.UsersTableAdapter.GetUserId(Me.TradeStatisticsDataSet.users, Class1.U_Name, Class1.Password) '''get id of that user
        '            Class1.GetUserID = Me.UsersBindingSource.Current("userID")
        '            If Class1.Role = "ADMIN" Then
        '                SupervisorDashboard.Show()
        '                Me.Hide()
        '            ElseIf Class1.Role = "editor" Then
        '                EditorDashboard.Show()
        '                Me.Hide()
        '            Else
        '                MsgBox("Invalid User_Name or Password", MsgBoxStyle.OkOnly, "invalid user")
        '                Me.TextBoxUserName.Text = ""
        '                Me.TextBoxPassword.Text = ""
        '                Me.TextBoxUserName.Focus()
        '            End If
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

        If TextBoxPassword.Text.Trim().Length() = 6 Then
            'If TextBoxPassword.Text.Length = 6 Then
            If Me.TextBoxUserName.Text = "" Then
                MsgBox("Please Enter User_Name")
                Me.TextBoxUserName.Focus()
            ElseIf Me.TextBoxPassword.Text = "" Then
                MsgBox("Please Enter Password")
                Me.TextBoxPassword.Focus()
            Else
                If Me.UsersTableAdapter.GetUser1(Me.TradeStatisticsDataSet.users, Me.TextBoxUserName.Text, Me.TextBoxPassword.Text) > 0 Then
                    ''Class_Variables.UserName = Me.me.TxtUsrName.Text
                    Class1.U_Name = Me.TextBoxUserName.Text
                    Class1.Password = Me.TextBoxPassword.Text
                    Class1.userCount = Me.UsersTableAdapter.UserCount(Class1.U_Name, Class1.Password)
                    Dim Role As String = UsersBindingSource.Current("Role")
                    'Dim UserClass As String = UsersBindingSource.Current("Userclass")
                    Class1.Role = Role
                    ''Class1.UserID = UsersBindingSource.Current("userID")
                    Me.UsersTableAdapter.GetUserId(Me.TradeStatisticsDataSet.users, Class1.U_Name, Class1.Password) '''get id of that user
                    Class1.GetUserID = Me.UsersBindingSource.Current("userID")
                    If Class1.Role = "ADMIN" Then
                        SupervisorDashboard.Show()
                        Me.Hide()

                    ElseIf Class1.Role = "superadmin" Then
                        SupervisorDashboard.Show()
                        Me.Hide()

                    ElseIf Class1.Role = "indexeditor" Then
                        EditorDashboard.Show()
                        Me.Hide()

                    ElseIf Class1.Role = "editor" Then
                        Class1.rowindx = Me.SupervisorWorkTableAdapter.GetLastRowNumber(Class1.GetUserID)
                        Class1.lastSavedIndexflag = 1
                        Class1.HscodeIndex = 1
                        EditorDashboard.Show()
                        Me.Hide()
                    Else
                        MsgBox("Invalid User_Name or Password", MsgBoxStyle.OkOnly, "invalid user")
                        Me.TextBoxUserName.Text = ""
                        Me.TextBoxPassword.Text = ""
                        Me.TextBoxUserName.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub LoginTrade_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Controls.Clear()
        'Application.Exit()
    End Sub
End Class
