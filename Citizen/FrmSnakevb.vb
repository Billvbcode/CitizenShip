Imports System.Speech
Imports System.Speech.Synthesis

Public Class FrmSnakevb
    Dim pAngry(800) As PictureBox
    Dim sDir As String
    Dim iCnt As Integer
    Dim iLen As Integer
    Dim iSnake(200) As Integer
    Dim iWloc(10) As Integer
    Dim sWord(10) As String
    Dim iwCnt As Integer
    Dim iLet As Integer
    Dim iDeltaX As Integer
    Dim iDeltaY As Integer
    Dim iPick As Integer
    Dim iPick1 As Integer
    Dim iTick As Integer
    Dim iLevel As Integer
    Dim iLetMove As Integer
    Dim iClickVal As Integer
    Dim speaker As New SpeechSynthesizer
    Private Sub tMove()
        Dim i As Integer
        Dim m As Integer
        'iTick = iTick + 1
        Select Case sDir
            Case "R"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) + 1
                If iSnake(1) > 64 Then iSnake(1) = 1
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pRight.Image = pRight2.Image
                '
            Case "L"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) - 1
                If iSnake(1) < 1 Then iSnake(1) = iSnake(1) + 64
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pLeft.Image = pLeft2.Image
            Case "D"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) + 8
                If iSnake(1) > 64 Then iSnake(1) = iSnake(1) - 64
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pDown.Image = pDown2.Image
            Case "U"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) - 8
                If iSnake(1) < 0 Then iSnake(1) = iSnake(1) + 64
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pUp.Image = pUp2.Image
        End Select
        For i = 1 To 10
            If iSnake(1) = iWloc(i) Then
                iPick = i
                iTick = 1
                iPick1 = iSnake(1)
                If Mid(LblWord.Tag, iLet, 1) = sWord(i) Then
                    iDeltaX = Int((pAngry(iPick1).Top - LblWord.Top) / 6)
                    iDeltaY = Int((pAngry(iPick1).Left - LblWord.Left) / 6)
                    Label2.Text = iPick1 & " " & pAngry(iPick1).Top & " " & pAngry(iPick1).Left
                    TimYes.Enabled = True
                Else
                    m = 2
                    'iDeltaX = pAngry(iPick1).Top
                    'iDeltaY = pAngry(iPick1).Left
                    TimNo.Enabled = True
                End If
                ' TimMove.Enabled = False
            End If
        Next
    End Sub
    Private Sub pAngry_Click(ByVal sender As Object, ByVal e As EventArgs)
        '  pAngry(Val(sender.name)).Image = pAll.Image
        '  pAngry(Val(sender.name)).Tag = pAll.Tag
        LblTest.Text = sender.name & " " & sender.tag ' Button Text
        'p
    End Sub
    Private Sub GetFiles()
        '
        ' List all Pictures
        '
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        Dim di As New IO.DirectoryInfo(value)
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.*")
        Dim dra As IO.FileInfo
        Dim sMsg As String
        ListBox1.Items.Clear()
        For Each dra In diar1
            If Len(dra.ToString) < 9 Then
                ' ListBox1.Items.Add(UCase(dra.ToString))
                sMsg = UCase(dra.Name)
                If UCase(Mid(sMsg, 1, 3)) = "BOY" Then
                    sMsg = dra.Name
                End If
                If Mid(sMsg, Len(sMsg) - 4, 1) > "A" Then ListBox1.Items.Add(Mid(sMsg, 1, Len(sMsg) - 4))
            End If
        Next
        Label2.Text = ListBox1.Items.Count
    End Sub
    Private Sub Game()
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        '
        ' Reset Grid to green
        '
        For i = 1 To 64
            pAngry(i).Image = pGreen.Image   'Green Image
        Next
        For i = 1 To 10
            iWloc(i) = 0
        Next
