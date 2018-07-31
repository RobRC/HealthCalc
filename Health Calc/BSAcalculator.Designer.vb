<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BSAcalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BSAcalculator))
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpBSA = New System.Windows.Forms.GroupBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblBSA = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblBSAlabel = New System.Windows.Forms.Label()
        Me.lblWeightLabel = New System.Windows.Forms.Label()
        Me.lblHeightLabel = New System.Windows.Forms.Label()
        Me.btnHelpTip = New System.Windows.Forms.Button()
        Me.txtHelpTip = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBSA.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(256, 236)
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
        Me.btnReset.Location = New System.Drawing.Point(134, 236)
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
        Me.btnCalculate.Location = New System.Drawing.Point(12, 236)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 32)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'grpBSA
        '
        Me.grpBSA.Controls.Add(Me.lblHeight)
        Me.grpBSA.Controls.Add(Me.lblBSA)
        Me.grpBSA.Controls.Add(Me.lblWeight)
        Me.grpBSA.Controls.Add(Me.lblBSAlabel)
        Me.grpBSA.Controls.Add(Me.lblWeightLabel)
        Me.grpBSA.Controls.Add(Me.lblHeightLabel)
        Me.grpBSA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBSA.Location = New System.Drawing.Point(13, 50)
        Me.grpBSA.Name = "grpBSA"
        Me.grpBSA.Size = New System.Drawing.Size(359, 161)
        Me.grpBSA.TabIndex = 7
        Me.grpBSA.TabStop = False
        Me.grpBSA.Text = "Body Surface Area"
        '
        'lblHeight
        '
        Me.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeight.Location = New System.Drawing.Point(212, 27)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(130, 27)
        Me.lblHeight.TabIndex = 8
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBSA
        '
        Me.lblBSA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBSA.Location = New System.Drawing.Point(212, 118)
        Me.lblBSA.Name = "lblBSA"
        Me.lblBSA.Size = New System.Drawing.Size(130, 27)
        Me.lblBSA.TabIndex = 7
        Me.lblBSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeight.Location = New System.Drawing.Point(212, 73)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(130, 27)
        Me.lblWeight.TabIndex = 6
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBSAlabel
        '
        Me.lblBSAlabel.AutoSize = True
        Me.lblBSAlabel.Location = New System.Drawing.Point(63, 122)
        Me.lblBSAlabel.Name = "lblBSAlabel"
        Me.lblBSAlabel.Size = New System.Drawing.Size(128, 19)
        Me.lblBSAlabel.TabIndex = 5
        Me.lblBSAlabel.Text = "Body Surface Area:"
        '
        'lblWeightLabel
        '
        Me.lblWeightLabel.AutoSize = True
        Me.lblWeightLabel.Location = New System.Drawing.Point(137, 77)
        Me.lblWeightLabel.Name = "lblWeightLabel"
        Me.lblWeightLabel.Size = New System.Drawing.Size(54, 19)
        Me.lblWeightLabel.TabIndex = 20
        Me.lblWeightLabel.Text = "Weight:"
        '
        'lblHeightLabel
        '
        Me.lblHeightLabel.AutoSize = True
        Me.lblHeightLabel.Location = New System.Drawing.Point(140, 31)
        Me.lblHeightLabel.Name = "lblHeightLabel"
        Me.lblHeightLabel.Size = New System.Drawing.Size(51, 19)
        Me.lblHeightLabel.TabIndex = 10
        Me.lblHeightLabel.Text = "Height:"
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
        Me.txtHelpTip.Size = New System.Drawing.Size(327, 205)
        Me.txtHelpTip.TabIndex = 19
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
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BSAcalculator
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
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpBSA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BSAcalculator"
        Me.Text = "BSAcalculator"
        Me.grpBSA.ResumeLayout(False)
        Me.grpBSA.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCLose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpBSA As GroupBox
    Friend WithEvents lblBSAlabel As Label
    Friend WithEvents lblWeightLabel As Label
    Friend WithEvents lblHeightLabel As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblBSA As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents btnHelpTip As Button
    Friend WithEvents txtHelpTip As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
