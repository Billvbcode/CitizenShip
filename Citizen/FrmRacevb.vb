Imports System.Speech
Imports System.Speech.Synthesis

Public Class FrmRacevb
    Dim PicShip(5) As PictureBox
    Dim PicMoon(5) As PictureBox
    Dim iNumPlayers As Integer
    Dim iWordOption As Integer
    Dim iPlay As Integer
    Dim iMove As Integer
    Dim iCurrentPlayer As Integer
    Dim bWin As Boolean
    Dim iWordcnt As Integer
    Dim iMaster As Integer
    Dim iLetloc As Integer
    Dim cWord As String
    Public cWordProb(5000) As String
    Public cMaster(5000, 8) As String
    Dim speaker As New SpeechSynthesizer
    Dim bShip As Boolean
    Dim iRtop As Integer

    Private Sub Myreset()
        Dim i As Integer
        For i = 1 To 4
            PicShip(i).Top = iRtop
            PicShip(i).Visible = True
            PicMoon(i).Visible = False
        Next
        iCurrentPlayer = 0
        bWin = False
        Game()
    End Sub
    Private Sub Game()
        LblPlayer.Text = "Player " & iPlay
        Dim i, j As Integer
        Dim iUse(10) As Integer
        iMove = 0
        iLetloc = 1
        iMaster = iWordcnt
        LblWord.Text = ""
        LblDisplay.Text = Space(iWordOption)
        iCurrentPlayer = iCurrentPlayer + 1
        If iCurrentPlayer > iNumPlayers Then
            iCurrentPlayer = 1
            For i = 1 To iNumPlayers
                If PicShip(i).Visible = False Then
                    bWin = True
                    Exit Sub
                End If
            Next
        End If
        Select Case iCurrentPlayer
            Case 1
                Panel3.BackColor = Color.LightBlue
            Case 2
                Panel3.BackColor = Color.LightGreen
            Case 3
                Panel3.BackColor = Color.LightYellow
            Case 4
                Panel3.BackColor = Color.Tomato
        End Select
        'If bWin And iCurrentPlayer = 1 Then
        '    Timer1.Interval = 1500
        '    Timer1.Enabled = True
        '    'cGame = "Word Race Results"
        '    'FrmWin.Show
        '    Exit Sub
        'End If
        LblPlayer.Text = "Player " & iCurrentPlayer & Chr(13) & "Guess Word"
PickWord:
        If iWordOption < 5 Then
            i = (Rnd() * iMaster) + 1
            If i = 0 Or i > iMaster Then i = iMaster
            cWord = cMaster(i, iWordOption - 2)
        Else
            i = Int((Rnd() * iWordcnt) + 1)
            If i = 0 Or i > iWordcnt Then i = iWordcnt
            cWord = cWordProb(i)
        End If
        For i = 1 To Len(cWord)
            iUse(i) = 0
        Next
        If Len(Trim(cWord)) < 1 Then GoTo PickWord
        'For Word Flash
        'If OptGame(1).Value Then
        'LblFlash = ""
        'For i = 1 To Len(cWord)
        '    LblFlash = LblFlash & "*"
        'Next
        'If OptGame(1).Value Then
        '    CmdFlash.SetFocus
        '    'Exit Sub
        'End If
        LblAnswer.Text = cWord
        '
        'Scramble word up
        j = (Rnd() * 0.9 * (Len(cWord) - 1)) + 2
        If j > Len(cWord) Then j = 2
        iUse(j) = 1
        i = 1
        LblWord.Text = ""
        LblWord.Text = Mid(cWord, j, 1)
        'CmdStart.SetFocus
NextLetter:
        i = i + 1
