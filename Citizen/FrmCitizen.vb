Imports System.Speech
Imports System.Speech.Synthesis
Public Class FrmCitizen
    Dim iCnt As Integer
    Dim iCnt2 As Integer
    Dim bCur As Boolean
    Dim MyStr2 As String
    Dim MyStr3 As String
    Dim MyString As String
    Dim txtfile(20) As RichTextBox ' Array of labels
    Dim speaker As New SpeechSynthesizer
    Dim aList(20) As Label ' Array of labels
    Dim iClick As Integer
    Dim bRead As Boolean
    Dim iRcnt As Integer
    Dim iQmax As Integer
    Dim iAns As Integer
    Public Sub ReadLine()
        Dim sFileName As String
        Dim k As Integer
        sFileName = "usaq.txt"
        Dim value As String = My.Application.Info.DirectoryPath & "\File\”
        Dim srFileReader As System.IO.StreamReader

        srFileReader = System.IO.File.OpenText(value & sFileName)
        iCnt = 0
        iCnt2 = 0
        'Read First Line
        MyString = srFileReader.ReadLine()
        Do Until MyString Is Nothing
            MyString = MyString & " "
            MyStr2 = Mid(MyString, 1, 1)
            If MyStr2 = "Q" Then
                If iCnt > 0 Then
                    clsQues.QCnt = iCnt
                    cQues.Add(clsQues)
                    'Exit Sub
                End If
                clsQues = New ClsQuestion
                clsQues.Clear()
                clsQues.YorN = "Y"
                k = InStr(1, MyString, " ")
                MyStr3 = Mid(MyString, k + 1, Len(MyString) - k)
                clsQues.Question = MyStr3
                iCnt = 0
                iCnt2 = 0
            ElseIf MyStr2 = "*" Then
                iCnt2 = iCnt2 + 1
                clsQues.YorN = "N"
                clsQues.SaveMap2(iCnt2) = MyString
            Else
                iCnt = iCnt + 1
                clsQues.SaveMap(iCnt) = MyString
            End If
            ' clsQues = New ClsQuestion
            ' clsQues.Clear

            '  End If
            MyString = srFileReader.ReadLine()
        Loop
        clsQues.QCnt = iCnt
        cQues.Add(clsQues)

        srFileReader.Close() 'Close Reader
        iQuizcnt = cQues.Count
    End Sub
    Public Sub Init()

        Q = 0
        Score = 0
        Questions = 0
        Search = 0
        Label7.Text = "1:"
        Label8.Text = "2:"
        Label9.Text = "3:"
        Label10.Text = "4:"
        'LblScore.Text = Score & " of  " & Questions
        LblScore.Text = " Score = " & Score & " out of  " & Questions
    End Sub
    Private Sub BtnQuestion_Click(sender As Object, e As EventArgs) Handles BtnQuestion.Click
        BtnQuiz.Visible = True
        Timer1.Stop()
        Timer2.Stop()
        Panel1.Visible = False
        LblQ.Visible = True
        Listsq()
    End Sub

    Private Sub BtnQuiz_Click(sender As Object, e As EventArgs) Handles BtnQuiz.Click
        ' Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.ARROW_RL))
        'Me.Cursor = 
        BtnQuiz.Visible = False
        iQmax += 1
        If iQmax > 6 Then
            For Each clsQues In cQues
                clsQues.YorN = "N"
            Next
            iQmax = 0
        End If
        bRead = False
        Panel1.Visible = True
        LblQ.Visible = False
        Init()
        Quiz()
    End Sub
    Private Sub Listsq()
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim icnt As Integer
        '  i = Val(LblTalk.Caption)

        For k = 1 To 4
            txtfile(k).BackColor = Color.White
            i = Val(Label1.Text)
            icnt = 1
            For Each clsQues In cQues
                If icnt = i Then
                    txtfile(k).Text = clsQues.Question & vbCrLf & vbCrLf
                    j = clsQues.QCnt
                    For j = 1 To clsQues.QCnt
                        txtfile(k).Text = txtfile(k).Text & clsQues.SaveMap(j) & vbCrLf
                    Next
                    Exit For
                End If
                icnt = icnt + 1
            Next
            i = i + 1
            If i > 80 Then
                j = i
            End If
            If i > 85 Then
                i = 1
            End If
            Label1.Text = i
            'if i
        Next
    End Sub
    Private Sub Quiz()
        Dim i As Integer
        Dim ival As Integer
        Dim ival2 As Integer
        Dim j As Integer
        Dim L As Integer
        Dim icnt As Integer
        Dim icnt2 As Integer
        ' 'Call ReadQuiz(cQuizfile)
        ' If iMax > iQuizcnt Then iMax = iQuizcnt
        ' Panel1.Enabled = False
        icnt = 1
        icnt2 = 1
        iRcnt = 0
        j = 0
        'ListBox1.Items.Clear()
        For i = 1 To 8
            aList(i).BackColor = DefaultBackColor
        Next
