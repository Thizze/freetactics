Public Class Main
    Dim Enemies(2) As BattleEnemy
    Sub BattleStart(ByVal BattleID As Integer, Optional ByVal TurnCount As Integer = 30)
        '##BATTLE SYSTEM WILL NEED RECODING TO SUPPORT UP TO 4 TEAMS PER FIELD RATHER THAN JUST PLAYER AND OPPOSITION##
        tsTimerPause.Enabled = True
        Dim items(2) As ListViewItem
        items(0) = New ListViewItem("First A.I.")
        items(0).SubItems.Add("0")
        items(1) = New ListViewItem("Second A.I.")
        items(1).SubItems.Add("0")
        items(2) = New ListViewItem("Third A.I.")
        items(2).SubItems.Add("0")
        lstSpeed.Items.AddRange(items)
        Dim Turns As Integer = TurnCount
        Dim EnemyCount As Integer
        Dim PlayerCount As Integer
        Dim Terminated As Integer 'a variable that when more than 0 will signify the battle has been terminated
        'regardless of no turns, lack of player count or lack of enemy count, e.g. a special battle event
        If BattleID > 0 Then 'if the battle id is valid, load the battle
        Else 'otherwise load the debug battle
            Enemies(0) = New BattleEnemy
            Enemies(0).PositionX = 1
            Enemies(0).PositionY = 1
            Enemies(0).HP = 100
            Enemies(0).MP = 20
            Enemies(0).Speed = 10
            Enemies(1) = New BattleEnemy
            Enemies(1).PositionX = 2
            Enemies(1).PositionY = 1
            Enemies(1).HP = 100
            Enemies(1).MP = 20
            Enemies(1).Speed = 5
            Enemies(2) = New BattleEnemy
            Enemies(2).PositionX = 2
            Enemies(2).PositionY = 1
            Enemies(2).HP = 100
            Enemies(2).MP = 20
            Enemies(2).Speed = 7
            Dim temp As Integer
            For temp = 0 To Enemies.GetUpperBound(0)
                Enemies(temp).Counter = 0
                Enemies(temp).Reserve = 0
            Next
            Log("Created new battle: debug battle. Created default enemies on field.")
            DisplayFPS.Start()
        End If
        Do Until Turns <= 0 Or EnemyCount <= 0 Or PlayerCount <= 0 Or Terminated > 0

            Turns = Turns - 1
        Loop
    End Sub

    Private Sub NewBattleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBattleToolStripMenuItem.Click
        BattleStart(0)
    End Sub

    Private Sub tsTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTimer.Click
        tsTimer.Visible = False
        tsTimerPause.Visible = True
        txtSpeed.Enabled = False
        If txtSpeed.Text <> "" And IsNumeric(txtSpeed.Text) Then
            DisplayFPS.Interval = Val(txtSpeed.Text)
        Else
            txtSpeed.Text = Str(DisplayFPS.Interval)
        End If
        DisplayFPS.Enabled = True
    End Sub

    Private Sub tsTimerPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTimerPause.Click
        tsTimer.Visible = True
        tsTimerPause.Visible = False
        DisplayFPS.Enabled = False
        txtSpeed.Enabled = True
    End Sub

    Private Sub DisplayFPS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFPS.Tick
        Dim i As Integer
        For i = 0 To Enemies.GetUpperBound(0)
            Enemies(i).Counter = Enemies(i).Counter + Enemies(i).Reserve + Enemies(i).Speed
            Enemies(i).Reserve = 0
            If Enemies(i).Counter >= 1000 Then
                Enemies(i).Reserve = Enemies(i).Counter - 1000
                Enemies(i).Counter = 0
                Log("Enemy ID" + Str(i) + " is about to perform an action")
                Enemies(i).DoAction()
            End If
            lstSpeed.Items(i).SubItems(1).Text = Str(Enemies(i).Counter)
        Next
        txtLog.SelectionStart = txtLog.Text.Length
        txtLog.ScrollToCaret()
        txtLog.Refresh()
        Application.DoEvents()
    End Sub
End Class
