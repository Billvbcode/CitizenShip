<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSnakevb
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
        Me.pGreen = New System.Windows.Forms.PictureBox()
        Me.pHead = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.PictureBox()
        Me.TimMove = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.pBody2 = New System.Windows.Forms.PictureBox()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.LblWord = New System.Windows.Forms.Label()
        Me.pAns = New System.Windows.Forms.PictureBox()
        Me.TimYes = New System.Windows.Forms.Timer(Me.components)
        Me.TimNo = New System.Windows.Forms.Timer(Me.components)
        Me.TimDone = New System.Windows.Forms.Timer(Me.components)
        Me.TimStart = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimPlace = New System.Windows.Forms.Timer(Me.components)
        Me.LblTest = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pDown = New System.Windows.Forms.PictureBox()
        Me.pUp = New System.Windows.Forms.PictureBox()
        Me.pRight = New System.Windows.Forms.PictureBox()
        Me.pLeft = New System.Windows.Forms.PictureBox()
        Me.pUp2 = New System.Windows.Forms.PictureBox()
        Me.pDown2 = New System.Windows.Forms.PictureBox()
        Me.pLeft2 = New System.Windows.Forms.PictureBox()
        Me.pRight2 = New System.Windows.Forms.PictureBox()
        Me.pUp3 = New System.Windows.Forms.PictureBox()
        Me.pDown3 = New System.Windows.Forms.PictureBox()
        Me.pLeft3 = New System.Windows.Forms.PictureBox()
        Me.pRight3 = New System.Windows.Forms.PictureBox()
        CType(Me.pGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBody2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pAns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pUp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pLeft2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pRight2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pUp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pLeft3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pRight3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pGreen
        '
        Me.pGreen.Location = New System.Drawing.Point(26, 477)
        Me.pGreen.Name = "pGreen"
        Me.pGreen.Size = New System.Drawing.Size(40, 40)
        Me.pGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pGreen.TabIndex = 7
        Me.pGreen.TabStop = False
        Me.pGreen.Tag = "G"
        Me.pGreen.Visible = False
        '
        'pHead
        '
        Me.pHead.Location = New System.Drawing.Point(83, 477)
        Me.pHead.Name = "pHead"
        Me.pHead.Size = New System.Drawing.Size(60, 60)
        Me.pHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pHead.TabIndex = 8
        Me.pHead.TabStop = False
        Me.pHead.Tag = "G"
        Me.pHead.Visible = False
        '
        'pBody
        '
        Me.pBody.Location = New System.Drawing.Point(129, 477)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(60, 60)
        Me.pBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBody.TabIndex = 9
        Me.pBody.TabStop = False
        Me.pBody.Tag = "G"
        Me.pBody.Visible = False
        '
        'TimMove
        '
        Me.TimMove.Interval = 750
        '
        'Lbl1
        '
        Me.Lbl1.BackColor = System.Drawing.Color.Yellow
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(648, 97)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(60, 60)
        Me.Lbl1.TabIndex = 11
        Me.Lbl1.Text = "C"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pBody2
        '
        Me.pBody2.Location = New System.Drawing.Point(184, 477)
        Me.pBody2.Name = "pBody2"
        Me.pBody2.Size = New System.Drawing.Size(60, 60)
        Me.pBody2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBody2.TabIndex = 12
        Me.pBody2.TabStop = False
        Me.pBody2.Tag = "G"
        Me.pBody2.Visible = False
        '
        'Lbl2
        '
        Me.Lbl2.BackColor = System.Drawing.Color.Yellow
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(733, 97)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(60, 60)
        Me.Lbl2.TabIndex = 15
        Me.Lbl2.Text = "A"
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl3
        '
        Me.Lbl3.BackColor = System.Drawing.Color.Yellow
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(648, 162)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(60, 60)
        Me.Lbl3.TabIndex = 16
        Me.Lbl3.Text = "T"
        Me.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(786, 151)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(129, 173)
        Me.ListBox1.TabIndex = 17
        Me.ListBox1.Visible = False
        '
        'Lbl4
        '
        Me.Lbl4.BackColor = System.Drawing.Color.Yellow
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(733, 162)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(60, 60)
        Me.Lbl4.TabIndex = 18
        Me.Lbl4.Text = "A"
        Me.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWord
        '
        Me.LblWord.AutoSize = True
        Me.LblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWord.Location = New System.Drawing.Point(534, 33)
        Me.LblWord.Name = "LblWord"
        Me.LblWord.Size = New System.Drawing.Size(108, 33)
        Me.LblWord.TabIndex = 19
        Me.LblWord.Text = "Label1"
        '
        'pAns
        '
        Me.pAns.Location = New System.Drawing.Point(525, 88)
        Me.pAns.Name = "pAns"
        Me.pAns.Size = New System.Drawing.Size(120, 94)
        Me.pAns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pAns.TabIndex = 20
        Me.pAns.TabStop = False
        '
        'TimYes
        '
        '
        'TimNo
        '
        '
        'TimDone
        '
        Me.TimDone.Interval = 200
        '
        'TimStart
        '
        Me.TimStart.Interval = 6400
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'TimPlace
        '
        Me.TimPlace.Interval = 6400
        '
        'LblTest
        '
        Me.LblTest.AutoSize = True
        Me.LblTest.Location = New System.Drawing.Point(643, 9)
        Me.LblTest.Name = "LblTest"
        Me.LblTest.Size = New System.Drawing.Size(39, 13)
        Me.LblTest.TabIndex = 36
        Me.LblTest.Text = "Label4"
        Me.LblTest.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(669, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(669, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'pDown
        '
        Me.pDown.Location = New System.Drawing.Point(847, 438)
        Me.pDown.Name = "pDown"
        Me.pDown.Size = New System.Drawing.Size(44, 50)
        Me.pDown.TabIndex = 39
        Me.pDown.TabStop = False
        Me.pDown.Visible = False
        '
        'pUp
        '
        Me.pUp.Location = New System.Drawing.Point(786, 438)
        Me.pUp.Name = "pUp"
        Me.pUp.Size = New System.Drawing.Size(44, 50)
        Me.pUp.TabIndex = 40
        Me.pUp.TabStop = False
        Me.pUp.Visible = False
        '
        'pRight
        '
        Me.pRight.Location = New System.Drawing.Point(786, 382)
        Me.pRight.Name = "pRight"
        Me.pRight.Size = New System.Drawing.Size(44, 50)
        Me.pRight.TabIndex = 42
        Me.pRight.TabStop = False
        Me.pRight.Visible = False
        '
        'pLeft
        '
        Me.pLeft.Location = New System.Drawing.Point(847, 382)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(44, 50)
        Me.pLeft.TabIndex = 41
        Me.pLeft.TabStop = False
        Me.pLeft.Visible = False
        '
        'pUp2
        '
        Me.pUp2.Location = New System.Drawing.Point(525, 412)
        Me.pUp2.Name = "pUp2"
        Me.pUp2.Size = New System.Drawing.Size(44, 50)
        Me.pUp2.TabIndex = 46
        Me.pUp2.TabStop = False
        Me.pUp2.Visible = False
        '
        'pDown2
        '
        Me.pDown2.Location = New System.Drawing.Point(586, 412)
        Me.pDown2.Name = "pDown2"
        Me.pDown2.Size = New System.Drawing.Size(44, 50)
        Me.pDown2.TabIndex = 45
        Me.pDown2.TabStop = False
        Me.pDown2.Visible = False
        '
        'pLeft2
        '
        Me.pLeft2.Location = New System.Drawing.Point(525, 468)
        Me.pLeft2.Name = "pLeft2"
        Me.pLeft2.Size = New System.Drawing.Size(44, 50)
        Me.pLeft2.TabIndex = 44
        Me.pLeft2.TabStop = False
        Me.pLeft2.Visible = False
        '
        'pRight2
        '
        Me.pRight2.Location = New System.Drawing.Point(586, 468)
        Me.pRight2.Name = "pRight2"
        Me.pRight2.Size = New System.Drawing.Size(44, 50)
        Me.pRight2.TabIndex = 43
        Me.pRight2.TabStop = False
        Me.pRight2.Visible = False
        '
        'pUp3
        '
        Me.pUp3.Location = New System.Drawing.Point(410, 402)
        Me.pUp3.Name = "pUp3"
        Me.pUp3.Size = New System.Drawing.Size(44, 50)
        Me.pUp3.TabIndex = 50
        Me.pUp3.TabStop = False
        Me.pUp3.Visible = False
        '
        'pDown3
        '
        Me.pDown3.Location = New System.Drawing.Point(471, 402)
        Me.pDown3.Name = "pDown3"
        Me.pDown3.Size = New System.Drawing.Size(44, 50)
        Me.pDown3.TabIndex = 49
        Me.pDown3.TabStop = False
        Me.pDown3.Visible = False
        '
        'pLeft3
        '
        Me.pLeft3.Location = New System.Drawing.Point(410, 458)
        Me.pLeft3.Name = "pLeft3"
        Me.pLeft3.Size = New System.Drawing.Size(44, 50)
        Me.pLeft3.TabIndex = 48
        Me.pLeft3.TabStop = False
        Me.pLeft3.Visible = False
        '
        'pRight3
        '
        Me.pRight3.Location = New System.Drawing.Point(471, 458)
        Me.pRight3.Name = "pRight3"
        Me.pRight3.Size = New System.Drawing.Size(44, 50)
        Me.pRight3.TabIndex = 47
        Me.pRight3.TabStop = False
        Me.pRight3.Visible = False
        '
        'FrmSnakevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 529)
        Me.Controls.Add(Me.pUp3)
        Me.Controls.Add(Me.pDown3)
        Me.Controls.Add(Me.pLeft3)
        Me.Controls.Add(Me.pRight3)
        Me.Controls.Add(Me.pUp2)
        Me.Controls.Add(Me.pDown2)
        Me.Controls.Add(Me.pLeft2)
        Me.Controls.Add(Me.pRight2)
        Me.Controls.Add(Me.pRight)
        Me.Controls.Add(Me.pLeft)
        Me.Controls.Add(Me.pUp)
        Me.Controls.Add(Me.pDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pAns)
        Me.Controls.Add(Me.LblWord)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.pBody2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.pBody)
        Me.Controls.Add(Me.pHead)
        Me.Controls.Add(Me.pGreen)
        Me.Name = "FrmSnakevb"
        Me.Text = "FrmSnakevb"
        CType(Me.pGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBody2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pAns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pUp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pLeft2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pRight2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pUp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pLeft3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pRight3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pGreen As PictureBox
    Friend WithEvents pHead As PictureBox
    Friend WithEvents pBody As PictureBox
    Friend WithEvents TimMove As Timer
    Friend WithEvents Lbl1 As Label
    Friend WithEvents pBody2 As PictureBox
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Lbl4 As Label
    Friend WithEvents LblWord As Label
    Friend WithEvents pAns As PictureBox
    Friend WithEvents TimYes As Timer
    Friend WithEvents TimNo As Timer
    Friend WithEvents TimDone As Timer
    Friend WithEvents TimStart As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents TimPlace As Timer
    Friend WithEvents LblTest As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pDown As PictureBox
    Friend WithEvents pUp As PictureBox
    Friend WithEvents pRight As PictureBox
    Friend WithEvents pLeft As PictureBox
    Friend WithEvents pUp2 As PictureBox
    Friend WithEvents pDown2 As PictureBox
    Friend WithEvents pLeft2 As PictureBox
    Friend WithEvents pRight2 As PictureBox
    Friend WithEvents pUp3 As PictureBox
    Friend WithEvents pDown3 As PictureBox
    Friend WithEvents pLeft3 As PictureBox
    Friend WithEvents pRight3 As PictureBox
End Class
