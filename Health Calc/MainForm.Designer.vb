<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.radMetric = New System.Windows.Forms.RadioButton()
        Me.radUS = New System.Windows.Forms.RadioButton()
        Me.lblGetStarted = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcBMR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcBAC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcBMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcBodySurfaceArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcTargetHeartRate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalcWHR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblWeightLBS = New System.Windows.Forms.Label()
        Me.lblWeightKG = New System.Windows.Forms.Label()
        Me.lblHeightInches = New System.Windows.Forms.Label()
        Me.lblHeightCM = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.grpSettings.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grpPersonalInfo.SuspendLayout()
        Me.grpGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSettings
        '
        Me.grpSettings.Controls.Add(Me.radMetric)
        Me.grpSettings.Controls.Add(Me.radUS)
        Me.grpSettings.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSettings.Location = New System.Drawing.Point(326, 202)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(129, 80)
        Me.grpSettings.TabIndex = 9
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Units"
        '
        'radMetric
        '
        Me.radMetric.AutoSize = True
        Me.radMetric.Location = New System.Drawing.Point(17, 46)
        Me.radMetric.Name = "radMetric"
        Me.radMetric.Size = New System.Drawing.Size(67, 23)
        Me.radMetric.TabIndex = 6
        Me.radMetric.Text = "Metric"
        Me.radMetric.UseVisualStyleBackColor = True
        '
        'radUS
        '
        Me.radUS.AutoSize = True
        Me.radUS.Location = New System.Drawing.Point(17, 25)
        Me.radUS.Name = "radUS"
        Me.radUS.Size = New System.Drawing.Size(47, 23)
        Me.radUS.TabIndex = 5
        Me.radUS.Text = "US"
        Me.radUS.UseVisualStyleBackColor = True
        '
        'lblGetStarted
        '
        Me.lblGetStarted.BackColor = System.Drawing.Color.Transparent
        Me.lblGetStarted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGetStarted.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGetStarted.Location = New System.Drawing.Point(30, 42)
        Me.lblGetStarted.Name = "lblGetStarted"
        Me.lblGetStarted.Padding = New System.Windows.Forms.Padding(10)
        Me.lblGetStarted.Size = New System.Drawing.Size(425, 60)
        Me.lblGetStarted.TabIndex = 7
        Me.lblGetStarted.Text = "To get started, please enter your information below, then select a calculator fro" &
    "m the menu."
        Me.lblGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.CalculatorsToolStripMenuItem, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.ToolStripMenuItem1, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ToolStripMenuItem2, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileNew.Text = "&New Profile"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileOpen.Text = "&Open Profile"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 6)
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileSave.Text = "&Save Profle"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileSaveAs.Text = "Save Profile &As..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'CalculatorsToolStripMenuItem
        '
        Me.CalculatorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalcBMR, Me.mnuCalcBAC, Me.mnuCalcBMI, Me.mnuCalcBodySurfaceArea, Me.mnuCalcTargetHeartRate, Me.mnuCalcWHR})
        Me.CalculatorsToolStripMenuItem.Name = "CalculatorsToolStripMenuItem"
        Me.CalculatorsToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CalculatorsToolStripMenuItem.Text = "&Calculators"
        '
        'mnuCalcBMR
        '
        Me.mnuCalcBMR.Name = "mnuCalcBMR"
        Me.mnuCalcBMR.Size = New System.Drawing.Size(291, 22)
        Me.mnuCalcBMR.Text = "&Basal &Metabolic Rate Calculator"
        '
        'mnuCalcBAC
        '
        Me.mnuCalcBAC.Name = "mnuCalcBAC"
        Me.mnuCalcBAC.Size = New System.Drawing.Size(291, 22)
        Me.mnuCalcBAC.Text = "Blood &Alcohol Content Calculator"
        '
        'mnuCalcBMI
        '
        Me.mnuCalcBMI.Name = "mnuCalcBMI"
        Me.mnuCalcBMI.Size = New System.Drawing.Size(291, 22)
        Me.mnuCalcBMI.Text = "Body &Mass Index and Body Fat Calculator"
        '
        'mnuCalcBodySurfaceArea
        '
        Me.mnuCalcBodySurfaceArea.Name = "mnuCalcBodySurfaceArea"
        Me.mnuCalcBodySurfaceArea.Size = New System.Drawing.Size(291, 22)
        Me.mnuCalcBodySurfaceArea.Text = "Body &Surface Area Calculator"
        '
        'mnuCalcTargetHeartRate
        '
        Me.mnuCalcTargetHeartRate.Name = "mnuCalcTargetHeartRate"
        Me.mnuCalcTargetHeartRate.Size = New System.Drawing.Size(291, 22)
        Me.mnuCalcTargetHeartRate.Text = "&Target Heart Rate Calculator"
        '
        'mnuCalcWHR
        '
        Me.mnuCalcWHR.Name = "mnuCalcWHR"
        Me.mnuCalcWHR.Size = New System.Drawing.Size(291, 22)
        Me.mnuCalcWHR.Text = "&Waist to Height Ratio"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpHelp, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpHelp
        '
        Me.mnuHelpHelp.Name = "mnuHelpHelp"
        Me.mnuHelpHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpHelp.Size = New System.Drawing.Size(202, 22)
        Me.mnuHelpHelp.Text = "View &Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(202, 22)
        Me.mnuHelpAbout.Text = "&About Health Calculator"
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpPersonalInfo.Controls.Add(Me.lblAge)
        Me.grpPersonalInfo.Controls.Add(Me.txtWeight)
        Me.grpPersonalInfo.Controls.Add(Me.txtHeight)
        Me.grpPersonalInfo.Controls.Add(Me.txtAge)
        Me.grpPersonalInfo.Controls.Add(Me.lblWeightLBS)
        Me.grpPersonalInfo.Controls.Add(Me.lblWeightKG)
        Me.grpPersonalInfo.Controls.Add(Me.lblHeightInches)
        Me.grpPersonalInfo.Controls.Add(Me.lblHeightCM)
        Me.grpPersonalInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPersonalInfo.Location = New System.Drawing.Point(30, 120)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(275, 162)
        Me.grpPersonalInfo.TabIndex = 8
        Me.grpPersonalInfo.TabStop = False
        Me.grpPersonalInfo.Text = "Personal Information"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(101, 36)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 19)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(154, 115)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 26)
        Me.txtWeight.TabIndex = 2
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(154, 72)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 26)
        Me.txtHeight.TabIndex = 1
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(154, 29)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 26)
        Me.txtAge.TabIndex = 0
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWeightLBS
        '
        Me.lblWeightLBS.AutoSize = True
        Me.lblWeightLBS.Location = New System.Drawing.Point(53, 118)
        Me.lblWeightLBS.Name = "lblWeightLBS"
        Me.lblWeightLBS.Size = New System.Drawing.Size(85, 19)
        Me.lblWeightLBS.TabIndex = 6
        Me.lblWeightLBS.Text = "Weight (lbs):"
        Me.lblWeightLBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeightKG
        '
        Me.lblWeightKG.AutoSize = True
        Me.lblWeightKG.Location = New System.Drawing.Point(55, 118)
        Me.lblWeightKG.Name = "lblWeightKG"
        Me.lblWeightKG.Size = New System.Drawing.Size(83, 19)
        Me.lblWeightKG.TabIndex = 5
        Me.lblWeightKG.Text = "Weight (kg):"
        Me.lblWeightKG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblWeightKG.Visible = False
        '
        'lblHeightInches
        '
        Me.lblHeightInches.AutoSize = True
        Me.lblHeightInches.Location = New System.Drawing.Point(36, 75)
        Me.lblHeightInches.Name = "lblHeightInches"
        Me.lblHeightInches.Size = New System.Drawing.Size(102, 19)
        Me.lblHeightInches.TabIndex = 5
        Me.lblHeightInches.Text = "Height (inches):"
        Me.lblHeightInches.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeightCM
        '
        Me.lblHeightCM.AutoSize = True
        Me.lblHeightCM.Location = New System.Drawing.Point(55, 75)
        Me.lblHeightCM.Name = "lblHeightCM"
        Me.lblHeightCM.Size = New System.Drawing.Size(83, 19)
        Me.lblHeightCM.TabIndex = 5
        Me.lblHeightCM.Text = "Height (cm):"
        Me.lblHeightCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHeightCM.Visible = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(17, 46)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(71, 23)
        Me.radFemale.TabIndex = 4
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(17, 25)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(58, 23)
        Me.radMale.TabIndex = 3
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGender.Location = New System.Drawing.Point(326, 120)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(129, 76)
        Me.grpGender.TabIndex = 10
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Select Gender"
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        Me.ofdOpenFile.Filter = "Text files (*.txt)|*.txt"
        Me.ofdOpenFile.Title = "Open Profile"
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Filter = "Text Files (*.txt)|*.txt"
        Me.sfdSaveFile.Title = "Save Profile As"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 301)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.grpSettings)
        Me.Controls.Add(Me.lblGetStarted)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Health Calculator"
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSettings As GroupBox
    Friend WithEvents radMetric As RadioButton
    Friend WithEvents radUS As RadioButton
    Friend WithEvents lblGetStarted As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents CalculatorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents grpPersonalInfo As GroupBox
    Friend WithEvents lblHeightInches As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lblAge As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblHeightCM As Label
    Friend WithEvents lblWeightLBS As Label
    Friend WithEvents lblWeightKG As Label
    Friend WithEvents mnuCalcBMR As ToolStripMenuItem
    Friend WithEvents mnuCalcBAC As ToolStripMenuItem
    Friend WithEvents mnuCalcBMI As ToolStripMenuItem
    Friend WithEvents mnuCalcBodySurfaceArea As ToolStripMenuItem
    Friend WithEvents mnuCalcTargetHeartRate As ToolStripMenuItem
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents sfdSaveFile As SaveFileDialog
    Friend WithEvents mnuCalcWHR As ToolStripMenuItem
End Class
