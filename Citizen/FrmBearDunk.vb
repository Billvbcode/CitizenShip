Imports System.Speech
Imports System.Speech.Synthesis
Public Class FrmBearDunk
    Dim BtnABC(800) As Button ' Array of 800 Buttons
    Dim sWord3(800, 2) As String  ' 3 letter words
    Dim sWord4(800, 2) As String  ' 4 letter words
    Dim sWord5(800, 2) As String  ' 5 letter words
    Dim sWord6(800, 2) As String  ' 6 letter words
    Dim iWcnt As Integer ' Word Counter
    Dim speaker As New SpeechSynthesizer
    Private Sub BtnABC_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        Dim bMove As Boolean
        bMove = True   ' Move Bear
        sender.Visible = False 'Make Button invisible
        For i = 1 To Len(LblWord.Tag)
            If Mid(LblWord.Tag, i, 1) = sender.text Then
                Mid(LblWord.Text, i, 1) = sender.text 'Replace *
                bMove = False ' Don't move bear
            End If
        Next
        If LblWord.Tag = LblWord.Text Then 'You Won
            LblWinOrLose.Text = "You Won"
            speaker.SpeakAsync(LblWord.Text)
            LblWinOrLose.Visible = True
            BtnStart.Visible = True ' Show Start Button
        End If
        If bMove Then  'Move bear if wrong letter
            If pBear.Left > 0 Then
                pBear.Left -= 15 'Bear Left
                LblBear.Text = pBear.Left
            Else
                TimFall.Start() 'Start Fall Timer
            End If
        End If
    End Sub
    Private Sub RFile()
        Dim value As String  'Name of file
        value = My.Application.Info.DirectoryPath & "\file\master.txt"
        Dim fStream As New System.IO.FileStream(value, IO.FileMode.Open)
        Dim sReader As New System.IO.StreamReader(fStream)
        iWcnt = 0 ' Set Word counter to zero
        Dim sMyLine As String
        Do While sReader.Peek >= 0 'Read to the end of the file
            sMyLine = sReader.ReadLine            ' Read one Line
            iWcnt += 1                     ' Increase Word counter
            sWord3(iWcnt, 1) = Mid(sMyLine, 1, 3) ' 3 letter words
            sWord4(iWcnt, 1) = Mid(sMyLine, 5, 4) ' 4 letter words
            sWord5(iWcnt, 1) = Mid(sMyLine, 10, 5) ' 5 letter words
            sWord6(iWcnt, 1) = Mid(sMyLine, 16, 6) ' 6 letter words

            sWord3(iWcnt, 2) = "N" 'Not Played
            sWord4(iWcnt, 2) = "N" 'Not Played
            sWord5(iWcnt, 2) = "N" 'Not Played
            sWord6(iWcnt, 2) = "N" 'Not Played
        Loop
        fStream.Close() ' Close File
        sReader.Close()  'Close Reader
        LblTest.Text = sWord3(iWcnt, 1) 'Last 3 letter word
    End Sub

    Private Sub FrmBearDunk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim j As Integer
        Dim Icnt As Integer
        Randomize() 'Creates seed for RND function        
        Icnt = 1 ' Button counter
        '
        ' Create Buttons
        '
        For j = 1 To 5     ' Vertical
            For i = 1 To 6 ' Horizontal
                BtnABC(Icnt) = New System.Windows.Forms.Button   'Create Button
                With BtnABC(Icnt)
                    .Name = Icnt                                     'Button Name
                    .Location = New System.Drawing.Point(225 + (i - 1) * 35,
                                                         40 + (j - 1) * 35)
                    .Size = New Size(30, 30)                      'Button Size
                    .Text = Chr(64 + Icnt)                        'Button Text
                    .Font = New Font("Times New Roman", 10, FontStyle.Bold)
                End With
                Me.Controls.Add(BtnABC(Icnt)) '  This is the create the Button
                AddHandler BtnABC(Icnt).Click, AddressOf BtnABC_Click 'Click Event
                Icnt += 1 ' Increase Button counter
            Next
        Next
        For i = 27 To 30 'Hide Four Extra Buttons
            BtnABC(i).Visible = False
        Next
        RFile() ' Read Word File
        Game()
    End Sub
    Private Sub RB3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB3.CheckedChanged
        If RB3.Checked Then LblWord.Text = "***" ' 3 Letter
        If RB4.Checked Then LblWord.Text = "****" ' 4 Letter
        If RB5.Checked Then LblWord.Text = "*****" ' 5 Letter
        If RB6.Checked Then LblWord.Text = "******" ' 6 Letter
    End Sub

    Private Sub RB4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB4.CheckedChanged
        If RB3.Checked Then LblWord.Text = "***" ' 3 Letter
        If RB4.Checked Then LblWord.Text = "****" ' 4 Letter
        If RB5.Checked Then LblWord.Text = "*****" ' 5 Letter
        If RB6.Checked Then LblWord.Text = "******" ' 6 Letter
    End Sub

    Private Sub RB5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB5.CheckedChanged
        If RB3.Checked Then LblWord.Text = "***" ' 3 Letter
        If RB4.Checked Then LblWord.Text = "****" ' 4 Letter
        If RB5.Checked Then LblWord.Text = "*****" ' 5 Letter
        If RB6.Checked Then LblWord.Text = "******" ' 6 Letter
    End Sub

    Private Sub RB6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB6.CheckedChanged
        If RB3.Checked Then LblWord.Text = "***" ' 3 Letter
        If RB4.Checked Then LblWord.Text = "****" ' 4 Letter
        If RB5.Checked Then LblWord.Text = "*****" ' 5 Letter
        If RB6.Checked Then LblWord.Text = "******" ' 6 Letter
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Game()
    End Sub
    Private Sub Game()
        Dim iPick As Integer
        Dim i As Integer
        ' Pick a random number between 1 and iwcnt
