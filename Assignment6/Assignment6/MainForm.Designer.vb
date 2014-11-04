<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactForm
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
        Me.NameGroupBox = New System.Windows.Forms.GroupBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.StreeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.NbrOfRegistredLabel = New System.Windows.Forms.Label()
        Me.RegisteredLabel = New System.Windows.Forms.Label()
        Me.NameGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameGroupBox
        '
        Me.NameGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameGroupBox.Controls.Add(Me.LastNameLabel)
        Me.NameGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.NameGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.NameGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.NameGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.NameGroupBox.Name = "NameGroupBox"
        Me.NameGroupBox.Size = New System.Drawing.Size(324, 74)
        Me.NameGroupBox.TabIndex = 0
        Me.NameGroupBox.TabStop = False
        Me.NameGroupBox.Text = "Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 53)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 27)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(128, 46)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.LastNameTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(128, 20)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.CountryLabel)
        Me.GroupBox2.Controls.Add(Me.CountryComboBox)
        Me.GroupBox2.Controls.Add(Me.StreetLabel)
        Me.GroupBox2.Controls.Add(Me.CityLabel)
        Me.GroupBox2.Controls.Add(Me.ZipCodeLabel)
        Me.GroupBox2.Controls.Add(Me.StreeTextBox)
        Me.GroupBox2.Controls.Add(Me.CityTextBox)
        Me.GroupBox2.Controls.Add(Me.ZipCodeTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 128)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address"
        '
        'CountryLabel
        '
        Me.CountryLabel.AutoSize = True
        Me.CountryLabel.Location = New System.Drawing.Point(6, 105)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(43, 13)
        Me.CountryLabel.TabIndex = 7
        Me.CountryLabel.Text = "Country"
        '
        'CountryComboBox
        '
        Me.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(128, 97)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(184, 21)
        Me.CountryComboBox.TabIndex = 6
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(6, 25)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(35, 13)
        Me.StreetLabel.TabIndex = 5
        Me.StreetLabel.Text = "Street"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(6, 51)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "City"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(6, 78)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(47, 13)
        Me.ZipCodeLabel.TabIndex = 3
        Me.ZipCodeLabel.Text = "ZipCode"
        '
        'StreeTextBox
        '
        Me.StreeTextBox.Location = New System.Drawing.Point(128, 18)
        Me.StreeTextBox.Name = "StreeTextBox"
        Me.StreeTextBox.Size = New System.Drawing.Size(184, 20)
        Me.StreeTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(128, 44)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(184, 20)
        Me.CityTextBox.TabIndex = 1
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(128, 71)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(184, 20)
        Me.ZipCodeTextBox.TabIndex = 0
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(12, 226)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(763, 212)
        Me.ListBox.TabIndex = 1
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(362, 34)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(77, 39)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(362, 79)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(77, 39)
        Me.ChangeButton.TabIndex = 3
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(362, 124)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(77, 39)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'NbrOfRegistredLabel
        '
        Me.NbrOfRegistredLabel.AutoSize = True
        Me.NbrOfRegistredLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NbrOfRegistredLabel.Location = New System.Drawing.Point(725, 205)
        Me.NbrOfRegistredLabel.MinimumSize = New System.Drawing.Size(50, 0)
        Me.NbrOfRegistredLabel.Name = "NbrOfRegistredLabel"
        Me.NbrOfRegistredLabel.Size = New System.Drawing.Size(50, 15)
        Me.NbrOfRegistredLabel.TabIndex = 5
        '
        'RegisteredLabel
        '
        Me.RegisteredLabel.AutoSize = True
        Me.RegisteredLabel.Location = New System.Drawing.Point(581, 205)
        Me.RegisteredLabel.Name = "RegisteredLabel"
        Me.RegisteredLabel.Size = New System.Drawing.Size(123, 13)
        Me.RegisteredLabel.TabIndex = 6
        Me.RegisteredLabel.Text = "No. of registered records"
        '
        'ContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 455)
        Me.Controls.Add(Me.RegisteredLabel)
        Me.Controls.Add(Me.NbrOfRegistredLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.NameGroupBox)
        Me.Name = "ContactForm"
        Me.Text = "Contact Registry"
        Me.NameGroupBox.ResumeLayout(False)
        Me.NameGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents CountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StreetLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents ZipCodeLabel As System.Windows.Forms.Label
    Friend WithEvents StreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents ChangeButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents NbrOfRegistredLabel As System.Windows.Forms.Label
    Friend WithEvents RegisteredLabel As System.Windows.Forms.Label

End Class
