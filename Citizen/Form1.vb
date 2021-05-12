Public Class Form1
    Dim pAngry(800) As Label
    Dim iLoc As Integer
    Dim sDir As String
    Dim iCnt As Integer
    Dim iYoucnt As Integer
    Dim cBoggle As String
    Dim clWords As ClsWords
    Dim ColWords As Collection
    Dim ColWords4 As Collection
    Dim ColWords5 As Collection
    Dim ColWords6 As Collection
    Dim ColWords4a As Collection
    Dim ColWords5a As Collection
    Dim ColWords4b As Collection
    Dim ColWords5b As Collection
    Dim ColWords4c As Collection
    Dim ColWords5c As Collection
    Dim iTotal As Integer
    Dim IFINDWORDS As Integer
    Private cSquare(20) As String
    Public cWordsYou(4000) As String     ' Word Problems
    Public cWords(4000) As String     ' Word Problems
    Public iWords As Integer           ' Counter for word Problems
    Public cFindWords(3000) As String
    Dim iSkip As Integer
    Dim x As Date
    Dim y As Date
    Dim sDice(20) As String
    Dim iDiceUsed(20) As Integer
    Private Sub pAngry_Click(ByVal sender As Object, ByVal e As EventArgs)
        LblTest.Text = sender.name & " " & sender.tag ' Button Text        
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        sDice(1) = "DTNKUO"
        sDice(2) = "WNSDEO"
        sDice(3) = "TBYLIA"
        sDice(4) = "HESIPN"
        sDice(5) = "PULETS"
        sDice(6) = "EPACDM"
        sDice(7) = "FIHIEY"
        sDice(8) = "CESARL"
        sDice(9) = "HMSRAO"
        sDice(10) = "GINEVT"
        sDice(11) = "RLGWIU"
        sDice(12) = "KYLGEU"
        sDice(13) = "FIROBX"
        sDice(14) = "EAVEDN"
        sDice(15) = "BAIMAO"
        sDice(16) = "AACITO"
        iCnt = 0 ' PictureBox counter
        For j = 1 To 4    ' Vertical
            For i = 1 To 4 ' Horizontal
                pAngry(iCnt) = New System.Windows.Forms.Label   ' PictureBox
                With pAngry(iCnt)
                    .Name = iCnt                                  'PictureBox Name
                    '  .Image = pWood.Image   ' Wood Image
                    .Tag = "W"              'W=Wood Tag
                    .Size = New Size(60, 60)
                    .Location = New System.Drawing.Point(24 + (i - 1) * 60,
                                                         30 + (j - 1) * 60)
                    ' .SizeMode = PictureBoxSizeMode.StretchImage
                    .Text = "A"
                    .Font = New Font("Courier New", 20, FontStyle.Bold)
                    .AutoSize = True
                    ' .Font.Size = 15
                End With
                Me.Controls.Add(pAngry(iCnt)) '  This is the create the label
                AddHandler pAngry(iCnt).Click, AddressOf pAngry_Click 'Click Event
                iCnt = iCnt + 1 ' Increase PictureBox counter
            Next
        Next
        '
        ' Use scrabble letters except j q x z
        '
        cBoggle = "AAAAAAAAABBCCDDDDEEEEEEEEEEEEFFGGGHHIIIIIIKLLLLMMNNNNNN"
        cBoggle = cBoggle & "OOOOOOOOPPRRRRRRSSSSTTTTTTUUUUVVWWYY"
        cBoggle = cBoggle & "OOOOOOOOPPRRRRRRSSSSTTTTTTUUUUVVWWYY"
        cBoggle = cBoggle & "AAAAAAAAABBCCDDDDEEEEEEEEEEEEFFGGGHHIIIIIIKLLLLMMNNNNNN"
        'cBoggle = "ROSAHMCAPEMDLUWIGRYEGUKLDONNEWSAMOSJBHEISNPEHYFEIPULETSTUNKDOATIBYLDZVNAECITAAOTGVNIEASRCLEFOBIXRE"
        'cBoggle = cBoggle & "ROSAHMCAPEMDLUWIGRYEGUKLDONNEWSAMOSBHEISNPEHYFEIPULETSTUNKDOATIBYLDZVNAECITAAOTGVNIEASRCLEFOBIRE"
        ReadFileMap()
        '
        cSquare(0) = "010405"
        cSquare(1) = "0002040506"
        cSquare(2) = "0103050607"
        cSquare(3) = "020607"
        cSquare(4) = "0001050809"
        cSquare(5) = "0001020406080910"
        cSquare(6) = "0102030507091011"
        cSquare(7) = "0203061011"
        cSquare(8) = "0405091213"
        cSquare(9) = "0405060810121314"
        cSquare(10) = "0506070911131415"
        cSquare(11) = "0607101415"
        cSquare(12) = "080913"
        cSquare(13) = "0809101214"
        cSquare(14) = "0910111315"
        cSquare(15) = "101114"
    End Sub
    Private Sub ReadFileMap()
        '
        ' Read File
        '
        Dim j As Integer
        Dim j4 As Integer
        Dim j5 As Integer
        Dim j4a As Integer
        Dim j4b As Integer
        Dim j4c As Integer
        Dim j5a As Integer
        Dim je As Integer
        Dim sFileName As String
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim value As String = My.Application.Info.DirectoryPath & "\file\"
        Dim iwcnt As Long
        '  sFileName = value & "\boggle.txt" '"\words.dat"
        sFileName = value & "\boggle.txt"
        iwcnt = 0
        ColWords = New Collection
        ColWords4 = New Collection
        ColWords5 = New Collection
        ColWords6 = New Collection
        ColWords4a = New Collection
        ColWords5a = New Collection
        ColWords4b = New Collection
        ColWords5b = New Collection
        ColWords4c = New Collection
        ColWords5c = New Collection
        srFileReader = System.IO.File.OpenText(sFileName)
        '  sInputLine = srFileReader.ReadLine()
        Do While srFileReader.Peek() <> -1
            sInputLine = srFileReader.ReadLine()
            j = InStr(1, sInputLine, " ")
            j4 = InStr(1, UCase(sInputLine), "Q") '+ 1
            If j + j4 = 0 And Len(sInputLine) > 2 And Len(sInputLine) < 6 Then
                iwcnt += 1
                clWords = New ClsWords
                clWords.Name = sInputLine
                je = InStr(1, UCase(sInputLine), "E")
                If Len(sInputLine) = 3 Then ColWords.Add(clWords)
                ' If Len(sInputLine) = 4 Then ColWords4.Add(clWords)
                If Len(sInputLine) = 4 Then
                    If UCase(Mid(sInputLine, 1, 1)) < "M" Then
                        If je = 0 Then
                            ColWords4.Add(clWords)
                        Else
                            ColWords4b.Add(clWords)
                        End If
                    Else
                        If je = 0 Then
                            ColWords4a.Add(clWords)
                        Else
                            ColWords4c.Add(clWords)
                        End If
                    End If
                End If
                If Len(sInputLine) = 5 Then
                    If UCase(Mid(sInputLine, 1, 1)) < "M" Then
                        If je = 0 Then
                            ColWords5.Add(clWords)
                        Else
                            ColWords5b.Add(clWords)
                        End If
                    Else
                        If je = 0 Then
                            ColWords5a.Add(clWords)
                        Else
                            ColWords5c.Add(clWords)
                        End If
                    End If
                End If
                If Len(sInputLine) = 6 Then ColWords6.Add(clWords)
                End If

        Loop
        srFileReader.Close()
        j = ColWords.Count
        j4 = ColWords4.Count
        j5 = ColWords5.Count
        j4a = ColWords4a.Count
        j4b = ColWords4b.Count
        j4c = ColWords4c.Count
        j5a = ColWords5a.Count
        j = j + 1
        '

    End Sub
    Private Sub cmdShake()
        Dim i As Integer
        Dim iLen As Integer
        Dim ival As Integer
        Dim ival2 As Integer
        Dim ival3 As Integer
        TxtWords.Enabled = True
        List1.Items.Clear()
        ListMy.Items.Clear()
        iYoucnt = 0
        iSkip = 0
        Label3.Text = "You Found " & iYoucnt
        TxtWords.Text = ""
        TxtWords.Visible = True
        ' LblGame.Visible = False
        'Timer1.Enabled = True
        iTotal = 0
        Timer1.Interval = 600    ' 250
        Timer.Width = 500
        'List1.Visible = False
        'LblWords.Visible = False
        '  Frame1.Visible = False
        iLen = Len(cBoggle)
        ListBox1.Items.Clear()

        For i = 0 To 15
            iDiceUsed(i + 1) = 0
            pAngry(i).Text = ""
        Next
        For i = 0 To 15
