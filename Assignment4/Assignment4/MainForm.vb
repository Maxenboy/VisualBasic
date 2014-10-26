Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-26

Public Class MainForm
    Private currTask As Task
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub

    Public Sub InitializeGUI()
        'PriorityBox.Items.AddRange([Enum].GetNames(GetType(PriorityTypes)))
        currTask = New Task(DateTime.Now)
        'PriorityBox.SelectedIndex = 1
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim window As Form = New MainForm
        window.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim msg = "Sure to exit program?"
        Dim title = "Think twice"
        Dim style = MsgBoxStyle.OkCancel
        Dim response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As AboutBox = New AboutBox
        about.ShowDialog()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TimeLabel.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub AddToDo_Click(sender As Object, e As EventArgs) Handles AddToDo.Click
        currTask = New Task(DateTime.Parse(DateAndTimeBox.Text))
        currTask.setPrio(PriorityBox.SelectedIndex.ToString)
        currTask.setDescription(ToDoTextBox.Text)
        ToDoListBox.Items.Add(currTask.getToString)
    End Sub
End Class
