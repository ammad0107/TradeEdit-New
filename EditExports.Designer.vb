<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditExports
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
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditExports))
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblValExp = New System.Windows.Forms.Label()
        Me.LblExp = New System.Windows.Forms.Label()
        Me.Lbl_UserName = New System.Windows.Forms.Label()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.LblNote2 = New System.Windows.Forms.Label()
        Me.DgvExp = New System.Windows.Forms.DataGridView()
        Me.UnSRec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ExpSNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpTT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpUnitVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpHs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Updated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpHsDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.lblMonthYear = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBoxUFD = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPBS = New System.Windows.Forms.PictureBox()
        Me.LblTitleBar = New System.Windows.Forms.Label()
        Me.LblStatusBar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Replace = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.CountryTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.CountryTableAdapter()
        Me.HscodeTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.HscodeTableAdapter()
        Me.ImportDataTableAdapter1 = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.SupervisorWorkTableAdapter1 = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.HscodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportData1TableAdapter1 = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportData1TableAdapter()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DgvExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HscodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeading
        '
        Me.LblHeading.BackColor = System.Drawing.SystemColors.Control
        Me.LblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.ForeColor = System.Drawing.Color.Black
        Me.LblHeading.Location = New System.Drawing.Point(429, 58)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(387, 23)
        Me.LblHeading.TabIndex = 288
        Me.LblHeading.Text = "Edit Export Records"
        Me.LblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(3, 65)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(135, 32)
        Me.BtnBack.TabIndex = 287
        Me.BtnBack.Text = "Back to DashBoard"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'LblValExp
        '
        Me.LblValExp.AutoSize = True
        Me.LblValExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.LblValExp.ForeColor = System.Drawing.Color.Black
        Me.LblValExp.Location = New System.Drawing.Point(242, 669)
        Me.LblValExp.Name = "LblValExp"
        Me.LblValExp.Size = New System.Drawing.Size(74, 20)
        Me.LblValExp.TabIndex = 291
        Me.LblValExp.Text = "............."
        '
        'LblExp
        '
        Me.LblExp.AutoSize = True
        Me.LblExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExp.ForeColor = System.Drawing.Color.Black
        Me.LblExp.Location = New System.Drawing.Point(12, 669)
        Me.LblExp.Name = "LblExp"
        Me.LblExp.Size = New System.Drawing.Size(224, 20)
        Me.LblExp.TabIndex = 290
        Me.LblExp.Text = "Total Editable Export Records:"
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.AutoSize = True
        Me.Lbl_UserName.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.Black
        Me.Lbl_UserName.Location = New System.Drawing.Point(1161, 664)
        Me.Lbl_UserName.MinimumSize = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.TabIndex = 295
        Me.Lbl_UserName.Text = "\"
        Me.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.ForeColor = System.Drawing.Color.Black
        Me.Lbl_User.Location = New System.Drawing.Point(1093, 664)
        Me.Lbl_User.MinimumSize = New System.Drawing.Size(5, 30)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(55, 30)
        Me.Lbl_User.TabIndex = 294
        Me.Lbl_User.Text = "Editor:"
        Me.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNote2
        '
        Me.LblNote2.AutoSize = True
        Me.LblNote2.BackColor = System.Drawing.Color.LightGreen
        Me.LblNote2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNote2.ForeColor = System.Drawing.Color.Maroon
        Me.LblNote2.Location = New System.Drawing.Point(740, 1)
        Me.LblNote2.Name = "LblNote2"
        Me.LblNote2.Size = New System.Drawing.Size(373, 20)
        Me.LblNote2.TabIndex = 293
        Me.LblNote2.Text = "Editable Entities: Country, Quantity, HS-Code"
        Me.LblNote2.Visible = False
        '
        'DgvExp
        '
        Me.DgvExp.AllowUserToAddRows = False
        Me.DgvExp.AllowUserToDeleteRows = False
        Me.DgvExp.AutoGenerateColumns = False
        Me.DgvExp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvExp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle53
        Me.DgvExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvExp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnSRec, Me.ExpSNo, Me.ExpTT, Me.ExpRT, Me.ExpCNT, Me.CountryName, Me.ExpUnit, Me.ExpQty, Me.ExpVal, Me.ExpUnitVal, Me.ExpHs, Me.Updated, Me.ExpHsDesc})
        Me.DgvExp.DataSource = Me.ExportDataBindingSource
        Me.DgvExp.Location = New System.Drawing.Point(3, 187)
        Me.DgvExp.Name = "DgvExp"
        Me.DgvExp.Size = New System.Drawing.Size(1328, 471)
        Me.DgvExp.TabIndex = 296
        '
        'UnSRec
        '
        Me.UnSRec.DataPropertyName = "UnSRec"
        Me.UnSRec.HeaderText = "UnSRec"
        Me.UnSRec.Name = "UnSRec"
        '
        'ExpSNo
        '
        Me.ExpSNo.DataPropertyName = "SNO"
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black
        Me.ExpSNo.DefaultCellStyle = DataGridViewCellStyle54
        Me.ExpSNo.HeaderText = "SNO"
        Me.ExpSNo.Name = "ExpSNo"
        Me.ExpSNo.ReadOnly = True
        Me.ExpSNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ExpTT
        '
        Me.ExpTT.DataPropertyName = "TT"
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle55.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle55.ForeColor = System.Drawing.Color.Black
        Me.ExpTT.DefaultCellStyle = DataGridViewCellStyle55
        Me.ExpTT.HeaderText = "TT"
        Me.ExpTT.Name = "ExpTT"
        Me.ExpTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExpTT.Width = 40
        '
        'ExpRT
        '
        Me.ExpRT.DataPropertyName = "RT"
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black
        Me.ExpRT.DefaultCellStyle = DataGridViewCellStyle56
        Me.ExpRT.HeaderText = "RT"
        Me.ExpRT.Name = "ExpRT"
        Me.ExpRT.ReadOnly = True
        Me.ExpRT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExpRT.Width = 40
        '
        'ExpCNT
        '
        Me.ExpCNT.DataPropertyName = "CNT"
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle57.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black
        Me.ExpCNT.DefaultCellStyle = DataGridViewCellStyle57
        Me.ExpCNT.HeaderText = "CNT"
        Me.ExpCNT.Name = "ExpCNT"
        Me.ExpCNT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExpCNT.Width = 50
        '
        'CountryName
        '
        Me.CountryName.DataPropertyName = "Country"
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryName.DefaultCellStyle = DataGridViewCellStyle58
        Me.CountryName.HeaderText = "CountryName"
        Me.CountryName.Name = "CountryName"
        Me.CountryName.ReadOnly = True
        Me.CountryName.Width = 115
        '
        'ExpUnit
        '
        Me.ExpUnit.DataPropertyName = "Unit"
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black
        Me.ExpUnit.DefaultCellStyle = DataGridViewCellStyle59
        Me.ExpUnit.HeaderText = "Unit"
        Me.ExpUnit.Name = "ExpUnit"
        Me.ExpUnit.ReadOnly = True
        Me.ExpUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExpUnit.Width = 50
        '
        'ExpQty
        '
        Me.ExpQty.DataPropertyName = "Qty1"
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle60.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black
        Me.ExpQty.DefaultCellStyle = DataGridViewCellStyle60
        Me.ExpQty.HeaderText = "Quantity"
        Me.ExpQty.Name = "ExpQty"
        Me.ExpQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ExpVal
        '
        Me.ExpVal.DataPropertyName = "val"
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle61.ForeColor = System.Drawing.Color.Black
        Me.ExpVal.DefaultCellStyle = DataGridViewCellStyle61
        Me.ExpVal.HeaderText = "Value"
        Me.ExpVal.Name = "ExpVal"
        Me.ExpVal.ReadOnly = True
        Me.ExpVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ExpUnitVal
        '
        Me.ExpUnitVal.DataPropertyName = "UnitVal"
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black
        Me.ExpUnitVal.DefaultCellStyle = DataGridViewCellStyle62
        Me.ExpUnitVal.HeaderText = "Unit Value"
        Me.ExpUnitVal.Name = "ExpUnitVal"
        Me.ExpUnitVal.ReadOnly = True
        Me.ExpUnitVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ExpHs
        '
        Me.ExpHs.DataPropertyName = "hs"
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle63.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle63.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle63.ForeColor = System.Drawing.Color.Black
        Me.ExpHs.DefaultCellStyle = DataGridViewCellStyle63
        Me.ExpHs.HeaderText = "HS Code"
        Me.ExpHs.Name = "ExpHs"
        Me.ExpHs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Updated
        '
        Me.Updated.DataPropertyName = "Updated"
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updated.DefaultCellStyle = DataGridViewCellStyle64
        Me.Updated.HeaderText = "U"
        Me.Updated.Name = "Updated"
        Me.Updated.ReadOnly = True
        Me.Updated.Width = 30
        '
        'ExpHsDesc
        '
        Me.ExpHsDesc.DataPropertyName = "HsDesc"
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle65.ForeColor = System.Drawing.Color.Black
        Me.ExpHsDesc.DefaultCellStyle = DataGridViewCellStyle65
        Me.ExpHsDesc.HeaderText = "HSDescription"
        Me.ExpHsDesc.Name = "ExpHsDesc"
        Me.ExpHsDesc.ReadOnly = True
        Me.ExpHsDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ExpHsDesc.Width = 800
        '
        'ExportDataBindingSource
        '
        Me.ExportDataBindingSource.DataMember = "ExportData"
        Me.ExportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMonthYear
        '
        Me.lblMonthYear.BackColor = System.Drawing.SystemColors.Control
        Me.lblMonthYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonthYear.ForeColor = System.Drawing.Color.Black
        Me.lblMonthYear.Location = New System.Drawing.Point(552, 81)
        Me.lblMonthYear.Name = "lblMonthYear"
        Me.lblMonthYear.Size = New System.Drawing.Size(202, 20)
        Me.lblMonthYear.TabIndex = 298
        Me.lblMonthYear.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 300
        Me.Label1.Text = "Search By HS code "
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBoxSearch.Location = New System.Drawing.Point(3, 156)
        Me.TextBoxSearch.Multiline = True
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(233, 30)
        Me.TextBoxSearch.TabIndex = 299
        Me.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(299, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Search By Country"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.Location = New System.Drawing.Point(270, 156)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 30)
        Me.TextBox1.TabIndex = 305
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(154, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 30)
        Me.Button1.TabIndex = 307
        Me.Button1.Text = "HighLight Entry"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(166, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 30)
        Me.Button2.TabIndex = 310
        Me.Button2.Text = "Reset Entry"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'PictureBoxUFD
        '
        Me.PictureBoxUFD.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBoxUFD.Image = CType(resources.GetObject("PictureBoxUFD.Image"), System.Drawing.Image)
        Me.PictureBoxUFD.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBoxUFD.Name = "PictureBoxUFD"
        Me.PictureBoxUFD.Size = New System.Drawing.Size(101, 57)
        Me.PictureBoxUFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUFD.TabIndex = 313
        Me.PictureBoxUFD.TabStop = False
        '
        'PictureBoxPBS
        '
        Me.PictureBoxPBS.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPBS.Image = CType(resources.GetObject("PictureBoxPBS.Image"), System.Drawing.Image)
        Me.PictureBoxPBS.Location = New System.Drawing.Point(1224, 1)
        Me.PictureBoxPBS.Name = "PictureBoxPBS"
        Me.PictureBoxPBS.Size = New System.Drawing.Size(142, 57)
        Me.PictureBoxPBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBS.TabIndex = 312
        Me.PictureBoxPBS.TabStop = False
        '
        'LblTitleBar
        '
        Me.LblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblTitleBar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleBar.ForeColor = System.Drawing.Color.FloralWhite
        Me.LblTitleBar.Location = New System.Drawing.Point(2, 1)
        Me.LblTitleBar.Name = "LblTitleBar"
        Me.LblTitleBar.Size = New System.Drawing.Size(1227, 57)
        Me.LblTitleBar.TabIndex = 311
        Me.LblTitleBar.Text = "Trade Statistics Management Information System (TSMIS)"
        Me.LblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStatusBar
        '
        Me.LblStatusBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblStatusBar.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusBar.ForeColor = System.Drawing.Color.White
        Me.LblStatusBar.Location = New System.Drawing.Point(5, 695)
        Me.LblStatusBar.Name = "LblStatusBar"
        Me.LblStatusBar.Size = New System.Drawing.Size(1368, 40)
        Me.LblStatusBar.TabIndex = 314
        Me.LblStatusBar.Text = "Powered By: DP-Centre, PBS , Karachi"
        Me.LblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(553, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 18)
        Me.Label5.TabIndex = 322
        Me.Label5.Text = "Search By HS Desc"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox2.Location = New System.Drawing.Point(540, 156)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 30)
        Me.TextBox2.TabIndex = 321
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1208, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 37)
        Me.Button3.TabIndex = 323
        Me.Button3.Text = "Clear Search"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Replace
        '
        Me.Replace.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Replace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Replace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Replace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Replace.ForeColor = System.Drawing.Color.White
        Me.Replace.Location = New System.Drawing.Point(1208, 67)
        Me.Replace.Name = "Replace"
        Me.Replace.Size = New System.Drawing.Size(135, 37)
        Me.Replace.TabIndex = 324
        Me.Replace.Text = "Replace "
        Me.Replace.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1208, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 37)
        Me.Button4.TabIndex = 325
        Me.Button4.Text = "Formula"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox5.Location = New System.Drawing.Point(891, 81)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(233, 30)
        Me.TextBox5.TabIndex = 328
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox5.Visible = False
        Me.TextBox5.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(906, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 18)
        Me.Label6.TabIndex = 329
        Me.Label6.Text = "Search Pending Records"
        Me.Label6.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1080, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 19)
        Me.Label12.TabIndex = 386
        Me.Label12.Text = "Unit Value"
        Me.Label12.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(1078, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 38)
        Me.Label7.TabIndex = 385
        Me.Label7.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(949, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 26)
        Me.Label13.TabIndex = 387
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(953, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 26)
        Me.Label14.TabIndex = 388
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(368, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 27)
        Me.Label17.TabIndex = 395
        Me.Label17.Text = "Data Not Available"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(949, 669)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 331
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(871, 669)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 330
        Me.Label10.Text = "Average:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(683, 669)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 20)
        Me.Label9.TabIndex = 333
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(621, 669)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 332
        Me.Label8.Text = "Count:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(383, 669)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 20)
        Me.Label4.TabIndex = 309
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(331, 669)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 308
        Me.Label3.Text = "Sum:"
        '
        'ExportDataTableAdapter
        '
        Me.ExportDataTableAdapter.ClearBeforeFill = True
        '
        'CountryTableAdapter
        '
        Me.CountryTableAdapter.ClearBeforeFill = True
        '
        'HscodeTableAdapter
        '
        Me.HscodeTableAdapter.ClearBeforeFill = True
        '
        'ImportDataTableAdapter1
        '
        Me.ImportDataTableAdapter1.ClearBeforeFill = True
        '
        'SupervisorWorkTableAdapter1
        '
        Me.SupervisorWorkTableAdapter1.ClearBeforeFill = True
        '
        'HscodeBindingSource
        '
        Me.HscodeBindingSource.DataMember = "Hscode"
        Me.HscodeBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'CountryBindingSource
        '
        Me.CountryBindingSource.DataMember = "Country"
        Me.CountryBindingSource.DataSource = Me.TradeStatisticsDataSet
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
        'ImportDataBindingSource
        '
        Me.ImportDataBindingSource.DataMember = "ImportData"
        Me.ImportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ImportData1TableAdapter1
        '
        Me.ImportData1TableAdapter1.ClearBeforeFill = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(790, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(347, 26)
        Me.Label16.TabIndex = 397
        Me.Label16.Text = "Unit Value Not Found"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label16.Visible = False
        '
        'EditExports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Replace)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblStatusBar)
        Me.Controls.Add(Me.PictureBoxUFD)
        Me.Controls.Add(Me.PictureBoxPBS)
        Me.Controls.Add(Me.LblTitleBar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.lblMonthYear)
        Me.Controls.Add(Me.DgvExp)
        Me.Controls.Add(Me.Lbl_UserName)
        Me.Controls.Add(Me.Lbl_User)
        Me.Controls.Add(Me.LblNote2)
        Me.Controls.Add(Me.LblValExp)
        Me.Controls.Add(Me.LblExp)
        Me.Controls.Add(Me.LblHeading)
        Me.Controls.Add(Me.BtnBack)
        Me.MaximizeBox = False
        Me.Name = "EditExports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditExports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HscodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHeading As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents LblValExp As Label
    Friend WithEvents LblExp As Label
    Friend WithEvents Lbl_UserName As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents LblNote2 As Label
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents CountryBindingSource As BindingSource
    Friend WithEvents CountryTableAdapter As TradeStatisticsDataSetTableAdapters.CountryTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HscodeTableAdapter As TradeStatisticsDataSetTableAdapters.HscodeTableAdapter
    Friend WithEvents HscodeBindingSource As BindingSource
    Friend WithEvents DgvExp As DataGridView
    Friend WithEvents lblMonthYear As Label
    Friend WithEvents ImportDataTableAdapter1 As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents ImportData1TableAdapter1 As TradeStatisticsDataSetTableAdapters.ImportData1TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBoxUFD As PictureBox
    Friend WithEvents PictureBoxPBS As PictureBox
    Friend WithEvents LblTitleBar As Label
    Friend WithEvents LblStatusBar As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Replace As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SupervisorWorkTableAdapter1 As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UnSRec As DataGridViewCheckBoxColumn
    Friend WithEvents ExpSNo As DataGridViewTextBoxColumn
    Friend WithEvents ExpTT As DataGridViewTextBoxColumn
    Friend WithEvents ExpRT As DataGridViewTextBoxColumn
    Friend WithEvents ExpCNT As DataGridViewTextBoxColumn
    Friend WithEvents CountryName As DataGridViewTextBoxColumn
    Friend WithEvents ExpUnit As DataGridViewTextBoxColumn
    Friend WithEvents ExpQty As DataGridViewTextBoxColumn
    Friend WithEvents ExpVal As DataGridViewTextBoxColumn
    Friend WithEvents ExpUnitVal As DataGridViewTextBoxColumn
    Friend WithEvents ExpHs As DataGridViewTextBoxColumn
    Friend WithEvents Updated As DataGridViewTextBoxColumn
    Friend WithEvents ExpHsDesc As DataGridViewTextBoxColumn
    Friend WithEvents Label16 As Label
End Class
