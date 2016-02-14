<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigitalDownloads
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
        Me.picMusic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfDownloads = New System.Windows.Forms.Label()
        Me.txtNumberOfDownloads = New System.Windows.Forms.TextBox()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMusic
        '
        Me.picMusic.Image = Global.Digital_Download2.My.Resources.Resources.Music
        Me.picMusic.Location = New System.Drawing.Point(2, 290)
        Me.picMusic.Name = "picMusic"
        Me.picMusic.Size = New System.Drawing.Size(405, 175)
        Me.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMusic.TabIndex = 0
        Me.picMusic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(84, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(240, 27)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Digital Downloads"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(125, 51)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(158, 20)
        Me.lblCostHeading.TabIndex = 2
        Me.lblCostHeading.Text = "$X.XX per Download"
        Me.lblCostHeading.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNumberOfDownloads
        '
        Me.lblNumberOfDownloads.AutoSize = True
        Me.lblNumberOfDownloads.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDownloads.Location = New System.Drawing.Point(85, 106)
        Me.lblNumberOfDownloads.Name = "lblNumberOfDownloads"
        Me.lblNumberOfDownloads.Size = New System.Drawing.Size(177, 20)
        Me.lblNumberOfDownloads.TabIndex = 3
        Me.lblNumberOfDownloads.Text = "Number of Downloads:"
        '
        'txtNumberOfDownloads
        '
        Me.txtNumberOfDownloads.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDownloads.Location = New System.Drawing.Point(268, 103)
        Me.txtNumberOfDownloads.Name = "txtNumberOfDownloads"
        Me.txtNumberOfDownloads.Size = New System.Drawing.Size(31, 26)
        Me.txtNumberOfDownloads.TabIndex = 4
        Me.txtNumberOfDownloads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(85, 167)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(189, 20)
        Me.lblTotalCostLabel.TabIndex = 5
        Me.lblTotalCostLabel.Text = "Total Cost of Downloads:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(280, 167)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Red
        Me.btnCalculate.Location = New System.Drawing.Point(23, 231)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(159, 231)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(295, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDigitalDownloads
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(409, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.txtNumberOfDownloads)
        Me.Controls.Add(Me.lblNumberOfDownloads)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picMusic)
        Me.Name = "frmDigitalDownloads"
        Me.Text = "Download Music"
        CType(Me.picMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMusic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblNumberOfDownloads As Label
    Friend WithEvents txtNumberOfDownloads As TextBox
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
