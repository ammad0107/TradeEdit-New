<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.DgvUser = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.LblAssigned = New System.Windows.Forms.Label()
        Me.LblRcdTot = New System.Windows.Forms.Label()
        Me.LblRemaining = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblRcdTotal = New System.Windows.Forms.Label()
        Me.LblTRecords = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        CType(Me.DgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(843, 295)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(130, 81)
        Me.BtnOk.TabIndex = 149
        Me.BtnOk.Text = "Re-Assign"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'DgvUser
        '
        Me.DgvUser.AllowUserToAddRows = False
        Me.DgvUser.AllowUserToDeleteRows = False
        Me.DgvUser.AutoGenerateColumns = False
        Me.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.UserName, Me.FromRecord, Me.ToRecord})
        Me.DgvUser.DataSource = Me.UsersBindingSource
        Me.DgvUser.Location = New System.Drawing.Point(12, 179)
        Me.DgvUser.Name = "DgvUser"
        Me.DgvUser.Size = New System.Drawing.Size(810, 273)
        Me.DgvUser.TabIndex = 300
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "userID"
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.UserName.Width = 200
        '
        'FromRecord
        '
        Me.FromRecord.HeaderText = "From Rec #"
        Me.FromRecord.Name = "FromRecord"
        Me.FromRecord.ReadOnly = True
        Me.FromRecord.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FromRecord.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FromRecord.Width = 200
        '
        'ToRecord
        '
        Me.ToRecord.HeaderText = "To Rec #"
        Me.ToRecord.Name = "ToRecord"
        Me.ToRecord.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ToRecord.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ToRecord.Width = 200
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
        'LblAssigned
        '
        Me.LblAssigned.BackColor = System.Drawing.Color.SteelBlue
        Me.LblAssigned.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssigned.ForeColor = System.Drawing.Color.White
        Me.LblAssigned.Location = New System.Drawing.Point(577, 137)
        Me.LblAssigned.MinimumSize = New System.Drawing.Size(75, 25)
        Me.LblAssigned.Name = "LblAssigned"
        Me.LblAssigned.Size = New System.Drawing.Size(133, 25)
        Me.LblAssigned.TabIndex = 303
        Me.LblAssigned.Text = "------"
        '
        'LblRcdTot
        '
        Me.LblRcdTot.BackColor = System.Drawing.Color.BurlyWood
        Me.LblRcdTot.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRcdTot.ForeColor = System.Drawing.Color.Maroon
        Me.LblRcdTot.Location = New System.Drawing.Point(206, 88)
        Me.LblRcdTot.MinimumSize = New System.Drawing.Size(193, 32)
        Me.LblRcdTot.Name = "LblRcdTot"
        Me.LblRcdTot.Size = New System.Drawing.Size(779, 32)
        Me.LblRcdTot.TabIndex = 302
        Me.LblRcdTot.Text = "-----"
        '
        'LblRemaining
        '
        Me.LblRemaining.BackColor = System.Drawing.Color.SteelBlue
        Me.LblRemaining.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemaining.ForeColor = System.Drawing.Color.White
        Me.LblRemaining.Location = New System.Drawing.Point(828, 136)
        Me.LblRemaining.MinimumSize = New System.Drawing.Size(75, 25)
        Me.LblRemaining.Name = "LblRemaining"
        Me.LblRemaining.Size = New System.Drawing.Size(119, 25)
        Me.LblRemaining.TabIndex = 301
        Me.LblRemaining.Text = "-------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BurlyWood
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(7, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 32)
        Me.Label7.TabIndex = 306
        Me.Label7.Text = "Total Records:"
        '
        'LblRcdTotal
        '
        Me.LblRcdTotal.AutoSize = True
        Me.LblRcdTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRcdTotal.Location = New System.Drawing.Point(482, 136)
        Me.LblRcdTotal.Name = "LblRcdTotal"
        Me.LblRcdTotal.Size = New System.Drawing.Size(89, 24)
        Me.LblRcdTotal.TabIndex = 305
        Me.LblRcdTotal.Text = "Assigned"
        '
        'LblTRecords
        '
        Me.LblTRecords.AutoSize = True
        Me.LblTRecords.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTRecords.Location = New System.Drawing.Point(716, 137)
        Me.LblTRecords.Name = "LblTRecords"
        Me.LblTRecords.Size = New System.Drawing.Size(106, 24)
        Me.LblTRecords.TabIndex = 304
        Me.LblTRecords.Text = "Remaining"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "From ::"
        '
        'lblFrom
        '
        Me.lblFrom.BackColor = System.Drawing.Color.SteelBlue
        Me.lblFrom.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.White
        Me.lblFrom.Location = New System.Drawing.Point(87, 136)
        Me.lblFrom.MinimumSize = New System.Drawing.Size(75, 25)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(79, 25)
        Me.lblFrom.TabIndex = 307
        Me.lblFrom.Text = "------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 310
        Me.Label3.Text = "To ::"
        '
        'lblTo
        '
        Me.lblTo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(229, 135)
        Me.lblTo.MinimumSize = New System.Drawing.Size(75, 25)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(75, 25)
        Me.lblTo.TabIndex = 309
        Me.lblTo.Text = "------"
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
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
        'ImportDataBindingSource
        '
        Me.ImportDataBindingSource.DataMember = "ImportData"
        Me.ImportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ImportDataTableAdapter
        '
        Me.ImportDataTableAdapter.ClearBeforeFill = True
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
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 458)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblRcdTotal)
        Me.Controls.Add(Me.LblTRecords)
        Me.Controls.Add(Me.LblAssigned)
        Me.Controls.Add(Me.LblRcdTot)
        Me.Controls.Add(Me.LblRemaining)
        Me.Controls.Add(Me.DgvUser)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        CType(Me.DgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As TradeStatisticsDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnOk As Button
    Friend WithEvents DgvUser As DataGridView
    Friend WithEvents LblAssigned As Label
    Friend WithEvents LblRcdTot As Label
    Friend WithEvents LblRemaining As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblRcdTotal As Label
    Friend WithEvents LblTRecords As Label
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents FromRecord As DataGridViewTextBoxColumn
    Friend WithEvents ToRecord As DataGridViewTextBoxColumn
End Class
