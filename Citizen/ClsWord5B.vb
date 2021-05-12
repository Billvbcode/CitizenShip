Public Class ClsWord5B
    Dim strName As String
    Public Property Name() As String     'Store Foe Name
        Get
            Return strName
        End Get
        Set(ByVal Value As String)
            strName = Value
        End Set
    End Property
End Class
