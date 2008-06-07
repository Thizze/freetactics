<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.statusBar = New System.Windows.Forms.StatusStrip
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.DisplayFPS = New System.Windows.Forms.Timer(Me.components)
        Me.lstSpeed = New System.Windows.Forms.ListView
        Me.clnAI = New System.Windows.Forms.ColumnHeader
        Me.clnSpeed = New System.Windows.Forms.ColumnHeader
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewBattleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsTimer = New System.Windows.Forms.ToolStripButton
        Me.tsTimerPause = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtSpeed = New System.Windows.Forms.ToolStripTextBox
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusBar
        '
        Me.statusBar.Location = New System.Drawing.Point(0, 531)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(840, 22)
        Me.statusBar.TabIndex = 1
        Me.statusBar.Text = "StatusStrip"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.White
        Me.txtLog.Location = New System.Drawing.Point(12, 52)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(523, 466)
        Me.txtLog.TabIndex = 3
        '
        'DisplayFPS
        '
        '
        'lstSpeed
        '
        Me.lstSpeed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnAI, Me.clnSpeed})
        Me.lstSpeed.GridLines = True
        Me.lstSpeed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstSpeed.Location = New System.Drawing.Point(541, 52)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(287, 466)
        Me.lstSpeed.TabIndex = 4
        Me.lstSpeed.UseCompatibleStateImageBehavior = False
        Me.lstSpeed.View = System.Windows.Forms.View.Details
        '
        'clnAI
        '
        Me.clnAI.Text = "Player"
        Me.clnAI.Width = 187
        '
        'clnSpeed
        '
        Me.clnSpeed.Text = "Current Speed"
        Me.clnSpeed.Width = 95
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBattleToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewBattleToolStripMenuItem
        '
        Me.NewBattleToolStripMenuItem.Name = "NewBattleToolStripMenuItem"
        Me.NewBattleToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NewBattleToolStripMenuItem.Text = "New Battle"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTimer, Me.tsTimerPause, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtSpeed})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(840, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsTimer
        '
        Me.tsTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsTimer.Image = Global.FreeTactics.My.Resources.Resources.Run
        Me.tsTimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTimer.Name = "tsTimer"
        Me.tsTimer.Size = New System.Drawing.Size(23, 22)
        Me.tsTimer.Text = "Resume the battle timer"
        Me.tsTimer.Visible = False
        '
        'tsTimerPause
        '
        Me.tsTimerPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsTimerPause.Enabled = False
        Me.tsTimerPause.Image = Global.FreeTactics.My.Resources.Resources.Pause
        Me.tsTimerPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTimerPause.Name = "tsTimerPause"
        Me.tsTimerPause.Size = New System.Drawing.Size(23, 22)
        Me.tsTimerPause.Text = "Pause the battle timer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "Timer Speed:"
        '
        'txtSpeed
        '
        Me.txtSpeed.Enabled = False
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(100, 25)
        Me.txtSpeed.Text = "100"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 553)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.Text = "FreeTactics Debug"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents DisplayFPS As System.Windows.Forms.Timer
    Friend WithEvents lstSpeed As System.Windows.Forms.ListView
    Friend WithEvents clnAI As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnSpeed As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBattleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsTimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsTimerPause As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSpeed As System.Windows.Forms.ToolStripTextBox

End Class
