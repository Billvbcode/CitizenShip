Imports System.Threading
Imports System.Speech
Imports System.Speech.Synthesis

Public Class FrmBook
    Dim sFolder As String
    Dim psnake(2000) As PictureBox
    Dim pLabel(2000) As Label
    Dim lSave(5) As String
    Dim lColor(5) As Integer
    Dim lTrans(5) As String
    Dim lMark(5) As Boolean
    Dim lMarkOut(5) As String
    Dim pSave(25) As String
    Dim iPcnt As Integer
    Dim iLcnt As Integer
    Dim iClick As Integer
    Dim iLClick As Integer
    Dim bRequest As Boolean
    Dim bRequestDone As Boolean
    Dim colWhere As Collection   ' Collection for all Cars
    Dim cWhere As ClsWhere        ' Class for one Car
    Dim sWav As String
    Dim colMove As Collection   ' Collection for all Cars
    Dim cMove As ClsMove        ' Class for one Car
    Dim iMcnt As Integer
    Dim iMLoc As Integer
    Dim sMove As String
    Dim iReadCnt As Integer
    Dim sBackground As String
    Dim cTxt As String
    Dim iloop As Integer
    Dim bMove As Boolean
    Dim iReq As Integer
    Dim iReset As Integer
    Dim bMyPictureAdd As Boolean
    Dim speaker As New SpeechSynthesizer

    Private Sub NewBook()
        Dim i As Integer
        colWhere = New Collection ' Initialize Collection
        cWhere = New ClsWhere        ' Initialize class
        colWhere.Add(cWhere)         'Add Car to collection
        colMove = New Collection ' Initialize Collection
        cMove = New ClsMove        ' Initialize class
        colMove.Add(cMove)         'Add Car to collection
        TxtStory.Text = ""
        iPcnt = 1
        iLcnt = 1
        iMcnt = 1
        iClick = 0
        iLClick = 0
        Timer5.Stop()
        For i = 1 To 25
            cWhere = New ClsWhere        ' Initialize class
            cWhere.Loc = i
            cWhere.MyLeft = psnake(i).Left
            cWhere.MyTop = psnake(i).Top
            cWhere.MyLock = False
            colWhere.Add(cWhere)
            psnake(i).Visible = False
            pSave(i) = "None"
            psnake(i).Enabled = False
        Next
        For i = 1 To 5
            pLabel(i).Visible = False
            pLabel(i).Text = ""
            lSave(i) = "None"
            lColor(i) = 0
            pLabel(i).BackColor = Color.Black
            pLabel(i).ForeColor = DefaultBackColor
            lTrans(i) = "T"
            lMark(i) = False
            lMarkOut(i) = lSave(i) & "....."
        Next
        BtnMove.Visible = False
        BtnHide.Visible = False
        BntShow.Visible = False
        Panel1.Visible = False
        BtnAdd.Visible = False
        BtnAdd2.Visible = False
    End Sub
    Private Sub AddMove()
        cMove = New ClsMove        ' Initialize class
        cMove.Loc = iClick
        cMove.MyTop = psnake(iClick).Top
        cMove.MyLeft = psnake(iClick).Left
        cMove.Name = sMove
        cMove.iCnt = iMcnt
        colMove.Add(cMove)         'Add Car to collection
        iMcnt += 1
    End Sub
    Private Sub MyMove()
        For Each cMove In colMove
            If cMove.iCnt = iMLoc Then
                Select Case cMove.Name
                    Case "Move"
                        psnake(cMove.Loc).Left = cMove.MyLeft
                        psnake(cMove.Loc).Top = cMove.MyTop
                    Case "Show"
                        psnake(cMove.Loc).Visible = True
                    Case "Hide"
                        psnake(cMove.Loc).Visible = False
                End Select
                Exit Sub
            End If
        Next

    End Sub
    Private Sub GetFilesWMF()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & ”\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.wmf")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub SetWhere()
        Dim i As Integer
        For i = 1 To 25
            For Each cWhere In colWhere
                If cWhere.MyLock = False And cWhere.Loc = i Then
                    cWhere.MyLeft = psnake(i).Left
                    cWhere.MyTop = psnake(i).Top
                End If
            Next
        Next
    End Sub
    Private Sub GoWhere()
        Dim i As Integer
        For i = 1 To 25
            psnake(i).Visible = False
        Next
        Timer5.Stop()

        For i = 1 To 25
            '  If psnake(i).Tag <> "None" Then psnake(i).Visible = True
            For Each cWhere In colWhere
                If cWhere.Loc = i Then
                    psnake(i).Left = cWhere.MyLeft
                    psnake(i).Top = cWhere.MyTop
                End If
            Next
        Next
        For i = 1 To 25
            If psnake(i).Tag <> "None" And psnake(i).Tag <> "G" Then psnake(i).Visible = True
        Next
        Dim valueb As String = My.Application.Info.DirectoryPath & "\Background\"
        Dim valuep As String = My.Application.Info.DirectoryPath & "\wmf\"
        pStory.Image = Image.FromFile(valueb & sBackground)
    End Sub
    Private Sub SetLock()
        For Each cWhere In colWhere
            If cWhere.Loc = iClick Then
                cWhere.MyLock = True
                Exit Sub
            End If
        Next
    End Sub
    Private Sub GetFileswav()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & ”\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.wav")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub GetFiles()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & ”\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.jpg")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub GetBooks()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & ”\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.txt")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub pSnake_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        '   Dim j As Integer
        Dim sMsg As String
        i = Val(sender.name) ' Location
        Timer5.Stop()
        Panel1.Visible = False
        Label6.Text = sender.width & " " & sender.height & " " & sender.name
        iClick = i
        Label6.Text = sender.width & " " & sender.height & " " & sender.name & " Click" & iClick
        LblHeight.Text = sender.tag & " Height"
        LblWidth.Text = sender.tag & " Width"
        If psnake(i).BorderStyle = 0 Then
            psnake(i).BorderStyle = BorderStyle.Fixed3D
            SetWhere()
            BtnMove.Visible = True
            BtnHide.Visible = True
            BntShow.Visible = True
        Else
            psnake(i).BorderStyle = BorderStyle.None
        End If
        sMsg = ""
    End Sub
    Private Sub pLabel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        '   Dim j As Integer
        Dim sMsg As String
        i = Val(sender.tag) ' Location
        Panel1.Visible = True
        Timer5.Stop()
        iLClick = i
        Label3.Text = "Labei " & iLClick
        Label2.Text = "Label " & sender.text
        CheckBox1.Checked = lMark(iLClick)
        TxtLabel.Text = sender.text
        BtnMove.Visible = False
        BtnHide.Visible = False
        BntShow.Visible = False
        If pLabel(i).BorderStyle = 0 Then
            pLabel(i).BorderStyle = BorderStyle.Fixed3D
        Else
            pLabel(i).BorderStyle = BorderStyle.None
        End If
        sMsg = ""
    End Sub
    Private Sub MYControl_RequestComplete(ByVal Request As Object)
        'Set only when the request is done
        bRequestDone = True
        'Label6.Text = iReq & " " & bRequestDone
        iReq += 1
        '   ListBox1.Items.Add(Request.GetHashCode & " " & iDone)
    End Sub
    Private Sub pSnake_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If iClick > 0 Then

        End If
    End Sub
    Private Sub FrmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sFolder = "Background"
        TxtStory.Text = ""
        iReset = 1
        Dim i As Integer
        Dim j As Integer
        Dim Icnt As Integer
        sBackground = "Stream.jpg"


        colWhere = New Collection ' Initialize Collection
        cWhere = New ClsWhere        ' Initialize class
        colWhere.Add(cWhere)         'Add Car to collection
        colMove = New Collection ' Initialize Collection
        cMove = New ClsMove        ' Initialize class
        colMove.Add(cMove)         'Add Car to collection

        iPcnt = 1
        iLcnt = 1
        iMcnt = 1
        iClick = 0
        iLClick = 0
        Icnt = 1 ' PictureBox counter
        For j = 1 To 5     ' Vertical
            For i = 1 To 5 ' Horizontal
                psnake(Icnt) = New System.Windows.Forms.PictureBox    'PictureBox
                With psnake(Icnt)
                    .Name = Icnt                                 'PictureBox Name
                    .Visible = False
                    .Tag = "None"                          'G=Green Tag
                    .Size = New Size(32, 32)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Location = New System.Drawing.Point(24 + (i - 1) * 32,
                                                         6 + (j - 1) * 32)
                End With
                pStory.Controls.Add(psnake(Icnt)) '  This is the create the label
                AddHandler psnake(Icnt).Click, AddressOf pSnake_Click 'Click Event
                AddHandler psnake(Icnt).MouseMove, AddressOf pSnake_MouseMove 'Mouse
                cWhere = New ClsWhere        ' Initialize class
                cWhere.Loc = Icnt
                cWhere.MyLeft = psnake(Icnt).Left
                cWhere.MyTop = psnake(Icnt).Top
                cWhere.MyLock = False
                colWhere.Add(cWhere)
                pSave(Icnt) = "None"
                Icnt = Icnt + 1 ' Increase PictureBox counter
            Next
        Next
        Icnt = 1 ' Label counter
        For i = 1 To 5 ' Horizontal
            pLabel(Icnt) = New System.Windows.Forms.Label   'PictureBox
            With pLabel(Icnt)
                .Name = "L" & Icnt                                 'PictureBox Name
                .Visible = False
                .Tag = Icnt
                .Text = "None" 'G=Green Tag
                .AutoSize = True
                .Font = New Font("Times New Roman", 16, FontStyle.Bold)

                .Location = New System.Drawing.Point(124 + (i - 1) * 32,
                                                         6 + (j - 1) * 32)
            End With
            pStory.Controls.Add(pLabel(Icnt)) '  This is the create the label
            AddHandler pLabel(Icnt).Click, AddressOf pLabel_Click 'Click Event
            lSave(Icnt) = "None"
            lColor(Icnt) = 0
            Icnt = Icnt + 1 ' Increase PictureBox counter
        Next
        NewBook()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        sFolder = "Background"
        Timer5.Stop()
        GetFiles()
        ListBox1.Tag = sFolder
        BtnAdd2.Visible = False
        BtnAdd.Visible = False
        Panel1.Visible = False
        BtnMove.Visible = False
        BtnHide.Visible = False
        BntShow.Visible = False
    End Sub
    Private Sub PlaySound()
        Dim value As String = My.Application.Info.DirectoryPath & "\Sounds\"
        Dim sFile As String
        If sWav = "" Then Exit Sub
        sFile = value & sWav
        My.Computer.Audio.Play(sFile, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim value As String = My.Application.Info.DirectoryPath & "\" & sFolder & "\"
        ' Dim sFile As String
        Panel1.Visible = False
        Timer5.Stop()
        If sFolder <> "Sounds" Then BtnAdd.Visible = False
        If sFolder <> "Action" Then BtnAdd2.Visible = False
        If ListBox1.Text = "" Then Exit Sub
        If sFolder = "Background" Then
            pStory.Image = Image.FromFile(value & ListBox1.Text)
            sBackground = ListBox1.Text
        End If
        If sFolder = "Books" Then
            TxtName.Text = Mid(ListBox1.Text, 1, Len(ListBox1.Text) - 4)
            readbook()
            Exit Sub
        End If
        bMyPictureAdd = False
        If sFolder = "Wmf" Then
            psnake(iPcnt).Image = Image.FromFile(value & ListBox1.Text)
            psnake(iPcnt).Tag = Mid(ListBox1.Text, 1, Len(ListBox1.Text) - 4)
            psnake(iPcnt).Parent = pStory
            psnake(iPcnt).BackColor = Color.Transparent
            psnake(iPcnt).Visible = True
            psnake(iPcnt).Enabled = True
            SetWhere()
            pSave(iPcnt) = ListBox1.Text
            '  iPcnt += 1
            BtnAddPicture.Visible = True
            bMyPictureAdd = True
        End If
        If sFolder = "Sounds" Then
            BtnAdd.Visible = True
            sWav = ListBox1.Text
            PlaySound()
        End If
        'If sFolder = "Action" Then
        '    BtnAdd2.Visible = True
        '    MyChar.Play(ListBox1.Text)
        'End If
    End Sub

    Private Sub BtnPicture_Click(sender As Object, e As EventArgs) Handles BtnPicture.Click
        BtnAdd.Visible = False
        BtnAdd2.Visible = False
        Timer5.Stop()
        sFolder = "Wmf"
        GetFilesWMF()
        ListBox1.Tag = sFolder
        Panel1.Visible = False
    End Sub

    Private Sub pStory_MouseMove(sender As Object, e As MouseEventArgs) Handles pStory.MouseMove
        If iClick > 0 Then
            If psnake(iClick).BorderStyle > 0 Then
                psnake(iClick).Top = e.Y
                psnake(iClick).Left = e.X
                Panel1.Visible = False
            End If
        End If
        If iLClick > 0 Then
            If pLabel(iLClick).BorderStyle > 0 Then
                pLabel(iLClick).Top = e.Y
                pLabel(iLClick).Left = e.X
                Panel1.Visible = True
            End If
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        If iClick > 0 Then
            psnake(iClick).Width = HScrollBar1.Value
            SetWhere()
        End If
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        If iClick > 0 Then
            psnake(iClick).Height = HScrollBar2.Value
            SetWhere()
        End If
    End Sub

    Private Sub BtnSound_Click(sender As Object, e As EventArgs) Handles BtnSound.Click
        sFolder = "Sounds"
        BtnAdd.Visible = False
        BtnAdd2.Visible = False
        Timer5.Stop()
        GetFileswav()
        ListBox1.Tag = sFolder
        BtnAdd.Visible = True
        BtnMove.Visible = False
        BtnHide.Visible = False
        BntShow.Visible = False
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If sFolder = "Sounds" Then
            If ListBox1.Text <> "" Then
                TxtStory.Text = TxtStory.Text & " [" & Mid(ListBox1.Text, 1, Len(ListBox1.Text) - 4) & "]"
            End If
            BtnAdd.Visible = False
        End If
    End Sub



    Private Sub BtnAdd2_Click(sender As Object, e As EventArgs) Handles BtnAdd2.Click
        If sFolder = "Action" Then
            If ListBox1.Text <> "" Then
                TxtStory.Text = TxtStory.Text & " {" & ListBox1.Text & "}"
            End If
        Else
            BtnAdd2.Visible = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BtnAdd.Visible = False
        BtnAdd2.Visible = False
        BtnMove.Visible = False
        BtnHide.Visible = False
        BntShow.Visible = False
        Timer5.Stop()
        If iLcnt > 4 Then Exit Sub
        sFolder = "Text"
        Panel1.Visible = True
        TxtLabel.Text = "Text"
        pLabel(iLcnt).BackColor = Color.Transparent
        pLabel(iLcnt).ForeColor = Color.Black
        pLabel(iLcnt).Visible = True
        pLabel(iLcnt).Text = "Text"
        Label2.Text = "Label " & pLabel(iLcnt).Text
        lSave(iLcnt) = "Text"
        lColor(iLcnt) = 0
        iLClick = iLcnt
        iLcnt += 1
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        If iLcnt = 0 Then Exit Sub
        'Label3.Text = HScrollBar3.Value
        Select Case HScrollBar3.Value
            Case 0
                pLabel(iLClick).ForeColor = Color.Black
            Case 1
                pLabel(iLClick).ForeColor = Color.Red '&H8080FF
            Case 2
                pLabel(iLClick).ForeColor = Color.DarkOrange
            Case 3
                pLabel(iLClick).ForeColor = Color.Yellow'(&H80FF&)
            Case 4
                pLabel(iLClick).ForeColor = Color.Lime'.(&H40C0&)
            Case 5
                pLabel(iLClick).ForeColor = Color.Green'(&HFFFF&)      '&H80C0FF
            Case 6
                pLabel(iLClick).ForeColor = Color.Aqua'(&HC0C0&)
            Case 7
                pLabel(iLClick).ForeColor = Color.Blue
            Case 8
                pLabel(iLClick).ForeColor = Color.BlueViolet
            Case 9
                pLabel(iLClick).ForeColor = Color.Fuchsia
            Case 10
                pLabel(iLClick).ForeColor = Color.Chocolate
            Case 11
                pLabel(iLClick).ForeColor = Color.White
        End Select
        lColor(iLClick) = HScrollBar3.Value
        Label1.Text = "Color " & lColor(iLClick) & "  iLClick" & iLClick
        ' abel1.Text = "Color " & lColor(iLClick) & " " &
    End Sub



    Private Sub TxtLabel_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLabel.KeyDown
        If e.KeyCode = Keys.Enter Then
            If iLClick < 1 Then Exit Sub
            pLabel(iLClick).Text = TxtLabel.Text
            lSave(iLClick) = TxtLabel.Text
            lMarkOut(iLClick) = TxtLabel.Text & "....."
        End If
    End Sub

    Private Sub BtnTrans_Click(sender As Object, e As EventArgs) Handles BtnTrans.Click
        If iLClick < 1 Then Exit Sub
        pLabel(iLClick).BackColor = Color.Transparent
        lTrans(iLClick) = "T"
    End Sub

    Private Sub BtnGray_Click(sender As Object, e As EventArgs) Handles BtnGray.Click
        If iLClick < 1 Then Exit Sub
        pLabel(iLClick).BackColor = DefaultBackColor
        lTrans(iLClick) = "F"
    End Sub

    Private Sub BtnMove_Click(sender As Object, e As EventArgs) Handles BtnMove.Click
        If iClick > 0 Then
            SetLock()
            TxtStory.Text = TxtStory.Text & " (Move" & Format(iMcnt, "000") & ")"
            sMove = "Move"
            AddMove()
        End If
    End Sub

    Private Sub BntShow_Click(sender As Object, e As EventArgs) Handles BntShow.Click
        If iClick > 0 Then
            TxtStory.Text = TxtStory.Text & " (Show" & Format(iMcnt, "000") & ")"
            sMove = "Show"
            AddMove()
        End If
    End Sub

    Private Sub BtnHide_Click(sender As Object, e As EventArgs) Handles BtnHide.Click
        If iClick > 0 Then
            TxtStory.Text = TxtStory.Text & " (Hide" & Format(iMcnt, "000") & ")"
            sMove = "Hide"
            AddMove()
        End If
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        Dim i As Integer
        GoWhere()
        For i = 1 To 5
            If lMark(i) Then
                Timer5.Start()

            End If
        Next

        Timer1.Start()
        Exit Sub
        Dim cMy As String
        Dim cTxt As String
        GoWhere()
        Thread.Sleep(3000)
        '
        cTxt = ""

        For i = 1 To Len(TxtStory.Text)
            cMy = Mid(TxtStory.Text, i, 1)
            If cMy = "[" Then
                '  If Trim(cTxt) <> "" Then Myspeak(cTxt)
                speaker.SpeakAsync(cTxt)
                cTxt = ""
            ElseIf cMy = "." Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
            ElseIf cMy = "]" Then
                sWav = cTxt & ".wav"
                PlaySound()
                cTxt = ""
            ElseIf cMy = "{" Then
                '   If Trim(cTxt) <> "" Then Myspeak(cTxt)
                cTxt = ""
            ElseIf cMy = "}" Then
                'MyChar.Play(cTxt)
                Thread.Sleep(3000)
                cTxt = ""
            ElseIf cMy = "(" Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
            ElseIf cMy = ")" Then
                iMLoc = Val(Mid(cTxt, 5, 3))
                MyMove()
                cTxt = ""
                Thread.Sleep(3000)
            Else
                cTxt = cTxt & cMy
            End If

        Next
        If cTxt <> "" Then
            speaker.SpeakAsync(cTxt)
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  GoWhere()
        iReadCnt = 1
        cTxt = ""
        Timer3.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim cMy As String
        Dim cTxt As String
        '
        cTxt = ""

        For i = 1 To Len(TxtStory.Text)
            cMy = Mid(TxtStory.Text, i, 1)
            If cMy = "[" Then
                '  If Trim(cTxt) <> "" Then Myspeak(cTxt)
                speaker.SpeakAsync(cTxt)
                cTxt = ""
            ElseIf cMy = "." Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
            ElseIf cMy = "]" Then
                sWav = cTxt & ".wav"
                PlaySound()
                cTxt = ""
            ElseIf cMy = "{" Then
                '   If Trim(cTxt) <> "" Then Myspeak(cTxt)
                cTxt = ""
            ElseIf cMy = "}" Then
                'MyChar.Play(cTxt)
                '  Thread.Sleep(3000)
                cTxt = ""
            ElseIf cMy = "(" Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
            ElseIf cMy = ")" Then
                iMLoc = Val(Mid(cTxt, 5, 3))
                MyMove()
                cTxt = ""
                '
                'Thread.Sleep(3000)
            Else
                cTxt = cTxt & cMy
            End If

        Next
        If cTxt <> "" Then
            speaker.SpeakAsync(cTxt)
        End If
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim cMy As String
        '   Dim cTxt As String
        Dim i As Integer
        Dim j As Integer
        j = iReadCnt
        bRequestDone = False
        iloop = 0
        bMove = False
        '
        '  cTxt = ""

        For i = j To Len(TxtStory.Text)
            'bRequestDone(i) = False
            cMy = Mid(TxtStory.Text, i, 1)
            iReadCnt = i + 1
            If cMy = "[" Then
                '  If Trim(cTxt) <> "" Then Myspeak(cTxt)
                speaker.SpeakAsync(cTxt)
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
                Exit Sub
            ElseIf cMy = "." Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
                Exit Sub
            ElseIf cMy = "]" Then
                sWav = cTxt & ".wav"
                PlaySound()
                bMove = True
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
                Exit Sub
            ElseIf cMy = "{" Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
                Exit Sub
            ElseIf cMy = "}" Then
                '  Request = MyChar.Play(cTxt)
                '  Thread.Sleep(3000)
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
            ElseIf cMy = "(" Then
                speaker.SpeakAsync(cTxt)
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
                Exit Sub
            ElseIf cMy = ")" Then
                iMLoc = Val(Mid(cTxt, 5, 3))
                MyMove()
                cTxt = ""
                Timer3.Stop()
                Timer4.Start()
                bMove = True
                Exit Sub
            Else
                cTxt = cTxt & cMy
            End If
        Next
        If cTxt <> "" Then
            speaker.SpeakAsync(cTxt)
            iReadCnt += 5
        End If
        Timer3.Stop()
        Timer5.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'Label5.Text = iloop & " " & bRequestDone
        ' If bRequestDone Then
        Timer4.Stop()
        If iReadCnt < Len(TxtStory.Text) Then
            Timer3.Start()
        End If
        '  End If
        If bMove And iloop = 6 Then
            Timer4.Stop()
            If iReadCnt < Len(TxtStory.Text) Then
                Timer3.Start()
            End If
        End If
        iloop += 1
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim sFileName As String
        Dim sMsg As String
        Dim value As String = My.Application.Info.DirectoryPath & "\books\"
        If TxtName.Text = "" Then
            TxtName.Focus()
            Exit Sub
        End If
        sFileName = value & TxtName.Text & ".txt" 'File Name
        Dim srFileWrite As New System.IO.StreamWriter(sFileName) 'Open File
        Dim sMap As String ' Save Map Information
        Dim i As Integer
        GoWhere()
        srFileWrite.WriteLine(sBackground)
        For i = 1 To 25 ' For all 25 PictureBoxes
            sMap = Format(psnake(i).Top, "000") & Format(psnake(i).Left, "000") & pSave(i) ' psnake(i).Tag ' Create Map String
            srFileWrite.WriteLine(sMap)
            sMap = Format(psnake(i).Width, "000") & Format(psnake(i).Height, "000")
            srFileWrite.WriteLine(sMap)
        Next
        For i = 1 To 5 ' For all 5 labels
            sMsg = "F"
            If lMark(i) Then sMsg = "T"
            sMap = Format(pLabel(i).Top, "000") & Format(pLabel(i).Left, "000") & Format(lColor(i), "00") & lTrans(i) & sMsg & lSave(i) ' psnake(i).Tag ' Create Map String
            srFileWrite.WriteLine(sMap)
        Next
        sMap = Format(colWhere.Count, "000")
        srFileWrite.WriteLine(sMap)
        For Each cWhere In colWhere
            sMap = Format(cWhere.MyTop, "000") & Format(cWhere.MyLeft, "000") & Format(cWhere.Loc, "00") & cWhere.MyLock
            srFileWrite.WriteLine(sMap)
        Next
        sMap = Format(colMove.Count, "000")
        srFileWrite.WriteLine(sMap)
        For Each cMove In colMove
            sMap = Format(cMove.MyTop, "000") & Format(cMove.MyLeft, "000") & Format(cMove.Loc, "00") & Format(cMove.iCnt, "00") _
            & cMove.Name
            srFileWrite.WriteLine(sMap)
        Next
        srFileWrite.WriteLine(TxtStory.Text)
        srFileWrite.Close()         'Close File
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        sFolder = "Books"
        GetBooks()
        ' readbook()
    End Sub
    Public Sub readbook()
        Dim i As Integer
        Dim iw As Integer
        Dim im As Integer
        Dim sFileName As String
        Dim sMsg As String
        sFileName = TxtName.Text & ".txt"
        Dim value As String = My.Application.Info.DirectoryPath & "\books\"
        Dim valueb As String = My.Application.Info.DirectoryPath & "\Background\"
        Dim valuep As String = My.Application.Info.DirectoryPath & "\wmf\"
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        i = 1
        iw = 0
        im = 0
        NewBook()
        srFileReader = System.IO.File.OpenText(value & sFileName)
        'Read First Line
        sInputLine = srFileReader.ReadLine()
        Do Until sInputLine Is Nothing
            If i = 1 Then
                'Backgroung
                pStory.Image = Image.FromFile(valueb & sInputLine)
                sBackground = sInputLine
            ElseIf i > 1 And i < 27 Then
                'Pictures
                pSave(i - 1) = Mid(sInputLine, 7, Len(sInputLine) - 6)
                If pSave(i - 1) <> "None" Then
                    psnake(i - 1).Image = Image.FromFile(valuep & pSave(i - 1))
                    psnake(i - 1).Tag = Mid(pSave(i - 1), 1, Len(pSave(i - 1)) - 4)
                    psnake(i - 1).Visible = True
                    psnake(i - 1).Parent = pStory
                    psnake(i - 1).BackColor = Color.Transparent
                    psnake(i - 1).Enabled = True
                    iPcnt = i
                End If
                psnake(i - 1).Tag = pSave(i - 1)
                psnake(i - 1).Top = Mid(sInputLine, 1, 3)
                psnake(i - 1).Left = Mid(sInputLine, 4, 3)
                sInputLine = srFileReader.ReadLine()
                psnake(i - 1).Width = Mid(sInputLine, 1, 3)
                psnake(i - 1).Height = Mid(sInputLine, 4, 3)
            ElseIf i > 26 And i < 32 Then ' 31
                'LABELS
                pLabel(i - 26).Top = Mid(sInputLine, 1, 3)
                pLabel(i - 26).Left = Mid(sInputLine, 4, 3)
                lColor(i - 26) = Mid(sInputLine, 7, 2)
                lTrans(i - 26) = Mid(sInputLine, 9, 1)
                sMsg = Mid(sInputLine, 10, 1)
                lMark(i - 26) = False
                If sMsg = "T" Then lMark(i - 26) = True
                lSave(i - 26) = Mid(sInputLine, 11, Len(sInputLine) - 10)
                If lSave(i - 26) <> "None" Then
                    pLabel(i - 26).Visible = True
                    pLabel(i - 26).Parent = pStory
                    pLabel(i - 26).BackColor = Color.Transparent
                    If lTrans(i - 26) = "F" Then pLabel(i - 26).BackColor = DefaultBackColor
                    pLabel(i - 26).Text = lSave(i - 26)
                    iLcnt = i - 25
                End If
                lMarkOut(i - 26) = lSave(i - 26) & "....."
                Select Case lColor(i - 26)
                    Case 0
                        pLabel(i - 26).ForeColor = Color.Black
                    Case 1
                        pLabel(i - 26).ForeColor = Color.Red '&H8080FF
                    Case 2
                        pLabel(i - 26).ForeColor = Color.DarkOrange
                    Case 3
                        pLabel(i - 26).ForeColor = Color.Yellow'(&H80FF&)
                    Case 4
                        pLabel(i - 26).ForeColor = Color.Lime'.(&H40C0&)
                    Case 5
                        pLabel(i - 26).ForeColor = Color.Green'(&HFFFF&)      '&H80C0FF
                    Case 6
                        pLabel(i - 26).ForeColor = Color.Aqua'(&HC0C0&)
                    Case 7
                        pLabel(i - 26).ForeColor = Color.Blue
                    Case 8
                        pLabel(i - 26).ForeColor = Color.BlueViolet
                    Case 9
                        pLabel(i - 26).ForeColor = Color.Fuchsia
                    Case 10
                        pLabel(i - 26).ForeColor = Color.Chocolate
                    Case 11
                        pLabel(i - 26).ForeColor = Color.White
                End Select
            ElseIf i = 32 Then
                colWhere = New Collection ' Initialize Collection
                colMove = New Collection ' Initialize Collection
                iw = Val(sInputLine)
            ElseIf i > 32 And iw > 0 Then
                sMsg = sInputLine
                cWhere = New ClsWhere        ' Initialize class
                'Format(cWhere.MyTop, "000") & Format(cWhere.MyLeft, "000") & Format(cWhere.Loc, "00") & cWhere.MyLock
                cWhere.MyTop = Mid(sInputLine, 1, 3)
                cWhere.MyLeft = Mid(sInputLine, 4, 3)
                cWhere.Loc = Mid(sInputLine, 7, 2)
                cWhere.MyLock = False
                If Mid(sInputLine, 9, 1) = "T" Then
                    cWhere.MyLock = True
                End If
                colWhere.Add(cWhere)
                iw -= 1
                If iw = 0 Then iw = -5
            ElseIf i > 32 And iw < 0 And im = 0 Then
                im = Val(sInputLine)
                sMsg = sInputLine
            ElseIf i > 32 And iw < 0 And im > 0 Then
                cMove = New ClsMove        ' Initialize class
                cMove.MyTop = Mid(sInputLine, 1, 3)
                cMove.MyLeft = Mid(sInputLine, 4, 3)
                cMove.Loc = Mid(sInputLine, 7, 2)
                cMove.iCnt = Mid(sInputLine, 9, 2)
                cMove.Name = Mid(sInputLine, 11, Len(sInputLine) - 10)
                ' sMap = Format(cMove.MyTop, "000") & Format(cMove.MyLeft, "000") & Format(cMove.Loc, "00") & Format(cMove.iCnt, "00") _
                ' & cMove.Name
                colMove.Add(cMove)
                iMcnt = cMove.iCnt + 1
                im -= 1
                If im = 0 Then im = -5
            ElseIf i > 32 And iw < 0 And im < 0 Then
                TxtStory.Text = sInputLine
            End If
            sInputLine = srFileReader.ReadLine()
            i += 1
        Loop
        'Label7.Text = psnake(1).Width
        '  SetWhere()
        srFileReader.Close() 'Close Reader
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        NewBook()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        GoWhere()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        lMark(iLClick) = CheckBox1.Checked
        If lMark(iLClick) = False Then
            pLabel(iLClick).Text = lSave(iLClick)
        End If
    End Sub



    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim i As Integer
        Dim sMsg As String
        For i = 1 To 5
            If lMark(i) Then
                'Marquee     Move Text Left = All but First & First
                sMsg = Mid(lMarkOut(i), 2, Len(lMarkOut(i)) - 1)
                sMsg = sMsg & Mid(lMarkOut(i), 1, 1)
                pLabel(i).Text = Mid(sMsg, 1, Len(lSave(i)))
                lMarkOut(i) = sMsg
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 1 To 5
            If lMark(i) Then
                Timer5.Start()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub FrmBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'MyChar.Hide()
    End Sub

    Private Sub BtnAddPicture_Click(sender As Object, e As EventArgs) Handles BtnAddPicture.Click
        bMyPictureAdd = False
        BtnAddPicture.Visible = False
        Panel1.Visible = False
        Label6.Text = psnake(iPcnt).Width & " " & psnake(iPcnt).Height & " " & psnake(iPcnt).Name
        iClick = iPcnt
        Label6.Text = psnake(iPcnt).Width & " " & psnake(iPcnt).Height & " " & psnake(iPcnt).Name & " Click" & iClick
        LblHeight.Text = psnake(iPcnt).Tag & " Height"
        LblWidth.Text = psnake(iPcnt).Tag & " Width"
        psnake(iPcnt).BorderStyle = BorderStyle.Fixed3D
        SetWhere()
        BtnMove.Visible = True
        BtnHide.Visible = True
        BntShow.Visible = True
        If iPcnt < 25 Then iPcnt += 1
    End Sub
End Class