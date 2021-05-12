Imports System.Speech
Imports System.Speech.Synthesis

Public Class Form4
    Dim iLet As Integer
    Dim X(50), Y(50), pace(50), size8(50) As Integer
    Dim pStar(10) As PictureBox
    Dim icnt As Integer
    Dim mySkey As String
    Dim iLevel As Integer
    Dim iMax As Integer
    Dim speaker As New SpeechSynthesizer
    Private Sub Form_Activate()
        Dim pace1, size1, x1, y1 As Integer


        For I = 1 To 50
            x1 = Int(Me.Width * Rnd())
            y1 = Int(Me.Height * Rnd())
            pace1 = Int(500 - (Int(Rnd() * 499)))
            size1 = 16 * Rnd()
            X(I) = x1
            Y(I) = y1
            pace(I) = pace1
            size8(I) = size1
        Next
    End Sub
    Private Sub Game()
        Dim k As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        For k = 1 To 5
            pStar(k).Visible = False
        Next
        icnt = 0
        Timer5.Interval = 80
        If iLevel > 3 Then Timer5.Interval = 2280
        ' Me.Text = "Spell   Level=" & iLevel
NewWord:
        k = ListBox1.Items.Count
        k = (Int(k - 0.01) * Rnd())
        ' If k=
        'k = 80
        'iwCnt = Len(ListBox1.Items(k)) - 4
        ''
        '' Set LblWord to 3 or 4 letter word
        ''
        'If iwCnt = 4 Then
        '    If iLevel = 1 Then GoTo NewWord
        'End If
        If Len(ListBox1.Items(k)) = 3 Then
            LblWord.Tag = Mid(ListBox1.Items(k), 1, 3)
            LblWord.Text = LblWord.Tag
            Label2.Text = Mid(LblWord.Tag, 1, 3)
            iMax = 3
            If iLevel = 3 Or iLevel = 6 Then GoTo NewWord
            Lbl4.Visible = False
        Else
            LblWord.Tag = Mid(ListBox1.Items(k), 1, 4)
            LblWord.Text = LblWord.Tag
            Label2.Text = Mid(LblWord.Tag, 1, 4)
            iMax = 4
            If iLevel = 1 Or iLevel = 4 Then GoTo NewWord
        End If
        speaker.SpeakAsync(LblWord.Tag) 'Talk

        ' Load Picture
        '
        pAns.Image = Image.FromFile(value & ListBox1.Items(k) & ".wmf")
        iLet = 1
        LblWord.Visible = True
        pAns.Visible = True
        Timer7.Enabled = True
        'Lbl1.Visible = True
        'Lbl2.Visible = True
        'Lbl3.Visible = True
        'If iMax = 4 Then
        '    Lbl4.Visible = True
        '    Lbl14.Text = Mid(LblWord.Tag, 4, 1)
        'End If
        'Lbl1.Text = ""
        'Lbl2.Text = ""
        'Lbl3.Text = ""
        'Lbl4.Text = ""
        'Lbl11.Text = Mid(LblWord.Tag, 1, 1)
        'Lbl12.Text = Mid(LblWord.Tag, 2, 1)
        'Lbl13.Text = Mid(LblWord.Tag, 3, 1)
        'If iLevel < 4 Then Lbl11.Visible = True
        'Lbl12.Visible = False
        'Lbl13.Visible = False
        'Lbl14.Visible = False
        'Lbl1.BackColor = Color.Yellow
        'Lbl2.BackColor = Color.Yellow
        'Lbl3.BackColor = Color.Yellow
        'Lbl4.BackColor = Color.Yellow
        'If iLevel > 3 Then LblWord.Visible = True
        ''Timer1.Enabled = True
        'pUp2.Left = Lbl1.Left
        'pUp2.Visible = True
        'pAns.Visible = True
        'PlaynoFile()
    End Sub
    Sub PlaynoFile()
        'Dim value As String = My.Application.Info.DirectoryPath & "\Letter\"
        'Dim sMusic As String
        'Dim i As Integer
        'sMusic = Mid(LblWord.Text, iLet, 1)
        'i = Asc(sMusic) - 64
        'Label1.Text = i
        'sMusic = value & "Let" & i & ".wav"
        'My.Computer.Audio.Play(sMusic, AudioPlayMode.WaitToComplete)
        Timer5.Enabled = True
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
                sMsg = UCase(dra.Name)
                If UCase(Mid(sMsg, 1, 3)) = "BOY" Then
                    sMsg = dra.Name
                End If
                If Mid(sMsg, Len(sMsg) - 4, 1) > "A" Then ListBox1.Items.Add(Mid(sMsg, 1, Len(sMsg) - 4))
                ' ListBox1.Items.Add(UCase(dra.ToString))
            End If
        Next
        Label3.Text = ListBox1.Items.Count
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim i As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\4jpg\"
        Randomize()
        pStar(1) = PS1
        pStar(2) = PS2
        pStar(3) = PS3
        pStar(4) = PS4
        pStar(5) = PS5
        iLevel = 1
        pStar(1).Image = Image.FromFile(value & "Starr.jpg")
        pStar(2).Image = Image.FromFile(value & "Starg.jpg")
        pStar(3).Image = Image.FromFile(value & "Staro.jpg")
        pStar(4).Image = Image.FromFile(value & "Starp.jpg")
        pStar(5).Image = Image.FromFile(value & "Star.jpg")
        'For i = 1 To 5
        '    pStar(i).Visible = True
        'Next
        'Exit Sub
        GetFiles()    'List Jpg's
        Me.Text = "Spell 3-Letter  Level=" & iLevel & " 