TryAgain:
        j = (Rnd() * (Len(cWord)) * 0.9) + 1
        If j > Len(cWord) Then GoTo TryAgain
        If iUse(j) > 0 Then GoTo TryAgain
        iUse(j) = 1
        LblWord.Text = LblWord.Text & Mid(cWord, j, 1)
        If i < Len(cWord) Then GoTo NextLetter
    End Sub
    Private Sub RFile()
        Dim value As String  'Name of file
        value = My.Application.Info.DirectoryPath & "\file\master.txt"
        Dim fStream As New System.IO.FileStream(value, IO.FileMode.Open)
        Dim sReader As New System.IO.StreamReader(fStream)
        iWordcnt = 0 ' Set Word counter to zero
        Dim sMyLine As String
        Do While sReader.Peek >= 0 'Read to the end of the file
            sMyLine = sReader.ReadLine            ' Read one Line
            iWordcnt += 1                     ' Increase Word counter
            cMaster(iWordcnt, 1) = Mid(sMyLine, 1, 3) ' 3 letter words
            cMaster(iWordcnt, 2) = Mid(sMyLine, 5, 4) ' 4 letter words
            cMaster(iWordcnt, 3) = Mid(sMyLine, 10, 5) ' 5 letter words
            cMaster(iWordcnt, 4) = Mid(sMyLine, 16, 6) ' 6 letter words

            cMaster(iWordcnt, 5) = "N" 'Not Played
            cMaster(iWordcnt, 6) = "N" 'Not Played
            cMaster(iWordcnt, 7) = "N" 'Not Played
            cMaster(iWordcnt, 8) = "N" 'Not Played
        Loop
        fStream.Close() ' Close File
        sReader.Close()  'Close Reader
        '  LblTest.Text = sWord3(iWcnt, 1) 'Last 3 letter word
    End Sub
    Private Sub FrmRacevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        PicShip(1) = PictureBox1
        PicShip(2) = PictureBox2
        PicShip(3) = PictureBox3
        PicShip(4) = PictureBox4
        PicMoon(1) = PictureBox5
        PicMoon(2) = PictureBox6
        PicMoon(3) = PictureBox7
        PicMoon(4) = PictureBox8
        iRtop = PicShip(1).Top
        iNumPlayers = 1
        iWordOption = 4
        iPlay = 1
        Label3.Text = "Number of Players(" & iNumPlayers & ")"
        Label4.Text = "WordSize(" & iWordOption & ")"
        ' Panel2.Visible = False
        '  BtnStart.Enabled = False
        '  Panel2.Enabled = False
        For i = 1 To 4
            PicShip(i).Visible = False
        Next
        For i = 1 To iNumPlayers
            PicShip(i).Visible = True
        Next
        RFile()
        Game()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 1
        Else
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 1
        End If
        Label3.Text = "Number of Players(" & iNumPlayers & ")"
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 2
        Else
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 1
        End If
        Label3.Text = "Number of Players(" & iNumPlayers & ")"
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        If CheckBox3.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 3
        Else
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 1
        End If
        Label3.Text = "Number of Players(" & iNumPlayers & ")"
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        If CheckBox4.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            iNumPlayers = 4
        Else
            CheckBox1.Checked = True
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            iNumPlayers = 1
        End If
        Label3.Text = "Number of Players(" & iNumPlayers & ")"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles CheckBox7.Click
        If CheckBox7.Checked Then
            CheckBox6.Checked = False
            CheckBox5.Checked = False
            iWordOption = 4
        Else
            CheckBox7.Checked = True
            CheckBox6.Checked = False
            CheckBox5.Checked = False
            iWordOption = 4
        End If
        Label4.Text = "WordSize(" & iWordOption & ")"
    End Sub

    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        If CheckBox6.Checked Then
            CheckBox7.Checked = False
            CheckBox5.Checked = False
            iWordOption = 5
        Else
            CheckBox7.Checked = True
            CheckBox6.Checked = False
            CheckBox5.Checked = False
            iWordOption = 4
        End If
        Label4.Text = "WordSize(" & iWordOption & ")"
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            iWordOption = 6
        Else
            CheckBox7.Checked = True
            CheckBox6.Checked = False
            CheckBox5.Checked = False
            iWordOption = 4
        End If
        Label4.Text = "WordSize(" & iWordOption & ")"
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Dim i As Integer
        Panel2.Visible = False
        BtnStart.Enabled = False
        Panel2.Enabled = False
        For i = 1 To 4
            PicShip(i).Visible = False
        Next
        For i = 1 To iNumPlayers
            PicShip(i).Visible = True
        Next
        LblWord.Visible = True
        LblDisplay.Visible = True
    End Sub

    Private Sub FrmRacevb_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim cLet, cMatch As String
        Dim sFile As String
        ' Dim sMsg As String
        ' Dim value As String = My.Application.Info.DirectoryPath & "\”
        Dim value2 As String = My.Application.Info.DirectoryPath & "\Letter\"
        Dim sMusic As String
        cLet = Chr(e.KeyCode)
        cLet = UCase(cLet)
        Dim i, j As Integer
        j = iLetloc
        If bWin Then
            bWin = False
            Myreset()
            Exit Sub
        End If
        If cLet < "A" Or cLet > "Z" Then
            'Game()
            'sFile = LblDisplay.Text
            'sMsg = cWord
            Exit Sub
        End If
        ' = Len(LblDisplay) + 1
        mid(LblDisplay.Text, j, 1) = Mid(cWord, j, 1)
        cMatch = Mid(cWord, j, 1)



        sMusic = cMatch
        i = Asc(UCase(sMusic)) - 64

        sMusic = value2 & "Let" & i & ".wav"
        My.Computer.Audio.Play(sMusic, AudioPlayMode.WaitToComplete)
        ' Else
        If LblDisplay.Text = cWord Then
            bShip = False
            iMove = 0
            If cMatch = cLet Then
                LblPlayer.Text = "Player " & iCurrentPlayer & vbCrLf & "Good Job!"
                '   cPlayerNameCount(iCurrentPlayer) = cPlayerNameCount(iCurrentPlayer) + 1
                bShip = True
                Timer1.Start()
                'TimShip.Enabled = True
                'TimShip.Interval = 1200
            Else
                LblPlayer.Text = "Player " & iCurrentPlayer & vbCrLf & "Sorry!"
                Timer1.Start()
                '  TimerWait.Enabled = True
                ' TimerWait.Interval = 2200
            End If
        End If
        iLetloc += 1
    End Sub

    Private Sub TimShip_Tick(sender As Object, e As EventArgs) Handles TimShip.Tick
        Dim sFile As String
        Dim value As String = My.Application.Info.DirectoryPath & "\File\”
        TimShip.Interval = 300
        iMove = iMove + 1
        If PicShip(iCurrentPlayer).Top > 60 Then
            If bShip Then PicShip(iCurrentPlayer).Top -= 20

            sFile = value & "rocket.WAV"
            If iMove = 1 And bShip Then My.Computer.Audio.Play(sFile, AudioPlayMode.WaitToComplete)
        Else
            PicMoon(iCurrentPlayer).Visible = True
            PicShip(iCurrentPlayer).Visible = False
        End If
        If iMove = 4 Then
            TimShip.Stop()
            Game()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If iMove = 0 Then speaker.SpeakAsync(cWord) 'Talk
        iMove += 1

        If iMove = 2 Then
            iMove = 0
            TimShip.Start()
            Timer1.Stop()

        End If
    End Sub
End Class