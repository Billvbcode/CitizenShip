Public Class ClsMove
    Dim IntLoc As Integer
    Dim IntMyLeft As Integer
    Dim IntMyTop As Integer
    Dim IntiCnt As Integer
    Dim strName As String
    Public Property Name() As String     'Store Foe Name
        Get
            Return strName
        End Get
        Set(ByVal Value As String)
            strName = Value
        End Set
    End Property

    Public Property iCnt() As Integer     'Store Car iCnt
        Get
            Return IntiCnt
        End Get
        Set(ByVal Value As Integer)
            IntiCnt = Value
        End Set
    End Property
    Public Property MyTop() As Integer     'Store Car MyTop
        Get
            Return IntMyTop
        End Get
        Set(ByVal Value As Integer)
            IntMyTop = Value
        End Set
    End Property

    Public Property MyLeft() As Integer     'Store Car MyLeft
        Get
            Return IntMyLeft
        End Get
        Set(ByVal Value As Integer)
            IntMyLeft = Value
        End Set
    End Property

    Public Property Loc() As Integer     'Store Car Loc
        Get
            Return IntLoc
        End Get
        Set(ByVal Value As Integer)
            IntLoc = Value
        End Set
    End Property
    Public Sub New()
        MyLeft = 0
        MyTop = 0
        Loc = 0
        iCnt = 0
        Name = "None"
    End Sub
End Class
