Public Class BattleEnemy
    Private X As Integer
    Private Y As Integer
    Private H As Integer
    Private M As Integer
    Private S As Integer
    Public Counter As Integer
    Public Reserve As Integer
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
    Public Property Speed()
        Get
            Return S
        End Get
        Set(ByVal value)
            S = value
        End Set
    End Property
    Public Sub DoAction()
        Select Case A '##FOR DEBUG ONLY - PRESET AI MODES FOR TESTING PURPOSES - REMOVE WHEN AI DEVELOPMENT BEGINS##
            Case Is = 1
                Log("This battle enemy has finished its action.")
        End Select
    End Sub

    Public Sub New()
        Log("Battle enemy initialised.")
    End Sub
End Class
