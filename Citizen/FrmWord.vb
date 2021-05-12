Imports System.Speech
Imports System.Speech.Synthesis

Public Class FrmWord
    Dim cList(50) As Label ' Array of labels
    Dim sFolder As String
    Dim iMax As Integer
    Dim iFind(8) As Integer
    Dim iPlace As Integer
    Dim ImgGame(20) As PictureBox
    Dim LblPic(20) As Label
    Dim aryListBox(40) As String
    Dim aryMain(40, 10) As String
    Dim aryTemp(40, 10) As String
    Dim sMaster As String
    Dim sSort(50) As String
    Dim sFill As String
    Dim iPush As Integer
    Dim iMyPick(50) As Integer
    Dim iGreen(50) As Integer
    Dim iLastPush As Integer
    Dim iStart As Integer
    Dim iOldTop As Integer
    Dim iDelta As Integer
    Dim iListcnt As Integer
    Dim speaker As New SpeechSynthesizer
    'Click Event
    Private Sub ImgGame_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        Dim j As Integer
        i = Val(Mid(sender.name, 11, 1)) ' Extract Picture Number
        LblClick.Text = "Click  Name=" & sender.name & "   Tag=" & sender.tag & "   #=" & i
        If UCase(sender.tag) = UCase(LblPuzzle.Text) Then
            For j = 1 To iPush
                iGreen(iMyPick(j)) = 99
                cList(iMyPick(j)).BackColor = Color.LightGreen
            Next
            speaker.SpeakAsync(LblPuzzle.Text)
            lstInputWord.Items.Remove(LblPuzzle.Text)  'Delete Item
            iPush = 0
            iStart = 0
            iDelta = 0
            LblPuzzle.Text = ""
            LblPic(i).Visible = True
        Else
            iPush = 0
            iStart = 0
            iDelta = 0
            LblPuzzle.Text = ""
            For j = 1 To 24
                cList(j).BackColor = DefaultBackColor
                If iGreen(j) > 0 Then cList(j).BackColor = Color.LightGreen
                iMyPick(j) = 0
            Next
        End If
    End Sub

    'Click Event
    Private Sub cList_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        Dim index As Integer
        i = Val(sender.name) ' Location
        index = i
        LblClick.Text = "Click  Name=" & sender.name & "   Tag=" & sender.tag
        '
        Dim j As Integer
        '  If LetPuz(Index).BackColor = LblYellow.BackColor Then Exit Sub
        LblPuzzle.BackColor = DefaultBackColor
        iPush = iPush + 1
        'If bBillsPc Then
        '  Set objtexttospeech = CreateObject("SAPI.spVoice")
        '          If UCase(LetPuz(Index).Caption) = "A" Then
        '        objtexttospeech.Speak LCase("A")
        '         Else
        '        objtexttospeech.Speak UCase(LetPuz(Index).Caption)
        '         End If
        'Else
        '    If UCase(LetPuz(Index).Caption) = "A" Then
        '        TextToSpeech1.Speak LCase("AI")
        '    Else
        '        TextToSpeech1.Speak UCase(LetPuz(Index).Caption)
        '     End If

        'End If
        speaker.SpeakAsync(cList(index).Text)
        If iPush = 1 Then iStart = index
        If iPush = 1 Then iOldTop = cList(index).Top
        iMyPick(iPush) = index
        LblPuzzle.Text = LblPuzzle.Text & cList(index).Text
        cList(index).BackColor = Color.Yellow
        Label6.Text = ""
        Label7.Text = ""
        For i = 1 To iPush
            Label7.Text = Label7.Text & " " & iMyPick(i)

        Next
        If iPush > 1 Then
            i = Math.Abs(index - iLastPush)
            If i = 1 And cList(index).Top <> iOldTop Then
                i = 99
            End If
            If iPush = 2 Then iDelta = index - iLastPush
            j = index - iLastPush
            Label6.Text = "i=" & i
            If j = iDelta And (i = 1 Or i = 5) Then
                j = 0
                'check word
                For j = 0 To lstInputWord.Items.Count - 1
                    If lstInputWord.Items(j).ToString = LblPuzzle.Text Then
                        iListcnt = j
                        '              If bBillsPc Then
                        'Set objtexttospeech = CreateObject("SAPI.spVoice")
                        '      objtexttospeech.Speak LCase(LblPuzzle.Caption)
                        ' Else
                        '                  TextToSpeech1.Speak LCase(LblPuzzle.Caption)

                        'End If
                        LblPuzzle.BackColor = Color.Yellow
                        Timer2.Start()
                        'iPush = 0
                        'iStart = 0
                        'iDelta = 0
                    End If
                Next
            Else
                For j = 1 To 24
                    cList(j).BackColor = DefaultBackColor
                    If iGreen(j) > 0 Then cList(j).BackColor = Color.LightGreen
                    iMyPick(j) = 0
                Next
                iPush = 1
                iMyPick(iPush) = index
                LblPuzzle.Text = cList(index).Text
                cList(index).BackColor = Color.Yellow
                iStart = 0
                iDelta = 0
                ' LblPuzzle.Text = ""
                'if i

            End If
        End If
        iLastPush = index
        'Label1.Text = Label1.Text & " " & iLastPush

    End Sub

    'MouseMove Event 
    Private Sub cList_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        LblMouseMove.Text = "Mousemove  Name=" & sender.name & "   Tag=" & sender.tag
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
            sMsg = dra.Name
            If UCase(Mid(sMsg, 1, 3)) = "BOY" Then
                sMsg = dra.Name
            End If
            If Mid(sMsg, Len(sMsg) - 4, 1) > "A" Then ListBox1.Items.Add(Mid(sMsg, 1, Len(sMsg) - 4))
        Next
        iMax = ListBox1.Items.Count
    End Sub

    Private Sub FrmWord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim Icnt As Integer
        Randomize()
        ImgGame(1) = PictureBox1
        ImgGame(2) = PictureBox2
        ImgGame(3) = PictureBox3
        ImgGame(4) = PictureBox4
        ImgGame(5) = PictureBox5
        sFill = "ABCDEFGHILMNOPRST"
        sSort(1) = "0102030405"
        sSort(2) = "0607080910"
        sSort(3) = "1112131415"
        sSort(4) = "1617181920"
        sSort(5) = "2122232425"
        sSort(6) = "0504030201"
        sSort(7) = "1009080706"
        sSort(8) = "1514131211"
        sSort(9) = "2019181716"
        sSort(10) = "2524232221"
        k = 11
        For i = 1 To 5
            sSort(k) = Format(i, "00")
            For j = 1 To 4
                sSort(k) = sSort(k) & Format(i + j * 5, "00")
            Next
            k += 1
            AddHandler ImgGame(i).Click, AddressOf ImgGame_Click 'Click Event
        Next
        sSort(16) = "2116110601" '"0106111621""0504030201"
        sSort(17) = "2217120702" '"0207121722""1009080706"
        sSort(18) = "2318130803"
        sSort(19) = "2419140904"
        sSort(20) = "2520151005"
        'sSort(k) = ""
        'For i = 5 To 1 Step -1
        '    j = i * 5
        '    sSort(k) = sSort(k) & Format(j, "00")
        '    k += 1
        'Next
        sFolder = "wmf"

        LblPic(1) = Label1
        LblPic(2) = Label2
        LblPic(3) = Label3
        LblPic(4) = Label4
        LblPic(5) = Label5
        Icnt = 1 ' Label counter   
        For j = 1 To 5     ' Vertical
            For i = 1 To 5 ' Horizontal
                cList(Icnt) = New System.Windows.Forms.Label    'Label
                With cList(Icnt)
                    .Name = Icnt                                 'Label Name
                    .Location = New System.Drawing.Point(14 + (i - 1) * 72,
                                                 36 + (j - 1) * 72)
                    .Text = ""
                    .Font = New Font("Times New Roman", 24, FontStyle.Bold)
                    .AutoSize = False
                    '.Tag = Chr(64 + Icnt)  'Tag=A,B,C ect
                    .Visible = True
                    ' .BackColor = Color.Bisque
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Size = New Size(60, 60)
                    .BorderStyle = BorderStyle.Fixed3D
                End With
                Me.Controls.Add(cList(Icnt))    'Create label on Form(commeted out)
                ' Me.Controls.Add(cList(Icnt)) 'Create label on Panel1
                AddHandler cList(Icnt).Click, AddressOf cList_Click 'Click Event
                AddHandler cList(Icnt).MouseMove, AddressOf cList_MouseMove 'Mouse Event
                Icnt = Icnt + 1 ' Increase Label counter
            Next
        Next
        GetFiles()
    End Sub
    Private Sub Game()
        Dim j As Integer
        Dim k As Integer
        Dim iloc As Integer
        '    Dim cMsg As String
        For j = 1 To 6
            iFind(j) = 0
        Next
        iPlace = 1
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ival As Integer
        Dim j As Integer
        Dim k As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & “\"
        '    Dim cMsg As String
        'Timer1.Interval = 3600
        Timer1.Interval = 2400
        If iPlace > 1 Then LblPic(iPlace - 1).Visible = False
        If iPlace = 6 Then
            Timer1.Stop()
            mypuz()
            Exit Sub
        End If