NewWord:
        k = ListBox1.Items.Count
        k = (Int(k - 0.01) * Rnd() + 1)
        iwCnt = Len(ListBox1.Items(k)) '- 4
        '
        ' Set LblWord to 3 or 4 letter word
        '
        If iwCnt = 4 Then
            If iLevel = 1 Then GoTo NewWord
        End If
        LblWord.Tag = Mid(ListBox1.Items(k), 1, iwCnt)
        LblWord.Text = LblWord.Tag
        '
        ' Load Picture
        '
        pAns.Image = Image.FromFile(value & ListBox1.Items(k) & ".wmf")
        Label2.Text = LblWord.Tag
        '
        ' Set Snake
        '
        iLen = 3
        pAngry(28).Image = pHead.Image
        pAngry(27).Image = pBody.Image
        pAngry(26).Image = pBody.Image
        sDir = "R"
        Lbl4.Visible = False
        For i = 1 To 3
            iSnake(i) = 29 - i
        Next
        '
        ' Place Letters on Grid
        '
        For i = 1 To iwCnt
Myredo:
            j = Int(63.9 * Rnd() + 1)
            For k = 1 To 3
                If iSnake(k) = j Then GoTo Myredo
            Next
            For k = 1 To 10
                If iWloc(k) = j Then GoTo Myredo
            Next
            iWloc(i) = j
            Select Case i
                Case 1
                    Lbl1.Top = pAngry(j).Top
                    Lbl1.Left = pAngry(j).Left
                    Lbl1.Text = Mid(LblWord.Tag, 1, 1)
                    sWord(1) = Lbl1.Text
                    Lbl1.Visible = True
                    Lbl1.Tag = j
                Case 2
                    Lbl2.Top = pAngry(j).Top
                    Lbl2.Left = pAngry(j).Left
                    Lbl2.Text = Mid(LblWord.Tag, 2, 1)
                    sWord(2) = Lbl2.Text
                    Lbl2.Visible = True
                    Lbl2.Tag = j
                Case 3
                    Lbl3.Top = pAngry(j).Top
                    Lbl3.Left = pAngry(j).Left
                    Lbl3.Text = Mid(LblWord.Tag, 3, 1)
                    sWord(3) = Lbl3.Text
                    Lbl3.Visible = True
                    Lbl3.Tag = j
                Case 4
                    Lbl4.Top = pAngry(j).Top
                    Lbl4.Left = pAngry(j).Left
                    Lbl4.Visible = True
                    Lbl4.Text = Mid(LblWord.Tag, 4, 1)
                    sWord(4) = Lbl4.Text
                    Lbl4.Tag = j
            End Select
        Next
        '
        ' Start With Letter 1
        '
        iLet = 1
        speaker.SpeakAsync(LblWord.Text)  'LblWord.Text
        TimStart.Enabled = True
        iLetMove = 0
        iClickVal = 0
    End Sub
    Private Sub FrmSnakevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        iLetMove = 0
        Dim value As String = My.Application.Info.DirectoryPath & "\4jpg\"

        '
        pGreen.Image = Image.FromFile(value & "green.jpg")
        pHead.Image = Image.FromFile(value & "head.jpg")
        pBody.Image = Image.FromFile(value & "body.jpg")
        ' POrange1.Image = Image.FromFile(value & "wo.png")
        ' PGW.Image = Image.FromFile(value & "gw.png")
        ' POW.Image = Image.FromFile(value & "ow.png")
        pBody2.Image = pBody.Image
        iCnt = 1 ' PictureBox counter
        For j = 1 To 8    ' Vertical
            For i = 1 To 8 ' Horizontal
                pAngry(iCnt) = New System.Windows.Forms.PictureBox    ' PictureBox
                With pAngry(iCnt)
                    .Name = iCnt                                  'PictureBox Name
                    .Image = pGreen.Image   'Green Image
                    .Tag = "G"              'G=Green Tag
                    .Size = New Size(60, 60)
                    .Location = New System.Drawing.Point(24 + (i - 1) * 60,
                                                         24 + (j - 1) * 60)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                End With
                Me.Controls.Add(pAngry(iCnt)) '  This is the create the label
                AddHandler pAngry(iCnt).Click, AddressOf pAngry_Click 'Click Event
                iCnt = iCnt + 1 ' Increase PictureBox counter
            Next
        Next
        '
        iLevel = 1
        Me.Text = "Snake Level=" & iLevel & " 3-Letter"
        pUp.Image = pUp3.Image
        pDown.Image = pDown3.Image
        pRight.Image = pRight3.Image
        pLeft.Image = pLeft3.Image
        pUp.Visible = False
        pDown.Visible = False
        pRight.Visible = False
        pLeft.Visible = False
        GetFiles()    'List Jpg's
        Game()        'Start Game
    End Sub
    Private Sub TimMove_Tick(sender As Object, e As EventArgs) Handles TimMove.Tick
        Dim i As Integer
        Dim m As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\Letter\"
        Dim sMusic As String
        'iTick = iTick + 1
        Select Case iClickVal
            Case 0
            Case 1
                iLetMove = iSnake(1) - Val(Lbl1.Tag)
                i = iLetMove Mod 8
                LblTest.Text = "1=" & Lbl1.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
                sDir = "R"
                If i = 0 Then
                    If iLetMove > 0 Then
                        sDir = "U"
                    Else
                        sDir = "D"
                    End If
                End If
            Case 2
                iLetMove = iSnake(1) - Val(Lbl2.Tag)
                i = iLetMove Mod 8
                LblTest.Text = "1=" & Lbl1.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
                sDir = "R"
                If i = 0 Then
                    If iLetMove > 0 Then
                        sDir = "U"
                    Else
                        sDir = "D"
                    End If
                End If
            Case 3
                iLetMove = iSnake(1) - Val(Lbl3.Tag)
                i = iLetMove Mod 8
                LblTest.Text = "1=" & Lbl1.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
                sDir = "R"
                If i = 0 Then
                    If iLetMove > 0 Then
                        sDir = "U"
                    Else
                        sDir = "D"
                    End If
                End If
            Case 4
                iLetMove = iSnake(1) - Val(Lbl4.Tag)
                i = iLetMove Mod 8
                LblTest.Text = "1=" & Lbl1.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
                sDir = "R"
                If i = 0 Then
                    If iLetMove > 0 Then
                        sDir = "U"
                    Else
                        sDir = "D"
                    End If
                End If
        End Select
        Select Case sDir
            Case "R"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) + 1
                If iSnake(1) > 64 Then iSnake(1) = 1
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pRight.Image = pRight2.Image
                '
            Case "L"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) - 1
                If iSnake(1) < 1 Then iSnake(1) = iSnake(1) + 64
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pLeft.Image = pLeft2.Image
            Case "D"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) + 8
                If iSnake(1) > 64 Then iSnake(1) = iSnake(1) - 64
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pDown.Image = pDown2.Image
            Case "U"
                pAngry(iSnake(3)).Image = pGreen.Image
                iSnake(3) = iSnake(2)
                iSnake(2) = iSnake(1)
                iSnake(1) = iSnake(1) - 8
                If iSnake(1) < 0 Then iSnake(1) = iSnake(1) + 64
                pAngry(iSnake(2)).Image = pBody.Image
                pAngry(iSnake(1)).Image = pHead.Image
                pRight.Image = pRight3.Image
                pUp.Image = pUp3.Image
                pDown.Image = pDown3.Image
                pLeft.Image = pLeft3.Image
                pUp.Image = pUp2.Image
        End Select
        For i = 1 To 10
            If iSnake(1) = iWloc(i) Then
                iPick = i
                iTick = 1
                iPick1 = iSnake(1)
                If Mid(LblWord.Tag, iLet, 1) = sWord(i) Then
                    iDeltaX = Int((pAngry(iPick1).Top - LblWord.Top) / 6)
                    iDeltaY = Int((pAngry(iPick1).Left - LblWord.Left) / 6)
                    Label2.Text = iPick1 & " " & pAngry(iPick1).Top & " " & pAngry(iPick1).Left
                    TimYes.Enabled = True

                    sMusic = sWord(i)
                    i = Asc(sMusic) - 64
                    Label1.Text = i
                    sMusic = value & "Let" & i & ".wav"
                    My.Computer.Audio.Play(sMusic, AudioPlayMode.WaitToComplete)
                    m = 2
                    Exit Sub
                Else
                    m = 2
                    'iDeltaX = pAngry(iPick1).Top
                    'iDeltaY = pAngry(iPick1).Left
                    TimNo.Enabled = True
                End If
                ' TimMove.Enabled = False
            End If
        Next
        ' TimMove.Enabled = False
    End Sub
    Private Sub TimYes_Tick(sender As Object, e As EventArgs) Handles TimYes.Tick
        '
        ' Fly Letter to Answer
        '
        iTick = iTick + 1
        iClickVal = 0
        iWloc(iPick) = 0
        Select Case iPick
            Case 1
                Lbl1.Top = Lbl1.Top - iDeltaX
                Lbl1.Left = Lbl1.Left - iDeltaY
                Label1.Text = iPick1 & " " & Lbl1.Top & " " & Lbl1.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl1.Text
                    Lbl1.Visible = False
                    iLet = 2
                    TimYes.Enabled = False
                End If
            Case 2
                Lbl2.Top = Lbl2.Top - iDeltaX
                Lbl2.Left = Lbl2.Left - iDeltaY
                Label1.Text = iPick1 & " " & Lbl2.Top & " " & Lbl2.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl2.Text
                    Lbl2.Visible = False
                    iLet = 3
                    TimYes.Enabled = False
                End If
            Case 3
                Lbl3.Top = Lbl3.Top - iDeltaX
                Lbl3.Left = Lbl3.Left - iDeltaY
                Label1.Text = iPick1 & " " & Lbl3.Top & " " & Lbl3.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl3.Text
                    Lbl3.Visible = False
                    iLet = 4
                    TimYes.Enabled = False
                    If LblWord.Text = LblWord.Tag Then TimDone.Enabled = True
                End If
            Case 4
                Lbl4.Top = Lbl4.Top - iDeltaX
                Lbl4.Left = Lbl4.Left - iDeltaY
                Label1.Text = iPick1 & " " & Lbl4.Top & " " & Lbl4.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl4.Text
                    Lbl4.Visible = False
                    TimYes.Enabled = False
                    If LblWord.Text = LblWord.Tag Then TimDone.Enabled = True
                End If
        End Select
        If TimDone.Enabled Then TimMove.Enabled = False
    End Sub

    Private Sub TimNo_Tick(sender As Object, e As EventArgs) Handles TimNo.Tick
        '
        ' Fly Letter to new spot
        '
        Dim j As Integer
        Dim k As Integer
        If iTick = 1 Then
