Public Class Main
    Private Sub Log(ByVal LogText As String)
        txtLog.Text = txtLog.Text + LogText + vbNewLine
    End Sub
    Private Sub NewBattleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBattleToolStripMenuItem.Click
        BattleStart(0)
    End Sub

    Sub BattleStart(ByVal BattleID As Integer, Optional ByVal TurnCount As Integer = 30)
        Dim Turns As Integer = TurnCount
        Dim EnemyCount As Integer
        Dim PlayerCount As Integer
        Dim Terminated As Integer 'a variable that when more than 0 will signify the battle has been terminated
        'regardless of no turns, lack of player count or lack of enemy count, e.g. a special battle event
        If BattleID > 0 Then 'if the battle id is valid, load the battle
        Else 'otherwise load the debug battle
            Dim Enemies(0) As BattleEnemy
            Enemies(0) = New BattleEnemy
            Enemies(0).PositionX = 1
            Enemies(0).PositionY = 1
            Enemies(0).HP = 100
            Enemies(0).MP = 20
            Log("Created new battle: debug battle. Created default enemy at position 1,1 with 100 hp and 20 mp and AI type 1.")
        End If
        Do Until Turns <= 0 Or EnemyCount <= 0 Or PlayerCount <= 0 Or Terminated > 0

            Turns = Turns - 1
        Loop
    End Sub
End Class
