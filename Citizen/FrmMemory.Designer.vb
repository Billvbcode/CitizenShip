<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemory
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
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TimClick = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RB8 = New System.Windows.Forms.RadioButton()
        Me.BtnMemory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.CB34 = New System.Windows.Forms.CheckBox()
        Me.CBWord = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CBLabel = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(792, 69)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 238)
        Me.ListBox2.TabIndex = 1
        Me.ListBox2.Visible = False
        '
        'TimClick
        '
        Me.TimClick.Interval = 3600
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(725, 131)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(8, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(844, 620)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(68, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(672, 183)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(172, 654)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 24)
        Me.RadioButton2.TabIndex = 46
        Me.RadioButton2.Text = "12"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(98, 654)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 24)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.Text = "10"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RB8
        '
        Me.RB8.AutoSize = True
        Me.RB8.Checked = True
        Me.RB8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB8.Location = New System.Drawing.Point(42, 654)
        Me.RB8.Name = "RB8"
        Me.RB8.Size = New System.Drawing.Size(37, 24)
        Me.RB8.TabIndex = 44
        Me.RB8.TabStop = True
        Me.RB8.Text = "8"
        Me.RB8.UseVisualStyleBackColor = True
        '
        'BtnMemory
        '
        Me.BtnMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemory.Location = New System.Drawing.Point(725, 633)
        Me.BtnMemory.Name = "BtnMemory"
        Me.BtnMemory.Size = New System.Drawing.Size(75, 41)
        Me.BtnMemory.TabIndex = 47
        Me.BtnMemory.Text = "Memory"
        Me.BtnMemory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(841, 647)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB3.Location = New System.Drawing.Point(245, 660)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(78, 20)
        Me.CB3.TabIndex = 49
        Me.CB3.Text = "3 Letter"
        Me.CB3.UseVisualStyleBackColor = True
        '
        'CB34
        '
        Me.CB34.AutoSize = True
        Me.CB34.Checked = True
        Me.CB34.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB34.Location = New System.Drawing.Point(343, 660)
        Me.CB34.Name = "CB34"
        Me.CB34.Size = New System.Drawing.Size(94, 20)
        Me.CB34.TabIndex = 50
        Me.CB34.Text = "3, 4 Letter"
        Me.CB34.UseVisualStyleBackColor = True
        '
        'CBWord
        '
        Me.CBWord.AutoSize = True
        Me.CBWord.Checked = True
        Me.CBWord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBWord.Location = New System.Drawing.Point(469, 660)
        Me.CBWord.Name = "CBWord"
        Me.CBWord.Size = New System.Drawing.Size(117, 20)
        Me.CBWord.TabIndex = 51
        Me.CBWord.Text = "Picture/Word"
        Me.CBWord.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(792, 358)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 212)
        Me.ListBox1.TabIndex = 52
        Me.ListBox1.Visible = False
        '
        'CBLabel
        '
        Me.CBLabel.AutoSize = True
        Me.CBLabel.Checked = True
        Me.CBLabel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLabel.Location = New System.Drawing.Point(613, 660)
        Me.CBLabel.Name = "CBLabel"
        Me.CBLabel.Size = New System.Drawing.Size(94, 20)
        Me.CBLabel.TabIndex = 53
        Me.CBLabel.Text = "TopLabel"
        Me.CBLabel.UseVisualStyleBackColor = True
        '
        'FrmMemory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 686)
        Me.Controls.Add(Me.CBLabel)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CBWord)
        Me.Controls.Add(Me.CB34)
        Me.Controls.Add(Me.CB3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMemory)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RB8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Name = "FrmMemory"
        Me.Text = "FrmMemory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TimClick As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RB8 As RadioButton
    Friend WithEvents BtnMemory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents CB34 As CheckBox
    Friend WithEvents CBWord As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CBLabel As CheckBox
End Class
