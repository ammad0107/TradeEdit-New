<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReassignWork
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet2 = New TradeEdit.TradeStatisticsDataSet2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.usersTableAdapter()
        Me.UsersTableAdapter1 = New TradeEdit.TradeStatisticsDataSet2TableAdapters.usersTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompletedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromRecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToRecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.ImportDataTableAdapter1 = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.ExportDataTableAdapter1 = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        CType(Me.UsersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(718, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 32)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "New Assigned"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Already Assigned"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(265, 386)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 22)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(64, 386)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(130, 22)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(265, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(64, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(351, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Assign More"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UsersBindingSource1
        Me.ComboBox1.DisplayMember = "UserName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(194, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "userID"
        '
        'UsersBindingSource1
        '
        Me.UsersBindingSource1.DataMember = "users"
        Me.UsersBindingSource1.DataSource = Me.TradeStatisticsDataSet2
        '
        'TradeStatisticsDataSet2
        '
        Me.TradeStatisticsDataSet2.DataSetName = "TradeStatisticsDataSet2"
        Me.TradeStatisticsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = " Select Employee Name"
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.CompletedDataGridViewTextBoxColumn, Me.RemainingDataGridViewTextBoxColumn, Me.TTDataGridViewTextBoxColumn, Me.FromRecDataGridViewTextBoxColumn, Me.ToRecDataGridViewTextBoxColumn, Me.YYDataGridViewTextBoxColumn, Me.MMDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SupervisorWorkBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(812, 165)
        Me.DataGridView1.TabIndex = 19
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "userID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'CompletedDataGridViewTextBoxColumn
        '
        Me.CompletedDataGridViewTextBoxColumn.DataPropertyName = "Completed"
        Me.CompletedDataGridViewTextBoxColumn.HeaderText = "Completed"
        Me.CompletedDataGridViewTextBoxColumn.Name = "CompletedDataGridViewTextBoxColumn"
        '
        'RemainingDataGridViewTextBoxColumn
        '
        Me.RemainingDataGridViewTextBoxColumn.DataPropertyName = "Remaining"
        Me.RemainingDataGridViewTextBoxColumn.HeaderText = "Remaining"
        Me.RemainingDataGridViewTextBoxColumn.Name = "RemainingDataGridViewTextBoxColumn"
        '
        'TTDataGridViewTextBoxColumn
        '
        Me.TTDataGridViewTextBoxColumn.DataPropertyName = "TT"
        Me.TTDataGridViewTextBoxColumn.HeaderText = "TT"
        Me.TTDataGridViewTextBoxColumn.Name = "TTDataGridViewTextBoxColumn"
        '
        'FromRecDataGridViewTextBoxColumn
        '
        Me.FromRecDataGridViewTextBoxColumn.DataPropertyName = "FromRec1"
        Me.FromRecDataGridViewTextBoxColumn.HeaderText = "FromRec"
        Me.FromRecDataGridViewTextBoxColumn.Name = "FromRecDataGridViewTextBoxColumn"
        '
        'ToRecDataGridViewTextBoxColumn
        '
        Me.ToRecDataGridViewTextBoxColumn.DataPropertyName = "ToRec1"
        Me.ToRecDataGridViewTextBoxColumn.HeaderText = "ToRec"
        Me.ToRecDataGridViewTextBoxColumn.Name = "ToRecDataGridViewTextBoxColumn"
        '
        'YYDataGridViewTextBoxColumn
        '
        Me.YYDataGridViewTextBoxColumn.DataPropertyName = "YY1"
        Me.YYDataGridViewTextBoxColumn.HeaderText = "YY"
        Me.YYDataGridViewTextBoxColumn.Name = "YYDataGridViewTextBoxColumn"
        '
        'MMDataGridViewTextBoxColumn
        '
        Me.MMDataGridViewTextBoxColumn.DataPropertyName = "MM1"
        Me.MMDataGridViewTextBoxColumn.HeaderText = "MM"
        Me.MMDataGridViewTextBoxColumn.Name = "MMDataGridViewTextBoxColumn"
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
        'ImportDataTableAdapter1
        '
        Me.ImportDataTableAdapter1.ClearBeforeFill = True
        '
        'ExportDataTableAdapter1
        '
        Me.ExportDataTableAdapter1.ClearBeforeFill = True
        '
        'ReassignWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 485)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ReassignWork"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReassignWork"
        CType(Me.UsersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As TradeStatisticsDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TradeStatisticsDataSet2 As TradeStatisticsDataSet2
    Friend WithEvents UsersBindingSource1 As BindingSource
    Friend WithEvents UsersTableAdapter1 As TradeStatisticsDataSet2TableAdapters.usersTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents ImportDataTableAdapter1 As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents ExportDataTableAdapter1 As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompletedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromRecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToRecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
