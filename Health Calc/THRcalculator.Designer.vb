<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class THRcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(THRcalculator))
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpTargetHR = New System.Windows.Forms.GroupBox()
        Me.lblTHRlabel = New System.Windows.Forms.Label()
        Me.lblTHR = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAgeLabel = New System.Windows.Forms.Label()
        Me.btnHelpTip = New System.Windows.Forms.Button()
        Me.txtHelpTip = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpTargetHR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(256, 207)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(116, 32)
        Me.btnCLose.TabIndex = 2
        Me.btnCLose.Text = "&Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.GhostWhite
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(134, 207)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 32)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(12, 207)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 32)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'grpTargetHR
        '
        Me.grpTargetHR.Controls.Add(Me.lblTHRlabel)
        Me.grpTargetHR.Controls.Add(Me.lblTHR)
        Me.grpTargetHR.Controls.Add(Me.lblAge)
        Me.grpTargetHR.Controls.Add(Me.lblAgeLabel)
        Me.grpTargetHR.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTargetHR.Location = New System.Drawing.Point(13, 51)
        Me.grpTargetHR.Name = "grpTargetHR"
        Me.grpTargetHR.Size = New System.Drawing.Size(359, 147)
        Me.grpTargetHR.TabIndex = 7
        Me.grpTargetHR.TabStop = False
        Me.grpTargetHR.Text = "Target Heart Rate"
        '
        'lblTHRlabel
        '
        Me.lblTHRlabel.AutoSize = True
        Me.lblTHRlabel.Location = New System.Drawing.Point(14, 80)
        Me.lblTHRlabel.Name = "lblTHRlabel"
        Me.lblTHRlabel.Size = New System.Drawing.Size(184, 19)
        Me.lblTHRlabel.TabIndex = 5
        Me.lblTHRlabel.Text = "Target Maximum Heart Rate:"
        '
        'lblTHR
        '
        Me.lblTHR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTHR.Location = New System.Drawing.Point(219, 76)
        Me.lblTHR.Name = "lblTHR"
        Me.lblTHR.Size = New System.Drawing.Size(120, 27)
        Me.lblTHR.TabIndex = 40
        Me.lblTHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAge
        '
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAge.Location = New System.Drawing.Point(219, 31)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(120, 27)
        Me.lblAge.TabIndex = 30
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAgeLabel
        '
        Me.lblAgeLabel.AutoSize = True
        Me.lblAgeLabel.Location = New System.Drawing.Point(161, 35)
        Me.lblAgeLabel.Name = "lblAgeLabel"
        Me.lblAgeLabel.Size = New System.Drawing.Size(37, 19)
        Me.lblAgeLabel.TabIndex = 20
        Me.lblAgeLabel.Text = "Age:"
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
        'txtHelpTip
        '
        Me.txtHelpTip.BackColor = System.Drawing.Color.GhostWhite
        Me.txtHelpTip.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpTip.Location = New System.Drawing.Point(13, 12)
        Me.txtHelpTip.Multiline = True
        Me.txtHelpTip.Name = "txtHelpTip"
        Me.txtHelpTip.ReadOnly = True
        Me.txtHelpTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelpTip.Size = New System.Drawing.Size(327, 93)
        Me.txtHelpTip.TabIndex = 20
        Me.txtHelpTip.Text = "The Target Heart Rate is the maximum target heart rate for an individual undergoi" &
    "ng intensive exercise. This is determined by subtracting the individual's age fr" &
    "om 220."
        Me.txtHelpTip.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'THRcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 251)
        Me.Controls.Add(Me.txtHelpTip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHelpTip)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpTargetHR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "THRcalculator"
        Me.Text = "Target Heart Rate Calculator"
        Me.grpTargetHR.ResumeLayout(False)
        Me.grpTargetHR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCLose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpTargetHR As GroupBox
    Friend WithEvents lblTHRlabel As Label
    Friend WithEvents lblTHR As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAgeLabel As Label
    Friend WithEvents btnHelpTip As Button
    Friend WithEvents txtHelpTip As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
