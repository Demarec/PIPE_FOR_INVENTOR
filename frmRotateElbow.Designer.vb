<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRotateElbow
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
        Me.lblRotateElbow = New System.Windows.Forms.Label()
        Me.btnTurnPos = New System.Windows.Forms.Button()
        Me.btnTurnNeg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbxTurnByAngle = New System.Windows.Forms.ComboBox()
        Me.lblRotateElbowDeg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRotateElbow
        '
        Me.lblRotateElbow.AutoSize = True
        Me.lblRotateElbow.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotateElbow.Location = New System.Drawing.Point(12, 9)
        Me.lblRotateElbow.Name = "lblRotateElbow"
        Me.lblRotateElbow.Size = New System.Drawing.Size(148, 20)
        Me.lblRotateElbow.TabIndex = 0
        Me.lblRotateElbow.Text = " Turn the Part by"
        '
        'btnTurnPos
        '
        Me.btnTurnPos.Location = New System.Drawing.Point(12, 46)
        Me.btnTurnPos.Name = "btnTurnPos"
        Me.btnTurnPos.Size = New System.Drawing.Size(80, 35)
        Me.btnTurnPos.TabIndex = 1
        Me.btnTurnPos.Text = "Turn +"
        Me.btnTurnPos.UseVisualStyleBackColor = True
        '
        'btnTurnNeg
        '
        Me.btnTurnNeg.Location = New System.Drawing.Point(98, 46)
        Me.btnTurnNeg.Name = "btnTurnNeg"
        Me.btnTurnNeg.Size = New System.Drawing.Size(80, 35)
        Me.btnTurnNeg.TabIndex = 1
        Me.btnTurnNeg.Text = "Turn -"
        Me.btnTurnNeg.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chartreuse
        Me.Button1.Location = New System.Drawing.Point(184, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Accept"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CbxTurnByAngle
        '
        Me.CbxTurnByAngle.DisplayMember = "4"
        Me.CbxTurnByAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTurnByAngle.FormattingEnabled = True
        Me.CbxTurnByAngle.Items.AddRange(New Object() {"1", "2", "5", "10", "15", "45", "90"})
        Me.CbxTurnByAngle.Location = New System.Drawing.Point(188, 6)
        Me.CbxTurnByAngle.Name = "CbxTurnByAngle"
        Me.CbxTurnByAngle.Size = New System.Drawing.Size(61, 28)
        Me.CbxTurnByAngle.TabIndex = 2
        Me.CbxTurnByAngle.ValueMember = "4"
        '
        'lblRotateElbowDeg
        '
        Me.lblRotateElbowDeg.AutoSize = True
        Me.lblRotateElbowDeg.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRotateElbowDeg.Location = New System.Drawing.Point(255, 9)
        Me.lblRotateElbowDeg.Name = "lblRotateElbowDeg"
        Me.lblRotateElbowDeg.Size = New System.Drawing.Size(18, 20)
        Me.lblRotateElbowDeg.TabIndex = 0
        Me.lblRotateElbowDeg.Text = "°"
        '
        'frmRotateElbow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 124)
        Me.ControlBox = False
        Me.Controls.Add(Me.CbxTurnByAngle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTurnNeg)
        Me.Controls.Add(Me.btnTurnPos)
        Me.Controls.Add(Me.lblRotateElbowDeg)
        Me.Controls.Add(Me.lblRotateElbow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(700, 600)
        Me.Name = "frmRotateElbow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rotate Part"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRotateElbow As Label
    Friend WithEvents btnTurnPos As Button
    Friend WithEvents btnTurnNeg As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CbxTurnByAngle As ComboBox
    Friend WithEvents lblRotateElbowDeg As Label
End Class
