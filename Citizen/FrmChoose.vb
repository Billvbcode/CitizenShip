Imports System.Speech
Imports System.Speech.Synthesis
Public Class FrmChoose
    Dim iCount As Integer
    Dim Ppic(800) As PictureBox
    Dim iCnt As Integer
    Dim iPcnt As Integer
    Dim iSave(20) As Integer
    Dim iWord(30) As Integer
    Dim speaker As New SpeechSynthesizer
    Dim iRB As Integer
    Dim iPlay As Integer
    Dim rnd As Random
    Dim pLabel(800) As Label
    Dim bwin As Boolean
    Dim iPick As Integer
    Dim bStart As Boolean
    'Click Event
    Private Sub pPic_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        Dim j As Integer
        If Timer1.Enabled Then Exit Sub
        If bwin Then
            Game()
            Exit Sub
        End If
        i = Val(Mid(sender.name, 2, 3)) ' Extract Picture Number
        iPick = i
        LblClick.Text = "Click  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
        If sender.tag = LblWord.Text Then
            bwin = True
            For j = 1 To 16
                If i <> j Then
                    Ppic(j).Visible = False
                    pLabel(j).Visible = False
                End If
            Next
        Else
            Timer1.Start()
        End If
        pLabel(i).Visible = True
        speaker.SpeakAsync(sender.tag)
    End Sub

    'MouseMove Event 
    Private Sub pPic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Dim i As Integer
        i = Val(Mid(sender.name, 2, 3)) ' Extract Picture Number
        LblMouseMove.Text = "Mouse  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
    End Sub

    Private Sub GetFilesjpg()
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        '    Dim sFolder As String
        Dim j As Integer
        Dim k As Integer
        Dim sMsg As String
        '
        ' Check to see if the Directory Exist
        '
        ' sFolder = "Jpg"
        'CheckDir(sFolder) 'Suburoutine in Module
        '
        ' Read all the levels
        '
        ListBox2.Items.Clear()  'Clear ListBox
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.wmf")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            sMsg = dra.Name
            If UCase(Mid(sMsg, 1, 3)) = "BOY" Then
                sMsg = dra.Name
            End If
            If Mid(sMsg, Len(sMsg) - 4, 1) > "A" Then ' ListBox1.Items.Add(Mid(sMsg, 1, Len(sMsg) - 4))
                If Len(dra.ToString) < 9 Then ListBox2.Items.Add(UCase(dra.ToString))
                If Len(dra.ToString) < 9 Then ListBox1.Items.Add(UCase(dra.ToString))
            End If
        Next
        j = ListBox2.Items.Count
        k = j
        '  sFile = "bug"
        ' picOriginal.Image = Image.FromFile(value & sFile)
    End Sub
    Private Sub FrmChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        GetFilesjpg()

        Randomize()
        iCnt = 1
        '

        For j = 1 To 4     ' Vertical
            For i = 1 To 4 ' Horizontal
                Ppic(iCnt) = New System.Windows.Forms.PictureBox    'PictureBox
                With Ppic(iCnt)
                    'NOTE: Icnt has leading zeros 
                    .Name = "P" & Format(iCnt, "000")    'PictureBox Name 
                    .Image = PB1.Image
                    .Tag = iCnt  'Tag=A,B,C ect                       
                    .Size = New Size(100, 100)
                    .Visible = False
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Location = New System.Drawing.Point(14 + (i - 1) * 145,
                                                         86 + (j - 1) * 145)
                End With
                ' Me.Controls.Add(pPic(Icnt)) '  Add Picture to Form (commeted out)
                Me.Controls.Add(Ppic(iCnt)) '  Add Picture to Panel1
                AddHandler Ppic(iCnt).Click, AddressOf pPic_Click 'Click Event
                AddHandler Ppic(iCnt).MouseMove, AddressOf pPic_MouseMove 'Mouse Event
                '
                pLabel(iCnt) = New System.Windows.Forms.Label    'PictureBox
                With pLabel(iCnt)
                    .Name = iCnt
                    .AutoSize = True '
                    .Size = New Size(22, 22)
                    ' .SizeMode = PictureBoxSizeMode.AutoSize
                    .Location = New System.Drawing.Point(24 + (i - 1) * 22, 6)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Visible = False
                    .BackColor = Color.LightGreen
                    .Font = New Font("Times New Roman", 20, FontStyle.Bold)
                    .Text = iCnt
                    ' .Visible = True
                End With
                Me.Controls.Add(pLabel(iCnt)) '  This is the create the label
                iCnt = iCnt + 1 ' Increase Label counter
            Next
        Next
        For i = 1 To 16
            pLabel(i).Top = Ppic(i).Top + 95
            pLabel(i).Left = Ppic(i).Left
            pLabel(i).BringToFront()
        Next
        iRB = 8
        ' Exit Sub
        rnd = New Random
        Timer1.Interval = 400
        bwin = True
        Timer1.Start()
    End Sub
    Private Sub Game()
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        Dim iMax As Integer
        Dim i As Integer
        Dim j As Integer
        Dim icnt As Integer
        Dim sMsg As String
        bwin = False
        iMax = ListBox2.Items.Count
        For i = 1 To 16
            Ppic(i).Tag = ""
            Ppic(i).Enabled = True
            Ppic(i).Visible = False
            pLabel(i).Visible = False
        Next
        For icnt = 1 To iRB
Pickagain:
            j = rnd.Next(0, iMax)
            sMsg = Replace(ListBox2.Items(j), ".WMF", "")
            For i = 1 To 16
                If Ppic(i).Tag = sMsg Then GoTo Pickagain
            Next
            Ppic(icnt).Image = Image.FromFile(value & ListBox2.Items(j))
            Ppic(icnt).Tag = sMsg
            Ppic(icnt).Visible = True
            pLabel(icnt).Text = sMsg
        Next
        j = rnd.Next(1, iRB + 1)
        LblWord.Text = Ppic(j).Tag
        speaker.SpeakAsync(LblWord.Text) 'Talk

    End Sub

    Private Sub Rb4_Click(sender As Object, e As EventArgs) Handles Rb4.Click
        If Timer1.Enabled Then Exit Sub
        iRB = 4
        Game()
    End Sub

    Private Sub RB8_Click(sender As Object, e As EventArgs) Handles RB8.Click
        If Timer1.Enabled Then Exit Sub
        iRB = 8
        Game()
    End Sub

    Private Sub RB16_Click(sender As Object, e As EventArgs) Handles RB16.Click
        If Timer1.Enabled Then Exit Sub
        iRB = 16
        Game()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As Integer
        j = rnd.Next(1, iRB + 1)
        LblWord.Text = Ppic(j).Tag
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If bwin Then
            Game()
        Else
            speaker.SpeakAsync(LblWord.Text)
        End If

    End Sub

    Private Sub LblWord_MouseEnter(sender As Object, e As EventArgs) Handles LblWord.MouseEnter
        If bwin Then
            Game()
        Else
            speaker.SpeakAsync(LblWord.Text)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '   Dim i As Integer
        If bwin Then

            Game()
            Timer1.Stop()
            Timer1.Interval = 2400
        Else
            Ppic(iPick).Visible = False
            pLabel(iPick).Visible = False
            speaker.SpeakAsync(LblWord.Text)
        End If
        Timer1.Stop()

    End Sub

    Private Sub FrmChoose_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If bwin Then Game()
    End Sub
End Class