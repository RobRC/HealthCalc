<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMRcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMRcalculator))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCalorieLabel = New System.Windows.Forms.Label()
        Me.lblCalorieNeeds = New System.Windows.Forms.Label()
        Me.lblBMR = New System.Windows.Forms.Label()
        Me.lblBMRLabel = New System.Windows.Forms.Label()
        Me.cboActivityLevel = New System.Windows.Forms.ComboBox()
        Me.lblActivityLVL = New System.Windows.Forms.Label()
        Me.btnCalculateBMR = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.txtHelpTip = New System.Windows.Forms.TextBox()
        Me.btnHelpTip = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCalorieLabel)
        Me.GroupBox1.Controls.Add(Me.lblCalorieNeeds)
        Me.GroupBox1.Controls.Add(Me.lblBMR)
        Me.GroupBox1.Controls.Add(Me.lblBMRLabel)
        Me.GroupBox1.Controls.Add(Me.cboActivityLevel)
        Me.GroupBox1.Controls.Add(Me.lblActivityLVL)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 181)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basal Metabolic Rate"
        '
        'lblCalorieLabel
        '
        Me.lblCalorieLabel.AutoSize = True
        Me.lblCalorieLabel.Location = New System.Drawing.Point(8, 123)
        Me.lblCalorieLabel.Name = "lblCalorieLabel"
        Me.lblCalorieLabel.Size = New System.Drawing.Size(135, 19)
        Me.lblCalorieLabel.TabIndex = 5
        Me.lblCalorieLabel.Text = "Daily Calorie Needs:"
        '
        'lblCalorieNeeds
        '
        Me.lblCalorieNeeds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalorieNeeds.Location = New System.Drawing.Point(158, 119)
        Me.lblCalorieNeeds.Name = "lblCalorieNeeds"
        Me.lblCalorieNeeds.Size = New System.Drawing.Size(185, 27)
        Me.lblCalorieNeeds.TabIndex = 4
        Me.lblCalorieNeeds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBMR
        '
        Me.lblBMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBMR.Location = New System.Drawing.Point(158, 74)
        Me.lblBMR.Name = "lblBMR"
        Me.lblBMR.Size = New System.Drawing.Size(185, 27)
        Me.lblBMR.TabIndex = 19
        Me.lblBMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBMRLabel
        '
        Me.lblBMRLabel.AutoSize = True
        Me.lblBMRLabel.Location = New System.Drawing.Point(1, 78)
        Me.lblBMRLabel.Name = "lblBMRLabel"
        Me.lblBMRLabel.Size = New System.Drawing.Size(142, 19)
        Me.lblBMRLabel.TabIndex = 2
        Me.lblBMRLabel.Text = "Basal Metabolic Rate:"
        '
        'cboActivityLevel
        '
        Me.cboActivityLevel.BackColor = System.Drawing.Color.White
        Me.cboActivityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActivityLevel.DropDownWidth = 185
        Me.cboActivityLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboActivityLevel.FormattingEnabled = True
        Me.cboActivityLevel.Items.AddRange(New Object() {"Sedentary", "Lightly Active", "Moderately Active", "Very Active", "Extra Active"})
        Me.cboActivityLevel.Location = New System.Drawing.Point(158, 29)
        Me.cboActivityLevel.Name = "cboActivityLevel"
        Me.cboActivityLevel.Size = New System.Drawing.Size(185, 27)
        Me.cboActivityLevel.TabIndex = 0
        '
        'lblActivityLVL
        '
        Me.lblActivityLVL.AutoSize = True
        Me.lblActivityLVL.Location = New System.Drawing.Point(48, 32)
        Me.lblActivityLVL.Name = "lblActivityLVL"
        Me.lblActivityLVL.Size = New System.Drawing.Size(95, 19)
        Me.lblActivityLVL.TabIndex = 30
        Me.lblActivityLVL.Text = "Activity Level:"
        '
        'btnCalculateBMR
        '
        Me.btnCalculateBMR.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculateBMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateBMR.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateBMR.Location = New System.Drawing.Point(12, 236)
        Me.btnCalculateBMR.Name = "btnCalculateBMR"
        Me.btnCalculateBMR.Size = New System.Drawing.Size(116, 32)
        Me.btnCalculateBMR.TabIndex = 1
        Me.btnCalculateBMR.Text = "&Calculate"
        Me.btnCalculateBMR.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.GhostWhite
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(134, 236)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 32)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(256, 236)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(116, 32)
        Me.btnCLose.TabIndex = 3
        Me.btnCLose.Text = "&Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'txtHelpTip
        '
        Me.txtHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.txtHelpTip.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpTip.Location = New System.Drawing.Point(12, 11)
        Me.txtHelpTip.Margin = New System.Windows.Forms.Padding(6)
        Me.txtHelpTip.Multiline = True
        Me.txtHelpTip.Name = "txtHelpTip"
        Me.txtHelpTip.ReadOnly = True
        Me.txtHelpTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpTip.Size = New System.Drawing.Size(328, 207)
        Me.txtHelpTip.TabIndex = 7
        Me.txtHelpTip.Text = resources.GetString("txtHelpTip.Text")
        Me.txtHelpTip.Visible = False
        '
        'btnHelpTip
        '
        Me.btnHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.btnHelpTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpTip.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelpTip.ForeColor = System.Drawing.Color.Blue
        Me.btnHelpTip.Location = New System.Drawing.Point(340, 11)
        Me.btnHelpTip.Name = "btnHelpTip"
        Me.btnHelpTip.Size = New System.Drawing.Size(32, 32)
        Me.btnHelpTip.TabIndex = 4
        Me.btnHelpTip.Text = "&?"
        Me.btnHelpTip.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BMRcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 281)
        Me.Controls.Add(Me.txtHelpTip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHelpTip)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateBMR)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BMRcalculator"
        Me.Text = "BMR Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboActivityLevel As ComboBox
    Friend WithEvents lblActivityLVL As Label
    Friend WithEvents btnCalculateBMR As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCLose As Button
    Friend WithEvents lblBMR As Label
    Friend WithEvents lblBMRLabel As Label
    Friend WithEvents lblCalorieNeeds As Label
    Friend WithEvents lblCalorieLabel As Label
    Friend WithEvents txtHelpTip As TextBox
    Friend WithEvents btnHelpTip As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
