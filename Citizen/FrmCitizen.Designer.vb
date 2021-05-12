<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCitizen
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblQ = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.lblAnswer4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblAnswer3 = New System.Windows.Forms.Label()
        Me.LblAnswer2 = New System.Windows.Forms.Label()
        Me.LblAnswer1 = New System.Windows.Forms.Label()
        Me.LblQuestions = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnQuiz = New System.Windows.Forms.Button()
        Me.BtnQuestion = New System.Windows.Forms.Button()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 1200
        '
        'Timer1
        '
        Me.Timer1.Interval = 10800
        '
        'LblQ
        '
        Me.LblQ.AutoSize = True
        Me.LblQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQ.Location = New System.Drawing.Point(304, 21)
        Me.LblQ.Name = "LblQ"
        Me.LblQ.Size = New System.Drawing.Size(242, 20)
        Me.LblQ.TabIndex = 46
        Me.LblQ.Text = "Click to listen to the question"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(34, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Read Again"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(741, 22)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(73, 20)
        Me.LblScore.TabIndex = 36
        Me.LblScore.Text = "Label12"
        '
        'lblAnswer4
        '
        Me.lblAnswer4.AutoSize = True
        Me.lblAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer4.Location = New System.Drawing.Point(48, 398)
        Me.lblAnswer4.Name = "lblAnswer4"
        Me.lblAnswer4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnswer4.Size = New System.Drawing.Size(73, 20)
        Me.lblAnswer4.TabIndex = 35
        Me.lblAnswer4.Text = "Label12"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.LblScore)
        Me.Panel1.Controls.Add(Me.lblAnswer4)
        Me.Panel1.Controls.Add(Me.LblAnswer3)
        Me.Panel1.Controls.Add(Me.LblAnswer2)
        Me.Panel1.Controls.Add(Me.LblAnswer1)
        Me.Panel1.Controls.Add(Me.LblQuestions)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(10, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.Size = New System.Drawing.Size(1000, 600)
        Me.Panel1.TabIndex = 45
        Me.Panel1.Visible = False
        '
        'LblAnswer3
        '
        Me.LblAnswer3.AutoSize = True
        Me.LblAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswer3.Location = New System.Drawing.Point(48, 293)
        Me.LblAnswer3.Name = "LblAnswer3"
        Me.LblAnswer3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAnswer3.Size = New System.Drawing.Size(73, 20)
        Me.LblAnswer3.TabIndex = 34
        Me.LblAnswer3.Text = "Label12"
        '
        'LblAnswer2
        '
        Me.LblAnswer2.AutoSize = True
        Me.LblAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswer2.Location = New System.Drawing.Point(48, 176)
        Me.LblAnswer2.Name = "LblAnswer2"
        Me.LblAnswer2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAnswer2.Size = New System.Drawing.Size(73, 20)
        Me.LblAnswer2.TabIndex = 33
        Me.LblAnswer2.Text = "Label11"
        '
        'LblAnswer1
        '
        Me.LblAnswer1.AutoSize = True
        Me.LblAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswer1.Location = New System.Drawing.Point(48, 100)
        Me.LblAnswer1.Name = "LblAnswer1"
        Me.LblAnswer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAnswer1.Size = New System.Drawing.Size(102, 20)
        Me.LblAnswer1.TabIndex = 32
        Me.LblAnswer1.Text = "LblAnswer1"
        '
        'LblQuestions
        '
        Me.LblQuestions.AutoSize = True
        Me.LblQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestions.Location = New System.Drawing.Point(20, 42)
        Me.LblQuestions.Name = "LblQuestions"
        Me.LblQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblQuestions.Size = New System.Drawing.Size(73, 20)
        Me.LblQuestions.TabIndex = 31
        Me.LblQuestions.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(24, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(646, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(81, -20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Label11"
        '
        'BtnQuiz
        '
        Me.BtnQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuiz.Location = New System.Drawing.Point(884, 11)
        Me.BtnQuiz.Name = "BtnQuiz"
        Me.BtnQuiz.Size = New System.Drawing.Size(99, 50)
        Me.BtnQuiz.TabIndex = 43
        Me.BtnQuiz.Text = "Quiz"
        Me.BtnQuiz.UseVisualStyleBackColor = True
        '
        'BtnQuestion
        '
        Me.BtnQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuestion.Location = New System.Drawing.Point(31, 8)
        Me.BtnQuestion.Name = "BtnQuestion"
        Me.BtnQuestion.Size = New System.Drawing.Size(157, 50)
        Me.BtnQuestion.TabIndex = 42
        Me.BtnQuestion.Text = "Question"
        Me.BtnQuestion.UseVisualStyleBackColor = True
        '
        'RichTextBox4
        '
        Me.RichTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(534, 398)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(475, 300)
        Me.RichTextBox4.TabIndex = 41
        Me.RichTextBox4.Text = ""
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(12, 394)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(475, 300)
        Me.RichTextBox3.TabIndex = 40
        Me.RichTextBox3.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "1"
        Me.Label1.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(534, 74)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(475, 300)
        Me.RichTextBox2.TabIndex = 39
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 68)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(475, 320)
        Me.RichTextBox1.TabIndex = 38
        Me.RichTextBox1.Text = ""
        '
        'FrmCitizen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 707)
        Me.Controls.Add(Me.LblQ)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnQuiz)
        Me.Controls.Add(Me.BtnQuestion)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "FrmCitizen"
        Me.Text = "Citizenship Questions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblQ As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LblScore As Label
    Friend WithEvents lblAnswer4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblAnswer3 As Label
    Friend WithEvents LblAnswer2 As Label
    Friend WithEvents LblAnswer1 As Label
    Friend WithEvents LblQuestions As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnQuiz As Button
    Friend WithEvents BtnQuestion As Button
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
