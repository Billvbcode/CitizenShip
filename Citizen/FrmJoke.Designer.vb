<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJoke
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
        Me.BtnA = New System.Windows.Forms.Button()
        Me.BtnQ = New System.Windows.Forms.Button()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.LblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnA
        '
        Me.BtnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnA.Location = New System.Drawing.Point(28, 186)
        Me.BtnA.Name = "BtnA"
        Me.BtnA.Size = New System.Drawing.Size(101, 23)
        Me.BtnA.TabIndex = 0
        Me.BtnA.Text = "Answer"
        Me.BtnA.UseVisualStyleBackColor = True
        '
        'BtnQ
        '
        Me.BtnQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQ.Location = New System.Drawing.Point(28, 105)
        Me.BtnQ.Name = "BtnQ"
        Me.BtnQ.Size = New System.Drawing.Size(101, 23)
        Me.BtnQ.TabIndex = 1
        Me.BtnQ.Text = "Question"
        Me.BtnQ.UseVisualStyleBackColor = True
        '
        'LblQuestion
        '
        Me.LblQuestion.AutoSize = True
        Me.LblQuestion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion.Location = New System.Drawing.Point(158, 109)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(0, 19)
        Me.LblQuestion.TabIndex = 35
        '
        'LblAnswer
        '
        Me.LblAnswer.AutoSize = True
        Me.LblAnswer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnswer.Location = New System.Drawing.Point(158, 190)
        Me.LblAnswer.Name = "LblAnswer"
        Me.LblAnswer.Size = New System.Drawing.Size(0, 19)
        Me.LblAnswer.TabIndex = 36
        '
        'FrmJoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 348)
        Me.Controls.Add(Me.LblAnswer)
        Me.Controls.Add(Me.LblQuestion)
        Me.Controls.Add(Me.BtnQ)
        Me.Controls.Add(Me.BtnA)
        Me.Name = "FrmJoke"
        Me.Text = "FrmJoke"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnA As Button
    Friend WithEvents BtnQ As Button
    Friend WithEvents LblQuestion As Label
    Friend WithEvents LblAnswer As Label
End Class