PickQuestion:
        icnt2 = 1
        ival = Int((Rnd() * iQuizcnt) + 1)
        ' ival = 80
        If ival > iQuizcnt Then ival = 1
        For Each clsQues In cQues
            If icnt2 = ival Then
                cQuiz(0) = clsQues.Question
                If clsQues.YorN = "Y" Then GoTo PickQuestion
                clsQues.YorN = "Y"
                ival2 = 1
                If clsQues.QCnt > 1 Then ival2 = Int(1 + (400 * Rnd()) Mod clsQues.QCnt)
                cQuiz(1) = "Y" & clsQues.SaveMap(ival2)
                cQuiz(2) = Replace(clsQues.SaveMap2(1), "*", "n")
                cQuiz(3) = Replace(clsQues.SaveMap2(2), "*", "n")
                cQuiz(4) = Replace(clsQues.SaveMap2(3), "*", "n")
                j = 99
                Exit For
            End If
            icnt2 = icnt2 + 1

        Next
        If j = 0 Then
            'ListBox1.Items.Add(j & " " & ival)
            j = ival
            Exit Sub
        End If
        'j = Len(cQuiz(ival, 0))
        LblQuestions.Text = cQuiz(0)
        Ans(1) = Int(Rnd() * 4 + 1)
        Do
            Ans(2) = Int(Rnd() * 4 + 1)
        Loop Until Ans(2) <> Ans(1)

        Do
            Ans(3) = Int(Rnd() * 4 + 1)
        Loop Until Ans(3) <> Ans(1) And Ans(3) <> Ans(2)
        For i = 1 To 4
            Ans(4) = i
            If i <> Ans(1) And i <> Ans(2) And i <> Ans(3) Then Exit For
        Next
        'ListBox1.Items.Add(Ans(1) & " " & Ans(2) & " " & Ans(3) & " " & Ans(4))
        L = Len(cQuiz(Ans(1)))
        LblAnswer1.Text = Mid(cQuiz(Ans(1)), 2, L - 1)
        LblAnswer1.Tag = Mid(cQuiz(Ans(1)), 1, 1)
        L = Len(cQuiz(Ans(2)))
        LblAnswer2.Text = Mid(cQuiz(Ans(2)), 2, L - 1)
        LblAnswer2.Tag = Mid(cQuiz(Ans(2)), 1, 1)
        L = Len(cQuiz(Ans(3)))
        LblAnswer3.Text = Mid(cQuiz(Ans(3)), 2, L - 1)
        LblAnswer3.Tag = Mid(cQuiz(Ans(3)), 1, 1)
        L = Len(cQuiz(Ans(4)))
        lblAnswer4.Text = Mid(cQuiz(Ans(4)), 2, L - 1)
        lblAnswer4.Tag = Mid(cQuiz(Ans(4)), 1, 1)
        iRcnt = 0
        Timer2.Start()
    End Sub
    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        Dim k As Integer

        '  i = Val(LblTalk.Caption)

        For k = 1 To 4
            txtfile(k).BackColor = Color.White
        Next
        RichTextBox1.BackColor = Color.LightGreen

        speaker.SpeakAsync(RichTextBox1.Text) 'Talk
    End Sub

    Private Sub RichTextBox2_Click(sender As Object, e As EventArgs) Handles RichTextBox2.Click
        Dim k As Integer

        '  i = Val(LblTalk.Caption)

        For k = 1 To 4
            txtfile(k).BackColor = Color.White
        Next
        RichTextBox2.BackColor = Color.LightGreen
        speaker.SpeakAsync(RichTextBox2.Text) 'Talk

    End Sub

    Private Sub RichTextBox3_Click(sender As Object, e As EventArgs) Handles RichTextBox3.Click
        Dim k As Integer

        '  i = Val(LblTalk.Caption)

        For k = 1 To 4
            txtfile(k).BackColor = Color.White
        Next
        RichTextBox3.BackColor = Color.LightGreen
        speaker.SpeakAsync(RichTextBox3.Text) 'Talk

    End Sub

    Private Sub RichTextBox4_Click(sender As Object, e As EventArgs) Handles RichTextBox4.Click
        Dim k As Integer

        '  i = Val(LblTalk.Caption)

        For k = 1 To 4
            txtfile(k).BackColor = Color.White
        Next
        RichTextBox4.BackColor = Color.LightGreen
        speaker.SpeakAsync(RichTextBox4.Text) 'Talk

    End Sub
    '
    Private Sub sClick()
        Dim i As Integer
        Timer1.Stop()
        Timer2.Stop()
        Questions += 1
        If aList(iClick).Tag = "Y" Then
            Score += 1
            aList(iClick).BackColor = Color.LightGreen
            aList(iClick + 4).BackColor = Color.LightGreen
            iAns = iClick
        Else
            aList(iClick).BackColor = Color.Tomato
            aList(iClick + 4).BackColor = Color.Tomato
            For i = 1 To 4
                If aList(i).Tag = "Y" Then
                    aList(i).BackColor = Color.LightGreen
                    aList(i + 4).BackColor = Color.LightGreen
                    iAns = i
                    Exit For
                End If
            Next
        End If
        LblScore.Text = " Score = " & Score & " out of  " & Questions
        speaker.SpeakAsync(LblQuestions.Text) 'Talk

        If iAns = 1 Then speaker.SpeakAsync("One") 'Talk
        If iAns = 2 Then speaker.SpeakAsync("Two") 'Talk
        If iAns = 3 Then speaker.SpeakAsync("Three") 'Talk
        If iAns = 4 Then speaker.SpeakAsync("Four") 'Talk
        speaker.SpeakAsync(aList(iAns).Text) 'Talk


        Timer1.Start()
    End Sub
    '
    Private Sub FrmCitizen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i
        Randomize()
        aList(1) = LblAnswer1
        aList(2) = LblAnswer2
        aList(3) = LblAnswer3
        aList(4) = lblAnswer4
        aList(5) = Label7
        aList(6) = Label8
        aList(7) = Label9
        aList(8) = Label10
        i = Int(8000 * Rnd() Mod 8)
        i = i * 10 + 1
        Label1.Text = i
        cQues = New Collection ' Initialize Collection
        txtfile(1) = RichTextBox1
        txtfile(2) = RichTextBox2
        txtfile(3) = RichTextBox3
        txtfile(4) = RichTextBox4
        ReadLine()
        Listsq()
        iQmax = 0
        bCur = False
        '  Form2.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Questions < 10 Then
            Quiz()
        Else
            BtnQuestion.Visible = True
            Panel1.Visible = False
        End If
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If iRcnt = 0 Then
            speaker.SpeakAsync(LblQuestions.Text) 'Talk
            iRcnt = 1
        Else
            If iRcnt = 1 Then speaker.SpeakAsync("One") 'Talk
            If iRcnt = 2 Then speaker.SpeakAsync("Two") 'Talk
            If iRcnt = 3 Then speaker.SpeakAsync("Three") 'Talk
            If iRcnt = 4 Then speaker.SpeakAsync("Four") 'Talk
            speaker.SpeakAsync(aList(iRcnt).Text) 'Talk

            iRcnt += 1
            If iRcnt = 5 Then Timer2.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iRcnt = 0
        Timer2.Start()
    End Sub

    '

    Private Sub optAnswer1_Click(sender As Object, e As EventArgs)
        iClick = 1
        sClick()

    End Sub

    Private Sub optAnswer2_Click(sender As Object, e As EventArgs)
        iClick = 2
        sClick()
    End Sub

    Private Sub optAnswer3_Click(sender As Object, e As EventArgs)
        iClick = 3
        sClick()
    End Sub

    Private Sub optAnswer4_Click(sender As Object, e As EventArgs)
        iClick = 4
        sClick()
    End Sub

    Private Sub LblAnswer1_Click(sender As Object, e As EventArgs) Handles LblAnswer1.Click
        iClick = 1
        sClick()
    End Sub

    Private Sub LblAnswer2_Click(sender As Object, e As EventArgs) Handles LblAnswer2.Click
        iClick = 2
        sClick()
    End Sub

    Private Sub LblAnswer3_Click(sender As Object, e As EventArgs) Handles LblAnswer3.Click
        iClick = 3
        sClick()
    End Sub

    Private Sub lblAnswer4_Click(sender As Object, e As EventArgs) Handles lblAnswer4.Click
        iClick = 4
        sClick()
    End Sub

    Private Sub LblAnswer1_MouseEnter(sender As Object, e As EventArgs) Handles LblAnswer1.MouseEnter
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.ARROW_RL))
        Me.Cursor = cur
        LblAnswer1.BackColor = Color.Yellow
        Label7.BackColor = Color.Yellow
    End Sub

    Private Sub LblAnswer1_MouseLeave(sender As Object, e As EventArgs) Handles LblAnswer1.MouseLeave
        Me.Cursor = Cursors.Default
        LblAnswer1.BackColor = DefaultBackColor
        Label7.BackColor = DefaultBackColor
    End Sub

    Private Sub LblAnswer2_MouseEnter(sender As Object, e As EventArgs) Handles LblAnswer2.MouseEnter
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.ARROW_RL))
        Me.Cursor = cur
        LblAnswer2.BackColor = Color.Yellow
        Label8.BackColor = Color.Yellow
    End Sub

    Private Sub LblAnswer2_MouseLeave(sender As Object, e As EventArgs) Handles LblAnswer2.MouseLeave
        Me.Cursor = Cursors.Default
        LblAnswer2.BackColor = DefaultBackColor
        Label8.BackColor = DefaultBackColor
    End Sub

    Private Sub LblAnswer3_MouseEnter(sender As Object, e As EventArgs) Handles LblAnswer3.MouseEnter
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.ARROW_RL))
        Me.Cursor = cur
        LblAnswer3.BackColor = Color.Yellow
        Label9.BackColor = Color.Yellow
    End Sub

    Private Sub LblAnswer3_MouseLeave(sender As Object, e As EventArgs) Handles LblAnswer3.MouseLeave
        Me.Cursor = Cursors.Default
        LblAnswer3.BackColor = DefaultBackColor
        Label9.BackColor = DefaultBackColor
    End Sub

    Private Sub lblAnswer4_MouseEnter(sender As Object, e As EventArgs) Handles lblAnswer4.MouseEnter
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.ARROW_RL))
        Me.Cursor = cur
        lblAnswer4.BackColor = Color.Yellow
        Label10.BackColor = Color.Yellow
    End Sub

    Private Sub lblAnswer4_MouseLeave(sender As Object, e As EventArgs) Handles lblAnswer4.MouseLeave
        Me.Cursor = Cursors.Default
        lblAnswer4.BackColor = DefaultBackColor
        Label10.BackColor = DefaultBackColor
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class