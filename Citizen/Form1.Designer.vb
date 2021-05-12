<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblTest = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.TxtWords = New System.Windows.Forms.TextBox()
        Me.ListMy = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.PictureBox()
        Me.BtnShake = New System.Windows.Forms.Button()
        Me.LblWord = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.Timer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTest
        '
        Me.LblTest.AutoSize = True
        Me.LblTest.Location = New System.Drawing.Point(550, 8)
        Me.LblTest.Name = "LblTest"
        Me.LblTest.Size = New System.Drawing.Size(39, 13)
        Me.LblTest.TabIndex = 0
        Me.LblTest.Text = "Label1"
        Me.LblTest.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(472, 48)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(131, 355)
        Me.List1.Sorted = True
        Me.List1.TabIndex = 1
        '
        'TxtWords
        '
        Me.TxtWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWords.Location = New System.Drawing.Point(22, 256)
        Me.TxtWords.Name = "TxtWords"
        Me.TxtWords.Size = New System.Drawing.Size(246, 22)
        Me.TxtWords.TabIndex = 2
        '
        'ListMy
        '
        Me.ListMy.FormattingEnabled = True
        Me.ListMy.Location = New System.Drawing.Point(319, 48)
        Me.ListMy.Name = "ListMy"
        Me.ListMy.Size = New System.Drawing.Size(131, 355)
        Me.ListMy.Sorted = True
        Me.ListMy.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Timer
        '
        Me.Timer.Image = CType(resources.GetObject("Timer.Image"), System.Drawing.Image)
        Me.Timer.Location = New System.Drawing.Point(12, 8)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(486, 12)
        Me.Timer.TabIndex = 5
        Me.Timer.TabStop = False
        '
        'BtnShake
        '
        Me.BtnShake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShake.Location = New System.Drawing.Point(22, 316)
        Me.BtnShake.Name = "BtnShake"
        Me.BtnShake.Size = New System.Drawing.Size(73, 26)
        Me.BtnShake.TabIndex = 6
        Me.BtnShake.Text = "Shake"
        Me.BtnShake.UseVisualStyleBackColor = True
        '
        'LblWord
        '
        Me.LblWord.AutoSize = True
        Me.LblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWord.Location = New System.Drawing.Point(29, 297)
        Me.LblWord.Name = "LblWord"
        Me.LblWord.Size = New System.Drawing.Size(0, 16)
        Me.LblWord.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(497, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 26)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(636, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(131, 355)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 11
        Me.ListBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 458)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblWord)
        Me.Controls.Add(Me.BtnShake)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListMy)
        Me.Controls.Add(Me.TxtWords)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.LblTest)
        Me.Name = "Form1"
        Me.Text = "Boggle"
        CType(Me.Timer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTest As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents List1 As ListBox
    Friend WithEvents TxtWords As TextBox
    Friend WithEvents ListMy As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer As PictureBox
    Friend WithEvents BtnShake As Button
    Friend WithEvents LblWord As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
