<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyPipeLenght
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
        Me.cbxNewPipeLenght = New System.Windows.Forms.ComboBox()
        Me.lblNewPipeLenght = New System.Windows.Forms.Label()
        Me.LblCurrentPipeLenght = New System.Windows.Forms.Label()
        Me.btnReplacePipe = New System.Windows.Forms.Button()
        Me.lblLenghtCur = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxNewPipeLenght
        '
        Me.cbxNewPipeLenght.FormattingEnabled = True
        Me.cbxNewPipeLenght.Items.AddRange(New Object() {"50", "100", "150", "200", "250", "300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900", "950", "1000", "1050", "1100", "1150", "1200", "1250", "1300", "1350", "1400", "1450", "1500", "1550", "1600", "1650", "1700", "1750", "1800", "1850", "1900", "1950", "2000", "2050", "2100", "2150", "2200", "2250", "2300", "2350", "2400", "2450", "2500", "2550", "2600", "2650", "2700", "2750", "2800", "2850", "2900", "2950", "3000", "3050", "3100", "3150", "3200", "3250", "3300", "3350", "3400", "3450", "3500", "3550", "3600", "3650", "3700", "3750", "3800", "3850", "3900", "3950", "4000", "4050", "4100", "4150", "4200", "4250", "4300", "4350", "4400", "4450", "4500", "4550", "4600", "4650", "4700", "4750", "4800", "4850", "4900", "4950", "5000", "5050", "5100", "5150", "5200", "5250", "5300", "5350", "5400", "5450", "5500", "5550", "5600", "5650", "5700", "5750", "5800", "5850", "5900", "5950", "6000"})
        Me.cbxNewPipeLenght.Location = New System.Drawing.Point(173, 46)
        Me.cbxNewPipeLenght.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxNewPipeLenght.Name = "cbxNewPipeLenght"
        Me.cbxNewPipeLenght.Size = New System.Drawing.Size(94, 28)
        Me.cbxNewPipeLenght.TabIndex = 0
        '
        'lblNewPipeLenght
        '
        Me.lblNewPipeLenght.Location = New System.Drawing.Point(13, 49)
        Me.lblNewPipeLenght.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewPipeLenght.Name = "lblNewPipeLenght"
        Me.lblNewPipeLenght.Size = New System.Drawing.Size(120, 35)
        Me.lblNewPipeLenght.TabIndex = 2
        Me.lblNewPipeLenght.Text = "New Lenght    :"
        '
        'LblCurrentPipeLenght
        '
        Me.LblCurrentPipeLenght.AutoSize = True
        Me.LblCurrentPipeLenght.Location = New System.Drawing.Point(222, 14)
        Me.LblCurrentPipeLenght.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCurrentPipeLenght.Name = "LblCurrentPipeLenght"
        Me.LblCurrentPipeLenght.Size = New System.Drawing.Size(45, 20)
        Me.LblCurrentPipeLenght.TabIndex = 3
        Me.LblCurrentPipeLenght.Text = "0000"
        '
        'btnReplacePipe
        '
        Me.btnReplacePipe.Location = New System.Drawing.Point(123, 89)
        Me.btnReplacePipe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReplacePipe.Name = "btnReplacePipe"
        Me.btnReplacePipe.Size = New System.Drawing.Size(144, 35)
        Me.btnReplacePipe.TabIndex = 4
        Me.btnReplacePipe.Text = "REPLACE PIPE"
        Me.btnReplacePipe.UseVisualStyleBackColor = True
        '
        'lblLenghtCur
        '
        Me.lblLenghtCur.Location = New System.Drawing.Point(13, 14)
        Me.lblLenghtCur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLenghtCur.Name = "lblLenghtCur"
        Me.lblLenghtCur.Size = New System.Drawing.Size(120, 35)
        Me.lblLenghtCur.TabIndex = 5
        Me.lblLenghtCur.Text = "Current Lenght:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(17, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmModifyPipeLenght
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 124)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLenghtCur)
        Me.Controls.Add(Me.btnReplacePipe)
        Me.Controls.Add(Me.LblCurrentPipeLenght)
        Me.Controls.Add(Me.lblNewPipeLenght)
        Me.Controls.Add(Me.cbxNewPipeLenght)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(600, 400)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(300, 180)
        Me.MinimumSize = New System.Drawing.Size(300, 180)
        Me.Name = "frmModifyPipeLenght"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pipe Lenght"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxNewPipeLenght As ComboBox
    Friend WithEvents lblNewPipeLenght As Label
    Friend WithEvents btnReplacePipe As Button
    Public WithEvents LblCurrentPipeLenght As Label
    Friend WithEvents lblLenghtCur As Label
    Friend WithEvents Button1 As Button
End Class
