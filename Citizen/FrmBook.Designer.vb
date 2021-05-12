<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBook))
        Me.pStory = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnPicture = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.LblWidth = New System.Windows.Forms.Label()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.BtnSound = New System.Windows.Forms.Button()
        Me.TxtStory = New System.Windows.Forms.RichTextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnAdd2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGray = New System.Windows.Forms.Button()
        Me.BtnTrans = New System.Windows.Forms.Button()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.TxtLabel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnHide = New System.Windows.Forms.Button()
        Me.BntShow = New System.Windows.Forms.Button()
        Me.BtnMove = New System.Windows.Forms.Button()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAddPicture = New System.Windows.Forms.Button()
        CType(Me.pStory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pStory
        '
        Me.pStory.Image = CType(resources.GetObject("pStory.Image"), System.Drawing.Image)
        Me.pStory.Location = New System.Drawing.Point(232, 12)
        Me.pStory.Name = "pStory"
        Me.pStory.Size = New System.Drawing.Size(697, 343)
        Me.pStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pStory.TabIndex = 0
        Me.pStory.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(9, 3)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(118, 38)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "BackGround"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 365)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 324)
        Me.ListBox1.TabIndex = 2
        '
        'BtnPicture
        '
        Me.BtnPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPicture.Location = New System.Drawing.Point(12, 47)
        Me.BtnPicture.Name = "BtnPicture"
        Me.BtnPicture.Size = New System.Drawing.Size(118, 38)
        Me.BtnPicture.TabIndex = 3
        Me.BtnPicture.Text = "AddPicture"
        Me.BtnPicture.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(9, 109)
        Me.HScrollBar1.Maximum = 140
        Me.HScrollBar1.Minimum = 32
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(207, 29)
        Me.HScrollBar1.TabIndex = 5
        Me.HScrollBar1.Value = 32
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(12, 152)
        Me.HScrollBar2.Maximum = 140
        Me.HScrollBar2.Minimum = 32
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(204, 29)
        Me.HScrollBar2.TabIndex = 6
        Me.HScrollBar2.Value = 32
        '
        'LblWidth
        '
        Me.LblWidth.AutoSize = True
        Me.LblWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWidth.Location = New System.Drawing.Point(23, 96)
        Me.LblWidth.Name = "LblWidth"
        Me.LblWidth.Size = New System.Drawing.Size(86, 16)
        Me.LblWidth.TabIndex = 7
        Me.LblWidth.Text = "Picture Width"
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeight.Location = New System.Drawing.Point(23, 181)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(91, 16)
        Me.LblHeight.TabIndex = 8
        Me.LblHeight.Text = "Picture Height"
        '
        'BtnSound
        '
        Me.BtnSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSound.Location = New System.Drawing.Point(12, 213)
        Me.BtnSound.Name = "BtnSound"
        Me.BtnSound.Size = New System.Drawing.Size(118, 38)
        Me.BtnSound.TabIndex = 9
        Me.BtnSound.Text = "Sound"
        Me.BtnSound.UseVisualStyleBackColor = True
        '
        'TxtStory
        '
        Me.TxtStory.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStory.Location = New System.Drawing.Point(222, 365)
        Me.TxtStory.Name = "TxtStory"
        Me.TxtStory.Size = New System.Drawing.Size(685, 229)
        Me.TxtStory.TabIndex = 17
        Me.TxtStory.Text = ""
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(149, 211)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(67, 39)
        Me.BtnAdd.TabIndex = 18
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        Me.BtnAdd.Visible = False
        '
        'BtnAdd2
        '
        Me.BtnAdd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd2.Location = New System.Drawing.Point(149, 268)
        Me.BtnAdd2.Name = "BtnAdd2"
        Me.BtnAdd2.Size = New System.Drawing.Size(67, 39)
        Me.BtnAdd2.TabIndex = 20
        Me.BtnAdd2.Text = "Add"
        Me.BtnAdd2.UseVisualStyleBackColor = True
        Me.BtnAdd2.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 38)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "AddLabel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BtnGray)
        Me.Panel1.Controls.Add(Me.BtnTrans)
        Me.Panel1.Controls.Add(Me.HScrollBar3)
        Me.Panel1.Controls.Add(Me.TxtLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 365)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 324)
        Me.Panel1.TabIndex = 25
        Me.Panel1.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(35, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 38)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Test Marquee"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(53, 254)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 20)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Marquee"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label Color"
        '
        'BtnGray
        '
        Me.BtnGray.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGray.Location = New System.Drawing.Point(43, 206)
        Me.BtnGray.Name = "BtnGray"
        Me.BtnGray.Size = New System.Drawing.Size(110, 23)
        Me.BtnGray.TabIndex = 4
        Me.BtnGray.Text = "Gray"
        Me.BtnGray.UseVisualStyleBackColor = True
        '
        'BtnTrans
        '
        Me.BtnTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrans.Location = New System.Drawing.Point(43, 170)
        Me.BtnTrans.Name = "BtnTrans"
        Me.BtnTrans.Size = New System.Drawing.Size(110, 23)
        Me.BtnTrans.TabIndex = 3
        Me.BtnTrans.Text = "Transparent"
        Me.BtnTrans.UseVisualStyleBackColor = True
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(12, 121)
        Me.HScrollBar3.Maximum = 20
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(169, 26)
        Me.HScrollBar3.TabIndex = 2
        '
        'TxtLabel
        '
        Me.TxtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabel.Location = New System.Drawing.Point(6, 61)
        Me.TxtLabel.Name = "TxtLabel"
        Me.TxtLabel.Size = New System.Drawing.Size(147, 22)
        Me.TxtLabel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label Text"
        '
        'BtnHide
        '
        Me.BtnHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHide.Location = New System.Drawing.Point(149, 80)
        Me.BtnHide.Name = "BtnHide"
        Me.BtnHide.Size = New System.Drawing.Size(67, 26)
        Me.BtnHide.TabIndex = 29
        Me.BtnHide.Text = "Hide"
        Me.BtnHide.UseVisualStyleBackColor = True
        Me.BtnHide.Visible = False
        '
        'BntShow
        '
        Me.BntShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntShow.Location = New System.Drawing.Point(149, 56)
        Me.BntShow.Name = "BntShow"
        Me.BntShow.Size = New System.Drawing.Size(67, 24)
        Me.BntShow.TabIndex = 28
        Me.BntShow.Text = "Show"
        Me.BntShow.UseVisualStyleBackColor = True
        Me.BntShow.Visible = False
        '
        'BtnMove
        '
        Me.BtnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMove.Location = New System.Drawing.Point(149, 30)
        Me.BtnMove.Name = "BtnMove"
        Me.BtnMove.Size = New System.Drawing.Size(67, 25)
        Me.BtnMove.TabIndex = 27
        Me.BtnMove.Text = "Move"
        Me.BtnMove.UseVisualStyleBackColor = True
        Me.BtnMove.Visible = False
        '
        'BtnRead
        '
        Me.BtnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRead.Location = New System.Drawing.Point(362, 617)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(118, 38)
        Me.BtnRead.TabIndex = 30
        Me.BtnRead.Text = "Read"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 600
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        Me.Timer4.Interval = 300
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(502, 619)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(118, 38)
        Me.BtnSave.TabIndex = 35
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnOpen
        '
        Me.BtnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Location = New System.Drawing.Point(638, 617)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(118, 38)
        Me.BtnOpen.TabIndex = 36
        Me.BtnOpen.Text = "Load"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(796, 617)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(118, 38)
        Me.BtnNew.TabIndex = 38
        Me.BtnNew.Text = "New Book"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 679)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 676)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 679)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(515, 663)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(225, 22)
        Me.TxtName.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 669)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "StoryName"
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(232, 619)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(118, 54)
        Me.BtnStart.TabIndex = 44
        Me.BtnStart.Text = "Move to Start Location"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Timer5
        '
        Me.Timer5.Interval = 400
        '
        'BtnAddPicture
        '
        Me.BtnAddPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddPicture.Location = New System.Drawing.Point(9, 332)
        Me.BtnAddPicture.Name = "BtnAddPicture"
        Me.BtnAddPicture.Size = New System.Drawing.Size(100, 27)
        Me.BtnAddPicture.TabIndex = 45
        Me.BtnAddPicture.Text = "Add Picture"
        Me.BtnAddPicture.UseVisualStyleBackColor = True
        Me.BtnAddPicture.Visible = False
        '
        'FrmBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 717)
        Me.Controls.Add(Me.BtnAddPicture)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.BtnHide)
        Me.Controls.Add(Me.BntShow)
        Me.Controls.Add(Me.BtnMove)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAdd2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtStory)
        Me.Controls.Add(Me.BtnSound)
        Me.Controls.Add(Me.LblHeight)
        Me.Controls.Add(Me.LblWidth)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.BtnPicture)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.pStory)
        Me.Name = "FrmBook"
        Me.Text = "FrmBook"
        CType(Me.pStory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pStory As PictureBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnPicture As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents LblWidth As Label
    Friend WithEvents LblHeight As Label
    Friend WithEvents BtnSound As Button
    Friend WithEvents TxtStory As RichTextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnAdd2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtLabel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents BtnGray As Button
    Friend WithEvents BtnTrans As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnHide As Button
    Friend WithEvents BntShow As Button
    Friend WithEvents BtnMove As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnOpen As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnAddPicture As Button
End Class
