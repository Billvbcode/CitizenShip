Imports System.Speech
Imports System.Speech.Synthesis

Public Class FrmMemory
    Dim iCount As Integer
    Dim pSnake(800) As PictureBox
    Dim pLabel(800) As Label
    Dim lLabel(800) As Label
    Dim mLabel(800) As Label
    Dim iCnt As Integer
    Dim iPcnt As Integer
    Dim iSave(20) As Integer
    Dim iWord(30) As Integer
    Dim speaker As New SpeechSynthesizer
    Dim iRB As Integer
    Dim iPlay As Integer
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
                ListBox2.Items.Add(dra.ToString)
                If Len(dra.ToString) < 8 Then ListBox1.Items.Add(dra.ToString)
            End If
        Next
        j = ListBox2.Items.Count
        k = j
        '  sFile = "bug"
        ' picOriginal.Image = Image.FromFile(value & sFile)
    End Sub
    Private Sub plabel_Click(ByVal sender As Object, ByVal e As EventArgs)
        If TimClick.Enabled Then Exit Sub
        TextBox3.Text = sender.name
        Dim iPbox As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        iPbox = Val(sender.name) 'Find PictureBox Number
        iPcnt += 1 'Increase Click Counter
        Label1.Text = sender.name & " " & iPcnt
        If iPcnt = 1 Or iPcnt = 2 Then
            iSave(iPcnt) = iPbox 'Save Picture Box
            speaker.SpeakAsync(Mid(pSnake(iPbox).Tag, 1, Len(pSnake(iPbox).Tag) - 4)) 'Talk
        Else
            iSave(iPcnt) = iPbox 'Save Picture Box
            speaker.SpeakAsync("Oh OH") 'Ta
        End If


        pSnake(iPbox).Image = Image.FromFile(value & pSnake(iPbox).Tag) 'LoadJpg
        pSnake(iPbox).Width = pLabel(iPbox).Width
        pSnake(iPbox).Height = pLabel(iPbox).Height - 15
        pSnake(iPbox).Top = pLabel(iPbox).Top + 25
        pSnake(iPbox).Left = pLabel(iPbox).Left
        pSnake(iPbox).SizeMode = PictureBoxSizeMode.StretchImage
        pLabel(iPbox).Visible = False



        lLabel(iPbox).Text = Mid(pSnake(iPbox).Tag, 1, Len(pSnake(iPbox).Tag) - 4)
        mLabel(iPbox).Text = Mid(pSnake(iPbox).Tag, 1, Len(pSnake(iPbox).Tag) - 4)
        If iWord(iPbox) = 0 Then
            pSnake(iPbox).Visible = True
            lLabel(iPbox).Visible = CBLabel.Checked
        Else
            mLabel(iPbox).Visible = True
            lLabel(iPbox).Visible = False
        End If
        lLabel(iPbox).BringToFront()
        If iPcnt = 2 Then TimClick.Start() 'Start Timer

    End Sub
    Private Sub Game()
        Dim iJpg As Integer
        Dim Wnum As Single
        Dim Wnum2 As Single
        Dim iPbox As Integer
        Dim k As Integer
        Dim l As Integer
        Dim j As Integer
        Dim sMsg As String
        iPcnt = 0 ' Reset Picture Counter
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        GetFilesjpg()
        For k = 1 To 16   'Reset PictureBoxes
            pSnake(k).Tag = ""
            pSnake(k).Enabled = True
            pLabel(k).Visible = False
            lLabel(k).Visible = False
            mLabel(k).Visible = False
            pSnake(k).Visible = False
            iWord(k) = 0
        Next
        iJpg = ListBox2.Items.Count 'Total Jpg's
        ' Pick Random Jpg
        Wnum = iJpg - 0.001
        Wnum2 = iRB - 0.001
        'RT1.Text = ""
        For k = 1 To (iRB / 2) 'For 1/2 of the boxes
PickJpg:
            iJpg = Int(Rnd() * Wnum) 'Random Jpg
            For l = 1 To 16 'Make Sure Jpg is Unique
                If pSnake(l).Tag = ListBox2.Items(iJpg).ToString _
                    Then GoTo PickJpg
            Next
            iPbox = Int((Rnd() * Wnum2) + 1) 'Random PictureBox
            If pSnake(iPbox).Tag <> "" Then GoTo PickJpg 'Not Blank
            j = Len(ListBox2.Items(iJpg).ToString)
            sMsg = ListBox2.Items(iJpg).ToString
            If CB3.Checked And Len(ListBox2.Items(iJpg).ToString) > 7 Then GoTo PickJpg
            If CB34.Checked And Len(ListBox2.Items(iJpg).ToString) > 8 Then GoTo PickJpg
            If CBWord.Checked And Len(ListBox2.Items(iJpg).ToString) > 9 Then GoTo PickJpg
            pSnake(iPbox).Tag = ListBox2.Items(iJpg).ToString 'Tag= Unique Jpg
            pSnake(iPbox).Image = Image.FromFile(value & pSnake(iPbox).Tag) 'LoadJpg
            '  pLabel(iPbox).Text = "1- " & pSnake(iPbox).Tag & "-" & iJpg
            ' RT1.Text = RT1.Text & "1 ipbox=" & iPbox & " k=" & k & " ijpg=" & iJpg & vbCrLf
            iWord(iPbox) = 0
            If CBWord.Checked Then iWord(iPbox) = 999
