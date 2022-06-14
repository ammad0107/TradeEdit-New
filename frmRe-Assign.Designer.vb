<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRe_Assign
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
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Completed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.BtnreAssgn = New System.Windows.Forms.Button()
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeading
        '
        Me.LblHeading.BackColor = System.Drawing.Color.MidnightBlue
        Me.LblHeading.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeading.ForeColor = System.Drawing.Color.White
        Me.LblHeading.Location = New System.Drawing.Point(12, 61)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(401, 37)
        Me.LblHeading.TabIndex = 288
        Me.LblHeading.Text = "WORK RE-ASSIGNMENT"
        Me.LblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.Location = New System.Drawing.Point(812, 66)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(182, 39)
        Me.BtnBack.TabIndex = 297
        Me.BtnBack.Text = "Back to DashBoard"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserName, Me.Total, Me.Completed, Me.Remaining, Me.TT, Me.FromRec, Me.ToRec})
        Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(754, 355)
        Me.DataGridView1.TabIndex = 299
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "UserName"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 70
        '
        'Completed
        '
        Me.Completed.DataPropertyName = "Completed"
        Me.Completed.HeaderText = "Completed"
        Me.Completed.Name = "Completed"
        Me.Completed.ReadOnly = True
        Me.Completed.Width = 70
        '
        'Remaining
        '
        Me.Remaining.DataPropertyName = "Remaining"
        Me.Remaining.HeaderText = "Remaining"
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        Me.Remaining.Width = 70
        '
        'TT
        '
        Me.TT.DataPropertyName = "TT"
        Me.TT.HeaderText = "TT"
        Me.TT.Name = "TT"
        Me.TT.ReadOnly = True
        '
        'FromRec
        '
        Me.FromRec.DataPropertyName = "FromRec"
        Me.FromRec.HeaderText = "FromRec"
        Me.FromRec.Name = "FromRec"
        '
        'ToRec
        '
        Me.ToRec.DataPropertyName = "ToRec"
        Me.ToRec.HeaderText = "ToRec"
        Me.ToRec.Name = "ToRec"
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
        'BtnreAssgn
        '
        Me.BtnreAssgn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnreAssgn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnreAssgn.Location = New System.Drawing.Point(812, 311)
        Me.BtnreAssgn.Name = "BtnreAssgn"
        Me.BtnreAssgn.Size = New System.Drawing.Size(182, 131)
        Me.BtnreAssgn.TabIndex = 300
        Me.BtnreAssgn.Text = "Re-Assign Work"
        Me.BtnreAssgn.UseVisualStyleBackColor = True
        '
        'SupervisorWorkTableAdapter
        '
        Me.SupervisorWorkTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SupervisorWorkTableAdapter = Me.SupervisorWorkTableAdapter
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
        'ExportDataBindingSource
        '
        Me.ExportDataBindingSource.DataMember = "ExportData"
        Me.ExportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'ExportDataTableAdapter
        '
        Me.ExportDataTableAdapter.ClearBeforeFill = True
        '
        'frmRe_Assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1020, 600)
        Me.Controls.Add(Me.BtnreAssgn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblHeading)
        Me.Name = "frmRe_Assign"
        Me.Text = "frmRe_Assign"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblHeading As Label
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BtnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnreAssgn As Button
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Completed As DataGridViewTextBoxColumn
    Friend WithEvents Remaining As DataGridViewTextBoxColumn
    Friend WithEvents TT As DataGridViewTextBoxColumn
    Friend WithEvents FromRec As DataGridViewTextBoxColumn
    Friend WithEvents ToRec As DataGridViewTextBoxColumn
End Class
