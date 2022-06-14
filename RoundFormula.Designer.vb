<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoundFormula
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HSCombo = New TradeEdit.HSCombo()
        Me.HscodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HscodeTableAdapter = New TradeEdit.HSComboTableAdapters.hscodeTableAdapter()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ExportSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportSummaryTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportSummaryTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HscodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 23)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "."
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "/"
        Me.Label3.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(442, 531)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 27)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(442, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExportDataBindingSource
        '
        Me.ExportDataBindingSource.DataMember = "ExportData"
        Me.ExportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ExportDataTableAdapter
        '
        Me.ExportDataTableAdapter.ClearBeforeFill = True
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
        'ImportDataTableAdapter
        '
        Me.ImportDataTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.HSCombo
        Me.ComboBox1.DisplayMember = "hscode.HSCODE"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(442, 531)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 26)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "hscode.HSCODE"
        Me.ComboBox1.Visible = False
        '
        'HSCombo
        '
        Me.HSCombo.DataSetName = "HSCombo"
        Me.HSCombo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HscodeBindingSource
        '
        Me.HscodeBindingSource.DataMember = "hscode"
        Me.HscodeBindingSource.DataSource = Me.HSCombo
        '
        'HscodeTableAdapter
        '
        Me.HscodeTableAdapter.ClearBeforeFill = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(442, 495)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(260, 29)
        Me.NumericUpDown1.TabIndex = 8
        '
        'ExportSummaryBindingSource
        '
        Me.ExportSummaryBindingSource.DataMember = "ExportSummary"
        Me.ExportSummaryBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ExportSummaryTableAdapter
        '
        Me.ExportSummaryTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(200, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 31)
        Me.Label4.TabIndex = 9
        '
        'RoundFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 710)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RoundFormula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HscodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents HSCombo As HSCombo
    Friend WithEvents HscodeBindingSource As BindingSource
    Friend WithEvents HscodeTableAdapter As HSComboTableAdapters.hscodeTableAdapter
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ExportSummaryBindingSource As BindingSource
    Friend WithEvents ExportSummaryTableAdapter As TradeStatisticsDataSetTableAdapters.ExportSummaryTableAdapter
    Friend WithEvents Label4 As Label
    'Friend WithEvents HSCode As HSCode
    'Friend WithEvents HscodeBindingSource As BindingSource
    'Friend WithEvents HscodeTableAdapter As HSCodeTableAdapters.hscodeTableAdapter
End Class
