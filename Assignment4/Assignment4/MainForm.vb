Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-26
''' <summary>
''' The form that stores and visualizes reminders
''' </summary>
''' <remarks></remarks>
Public Class MainForm
    Private currTask As Task  'The reminder to be saved
    ''' <summary>
    ''' The constructor of the form, that makes the form and calls the initiating settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub
    ''' <summary>
    ''' Initiates default settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeGUI()
        ToDoTextBox.Select() 'Autofocus on the texbox
        PriorityBox.Items.Clear() 'Clears the priority combobox of its items
        PriorityBox.Items.AddRange([Enum].GetNames(GetType(PriorityTypes.priority))) 'Fills the priority combobox with the enum priorities
        currTask = New Task(DateTime.Now) 'Creates a new reminder with the current date and time
        ToDoListBox.Items.Clear() 'Clears the listbox of all reminders
        PriorityBox.SelectedIndex = 2 'Sets the priority Normal as default selected priority 
    End Sub
    ''' <summary>
    ''' ClickHandler that calls the initializeGUI and simulates a new window when New/Ctrl+n is clicked/pressed in the tool strip menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        InitializeGUI()
    End Sub
    ''' <summary>
    ''' ClickHandler that shows a message box with options Ok and Cancel when Exit/Alt+F4 is clicked/pressed in the tool strip menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim msg = "Sure to exit program?"
        Dim title = "Think twice"
        Dim style = MsgBoxStyle.OkCancel
        Dim response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Ok Then   'If ok is clicked, shutdown
            Application.Exit()
        End If
    End Sub
    ''' <summary>
    ''' ClickHandler that opens an About window when About is pressed in the tool strip menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As AboutBox = New AboutBox
        about.ShowDialog()
    End Sub
    ''' <summary>
    ''' Handler for the timer. Updates the timeLabel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TimeLabel.Text = Format(Now, "HH:mm:ss")
    End Sub
    ''' <summary>
    ''' Adds the reminder to the listbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddToDo_Click(sender As Object, e As EventArgs) Handles AddToDo.Click
        currTask = New Task(DateTime.Parse(DateAndTimeBox.Text)) 'Creates a new task with the selected date and time from the form
        currTask.setPrio(PriorityBox.SelectedItem.ToString) 'Sets the priority of the task
        currTask.setDescription(ToDoTextBox.Text) 'Sets the remindertext of the task 
        ToDoListBox.Items.Add(currTask.getToString) 'Adds the reminder to the listbox
        ToDoTextBox.Clear() 'Cleras the reminder textbox after adding to listbox
        ToDoListBox.TopIndex = ToDoListBox.Items.Count - 1 'Keeps the vertical scroll at the bottom
    End Sub
End Class
