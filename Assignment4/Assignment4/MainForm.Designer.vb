<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DateAndTimeBox = New System.Windows.Forms.DateTimePicker()
        Me.DateAndTimeLabel = New System.Windows.Forms.Label()
        Me.PriorityLabel = New System.Windows.Forms.Label()
        Me.PriorityBox = New System.Windows.Forms.ComboBox()
        Me.ToDoTextBox = New System.Windows.Forms.TextBox()
        Me.ToDoLabel = New System.Windows.Forms.Label()
        Me.AddToDo = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDatafileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDatafileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToDoBox = New System.Windows.Forms.GroupBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.PrioLabel = New System.Windows.Forms.Label()
        Me.HourLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.ToDoListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip.SuspendLayout()
        Me.ToDoBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateAndTimeBox
        '
        Me.DateAndTimeBox.CustomFormat = "yyyy-MM-dd       HH:mm"
        Me.DateAndTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateAndTimeBox.Location = New System.Drawing.Point(96, 40)
        Me.DateAndTimeBox.Name = "DateAndTimeBox"
        Me.DateAndTimeBox.Size = New System.Drawing.Size(200, 20)
        Me.DateAndTimeBox.TabIndex = 0
        '
        'DateAndTimeLabel
        '
        Me.DateAndTimeLabel.AutoSize = True
        Me.DateAndTimeLabel.Location = New System.Drawing.Point(13, 42)
        Me.DateAndTimeLabel.Name = "DateAndTimeLabel"
        Me.DateAndTimeLabel.Size = New System.Drawing.Size(77, 13)
        Me.DateAndTimeLabel.TabIndex = 1
        Me.DateAndTimeLabel.Text = "Date and Time"
        '
        'PriorityLabel
        '
        Me.PriorityLabel.AutoSize = True
        Me.PriorityLabel.Location = New System.Drawing.Point(316, 42)
        Me.PriorityLabel.Name = "PriorityLabel"
        Me.PriorityLabel.Size = New System.Drawing.Size(38, 13)
        Me.PriorityLabel.TabIndex = 2
        Me.PriorityLabel.Text = "Priority"
        '
        'PriorityBox
        '
        Me.PriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PriorityBox.FormattingEnabled = True
        Me.PriorityBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PriorityBox.Location = New System.Drawing.Point(374, 39)
        Me.PriorityBox.Name = "PriorityBox"
        Me.PriorityBox.Size = New System.Drawing.Size(121, 21)
        Me.PriorityBox.TabIndex = 3
        '
        'ToDoTextBox
        '
        Me.ToDoTextBox.Location = New System.Drawing.Point(96, 66)
        Me.ToDoTextBox.Name = "ToDoTextBox"
        Me.ToDoTextBox.Size = New System.Drawing.Size(399, 20)
        Me.ToDoTextBox.TabIndex = 4
        '
        'ToDoLabel
        '
        Me.ToDoLabel.AutoSize = True
        Me.ToDoLabel.Location = New System.Drawing.Point(13, 73)
        Me.ToDoLabel.Name = "ToDoLabel"
        Me.ToDoLabel.Size = New System.Drawing.Size(37, 13)
        Me.ToDoLabel.TabIndex = 5
        Me.ToDoLabel.Text = "To Do"
        '
        'AddToDo
        '
        Me.AddToDo.Location = New System.Drawing.Point(199, 92)
        Me.AddToDo.Name = "AddToDo"
        Me.AddToDo.Size = New System.Drawing.Size(112, 23)
        Me.AddToDo.TabIndex = 7
        Me.AddToDo.Text = "Add"
        Me.AddToDo.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(506, 24)
        Me.MenuStrip.TabIndex = 8
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenDatafileToolStripMenuItem, Me.SaveDatafileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenDatafileToolStripMenuItem
        '
        Me.OpenDatafileToolStripMenuItem.Enabled = False
        Me.OpenDatafileToolStripMenuItem.Name = "OpenDatafileToolStripMenuItem"
        Me.OpenDatafileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenDatafileToolStripMenuItem.Text = "Open datafile"
        '
        'SaveDatafileToolStripMenuItem
        '
        Me.SaveDatafileToolStripMenuItem.Enabled = False
        Me.SaveDatafileToolStripMenuItem.Name = "SaveDatafileToolStripMenuItem"
        Me.SaveDatafileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveDatafileToolStripMenuItem.Text = "Save datafile"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About .."
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.Blue
        Me.TimeLabel.Location = New System.Drawing.Point(352, 418)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(143, 37)
        Me.TimeLabel.TabIndex = 9
        Me.TimeLabel.Text = "00:00:00"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'ToDoBox
        '
        Me.ToDoBox.Controls.Add(Me.DescriptionLabel)
        Me.ToDoBox.Controls.Add(Me.PrioLabel)
        Me.ToDoBox.Controls.Add(Me.HourLabel)
        Me.ToDoBox.Controls.Add(Me.DateLabel)
        Me.ToDoBox.Controls.Add(Me.ToDoListBox)
        Me.ToDoBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToDoBox.Location = New System.Drawing.Point(12, 121)
        Me.ToDoBox.Name = "ToDoBox"
        Me.ToDoBox.Size = New System.Drawing.Size(494, 294)
        Me.ToDoBox.TabIndex = 10
        Me.ToDoBox.TabStop = False
        Me.ToDoBox.Text = "To Do"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.ForeColor = System.Drawing.Color.Black
        Me.DescriptionLabel.Location = New System.Drawing.Point(379, 16)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.DescriptionLabel.TabIndex = 4
        Me.DescriptionLabel.Text = "Description"
        '
        'PrioLabel
        '
        Me.PrioLabel.AutoSize = True
        Me.PrioLabel.ForeColor = System.Drawing.Color.Black
        Me.PrioLabel.Location = New System.Drawing.Point(261, 16)
        Me.PrioLabel.Name = "PrioLabel"
        Me.PrioLabel.Size = New System.Drawing.Size(38, 13)
        Me.PrioLabel.TabIndex = 3
        Me.PrioLabel.Text = "Priority"
        '
        'HourLabel
        '
        Me.HourLabel.AutoSize = True
        Me.HourLabel.ForeColor = System.Drawing.Color.Black
        Me.HourLabel.Location = New System.Drawing.Point(141, 16)
        Me.HourLabel.Name = "HourLabel"
        Me.HourLabel.Size = New System.Drawing.Size(30, 13)
        Me.HourLabel.TabIndex = 2
        Me.HourLabel.Text = "Hour"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.ForeColor = System.Drawing.Color.Black
        Me.DateLabel.Location = New System.Drawing.Point(6, 16)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(30, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "Date"
        '
        'ToDoListBox
        '
        Me.ToDoListBox.FormattingEnabled = True
        Me.ToDoListBox.HorizontalScrollbar = True
        Me.ToDoListBox.Location = New System.Drawing.Point(3, 29)
        Me.ToDoListBox.Name = "ToDoListBox"
        Me.ToDoListBox.Size = New System.Drawing.Size(485, 264)
        Me.ToDoListBox.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 464)
        Me.Controls.Add(Me.ToDoBox)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.AddToDo)
        Me.Controls.Add(Me.ToDoLabel)
        Me.Controls.Add(Me.ToDoTextBox)
        Me.Controls.Add(Me.PriorityBox)
        Me.Controls.Add(Me.PriorityLabel)
        Me.Controls.Add(Me.DateAndTimeLabel)
        Me.Controls.Add(Me.DateAndTimeBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "To Do Reminder"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToDoBox.ResumeLayout(False)
        Me.ToDoBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateAndTimeBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateAndTimeLabel As System.Windows.Forms.Label
    Friend WithEvents PriorityLabel As System.Windows.Forms.Label
    Friend WithEvents PriorityBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToDoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToDoLabel As System.Windows.Forms.Label
    Friend WithEvents AddToDo As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDatafileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDatafileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ToDoBox As System.Windows.Forms.GroupBox
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents PrioLabel As System.Windows.Forms.Label
    Friend WithEvents HourLabel As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents ToDoListBox As System.Windows.Forms.ListBox

End Class
