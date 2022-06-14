<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryCalculations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryCalculations))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HscodeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HsDesc = New TradeEdit.HsDesc()
        Me.HSCombo = New TradeEdit.HSCombo()
        Me.HSComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.HscodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HscodeTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.HscodeTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ExportSummaryTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportSummaryTableAdapter()
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.ImportSummaryTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportSummaryTableAdapter()
        Me.ExportSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HscodeTableAdapter1 = New TradeEdit.HSComboTableAdapters.hscodeTableAdapter()
        Me.TableAdapterManager1 = New TradeEdit.HSComboTableAdapters.TableAdapterManager()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HSCombo1 = New TradeEdit.HSCombo()
        Me.HSCombo1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HscodeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HscodeTableAdapter2 = New TradeEdit.HsDescTableAdapters.hscodeTableAdapter()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HscodeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HsDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HscodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.HSCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSCombo1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HscodeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(379, 497)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(260, 29)
        Me.NumericUpDown1.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.HscodeBindingSource2
        Me.ComboBox1.DisplayMember = "HSCODE"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(379, 533)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 26)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "Hscode"
        Me.ComboBox1.Visible = False
        '
        'HscodeBindingSource2
        '
        Me.HscodeBindingSource2.DataMember = "hscode"
        Me.HscodeBindingSource2.DataSource = Me.HsDesc
        '
        'HsDesc
        '
        Me.HsDesc.DataSetName = "HsDesc"
        Me.HsDesc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HSCombo
        '
        Me.HSCombo.DataSetName = "HSCombo"
        Me.HSCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HSComboBindingSource
        '
        Me.HSComboBindingSource.DataSource = Me.HSCombo
        Me.HSComboBindingSource.Position = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(379, 632)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(379, 533)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 27)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "/"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "."
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 23)
        Me.Label1.TabIndex = 9
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HscodeBindingSource
        '
        Me.HscodeBindingSource.DataMember = "Hscode"
        Me.HscodeBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'HscodeTableAdapter
        '
        Me.HscodeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CountryTableAdapter = Nothing
        Me.TableAdapterManager.dateTableTableAdapter = Nothing
        Me.TableAdapterManager.DollarSDRTableAdapter = Nothing
        Me.TableAdapterManager.exchangeRateTableAdapter = Nothing
        Me.TableAdapterManager.EXPORT_TableAdapter = Nothing
        Me.TableAdapterManager.ExportDataTableAdapter = Nothing
        Me.TableAdapterManager.ExportSummaryTableAdapter = Me.ExportSummaryTableAdapter
        Me.TableAdapterManager.HscodeTableAdapter = Me.HscodeTableAdapter
        Me.TableAdapterManager.ImportDataTableAdapter = Me.ImportDataTableAdapter
        Me.TableAdapterManager.ImportSummaryTableAdapter = Me.ImportSummaryTableAdapter
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
        'ExportSummaryTableAdapter
        '
        Me.ExportSummaryTableAdapter.ClearBeforeFill = True
        '
        'ImportDataTableAdapter
        '
        Me.ImportDataTableAdapter.ClearBeforeFill = True
        '
        'ImportSummaryTableAdapter
        '
        Me.ImportSummaryTableAdapter.ClearBeforeFill = True
        '
        'ExportSummaryBindingSource
        '
        Me.ExportSummaryBindingSource.DataMember = "ExportSummary"
        Me.ExportSummaryBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ImportSummaryBindingSource
        '
        Me.ImportSummaryBindingSource.DataMember = "ImportSummary"
        Me.ImportSummaryBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ImportDataBindingSource
        '
        Me.ImportDataBindingSource.DataMember = "ImportData"
        Me.ImportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'HscodeTableAdapter1
        '
        Me.HscodeTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.hscodeTableAdapter = Me.HscodeTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = TradeEdit.HSComboTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton, Me.ToolStripDropDownButton1})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1187, 25)
        Me.FillByToolStrip.TabIndex = 16
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'HSCombo1
        '
        Me.HSCombo1.DataSetName = "HSCombo"
        Me.HSCombo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HSCombo1BindingSource
        '
        Me.HSCombo1BindingSource.DataSource = Me.HSCombo1
        Me.HSCombo1BindingSource.Position = 0
        '
        'HscodeBindingSource1
        '
        Me.HscodeBindingSource1.DataMember = "Hscode"
        Me.HscodeBindingSource1.DataSource = Me.TradeStatisticsDataSet
        '
        'HscodeTableAdapter2
        '
        Me.HscodeTableAdapter2.ClearBeforeFill = True
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(1052, 0)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(135, 32)
        Me.BtnBack.TabIndex = 283
        Me.BtnBack.Text = "Back "
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'SummaryCalculations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 749)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SummaryCalculations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SummaryCalculations"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HscodeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HsDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HscodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.HSCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSCombo1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HscodeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HSComboBindingSource As BindingSource
    Friend WithEvents HSCombo As HSCombo
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents HscodeBindingSource As BindingSource
    Friend WithEvents HscodeTableAdapter As TradeStatisticsDataSetTableAdapters.HscodeTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExportSummaryTableAdapter As TradeStatisticsDataSetTableAdapters.ExportSummaryTableAdapter
    Friend WithEvents ExportSummaryBindingSource As BindingSource
    Friend WithEvents ImportSummaryTableAdapter As TradeStatisticsDataSetTableAdapters.ImportSummaryTableAdapter
    Friend WithEvents ImportSummaryBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents HscodeTableAdapter1 As HSComboTableAdapters.hscodeTableAdapter
    Friend WithEvents TableAdapterManager1 As HSComboTableAdapters.TableAdapterManager
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents HSCombo1BindingSource As BindingSource
    Friend WithEvents HSCombo1 As HSCombo
    Friend WithEvents HscodeBindingSource1 As BindingSource
    Friend WithEvents HsDesc As HsDesc
    Friend WithEvents HscodeBindingSource2 As BindingSource
    Friend WithEvents HscodeTableAdapter2 As HsDescTableAdapters.hscodeTableAdapter
    Friend WithEvents BtnBack As Button
End Class
