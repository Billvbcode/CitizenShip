Public Class FrmFile
    Dim iWordcnt As Integer
    Dim iMaster As Integer
    Dim iLetloc As Integer
    Dim cWord As String
    Public cWordProb(5000) As String
    Public cMaster(5000, 8) As String
    Private Sub RFile()
        Dim value As String  'Name of file
        value = My.Application.Info.DirectoryPath & "\master.txt"
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
    Private Sub GetFilesjpg()
        Dim value As String = My.Application.Info.DirectoryPath & "\wmf\"
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(value)
        '    Dim sFolder As String
        Dim j As Integer
        Dim k As Integer
        Dim sMsg As String
        Dim sInputLine As String
        '
        ' Check to see if the Directory Exist
        '
        ' sFolder = "Jpg"
        'CheckDir(sFolder) 'Suburoutine in Module
        '
        ' Read all the levels
        '
        ListBox2.Items.Clear()  'Clear ListBox
        ListBox1.Items.Clear()  'Clear ListBox
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.wmf")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            sInputLine = Mid(dra.Name, 1, Len(dra.Name) - 4)
            If Len(sInputLine) = 3 Then ListBox7.Items.Add(sInputLine)
            If Len(sInputLine) = 4 Then ListBox1.Items.Add(sInputLine)
            If Len(sInputLine) = 5 Then ListBox2.Items.Add(sInputLine)
            If Len(sInputLine) = 6 Then ListBox3.Items.Add(sInputLine)
        Next
        j = ListBox2.Items.Count
        k = j
        '  sFile = "bug"
        ' picOriginal.Image = Image.FromFile(value & sFile)
    End Sub
    Private Sub ReadFileMap()
        '
        ' Read File
        '

        Dim sFileName As String
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim value As String = My.Application.Info.DirectoryPath '& "\bird\"
        Dim iwcnt As Long
        '  sFileName = value & "\boggle.txt" '"\words.dat"
        sFileName = value & "\boggle.txt"
        iwcnt = 0
        srFileReader = System.IO.File.OpenText(sFileName)
        '  sInputLine = srFileReader.ReadLine()
        Do While srFileReader.Peek() <> -1
            sInputLine = srFileReader.ReadLine()
            If Len(sInputLine) = 4 Then ListBox4.Items.Add(sInputLine)
            If Len(sInputLine) = 5 Then ListBox5.Items.Add(sInputLine)
            If Len(sInputLine) = 6 Then ListBox6.Items.Add(sInputLine)
        Loop
        srFileReader.Close()
        '

    End Sub
    Private Sub FrmFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RFile()
        GetFilesjpg()
        ReadFileMap()
    End Sub
End Class