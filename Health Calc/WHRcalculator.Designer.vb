<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WHRcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WHRcalculator))
        Me.btnHelpTip = New System.Windows.Forms.Button()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpWHR = New System.Windows.Forms.GroupBox()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.lblClassification = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWHR = New System.Windows.Forms.Label()
        Me.lblWHRlabel = New System.Windows.Forms.Label()
        Me.lblHeightLabel = New System.Windows.Forms.Label()
        Me.lblWaistUS = New System.Windows.Forms.Label()
        Me.lblWaistMetric = New System.Windows.Forms.Label()
        Me.txtHelpTip = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpWHR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnHelpTip.TabIndex = 4
        Me.btnHelpTip.Text = "&?"
        Me.btnHelpTip.UseVisualStyleBackColor = False
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(256, 251)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(116, 32)
        Me.btnCLose.TabIndex = 3
        Me.btnCLose.Text = "&Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.GhostWhite
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(134, 251)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 32)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(12, 251)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 32)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'grpWHR
        '
        Me.grpWHR.Controls.Add(Me.txtWaist)
        Me.grpWHR.Controls.Add(Me.lblClassification)
        Me.grpWHR.Controls.Add(Me.lblClass)
        Me.grpWHR.Controls.Add(Me.lblHeight)
        Me.grpWHR.Controls.Add(Me.lblWHR)
        Me.grpWHR.Controls.Add(Me.lblWHRlabel)
        Me.grpWHR.Controls.Add(Me.lblHeightLabel)
        Me.grpWHR.Controls.Add(Me.lblWaistUS)
        Me.grpWHR.Controls.Add(Me.lblWaistMetric)
        Me.grpWHR.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWHR.Location = New System.Drawing.Point(13, 50)
        Me.grpWHR.Name = "grpWHR"
        Me.grpWHR.Size = New System.Drawing.Size(359, 194)
        Me.grpWHR.TabIndex = 19
        Me.grpWHR.TabStop = False
        Me.grpWHR.Text = "Waist to Height Ratio"
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(232, 28)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(110, 26)
        Me.txtWaist.TabIndex = 0
        Me.txtWaist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblClassification
        '
        Me.lblClassification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassification.Location = New System.Drawing.Point(232, 156)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(110, 27)
        Me.lblClassification.TabIndex = 12
        Me.lblClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(117, 160)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(91, 19)
        Me.lblClass.TabIndex = 11
        Me.lblClass.Text = "Classification:"
        '
        'lblHeight
        '
        Me.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeight.Location = New System.Drawing.Point(232, 70)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(110, 27)
        Me.lblHeight.TabIndex = 8
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWHR
        '
        Me.lblWHR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWHR.Location = New System.Drawing.Point(232, 113)
        Me.lblWHR.Name = "lblWHR"
        Me.lblWHR.Size = New System.Drawing.Size(110, 27)
        Me.lblWHR.TabIndex = 7
        Me.lblWHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWHRlabel
        '
        Me.lblWHRlabel.AutoSize = True
        Me.lblWHRlabel.Location = New System.Drawing.Point(67, 117)
        Me.lblWHRlabel.Name = "lblWHRlabel"
        Me.lblWHRlabel.Size = New System.Drawing.Size(141, 19)
        Me.lblWHRlabel.TabIndex = 5
        Me.lblWHRlabel.Text = "Waist to Height Ratio:"
        '
        'lblHeightLabel
        '
        Me.lblHeightLabel.AutoSize = True
        Me.lblHeightLabel.Location = New System.Drawing.Point(157, 74)
        Me.lblHeightLabel.Name = "lblHeightLabel"
        Me.lblHeightLabel.Size = New System.Drawing.Size(51, 19)
        Me.lblHeightLabel.TabIndex = 33
        Me.lblHeightLabel.Text = "Height:"
        '
        'lblWaistUS
        '
        Me.lblWaistUS.AutoSize = True
        Me.lblWaistUS.Location = New System.Drawing.Point(111, 31)
        Me.lblWaistUS.Name = "lblWaistUS"
        Me.lblWaistUS.Size = New System.Drawing.Size(97, 19)
        Me.lblWaistUS.TabIndex = 9
        Me.lblWaistUS.Text = "Waist (inches):"
        '
        'lblWaistMetric
        '
        Me.lblWaistMetric.AutoSize = True
        Me.lblWaistMetric.Location = New System.Drawing.Point(130, 31)
        Me.lblWaistMetric.Name = "lblWaistMetric"
        Me.lblWaistMetric.Size = New System.Drawing.Size(78, 19)
        Me.lblWaistMetric.TabIndex = 28
        Me.lblWaistMetric.Text = "Waist (cm):"
        Me.lblWaistMetric.Visible = False
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
        Me.txtHelpTip.Size = New System.Drawing.Size(327, 217)
        Me.txtHelpTip.TabIndex = 24
        Me.txtHelpTip.Text = resources.GetString("txtHelpTip.Text")
        Me.txtHelpTip.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'WHRcalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 291)
        Me.Controls.Add(Me.txtHelpTip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHelpTip)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpWHR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WHRcalculator"
        Me.Text = "Waist to Height Ratio Calculator"
        Me.grpWHR.ResumeLayout(False)
        Me.grpWHR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHelpTip As Button
    Friend WithEvents btnCLose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpWHR As GroupBox
    Friend WithEvents lblWaistUS As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWHR As Label
    Friend WithEvents lblWHRlabel As Label
    Friend WithEvents lblWaistMetric As Label
    Friend WithEvents lblHeightLabel As Label
    Friend WithEvents txtHelpTip As TextBox
    Friend WithEvents lblClassification As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
