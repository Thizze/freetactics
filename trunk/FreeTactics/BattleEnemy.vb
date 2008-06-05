Public Class BattleEnemy
    Dim X As Integer
    Dim Y As Integer
    Dim H As Integer
    Dim M As Integer
    'Dim S As SkillSet
    Const A As Integer = 1 'AIType
    Public Property PositionX() As Integer
        Get
            Return X
        End Get
        Set(ByVal value As Integer)
            X = value
        End Set
    End Property
    Public Property PositionY() As Integer
        Get
            Return Y
        End Get
        Set(ByVal value As Integer)
            Y = value
        End Set
    End Property
    Public Property HP() As Integer
        Get
            Return H
        End Get
        Set(ByVal value As Integer)
            H = value
        End Set
    End Property
    Public Property MP()
        Get
            Return M
        End Get
        Set(ByVal value)
            M = value
        End Set
    End Property
End Class