PickAgain:
        iPick = Int(1 + (iWcnt - 0.001) * Rnd())
        If RB3.Checked Then
            LblTest.Text = sWord3(iPick, 1) ' 3 Letter
            LblWord.Tag = sWord3(iPick, 1)
            LblWord.Text = "***"
            ' Pick another word if this onne has been used	
            If sWord3(iPick, 2) = "Y" Then GoTo PickAgain
            sWord3(iPick, 2) = "Y" ' Y=Word has been Used 
        End If
        If RB4.Checked Then
            LblTest.Text = sWord4(iPick, 1) ' 4 Letter
            LblWord.Tag = sWord4(iPick, 1)
            LblWord.Text = "****"
            ' Pick another word if this onne has been used	
            If sWord4(iPick, 2) = "Y" Then GoTo PickAgain
            sWord4(iPick, 2) = "Y" ' Y=Word has been Used
        End If
        If RB5.Checked Then
            LblTest.Text = sWord5(iPick, 1) ' 5 Letter
            LblWord.Tag = sWord5(iPick, 1)
            LblWord.Text = "*****"
            ' Pick another word if this one has been used	
            If sWord5(iPick, 2) = "Y" Then GoTo PickAgain
            sWord5(iPick, 2) = "Y" ' Y=Word has been Used
        End If
        If RB6.Checked Then
            LblTest.Text = sWord6(iPick, 1) ' 6 Letter
            LblWord.Tag = sWord6(iPick, 1)
            LblWord.Text = "******"
            ' Pick another word if this one has been used	
            If sWord6(iPick, 2) = "Y" Then GoTo PickAgain
            sWord6(iPick, 2) = "Y" ' Y=Word has been Used
        End If
        pBear.Top = 3     ' Reset Bear to the Top
        pBear.Left = 116  ' Reset Bear to the Left
        For i = 1 To 26
            BtnABC(i).Visible = True 'Show Button
        Next
        LblTest.Visible = False   ' Hide Label
        LblTest2.Visible = False   ' Hide Label
        LblBear.Visible = False     ' Hide Label
        LblWinOrLose.Visible = False ' Hide Label
        BtnStart.Visible = False 'Hide Button
    End Sub

    Private Sub TimFall_Tick(sender As Object, e As EventArgs) Handles TimFall.Tick
        pBear.Top += 20 'Bear Falls
        LblBear.Text = pBear.Top
        If pBear.Top > 260 Then
            TimFall.Stop() ' Stop timer
            LblWinOrLose.Text = "You Lost"  'You Lost
            LblWinOrLose.Visible = True
            LblWord.Text = LblWord.Tag ' Show Answer
            BtnStart.Visible = True ' Show Start Button
            speaker.SpeakAsync(LblWord.Text)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim blackPen As New Pen(Color.Black, 3) 'Dim mypen As New Pen(
        e.Graphics.DrawLine(blackPen, 60, 124, 195, 124)
    End Sub

    Private Sub RB3_Click(sender As Object, e As EventArgs) Handles RB3.Click
        Game()
    End Sub

    Private Sub RB4_Click(sender As Object, e As EventArgs) Handles RB4.Click
        Game()
    End Sub

    Private Sub RB5_Click(sender As Object, e As EventArgs) Handles RB5.Click
        Game()
    End Sub

    Private Sub RB6_Click(sender As Object, e As EventArgs) Handles RB6.Click
        Game()
    End Sub
End Class