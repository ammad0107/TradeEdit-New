<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assign))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblAssigned = New System.Windows.Forms.Label()
        Me.LblRcdTotal = New System.Windows.Forms.Label()
        Me.LblRcdTot = New System.Windows.Forms.Label()
        Me.DgvUser = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.BtnAssign = New System.Windows.Forms.Button()
        Me.LblRemaining = New System.Windows.Forms.Label()
        Me.LblTRecords = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.LblRemExp = New System.Windows.Forms.Label()
        Me.LblExpRem = New System.Windows.Forms.Label()
        Me.LblImports = New System.Windows.Forms.Label()
        Me.LblImp = New System.Windows.Forms.Label()
        Me.LblValImp = New System.Windows.Forms.Label()
        Me.LblImpRem = New System.Windows.Forms.Label()
        Me.LblImpAssigned = New System.Windows.Forms.Label()
        Me.LblRemImp = New System.Windows.Forms.Label()
        Me.LblAssImp = New System.Windows.Forms.Label()
        Me.LblExports = New System.Windows.Forms.Label()
        Me.LblExp = New System.Windows.Forms.Label()
        Me.LblValExp = New System.Windows.Forms.Label()
        Me.LblExpAssigned = New System.Windows.Forms.Label()
        Me.LblAssExp = New System.Windows.Forms.Label()
        Me.LblSummary = New System.Windows.Forms.Label()
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnreAssgn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FromRecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToRecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReAssignWk = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ReleasedRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet1 = New TradeEdit.TradeStatisticsDataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.usersTableAdapter()
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReleasedRecordTableAdapter = New TradeEdit.TradeStatisticsDataSet1TableAdapters.ReleasedRecordTableAdapter()
        Me.ReAssign = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FillBy2ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy2ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LblTitleBar = New System.Windows.Forms.Label()
        Me.LblStatusBar = New System.Windows.Forms.Label()
        Me.PictureBoxUFD = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPBS = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReleasedRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy2ToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BurlyWood
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(666, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 32)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "Total Records:"
        Me.Label7.Visible = False
        '
        'LblAssigned
        '
        Me.LblAssigned.BackColor = System.Drawing.Color.SteelBlue
        Me.LblAssigned.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssigned.ForeColor = System.Drawing.Color.White
        Me.LblAssigned.Location = New System.Drawing.Point(649, 80)
        Me.LblAssigned.MinimumSize = New System.Drawing.Size(75, 25)
        Me.LblAssigned.Name = "LblAssigned"
        Me.LblAssigned.Size = New System.Drawing.Size(226, 25)
        Me.LblAssigned.TabIndex = 218
        Me.LblAssigned.Text = "------"
        Me.LblAssigned.Visible = False
        '
        'LblRcdTotal
        '
        Me.LblRcdTotal.AutoSize = True
        Me.LblRcdTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRcdTotal.Location = New System.Drawing.Point(712, 88)
        Me.LblRcdTotal.Name = "LblRcdTotal"
        Me.LblRcdTotal.Size = New System.Drawing.Size(89, 24)
        Me.LblRcdTotal.TabIndex = 215
        Me.LblRcdTotal.Text = "Assigned"
        Me.LblRcdTotal.Visible = False
        '
        'LblRcdTot
        '
        Me.LblRcdTot.BackColor = System.Drawing.Color.BurlyWood
        Me.LblRcdTot.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRcdTot.ForeColor = System.Drawing.Color.Maroon
        Me.LblRcdTot.Location = New System.Drawing.Point(647, 80)
        Me.LblRcdTot.MinimumSize = New System.Drawing.Size(193, 32)
        Me.LblRcdTot.Name = "LblRcdTot"
        Me.LblRcdTot.Size = New System.Drawing.Size(193, 32)
        Me.LblRcdTot.TabIndex = 213
        Me.LblRcdTot.Text = "-----"
        Me.LblRcdTot.Visible = False
        '
        'DgvUser
        '
        Me.DgvUser.AllowUserToAddRows = False
        Me.DgvUser.AllowUserToDeleteRows = False
        Me.DgvUser.AutoGenerateColumns = False
        Me.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.UserName, Me.FromRecord, Me.ToRecord})
        Me.DgvUser.DataSource = Me.UsersBindingSource
        Me.DgvUser.Location = New System.Drawing.Point(-4, 19)
        Me.DgvUser.Name = "DgvUser"
        Me.DgvUser.Size = New System.Drawing.Size(578, 305)
        Me.DgvUser.TabIndex = 212
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "userID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.UserID.DefaultCellStyle = DataGridViewCellStyle1
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.UserID.Width = 80
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.UserName.DefaultCellStyle = DataGridViewCellStyle2
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.UserName.Width = 150
        '
        'FromRecord
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FromRecord.DefaultCellStyle = DataGridViewCellStyle3
        Me.FromRecord.HeaderText = "From Rec #"
        Me.FromRecord.Name = "FromRecord"
        Me.FromRecord.ReadOnly = True
        Me.FromRecord.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FromRecord.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FromRecord.Width = 150
        '
        'ToRecord
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.ToRecord.DefaultCellStyle = DataGridViewCellStyle4
        Me.ToRecord.HeaderText = "To Rec #"
        Me.ToRecord.Name = "ToRecord"
        Me.ToRecord.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ToRecord.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ToRecord.Width = 150
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
        'BtnAssign
        '
        Me.BtnAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnAssign.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAssign.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAssign.ForeColor = System.Drawing.Color.White
        Me.BtnAssign.Location = New System.Drawing.Point(0, 468)
        Me.BtnAssign.Name = "BtnAssign"
        Me.BtnAssign.Size = New System.Drawing.Size(150, 34)
        Me.BtnAssign.TabIndex = 211
        Me.BtnAssign.Text = "ASSIGN"
        Me.BtnAssign.UseVisualStyleBackColor = False
        '
        'LblRemaining
        '
        Me.LblRemaining.BackColor = System.Drawing.Color.SteelBlue
        Me.LblRemaining.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemaining.ForeColor = System.Drawing.Color.White
        Me.LblRemaining.Location = New System.Drawing.Point(690, 84)
        Me.LblRemaining.MinimumSize = New System.Drawing.Size(75, 25)
        Me.LblRemaining.Name = "LblRemaining"
        Me.LblRemaining.Size = New System.Drawing.Size(129, 25)
        Me.LblRemaining.TabIndex = 207
        Me.LblRemaining.Text = "-------"
        Me.LblRemaining.Visible = False
        '
        'LblTRecords
        '
        Me.LblTRecords.AutoSize = True
        Me.LblTRecords.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTRecords.Location = New System.Drawing.Point(667, 77)
        Me.LblTRecords.Name = "LblTRecords"
        Me.LblTRecords.Size = New System.Drawing.Size(106, 24)
        Me.LblTRecords.TabIndex = 204
        Me.LblTRecords.Text = "Remaining"
        Me.LblTRecords.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1213, 63)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(135, 32)
        Me.BtnBack.TabIndex = 270
        Me.BtnBack.Text = "Back to DashBoard"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'LblHeading
        '
        Me.LblHeading.BackColor = System.Drawing.SystemColors.Control
        Me.LblHeading.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.ForeColor = System.Drawing.Color.Black
        Me.LblHeading.Location = New System.Drawing.Point(6, 136)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(387, 37)
        Me.LblHeading.TabIndex = 277
        Me.LblHeading.Text = "Assign Records to Editors"
        Me.LblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRemExp
        '
        Me.LblRemExp.AutoSize = True
        Me.LblRemExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemExp.ForeColor = System.Drawing.Color.Black
        Me.LblRemExp.Location = New System.Drawing.Point(290, 631)
        Me.LblRemExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblRemExp.Name = "LblRemExp"
        Me.LblRemExp.Size = New System.Drawing.Size(101, 30)
        Me.LblRemExp.TabIndex = 357
        Me.LblRemExp.Text = "Remaining:"
        Me.LblRemExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExpRem
        '
        Me.LblExpRem.AutoSize = True
        Me.LblExpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpRem.ForeColor = System.Drawing.Color.Black
        Me.LblExpRem.Location = New System.Drawing.Point(412, 631)
        Me.LblExpRem.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExpRem.Name = "LblExpRem"
        Me.LblExpRem.Size = New System.Drawing.Size(100, 30)
        Me.LblExpRem.TabIndex = 355
        Me.LblExpRem.Text = "............."
        Me.LblExpRem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImports
        '
        Me.LblImports.AutoSize = True
        Me.LblImports.BackColor = System.Drawing.SystemColors.Control
        Me.LblImports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImports.ForeColor = System.Drawing.Color.White
        Me.LblImports.Location = New System.Drawing.Point(6, 519)
        Me.LblImports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblImports.Name = "LblImports"
        Me.LblImports.Size = New System.Drawing.Size(250, 150)
        Me.LblImports.TabIndex = 352
        Me.LblImports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblImp
        '
        Me.LblImp.AutoSize = True
        Me.LblImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImp.ForeColor = System.Drawing.Color.Black
        Me.LblImp.Location = New System.Drawing.Point(20, 528)
        Me.LblImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImp.Name = "LblImp"
        Me.LblImp.Size = New System.Drawing.Size(100, 30)
        Me.LblImp.TabIndex = 347
        Me.LblImp.Text = "IMPORTS"
        Me.LblImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblValImp
        '
        Me.LblValImp.AutoSize = True
        Me.LblValImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValImp.ForeColor = System.Drawing.Color.Black
        Me.LblValImp.Location = New System.Drawing.Point(142, 528)
        Me.LblValImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblValImp.Name = "LblValImp"
        Me.LblValImp.Size = New System.Drawing.Size(100, 30)
        Me.LblValImp.TabIndex = 346
        Me.LblValImp.Text = "............."
        Me.LblValImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpRem
        '
        Me.LblImpRem.AutoSize = True
        Me.LblImpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpRem.ForeColor = System.Drawing.Color.Black
        Me.LblImpRem.Location = New System.Drawing.Point(142, 631)
        Me.LblImpRem.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImpRem.Name = "LblImpRem"
        Me.LblImpRem.Size = New System.Drawing.Size(100, 30)
        Me.LblImpRem.TabIndex = 348
        Me.LblImpRem.Text = "............."
        Me.LblImpRem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpAssigned
        '
        Me.LblImpAssigned.AutoSize = True
        Me.LblImpAssigned.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpAssigned.ForeColor = System.Drawing.Color.Black
        Me.LblImpAssigned.Location = New System.Drawing.Point(142, 581)
        Me.LblImpAssigned.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImpAssigned.Name = "LblImpAssigned"
        Me.LblImpAssigned.Size = New System.Drawing.Size(100, 30)
        Me.LblImpAssigned.TabIndex = 349
        Me.LblImpAssigned.Text = "............."
        Me.LblImpAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRemImp
        '
        Me.LblRemImp.AutoSize = True
        Me.LblRemImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemImp.ForeColor = System.Drawing.Color.Black
        Me.LblRemImp.Location = New System.Drawing.Point(20, 631)
        Me.LblRemImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblRemImp.Name = "LblRemImp"
        Me.LblRemImp.Size = New System.Drawing.Size(101, 30)
        Me.LblRemImp.TabIndex = 350
        Me.LblRemImp.Text = "Remaining:"
        Me.LblRemImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAssImp
        '
        Me.LblAssImp.AutoSize = True
        Me.LblAssImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblAssImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAssImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssImp.ForeColor = System.Drawing.Color.Black
        Me.LblAssImp.Location = New System.Drawing.Point(20, 581)
        Me.LblAssImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblAssImp.Name = "LblAssImp"
        Me.LblAssImp.Size = New System.Drawing.Size(100, 30)
        Me.LblAssImp.TabIndex = 351
        Me.LblAssImp.Text = "Assigned:"
        Me.LblAssImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExports
        '
        Me.LblExports.AutoSize = True
        Me.LblExports.BackColor = System.Drawing.SystemColors.Control
        Me.LblExports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblExports.ForeColor = System.Drawing.Color.White
        Me.LblExports.Location = New System.Drawing.Point(276, 519)
        Me.LblExports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblExports.Name = "LblExports"
        Me.LblExports.Size = New System.Drawing.Size(250, 150)
        Me.LblExports.TabIndex = 359
        Me.LblExports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExp
        '
        Me.LblExp.AutoSize = True
        Me.LblExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExp.ForeColor = System.Drawing.Color.Black
        Me.LblExp.Location = New System.Drawing.Point(290, 528)
        Me.LblExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExp.Name = "LblExp"
        Me.LblExp.Size = New System.Drawing.Size(100, 30)
        Me.LblExp.TabIndex = 354
        Me.LblExp.Text = "EXPORTS"
        Me.LblExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblValExp
        '
        Me.LblValExp.AutoSize = True
        Me.LblValExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValExp.ForeColor = System.Drawing.Color.Black
        Me.LblValExp.Location = New System.Drawing.Point(412, 528)
        Me.LblValExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblValExp.Name = "LblValExp"
        Me.LblValExp.Size = New System.Drawing.Size(100, 30)
        Me.LblValExp.TabIndex = 353
        Me.LblValExp.Text = "............."
        Me.LblValExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExpAssigned
        '
        Me.LblExpAssigned.AutoSize = True
        Me.LblExpAssigned.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpAssigned.ForeColor = System.Drawing.Color.Black
        Me.LblExpAssigned.Location = New System.Drawing.Point(412, 581)
        Me.LblExpAssigned.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExpAssigned.Name = "LblExpAssigned"
        Me.LblExpAssigned.Size = New System.Drawing.Size(100, 30)
        Me.LblExpAssigned.TabIndex = 356
        Me.LblExpAssigned.Text = "............."
        Me.LblExpAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAssExp
        '
        Me.LblAssExp.AutoSize = True
        Me.LblAssExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblAssExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAssExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssExp.ForeColor = System.Drawing.Color.Black
        Me.LblAssExp.Location = New System.Drawing.Point(290, 581)
        Me.LblAssExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblAssExp.Name = "LblAssExp"
        Me.LblAssExp.Size = New System.Drawing.Size(100, 30)
        Me.LblAssExp.TabIndex = 358
        Me.LblAssExp.Text = "Assigned:"
        Me.LblAssExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSummary
        '
        Me.LblSummary.BackColor = System.Drawing.Color.Maroon
        Me.LblSummary.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSummary.ForeColor = System.Drawing.Color.White
        Me.LblSummary.Location = New System.Drawing.Point(667, 59)
        Me.LblSummary.MaximumSize = New System.Drawing.Size(310, 100)
        Me.LblSummary.MinimumSize = New System.Drawing.Size(0, 30)
        Me.LblSummary.Name = "LblSummary"
        Me.LblSummary.Size = New System.Drawing.Size(309, 52)
        Me.LblSummary.TabIndex = 361
        Me.LblSummary.Text = "Assignment Summary"
        Me.LblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSummary.Visible = False
        '
        'SupervisorWorkBindingSource
        '
        Me.SupervisorWorkBindingSource.DataMember = "SupervisorWork"
        Me.SupervisorWorkBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(647, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 37)
        Me.Label1.TabIndex = 363
        Me.Label1.Text = "Work Re-Assignment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnreAssgn
        '
        Me.BtnreAssgn.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnreAssgn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnreAssgn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnreAssgn.ForeColor = System.Drawing.Color.White
        Me.BtnreAssgn.Location = New System.Drawing.Point(636, 478)
        Me.BtnreAssgn.Name = "BtnreAssgn"
        Me.BtnreAssgn.Size = New System.Drawing.Size(150, 34)
        Me.BtnreAssgn.TabIndex = 364
        Me.BtnreAssgn.Text = "RE-ASSIGN WORK"
        Me.BtnreAssgn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvUser)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 305)
        Me.GroupBox1.TabIndex = 365
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ASSIGN RECORDS TO EDITORS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(653, 519)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 184)
        Me.GroupBox2.TabIndex = 366
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UnAssigned Range"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FromRecDataGridViewTextBoxColumn, Me.ToRecDataGridViewTextBoxColumn, Me.ReAssignWk})
        Me.DataGridView2.DataSource = Me.ReleasedRecordBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(18, 23)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(528, 150)
        Me.DataGridView2.TabIndex = 6
        '
        'FromRecDataGridViewTextBoxColumn
        '
        Me.FromRecDataGridViewTextBoxColumn.DataPropertyName = "FromRec"
        Me.FromRecDataGridViewTextBoxColumn.HeaderText = "FromRec"
        Me.FromRecDataGridViewTextBoxColumn.Name = "FromRecDataGridViewTextBoxColumn"
        Me.FromRecDataGridViewTextBoxColumn.Width = 160
        '
        'ToRecDataGridViewTextBoxColumn
        '
        Me.ToRecDataGridViewTextBoxColumn.DataPropertyName = "ToRec"
        Me.ToRecDataGridViewTextBoxColumn.HeaderText = "ToRec"
        Me.ToRecDataGridViewTextBoxColumn.Name = "ToRecDataGridViewTextBoxColumn"
        Me.ToRecDataGridViewTextBoxColumn.Width = 160
        '
        'ReAssignWk
        '
        Me.ReAssignWk.HeaderText = "ReAssignWk"
        Me.ReAssignWk.Name = "ReAssignWk"
        Me.ReAssignWk.Width = 160
        '
        'ReleasedRecordBindingSource
        '
        Me.ReleasedRecordBindingSource.DataMember = "ReleasedRecord"
        Me.ReleasedRecordBindingSource.DataSource = Me.TradeStatisticsDataSet1
        '
        'TradeStatisticsDataSet1
        '
        Me.TradeStatisticsDataSet1.DataSetName = "TradeStatisticsDataSet1"
        Me.TradeStatisticsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "."
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(206, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "."
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "."
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(206, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(206, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "."
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'ExportDataTableAdapter
        '
        Me.ExportDataTableAdapter.ClearBeforeFill = True
        '
        'ImportDataTableAdapter
        '
        Me.ImportDataTableAdapter.ClearBeforeFill = True
        '
        'SupervisorWorkTableAdapter
        '
        Me.SupervisorWorkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CountryTableAdapter = Nothing
        Me.TableAdapterManager.dateTableTableAdapter = Nothing
        Me.TableAdapterManager.DollarSDRTableAdapter = Nothing
        Me.TableAdapterManager.exchangeRateTableAdapter = Nothing
        Me.TableAdapterManager.EXPORT_TableAdapter = Nothing
        Me.TableAdapterManager.ExportDataTableAdapter = Nothing
        Me.TableAdapterManager.ExportSummaryTableAdapter = Nothing
        Me.TableAdapterManager.HscodeTableAdapter = Nothing
        Me.TableAdapterManager.ImportDataTableAdapter = Nothing
        Me.TableAdapterManager.ImportSummaryTableAdapter = Nothing
        Me.TableAdapterManager.Lp_Release_ExpTableAdapter = Nothing
        Me.TableAdapterManager.Lp_Release_ImpTableAdapter = Nothing
        Me.TableAdapterManager.MonthsTableAdapter = Nothing
        Me.TableAdapterManager.PRALExpDataTableAdapter = Nothing
        Me.TableAdapterManager.PRALImpDataTableAdapter = Nothing
        Me.TableAdapterManager.RouteTableAdapter = Nothing
        Me.TableAdapterManager.rs_delTableAdapter = Nothing
        Me.TableAdapterManager.SupervisorWorkTableAdapter = Nothing
        Me.TableAdapterManager.TradeTypeTableAdapter = Nothing
        Me.TableAdapterManager.UnitTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_roleTableAdapter = Nothing
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'ImportDataBindingSource
        '
        Me.ImportDataBindingSource.DataMember = "ImportData"
        Me.ImportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ExportDataBindingSource
        '
        Me.ExportDataBindingSource.DataMember = "ExportData"
        Me.ExportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ReleasedRecordTableAdapter
        '
        Me.ReleasedRecordTableAdapter.ClearBeforeFill = True
        '
        'ReAssign
        '
        Me.ReAssign.HeaderText = "ReAssign"
        Me.ReAssign.Name = "ReAssign"
        Me.ReAssign.Visible = False
        '
        'Edit
        '
        Me.Edit.HeaderText = "Release"
        Me.Edit.Name = "Edit"
        '
        'ToRec
        '
        Me.ToRec.DataPropertyName = "ToRec1"
        Me.ToRec.HeaderText = "ToRec"
        Me.ToRec.Name = "ToRec"
        Me.ToRec.Width = 80
        '
        'FromRec
        '
        Me.FromRec.DataPropertyName = "FromRec1"
        Me.FromRec.HeaderText = "FromRec"
        Me.FromRec.Name = "FromRec"
        Me.FromRec.Width = 80
        '
        'TT
        '
        Me.TT.DataPropertyName = "TT1"
        Me.TT.HeaderText = "TT"
        Me.TT.Name = "TT"
        Me.TT.ReadOnly = True
        Me.TT.Width = 60
        '
        'Remaining
        '
        Me.Remaining.DataPropertyName = "Remaining"
        Me.Remaining.HeaderText = "Remaining"
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        Me.Remaining.Width = 90
        '
        'Completed
        '
        Me.Completed.DataPropertyName = "Completed"
        Me.Completed.HeaderText = "Completed"
        Me.Completed.Name = "Completed"
        Me.Completed.ReadOnly = True
        Me.Completed.Width = 75
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 60
        '
        'UID
        '
        Me.UID.DataPropertyName = "userID"
        Me.UID.HeaderText = "UID"
        Me.UID.Name = "UID"
        Me.UID.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.UID, Me.Total, Me.Completed, Me.Remaining, Me.TT, Me.FromRec, Me.ToRec, Me.Edit, Me.ReAssign})
        Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(636, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(728, 294)
        Me.DataGridView1.TabIndex = 362
        '
        'FillBy2ToolStripButton
        '
        Me.FillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy2ToolStripButton.Name = "FillBy2ToolStripButton"
        Me.FillBy2ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy2ToolStripButton.Text = "FillBy2"
        Me.FillBy2ToolStripButton.Visible = False
        '
        'FillBy2ToolStrip
        '
        Me.FillBy2ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy2ToolStripButton})
        Me.FillBy2ToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBy2ToolStrip.Name = "FillBy2ToolStrip"
        Me.FillBy2ToolStrip.Size = New System.Drawing.Size(1370, 25)
        Me.FillBy2ToolStrip.TabIndex = 368
        Me.FillBy2ToolStrip.Text = "FillBy2ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        Me.FillBy1ToolStripButton.Visible = False
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1370, 25)
        Me.FillBy1ToolStrip.TabIndex = 367
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'LblTitleBar
        '
        Me.LblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblTitleBar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleBar.ForeColor = System.Drawing.Color.White
        Me.LblTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.LblTitleBar.Name = "LblTitleBar"
        Me.LblTitleBar.Size = New System.Drawing.Size(1227, 57)
        Me.LblTitleBar.TabIndex = 371
        Me.LblTitleBar.Text = "Trade Statistics Management Information System (TSMIS)"
        Me.LblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStatusBar
        '
        Me.LblStatusBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblStatusBar.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusBar.ForeColor = System.Drawing.Color.White
        Me.LblStatusBar.Location = New System.Drawing.Point(0, 706)
        Me.LblStatusBar.Name = "LblStatusBar"
        Me.LblStatusBar.Size = New System.Drawing.Size(1368, 40)
        Me.LblStatusBar.TabIndex = 374
        Me.LblStatusBar.Text = "Powered By: DP-Centre, PBS, Karachi"
        Me.LblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxUFD
        '
        Me.PictureBoxUFD.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBoxUFD.Image = CType(resources.GetObject("PictureBoxUFD.Image"), System.Drawing.Image)
        Me.PictureBoxUFD.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxUFD.Name = "PictureBoxUFD"
        Me.PictureBoxUFD.Size = New System.Drawing.Size(101, 57)
        Me.PictureBoxUFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUFD.TabIndex = 375
        Me.PictureBoxUFD.TabStop = False
        '
        'PictureBoxPBS
        '
        Me.PictureBoxPBS.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPBS.Image = CType(resources.GetObject("PictureBoxPBS.Image"), System.Drawing.Image)
        Me.PictureBoxPBS.Location = New System.Drawing.Point(1228, 0)
        Me.PictureBoxPBS.Name = "PictureBoxPBS"
        Me.PictureBoxPBS.Size = New System.Drawing.Size(142, 57)
        Me.PictureBoxPBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBS.TabIndex = 376
        Me.PictureBoxPBS.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(437, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(308, 37)
        Me.Label9.TabIndex = 377
        Me.Label9.Text = "."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.BtnBack
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBoxPBS)
        Me.Controls.Add(Me.PictureBoxUFD)
        Me.Controls.Add(Me.LblStatusBar)
        Me.Controls.Add(Me.LblTitleBar)
        Me.Controls.Add(Me.FillBy2ToolStrip)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblHeading)
        Me.Controls.Add(Me.BtnreAssgn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblSummary)
        Me.Controls.Add(Me.LblAssExp)
        Me.Controls.Add(Me.LblRemExp)
        Me.Controls.Add(Me.LblExpAssigned)
        Me.Controls.Add(Me.LblExpRem)
        Me.Controls.Add(Me.LblValExp)
        Me.Controls.Add(Me.LblExp)
        Me.Controls.Add(Me.LblExports)
        Me.Controls.Add(Me.LblAssImp)
        Me.Controls.Add(Me.LblRemImp)
        Me.Controls.Add(Me.LblImpAssigned)
        Me.Controls.Add(Me.LblImpRem)
        Me.Controls.Add(Me.LblValImp)
        Me.Controls.Add(Me.LblImp)
        Me.Controls.Add(Me.LblImports)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblAssigned)
        Me.Controls.Add(Me.LblRcdTotal)
        Me.Controls.Add(Me.LblRcdTot)
        Me.Controls.Add(Me.BtnAssign)
        Me.Controls.Add(Me.LblRemaining)
        Me.Controls.Add(Me.LblTRecords)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReleasedRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy2ToolStrip.ResumeLayout(False)
        Me.FillBy2ToolStrip.PerformLayout()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents LblAssigned As Label
    Friend WithEvents LblRcdTotal As Label
    Friend WithEvents LblRcdTot As Label
    Friend WithEvents DgvUser As DataGridView
    Friend WithEvents BtnAssign As Button
    Friend WithEvents LblRemaining As Label
    Friend WithEvents LblTRecords As Label
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As TradeStatisticsDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents BtnBack As Button
    Friend WithEvents LblHeading As Label
    Friend WithEvents LblRemExp As Label
    Friend WithEvents LblExpRem As Label
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents FromRecord As DataGridViewTextBoxColumn
    Friend WithEvents ToRecord As DataGridViewTextBoxColumn
    Friend WithEvents LblImports As Label
    Friend WithEvents LblImp As Label
    Friend WithEvents LblValImp As Label
    Friend WithEvents LblImpRem As Label
    Friend WithEvents LblImpAssigned As Label
    Friend WithEvents LblRemImp As Label
    Friend WithEvents LblAssImp As Label
    Friend WithEvents LblExports As Label
    Friend WithEvents LblExp As Label
    Friend WithEvents LblValExp As Label
    Friend WithEvents LblExpAssigned As Label
    Friend WithEvents LblAssExp As Label
    Friend WithEvents LblSummary As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnreAssgn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TradeStatisticsDataSet1 As TradeStatisticsDataSet1
    Friend WithEvents ReleasedRecordBindingSource As BindingSource
    Friend WithEvents ReleasedRecordTableAdapter As TradeStatisticsDataSet1TableAdapters.ReleasedRecordTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents FromRecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToRecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReAssignWk As DataGridViewButtonColumn
    Friend WithEvents ReAssign As DataGridViewButtonColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents ToRec As DataGridViewTextBoxColumn
    Friend WithEvents FromRec As DataGridViewTextBoxColumn
    Friend WithEvents TT As DataGridViewTextBoxColumn
    Friend WithEvents Remaining As DataGridViewTextBoxColumn
    Friend WithEvents Completed As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents UID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FillBy2ToolStripButton As ToolStripButton
    Friend WithEvents FillBy2ToolStrip As ToolStrip
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents LblTitleBar As Label
    Friend WithEvents LblStatusBar As Label
    Friend WithEvents PictureBoxUFD As PictureBox
    Friend WithEvents PictureBoxPBS As PictureBox
    Friend WithEvents Label9 As Label
End Class
