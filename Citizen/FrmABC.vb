Imports System.Speech
Imports System.Speech.Synthesis

Public Class FrmABC
    Dim BtnAbc(40) As Button ' Array of labels
    Dim sFolder As String
    Dim speaker As New SpeechSynthesizer
    Dim sList(30) As String
    Dim sSay As String
    Dim sKeycode As Integer
    Dim iKey As Integer
    Dim bPlay As Boolean
    Dim bFirst As Boolean
    Dim iGuess As Integer
    Dim iLet(30) As Integer
    Dim iPick As Integer
    Dim bOhNo As Boolean
    Dim bAgain As Boolean
    ' Dim bOhNo As Boolean
    'Read line by line 
    Public Sub ReadLine()
        Dim sFileName As String
        Dim icnt As Integer
        sFileName = "list.txt"
        Dim value As String = My.Application.Info.DirectoryPath & "\FILE\”
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        srFileReader = System.IO.File.OpenText(value & sFileName)
        'Read First Line
        sInputLine = srFileReader.ReadLine()
        icnt = 0
        Do Until sInputLine Is Nothing
            icnt += 1
            sList(icnt) = sInputLine
            'Read Next Lines       
            sInputLine = srFileReader.ReadLine()
        Loop
        srFileReader.Close() 'Close Reader
    End Sub
    Private Sub MyKey()
        Dim i As Integer
        Dim sFile As String
        Dim value As String = My.Application.Info.DirectoryPath & "\bmp\"
        Dim value2 As String = My.Application.Info.DirectoryPath & "\letter\"
        rText.Visible = False
        PictABC.Visible = True
        bOhNo = False
        bAgain = False
        i = iKey
        Label1.Text = iKey & " " & iPick
        If bPlay Then
            If iKey = iPick Then
                PictABC.Image = Image.FromFile(value & BtnAbc(i).Text & ".bmp")
                Panel1.Visible = False
                bAgain = True
                ' Timer3.Start()
            Else
                bOhNo = True
            End If
        Else
            PictABC.Image = Image.FromFile(value & BtnAbc(i).Text & ".bmp")
        End If
        sSay = sList(i)
        sFile = value2 & "let" & BtnAbc(i).Name & ".WAV"
        My.Computer.Audio.Play(sFile, AudioPlayMode.WaitToComplete)
        Timer1.Start()
    End Sub

    Private Sub BtnABC_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim value As String = My.Application.Info.DirectoryPath & "\bmp\"
        Dim value2 As String = My.Application.Info.DirectoryPath & "\letter\"
        'PictABC.Image = Image.FromFile(value & sender.text & ".bmp")
        iKey = Val(sender.name)
        MyKey()
    End Sub
    Private Sub GetFiles()
        Dim sMsg As String
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & “\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)

        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.*")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            sMsg = LCase(dra.Name)
            If UCase(Mid(sMsg, 1, 3)) = "BOY" Then
                sMsg = dra.Name
            End If
            If Mid(sMsg, Len(sMsg) - 4, 1) > "A" Then ListBox1.Items.Add(Mid(sMsg, 1, Len(sMsg) - 4))
        Next
        '   iMax = ListBox1.Items.Count
    End Sub
    Private Sub OhNo()
        Dim i As Integer
        Dim j As Integer
        i = 2600 * Rnd()
        j = i Mod 5 '26
        Select Case j
            Case 0
                speaker.SpeakAsync("Sorry! ")
            Case 1
                speaker.SpeakAsync("That is not it!")
            Case 2
                speaker.SpeakAsync("Try again!")
            Case 3
                speaker.SpeakAsync("No! ")
            Case 4
                speaker.SpeakAsync("I think i am going to win!")
        End Select

    End Sub
    Private Sub FrmABC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim j As Integer
        Dim Icnt As Integer
        Randomize() 'Creates seed for RND function        
        Icnt = 1 ' Button counter
        sFolder = "wmf"
        ReadLine()
        myReset()
        '
        ' Create Buttons
        '
        For j = 1 To 2    ' Vertical
            For i = 1 To 13 ' Horizontal
                BtnAbc(Icnt) = New System.Windows.Forms.Button   'Create Button
                With BtnAbc(Icnt)
                    .Name = Icnt
                    .Font = New Font("Times New Roman", 12, FontStyle.Bold)
                    'Button Name
                    .Location = New System.Drawing.Point(165 + (i - 1) * 45,
                                                         445 + (j - 1) * 45)
                    .Size = New Size(35, 35)                      'Button Size
                    .Text = Chr(64 + Icnt)                        'Button Text
                End With
                Me.Controls.Add(BtnAbc(Icnt)) '  This is the create the Button
                AddHandler BtnAbc(Icnt).Click, AddressOf BtnABC_Click 'Click Event
                Icnt += 1 ' Increase Button counter
            Next
        Next
        GetFiles()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        myReset()
        '   PictABC.Image = Image.FromFile(value & ListBox1.Text & ".wmf")
        LblTitle.Text = ListBox1.Text
        PicTitle.Image = Image.FromFile(value & ListBox1.Text & ".wmf")
        speaker.SpeakAsync(ListBox1.Text) 'Talk
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        speaker.SpeakAsync(sSay) 'Talk
        Timer1.Stop()
        If bOhNo Then
            bOhNo = False
            Timer2.Start()
        ElseIf bagain Then
            Timer3.Start()
            bAgain = False
        End If
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        MyRead()
    End Sub
    Private Sub myReset()
        rText.Visible = True
        PictABC.Visible = False
        Panel1.Visible = False
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        bPlay = False
    End Sub
    Private Sub MyRead()
        myReset()
        If rText.Text = "" Then Exit Sub
        speaker.SpeakAsync(rText.Text) 'Talk
    End Sub
    Private Sub MyKeycode()
        Dim i As Integer
        Dim sFile As String
        Dim value As String = My.Application.Info.DirectoryPath & "\bmp\"
        Dim value2 As String = My.Application.Info.DirectoryPath & "\letter\"
        If sKeycode > 64 And sKeycode < 91 Then
            iKey = sKeycode - 64
            MyKey()
        ElseIf sKeycode = 27 Then
            myread
        End If
    End Sub

    Private Sub FrmABC_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        sKeycode = e.KeyCode
        MyKeycode()
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        sKeycode = e.KeyCode
        MyKeycode()
    End Sub

    Private Sub rText_KeyDown(sender As Object, e As KeyEventArgs) Handles rText.KeyDown
        If e.KeyCode = 27 Then MyRead()
    End Sub

    Private Sub BtnGuess_Click(sender As Object, e As EventArgs) Handles BtnGuess.Click
        If BtnGuess.Text = "Stop" Then
            myReset()
            Panel1.Visible = False
            bPlay = False
            BtnGuess.Text = "Guess"
        Else
            Panel1.Visible = True
            bPlay = True
            LblTitle.Text = "Find the letter"
            Timer3.Interval = 1200
            Timer3.Start()
            BtnGuess.Text = "Stop"
        End If
    End Sub
    Private Sub MyHide()
        Dim i As Integer
        Dim j As Integer
        Dim iCnt As Integer
        Dim iErr As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\bmp\"
        Dim value2 As String = My.Application.Info.DirectoryPath & "\letter\"
        Dim sMsg As String
        Dim sFile As String
        ' sMsg = "I am  the letter "
        iErr = 0
        rText.Visible = False
        PictABC.Visible = True
        Panel1.Visible = True
        If iCnt < 28 Then iCnt = iCnt + 1
Pickagain:
        iErr = iErr + 1
        i = 2600 * Rnd()
        j = i Mod 26
        j = j + 1
        If j < 1 Or j > 26 Then GoTo Pickagain
        If iLet(j) > 0 And iErr < 499 Then
            GoTo Pickagain
        End If
        iLet(j) = 999
        'j = Text1.Text + 1
        'Text1.Text = j
        iPick = j
        bPlay = True
        PictABC.Image = Image.FromFile(value & BtnAbc(j).Text & ".bmp")
        sSay = sList(j)

        '  speaker.SpeakAsync("Find") 'Talk
        sFile = value2 & "let" & BtnAbc(j).Name & ".WAV"
        My.Computer.Audio.Play(sFile, AudioPlayMode.WaitToComplete)
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        OhNo()
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MyHide()
        Timer3.Interval = 4800
        Timer3.Stop()
    End Sub

    Private Sub BtnGuess_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnGuess.KeyDown
        sKeycode = e.KeyCode
        MyKeycode()
    End Sub
End Class