PickPbox2:
            iPbox = Int((Rnd() * Wnum2) + 1) 'Random PictureBox
            If pSnake(iPbox).Tag <> "" Then GoTo PickPbox2 'Not Blank
            pSnake(iPbox).Tag = ListBox2.Items(iJpg).ToString 'Tag= Unique Jpg
            pSnake(iPbox).Image = Image.FromFile(value & pSnake(iPbox).Tag) 'LoadJpg
            '   pLabel(iPbox).Text = "2- " & pSnake(iPbox).Tag & "-" & iJpg
            ' RT1.Text = RT1.Text & "2 ipbox=" & iPbox & " k=" & k & " ijpg=" & iJpg & vbCrLf
            iWord(iPbox) = 0
        Next
        For k = 1 To iRB 'Set all images to pCover
            pSnake(k).Visible = False
            pLabel(k).Visible = True
        Next
        '  BtnStart.Visible = False  ' Hide Start Button
    End Sub


    Private Sub FrmMemory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        GetFilesjpg()

        Randomize()
        '   iCnt = 1
        '
        For i = 1 To 40 ' Horizontal
            pSnake(iCnt) = New System.Windows.Forms.PictureBox    'PictureBox
            With pSnake(iCnt)
                .Name = "A" & iCnt                                  'PictureBox Name
                .Size = New Size(75, 75)
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Location = New System.Drawing.Point(24 + (i - 1) * 82, 6)
                .Visible = False
                ' .
            End With
            Me.Controls.Add(pSnake(iCnt)) '  This is the create the label
            pLabel(iCnt) = New System.Windows.Forms.Label    'PictureBox
            With pLabel(iCnt)
                .Name = iCnt
                .AutoSize = False '
                .Size = New Size(22, 22)
                ' .SizeMode = PictureBoxSizeMode.AutoSize
                .Location = New System.Drawing.Point(24 + (i - 1) * 22, 6)
                .TextAlign = ContentAlignment.MiddleCenter
                .Visible = False
                .BackColor = Color.LightGreen
                .Font = New Font("Times New Roman", 36, FontStyle.Bold)
                .Text = iCnt
                Visible = False
            End With
            Me.Controls.Add(pLabel(iCnt)) '  This is the create the label
            AddHandler pLabel(iCnt).Click, AddressOf plabel_Click 'Click Event
            '
            lLabel(iCnt) = New System.Windows.Forms.Label    'PictureBox
            With lLabel(iCnt)
                .Name = "L" & iCnt
                .AutoSize = True '
                .Size = New Size(22, 22)
                ' .SizeMode = PictureBoxSizeMode.AutoSize
                .Location = New System.Drawing.Point(24 + (i - 1) * 22, 6)
                .TextAlign = ContentAlignment.BottomCenter
                .Visible = False
                .BackColor = Color.Yellow
                .Font = New Font("Times New Roman", 16, FontStyle.Bold)
                .Text = iCnt
                .Visible = False
            End With
            Me.Controls.Add(lLabel(iCnt)) '  This is the create the label
            '
            '
            mLabel(iCnt) = New System.Windows.Forms.Label    'PictureBox
            With mLabel(iCnt)
                .Name = "m" & iCnt
                .AutoSize = True '
                .Size = New Size(22, 22)
                ' .SizeMode = PictureBoxSizeMode.AutoSize
                .Location = New System.Drawing.Point(24 + (i - 1) * 22, 6)
                .TextAlign = ContentAlignment.BottomCenter
                .Visible = False
                .BackColor = Color.Aqua
                .Font = New Font("Times New Roman", 22, FontStyle.Bold)
                .Text = iCnt
                .Visible = False
                .BringToFront()
            End With
            Me.Controls.Add(mLabel(iCnt)) '  This is the create the label
            iCnt = iCnt + 1 ' Increase PictureBox counter
        Next
        '  Exit Sub
        For i = 1 To 4
            pLabel(i).Top = 30
            pLabel(i).Left = 190 * i - 180
            lLabel(i).Top = 30
            lLabel(i).Left = 190 * i - 180
            mLabel(i).Top = 30 + 80
            mLabel(i).Left = 190 * i - 180 + 40
            pLabel(i).Width = 180
            pLabel(i).Height = 180
            '   mLabel(i).Visible = True
        Next
        '   Exit Sub
        For i = 5 To 8
            pLabel(i).Top = 30 + 190
            pLabel(i).Left = 190 * (i - 4) - 180
            lLabel(i).Top = 30 + 190
            lLabel(i).Left = 190 * (i - 4) - 180
            mLabel(i).Top = 30 + 190 + 80
            mLabel(i).Left = 190 * (i - 4) - 180 + 40
            pLabel(i).Width = 180
            pLabel(i).Height = 180
            '  mLabel(i).Visible = True
        Next
        For i = 9 To 12
            pLabel(i).Top = 30 + 190 * 2
            pLabel(i).Left = 190 * (i - 8) - 180
            lLabel(i).Top = 30 + 190 * 2
            lLabel(i).Left = 190 * (i - 8) - 180
            mLabel(i).Top = 30 + 190 * 2 + 80
            mLabel(i).Left = 190 * (i - 8) - 180 + 40
            pLabel(i).Width = 180
            pLabel(i).Height = 180
            '   mLabel(i).Visible = True
        Next
        iRB = 8
        ' Exit Sub
        '
        Game()
    End Sub

    Private Sub TimClick_Tick(sender As Object, e As EventArgs) Handles TimClick.Tick
        '  Dim i As Integer
        TextBox2.Text = iSave(1) & "= " & pSnake(iSave(1)).Tag & " " & iSave(2) & "= " & pSnake(iSave(2)).Tag
        If pSnake(iSave(1)).Tag <> pSnake(iSave(2)).Tag Then
            pSnake(iSave(1)).Visible = False
            pSnake(iSave(2)).Visible = False
            pLabel(iSave(1)).Visible = True
            pLabel(iSave(2)).Visible = True
            lLabel(iSave(1)).Visible = False
            lLabel(iSave(2)).Visible = False
            mLabel(iSave(1)).Visible = False
            mLabel(iSave(2)).Visible = False
        Else
            pSnake(iSave(1)).Enabled = False 'Disable PictureBox
            pSnake(iSave(2)).Enabled = False 'Disable PictureBox
            lLabel(iSave(1)).Visible = True
            lLabel(iSave(2)).Visible = CBLabel.Checked
            mLabel(iSave(1)).Visible = True
            mLabel(iSave(2)).Visible = True
            pSnake(iSave(1)).Visible = True
            pSnake(iSave(2)).Visible = True
        End If
        iPcnt = 0 'Reset PictureBox Counter
        TimClick.Stop() 'Stop Timer

        'For i = 1 To 16 ' Exit in any PictureBox is Enabled
        '    If pSnake(i).Enabled Then Exit Sub
        'Next
        'BtnStart.Visible = True
    End Sub

    Private Sub BtnMemory_Click(sender As Object, e As EventArgs) Handles BtnMemory.Click
        Game()
    End Sub
    Private Sub RB8_Click(sender As Object, e As EventArgs) Handles RB8.Click
        iRB = 8
        Game()
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        iRB = 10
        Game()
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        iRB = 12
        Game()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub CB34_Click(sender As Object, e As EventArgs) Handles CB34.Click
        CB3.Checked = False
        Game()
        'If CB34.Checked Then
        '    CB34.Checked = False
        'Else
        '    CB34.Checked = True
        'End If
    End Sub

    Private Sub CB3_Click(sender As Object, e As EventArgs) Handles CB3.Click
        CB34.Checked = False
        Game()
        'If CB3.Checked Then
        '    CB3.Checked = False
        'Else
        '    CB3.Checked = True
        'End If
    End Sub

    Private Sub CB3_CheckedChanged(sender As Object, e As EventArgs) Handles CB3.CheckedChanged

    End Sub

    Private Sub CBWord_CheckedChanged(sender As Object, e As EventArgs) Handles CBWord.CheckedChanged
        'If CBWord.Checked Then Game()
    End Sub

    Private Sub CBWord_Click(sender As Object, e As EventArgs) Handles CBWord.Click
        If CBWord.Checked Then Game()
    End Sub

    Private Sub CBLabel_CheckedChanged(sender As Object, e As EventArgs) Handles CBLabel.CheckedChanged
        'Dim i As Integer
        'For i = 1 To 16
        '    If CBLabel.Checked Then
        '        If pLabel(i).Visible = False Then lLabel(i).Visible = True
        '    Else
        '            lLabel(i).Visible = False
        '    End If
        'Next
    End Sub

    Private Sub CBLabel_Click(sender As Object, e As EventArgs) Handles CBLabel.Click
        Dim i As Integer
        For i = 1 To iRB
            If CBLabel.Checked Then
                If pLabel(i).Visible = False Then lLabel(i).Visible = True
            Else
                lLabel(i).Visible = False
            End If
        Next
    End Sub
End Class