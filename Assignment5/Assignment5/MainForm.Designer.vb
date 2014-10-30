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
        Me.SeatGroupBox = New System.Windows.Forms.GroupBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.BookingInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeatNumberInput = New System.Windows.Forms.Label()
        Me.SeatNumberLabel = New System.Windows.Forms.Label()
        Me.CancelRadioButton = New System.Windows.Forms.RadioButton()
        Me.ReserveRadioButton = New System.Windows.Forms.RadioButton()
        Me.ReserveButton = New System.Windows.Forms.Button()
        Me.OutputDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.NumberOfVacantOutputLabel = New System.Windows.Forms.Label()
        Me.NumberOfReservedOutputLabel = New System.Windows.Forms.Label()
        Me.NumberOfVacantLabel = New System.Windows.Forms.Label()
        Me.NumberOfSeatsOutputLabel = New System.Windows.Forms.Label()
        Me.NumberOfSeatsLabel = New System.Windows.Forms.Label()
        Me.NumberOfReservedLabel = New System.Windows.Forms.Label()
        Me.ReservationsGroupBox = New System.Windows.Forms.GroupBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SeatLabel = New System.Windows.Forms.Label()
        Me.PriceListBoxLabel = New System.Windows.Forms.Label()
        Me.NameListBoxLabel = New System.Windows.Forms.Label()
        Me.ReservationListBox = New System.Windows.Forms.ListBox()
        Me.ShowComboBox = New System.Windows.Forms.ComboBox()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.SeatGroupBox.SuspendLayout()
        Me.BookingInputGroupBox.SuspendLayout()
        Me.OutputDataGroupBox.SuspendLayout()
        Me.ReservationsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SeatGroupBox
        '
        Me.SeatGroupBox.Controls.Add(Me.PriceLabel)
        Me.SeatGroupBox.Controls.Add(Me.NameLabel)
        Me.SeatGroupBox.Controls.Add(Me.PriceBox)
        Me.SeatGroupBox.Controls.Add(Me.NameBox)
        Me.SeatGroupBox.Location = New System.Drawing.Point(0, 69)
        Me.SeatGroupBox.Name = "SeatGroupBox"
        Me.SeatGroupBox.Size = New System.Drawing.Size(330, 67)
        Me.SeatGroupBox.TabIndex = 0
        Me.SeatGroupBox.TabStop = False
        Me.SeatGroupBox.Text = "Seat"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.ForeColor = System.Drawing.Color.Black
        Me.PriceLabel.Location = New System.Drawing.Point(227, 20)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceLabel.TabIndex = 6
        Me.PriceLabel.Text = "Price"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.ForeColor = System.Drawing.Color.Black
        Me.NameLabel.Location = New System.Drawing.Point(0, 20)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'PriceBox
        '
        Me.PriceBox.Location = New System.Drawing.Point(230, 36)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceBox.TabIndex = 2
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(0, 36)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(215, 20)
        Me.NameBox.TabIndex = 1
        '
        'BookingInputGroupBox
        '
        Me.BookingInputGroupBox.Controls.Add(Me.SeatNumberInput)
        Me.BookingInputGroupBox.Controls.Add(Me.SeatNumberLabel)
        Me.BookingInputGroupBox.Controls.Add(Me.CancelRadioButton)
        Me.BookingInputGroupBox.Controls.Add(Me.ReserveRadioButton)
        Me.BookingInputGroupBox.Controls.Add(Me.ReserveButton)
        Me.BookingInputGroupBox.Controls.Add(Me.SeatGroupBox)
        Me.BookingInputGroupBox.ForeColor = System.Drawing.Color.Green
        Me.BookingInputGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.BookingInputGroupBox.Name = "BookingInputGroupBox"
        Me.BookingInputGroupBox.Size = New System.Drawing.Size(336, 172)
        Me.BookingInputGroupBox.TabIndex = 1
        Me.BookingInputGroupBox.TabStop = False
        Me.BookingInputGroupBox.Text = "Booking Input"
        '
        'SeatNumberInput
        '
        Me.SeatNumberInput.AutoSize = True
        Me.SeatNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SeatNumberInput.ForeColor = System.Drawing.Color.Black
        Me.SeatNumberInput.Location = New System.Drawing.Point(126, 28)
        Me.SeatNumberInput.MinimumSize = New System.Drawing.Size(40, 20)
        Me.SeatNumberInput.Name = "SeatNumberInput"
        Me.SeatNumberInput.Size = New System.Drawing.Size(40, 20)
        Me.SeatNumberInput.TabIndex = 7
        '
        'SeatNumberLabel
        '
        Me.SeatNumberLabel.AutoSize = True
        Me.SeatNumberLabel.ForeColor = System.Drawing.Color.Black
        Me.SeatNumberLabel.Location = New System.Drawing.Point(6, 35)
        Me.SeatNumberLabel.Name = "SeatNumberLabel"
        Me.SeatNumberLabel.Size = New System.Drawing.Size(67, 13)
        Me.SeatNumberLabel.TabIndex = 7
        Me.SeatNumberLabel.Text = "Seat number"
        '
        'CancelRadioButton
        '
        Me.CancelRadioButton.AutoSize = True
        Me.CancelRadioButton.ForeColor = System.Drawing.Color.Black
        Me.CancelRadioButton.Location = New System.Drawing.Point(230, 46)
        Me.CancelRadioButton.Name = "CancelRadioButton"
        Me.CancelRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.CancelRadioButton.TabIndex = 4
        Me.CancelRadioButton.TabStop = True
        Me.CancelRadioButton.Text = "Cancel"
        Me.CancelRadioButton.UseVisualStyleBackColor = True
        '
        'ReserveRadioButton
        '
        Me.ReserveRadioButton.AutoSize = True
        Me.ReserveRadioButton.ForeColor = System.Drawing.Color.Black
        Me.ReserveRadioButton.Location = New System.Drawing.Point(230, 19)
        Me.ReserveRadioButton.Name = "ReserveRadioButton"
        Me.ReserveRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.ReserveRadioButton.TabIndex = 3
        Me.ReserveRadioButton.TabStop = True
        Me.ReserveRadioButton.Text = "Reserve"
        Me.ReserveRadioButton.UseVisualStyleBackColor = True
        '
        'ReserveButton
        '
        Me.ReserveButton.ForeColor = System.Drawing.Color.Black
        Me.ReserveButton.Location = New System.Drawing.Point(126, 142)
        Me.ReserveButton.Name = "ReserveButton"
        Me.ReserveButton.Size = New System.Drawing.Size(75, 23)
        Me.ReserveButton.TabIndex = 1
        Me.ReserveButton.Text = "Reserve"
        Me.ReserveButton.UseVisualStyleBackColor = True
        '
        'OutputDataGroupBox
        '
        Me.OutputDataGroupBox.Controls.Add(Me.NumberOfVacantOutputLabel)
        Me.OutputDataGroupBox.Controls.Add(Me.NumberOfReservedOutputLabel)
        Me.OutputDataGroupBox.Controls.Add(Me.NumberOfVacantLabel)
        Me.OutputDataGroupBox.Controls.Add(Me.NumberOfSeatsOutputLabel)
        Me.OutputDataGroupBox.Controls.Add(Me.NumberOfSeatsLabel)
        Me.OutputDataGroupBox.Controls.Add(Me.NumberOfReservedLabel)
        Me.OutputDataGroupBox.ForeColor = System.Drawing.Color.Green
        Me.OutputDataGroupBox.Location = New System.Drawing.Point(6, 190)
        Me.OutputDataGroupBox.Name = "OutputDataGroupBox"
        Me.OutputDataGroupBox.Size = New System.Drawing.Size(342, 105)
        Me.OutputDataGroupBox.TabIndex = 1
        Me.OutputDataGroupBox.TabStop = False
        Me.OutputDataGroupBox.Text = "Output Data"
        '
        'NumberOfVacantOutputLabel
        '
        Me.NumberOfVacantOutputLabel.AutoSize = True
        Me.NumberOfVacantOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NumberOfVacantOutputLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberOfVacantOutputLabel.Location = New System.Drawing.Point(236, 78)
        Me.NumberOfVacantOutputLabel.MinimumSize = New System.Drawing.Size(100, 0)
        Me.NumberOfVacantOutputLabel.Name = "NumberOfVacantOutputLabel"
        Me.NumberOfVacantOutputLabel.Size = New System.Drawing.Size(100, 15)
        Me.NumberOfVacantOutputLabel.TabIndex = 6
        '
        'NumberOfReservedOutputLabel
        '
        Me.NumberOfReservedOutputLabel.AutoSize = True
        Me.NumberOfReservedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NumberOfReservedOutputLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberOfReservedOutputLabel.Location = New System.Drawing.Point(236, 54)
        Me.NumberOfReservedOutputLabel.MinimumSize = New System.Drawing.Size(100, 0)
        Me.NumberOfReservedOutputLabel.Name = "NumberOfReservedOutputLabel"
        Me.NumberOfReservedOutputLabel.Size = New System.Drawing.Size(100, 15)
        Me.NumberOfReservedOutputLabel.TabIndex = 5
        '
        'NumberOfVacantLabel
        '
        Me.NumberOfVacantLabel.AutoSize = True
        Me.NumberOfVacantLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberOfVacantLabel.Location = New System.Drawing.Point(6, 78)
        Me.NumberOfVacantLabel.Name = "NumberOfVacantLabel"
        Me.NumberOfVacantLabel.Size = New System.Drawing.Size(92, 13)
        Me.NumberOfVacantLabel.TabIndex = 5
        Me.NumberOfVacantLabel.Text = "Number of vacant"
        '
        'NumberOfSeatsOutputLabel
        '
        Me.NumberOfSeatsOutputLabel.AutoSize = True
        Me.NumberOfSeatsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NumberOfSeatsOutputLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberOfSeatsOutputLabel.Location = New System.Drawing.Point(236, 28)
        Me.NumberOfSeatsOutputLabel.MinimumSize = New System.Drawing.Size(100, 0)
        Me.NumberOfSeatsOutputLabel.Name = "NumberOfSeatsOutputLabel"
        Me.NumberOfSeatsOutputLabel.Size = New System.Drawing.Size(100, 15)
        Me.NumberOfSeatsOutputLabel.TabIndex = 4
        '
        'NumberOfSeatsLabel
        '
        Me.NumberOfSeatsLabel.AutoSize = True
        Me.NumberOfSeatsLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberOfSeatsLabel.Location = New System.Drawing.Point(6, 28)
        Me.NumberOfSeatsLabel.Name = "NumberOfSeatsLabel"
        Me.NumberOfSeatsLabel.Size = New System.Drawing.Size(84, 13)
        Me.NumberOfSeatsLabel.TabIndex = 3
        Me.NumberOfSeatsLabel.Text = "Number of seats"
        '
        'NumberOfReservedLabel
        '
        Me.NumberOfReservedLabel.AutoSize = True
        Me.NumberOfReservedLabel.ForeColor = System.Drawing.Color.Black
        Me.NumberOfReservedLabel.Location = New System.Drawing.Point(6, 54)
        Me.NumberOfReservedLabel.Name = "NumberOfReservedLabel"
        Me.NumberOfReservedLabel.Size = New System.Drawing.Size(100, 13)
        Me.NumberOfReservedLabel.TabIndex = 4
        Me.NumberOfReservedLabel.Text = "Number of reserved"
        '
        'ReservationsGroupBox
        '
        Me.ReservationsGroupBox.Controls.Add(Me.StatusLabel)
        Me.ReservationsGroupBox.Controls.Add(Me.SeatLabel)
        Me.ReservationsGroupBox.Controls.Add(Me.PriceListBoxLabel)
        Me.ReservationsGroupBox.Controls.Add(Me.NameListBoxLabel)
        Me.ReservationsGroupBox.Controls.Add(Me.ReservationListBox)
        Me.ReservationsGroupBox.Controls.Add(Me.ShowComboBox)
        Me.ReservationsGroupBox.Controls.Add(Me.ShowLabel)
        Me.ReservationsGroupBox.ForeColor = System.Drawing.Color.Green
        Me.ReservationsGroupBox.Location = New System.Drawing.Point(371, 12)
        Me.ReservationsGroupBox.Name = "ReservationsGroupBox"
        Me.ReservationsGroupBox.Size = New System.Drawing.Size(446, 283)
        Me.ReservationsGroupBox.TabIndex = 2
        Me.ReservationsGroupBox.TabStop = False
        Me.ReservationsGroupBox.Text = "Reservations"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.ForeColor = System.Drawing.Color.Black
        Me.StatusLabel.Location = New System.Drawing.Point(61, 48)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(37, 13)
        Me.StatusLabel.TabIndex = 6
        Me.StatusLabel.Text = "Status"
        '
        'SeatLabel
        '
        Me.SeatLabel.AutoSize = True
        Me.SeatLabel.ForeColor = System.Drawing.Color.Black
        Me.SeatLabel.Location = New System.Drawing.Point(3, 48)
        Me.SeatLabel.Name = "SeatLabel"
        Me.SeatLabel.Size = New System.Drawing.Size(29, 13)
        Me.SeatLabel.TabIndex = 5
        Me.SeatLabel.Text = "Seat"
        '
        'PriceListBoxLabel
        '
        Me.PriceListBoxLabel.AutoSize = True
        Me.PriceListBoxLabel.ForeColor = System.Drawing.Color.Black
        Me.PriceListBoxLabel.Location = New System.Drawing.Point(360, 50)
        Me.PriceListBoxLabel.Name = "PriceListBoxLabel"
        Me.PriceListBoxLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceListBoxLabel.TabIndex = 4
        Me.PriceListBoxLabel.Text = "Price"
        '
        'NameListBoxLabel
        '
        Me.NameListBoxLabel.AutoSize = True
        Me.NameListBoxLabel.ForeColor = System.Drawing.Color.Black
        Me.NameListBoxLabel.Location = New System.Drawing.Point(157, 50)
        Me.NameListBoxLabel.Name = "NameListBoxLabel"
        Me.NameListBoxLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameListBoxLabel.TabIndex = 3
        Me.NameListBoxLabel.Text = "Name"
        '
        'ReservationListBox
        '
        Me.ReservationListBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationListBox.FormattingEnabled = True
        Me.ReservationListBox.ItemHeight = 14
        Me.ReservationListBox.Location = New System.Drawing.Point(6, 65)
        Me.ReservationListBox.Name = "ReservationListBox"
        Me.ReservationListBox.Size = New System.Drawing.Size(434, 200)
        Me.ReservationListBox.TabIndex = 2
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.Location = New System.Drawing.Point(319, 15)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ShowComboBox.TabIndex = 1
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(267, 23)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 0
        Me.ShowLabel.Text = "Show"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 308)
        Me.Controls.Add(Me.ReservationsGroupBox)
        Me.Controls.Add(Me.OutputDataGroupBox)
        Me.Controls.Add(Me.BookingInputGroupBox)
        Me.Name = "MainForm"
        Me.Text = "CBS Cinema Booking System"
        Me.SeatGroupBox.ResumeLayout(False)
        Me.SeatGroupBox.PerformLayout()
        Me.BookingInputGroupBox.ResumeLayout(False)
        Me.BookingInputGroupBox.PerformLayout()
        Me.OutputDataGroupBox.ResumeLayout(False)
        Me.OutputDataGroupBox.PerformLayout()
        Me.ReservationsGroupBox.ResumeLayout(False)
        Me.ReservationsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SeatGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BookingInputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputDataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ReservationsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents ReserveButton As System.Windows.Forms.Button
    Friend WithEvents NumberOfVacantLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfSeatsLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfReservedLabel As System.Windows.Forms.Label
    Public WithEvents NumberOfVacantOutputLabel As System.Windows.Forms.Label
    Public WithEvents NumberOfReservedOutputLabel As System.Windows.Forms.Label
    Public WithEvents NumberOfSeatsOutputLabel As System.Windows.Forms.Label
    Friend WithEvents CancelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ReserveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SeatNumberLabel As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents SeatLabel As System.Windows.Forms.Label
    Friend WithEvents PriceListBoxLabel As System.Windows.Forms.Label
    Friend WithEvents NameListBoxLabel As System.Windows.Forms.Label
    Friend WithEvents ReservationListBox As System.Windows.Forms.ListBox
    Friend WithEvents ShowComboBox As System.Windows.Forms.ComboBox
    Public WithEvents ShowLabel As System.Windows.Forms.Label
    Public WithEvents SeatNumberInput As System.Windows.Forms.Label

End Class
