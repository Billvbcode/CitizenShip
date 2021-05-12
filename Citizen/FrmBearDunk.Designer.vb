<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBearDunk
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBearDunk))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblWinOrLose = New System.Windows.Forms.Label()
        Me.pBear = New System.Windows.Forms.PictureBox()
        Me.LblBear = New System.Windows.Forms.Label()
        Me.LblTest2 = New System.Windows.Forms.Label()
        Me.LblWord = New System.Windows.Forms.Label()
        Me.LblTest = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TimFall = New System.Windows.Forms.Timer(Me.components)
        Me.RB6 = New System.Windows.Forms.RadioButton()
        Me.RB5 = New System.Windows.Forms.RadioButton()
        Me.RB4 = New System.Windows.Forms.RadioButton()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pBear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pBear)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 350)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Controls.Add(Me.LblWinOrLose)
        Me.Panel2.Location = New System.Drawing.Point(0, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 90)
        Me.Panel2.TabIndex = 2
        '
        'LblWinOrLose
        '
        Me.LblWinOrLose.AutoSize = True
        Me.LblWinOrLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWinOrLose.Location = New System.Drawing.Point(56, 42)
        Me.LblWinOrLose.Name = "LblWinOrLose"
        Me.LblWinOrLose.Size = New System.Drawing.Size(96, 24)
        Me.LblWinOrLose.TabIndex = 3
        Me.LblWinOrLose.Text = "You Won"
        Me.LblWinOrLose.Visible = False
        '
        'pBear
        '
        Me.pBear.Image = CType(resources.GetObject("pBear.Image"), System.Drawing.Image)
        Me.pBear.Location = New System.Drawing.Point(116, 3)
        Me.pBear.Name = "pBear"
        Me.pBear.Size = New System.Drawing.Size(80, 120)
        Me.pBear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBear.TabIndex = 0
        Me.pBear.TabStop = False
        '
        'LblBear
        '
        Me.LblBear.AutoSize = True
        Me.LblBear.Location = New System.Drawing.Point(296, 325)
        Me.LblBear.Name = "LblBear"
        Me.LblBear.Size = New System.Drawing.Size(28, 13)
        Me.LblBear.TabIndex = 15
        Me.LblBear.Text = "Test"
        Me.LblBear.Visible = False
        '
        'LblTest2
        '
        Me.LblTest2.AutoSize = True
        Me.LblTest2.Location = New System.Drawing.Point(359, 325)
        Me.LblTest2.Name = "LblTest2"
        Me.LblTest2.Size = New System.Drawing.Size(28, 13)
        Me.LblTest2.TabIndex = 14
        Me.LblTest2.Text = "Test"
        Me.LblTest2.Visible = False
        '
        'LblWord
        '
        Me.LblWord.AutoSize = True
        Me.LblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWord.Location = New System.Drawing.Point(271, 12)
        Me.LblWord.Name = "LblWord"
        Me.LblWord.Size = New System.Drawing.Size(30, 20)
        Me.LblWord.TabIndex = 13
        Me.LblWord.Text = "***"
        '
        'LblTest
        '
        Me.LblTest.AutoSize = True
        Me.LblTest.Location = New System.Drawing.Point(243, 325)
        Me.LblTest.Name = "LblTest"
        Me.LblTest.Size = New System.Drawing.Size(28, 13)
        Me.LblTest.TabIndex = 12
        Me.LblTest.Text = "Test"
        Me.LblTest.Visible = False
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(274, 272)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(63, 35)
        Me.BtnStart.TabIndex = 11
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'TimFall
        '
        '
        'RB6
        '
        Me.RB6.AutoSize = True
        Me.RB6.Location = New System.Drawing.Point(343, 245)
        Me.RB6.Name = "RB6"
        Me.RB6.Size = New System.Drawing.Size(31, 17)
        Me.RB6.TabIndex = 19
        Me.RB6.Text = "6"
        Me.RB6.UseVisualStyleBackColor = True
        '
        'RB5
        '
        Me.RB5.AutoSize = True
        Me.RB5.Location = New System.Drawing.Point(306, 245)
        Me.RB5.Name = "RB5"
        Me.RB5.Size = New System.Drawing.Size(31, 17)
        Me.RB5.TabIndex = 18
        Me.RB5.Text = "5"
        Me.RB5.UseVisualStyleBackColor = True
        '
        'RB4
        '
        Me.RB4.AutoSize = True
        Me.RB4.Checked = True
        Me.RB4.Location = New System.Drawing.Point(271, 245)
        Me.RB4.Name = "RB4"
        Me.RB4.Size = New System.Drawing.Size(31, 17)
        Me.RB4.TabIndex = 17
        Me.RB4.TabStop = True
        Me.RB4.Text = "4"
        Me.RB4.UseVisualStyleBackColor = True
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(234, 245)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(31, 17)
        Me.RB3.TabIndex = 16
        Me.RB3.Text = "3"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'FrmBearDunk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 378)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblBear)
        Me.Controls.Add(Me.LblTest2)
        Me.Controls.Add(Me.LblWord)
        Me.Controls.Add(Me.LblTest)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.RB6)
        Me.Controls.Add(Me.RB5)
        Me.Controls.Add(Me.RB4)
        Me.Controls.Add(Me.RB3)
        Me.Name = "FrmBearDunk"
        Me.Text = "FrmBearDunk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pBear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblWinOrLose As Label
    Friend WithEvents pBear As PictureBox
    Friend WithEvents LblBear As Label
    Friend WithEvents LblTest2 As Label
    Friend WithEvents LblWord As Label
    Friend WithEvents LblTest As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents TimFall As Timer
    Friend WithEvents RB6 As RadioButton
    Friend WithEvents RB5 As RadioButton
    Friend WithEvents RB4 As RadioButton
    Friend WithEvents RB3 As RadioButton
End Class