Myredo:
            j = Int(63.9 * Rnd() + 1)
            For k = 1 To 3
                If iSnake(k) = j Then GoTo Myredo
            Next
            For k = 1 To 10
                If iWloc(k) = j Then GoTo Myredo
            Next
            iWloc(iPick) = j
            Select Case iPick
                Case 1
                    iDeltaX = Int((pAngry(j).Top - Lbl1.Top) / 6)
                    iDeltaY = Int((pAngry(j).Left - Lbl1.Left) / 6)
                    Label2.Text = j & " " & pAngry(j).Top & " " & pAngry(j).Left
                Case 2
                    iDeltaX = Int((pAngry(j).Top - Lbl2.Top) / 6)
                    iDeltaY = Int((pAngry(j).Left - Lbl2.Left) / 6)
                    Label2.Text = j & " " & pAngry(j).Top & " " & pAngry(j).Left
                Case 3
                    iDeltaX = Int((pAngry(j).Top - Lbl3.Top) / 6)
                    iDeltaY = Int((pAngry(j).Left - Lbl3.Left) / 6)
                    Label2.Text = j & " " & pAngry(j).Top & " " & pAngry(j).Left
                Case 4
                    iDeltaX = Int((pAngry(j).Top - Lbl4.Top) / 6)
                    iDeltaY = Int((pAngry(j).Left - Lbl4.Left) / 6)
            End Select
        End If
        iTick = iTick + 1
        Select Case iPick
            Case 1
                Lbl1.Top = Lbl1.Top + iDeltaX
                Lbl1.Left = Lbl1.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl1.Top & " " & Lbl1.Left & " " & iTick
                If iTick = 7 Then
                    Lbl1.Top = pAngry(iWloc(iPick)).Top
                    Lbl1.Left = pAngry(iWloc(iPick)).Left
                    TimNo.Enabled = False
                    Lbl1.Tag = iWloc(iPick)
                End If
            Case 2
                Lbl2.Top = Lbl2.Top + iDeltaX
                Lbl2.Left = Lbl2.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl2.Top & " " & Lbl2.Left & " " & iTick
                If iTick = 7 Then
                    Lbl2.Top = pAngry(iWloc(iPick)).Top
                    Lbl2.Left = pAngry(iWloc(iPick)).Left
                    TimNo.Enabled = False
                    Lbl2.Tag = iWloc(iPick)
                End If
            Case 3
                Lbl3.Top = Lbl3.Top + iDeltaX
                Lbl3.Left = Lbl3.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl3.Top & " " & Lbl3.Left & " " & iTick
                If iTick = 7 Then
                    Lbl3.Top = pAngry(iWloc(iPick)).Top
                    Lbl3.Left = pAngry(iWloc(iPick)).Left
                    TimNo.Enabled = False
                    Lbl3.Tag = iWloc(iPick)
                End If
            Case 4
                Lbl4.Top = Lbl4.Top + iDeltaX
                Lbl4.Left = Lbl4.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl4.Top & " " & Lbl4.Left & " " & iTick
                If iTick = 7 Then
                    Lbl4.Top = pAngry(iWloc(iPick)).Top
                    Lbl4.Left = pAngry(iWloc(iPick)).Left
                    TimNo.Enabled = False
                    Lbl4.Tag = iWloc(iPick)
                End If
        End Select
    End Sub
    Private Sub TimDone_Tick(sender As Object, e As EventArgs) Handles TimDone.Tick
        Dim i As Integer
        Dim j As Integer
        iTick = iTick + 1
        Lbl1.Visible = False
        Lbl2.Visible = False
        Lbl3.Visible = False
        Lbl4.Visible = False
        pUp.Visible = False
        pDown.Visible = False
        pRight.Visible = False
        pLeft.Visible = False
        For i = 1 To 7
            j = Int(63.9 * Rnd() + 1)
            pAngry(j).Image = Nothing
            pAngry(j).BackColor = Choose(Int(Rnd() * 13) + 1, Color.CadetBlue, Color.Red, Color.Orange, Color.Chartreuse, Color.Cyan, Color.Sienna, Color.Yellow, Color.Pink, Color.Magenta,
                                        Color.DodgerBlue, Color.Salmon, Color.YellowGreen, Color.Purple)
        Next
        If iTick = 10 Then
            speaker.SpeakAsync(LblWord.Text) 'Talk
        End If
        If iTick = 30 Then
            TimDone.Enabled = False
            Game()
        End If
    End Sub
    Private Sub FrmSnakevb_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If TimStart.Enabled Then Exit Sub
        If TimMove.Enabled = False Then TimMove.Enabled = True
        Label3.Text = e.KeyCode
        Select Case e.KeyCode
            Case Keys.I, Keys.Up
                If sDir <> "D" Then sDir = "U"
            Case Keys.M, Keys.Down
                If sDir <> "U" Then sDir = "D"
            Case Keys.K, Keys.Right
                If sDir <> "L" Then sDir = "R"
            Case Keys.J, Keys.Left
                If sDir <> "R" Then sDir = "L"
            Case Keys.P
                TimMove.Enabled = False
            Case Keys.N
                Game()
            Case 49
                iLevel = 1
                Me.Text = "Snake Level=" & iLevel & " 3-Letter"
            Case 50
                iLevel = 2
                Me.Text = "Snake Level=" & iLevel & " 3,4-Letter"
        End Select
    End Sub
    Private Sub TimStart_Tick(sender As Object, e As EventArgs) Handles TimStart.Tick
        LblWord.Text = "???"
        If iwCnt = 4 Then LblWord.Text = "????"
        TimStart.Enabled = False
        pUp.Visible = True
        pDown.Visible = True
        pRight.Visible = True
        pLeft.Visible = True
    End Sub

    Private Sub TimPlace_Tick(sender As Object, e As EventArgs) Handles TimPlace.Tick
        '
        ' Fly Letter to spot
        '
        iTick = iTick + 1
        iWloc(iPick) = 0
        Select Case iPick
            Case 1
                Lbl1.Top = Lbl1.Top + iDeltaX
                Lbl1.Left = Lbl1.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl1.Top & " " & Lbl1.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl1.Text
                    Lbl1.Visible = False
                    iLet = 2
                    TimYes.Enabled = False
                End If
            Case 2
                Lbl2.Top = Lbl2.Top + iDeltaX
                Lbl2.Left = Lbl2.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl2.Top & " " & Lbl2.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl2.Text
                    Lbl2.Visible = False
                    iLet = 3
                    TimPlace.Enabled = False
                End If
            Case 3
                Lbl3.Top = Lbl3.Top + iDeltaX
                Lbl3.Left = Lbl3.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl3.Top & " " & Lbl3.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl3.Text
                    Lbl3.Visible = False
                    iLet = 4
                    TimPlace.Enabled = False
                End If
            Case 4
                Lbl4.Top = Lbl4.Top + iDeltaX
                Lbl4.Left = Lbl4.Left + iDeltaY
                Label1.Text = iPick1 & " " & Lbl4.Top & " " & Lbl4.Left & " " & iTick
                If iTick = 7 Then
                    Mid(LblWord.Text, iLet, 1) = Lbl4.Text
                    Lbl4.Visible = False
                    TimPlace.Enabled = False

                End If
        End Select
    End Sub

    Private Sub pUp_Click(sender As Object, e As EventArgs)
        If sDir <> "D" Then
            sDir = "U"
            TimMove.Enabled = True
            pUp.Visible = True
            pDown.Visible = False
            pRight.Visible = True
            pLeft.Visible = True
        End If
        pUp.Image = pUp2.Image
    End Sub

    Private Sub pUp_MouseEnter(sender As Object, e As EventArgs)
        pUp.Image = pUp2.Image
    End Sub

    Private Sub pUp_MouseLeave(sender As Object, e As EventArgs)
        pUp.Image = pUp3.Image
    End Sub

    Private Sub pDown_Click(sender As Object, e As EventArgs)
        If sDir <> "U" Then
            sDir = "D"
            TimMove.Enabled = True
            '  pUp.Visible = False
            pDown.Visible = True
            pRight.Visible = True
            pLeft.Visible = True
        End If
        pDown.Image = pDown2.Image
    End Sub

    Private Sub pUp_MouseClick(sender As Object, e As MouseEventArgs)
        If sDir <> "D" Then
            sDir = "U"
            TimMove.Enabled = True
            pUp.Visible = True
            '  pDown.Visible = False
            pRight.Visible = True
            pLeft.Visible = True
        End If
        pUp.Image = pUp2.Image
    End Sub

    Private Sub pDown_MouseEnter(sender As Object, e As EventArgs)
        pDown.Image = pDown2.Image
    End Sub

    Private Sub pDown_MouseLeave(sender As Object, e As EventArgs)
        pDown.Image = pDown3.Image
    End Sub

    Private Sub pDown_MouseClick(sender As Object, e As MouseEventArgs)
        If sDir <> "U" Then
            sDir = "D"
            TimMove.Enabled = True
            ' pUp.Visible = False
            pDown.Visible = True
            pRight.Visible = True
            pLeft.Visible = True
        End If
        pDown.Image = pDown2.Image
    End Sub

    Private Sub pRight_Click(sender As Object, e As EventArgs)
        If sDir <> "L" Then
            sDir = "R"
            TimMove.Enabled = True
            pUp.Visible = True
            pDown.Visible = True
            pRight.Visible = True
            ' pLeft.Visible = False
        End If
    End Sub

    Private Sub pRight_MouseEnter(sender As Object, e As EventArgs)
        pRight.Image = pRight2.Image
    End Sub

    Private Sub pRight_MouseLeave(sender As Object, e As EventArgs)
        pRight.Image = pRight3.Image
    End Sub

    Private Sub pRight_MouseClick(sender As Object, e As MouseEventArgs)
        If sDir <> "L" Then
            sDir = "R"
            TimMove.Enabled = True
            pUp.Visible = True
            pDown.Visible = True
            pRight.Visible = True
            pLeft.Visible = False
        End If
    End Sub

    Private Sub pLeft_Click(sender As Object, e As EventArgs)
        If sDir <> "R" Then
            sDir = "L"
            TimMove.Enabled = True
            pUp.Visible = True
            pDown.Visible = True
            pRight.Visible = False
            pLeft.Visible = True
        End If
    End Sub

    Private Sub pLeft_MouseClick(sender As Object, e As MouseEventArgs)
        If sDir <> "R" Then
            sDir = "L"
            TimMove.Enabled = True
            pUp.Visible = True
            pDown.Visible = True
            pRight.Visible = False
            pLeft.Visible = True
        End If
    End Sub

    Private Sub pLeft_MouseEnter(sender As Object, e As EventArgs)
        pLeft.Image = pLeft2.Image
    End Sub

    Private Sub pLeft_MouseLeave(sender As Object, e As EventArgs)
        pLeft.Image = pLeft3.Image
    End Sub

    Private Sub FrmSnakevb_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'End
    End Sub

    Private Sub Lbl1_Click(sender As Object, e As EventArgs) Handles Lbl1.Click
        'Dim i As Integer
        'iLetMove = iSnake(1) - Val(Lbl1.Tag)
        'i = iLetMove Mod 8
        'LblTest.Text = "1=" & Lbl1.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
        'sDir = "R"
        'If i = 0 Then
        '    If iLetMove > 0 Then
        '        sDir = "U"
        '    Else
        '        sDir = "D"
        '    End If
        'End If
        iClickVal = 1
        If TimDone.Enabled = False Then TimMove.Enabled = True
    End Sub

    Private Sub Lbl2_Click(sender As Object, e As EventArgs) Handles Lbl2.Click
        'Dim i As Integer
        'iLetMove = iSnake(1) - Val(Lbl2.Tag)
        'i = iLetMove Mod 8
        'LblTest.Text = "2=" & Lbl2.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
        'sDir = "R"
        'If i = 0 Then
        '    If iLetMove > 0 Then
        '        sDir = "U"
        '    Else
        '        sDir = "D"
        '    End If
        'End If
        iClickVal = 2
        If TimDone.Enabled = False Then TimMove.Enabled = True
    End Sub

    Private Sub Lbl3_Click(sender As Object, e As EventArgs) Handles Lbl3.Click
        'Dim i As Integer
        'iLetMove = iSnake(1) - Val(Lbl3.Tag)
        'i = iLetMove Mod 8
        'LblTest.Text = "3=" & Lbl3.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
        'sDir = "R"
        'If i = 0 Then
        '    If iLetMove > 0 Then
        '        sDir = "U"
        '    Else
        '        sDir = "D"
        '    End If
        'End If
        iClickVal = 3
        If TimDone.Enabled = False Then TimMove.Enabled = True
    End Sub

    Private Sub Lbl4_Click(sender As Object, e As EventArgs) Handles Lbl4.Click
        'Dim i As Integer
        'iLetMove = iSnake(1) - Val(Lbl4.Tag)
        'i = iLetMove Mod 8
        'LblTest.Text = "4=" & Lbl4.Tag & " sdir=" & sDir & " Isnake(1)" & iSnake(1) & " iLetMove=" & iLetMove & " i=" & i
        'sDir = "R"
        'If i = 0 Then
        '    If iLetMove > 0 Then
        '        sDir = "U"
        '    Else
        '        sDir = "D"
        '    End If
        'End If
        iClickVal = 4
        If TimDone.Enabled = False Then TimMove.Enabled = True
    End Sub

    Private Sub pRight3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pRight2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pLeft2_Click(sender As Object, e As EventArgs)

    End Sub
End Class