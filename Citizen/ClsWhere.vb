Public Class ClsWhere
    Dim IntLoc As Integer
    Dim IntMyLeft As Integer
    Dim IntMyTop As Integer
    Dim bMyLock As Boolean
    Public Property MyLock() As Boolean     'Store Car MyLock
        Get
            Return bMyLock
        End Get
        Set(ByVal Value As Boolean)
            bMyLock = Value
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
        MyLock = False
    End Sub
End Class
