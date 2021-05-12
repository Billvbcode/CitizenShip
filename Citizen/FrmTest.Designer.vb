<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTest
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
        Me.LblClick = New System.Windows.Forms.Label()
        Me.LblMousemove = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblClick
        '
        Me.LblClick.AutoSize = True
        Me.LblClick.Location = New System.Drawing.Point(654, 502)
        Me.LblClick.Name = "LblClick"
        Me.LblClick.Size = New System.Drawing.Size(39, 13)
        Me.LblClick.TabIndex = 0
        Me.LblClick.Text = "Label1"
        '
        'LblMousemove
        '
        Me.LblMousemove.AutoSize = True
        Me.LblMousemove.Location = New System.Drawing.Point(654, 545)
        Me.LblMousemove.Name = "LblMousemove"
        Me.LblMousemove.Size = New System.Drawing.Size(39, 13)
        Me.LblMousemove.TabIndex = 1
        Me.LblMousemove.Text = "Label2"
        '
        'FrmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 590)
        Me.Controls.Add(Me.LblMousemove)
        Me.Controls.Add(Me.LblClick)
        Me.Name = "FrmTest"
        Me.Text = "FrmTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblClick As Label
    Friend WithEvents LblMousemove As Label
End Class