MyPick:
        ival = Int((Rnd() * iMax) + 1)
        If ival > iMax Then ival = iMax
        ival -= 1
        If Len(ListBox1.Items(ival).ToString) > 4 Then GoTo MyPick
        For j = 1 To 6
            If ival = iFind(j) Then GoTo MyPick
        Next
        iFind(iPlace) = ival

        ImgGame(iPlace).Image = Image.FromFile(value & ListBox1.Items(ival).ToString & ".wmf")
        ImgGame(iPlace).Tag = ListBox1.Items(ival).ToString
        ImgGame(iPlace).Visible = True
        speaker.SpeakAsync(ImgGame(iPlace).Tag)
        lstInputWord.Items.Add(UCase(ListBox1.Items(ival).ToString))

        'If bBillsPc Then
        '  Set objtexttospeech = CreateObject("SAPI.spVoice")
        '        objtexttospeech.Speak LCase(ImgGame(iplace).Tag)
        ' Else
        '        TextToSpeech1.Speak LCase(ImgGame(iplace).Tag)

        'End If
        '  TextToSpeech1.Speak LCase(ImgGame(iplace).Tag)
        LblPic(iPlace).Visible = True
        LblPic(iPlace).BackColor = Color.Yellow
        LblPic(iPlace).Text = UCase(ImgGame(iPlace).Tag)
        '    LblPic(iplace - 1).Visible = False
        '    Exit Sub
        'End If
        'LblPic(iplace - 1).Visible = False
        ' Timer1.Enabled = False
        iPlace += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cMsg As String
        Dim cALet As String
        Dim i As Integer
        Dim j As Integer
        Dim iPointer As Integer
        Dim iCount As Integer
        ' Game()
        lstInputWord.Items.Clear()
        lstInputWord.Items.Add("DIG")
        lstInputWord.Items.Add("TOP")
        lstInputWord.Items.Add("BOY")
        lstInputWord.Items.Add("MAIL")
        lstInputWord.Items.Add("MAP")
        For iCount = 1 To 5
            For iPointer = 1 To 5
                aryMain(iCount, iPointer) = "."
            Next '»For iPointer = 1 To iMaxCol
        Next
        ' Call FitWordOnGrid()
        '   Call ShowWordOnWordText()
        '  Call ShowFinishedWord()
        cMsg = TxtWord.Text
        j = 1
        For i = 1 To Len(cMsg)
            cALet = Mid(cMsg, i, 1)
            If cALet >= "A" And cALet <= "Z" Then
                cList(j).Text = cALet
                j = j + 1
            End If
            If cALet = "." Then
                cList(j).Text = cALet
                j = j + 1
            End If
        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'lstInputWord.Items.Clear()
        'lstInputWord.Items.Add("DIG")
        'lstInputWord.Items.Add("TOP")
        'lstInputWord.Items.Add("BOY")
        'lstInputWord.Items.Add("MAIL")
        'lstInputWord.Items.Add("MAP")
        'mypuz()
        iPlace = 1
        Timer1.Interval = 5
        Timer1.Start()
    End Sub
    Private Sub mypuz()
        Dim i As Integer
        Dim k As Integer
        Dim j As Integer
        Dim l As Integer
        Dim iMax As Integer
        Dim iAdd As Integer
        Dim iRow As Integer
        Dim iPick As Integer
        Dim smsg As String
        Dim smsg2 As String
        Dim bOK As Boolean
        sMaster = "........................."
        For i = 1 To 40
            iMyPick(i) = 0
        Next
        For i = 1 To 25
            cList(i).BackColor = DefaultBackColor
            iGreen(i) = 0
        Next
        iPush = 0
        iStart = 0
        iDelta = 0
        LblPuzzle.Text = ""
        k = 0
        ListBox2.Items.Clear()
        For i = 0 To 4
            If Len(lstInputWord.Items(i).ToString) > 3 Then
                k += 1
                aryListBox(k) = lstInputWord.Items(i).ToString
            End If
        Next
        For i = 0 To 4
            If Len(lstInputWord.Items(i).ToString) < 4 Then
                k += 1
                aryListBox(k) = lstInputWord.Items(i).ToString
            End If
        Next
        For i = 1 To k
            ListBox2.Items.Add(aryListBox(i))
        Next
        '
        '
        '
        'iRow = 1 ' (Int(Rnd() * 2000) Mod 20) + 1
        For i = 1 To 5
            'speaker.SpeakAsync(aryListBox(i))
            If Len(aryListBox(i)) > 3 Then
                j = (Int(Rnd() * 2000) Mod 2)
                'j = 0
                iMax = 40
                iAdd = 1
            Else
                j = (Int(Rnd() * 3000) Mod 3)
                iMax = 60
                iAdd = 2
            End If
            iRow = (Int(Rnd() * 2000) Mod 20) + 1
            If i = 1 Then
                ' iPick = Val(Mid(sSort(iRow), iAdd, 2))
                For k = 1 To Len(aryListBox(i))
                    iPick = Val(Mid(sSort(iRow), (j + k) * 2 - 1, 2))
                    Mid(sMaster, iPick, 1) = Mid(aryListBox(i), k, 1)
                Next
            Else
                '  iPick = Val(Mid(sSort(iRow), (j + k) * 2 - 1, 2))
                bOK = True
                For l = 1 To iMax
                    smsg2 = sSort(iRow)
                    smsg = sMaster
                    bOK = True
                    For k = 1 To Len(aryListBox(i))
                        iPick = Val(Mid(sSort(iRow), (j + k) * 2 - 1, 2))
                        Mid(smsg, iPick, 1) = Mid(aryListBox(i), k, 1)
                        If Mid(smsg, iPick, 1) = Mid(sMaster, iPick, 1) Or Mid(sMaster, iPick, 1) = "." Then
                        Else
                            bOK = False
                            Exit For
                        End If
                    Next
                    If bOK Then
                        sMaster = smsg
                        Exit For
                    End If
                    j += 1
                    If j > iAdd Then
                        iRow = iRow + 1
                        If iRow > 20 Then iRow = 1
                        j = 0
                    End If
                Next
            End If
        Next
        For i = 1 To 25
            cList(i).Text = Mid(sMaster, i, 1)
        Next
        MYfILL()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MYfILL()
    End Sub
    Private Sub MYfILL()
        Dim I As Integer
        Dim J As Integer
        For I = 1 To 25
            J = 1 + Int(1700 * Rnd()) Mod 17
            If cList(I).Text = "." Then cList(I).Text = Mid(sFill, J, 1)
        Next
    End Sub

    Private Sub Timer1_Disposed(sender As Object, e As EventArgs) Handles Timer1.Disposed

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        speaker.SpeakAsync(LblPuzzle.Text)
        Timer2.Stop()
    End Sub
End Class