Public Class ClsQuestion
    Private cMapQType As String
    Private strQuestion As String
    Private mElements As Integer
    Private mElements2 As Integer
    Private mStrArray(99) As String
    Private mStrArray2(99) As String
    Private intQCnt As Integer
    Private strYorN As String
    Private lCount As Long
    Private lCount2 As Long
    Private iQMax As Integer
    Public Property Count() As Long
        Get
            Return mElements
        End Get
        Set(ByVal Value As Long)
            lCount = Value
        End Set
    End Property
    Public Property SaveMap(ByVal test_number As Integer) As String
        Get
            Return mStrArray(test_number)
        End Get
        Set(ByVal Value As String)
            mStrArray(test_number) = Value
            mElements = test_number + 1
        End Set
    End Property
    Public Property Count2() As Long
        Get
            Return mElements2
        End Get
        Set(ByVal Value As Long)
            lCount2 = Value
        End Set
    End Property
    Public Property SaveMap2(ByVal test_number As Integer) As String
        Get
            Return mStrArray2(test_number)
        End Get
        Set(ByVal Value As String)
            mStrArray2(test_number) = Value
            mElements2 = test_number + 1
        End Set
    End Property
    Public Property YorN() As String     'Store Car YorN
        Get
            Return strYorN
        End Get
        Set(ByVal Value As String)
            strYorN = Value
        End Set
    End Property
    Public Property Question() As String     'Store Car Question
        Get
            Return strQuestion
        End Get
        Set(ByVal Value As String)
            strQuestion = Value
        End Set
    End Property

    Public Property QCnt() As Integer     'Store Car QCnt
        Get
            Return IntQCnt
        End Get
        Set(ByVal Value As Integer)
            IntQCnt = Value
        End Set
    End Property
    Public Sub Clear()
        mElements = 0
        mElements2 = 0
    End Sub
End Class
