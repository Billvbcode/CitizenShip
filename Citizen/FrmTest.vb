Public Class FrmTest
    'https://roguesharp.wordpress.com/2014/05/18/tutorial-1-roguelike-map-generation-using-roguesharp-and-monogame/
    'https://roguesharp.wordpress.com/2014/05/18/tutorial-1-roguelike-map-generation-using-roguesharp-and-monogame/
    'Dim  spriteBatch  As 
    Dim pPic(200) As PictureBox 'Array of PictureBoxes
    'Click Event
    Private Sub pPic_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        i = Val(Mid(sender.name, 2, 3)) ' Extract Picture Number
        LblClick.Text = "Click  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
    End Sub

    'MouseMove Event 
    Private Sub pPic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Dim i As Integer
        i = Val(Mid(sender.name, 2, 3)) ' Extract Picture Number
        LblMouseMove.Text = "Mouse  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
    End Sub

    Private Sub FrmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer
        Dim j As Integer
        Dim Icnt As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\" ' & sFolder & "\"
        Icnt = 1 ' PictureBox counter
        For j = 1 To 3     ' Vertical
            For i = 1 To 3 ' Horizontal
                pPic(Icnt) = New System.Windows.Forms.PictureBox    'PictureBox
                With pPic(Icnt)
                    'NOTE: Icnt has leading zeros 
                    .Name = "P" & Format(Icnt, "000")    'PictureBox Name 
                    '  .Image = PictureBox1.Image
                    .Tag = Chr(64 + Icnt)  'Tag=A,B,C ect                       
                    .Size = New Size(22, 22)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Location = New System.Drawing.Point(4 + (i - 1) * 22,
                                                         6 + (j - 1) * 22)
                End With
                ' Me.Controls.Add(pPic(Icnt)) '  Add Picture to Form (commeted out)
                Me.Controls.Add(pPic(Icnt)) '  Add Picture to Panel1
                AddHandler pPic(Icnt).Click, AddressOf pPic_Click 'Click Event
                AddHandler pPic(Icnt).MouseMove, AddressOf pPic_MouseMove 'Mouse Event
                Icnt = Icnt + 1 ' Increase Label counter
            Next
        Next

        pPic(1).Image = Image.FromFile(value & "floor.png")
        pPic(2).Image = Image.FromFile(value & "wall.png")

    End Sub
End Class