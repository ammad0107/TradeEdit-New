<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditorDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorDashboard))
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Lbl_UserName = New System.Windows.Forms.Label()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.LblValExp = New System.Windows.Forms.Label()
        Me.LblValImp = New System.Windows.Forms.Label()
        Me.LblExp = New System.Windows.Forms.Label()
        Me.LblImp = New System.Windows.Forms.Label()
        Me.LblImpRem = New System.Windows.Forms.Label()
        Me.LblImpComp = New System.Windows.Forms.Label()
        Me.LblExpComp = New System.Windows.Forms.Label()
        Me.LblExpRem = New System.Windows.Forms.Label()
        Me.LblCompImp = New System.Windows.Forms.Label()
        Me.LblRemImp = New System.Windows.Forms.Label()
        Me.LblCompExp = New System.Windows.Forms.Label()
        Me.LblRemExp = New System.Windows.Forms.Label()
        Me.LblExports = New System.Windows.Forms.Label()
        Me.LblImports = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.PictureBoxPBS = New System.Windows.Forms.PictureBox()
        Me.PictureBoxUFD = New System.Windows.Forms.PictureBox()
        Me.LblTitleBar = New System.Windows.Forms.Label()
        Me.LblStatusBar = New System.Windows.Forms.Label()
        Me.BtnEditImp = New System.Windows.Forms.Button()
        Me.CmbYY = New System.Windows.Forms.ComboBox()
        Me.LblYY = New System.Windows.Forms.Label()
        Me.LblMM = New System.Windows.Forms.Label()
        Me.CmbMM = New System.Windows.Forms.ComboBox()
        Me.MonthsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthsTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.MonthsTableAdapter()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogout.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(909, 98)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(130, 42)
        Me.BtnLogout.TabIndex = 279
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.Black
        Me.Lbl_UserName.Location = New System.Drawing.Point(74, 85)
        Me.Lbl_UserName.MinimumSize = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.TabIndex = 297
        Me.Lbl_UserName.Text = "............."
        Me.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.ForeColor = System.Drawing.Color.Black
        Me.Lbl_User.Location = New System.Drawing.Point(6, 85)
        Me.Lbl_User.MinimumSize = New System.Drawing.Size(5, 30)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(62, 30)
        Me.Lbl_User.TabIndex = 296
        Me.Lbl_User.Text = "Editor:"
        Me.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblValExp
        '
        Me.LblValExp.AutoSize = True
        Me.LblValExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValExp.ForeColor = System.Drawing.Color.Black
        Me.LblValExp.Location = New System.Drawing.Point(722, 344)
        Me.LblValExp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblValExp.Name = "LblValExp"
        Me.LblValExp.Size = New System.Drawing.Size(75, 30)
        Me.LblValExp.TabIndex = 298
        Me.LblValExp.Text = "............."
        Me.LblValExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblValImp
        '
        Me.LblValImp.AutoSize = True
        Me.LblValImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValImp.ForeColor = System.Drawing.Color.Black
        Me.LblValImp.Location = New System.Drawing.Point(430, 344)
        Me.LblValImp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblValImp.Name = "LblValImp"
        Me.LblValImp.Size = New System.Drawing.Size(75, 30)
        Me.LblValImp.TabIndex = 299
        Me.LblValImp.Text = "............."
        Me.LblValImp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExp
        '
        Me.LblExp.AutoSize = True
        Me.LblExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExp.ForeColor = System.Drawing.Color.Black
        Me.LblExp.Location = New System.Drawing.Point(575, 349)
        Me.LblExp.Name = "LblExp"
        Me.LblExp.Size = New System.Drawing.Size(143, 22)
        Me.LblExp.TabIndex = 300
        Me.LblExp.Text = "Editable Exports"
        '
        'LblImp
        '
        Me.LblImp.AutoSize = True
        Me.LblImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImp.ForeColor = System.Drawing.Color.Black
        Me.LblImp.Location = New System.Drawing.Point(283, 349)
        Me.LblImp.Name = "LblImp"
        Me.LblImp.Size = New System.Drawing.Size(143, 22)
        Me.LblImp.TabIndex = 301
        Me.LblImp.Text = "Editable Imports"
        '
        'LblImpRem
        '
        Me.LblImpRem.AutoSize = True
        Me.LblImpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpRem.ForeColor = System.Drawing.Color.Black
        Me.LblImpRem.Location = New System.Drawing.Point(430, 442)
        Me.LblImpRem.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblImpRem.Name = "LblImpRem"
        Me.LblImpRem.Size = New System.Drawing.Size(75, 30)
        Me.LblImpRem.TabIndex = 302
        Me.LblImpRem.Text = "............."
        Me.LblImpRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblImpComp
        '
        Me.LblImpComp.AutoSize = True
        Me.LblImpComp.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpComp.ForeColor = System.Drawing.Color.Black
        Me.LblImpComp.Location = New System.Drawing.Point(430, 392)
        Me.LblImpComp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblImpComp.Name = "LblImpComp"
        Me.LblImpComp.Size = New System.Drawing.Size(75, 30)
        Me.LblImpComp.TabIndex = 303
        Me.LblImpComp.Text = "............."
        Me.LblImpComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExpComp
        '
        Me.LblExpComp.AutoSize = True
        Me.LblExpComp.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpComp.ForeColor = System.Drawing.Color.Black
        Me.LblExpComp.Location = New System.Drawing.Point(722, 392)
        Me.LblExpComp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblExpComp.Name = "LblExpComp"
        Me.LblExpComp.Size = New System.Drawing.Size(75, 30)
        Me.LblExpComp.TabIndex = 305
        Me.LblExpComp.Text = "............."
        Me.LblExpComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExpRem
        '
        Me.LblExpRem.AutoSize = True
        Me.LblExpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpRem.ForeColor = System.Drawing.Color.Black
        Me.LblExpRem.Location = New System.Drawing.Point(722, 442)
        Me.LblExpRem.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblExpRem.Name = "LblExpRem"
        Me.LblExpRem.Size = New System.Drawing.Size(75, 30)
        Me.LblExpRem.TabIndex = 304
        Me.LblExpRem.Text = "............."
        Me.LblExpRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCompImp
        '
        Me.LblCompImp.AutoSize = True
        Me.LblCompImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblCompImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCompImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompImp.ForeColor = System.Drawing.Color.Black
        Me.LblCompImp.Location = New System.Drawing.Point(289, 392)
        Me.LblCompImp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblCompImp.Name = "LblCompImp"
        Me.LblCompImp.Size = New System.Drawing.Size(97, 30)
        Me.LblCompImp.TabIndex = 307
        Me.LblCompImp.Text = "Completed"
        Me.LblCompImp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRemImp
        '
        Me.LblRemImp.AutoSize = True
        Me.LblRemImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemImp.ForeColor = System.Drawing.Color.Black
        Me.LblRemImp.Location = New System.Drawing.Point(289, 442)
        Me.LblRemImp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblRemImp.Name = "LblRemImp"
        Me.LblRemImp.Size = New System.Drawing.Size(96, 30)
        Me.LblRemImp.TabIndex = 306
        Me.LblRemImp.Text = "Remaining"
        Me.LblRemImp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCompExp
        '
        Me.LblCompExp.AutoSize = True
        Me.LblCompExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblCompExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCompExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompExp.ForeColor = System.Drawing.Color.Black
        Me.LblCompExp.Location = New System.Drawing.Point(592, 392)
        Me.LblCompExp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblCompExp.Name = "LblCompExp"
        Me.LblCompExp.Size = New System.Drawing.Size(97, 30)
        Me.LblCompExp.TabIndex = 309
        Me.LblCompExp.Text = "Completed"
        Me.LblCompExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRemExp
        '
        Me.LblRemExp.AutoSize = True
        Me.LblRemExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemExp.ForeColor = System.Drawing.Color.Black
        Me.LblRemExp.Location = New System.Drawing.Point(592, 442)
        Me.LblRemExp.MinimumSize = New System.Drawing.Size(75, 30)
        Me.LblRemExp.Name = "LblRemExp"
        Me.LblRemExp.Size = New System.Drawing.Size(96, 30)
        Me.LblRemExp.TabIndex = 308
        Me.LblRemExp.Text = "Remaining"
        Me.LblRemExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExports
        '
        Me.LblExports.AutoSize = True
        Me.LblExports.BackColor = System.Drawing.SystemColors.Control
        Me.LblExports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblExports.ForeColor = System.Drawing.Color.White
        Me.LblExports.Location = New System.Drawing.Point(562, 336)
        Me.LblExports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblExports.Name = "LblExports"
        Me.LblExports.Size = New System.Drawing.Size(250, 150)
        Me.LblExports.TabIndex = 363
        Me.LblExports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblImports
        '
        Me.LblImports.AutoSize = True
        Me.LblImports.BackColor = System.Drawing.SystemColors.Control
        Me.LblImports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblImports.ForeColor = System.Drawing.Color.Black
        Me.LblImports.Location = New System.Drawing.Point(274, 333)
        Me.LblImports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblImports.Name = "LblImports"
        Me.LblImports.Size = New System.Drawing.Size(250, 150)
        Me.LblImports.TabIndex = 362
        Me.LblImports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(277, 274)
        Me.Label1.MaximumSize = New System.Drawing.Size(550, 100)
        Me.Label1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 37)
        Me.Label1.TabIndex = 365
        Me.Label1.Text = "Completion Status "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImportDataBindingSource
        '
        Me.ImportDataBindingSource.DataMember = "ImportData"
        Me.ImportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ImportDataTableAdapter
        '
        Me.ImportDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CountryTableAdapter = Nothing
        Me.TableAdapterManager.dateTableTableAdapter = Nothing
        Me.TableAdapterManager.DollarSDRTableAdapter = Nothing
        Me.TableAdapterManager.exchangeRateTableAdapter = Nothing
        Me.TableAdapterManager.EXPORT_TableAdapter = Nothing
        Me.TableAdapterManager.ExportDataTableAdapter = Me.ExportDataTableAdapter
        Me.TableAdapterManager.ExportSummaryTableAdapter = Nothing
        Me.TableAdapterManager.HscodeTableAdapter = Nothing
        Me.TableAdapterManager.ImportDataTableAdapter = Me.ImportDataTableAdapter
        Me.TableAdapterManager.ImportSummaryTableAdapter = Nothing
        Me.TableAdapterManager.index_exportTableAdapter = Nothing
        Me.TableAdapterManager.index_importTableAdapter = Nothing
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
        'ExportDataTableAdapter
        '
        Me.ExportDataTableAdapter.ClearBeforeFill = True
        '
        'ExportDataBindingSource
        '
        Me.ExportDataBindingSource.DataMember = "ExportData"
        Me.ExportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'SupervisorWorkBindingSource
        '
        Me.SupervisorWorkBindingSource.DataMember = "SupervisorWork"
        Me.SupervisorWorkBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'SupervisorWorkTableAdapter
        '
        Me.SupervisorWorkTableAdapter.ClearBeforeFill = True
        '
        'PictureBoxPBS
        '
        Me.PictureBoxPBS.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPBS.Image = CType(resources.GetObject("PictureBoxPBS.Image"), System.Drawing.Image)
        Me.PictureBoxPBS.Location = New System.Drawing.Point(909, 9)
        Me.PictureBoxPBS.Name = "PictureBoxPBS"
        Me.PictureBoxPBS.Size = New System.Drawing.Size(142, 73)
        Me.PictureBoxPBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBS.TabIndex = 368
        Me.PictureBoxPBS.TabStop = False
        '
        'PictureBoxUFD
        '
        Me.PictureBoxUFD.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBoxUFD.Image = CType(resources.GetObject("PictureBoxUFD.Image"), System.Drawing.Image)
        Me.PictureBoxUFD.Location = New System.Drawing.Point(-1, 9)
        Me.PictureBoxUFD.Name = "PictureBoxUFD"
        Me.PictureBoxUFD.Size = New System.Drawing.Size(101, 73)
        Me.PictureBoxUFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUFD.TabIndex = 367
        Me.PictureBoxUFD.TabStop = False
        '
        'LblTitleBar
        '
        Me.LblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblTitleBar.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleBar.ForeColor = System.Drawing.Color.White
        Me.LblTitleBar.Location = New System.Drawing.Point(96, 9)
        Me.LblTitleBar.Name = "LblTitleBar"
        Me.LblTitleBar.Size = New System.Drawing.Size(816, 73)
        Me.LblTitleBar.TabIndex = 366
        Me.LblTitleBar.Text = "Trade Statistics Management Information System (TSMIS)"
        Me.LblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStatusBar
        '
        Me.LblStatusBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblStatusBar.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusBar.ForeColor = System.Drawing.Color.White
        Me.LblStatusBar.Location = New System.Drawing.Point(-5, 538)
        Me.LblStatusBar.Name = "LblStatusBar"
        Me.LblStatusBar.Size = New System.Drawing.Size(1056, 40)
        Me.LblStatusBar.TabIndex = 369
        Me.LblStatusBar.Text = "Powered By: DP-Centre, PBS. Karachi"
        Me.LblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEditImp
        '
        Me.BtnEditImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnEditImp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEditImp.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditImp.ForeColor = System.Drawing.Color.White
        Me.BtnEditImp.Location = New System.Drawing.Point(24, 263)
        Me.BtnEditImp.Name = "BtnEditImp"
        Me.BtnEditImp.Size = New System.Drawing.Size(168, 47)
        Me.BtnEditImp.TabIndex = 196
        Me.BtnEditImp.Text = "Edit Data  "
        Me.BtnEditImp.UseVisualStyleBackColor = False
        '
        'CmbYY
        '
        Me.CmbYY.BackColor = System.Drawing.Color.LightGray
        Me.CmbYY.Font = New System.Drawing.Font("Calibri", 12.75!)
        Me.CmbYY.ForeColor = System.Drawing.Color.Black
        Me.CmbYY.FormattingEnabled = True
        Me.CmbYY.Items.AddRange(New Object() {"2022", "2021", "2020", "2019", "2018", "2017"})
        Me.CmbYY.Location = New System.Drawing.Point(500, 240)
        Me.CmbYY.Name = "CmbYY"
        Me.CmbYY.Size = New System.Drawing.Size(155, 29)
        Me.CmbYY.TabIndex = 371
        '
        'LblYY
        '
        Me.LblYY.AutoSize = True
        Me.LblYY.BackColor = System.Drawing.Color.Transparent
        Me.LblYY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYY.ForeColor = System.Drawing.Color.Black
        Me.LblYY.Location = New System.Drawing.Point(432, 243)
        Me.LblYY.Name = "LblYY"
        Me.LblYY.Size = New System.Drawing.Size(49, 24)
        Me.LblYY.TabIndex = 373
        Me.LblYY.Text = "Year"
        '
        'LblMM
        '
        Me.LblMM.AutoSize = True
        Me.LblMM.BackColor = System.Drawing.Color.Transparent
        Me.LblMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMM.ForeColor = System.Drawing.Color.Black
        Me.LblMM.Location = New System.Drawing.Point(417, 208)
        Me.LblMM.Name = "LblMM"
        Me.LblMM.Size = New System.Drawing.Size(63, 24)
        Me.LblMM.TabIndex = 372
        Me.LblMM.Text = "Month"
        '
        'CmbMM
        '
        Me.CmbMM.BackColor = System.Drawing.Color.LightGray
        Me.CmbMM.DataSource = Me.MonthsBindingSource
        Me.CmbMM.DisplayMember = "Month"
        Me.CmbMM.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMM.ForeColor = System.Drawing.Color.Black
        Me.CmbMM.FormattingEnabled = True
        Me.CmbMM.Location = New System.Drawing.Point(500, 206)
        Me.CmbMM.Name = "CmbMM"
        Me.CmbMM.Size = New System.Drawing.Size(155, 29)
        Me.CmbMM.TabIndex = 370
        Me.CmbMM.ValueMember = "MonthCode"
        '
        'MonthsBindingSource
        '
        Me.MonthsBindingSource.DataMember = "Months"
        Me.MonthsBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(367, 166)
        Me.Label4.MaximumSize = New System.Drawing.Size(550, 100)
        Me.Label4.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 37)
        Me.Label4.TabIndex = 378
        Me.Label4.Text = "Select Base"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightGray
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 12.75!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"NEW", "OLD"})
        Me.ComboBox1.Location = New System.Drawing.Point(500, 166)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 29)
        Me.ComboBox1.TabIndex = 379
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.LightGray
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 12.75!)
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Import ", "Export"})
        Me.ComboBox2.Location = New System.Drawing.Point(500, 280)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(155, 29)
        Me.ComboBox2.TabIndex = 380
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(305, 274)
        Me.Label2.MaximumSize = New System.Drawing.Size(550, 100)
        Me.Label2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 37)
        Me.Label2.TabIndex = 381
        Me.Label2.Text = "Select Trade Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthsTableAdapter
        '
        Me.MonthsTableAdapter.ClearBeforeFill = True
        '
        'EditorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 577)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbYY)
        Me.Controls.Add(Me.LblYY)
        Me.Controls.Add(Me.LblMM)
        Me.Controls.Add(Me.CmbMM)
        Me.Controls.Add(Me.BtnEditImp)
        Me.Controls.Add(Me.LblStatusBar)
        Me.Controls.Add(Me.PictureBoxPBS)
        Me.Controls.Add(Me.PictureBoxUFD)
        Me.Controls.Add(Me.LblTitleBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblCompExp)
        Me.Controls.Add(Me.LblRemExp)
        Me.Controls.Add(Me.LblCompImp)
        Me.Controls.Add(Me.LblRemImp)
        Me.Controls.Add(Me.LblExpComp)
        Me.Controls.Add(Me.LblExpRem)
        Me.Controls.Add(Me.LblImpComp)
        Me.Controls.Add(Me.LblImpRem)
        Me.Controls.Add(Me.LblImp)
        Me.Controls.Add(Me.LblExp)
        Me.Controls.Add(Me.LblValImp)
        Me.Controls.Add(Me.LblValExp)
        Me.Controls.Add(Me.Lbl_UserName)
        Me.Controls.Add(Me.Lbl_User)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.LblExports)
        Me.Controls.Add(Me.LblImports)
        Me.MaximizeBox = False
        Me.Name = "EditorDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditorDashboard"
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Lbl_UserName As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents LblValExp As Label
    Friend WithEvents LblValImp As Label
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents LblExp As Label
    Friend WithEvents LblImp As Label
    Friend WithEvents LblImpRem As Label
    Friend WithEvents LblImpComp As Label
    Friend WithEvents LblExpComp As Label
    Friend WithEvents LblExpRem As Label
    Friend WithEvents LblCompImp As Label
    Friend WithEvents LblRemImp As Label
    Friend WithEvents LblCompExp As Label
    Friend WithEvents LblRemExp As Label
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents LblExports As Label
    Friend WithEvents LblImports As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxPBS As PictureBox
    Friend WithEvents PictureBoxUFD As PictureBox
    Friend WithEvents LblTitleBar As Label
    Friend WithEvents LblStatusBar As Label
    Friend WithEvents BtnEditImp As Button
    Friend WithEvents CmbYY As ComboBox
    Friend WithEvents LblYY As Label
    Friend WithEvents LblMM As Label
    Friend WithEvents CmbMM As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthsBindingSource As BindingSource
    Friend WithEvents MonthsTableAdapter As TradeStatisticsDataSetTableAdapters.MonthsTableAdapter
End Class