of 6"
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Game()
        Button1.Enabled = False
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim sKey As String
        If Timer7.Enabled Then Exit Sub
        sKey = Chr(e.KeyData)
        If e.KeyData = Keys.D1 Then
            iLevel = 1
            icnt = 19
            Timer4.Enabled = True
            Me.Text = "Spell 3-Letter  Level=" & iLevel & " of 6"
            Exit Sub
        End If
        If e.KeyData = Keys.D2 Then
            iLevel = 2
            icnt = 19
            Timer4.Enabled = True
            Me.Text = "Spell 3or4-Letter  Level=" & iLevel & " of 6"
            Exit Sub
        End If
        If e.KeyData = Keys.D3 Then
            iLevel = 3
            icnt = 19
            Timer4.Enabled = True
            Me.Text = "Spell 4-Letter  Level=" & iLevel & " of 6"
            Exit Sub
        End If
        If e.KeyData = Keys.D4 Then
            iLevel = 4
            icnt = 19
            Timer4.Enabled = True
            Me.Text = "Spell 3-Letter(no Sound)  Level=" & iLevel & " of 6"
            Exit Sub
        End If

        If e.KeyData = Keys.D5 Then
            iLevel = 5
            icnt = 19
            Timer4.Enabled = True
            Me.Text = "Spell 3or4-Letter(no Sound)  Level=" & iLevel & " of 6"
            Exit Sub
        End If
        If e.KeyData = Keys.D6 Then
            iLevel = 6
            icnt = 19
            Timer4.Enabled = True
            Me.Text = "Spell 4-Letter(no Sound)  Level=" & iLevel & " of 6"
            Exit Sub
        End If
        mySkey = sKey
        If sKey = Mid(LblWord.Text, iLet, 1) Then
            Timer6.Enabled = True
            If iLet = 1 Then
                Lbl1.Text = sKey
                'iLet += 1
                'pUp2.Left = Lbl2.Left
                Lbl1.BackColor = Color.LimeGreen
                Lbl11.Visible = False
                If iLevel < 4 Then Lbl12.Visible = True
                ' PlaynoFile()
            ElseIf iLet = 2 Then
                Lbl2.Text = sKey
                'iLet += 1
                'pUp2.Left = Lbl3.Left
                Lbl2.BackColor = Color.LimeGreen
                Lbl12.Visible = False
                If iLevel < 4 Then Lbl13.Visible = True
                'PlaynoFile()
            ElseIf iLet = 3 Then
                Lbl3.Text = sKey
                'iLet += 1
                Lbl3.BackColor = Color.LimeGreen
                'pUp2.Visible = False
                'Timer4.Enabled = True
                Lbl13.Visible = False
            ElseIf iLet = 4 Then
                Lbl4.Text = sKey
                'iLet += 1
                Lbl4.BackColor = Color.LimeGreen
                'pUp2.Visible = False
                'Timer4.Enabled = True
                If iLevel < 4 Then Lbl14.Visible = False
            End If
        Else
            PlaynoFile()
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        '        For I = 1 To 50
        '            Circle(X(I), Y(I)), size(I), BackColor
        'Y(I) = Y(I) + pace(I)
        '            If Y(I) >= Form1.Height Then Y(I) = 0 : X(I) = Int(Form1.Width * Rnd())
        '            Circle(X(I), Y(I)), size(I)
        'Next
        Dim g As Graphics = Me.CreateGraphics
        ' Create pen (Color, Width)
        Dim blackPen As New Pen(Color.Black, 3)
        ' DrawLine (X1 , Y1 , X2 , Y2)
        ' g.DrawLine(blackPen, 20, 86, 300, 86) 'top
        'For I = 1 To 50
        g.DrawEllipse(blackPen, 5, 5, 8, 8) '(X(I), Y(I)), size(I), BackColor
        'Y(I) = Y(I) + pace(I)
        'If Y(I) >= Form1.Height Then Y(I) = 0 : X(I) = Int(Form1.Width * Rnd())
        'Circle(X(I), Y(I)), size(I)
        ' Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Me.BackColor = Color.AliceBlue
        Dim g As Graphics = Me.CreateGraphics
        ' Create pen (Color, Width)
        Dim blackPen As New Pen(Color.Black, 3)
        g.DrawLine(blackPen, 20, 86, 300, 86) 'top
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim gr As Graphics = Me.CreateGraphics()

        ' Create a brush representing a "backward
        ' diagonal" fill using blue lines over
        ' a blank background.
        Dim ellipse_brush As New SolidBrush(Color.Blue)

        ' Fill the ellipse.
        gr.FillEllipse(ellipse_brush, 0, 0,
            Me.ClientSize.Width,
            Me.ClientSize.Height)

        ' Make a pen representing a thick red line.
        Dim ellipse_pen As New Pen(Color.Red, 5)

        ' Draw the ellipse.
        gr.DrawEllipse(ellipse_pen, 0, 0,
            Me.ClientSize.Width,
            Me.ClientSize.Height)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim gr As Graphics = Me.CreateGraphics()

        ' Create a brush representing a "backward
        ' diagonal" fill using blue lines over
        ' a blank background.
        Dim ellipse_brush As New SolidBrush(Color.Blue)

        '' Fill the ellipse.
        gr.FillRectangle(ellipse_brush, 40, 40,
           50, 50)

        ' Make a pen representing a thick red line.
        Dim ellipse_pen As New Pen(Color.Red, 5)
        ' (x, y, Width, Height)
        ' Draw the ellipse.
        gr.DrawRectangle(ellipse_pen, 20, 20,
            50, 50)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim i As Integer
        i = Rnd() * 800
        i = Int(i Mod 5) + 1
        pStar(i).Visible = True
        If icnt = 4 Or icnt = 8 Or icnt = 12 Or icnt = 16 Then
            pStar(icnt / 4).Visible = False
            Label1.Text += " " & i
        End If
        icnt += 1
        If icnt = 18 Then
            'Timer4.Enabled = False
            For i = 1 To 4
                pStar(i).Visible = True
            Next
        End If
        If icnt = 20 Then
            pAns.Visible = False
            Lbl11.Visible = False
            Lbl12.Visible = False
            Lbl13.Visible = False
            Lbl14.Visible = False
            Lbl1.Visible = False
            Lbl2.Visible = False
            Lbl3.Visible = False
            Lbl4.Visible = False
            Timer4.Enabled = False
            pUp2.Visible = False
            ' Game()
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PlaynoFile()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim value As String = My.Application.Info.DirectoryPath & "\Letter\"
        Dim sMusic As String
        Dim i As Integer
        If iLet > iMax Then Exit Sub
        sMusic = Mid(LblWord.Text, iLet, 1)
        i = Asc(UCase(sMusic)) - 64
        Label1.Text = i
        sMusic = value & "Let" & i & ".wav"
        If iLevel < 4 Then My.Computer.Audio.Play(sMusic, AudioPlayMode.WaitToComplete)
        LblWord.Visible = False
        Timer5.Enabled = False
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If iLet = 1 Then
            Lbl1.Text = mySkey
            iLet += 1
            pUp2.Left = Lbl2.Left
            Lbl1.BackColor = Color.LimeGreen
            Lbl11.Visible = False
            If iLevel < 4 Then Lbl12.Visible = True
            PlaynoFile()
        ElseIf iLet = 2 Then
            Lbl2.Text = mySkey
            iLet += 1
            pUp2.Left = Lbl3.Left
            Lbl2.BackColor = Color.LimeGreen
            Lbl12.Visible = False
            If iLevel < 4 Then Lbl13.Visible = True
            PlaynoFile()
        ElseIf iLet = 3 Then
            Lbl3.Text = mySkey
            iLet += 1
            Lbl3.BackColor = Color.LimeGreen
            Lbl13.Visible = False
            If iMax = 3 Then
                ' Dim values As String = My.Application.Info.DirectoryPath & "\sound\"
                ' Dim Psound As String
                '  Psound = values & LblWord.Tag & ".wav"
                ' My.Computer.Audio.Play(Psound)
                speaker.SpeakAsync(LblWord.Tag) 'Talk

                Timer4.Enabled = True
                pUp2.Visible = False
            Else
                If iLevel < 4 Then Lbl14.Visible = True
                pUp2.Left = Lbl4.Left
                PlaynoFile()
            End If
        ElseIf iLet = 4 Then
            Lbl4.Text = mySkey
            iLet += 1
            Lbl4.BackColor = Color.LimeGreen
            pUp2.Visible = False
            Timer4.Enabled = True
            Lbl14.Visible = False
        End If
        Timer6.Enabled = False
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Lbl1.Visible = True
        Lbl2.Visible = True
        Lbl3.Visible = True
        If iMax = 4 Then
            Lbl4.Visible = True
            Lbl14.Text = Mid(LblWord.Tag, 4, 1)
        End If
        Lbl1.Text = ""
        Lbl2.Text = ""
        Lbl3.Text = ""
        Lbl4.Text = ""
        Lbl11.Text = Mid(LblWord.Tag, 1, 1)
        Lbl12.Text = Mid(LblWord.Tag, 2, 1)
        Lbl13.Text = Mid(LblWord.Tag, 3, 1)
        If iLevel < 4 Then Lbl11.Visible = True
        Lbl12.Visible = False
        Lbl13.Visible = False
        Lbl14.Visible = False
        Lbl1.BackColor = Color.Yellow
        Lbl2.BackColor = Color.Yellow
        Lbl3.BackColor = Color.Yellow
        Lbl4.BackColor = Color.Yellow
        If iLevel > 3 Then LblWord.Visible = True
        'Timer1.Enabled = True
        pUp2.Left = Lbl1.Left
        pUp2.Visible = True
        pAns.Visible = True
        PlaynoFile()
        LblWord.Visible = False
        Timer7.Enabled = False
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' End
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Dim values As String = My.Application.Info.DirectoryPath & "\sound\"
        'Dim Psound As String
        'Psound = values & LblWord.Tag & ".wav"
        'My.Computer.Audio.Play(Psound)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Game()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'LblWord.Visible = False
        Game()
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BackColor = Color.AliceBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Me.BackColor = Color.AliceBlue
        Dim g As Graphics = Me.CreateGraphics
        ' Create pen (Color, Width)
        Dim blackPen As New Pen(Color.Black, 3)
        ' DrawLine (X1 , Y1 , X2 , Y2)
        ' g.DrawLine(blackPen, 20, 86, 300, 86) 'top
        g.DrawRectangle(Pens.AliceBlue, 20, 20, 200, 200)
        'For I = 1 To 50
        ' g.FillEllipse(blackPen, 20, 20, 200, 200)
        'Using Brush1 As New SolidBrush(Color.Blue)
        '    g.FillEllipse(Brush1, 20, 20, 200, 200)
        'End Using
        Dim square As New Rectangle(20, 20, 200, 200)
        'Using Brush1 As New SolidBrush(Color.Blue)
        '    g.Graphics.FillRectangle(Brush1, square)
        'End Using
        Dim gr As Graphics = Me.CreateGraphics()

        ' Create a brush representing a "backward
        ' diagonal" fill using blue lines over
        ' a blank background.
        Dim ellipse_brush As New SolidBrush(Color.Blue)

        ' Fill the ellipse.
        gr.FillEllipse(ellipse_brush, 0, 0,
            Me.ClientSize.Width,
            Me.ClientSize.Height)

        ' Make a pen representing a thick red line.
        Dim ellipse_pen As New Pen(Color.Red, 5)

        ' Draw the ellipse.
        gr.DrawEllipse(ellipse_pen, 0, 0,
            Me.ClientSize.Width,
            Me.ClientSize.Height)
    End Sub
End Class