Mypickdice:
            ival = Int((Rnd() * 2600)) Mod 16
            ival = ival + 1
            If iDiceUsed(ival) > 0 Then GoTo Mypickdice
            ival3 = Int((Rnd() * 2600)) Mod 16
Mypickagain:

            If pAngry(ival3).Text <> "" Then
                ival3 += 1
                If ival3 > 15 Then ival3 = 0
                GoTo Mypickagain
            End If
            '   ListBox1.Items.Add(ival3)
            ival2 = Int((Rnd() * 2600)) Mod 6
            ival2 = ival2 + 1
            pAngry(ival3).Text = Mid(sDice(ival), ival2, 1)
            If pAngry(ival3).Text = "" Then
                iDiceUsed(ival) = 999
            End If
            ListBox1.Items.Add(ival3 & " " & ival2 & " " & Mid(sDice(ival), ival2, 1))
            pAngry(ival3).BackColor = Color.Orange
            iDiceUsed(ival) = 999
        Next
        'old

        'For i = 0 To 15
        '    ival = Int((Rnd() * iLen) + 1)
        '    pAngry(i).Text = Mid(cBoggle, ival, 1)
        '    pAngry(i).BackColor = Color.Orange
        'Next
        ' Call FindWords
        List1.Visible = True
        ' Frame1.Visible = True
        TxtWords.Focus()
        Timer.Visible = True
        LblWord.Text = ""
        'CmdShow.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer.Width < 6 Then
            Timer.Visible = False
            Timer1.Enabled = False
            TxtWords.Visible = False
            Dim SecondsDifference As Integer
            y = DateTime.Now
            SecondsDifference = DateDiff(DateInterval.Second, x, y)
            'MessageBox.Show("Difference in seconds is : " & SecondsDifference.ToString())
            FindWords()
            MYCheck()
            BtnShake.Enabled = True
            y = DateTime.Now
            Exit Sub
        Else
            Timer.Width = Timer.Width - 5
        End If
    End Sub

    Private Sub BtnShake_Click(sender As Object, e As EventArgs) Handles BtnShake.Click
        Label2.Text = ""
        cmdShake()
        ' BtnShake.Enabled = False
        x = DateTime.Now
        'pAngry(0).Text = "H"
        'pAngry(1).Text = "O"
        'pAngry(2).Text = "U"
        'pAngry(3).Text = "S"
        'pAngry(7).Text = "E"
    End Sub

    Private Sub TxtWords_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtWords.KeyDown
        Dim i As Integer
        Dim bAdd As Boolean
        bAdd = True
        If e.KeyCode >= Keys.A And e.KeyCode <= Keys.Z Then
            LblWord.Text = LblWord.Text & Chr(e.KeyCode)
        End If
        If e.KeyCode = Keys.Enter Then
            If iYoucnt = 0 Then
                ListMy.Items.Add(LblWord.Text)
                iYoucnt += 1
                cWordsYou(iYoucnt) = LblWord.Text
            Else
                For i = 1 To iYoucnt
                    If LblWord.Text = cWordsYou(i) Then bAdd = False
                Next
                If bAdd Then
                    ListMy.Items.Add(LblWord.Text)
                    iYoucnt += 1
                    cWordsYou(iYoucnt) = LblWord.Text
                End If
            End If
            Label3.Text = "You Found " & iYoucnt
            LblWord.Text = ""
            TxtWords.Text = ""
        End If
    End Sub
    Private Sub MYCheck()
        Dim i As Integer
        Dim j As Integer
        Dim ixCnt As Integer
        ixCnt = 0
        ListMy.Items.Clear()
        For i = 1 To iYoucnt
            For j = 1 To iWords
                If cWordsYou(i) = cWords(j) Then
                    ixCnt += 1
                    ListMy.Items.Add(cWords(j))
                    Exit For
                End If
            Next
        Next
        Label3.Text = "You Found " & ixCnt & " of " & iWords
    End Sub
    Private Sub FindWords()
        Dim cMyTwo As String
        Dim cMyThree As String
        Dim cMyFour As String
        Dim cMyFive As String
        Dim cMyLoc2 As String
        Dim cMyLoc3 As String
        Dim cMyLoc4 As String
        Dim cMyLoc5 As String
        Dim iBlock(20) As Integer
        Dim iCnt As Integer
        Dim i As Integer
        Dim j As Integer
        Dim lNow As Integer
        Dim kNow As Integer
        Dim lNext As Integer
        Dim kNext As Integer
        Dim lFour As Integer
        Dim kFour As Integer
        Dim lFive As Integer
        Dim kFive As Integer
        Dim iVal2 As Integer
        Dim iVal3 As Integer
        Dim iVal4 As Integer
        Dim iVal5 As Integer
        'List1.Visible = True
        'LblWords.Visible = True
        iCnt = 0
        iWords = 0
        IFINDWORDS = 0
        For i = 0 To 15
            '
            ' For this block
            '
            lNow = Len(cSquare(i)) '/ 2
            For kNow = 1 To lNow Step 2
                iVal2 = Mid(cSquare(i), kNow, 2)
                '
                ' Two = This block & Next block
                '
                cMyLoc2 = Format(i, "00") & Format(iVal2, "00")
                '  cMyTwo = lblGridLetter(i).Caption & lblGridLetter(iVal2).Caption
                cMyTwo = pAngry(i).Text & pAngry(iVal2).Text
                '
                ' Call FindWordx(cMyTwo, cMyLoc2)
                '
                ' Find three letter words
                '
                lNext = Len(cSquare(iVal2))
                For kNext = 1 To lNext Step 2
                    For j = 0 To 19
                        iBlock(j) = 0
                    Next j
                    iBlock(i) = 99
                    iBlock(iVal2) = 99
                    iVal3 = Mid(cSquare(iVal2), kNext, 2)
                    If iBlock(iVal3) = 0 Then
                        iBlock(iVal3) = 99
                        cMyLoc3 = cMyLoc2 & Format(iVal3, "00")
                        cMyThree = cMyTwo & pAngry(iVal3).Text 'lblGridLetter(iVal3).Caption

                        Call FindWordx(cMyThree, cMyLoc3)
                        '
                        ' Find four letter words
                        '
                        lFour = Len(cSquare(iVal3)) '/ 2
                        For kFour = 1 To lFour Step 2
                            iVal4 = Mid(cSquare(iVal3), kFour, 2)
                            If iBlock(iVal4) = 0 Then
                                iBlock(iVal4) = 99
                                cMyLoc4 = cMyLoc3 & Format(iVal4, "00")
                                cMyFour = cMyThree & pAngry(iVal4).Text 'lblGridLetter(iVal4).Caption
                                Call FindWordx4(cMyFour, cMyLoc4)
                                iCnt = iCnt + 1
                                ' Find five letter words
                                '
                                lFive = Len(cSquare(iVal4)) '/ 2
                                For kFive = 1 To lFive Step 2
                                    iVal5 = Mid(cSquare(iVal4), kFive, 2)
                                    If iBlock(iVal5) = 0 Then
                                        iBlock(iVal5) = 99
                                        cMyLoc5 = cMyLoc4 & Format(iVal5, "00")
                                        cMyFive = cMyFour & pAngry(iVal5).Text 'lblGridLetter(iVal4).Caption
                                        Call FindWordx5(cMyFive, cMyLoc5)
                                        iCnt = iCnt + 1
                                        iBlock(iVal5) = 0
                                        'Debug.Print cMyFour
                                    End If
                                Next ' kFour
                                iBlock(iVal4) = 0
                                'Debug.Print cMyFour
                            End If
                        Next kFour
                        iBlock(iVal3) = 0
                    End If
                Next kNext
            Next kNow
        Next i
        Label2.Text = "Found " & iWords '& " " & iSkip
        'List1.Text = "Found " & iWords
        List1.Items.Clear()

        For i = 1 To iWords
            List1.Items.Add(cWords(i))
        Next
        '  TxtWords.SetFocus
    End Sub
    '
    Public Sub FindWordx5(cMyWord As String, cMyLoc As String)
        ' Dim i As Integer
        Dim j As Integer
        Dim j1 As Integer
        Dim j2 As Integer
        Dim j3 As Integer
        Dim j4 As Integer
        Dim j5 As Integer
        Dim je As Integer
        j = InStr(1, cMyWord, "A")
        j1 = InStr(1, cMyWord, "E")
        j2 = InStr(1, cMyWord, "I")
        j3 = InStr(1, cMyWord, "O")
        j4 = InStr(1, cMyWord, "U")
        j5 = InStr(1, cMyWord, "Y")
        If j + j1 + j2 + j3 + j4 + j5 = 0 Then
            iSkip += 1
        End If
        '  j = 2
        je = InStr(1, cMyWord, "E")
        If Mid(cMyWord, 1, 1) < "M" Then
            If je = 0 Then
                For Each clWords In ColWords5
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            Else
                For Each clWords In ColWords5b
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            End If

        Else
            '
            If je = 0 Then
                For Each clWords In ColWords5a
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            Else
                For Each clWords In ColWords5c
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            End If
        End If
        j = iWords

        ' j = iSkip
    End Sub
    '
    Public Sub FindWordx4(cMyWord As String, cMyLoc As String)
        ' Dim i As Integer
        Dim j As Integer
        Dim j1 As Integer
        Dim j2 As Integer
        Dim j3 As Integer
        Dim j4 As Integer
        Dim j5 As Integer
        Dim je As Integer
        j = InStr(1, cMyWord, "A")
        j1 = InStr(1, cMyWord, "E")
        j2 = InStr(1, cMyWord, "I")
        j3 = InStr(1, cMyWord, "O")
        j4 = InStr(1, cMyWord, "U")
        j5 = InStr(1, cMyWord, "Y")
        If j + j1 + j2 + j3 + j4 + j5 = 0 Then
            iSkip += 1
        End If
        '  j = 2
        je = InStr(1, cMyWord, "E")
        If Mid(cMyWord, 1, 1) < "M" Then
            If je = 0 Then
                For Each clWords In ColWords4
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            Else
                For Each clWords In ColWords4b
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            End If

        Else
            '
            If je = 0 Then
                For Each clWords In ColWords4a
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            Else
                For Each clWords In ColWords4c
                    'If (cMyWord = clWords.Name) Then
                    If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
                    If (cMyWord = UCase(clWords.Name)) Then
                        If iWords > 0 Then
                            For j = 1 To iWords
                                If cWords(j) = cMyWord Then Exit Sub
                            Next
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        Else
                            iWords = iWords + 1
                            cWords(iWords) = cMyWord
                            cFindWords(iWords) = cMyLoc
                            Exit Sub
                        End If
                    End If
                    ' End If
                Next
            End If
        End If
        j = iWords

    End Sub
    Public Sub FindWordx(cMyWord As String, cMyLoc As String)
        ' Dim i As Integer
        Dim j As Integer
        j = 2
        For Each clWords In ColWords
            'If (cMyWord = clWords.Name) Then
            If UCase(Mid(clWords.Name, 1, 2)) > Mid(cMyWord, 1, 2) Then Exit Sub
            If (cMyWord = UCase(clWords.Name)) Then
                If iWords > 0 Then
                    For j = 1 To iWords
                        If cWords(j) = cMyWord Then Exit Sub
                    Next
                    iWords = iWords + 1
                    cWords(iWords) = cMyWord
                    cFindWords(iWords) = cMyLoc
                    Exit Sub
                Else
                    iWords = iWords + 1
                    cWords(iWords) = cMyWord
                    cFindWords(iWords) = cMyLoc
                    Exit Sub
                End If
            End If
            ' End If
        Next
        j = iWords

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FindWords()
    End Sub



    Private Sub List1_Click(sender As Object, e As EventArgs) Handles List1.Click
        Dim iClick As Integer
        Dim ival As Integer
        Dim i As Integer
        Dim j As Integer
        Dim cMyWord As String
        cMyWord = List1.Text
        ' For i = 1 To 
        'iClick = List1.Items.IndexOf
        For i = 0 To 15
            pAngry(i).BackColor = Color.Orange
        Next
        For j = 1 To iWords
            If cMyWord = cWords(j) Then
                iClick = j
                Exit For
            End If
            '    i = InStr(1, List1.Text, "-")
            '    cMyWord = Trim(Left(List1.Text, i - 1))
            '    If cWords(j) = cMyWord Then iClick = j
        Next
        For i = 1 To Len(cFindWords(iClick)) Step 2
            ival = Mid(cFindWords(iClick), i, 2)
            pAngry(ival).BackColor = Color.LightBlue
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
