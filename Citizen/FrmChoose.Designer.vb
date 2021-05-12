<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChoose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChoose))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.RB8 = New System.Windows.Forms.RadioButton()
        Me.RB16 = New System.Windows.Forms.RadioButton()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.LblClick = New System.Windows.Forms.Label()
        Me.LblMouseMove = New System.Windows.Forms.Label()
        Me.Rb4 = New System.Windows.Forms.RadioButton()
        Me.LblWord = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(775, 49)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 212)
        Me.ListBox1.TabIndex = 53
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(788, 371)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 238)
        Me.ListBox2.TabIndex = 54
        Me.ListBox2.Visible = False
        '
        'RB8
        '
        Me.RB8.AutoSize = True
        Me.RB8.Checked = True
        Me.RB8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB8.Location = New System.Drawing.Point(82, 661)
        Me.RB8.Name = "RB8"
        Me.RB8.Size = New System.Drawing.Size(43, 29)
        Me.RB8.TabIndex = 55
        Me.RB8.Text = "8"
        Me.RB8.UseVisualStyleBackColor = True
        '
        'RB16
        '
        Me.RB16.AutoSize = True
        Me.RB16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB16.Location = New System.Drawing.Point(156, 661)
        Me.RB16.Name = "RB16"
        Me.RB16.Size = New System.Drawing.Size(56, 29)
        Me.RB16.TabIndex = 56
        Me.RB16.Text = "16"
        Me.RB16.UseVisualStyleBackColor = True
        '
        'PB1
        '
        Me.PB1.Image = CType(resources.GetObject("PB1.Image"), System.Drawing.Image)
        Me.PB1.Location = New System.Drawing.Point(380, 640)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(48, 50)
        Me.PB1.TabIndex = 57
        Me.PB1.TabStop = False
        Me.PB1.Visible = False
        '
        'LblClick
        '
        Me.LblClick.AutoSize = True
        Me.LblClick.Location = New System.Drawing.Point(455, 636)
        Me.LblClick.Name = "LblClick"
        Me.LblClick.Size = New System.Drawing.Size(39, 13)
        Me.LblClick.TabIndex = 58
        Me.LblClick.Text = "Label1"
        Me.LblClick.Visible = False
        '
        'LblMouseMove
        '
        Me.LblMouseMove.AutoSize = True
        Me.LblMouseMove.Location = New System.Drawing.Point(455, 672)
        Me.LblMouseMove.Name = "LblMouseMove"
        Me.LblMouseMove.Size = New System.Drawing.Size(39, 13)
        Me.LblMouseMove.TabIndex = 59
        Me.LblMouseMove.Text = "Label2"
        Me.LblMouseMove.Visible = False
        '
        'Rb4
        '
        Me.Rb4.AutoSize = True
        Me.Rb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb4.Location = New System.Drawing.Point(12, 661)
        Me.Rb4.Name = "Rb4"
        Me.Rb4.Size = New System.Drawing.Size(43, 29)
        Me.Rb4.TabIndex = 60
        Me.Rb4.Text = "4"
        Me.Rb4.UseVisualStyleBackColor = True
        '
        'LblWord
        '
        Me.LblWord.AutoSize = True
        Me.LblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWord.Location = New System.Drawing.Point(151, 9)
        Me.LblWord.Name = "LblWord"
        Me.LblWord.Size = New System.Drawing.Size(92, 29)
        Me.LblWord.TabIndex = 61
        Me.LblWord.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(734, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(647, 287)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(114, 342)
        Me.ListBox3.TabIndex = 63
        Me.ListBox3.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(249, 652)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 38)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Game"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2400
        '
        'FrmChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 702)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblWord)
        Me.Controls.Add(Me.Rb4)
        Me.Controls.Add(Me.LblMouseMove)
        Me.Controls.Add(Me.LblClick)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.RB16)
        Me.Controls.Add(Me.RB8)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "FrmChoose"
        Me.Text = "FrmChoose"
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents RB8 As RadioButton
    Friend WithEvents RB16 As RadioButton
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents LblClick As Label
    Friend WithEvents LblMouseMove As Label
    Friend WithEvents Rb4 As RadioButton
    Friend WithEvents LblWord As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
