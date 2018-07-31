<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BACcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BACcalculator))
        Me.grpBAC = New System.Windows.Forms.GroupBox()
        Me.lblVolConsumedMetric = New System.Windows.Forms.Label()
        Me.lblBloodAlcoholConc = New System.Windows.Forms.Label()
        Me.lblBAC = New System.Windows.Forms.Label()
        Me.lblTimeDrinking = New System.Windows.Forms.Label()
        Me.cboAlcoholUnits = New System.Windows.Forms.ComboBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtAlcoholPercent = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.lblVolConsumedUS = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblWeightLabel = New System.Windows.Forms.Label()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnHelpTip = New System.Windows.Forms.Button()
        Me.txtHelpTip = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBAC.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBAC
        '
        Me.grpBAC.Controls.Add(Me.lblVolConsumedMetric)
        Me.grpBAC.Controls.Add(Me.lblBloodAlcoholConc)
        Me.grpBAC.Controls.Add(Me.lblBAC)
        Me.grpBAC.Controls.Add(Me.lblTimeDrinking)
        Me.grpBAC.Controls.Add(Me.cboAlcoholUnits)
        Me.grpBAC.Controls.Add(Me.txtHours)
        Me.grpBAC.Controls.Add(Me.txtAlcoholPercent)
        Me.grpBAC.Controls.Add(Me.txtVolume)
        Me.grpBAC.Controls.Add(Me.lblVolConsumedUS)
        Me.grpBAC.Controls.Add(Me.lblWeight)
        Me.grpBAC.Controls.Add(Me.lblWeightLabel)
        Me.grpBAC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBAC.Location = New System.Drawing.Point(13, 62)
        Me.grpBAC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBAC.Name = "grpBAC"
        Me.grpBAC.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBAC.Size = New System.Drawing.Size(433, 231)
        Me.grpBAC.TabIndex = 0
        Me.grpBAC.TabStop = False
        Me.grpBAC.Text = "Blood Alcohol Concentration"
        '
        'lblVolConsumedMetric
        '
        Me.lblVolConsumedMetric.AutoSize = True
        Me.lblVolConsumedMetric.Location = New System.Drawing.Point(85, 44)
        Me.lblVolConsumedMetric.Name = "lblVolConsumedMetric"
        Me.lblVolConsumedMetric.Size = New System.Drawing.Size(182, 19)
        Me.lblVolConsumedMetric.TabIndex = 11
        Me.lblVolConsumedMetric.Text = "Total volume consumed (ml):"
        Me.lblVolConsumedMetric.Visible = False
        '
        'lblBloodAlcoholConc
        '
        Me.lblBloodAlcoholConc.AutoSize = True
        Me.lblBloodAlcoholConc.Location = New System.Drawing.Point(79, 193)
        Me.lblBloodAlcoholConc.Name = "lblBloodAlcoholConc"
        Me.lblBloodAlcoholConc.Size = New System.Drawing.Size(188, 19)
        Me.lblBloodAlcoholConc.TabIndex = 10
        Me.lblBloodAlcoholConc.Text = "Blood Alcohol Concentration:"
        '
        'lblBAC
        '
        Me.lblBAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBAC.Location = New System.Drawing.Point(297, 189)
        Me.lblBAC.Name = "lblBAC"
        Me.lblBAC.Size = New System.Drawing.Size(116, 26)
        Me.lblBAC.TabIndex = 6
        Me.lblBAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeDrinking
        '
        Me.lblTimeDrinking.AutoSize = True
        Me.lblTimeDrinking.Location = New System.Drawing.Point(92, 118)
        Me.lblTimeDrinking.Name = "lblTimeDrinking"
        Me.lblTimeDrinking.Size = New System.Drawing.Size(175, 19)
        Me.lblTimeDrinking.TabIndex = 8
        Me.lblTimeDrinking.Text = "Hours since drinking began:"
        '
        'cboAlcoholUnits
        '
        Me.cboAlcoholUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlcoholUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAlcoholUnits.FormattingEnabled = True
        Me.cboAlcoholUnits.Items.AddRange(New Object() {"Alcohol % (ABV):", "Proof:"})
        Me.cboAlcoholUnits.Location = New System.Drawing.Point(126, 78)
        Me.cboAlcoholUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAlcoholUnits.Name = "cboAlcoholUnits"
        Me.cboAlcoholUnits.Size = New System.Drawing.Size(141, 27)
        Me.cboAlcoholUnits.TabIndex = 1
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(297, 115)
        Me.txtHours.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(116, 26)
        Me.txtHours.TabIndex = 3
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlcoholPercent
        '
        Me.txtAlcoholPercent.Location = New System.Drawing.Point(297, 78)
        Me.txtAlcoholPercent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlcoholPercent.Name = "txtAlcoholPercent"
        Me.txtAlcoholPercent.Size = New System.Drawing.Size(116, 26)
        Me.txtAlcoholPercent.TabIndex = 2
        Me.txtAlcoholPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(297, 41)
        Me.txtVolume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(116, 26)
        Me.txtVolume.TabIndex = 0
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVolConsumedUS
        '
        Me.lblVolConsumedUS.AutoSize = True
        Me.lblVolConsumedUS.Location = New System.Drawing.Point(56, 44)
        Me.lblVolConsumedUS.Name = "lblVolConsumedUS"
        Me.lblVolConsumedUS.Size = New System.Drawing.Size(211, 19)
        Me.lblVolConsumedUS.TabIndex = 7
        Me.lblVolConsumedUS.Text = "Total volume consumed (fluid oz):"
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeight.Location = New System.Drawing.Point(297, 152)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(116, 26)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeightLabel
        '
        Me.lblWeightLabel.AutoSize = True
        Me.lblWeightLabel.Location = New System.Drawing.Point(213, 156)
        Me.lblWeightLabel.Name = "lblWeightLabel"
        Me.lblWeightLabel.Size = New System.Drawing.Size(54, 19)
        Me.lblWeightLabel.TabIndex = 9
        Me.lblWeightLabel.Text = "Weight:"
        Me.lblWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(311, 301)
        Me.btnCLose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(135, 36)
        Me.btnCLose.TabIndex = 10
        Me.btnCLose.Text = "&Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.GhostWhite
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(162, 301)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(135, 36)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(13, 301)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(135, 36)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnHelpTip
        '
        Me.btnHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.btnHelpTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpTip.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpTip.ForeColor = System.Drawing.Color.Blue
        Me.btnHelpTip.Location = New System.Drawing.Point(415, 13)
        Me.btnHelpTip.Name = "btnHelpTip"
        Me.btnHelpTip.Size = New System.Drawing.Size(32, 32)
        Me.btnHelpTip.TabIndex = 18
        Me.btnHelpTip.Text = "&?"
        Me.btnHelpTip.UseVisualStyleBackColor = False
        '
        'txtHelpTip
        '
        Me.txtHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.txtHelpTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHelpTip.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpTip.Location = New System.Drawing.Point(12, 13)
        Me.txtHelpTip.Multiline = True
        Me.txtHelpTip.Name = "txtHelpTip"
        Me.txtHelpTip.ReadOnly = True
        Me.txtHelpTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpTip.Size = New System.Drawing.Size(403, 273)
        Me.txtHelpTip.TabIndex = 19
        Me.txtHelpTip.Text = resources.GetString("txtHelpTip.Text")
        Me.txtHelpTip.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'BACcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 346)
        Me.Controls.Add(Me.txtHelpTip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHelpTip)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpBAC)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "BACcalculator"
        Me.Text = "Blood Alcohol Concentration Calculator"
        Me.grpBAC.ResumeLayout(False)
        Me.grpBAC.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBAC As GroupBox
    Friend WithEvents btnCLose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblBloodAlcoholConc As Label
    Friend WithEvents lblBAC As Label
    Friend WithEvents lblTimeDrinking As Label
    Friend WithEvents cboAlcoholUnits As ComboBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtAlcoholPercent As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents lblVolConsumedUS As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblWeightLabel As Label
    Friend WithEvents lblVolConsumedMetric As Label
    Friend WithEvents btnHelpTip As Button
    Friend WithEvents txtHelpTip As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
