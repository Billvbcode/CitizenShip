Imports System.Speech
Imports System.Speech.Synthesis
Public Class FrmJoke
    Dim cJokes(500, 4)
    Dim ijCnt As Integer
    Dim ikCnt As Integer
    Dim iQuizcnt As Integer
    Dim iCnt As Integer
    Dim speaker As New SpeechSynthesizer




    Private Sub FrmJoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sFileName = "Joke.txt"
        Randomize()
        Dim value As String = My.Application.Info.DirectoryPath & "\file\”
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        srFileReader = System.IO.File.OpenText(value & "Joke.txt")
        'Read First Line

        sInputLine = srFileReader.ReadLine()
        ijCnt = 0
        ikCnt = 0
        iCnt = 1
        Do Until sInputLine Is Nothing

            '  sInputLine = srFileReader.ReadLine()
            If Mid(sInputLine, 1, 1) = "Q" Then
                ijCnt += 1
                cJokes(ijCnt, 1) = Mid(sInputLine, 3, Len(sInputLine) - 2)
                cJokes(ijCnt, 3) = "N"
            Else
                ikCnt += 1
                cJokes(ikCnt, 2) = Mid(sInputLine, 3, Len(sInputLine) - 2)
            End If
            sInputLine = srFileReader.ReadLine()
        Loop
        srFileReader.Close() 'Close Reader
        iQuizcnt = ikCnt

    End Sub

    Private Sub BtnQ_Click(sender As Object, e As EventArgs) Handles BtnQ.Click
        Dim ival As Integer
        ' Dim j, L As Integer
        'Dim cMsg As String
        ' cQuizfile = "C:\kids\Quiz1.txt"

PickQuestion:
        'iCnt = iCnt + 1
        ival = Int((Rnd() * iQuizcnt) + 1)
        If ival > iQuizcnt Then ival = 1
        'j = Len(cJokes(ival, 0))

        If cJokes(ival, 3) = "Y" And iCnt < iQuizcnt Then GoTo PickQuestion
        cJokes(ival, 3) = "Y"
        iCnt = iCnt + 1
        LblQuestion.Text = cJokes(ival, 1)
        LblAnswer.Text = cJokes(ival, 2)
        LblAnswer.Visible = False
        speaker.SpeakAsync(LblQuestion.Text)
        BtnA.Focus()
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles BtnA.Click
        LblAnswer.Visible = True
        speaker.SpeakAsync(LblAnswer.Text)
        BtnQ.Focus()
    End Sub

    Private Sub FrmJoke_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' MyChar.Hide()
    End Sub
End Class