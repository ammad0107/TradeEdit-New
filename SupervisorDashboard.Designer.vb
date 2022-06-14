<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupervisorDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupervisorDashboard))
        Me.BtnImpViewAssigned = New System.Windows.Forms.Button()
        Me.BtnImpAssign = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Lbl_UserName = New System.Windows.Forms.Label()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditRec_Exp = New System.Windows.Forms.Button()
        Me.btnEditRec_Imp = New System.Windows.Forms.Button()
        Me.btnEditorImport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExpViewAssigned = New System.Windows.Forms.Button()
        Me.btnexpAssign = New System.Windows.Forms.Button()
        Me.btnReAsgn_Exp = New System.Windows.Forms.Button()
        Me.btnReAssign_Imp = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
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
        Me.LblImp = New System.Windows.Forms.Label()
        Me.LblImports = New System.Windows.Forms.Label()
        Me.CmbYY = New System.Windows.Forms.ComboBox()
        Me.LblYY = New System.Windows.Forms.Label()
        Me.LblMM = New System.Windows.Forms.Label()
        Me.CmbMM = New System.Windows.Forms.ComboBox()
        Me.MonthsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradeStatisticsDataSet = New TradeEdit.TradeStatisticsDataSet()
        Me.BtnSummary = New System.Windows.Forms.Button()
        Me.ImportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter()
        Me.ExportDataTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter()
        Me.ExportSummaryTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ExportSummaryTableAdapter()
        Me.ImportSummaryTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.ImportSummaryTableAdapter()
        Me.MonthsTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.MonthsTableAdapter()
        Me.lblimpFinal = New System.Windows.Forms.Label()
        Me.lblExpFinal = New System.Windows.Forms.Label()
        Me.LblValImp = New System.Windows.Forms.Label()
        Me.PictureBoxUFD = New System.Windows.Forms.PictureBox()
        Me.LblTitleBar = New System.Windows.Forms.Label()
        Me.LblStatusBar = New System.Windows.Forms.Label()
        Me.PictureBoxPBS = New System.Windows.Forms.PictureBox()
        Me.ImportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New TradeEdit.TradeStatisticsDataSetTableAdapters.TableAdapterManager()
        Me.ExportDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupervisorWorkTableAdapter = New TradeEdit.TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter()
        Me.GroupBox.SuspendLayout()
        CType(Me.MonthsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnImpViewAssigned
        '
        Me.BtnImpViewAssigned.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnImpViewAssigned.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImpViewAssigned.Enabled = False
        Me.BtnImpViewAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnImpViewAssigned.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.BtnImpViewAssigned.ForeColor = System.Drawing.Color.White
        Me.BtnImpViewAssigned.Location = New System.Drawing.Point(19, 205)
        Me.BtnImpViewAssigned.Name = "BtnImpViewAssigned"
        Me.BtnImpViewAssigned.Size = New System.Drawing.Size(343, 32)
        Me.BtnImpViewAssigned.TabIndex = 203
        Me.BtnImpViewAssigned.Text = "VIEW IMPORT DATA PROGRESS"
        Me.BtnImpViewAssigned.UseVisualStyleBackColor = False
        '
        'BtnImpAssign
        '
        Me.BtnImpAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnImpAssign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImpAssign.Enabled = False
        Me.BtnImpAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnImpAssign.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpAssign.ForeColor = System.Drawing.Color.White
        Me.BtnImpAssign.Location = New System.Drawing.Point(19, 169)
        Me.BtnImpAssign.Name = "BtnImpAssign"
        Me.BtnImpAssign.Size = New System.Drawing.Size(343, 32)
        Me.BtnImpAssign.TabIndex = 202
        Me.BtnImpAssign.Text = "ASSIGN IMPORT DATA"
        Me.BtnImpAssign.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(911, 95)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(130, 42)
        Me.BtnLogout.TabIndex = 280
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.Black
        Me.Lbl_UserName.Location = New System.Drawing.Point(123, 82)
        Me.Lbl_UserName.MinimumSize = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_UserName.TabIndex = 299
        Me.Lbl_UserName.Text = "............."
        Me.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.ForeColor = System.Drawing.Color.Black
        Me.Lbl_User.Location = New System.Drawing.Point(18, 82)
        Me.Lbl_User.MinimumSize = New System.Drawing.Size(5, 30)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_User.TabIndex = 298
        Me.Lbl_User.Text = "Supervisor:"
        Me.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox.Controls.Add(Me.Button4)
        Me.GroupBox.Controls.Add(Me.Button3)
        Me.GroupBox.Controls.Add(Me.Button2)
        Me.GroupBox.Controls.Add(Me.Button1)
        Me.GroupBox.Controls.Add(Me.btnEditRec_Exp)
        Me.GroupBox.Controls.Add(Me.btnEditRec_Imp)
        Me.GroupBox.Controls.Add(Me.btnEditorImport)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.btnExpViewAssigned)
        Me.GroupBox.Controls.Add(Me.btnexpAssign)
        Me.GroupBox.Controls.Add(Me.BtnImpViewAssigned)
        Me.GroupBox.Controls.Add(Me.BtnImpAssign)
        Me.GroupBox.Location = New System.Drawing.Point(25, 122)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(384, 522)
        Me.GroupBox.TabIndex = 300
        Me.GroupBox.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(19, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(343, 35)
        Me.Button4.TabIndex = 363
        Me.Button4.Text = "Set Unit Value"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(19, 478)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(343, 34)
        Me.Button3.TabIndex = 362
        Me.Button3.Text = "Edit Export Summary"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(19, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(343, 34)
        Me.Button2.TabIndex = 361
        Me.Button2.Text = "Edit Import Summary"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(343, 35)
        Me.Button1.TabIndex = 360
        Me.Button1.Text = "Clear Supervisor Table"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnEditRec_Exp
        '
        Me.btnEditRec_Exp.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnEditRec_Exp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditRec_Exp.Enabled = False
        Me.btnEditRec_Exp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditRec_Exp.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.btnEditRec_Exp.ForeColor = System.Drawing.Color.White
        Me.btnEditRec_Exp.Location = New System.Drawing.Point(19, 438)
        Me.btnEditRec_Exp.Name = "btnEditRec_Exp"
        Me.btnEditRec_Exp.Size = New System.Drawing.Size(343, 34)
        Me.btnEditRec_Exp.TabIndex = 359
        Me.btnEditRec_Exp.Text = "View Editor Work (Rec By Rec)"
        Me.btnEditRec_Exp.UseVisualStyleBackColor = False
        '
        'btnEditRec_Imp
        '
        Me.btnEditRec_Imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnEditRec_Imp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditRec_Imp.Enabled = False
        Me.btnEditRec_Imp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditRec_Imp.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.btnEditRec_Imp.ForeColor = System.Drawing.Color.White
        Me.btnEditRec_Imp.Location = New System.Drawing.Point(19, 243)
        Me.btnEditRec_Imp.Name = "btnEditRec_Imp"
        Me.btnEditRec_Imp.Size = New System.Drawing.Size(343, 34)
        Me.btnEditRec_Imp.TabIndex = 358
        Me.btnEditRec_Imp.Text = "View Editor Work (Rec By Rec)"
        Me.btnEditRec_Imp.UseVisualStyleBackColor = False
        '
        'btnEditorImport
        '
        Me.btnEditorImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnEditorImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditorImport.Enabled = False
        Me.btnEditorImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditorImport.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditorImport.ForeColor = System.Drawing.Color.White
        Me.btnEditorImport.Location = New System.Drawing.Point(19, 19)
        Me.btnEditorImport.Name = "btnEditorImport"
        Me.btnEditorImport.Size = New System.Drawing.Size(343, 35)
        Me.btnEditorImport.TabIndex = 356
        Me.btnEditorImport.Text = "Editor Classification (Imp/Exp)"
        Me.btnEditorImport.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 319)
        Me.Label2.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 355
        Me.Label2.Text = "EXPORTS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 135)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 30)
        Me.Label1.TabIndex = 348
        Me.Label1.Text = "IMPORTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExpViewAssigned
        '
        Me.btnExpViewAssigned.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnExpViewAssigned.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpViewAssigned.Enabled = False
        Me.btnExpViewAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpViewAssigned.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.btnExpViewAssigned.ForeColor = System.Drawing.Color.White
        Me.btnExpViewAssigned.Location = New System.Drawing.Point(19, 396)
        Me.btnExpViewAssigned.Name = "btnExpViewAssigned"
        Me.btnExpViewAssigned.Size = New System.Drawing.Size(343, 36)
        Me.btnExpViewAssigned.TabIndex = 205
        Me.btnExpViewAssigned.Text = "VIEW EXPORT DATA PROGRESS"
        Me.btnExpViewAssigned.UseVisualStyleBackColor = False
        '
        'btnexpAssign
        '
        Me.btnexpAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnexpAssign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpAssign.Enabled = False
        Me.btnexpAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexpAssign.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.btnexpAssign.ForeColor = System.Drawing.Color.White
        Me.btnexpAssign.Location = New System.Drawing.Point(19, 352)
        Me.btnexpAssign.Name = "btnexpAssign"
        Me.btnexpAssign.Size = New System.Drawing.Size(343, 38)
        Me.btnexpAssign.TabIndex = 204
        Me.btnexpAssign.Text = "ASSIGN EXPORT DATA"
        Me.btnexpAssign.UseVisualStyleBackColor = False
        '
        'btnReAsgn_Exp
        '
        Me.btnReAsgn_Exp.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnReAsgn_Exp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReAsgn_Exp.Enabled = False
        Me.btnReAsgn_Exp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReAsgn_Exp.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.btnReAsgn_Exp.ForeColor = System.Drawing.Color.White
        Me.btnReAsgn_Exp.Location = New System.Drawing.Point(477, 590)
        Me.btnReAsgn_Exp.Name = "btnReAsgn_Exp"
        Me.btnReAsgn_Exp.Size = New System.Drawing.Size(343, 35)
        Me.btnReAsgn_Exp.TabIndex = 360
        Me.btnReAsgn_Exp.Text = "RE-ASSIGN WORK"
        Me.btnReAsgn_Exp.UseVisualStyleBackColor = False
        Me.btnReAsgn_Exp.Visible = False
        '
        'btnReAssign_Imp
        '
        Me.btnReAssign_Imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnReAssign_Imp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReAssign_Imp.Enabled = False
        Me.btnReAssign_Imp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReAssign_Imp.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.btnReAssign_Imp.ForeColor = System.Drawing.Color.White
        Me.btnReAssign_Imp.Location = New System.Drawing.Point(471, 599)
        Me.btnReAssign_Imp.Name = "btnReAssign_Imp"
        Me.btnReAssign_Imp.Size = New System.Drawing.Size(343, 35)
        Me.btnReAssign_Imp.TabIndex = 357
        Me.btnReAssign_Imp.Text = "RE-ASSIGN WORK"
        Me.btnReAssign_Imp.UseVisualStyleBackColor = False
        Me.btnReAssign_Imp.Visible = False
        '
        'LblAssExp
        '
        Me.LblAssExp.AutoSize = True
        Me.LblAssExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblAssExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAssExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssExp.ForeColor = System.Drawing.Color.Black
        Me.LblAssExp.Location = New System.Drawing.Point(763, 358)
        Me.LblAssExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblAssExp.Name = "LblAssExp"
        Me.LblAssExp.Size = New System.Drawing.Size(100, 30)
        Me.LblAssExp.TabIndex = 358
        Me.LblAssExp.Text = "Assigned:"
        Me.LblAssExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRemExp
        '
        Me.LblRemExp.AutoSize = True
        Me.LblRemExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemExp.ForeColor = System.Drawing.Color.Black
        Me.LblRemExp.Location = New System.Drawing.Point(763, 408)
        Me.LblRemExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblRemExp.Name = "LblRemExp"
        Me.LblRemExp.Size = New System.Drawing.Size(101, 30)
        Me.LblRemExp.TabIndex = 357
        Me.LblRemExp.Text = "Remaining:"
        Me.LblRemExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExpAssigned
        '
        Me.LblExpAssigned.AutoSize = True
        Me.LblExpAssigned.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpAssigned.ForeColor = System.Drawing.Color.Black
        Me.LblExpAssigned.Location = New System.Drawing.Point(885, 358)
        Me.LblExpAssigned.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExpAssigned.Name = "LblExpAssigned"
        Me.LblExpAssigned.Size = New System.Drawing.Size(100, 30)
        Me.LblExpAssigned.TabIndex = 356
        Me.LblExpAssigned.Text = "............."
        Me.LblExpAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExpRem
        '
        Me.LblExpRem.AutoSize = True
        Me.LblExpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblExpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExpRem.ForeColor = System.Drawing.Color.Black
        Me.LblExpRem.Location = New System.Drawing.Point(885, 408)
        Me.LblExpRem.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExpRem.Name = "LblExpRem"
        Me.LblExpRem.Size = New System.Drawing.Size(100, 30)
        Me.LblExpRem.TabIndex = 355
        Me.LblExpRem.Text = "............."
        Me.LblExpRem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblValExp
        '
        Me.LblValExp.AutoSize = True
        Me.LblValExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValExp.ForeColor = System.Drawing.Color.Black
        Me.LblValExp.Location = New System.Drawing.Point(885, 305)
        Me.LblValExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblValExp.Name = "LblValExp"
        Me.LblValExp.Size = New System.Drawing.Size(100, 30)
        Me.LblValExp.TabIndex = 353
        Me.LblValExp.Text = "............."
        Me.LblValExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExp
        '
        Me.LblExp.AutoSize = True
        Me.LblExp.BackColor = System.Drawing.SystemColors.Control
        Me.LblExp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExp.ForeColor = System.Drawing.Color.Black
        Me.LblExp.Location = New System.Drawing.Point(763, 305)
        Me.LblExp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblExp.Name = "LblExp"
        Me.LblExp.Size = New System.Drawing.Size(100, 30)
        Me.LblExp.TabIndex = 354
        Me.LblExp.Text = "EXPORTS"
        Me.LblExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblExports
        '
        Me.LblExports.AutoSize = True
        Me.LblExports.BackColor = System.Drawing.SystemColors.Control
        Me.LblExports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblExports.ForeColor = System.Drawing.Color.White
        Me.LblExports.Location = New System.Drawing.Point(749, 299)
        Me.LblExports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblExports.Name = "LblExports"
        Me.LblExports.Size = New System.Drawing.Size(250, 150)
        Me.LblExports.TabIndex = 359
        Me.LblExports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAssImp
        '
        Me.LblAssImp.AutoSize = True
        Me.LblAssImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblAssImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAssImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAssImp.ForeColor = System.Drawing.Color.Black
        Me.LblAssImp.Location = New System.Drawing.Point(488, 358)
        Me.LblAssImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblAssImp.Name = "LblAssImp"
        Me.LblAssImp.Size = New System.Drawing.Size(100, 30)
        Me.LblAssImp.TabIndex = 351
        Me.LblAssImp.Text = "Assigned:"
        Me.LblAssImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRemImp
        '
        Me.LblRemImp.AutoSize = True
        Me.LblRemImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblRemImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRemImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemImp.ForeColor = System.Drawing.Color.Black
        Me.LblRemImp.Location = New System.Drawing.Point(488, 408)
        Me.LblRemImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblRemImp.Name = "LblRemImp"
        Me.LblRemImp.Size = New System.Drawing.Size(101, 30)
        Me.LblRemImp.TabIndex = 350
        Me.LblRemImp.Text = "Remaining:"
        Me.LblRemImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpAssigned
        '
        Me.LblImpAssigned.AutoSize = True
        Me.LblImpAssigned.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpAssigned.ForeColor = System.Drawing.Color.Black
        Me.LblImpAssigned.Location = New System.Drawing.Point(610, 358)
        Me.LblImpAssigned.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImpAssigned.Name = "LblImpAssigned"
        Me.LblImpAssigned.Size = New System.Drawing.Size(100, 30)
        Me.LblImpAssigned.TabIndex = 349
        Me.LblImpAssigned.Text = "............."
        Me.LblImpAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpRem
        '
        Me.LblImpRem.AutoSize = True
        Me.LblImpRem.BackColor = System.Drawing.SystemColors.Control
        Me.LblImpRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpRem.ForeColor = System.Drawing.Color.Black
        Me.LblImpRem.Location = New System.Drawing.Point(610, 408)
        Me.LblImpRem.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImpRem.Name = "LblImpRem"
        Me.LblImpRem.Size = New System.Drawing.Size(100, 30)
        Me.LblImpRem.TabIndex = 348
        Me.LblImpRem.Text = "............."
        Me.LblImpRem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImp
        '
        Me.LblImp.AutoSize = True
        Me.LblImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblImp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImp.ForeColor = System.Drawing.Color.Black
        Me.LblImp.Location = New System.Drawing.Point(488, 305)
        Me.LblImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblImp.Name = "LblImp"
        Me.LblImp.Size = New System.Drawing.Size(100, 30)
        Me.LblImp.TabIndex = 347
        Me.LblImp.Text = "IMPORTS"
        Me.LblImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImports
        '
        Me.LblImports.AutoSize = True
        Me.LblImports.BackColor = System.Drawing.SystemColors.Control
        Me.LblImports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblImports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblImports.ForeColor = System.Drawing.Color.Black
        Me.LblImports.Location = New System.Drawing.Point(474, 296)
        Me.LblImports.MinimumSize = New System.Drawing.Size(250, 150)
        Me.LblImports.Name = "LblImports"
        Me.LblImports.Size = New System.Drawing.Size(250, 150)
        Me.LblImports.TabIndex = 352
        Me.LblImports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbYY
        '
        Me.CmbYY.BackColor = System.Drawing.Color.LightGray
        Me.CmbYY.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbYY.ForeColor = System.Drawing.Color.Black
        Me.CmbYY.FormattingEnabled = True
        Me.CmbYY.Items.AddRange(New Object() {"2021", "2020", "2019", "2018", "2017"})
        Me.CmbYY.Location = New System.Drawing.Point(530, 129)
        Me.CmbYY.Name = "CmbYY"
        Me.CmbYY.Size = New System.Drawing.Size(155, 31)
        Me.CmbYY.TabIndex = 363
        '
        'LblYY
        '
        Me.LblYY.AutoSize = True
        Me.LblYY.BackColor = System.Drawing.Color.Transparent
        Me.LblYY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYY.ForeColor = System.Drawing.Color.Black
        Me.LblYY.Location = New System.Drawing.Point(462, 132)
        Me.LblYY.Name = "LblYY"
        Me.LblYY.Size = New System.Drawing.Size(49, 24)
        Me.LblYY.TabIndex = 365
        Me.LblYY.Text = "Year"
        '
        'LblMM
        '
        Me.LblMM.AutoSize = True
        Me.LblMM.BackColor = System.Drawing.Color.Transparent
        Me.LblMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMM.ForeColor = System.Drawing.Color.Black
        Me.LblMM.Location = New System.Drawing.Point(447, 97)
        Me.LblMM.Name = "LblMM"
        Me.LblMM.Size = New System.Drawing.Size(63, 24)
        Me.LblMM.TabIndex = 364
        Me.LblMM.Text = "Month"
        '
        'CmbMM
        '
        Me.CmbMM.BackColor = System.Drawing.Color.LightGray
        Me.CmbMM.DataSource = Me.MonthsBindingSource
        Me.CmbMM.DisplayMember = "Month"
        Me.CmbMM.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMM.ForeColor = System.Drawing.Color.Black
        Me.CmbMM.FormattingEnabled = True
        Me.CmbMM.Location = New System.Drawing.Point(530, 95)
        Me.CmbMM.Name = "CmbMM"
        Me.CmbMM.Size = New System.Drawing.Size(155, 31)
        Me.CmbMM.TabIndex = 362
        Me.CmbMM.ValueMember = "MonthCode"
        '
        'MonthsBindingSource
        '
        Me.MonthsBindingSource.DataMember = "Months"
        Me.MonthsBindingSource.DataSource = Me.TradeStatisticsDataSet
        '
        'TradeStatisticsDataSet
        '
        Me.TradeStatisticsDataSet.DataSetName = "TradeStatisticsDataSet"
        Me.TradeStatisticsDataSet.EnforceConstraints = False
        Me.TradeStatisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSummary
        '
        Me.BtnSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSummary.ForeColor = System.Drawing.Color.White
        Me.BtnSummary.Image = CType(resources.GetObject("BtnSummary.Image"), System.Drawing.Image)
        Me.BtnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSummary.Location = New System.Drawing.Point(492, 186)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(218, 43)
        Me.BtnSummary.TabIndex = 366
        Me.BtnSummary.Text = "Show Summary"
        Me.BtnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSummary.UseVisualStyleBackColor = False
        '
        'ImportDataTableAdapter
        '
        Me.ImportDataTableAdapter.ClearBeforeFill = True
        '
        'ExportDataTableAdapter
        '
        Me.ExportDataTableAdapter.ClearBeforeFill = True
        '
        'ExportSummaryTableAdapter
        '
        Me.ExportSummaryTableAdapter.ClearBeforeFill = True
        '
        'ImportSummaryTableAdapter
        '
        Me.ImportSummaryTableAdapter.ClearBeforeFill = True
        '
        'MonthsTableAdapter
        '
        Me.MonthsTableAdapter.ClearBeforeFill = True
        '
        'lblimpFinal
        '
        Me.lblimpFinal.AutoSize = True
        Me.lblimpFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblimpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimpFinal.ForeColor = System.Drawing.Color.Black
        Me.lblimpFinal.Location = New System.Drawing.Point(473, 267)
        Me.lblimpFinal.Name = "lblimpFinal"
        Me.lblimpFinal.Size = New System.Drawing.Size(74, 20)
        Me.lblimpFinal.TabIndex = 367
        Me.lblimpFinal.Text = "............."
        Me.lblimpFinal.Visible = False
        '
        'lblExpFinal
        '
        Me.lblExpFinal.AutoSize = True
        Me.lblExpFinal.BackColor = System.Drawing.SystemColors.Control
        Me.lblExpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpFinal.ForeColor = System.Drawing.Color.Black
        Me.lblExpFinal.Location = New System.Drawing.Point(748, 267)
        Me.lblExpFinal.Name = "lblExpFinal"
        Me.lblExpFinal.Size = New System.Drawing.Size(74, 20)
        Me.lblExpFinal.TabIndex = 368
        Me.lblExpFinal.Text = "............."
        Me.lblExpFinal.Visible = False
        '
        'LblValImp
        '
        Me.LblValImp.AutoSize = True
        Me.LblValImp.BackColor = System.Drawing.SystemColors.Control
        Me.LblValImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValImp.ForeColor = System.Drawing.Color.Black
        Me.LblValImp.Location = New System.Drawing.Point(610, 305)
        Me.LblValImp.MinimumSize = New System.Drawing.Size(100, 30)
        Me.LblValImp.Name = "LblValImp"
        Me.LblValImp.Size = New System.Drawing.Size(100, 30)
        Me.LblValImp.TabIndex = 346
        Me.LblValImp.Text = "............."
        Me.LblValImp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxUFD
        '
        Me.PictureBoxUFD.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBoxUFD.Image = CType(resources.GetObject("PictureBoxUFD.Image"), System.Drawing.Image)
        Me.PictureBoxUFD.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBoxUFD.Name = "PictureBoxUFD"
        Me.PictureBoxUFD.Size = New System.Drawing.Size(101, 73)
        Me.PictureBoxUFD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUFD.TabIndex = 370
        Me.PictureBoxUFD.TabStop = False
        '
        'LblTitleBar
        '
        Me.LblTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblTitleBar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleBar.ForeColor = System.Drawing.Color.White
        Me.LblTitleBar.Location = New System.Drawing.Point(93, -1)
        Me.LblTitleBar.Name = "LblTitleBar"
        Me.LblTitleBar.Size = New System.Drawing.Size(816, 73)
        Me.LblTitleBar.TabIndex = 369
        Me.LblTitleBar.Text = "Trade Statistics Management Information System (TSMIS)"
        Me.LblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStatusBar
        '
        Me.LblStatusBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LblStatusBar.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusBar.ForeColor = System.Drawing.Color.White
        Me.LblStatusBar.Location = New System.Drawing.Point(-8, 672)
        Me.LblStatusBar.Name = "LblStatusBar"
        Me.LblStatusBar.Size = New System.Drawing.Size(1069, 40)
        Me.LblStatusBar.TabIndex = 372
        Me.LblStatusBar.Text = "Powered By: DP-Centre, PBS, Karachi"
        Me.LblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxPBS
        '
        Me.PictureBoxPBS.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPBS.Image = CType(resources.GetObject("PictureBoxPBS.Image"), System.Drawing.Image)
        Me.PictureBoxPBS.Location = New System.Drawing.Point(906, -1)
        Me.PictureBoxPBS.Name = "PictureBoxPBS"
        Me.PictureBoxPBS.Size = New System.Drawing.Size(142, 73)
        Me.PictureBoxPBS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPBS.TabIndex = 371
        Me.PictureBoxPBS.TabStop = False
        '
        'ImportDataBindingSource
        '
        Me.ImportDataBindingSource.DataMember = "ImportData"
        Me.ImportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
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
        'ExportDataBindingSource
        '
        Me.ExportDataBindingSource.DataMember = "ExportData"
        Me.ExportDataBindingSource.DataSource = Me.TradeStatisticsDataSet
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
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.TradeStatisticsDataSet
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
        'SupervisorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1082, 709)
        Me.Controls.Add(Me.btnReAsgn_Exp)
        Me.Controls.Add(Me.LblStatusBar)
        Me.Controls.Add(Me.btnReAssign_Imp)
        Me.Controls.Add(Me.PictureBoxPBS)
        Me.Controls.Add(Me.PictureBoxUFD)
        Me.Controls.Add(Me.LblTitleBar)
        Me.Controls.Add(Me.lblExpFinal)
        Me.Controls.Add(Me.lblimpFinal)
        Me.Controls.Add(Me.BtnSummary)
        Me.Controls.Add(Me.CmbYY)
        Me.Controls.Add(Me.LblYY)
        Me.Controls.Add(Me.LblMM)
        Me.Controls.Add(Me.CmbMM)
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
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Lbl_UserName)
        Me.Controls.Add(Me.Lbl_User)
        Me.Controls.Add(Me.BtnLogout)
        Me.MaximizeBox = False
        Me.Name = "SupervisorDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SupervisorDashboard"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.MonthsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeStatisticsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnImpViewAssigned As Button
    Friend WithEvents BtnImpAssign As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Lbl_UserName As Label
    Friend WithEvents Lbl_User As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
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
    Friend WithEvents LblImp As Label
    Friend WithEvents LblImports As Label
    Friend WithEvents TradeStatisticsDataSet As TradeStatisticsDataSet
    Friend WithEvents ImportDataBindingSource As BindingSource
    Friend WithEvents ImportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ImportDataTableAdapter
    Friend WithEvents TableAdapterManager As TradeStatisticsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExportDataTableAdapter As TradeStatisticsDataSetTableAdapters.ExportDataTableAdapter
    Friend WithEvents ExportDataBindingSource As BindingSource
    Friend WithEvents CmbYY As ComboBox
    Friend WithEvents LblYY As Label
    Friend WithEvents LblMM As Label
    Friend WithEvents CmbMM As ComboBox
    Friend WithEvents BtnSummary As Button
    Friend WithEvents ExportSummaryBindingSource As BindingSource
    Friend WithEvents ExportSummaryTableAdapter As TradeStatisticsDataSetTableAdapters.ExportSummaryTableAdapter
    Friend WithEvents ImportSummaryBindingSource As BindingSource
    Friend WithEvents ImportSummaryTableAdapter As TradeStatisticsDataSetTableAdapters.ImportSummaryTableAdapter
    Friend WithEvents MonthsBindingSource As BindingSource
    Friend WithEvents MonthsTableAdapter As TradeStatisticsDataSetTableAdapters.MonthsTableAdapter
    Friend WithEvents lblimpFinal As Label
    Friend WithEvents lblExpFinal As Label
    Friend WithEvents btnExpViewAssigned As Button
    Friend WithEvents btnexpAssign As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblValImp As Label
    Friend WithEvents btnEditorImport As Button
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents btnReAssign_Imp As Button
    Friend WithEvents btnEditRec_Imp As Button
    Friend WithEvents btnEditRec_Exp As Button
    Friend WithEvents btnReAsgn_Exp As Button
    Friend WithEvents PictureBoxUFD As PictureBox
    Friend WithEvents LblTitleBar As Label
    Friend WithEvents LblStatusBar As Label
    Friend WithEvents PictureBoxPBS As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SupervisorWorkBindingSource As BindingSource
    Friend WithEvents SupervisorWorkTableAdapter As TradeStatisticsDataSetTableAdapters.SupervisorWorkTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
