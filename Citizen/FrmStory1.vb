Imports System.Speech
Imports System.Speech.Synthesis
Public Class FrmStory1
    Dim sFolder As String
    Dim speaker As New SpeechSynthesizer


    'Agent Action Done

    Private Sub GetFiles()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & ”\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        ' Read all the levels
        '
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.*")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        TxtName.Text = ListBox1.Text
        LblSave.Text = ""
        ReadLine()
    End Sub

    'Private Sub BtnRead_Click(sender As Object, e As EventArgs)
    '    Dim i As Integer
    '    Dim n As Integer
    '    Dim cMY As String
    '    Dim cTxt As String
    '    cTxt = ""
    '    For i = 1 To Len(TxtFile.Text)
    '        cMY = Mid(TxtFile.Text, i, 1)
    '        If cMY >= " " Then
    '            cTxt = cTxt & cMY
    '            '       If bOneword Then
    '            '       Else
    '            If cMY = "." Or cMY = "?" Or cMY = "!" Then
    '                If cTxt <> "" Then MyChar.Speak(cTxt)
    '                'If bFirst Then

    '                'End If
    '                cTxt = ""
    '            End If

    '        End If
    '    Next
    '    Threading.Thread.Sleep(4000)
    '    n = Int((3 * Rnd()) + 1)
    '    Select Case n
    '        Case 1
    '            MyChar.Speak("The end")
    '        Case 2
    '            MyChar.Speak("That is all folks")
    '        Case 3
    '            MyChar.Speak("Another Story?")
    '    End Select
    'End Sub

    'Private Sub BtnSave_Click(sender As Object, e As EventArgs)
    '    Dim sFileName As String
    '    Dim i As Integer
    '    Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & “\"
    '    If TxtName.Text = "" Then Exit Sub
    '    i = InStr(1, TxtName.Text, ".")
    '    If i = 0 Then
    '        TxtName.Text = TxtName.Text & ".txt"
    '    Else
    '        TxtName.Text = Mid(TxtName.Text, 1, i) & "txt"
    '    End If
    '    ' If Mid(TxtName.Text,,4)
    '    sFileName = value & TxtName.Text 'File Name
    '    Dim srFileWrite As New System.IO.StreamWriter(sFileName) 'Open File
    '    srFileWrite.WriteLine(TxtFile.Text) 'Write Map String as a File
    '    srFileWrite.Close()         'Close File
    '    LblSave.Text = TxtName.Text
    '    GetFiles()
    'End Sub
    Public Sub ReadLine()
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & ”\"
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        srFileReader = System.IO.File.OpenText(value & TxtName.Text)
        'Read First Line
        sInputLine = srFileReader.ReadLine()
        TxtFile.Text = sInputLine
        Do Until sInputLine Is Nothing
            'Read Next Lines       
            sInputLine = srFileReader.ReadLine()
            TxtFile.Text = TxtFile.Text & vbCrLf & sInputLine
        Loop
        srFileReader.Close() 'Close Reader
    End Sub
    Private Sub FrmStory1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sFolder = "Story"

        Panel1.Visible = False
        Randomize()
        GetFiles()
        TxtName.Text = "AStory.txt"
        ReadLine()
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        TxtName.Text = ListBox1.Text
        Panel1.Visible = False
        LblSave.Text = ""
        ReadLine()
    End Sub

    Private Sub BtnRead_Click_1(sender As Object, e As EventArgs) Handles BtnRead.Click
        Dim i As Integer
        Dim n As Integer
        Dim cMY As String
        Dim cTxt As String
        Panel1.Visible = False
        LblSave.Text = ""
        If TxtFile.Text = "" Then Exit Sub
        cTxt = ""
        For i = 1 To Len(TxtFile.Text)
            cMY = Mid(TxtFile.Text, i, 1)
            If cMY >= " " Then
                cTxt = cTxt & cMY
                '       If bOneword Then
                '       Else
                If cMY = "." Or cMY = "?" Or cMY = "!" Then
                    If cTxt <> "" Then speaker.SpeakAsync(cTxt)
                    'If bFirst Then

                    'End If
                    cTxt = ""
                End If

            End If
        Next
        Threading.Thread.Sleep(4000)
        n = Int((3 * Rnd()) + 1)
        Select Case n
            Case 1
                speaker.SpeakAsync("The end")
            Case 2
                speaker.SpeakAsync("That is all folks")
            Case 3
                speaker.SpeakAsync("Another Story?")
        End Select
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim sFileName As String
        Dim i As Integer
        Dim value As String = My.Application.Info.DirectoryPath & "\” & sFolder & “\"
        Panel1.Visible = False
        LblSave.Text = ""
        If TxtName.Text = "" Then Exit Sub
        i = InStr(1, TxtName.Text, ".")
        If i = 0 Then
            TxtName.Text = TxtName.Text & ".txt"
        Else
            TxtName.Text = Mid(TxtName.Text, 1, i) & "txt"
        End If
        ' If Mid(TxtName.Text,,4)
        sFileName = value & TxtName.Text 'File Name
        Dim srFileWrite As New System.IO.StreamWriter(sFileName) 'Open File
        srFileWrite.WriteLine(TxtFile.Text) 'Write Map String as a File
        srFileWrite.Close()         'Close File
        LblSave.Text = TxtName.Text
        GetFiles()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim WRD(40) As String
        Dim sOut As String
        Dim CNT As Integer
        Dim iLoc As Integer
        Dim iHZ As Integer
        Dim iVT As Integer
        Dim iHZD As Integer
        Dim iVTD As Integer
        Dim iHZU As Integer
        Dim iVTU As Integer
        Dim iEND As Integer
        Dim iEND2 As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim sMsg As String
        Dim iChrcnt As Integer
        ' Panel1.Visible = True
        iHZ = 50 '16 '20
        iVT = 25  '20 '24
        iChrcnt = 0
        ' iHZ = HScroll1.Value
        '  iVT = VScroll1.Value
        iEND = Len(TxtFile.Text)
        ' WRD(1, 1) = Mid(TxtFile)
        sOut = ""
        'ListBox1.Items.Clear()
        For i = 1 To iEND
            If Asc(Mid(TxtFile.Text, i, 1)) > 31 Then
                sOut = sOut & Mid(TxtFile.Text, i, 1)
            End If
        Next
        For i = 1 To 40
            WRD(i) = Space(50)
        Next
        iEND2 = Len(sOut)
        CNT = iEND2
        WRD(1) = Mid(sOut, 1, 50)
        'ListBox1.Items.Add("50")
        iLoc = 51
        iVTD = 50
        iHZU = 25
        iVTU = 1
        iHZD = 3
        '  TxtFile.Text = WRD(1)
        '
        ' Down
        For j = 1 To 6
            ' Down
            iChrcnt = 0
            If j = 3 Then iVTU -= 3
            If j = 4 Then iVTU = 7
            If j = 5 Then iVTU = 9
            If j = 6 Then iVTU = 11
            ' ListBox1.Items.Add(j & "*Down* " & "  iVTu " & iVTU + 1 & "  iVTD " & iVTD)
            For i = 1 To 24
                If iVTU + i > iHZU Then Exit For
                mid(WRD(iVTU + i), iVTD, 1) = Mid(sOut, iLoc, 1)
                iLoc += 1
                If iLoc > iEND2 Then iLoc = 1
                iChrcnt += 1
            Next
            ' ListBox1.Items.Add("Down " & iChrcnt & "  iVTD " & iVTD)
            iChrcnt = 0
            'If j = 6 Then GoTo myOUt
            '
            'Back
            k = iVTD
            sMsg = Mid(sOut, iLoc, 1)
            k = 0
            For i = 1 To 70
                If iVTD - i < iVTU Then Exit For
                If k = iVTD Then Exit For
                k += 1
                mid(WRD(iHZU), iVTD - i, 1) = Mid(sOut, iLoc, 1)
                iLoc += 1
                If iLoc > iEND2 Then iLoc = 1
                iChrcnt += 1
                If j = 2 And iChrcnt = 41 Then Exit For
                If j = 3 And iChrcnt = 34 Then Exit For
                If j = 4 And iChrcnt = 27 Then Exit For
                If j = 5 And iChrcnt = 21 Then Exit For
                If j = 6 And iChrcnt = 15 Then Exit For
            Next
            'ListBox1.Items.Add("Back " & iChrcnt & "  iVTu " & iVTU)
            iChrcnt = 0
            If j = 2 Then iVTU += 2
            If j = 3 Then iVTU += 4
            If j = 4 Then iVTU += 4
            If j = 5 Then iVTU += 4
            If j = 6 Then iVTU += 4
            'If j = 6 Then GoTo myOUt
            '
            ' Up
            sMsg = Mid(sOut, iLoc, 1)

            For i = 1 To 70
                If iHZU - i < iHZD Then Exit For
                If i + iVTU > iVTD Then Exit For
                mid(WRD(iHZU - i), iVTU, 1) = Mid(sOut, iLoc, 1)
                iLoc += 1
                If iLoc > iEND2 Then iLoc = 1
                iChrcnt += 1
            Next
            ' ListBox1.Items.Add("Up " & iChrcnt & "  iVTu " & iVTU)
            iChrcnt = 0
            ' If j = 6 Then GoTo myOUt
            iVTD -= 2
            '
            ' Across
            iVTD -= 2
            sMsg = Mid(sOut, iLoc, 1)
            For i = 1 To 50
                If iHZD + i > 50 Then Exit For
                If iVTU + i > iVTD Then Exit For
                mid(WRD(iHZD), iVTU + i, 1) = Mid(sOut, iLoc, 1)
                iLoc += 1
                If iLoc > iEND2 Then iLoc = 1
                iChrcnt += 1
            Next
            'ListBox1.Items.Add("Across " & iChrcnt)
            iChrcnt = 0
            iVTU += 2
            iHZU -= 2
            iHZD += 2
            'iVTD -= 2
        Next
myOUt:
        TxtFile.Text = WRD(1)
        For i = 1 To 25
            TxtFile.Text = TxtFile.Text & vbCrLf & WRD(i + 1)
        Next
    End Sub

    Private Sub FrmStory1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ';MyChar.Hide()
    End Sub
End Class