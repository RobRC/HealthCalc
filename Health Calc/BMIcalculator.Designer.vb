<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMIcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMIcalculator))
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.grpBMI = New System.Windows.Forms.GroupBox()
        Me.lblClassification = New System.Windows.Forms.Label()
        Me.lblClassificationLabel = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblBMIlbl = New System.Windows.Forms.Label()
        Me.lblWeightLBL = New System.Windows.Forms.Label()
        Me.lblHeightLBL = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblFatMassLabel = New System.Windows.Forms.Label()
        Me.lblLeanMass = New System.Windows.Forms.Label()
        Me.lblFatMass = New System.Windows.Forms.Label()
        Me.lblBFLabel = New System.Windows.Forms.Label()
        Me.lblBodyFat = New System.Windows.Forms.Label()
        Me.lblLeanMassLabel = New System.Windows.Forms.Label()
        Me.grpBFP = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculateBMI = New System.Windows.Forms.Button()
        Me.lklHelpTip = New System.Windows.Forms.LinkLabel()
        Me.btnHelpTip = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBMI.SuspendLayout()
        Me.grpBFP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(255, 372)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(116, 32)
        Me.btnCLose.TabIndex = 2
        Me.btnCLose.Text = "&Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'grpBMI
        '
        Me.grpBMI.Controls.Add(Me.lblClassification)
        Me.grpBMI.Controls.Add(Me.lblClassificationLabel)
        Me.grpBMI.Controls.Add(Me.lblBMI)
        Me.grpBMI.Controls.Add(Me.lblWeight)
        Me.grpBMI.Controls.Add(Me.lblBMIlbl)
        Me.grpBMI.Controls.Add(Me.lblWeightLBL)
        Me.grpBMI.Controls.Add(Me.lblHeightLBL)
        Me.grpBMI.Controls.Add(Me.lblHeight)
        Me.grpBMI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBMI.Location = New System.Drawing.Point(13, 50)
        Me.grpBMI.Name = "grpBMI"
        Me.grpBMI.Size = New System.Drawing.Size(359, 178)
        Me.grpBMI.TabIndex = 6
        Me.grpBMI.TabStop = False
        Me.grpBMI.Text = "Body Mass Index"
        '
        'lblClassification
        '
        Me.lblClassification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassification.Location = New System.Drawing.Point(245, 132)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(100, 26)
        Me.lblClassification.TabIndex = 18
        Me.lblClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClassificationLabel
        '
        Me.lblClassificationLabel.AutoSize = True
        Me.lblClassificationLabel.Location = New System.Drawing.Point(123, 136)
        Me.lblClassificationLabel.Name = "lblClassificationLabel"
        Me.lblClassificationLabel.Size = New System.Drawing.Size(91, 19)
        Me.lblClassificationLabel.TabIndex = 17
        Me.lblClassificationLabel.Text = "Classification:"
        '
        'lblBMI
        '
        Me.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBMI.Location = New System.Drawing.Point(245, 97)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(100, 26)
        Me.lblBMI.TabIndex = 13
        Me.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeight.Location = New System.Drawing.Point(245, 62)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(100, 26)
        Me.lblWeight.TabIndex = 12
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBMIlbl
        '
        Me.lblBMIlbl.AutoSize = True
        Me.lblBMIlbl.Location = New System.Drawing.Point(94, 101)
        Me.lblBMIlbl.Name = "lblBMIlbl"
        Me.lblBMIlbl.Size = New System.Drawing.Size(120, 19)
        Me.lblBMIlbl.TabIndex = 16
        Me.lblBMIlbl.Text = "Body Mass Index:"
        '
        'lblWeightLBL
        '
        Me.lblWeightLBL.AutoSize = True
        Me.lblWeightLBL.Location = New System.Drawing.Point(158, 66)
        Me.lblWeightLBL.Name = "lblWeightLBL"
        Me.lblWeightLBL.Size = New System.Drawing.Size(54, 19)
        Me.lblWeightLBL.TabIndex = 14
        Me.lblWeightLBL.Text = "Weight:"
        '
        'lblHeightLBL
        '
        Me.lblHeightLBL.AutoSize = True
        Me.lblHeightLBL.Location = New System.Drawing.Point(163, 31)
        Me.lblHeightLBL.Name = "lblHeightLBL"
        Me.lblHeightLBL.Size = New System.Drawing.Size(51, 19)
        Me.lblHeightLBL.TabIndex = 11
        Me.lblHeightLBL.Text = "Height:"
        '
        'lblHeight
        '
        Me.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeight.Location = New System.Drawing.Point(245, 27)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(100, 26)
        Me.lblHeight.TabIndex = 15
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFatMassLabel
        '
        Me.lblFatMassLabel.AutoSize = True
        Me.lblFatMassLabel.Location = New System.Drawing.Point(144, 58)
        Me.lblFatMassLabel.Name = "lblFatMassLabel"
        Me.lblFatMassLabel.Size = New System.Drawing.Size(69, 19)
        Me.lblFatMassLabel.TabIndex = 5
        Me.lblFatMassLabel.Text = "Fat Mass:"
        '
        'lblLeanMass
        '
        Me.lblLeanMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLeanMass.Location = New System.Drawing.Point(244, 89)
        Me.lblLeanMass.Name = "lblLeanMass"
        Me.lblLeanMass.Size = New System.Drawing.Size(100, 26)
        Me.lblLeanMass.TabIndex = 4
        Me.lblLeanMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFatMass
        '
        Me.lblFatMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFatMass.Location = New System.Drawing.Point(244, 54)
        Me.lblFatMass.Name = "lblFatMass"
        Me.lblFatMass.Size = New System.Drawing.Size(100, 26)
        Me.lblFatMass.TabIndex = 22
        Me.lblFatMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBFLabel
        '
        Me.lblBFLabel.AutoSize = True
        Me.lblBFLabel.Location = New System.Drawing.Point(144, 23)
        Me.lblBFLabel.Name = "lblBFLabel"
        Me.lblBFLabel.Size = New System.Drawing.Size(69, 19)
        Me.lblBFLabel.TabIndex = 23
        Me.lblBFLabel.Text = "Body Fat:"
        '
        'lblBodyFat
        '
        Me.lblBodyFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBodyFat.Location = New System.Drawing.Point(244, 19)
        Me.lblBodyFat.Name = "lblBodyFat"
        Me.lblBodyFat.Size = New System.Drawing.Size(100, 26)
        Me.lblBodyFat.TabIndex = 9
        Me.lblBodyFat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeanMassLabel
        '
        Me.lblLeanMassLabel.AutoSize = True
        Me.lblLeanMassLabel.Location = New System.Drawing.Point(134, 93)
        Me.lblLeanMassLabel.Name = "lblLeanMassLabel"
        Me.lblLeanMassLabel.Size = New System.Drawing.Size(79, 19)
        Me.lblLeanMassLabel.TabIndex = 10
        Me.lblLeanMassLabel.Text = "Lean Mass:"
        '
        'grpBFP
        '
        Me.grpBFP.Controls.Add(Me.lblLeanMass)
        Me.grpBFP.Controls.Add(Me.lblFatMass)
        Me.grpBFP.Controls.Add(Me.lblLeanMassLabel)
        Me.grpBFP.Controls.Add(Me.lblFatMassLabel)
        Me.grpBFP.Controls.Add(Me.lblBFLabel)
        Me.grpBFP.Controls.Add(Me.lblBodyFat)
        Me.grpBFP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBFP.Location = New System.Drawing.Point(12, 234)
        Me.grpBFP.Name = "grpBFP"
        Me.grpBFP.Size = New System.Drawing.Size(360, 132)
        Me.grpBFP.TabIndex = 12
        Me.grpBFP.TabStop = False
        Me.grpBFP.Text = "Body Fat Percentage"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.GhostWhite
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(134, 372)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 32)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCalculateBMI
        '
        Me.btnCalculateBMI.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculateBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateBMI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateBMI.Location = New System.Drawing.Point(12, 372)
        Me.btnCalculateBMI.Name = "btnCalculateBMI"
        Me.btnCalculateBMI.Size = New System.Drawing.Size(116, 32)
        Me.btnCalculateBMI.TabIndex = 0
        Me.btnCalculateBMI.Text = "&Calculate"
        Me.btnCalculateBMI.UseVisualStyleBackColor = False
        '
        'lklHelpTip
        '
        Me.lklHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.lklHelpTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lklHelpTip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklHelpTip.LinkArea = New System.Windows.Forms.LinkArea(666, 43)
        Me.lklHelpTip.Location = New System.Drawing.Point(14, 12)
        Me.lklHelpTip.Name = "lklHelpTip"
        Me.lklHelpTip.Padding = New System.Windows.Forms.Padding(6)
        Me.lklHelpTip.Size = New System.Drawing.Size(326, 334)
        Me.lklHelpTip.TabIndex = 16
        Me.lklHelpTip.TabStop = True
        Me.lklHelpTip.Tag = "https://www.ncbi.nlm.nih.gov/pubmed/2043597"
        Me.lklHelpTip.Text = resources.GetString("lklHelpTip.Text")
        Me.lklHelpTip.UseCompatibleTextRendering = True
        Me.lklHelpTip.Visible = False
        '
        'btnHelpTip
        '
        Me.btnHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.btnHelpTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpTip.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpTip.ForeColor = System.Drawing.Color.Blue
        Me.btnHelpTip.Location = New System.Drawing.Point(340, 12)
        Me.btnHelpTip.Name = "btnHelpTip"
        Me.btnHelpTip.Size = New System.Drawing.Size(32, 32)
        Me.btnHelpTip.TabIndex = 3
        Me.btnHelpTip.Text = "&?"
        Me.btnHelpTip.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BMIcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.Controls.Add(Me.lklHelpTip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHelpTip)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.grpBMI)
        Me.Controls.Add(Me.btnCalculateBMI)
        Me.Controls.Add(Me.grpBFP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BMIcalculator"
        Me.Text = "BMI & Body Fat Calculator"
        Me.grpBMI.ResumeLayout(False)
        Me.grpBMI.PerformLayout()
        Me.grpBFP.ResumeLayout(False)
        Me.grpBFP.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCLose As Button
    Friend WithEvents grpBMI As GroupBox
    Friend WithEvents lblFatMassLabel As Label
    Friend WithEvents lblLeanMass As Label
    Friend WithEvents lblFatMass As Label
    Friend WithEvents lblBFLabel As Label
    Friend WithEvents lblBodyFat As Label
    Friend WithEvents lblLeanMassLabel As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblBMIlbl As Label
    Friend WithEvents lblWeightLBL As Label
    Friend WithEvents lblHeightLBL As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents grpBFP As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculateBMI As Button
    Friend WithEvents lklHelpTip As LinkLabel
    Friend WithEvents btnHelpTip As Button
    Friend WithEvents lblClassification As Label
    Friend WithEvents lblClassificationLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
