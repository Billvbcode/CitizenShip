<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABC
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
        Me.PictABC = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PicTitle = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rText = New System.Windows.Forms.RichTextBox()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.BtnGuess = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictABC
        '
        Me.PictABC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictABC.Location = New System.Drawing.Point(181, 140)
        Me.PictABC.Name = "PictABC"
        Me.PictABC.Size = New System.Drawing.Size(529, 272)
        Me.PictABC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictABC.TabIndex = 0
        Me.PictABC.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(142, 498)
        Me.ListBox1.TabIndex = 1
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(177, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(0, 20)
        Me.LblTitle.TabIndex = 2
        '
        'PicTitle
        '
        Me.PicTitle.Location = New System.Drawing.Point(344, 12)
        Me.PicTitle.Name = "PicTitle"
        Me.PicTitle.Size = New System.Drawing.Size(246, 111)
        Me.PicTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTitle.TabIndex = 3
        Me.PicTitle.TabStop = False
        '
        'Timer1
        '
        '
        'rText
        '
        Me.rText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rText.Location = New System.Drawing.Point(181, 140)
        Me.rText.Name = "rText"
        Me.rText.Size = New System.Drawing.Size(529, 272)
        Me.rText.TabIndex = 4
        Me.rText.Text = ""
        '
        'BtnRead
        '
        Me.BtnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRead.Location = New System.Drawing.Point(21, 9)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(110, 23)
        Me.BtnRead.TabIndex = 5
        Me.BtnRead.Text = "Esc = Read"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'BtnGuess
        '
        Me.BtnGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuess.Location = New System.Drawing.Point(647, 67)
        Me.BtnGuess.Name = "BtnGuess"
        Me.BtnGuess.Size = New System.Drawing.Size(110, 23)
        Me.BtnGuess.TabIndex = 6
        Me.BtnGuess.Text = "Guess"
        Me.BtnGuess.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(181, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 272)
        Me.Panel1.TabIndex = 7
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'Timer3
        '
        Me.Timer3.Interval = 4800
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'FrmABC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 552)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnGuess)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.rText)
        Me.Controls.Add(Me.PicTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictABC)
        Me.Name = "FrmABC"
        Me.Text = "FrmABC"
        CType(Me.PictABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictABC As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents PicTitle As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents rText As RichTextBox
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnGuess As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label1 As Label
End Class
