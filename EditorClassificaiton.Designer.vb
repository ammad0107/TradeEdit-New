<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorClassificaiton
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorClassificaiton))
        Me.Lbl_UserName = New System.Windows.Forms.Label()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.LblTitleBar = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserClass = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.usersTableAdapter()
        Me.PictureBoxUFD = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPBS = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.AutoSize = True
        Me.Lbl_UserName.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.Black
        Me.Lbl_UserName.Location = New System.Drawing.Point(475, 75)
        Me.Lbl_UserName.MinimumSize = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.TabIndex = 305
        Me.Lbl_UserName.Text = "............."
        Me.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.ForeColor = System.Drawing.Color.Black
        Me.Lbl_User.Location = New System.Drawing.Point(370, 75)
        Me.Lbl_User.MinimumSize = New System.Drawing.Size(5, 30)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_User.TabIndex = 304
        Me.Lbl_User.Text = "Supervisor:"
        Me.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(425, 214)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(135, 32)
        Me.BtnLogout.TabIndex = 303
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'LblTitleBar
        '
        Me.LblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblTitleBar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleBar.ForeColor = System.Drawing.Color.Black
        Me.LblTitleBar.Location = New System.Drawing.Point(98, -1)
        Me.LblTitleBar.Name = "LblTitleBar"
        Me.LblTitleBar.Size = New System.Drawing.Size(407, 73)
        Me.LblTitleBar.TabIndex = 300
        Me.LblTitleBar.Text = "TSMIS"
        Me.LblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.Password, Me.UserClass})
        Me.DataGridView1.DataSource = Me.UsersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(389, 310)
        Me.DataGridView1.TabIndex = 306
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "userID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoleDataGridViewTextBoxColumn.Visible = False
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.Visible = False
        '
        'UserClass
        '
        Me.UserClass.DataPropertyName = "UserClass"
        Me.UserClass.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.UserClass.HeaderText = "UserClass"
        Me.UserClass.Items.AddRange(New Object() {"Imports", "Exports"})
        Me.UserClass.Name = "UserClass"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(425, 155)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(135, 32)
        Me.BtnBack.TabIndex = 307
        Me.BtnBack.Text = "Back to DashBoard"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 30)
        Me.Label1.TabIndex = 349
        Me.Label1.Text = "EDITOR CLASSIFICATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'PictureBoxUFD
        '
        Me.PictureBoxUFD.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBoxUFD.Image = CType(resources.GetObject("PictureBoxUFD.Image"), System.Drawing.Image)
        Me.PictureBoxUFD.Location = New System.Drawing.Point(0, -1)
        Me.PictureBoxUFD.Name = "PictureBoxUFD"
        Me.PictureBoxUFD.Size = New System.Drawing.Size(101, 73)
        Me.PictureBoxUFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUFD.TabIndex = 350
        Me.PictureBoxUFD.TabStop = False
        '
        'PictureBoxPBS
        '
        Me.PictureBoxPBS.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPBS.Image = CType(resources.GetObject("PictureBoxPBS.Image"), System.Drawing.Image)
        Me.PictureBoxPBS.Location = New System.Drawing.Point(503, -1)
        Me.PictureBoxPBS.Name = "PictureBoxPBS"
        Me.PictureBoxPBS.Size = New System.Drawing.Size(142, 73)
        Me.PictureBoxPBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBS.TabIndex = 351
        Me.PictureBoxPBS.TabStop = False
        '
        'EditorClassificaiton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 476)
        Me.Controls.Add(Me.PictureBoxPBS)
        Me.Controls.Add(Me.PictureBoxUFD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Lbl_UserName)
        Me.Controls.Add(Me.Lbl_User)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.LblTitleBar)
        Me.Name = "EditorClassificaiton"
        Me.Text = "EditorClassificaiton"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_UserName As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents LblTitleBar As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As TradeStatisticsDataSetTableAdapters.usersTableAdapter
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents UserClass As DataGridViewComboBoxColumn
    Friend WithEvents PictureBoxUFD As PictureBox
    Friend WithEvents PictureBoxPBS As PictureBox
End Class
