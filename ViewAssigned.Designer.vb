<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAssigned
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAssigned))
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.SupervisorWorkDataGridView = New System.Windows.Forms.DataGridView()
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.LblAssExp = New System.Windows.Forms.Label()
        Me.LblRemExp = New System.Windows.Forms.Label()
        Me.LblExpAssigned = New System.Windows.Forms.Label()
        Me.LblExpRem = New System.Windows.Forms.Label()
        Me.LblValExp = New System.Windows.Forms.Label()
        Me.LblExp = New System.Windows.Forms.Label()
        Me.LblExports = New System.Windows.Forms.Label()
        Me.LblAssImp = New System.Windows.Forms.Label()
        Me.LblRemImp = New System.Windows.Forms.Label()
        Me.LblImpAssigned = New System.Windows.Forms.Label()
        Me.LblImpRem = New System.Windows.Forms.Label()
        Me.LblValImp = New System.Windows.Forms.Label()
        Me.LblImp = New System.Windows.Forms.Label()
        Me.LblImports = New System.Windows.Forms.Label()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblSummary = New System.Windows.Forms.Label()
        Me.PictureBoxUFD = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPBS = New System.Windows.Forms.PictureBox()
        Me.LblTitleBar = New System.Windows.Forms.Label()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompletedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromRec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToRec1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YY1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MM1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TT1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SupervisorWorkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeading
        '
        Me.LblHeading.BackColor = System.Drawing.SystemColors.Control
        Me.LblHeading.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.ForeColor = System.Drawing.Color.Black
        Me.LblHeading.Location = New System.Drawing.Point(53, 102)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(270, 43)
        Me.LblHeading.TabIndex = 283
        Me.LblHeading.Text = "Editor Progress"
        Me.LblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1226, 78)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(132, 42)
        Me.BtnBack.TabIndex = 278
        Me.BtnBack.Text = "Back to DashBoard"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(533, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 287
        Me.Label1.Text = "Search By UserName"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBoxSearch.Location = New System.Drawing.Point(719, 110)
        Me.TextBoxSearch.Multiline = True
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(238, 30)
        Me.TextBoxSearch.TabIndex = 285
        Me.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SupervisorWorkDataGridView
        '
        Me.SupervisorWorkDataGridView.AllowUserToAddRows = False
        Me.SupervisorWorkDataGridView.AllowUserToDeleteRows = False
        Me.SupervisorWorkDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupervisorWorkDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SupervisorWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupervisorWorkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.CompletedDataGridViewTextBoxColumn, Me.RemainingDataGridViewTextBoxColumn, Me.FromRec1DataGridViewTextBoxColumn, Me.ToRec1DataGridViewTextBoxColumn, Me.YY1DataGridViewTextBoxColumn, Me.MM1DataGridViewTextBoxColumn, Me.TT1DataGridViewTextBoxColumn})
        Me.SupervisorWorkDataGridView.DataSource = Me.SupervisorWorkBindingSource
        Me.SupervisorWorkDataGridView.Location = New System.Drawing.Point(59, 173)
        Me.SupervisorWorkDataGridView.Name = "SupervisorWorkDataGridView"
        Me.SupervisorWorkDataGridView.ReadOnly = True
        Me.SupervisorWorkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupervisorWorkDataGridView.Size = New System.Drawing.Size(1092, 500)
        Me.SupervisorWorkDataGridView.TabIndex = 284
        '
        'SupervisorWorkBindingSource
        '
        Me.SupervisorWorkBindingSource.DataMember = "SupervisorWork"
        Me.SupervisorWorkBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupervisorWorkTableAdapter
        '
        Me.SupervisorWorkTableAdapter.ClearBeforeFill = True
        '
        'LblAssExp
        '
        Me.LblAssExp.AutoSize = True
        Me.LblAssExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblAssExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAssExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssExp.ForeColor = System.Drawing.Color.Black
        Me.LblAssExp.Location = New System.Drawing.Point(1062, 471)
        Me.LblAssExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblAssExp.Name = "LblAssExp"
        Me.LblAssExp.Size = New System.Drawing.Size(100, 30)
        Me.LblAssExp.TabIndex = 343
        Me.LblAssExp.Text = "Assigned:"
        Me.LblAssExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblAssExp.Visible = False
        '
        'LblRemExp
        '
        Me.LblRemExp.AutoSize = True
        Me.LblRemExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemExp.ForeColor = System.Drawing.Color.Black
        Me.LblRemExp.Location = New System.Drawing.Point(1062, 521)
        Me.LblRemExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblRemExp.Name = "LblRemExp"
        Me.LblRemExp.Size = New System.Drawing.Size(101, 30)
        Me.LblRemExp.TabIndex = 342
        Me.LblRemExp.Text = "Remaining:"
        Me.LblRemExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblRemExp.Visible = False
        '
        'LblExpAssigned
        '
        Me.LblExpAssigned.AutoSize = True
        Me.LblExpAssigned.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpAssigned.ForeColor = System.Drawing.Color.Black
        Me.LblExpAssigned.Location = New System.Drawing.Point(1184, 471)
        Me.LblExpAssigned.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExpAssigned.Name = "LblExpAssigned"
        Me.LblExpAssigned.Size = New System.Drawing.Size(100, 30)
        Me.LblExpAssigned.TabIndex = 341
        Me.LblExpAssigned.Text = "............."
        Me.LblExpAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblExpAssigned.Visible = False
        '
        'LblExpRem
        '
        Me.LblExpRem.AutoSize = True
        Me.LblExpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpRem.ForeColor = System.Drawing.Color.Black
        Me.LblExpRem.Location = New System.Drawing.Point(1184, 521)
        Me.LblExpRem.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExpRem.Name = "LblExpRem"
        Me.LblExpRem.Size = New System.Drawing.Size(100, 30)
        Me.LblExpRem.TabIndex = 340
        Me.LblExpRem.Text = "............."
        Me.LblExpRem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblExpRem.Visible = False
        '
        'LblValExp
        '
        Me.LblValExp.AutoSize = True
        Me.LblValExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValExp.ForeColor = System.Drawing.Color.Black
        Me.LblValExp.Location = New System.Drawing.Point(1184, 418)
        Me.LblValExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblValExp.Name = "LblValExp"
        Me.LblValExp.Size = New System.Drawing.Size(100, 30)
        Me.LblValExp.TabIndex = 338
        Me.LblValExp.Text = "............."
        Me.LblValExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblValExp.Visible = False
        '
        'LblExp
        '
        Me.LblExp.AutoSize = True
        Me.LblExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExp.ForeColor = System.Drawing.Color.Black
        Me.LblExp.Location = New System.Drawing.Point(1062, 418)
        Me.LblExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExp.Name = "LblExp"
        Me.LblExp.Size = New System.Drawing.Size(100, 30)
        Me.LblExp.TabIndex = 339
        Me.LblExp.Text = "EXPORTS"
        Me.LblExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblExp.Visible = False
        '
        'LblExports
        '
        Me.LblExports.AutoSize = True
        Me.LblExports.BackColor = System.Drawing.SystemColors.Control
        Me.LblExports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblExports.ForeColor = System.Drawing.Color.White
        Me.LblExports.Location = New System.Drawing.Point(1048, 409)
        Me.LblExports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblExports.Name = "LblExports"
        Me.LblExports.Size = New System.Drawing.Size(250, 150)
        Me.LblExports.TabIndex = 344
        Me.LblExports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblExports.Visible = False
        '
        'LblAssImp
        '
        Me.LblAssImp.AutoSize = True
        Me.LblAssImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblAssImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAssImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssImp.ForeColor = System.Drawing.Color.Black
        Me.LblAssImp.Location = New System.Drawing.Point(1062, 288)
        Me.LblAssImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblAssImp.Name = "LblAssImp"
        Me.LblAssImp.Size = New System.Drawing.Size(100, 30)
        Me.LblAssImp.TabIndex = 336
        Me.LblAssImp.Text = "Assigned:"
        Me.LblAssImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblAssImp.Visible = False
        '
        'LblRemImp
        '
        Me.LblRemImp.AutoSize = True
        Me.LblRemImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemImp.ForeColor = System.Drawing.Color.Black
        Me.LblRemImp.Location = New System.Drawing.Point(1062, 338)
        Me.LblRemImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblRemImp.Name = "LblRemImp"
        Me.LblRemImp.Size = New System.Drawing.Size(101, 30)
        Me.LblRemImp.TabIndex = 335
        Me.LblRemImp.Text = "Remaining:"
        Me.LblRemImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblRemImp.Visible = False
        '
        'LblImpAssigned
        '
        Me.LblImpAssigned.AutoSize = True
        Me.LblImpAssigned.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpAssigned.ForeColor = System.Drawing.Color.Black
        Me.LblImpAssigned.Location = New System.Drawing.Point(1184, 288)
        Me.LblImpAssigned.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImpAssigned.Name = "LblImpAssigned"
        Me.LblImpAssigned.Size = New System.Drawing.Size(100, 30)
        Me.LblImpAssigned.TabIndex = 334
        Me.LblImpAssigned.Text = "............."
        Me.LblImpAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblImpAssigned.Visible = False
        '
        'LblImpRem
        '
        Me.LblImpRem.AutoSize = True
        Me.LblImpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpRem.ForeColor = System.Drawing.Color.Black
        Me.LblImpRem.Location = New System.Drawing.Point(1184, 338)
        Me.LblImpRem.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImpRem.Name = "LblImpRem"
        Me.LblImpRem.Size = New System.Drawing.Size(100, 30)
        Me.LblImpRem.TabIndex = 333
        Me.LblImpRem.Text = "............."
        Me.LblImpRem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblImpRem.Visible = False
        '
        'LblValImp
        '
        Me.LblValImp.AutoSize = True
        Me.LblValImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValImp.ForeColor = System.Drawing.Color.Black
        Me.LblValImp.Location = New System.Drawing.Point(1184, 235)
        Me.LblValImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblValImp.Name = "LblValImp"
        Me.LblValImp.Size = New System.Drawing.Size(100, 30)
        Me.LblValImp.TabIndex = 331
        Me.LblValImp.Text = "............."
        Me.LblValImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblValImp.Visible = False
        '
        'LblImp
        '
        Me.LblImp.AutoSize = True
        Me.LblImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImp.ForeColor = System.Drawing.Color.Black
        Me.LblImp.Location = New System.Drawing.Point(1062, 235)
        Me.LblImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImp.Name = "LblImp"
        Me.LblImp.Size = New System.Drawing.Size(100, 30)
        Me.LblImp.TabIndex = 332
        Me.LblImp.Text = "IMPORTS"
        Me.LblImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblImp.Visible = False
        '
        'LblImports
        '
        Me.LblImports.AutoSize = True
        Me.LblImports.BackColor = System.Drawing.SystemColors.Control
        Me.LblImports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImports.ForeColor = System.Drawing.Color.White
        Me.LblImports.Location = New System.Drawing.Point(1048, 226)
        Me.LblImports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblImports.Name = "LblImports"
        Me.LblImports.Size = New System.Drawing.Size(250, 150)
        Me.LblImports.TabIndex = 337
        Me.LblImports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblImports.Visible = False
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
        Me.TableAdapterManager.Lp_Release_ExpTableAdapter = Nothing
        Me.TableAdapterManager.Lp_Release_ImpTableAdapter = Nothing
        Me.TableAdapterManager.MonthsTableAdapter = Nothing
        Me.TableAdapterManager.PRALExpDataTableAdapter = Nothing
        Me.TableAdapterManager.PRALImpDataTableAdapter = Nothing
        Me.TableAdapterManager.RouteTableAdapter = Nothing
        Me.TableAdapterManager.rs_delTableAdapter = Nothing
        Me.TableAdapterManager.SupervisorWorkTableAdapter = Me.SupervisorWorkTableAdapter
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
        'LblSummary
        '
        Me.LblSummary.AutoSize = True
        Me.LblSummary.BackColor = System.Drawing.SystemColors.Control
        Me.LblSummary.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSummary.ForeColor = System.Drawing.Color.Black
        Me.LblSummary.Location = New System.Drawing.Point(1094, 222)
        Me.LblSummary.MaximumSize = New System.Drawing.Size(310, 100)
        Me.LblSummary.MinimumSize = New System.Drawing.Size(0, 30)
        Me.LblSummary.Name = "LblSummary"
        Me.LblSummary.Size = New System.Drawing.Size(309, 52)
        Me.LblSummary.TabIndex = 361
        Me.LblSummary.Text = "Summary Assigned / Not Assigned  (Previous Month)"
        Me.LblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSummary.Visible = False
        '
        'PictureBoxUFD
        '
        Me.PictureBoxUFD.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBoxUFD.Image = CType(resources.GetObject("PictureBoxUFD.Image"), System.Drawing.Image)
        Me.PictureBoxUFD.Location = New System.Drawing.Point(0, -3)
        Me.PictureBoxUFD.Name = "PictureBoxUFD"
        Me.PictureBoxUFD.Size = New System.Drawing.Size(101, 57)
        Me.PictureBoxUFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUFD.TabIndex = 364
        Me.PictureBoxUFD.TabStop = False
        '
        'PictureBoxPBS
        '
        Me.PictureBoxPBS.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPBS.Image = CType(resources.GetObject("PictureBoxPBS.Image"), System.Drawing.Image)
        Me.PictureBoxPBS.Location = New System.Drawing.Point(1226, -3)
        Me.PictureBoxPBS.Name = "PictureBoxPBS"
        Me.PictureBoxPBS.Size = New System.Drawing.Size(142, 57)
        Me.PictureBoxPBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBS.TabIndex = 363
        Me.PictureBoxPBS.TabStop = False
        '
        'LblTitleBar
        '
        Me.LblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblTitleBar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleBar.ForeColor = System.Drawing.Color.FloralWhite
        Me.LblTitleBar.Location = New System.Drawing.Point(0, -3)
        Me.LblTitleBar.Name = "LblTitleBar"
        Me.LblTitleBar.Size = New System.Drawing.Size(1227, 57)
        Me.LblTitleBar.TabIndex = 362
        Me.LblTitleBar.Text = "Trade Statistics Managementent Information System (TSMIS)"
        Me.LblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompletedDataGridViewTextBoxColumn
        '
        Me.CompletedDataGridViewTextBoxColumn.DataPropertyName = "Completed"
        Me.CompletedDataGridViewTextBoxColumn.HeaderText = "Completed"
        Me.CompletedDataGridViewTextBoxColumn.Name = "CompletedDataGridViewTextBoxColumn"
        Me.CompletedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemainingDataGridViewTextBoxColumn
        '
        Me.RemainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining"
        Me.RemainingDataGridViewTextBoxColumn.HeaderText = "Remaining"
        Me.RemainingDataGridViewTextBoxColumn.Name = "RemainingDataGridViewTextBoxColumn"
        Me.RemainingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FromRec1DataGridViewTextBoxColumn
        '
        Me.FromRec1DataGridViewTextBoxColumn.DataPropertyName = "FromRec1"
        Me.FromRec1DataGridViewTextBoxColumn.HeaderText = "From Rec"
        Me.FromRec1DataGridViewTextBoxColumn.Name = "FromRec1DataGridViewTextBoxColumn"
        Me.FromRec1DataGridViewTextBoxColumn.ReadOnly = True
        Me.FromRec1DataGridViewTextBoxColumn.Width = 130
        '
        'ToRec1DataGridViewTextBoxColumn
        '
        Me.ToRec1DataGridViewTextBoxColumn.DataPropertyName = "ToRec1"
        Me.ToRec1DataGridViewTextBoxColumn.HeaderText = "To Rec"
        Me.ToRec1DataGridViewTextBoxColumn.Name = "ToRec1DataGridViewTextBoxColumn"
        Me.ToRec1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'YY1DataGridViewTextBoxColumn
        '
        Me.YY1DataGridViewTextBoxColumn.DataPropertyName = "YY1"
        Me.YY1DataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YY1DataGridViewTextBoxColumn.Name = "YY1DataGridViewTextBoxColumn"
        Me.YY1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'MM1DataGridViewTextBoxColumn
        '
        Me.MM1DataGridViewTextBoxColumn.DataPropertyName = "MM1"
        Me.MM1DataGridViewTextBoxColumn.HeaderText = "Month"
        Me.MM1DataGridViewTextBoxColumn.Name = "MM1DataGridViewTextBoxColumn"
        Me.MM1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TT1DataGridViewTextBoxColumn
        '
        Me.TT1DataGridViewTextBoxColumn.DataPropertyName = "TT1"
        Me.TT1DataGridViewTextBoxColumn.HeaderText = "Trade Type"
        Me.TT1DataGridViewTextBoxColumn.Name = "TT1DataGridViewTextBoxColumn"
        Me.TT1DataGridViewTextBoxColumn.ReadOnly = True
        Me.TT1DataGridViewTextBoxColumn.Width = 130
        '
        'ViewAssigned
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PictureBoxUFD)
        Me.Controls.Add(Me.PictureBoxPBS)
        Me.Controls.Add(Me.LblTitleBar)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.SupervisorWorkDataGridView)
        Me.Controls.Add(Me.LblHeading)
        Me.Controls.Add(Me.BtnBack)
        Me.MaximizeBox = False
        Me.Name = "ViewAssigned"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewAssigned"
        CType(Me.SupervisorWorkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHeading As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents SupervisorWorkDataGridView As DataGridView
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents LblAssExp As Label
    Friend WithEvents LblRemExp As Label
    Friend WithEvents LblExpAssigned As Label
    Friend WithEvents LblExpRem As Label
    Friend WithEvents LblValExp As Label
    Friend WithEvents LblExp As Label
    Friend WithEvents LblExports As Label
    Friend WithEvents LblAssImp As Label
    Friend WithEvents LblRemImp As Label
    Friend WithEvents LblImpAssigned As Label
    Friend WithEvents LblImpRem As Label
    Friend WithEvents LblValImp As Label
    Friend WithEvents LblImp As Label
    Friend WithEvents LblImports As Label
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents LblSummary As Label
    Friend WithEvents PictureBoxUFD As PictureBox
    Friend WithEvents PictureBoxPBS As PictureBox
    Friend WithEvents LblTitleBar As Label
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompletedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromRec1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToRec1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YY1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MM1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TT1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
