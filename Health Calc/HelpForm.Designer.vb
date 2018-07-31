<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.txtDemonstrationTextBox = New System.Windows.Forms.TextBox()
        Me.lblDemonstrationLabel = New System.Windows.Forms.Label()
        Me.grpHelp = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLose.Location = New System.Drawing.Point(256, 517)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(116, 32)
        Me.btnCLose.TabIndex = 4
        Me.btnCLose.Text = "&Close"
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'txtDemonstrationTextBox
        '
        Me.txtDemonstrationTextBox.BackColor = System.Drawing.Color.White
        Me.txtDemonstrationTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDemonstrationTextBox.Location = New System.Drawing.Point(24, 448)
        Me.txtDemonstrationTextBox.Name = "txtDemonstrationTextBox"
        Me.txtDemonstrationTextBox.Size = New System.Drawing.Size(100, 26)
        Me.txtDemonstrationTextBox.TabIndex = 6
        Me.txtDemonstrationTextBox.Text = "Input Box"
        Me.txtDemonstrationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDemonstrationLabel
        '
        Me.lblDemonstrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDemonstrationLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDemonstrationLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDemonstrationLabel.Location = New System.Drawing.Point(24, 374)
        Me.lblDemonstrationLabel.Name = "lblDemonstrationLabel"
        Me.lblDemonstrationLabel.Size = New System.Drawing.Size(100, 26)
        Me.lblDemonstrationLabel.TabIndex = 7
        Me.lblDemonstrationLabel.Text = "Results"
        Me.lblDemonstrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpHelp
        '
        Me.grpHelp.Controls.Add(Me.lblDemonstrationLabel)
        Me.grpHelp.Controls.Add(Me.txtDemonstrationTextBox)
        Me.grpHelp.Controls.Add(Me.TextBox1)
        Me.grpHelp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHelp.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpHelp.Location = New System.Drawing.Point(13, 13)
        Me.grpHelp.Name = "grpHelp"
        Me.grpHelp.Size = New System.Drawing.Size(359, 498)
        Me.grpHelp.TabIndex = 8
        Me.grpHelp.TabStop = False
        Me.grpHelp.Text = "Health Calculator Help"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(347, 456)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'HelpForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.grpHelp)
        Me.Controls.Add(Me.btnCLose)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HelpForm"
        Me.Text = "Health Calculator Help"
        Me.grpHelp.ResumeLayout(False)
        Me.grpHelp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCLose As Button
    Friend WithEvents txtDemonstrationTextBox As TextBox
    Friend WithEvents lblDemonstrationLabel As Label
    Friend WithEvents grpHelp As GroupBox
    Friend WithEvents TextBox1 As TextBox
End Class
