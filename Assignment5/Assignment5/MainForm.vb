
Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30
''' <summary>
''' The class of the form
''' </summary>
''' <remarks></remarks>
Public Class MainForm
    Dim seatManager As SeatManager
    Dim nbrOfSeats As Integer = 80
    ''' <summary>
    ''' Constructor of the form
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub
    ''' <summary>
    ''' The default settings of the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeGUI()
        seatManager = New SeatManager(nbrOfSeats)
        ReservationListBox.Items.Clear()
        ReserveRadioButton.Checked = True
        ShowComboBox.Items.AddRange([Enum].GetNames(GetType(DisplayOption.typeOfSeats)))
        ShowComboBox.SelectedIndex = 0
        updateListBox(seatManager.fillListBox())
        NameBox.Select()
    End Sub
    ''' <summary>
    ''' When the radioButton "Cancel" is clicked, it should not be possible to edit price and name.
    ''' It also changes the text on the button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CancelRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CancelRadioButton.CheckedChanged
        ReserveButton.Text = "Cancel"
        NameBox.Enabled = False
        PriceBox.Enabled = False
    End Sub
    ''' <summary>
    ''' When the radioButton "Reserve" is clicked, it should be possible to edit price and name.
    ''' It also changes the text on the button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ReserveRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ReserveRadioButton.CheckedChanged
        ReserveButton.Text = "Reserve"
        NameBox.Enabled = True
        PriceBox.Enabled = True
    End Sub
    ''' <summary>
    ''' When a row is clicked/selected in the listbox the seat number is put in the seat number input
    ''' If the clicked/selected seat isn't vacant the name and price input is updated with data
    ''' Otherwise the name and price input is cleared 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ReservationListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReservationListBox.SelectedIndexChanged
        SeatNumberInput.Text = ReservationListBox.SelectedItem.ToString.Substring(0, 6)
        If Not seatManager.isvacant(ReservationListBox.SelectedItem.ToString.Substring(0, 6)) Then
            NameBox.Text = seatManager.getName(ReservationListBox.SelectedItem.ToString.Substring(0, 6))
            PriceBox.Text = seatManager.getPrice(ReservationListBox.SelectedItem.ToString.Substring(0, 6))
        Else
            NameBox.Clear()
            PriceBox.Clear()
        End If
    End Sub
    ''' <summary>
    ''' When the reserved/cancel button is clicked it will either cancel a reservation or reserve a seta, depending on which radiobutton is checked
    ''' All input is validated and will give an appropriate message if the input doesn't match the standards
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ReserveButton_Click(sender As Object, e As EventArgs) Handles ReserveButton.Click
        If SeatNumberInput.Text.Length = 0 Then                                 'If there isn't a seat number input
            MsgBox("Please select a seat in the listbox")
        ElseIf PriceBox.Text.Length = 0 Then                                    'If there isn't a price input                   
            MsgBox("Please enter a price")
        ElseIf Not IsNumeric(PriceBox.Text) Then                                'If the price input is something else than a number
            MsgBox("Please enter only numbers in the price input.")
        ElseIf NameBox.Text.Trim.Length = 0 Or CDbl(PriceBox.Text) < 0 Then     'If the name is empty or the price is negative
            Dim msg = "Can't have an empty name or neagtive price"
            Dim title = "Think twice"
            Dim style = MsgBoxStyle.OkCancel
            MsgBox(msg, style, title)

        Else
            If ReserveRadioButton.Checked Then                                  'If the reserve radiobutton is checked
                Dim reserve As Boolean = False
                If seatManager.isvacant(SeatNumberInput.Text) Then              'If the clicked seat is vacant, reserve
                    ReservationListBox.Items.Clear()
                    updateListBox(seatManager.reserve(SeatNumberInput.Text, NameBox.Text, CDbl(PriceBox.Text)))
                Else                                                            'Else ask if the  user wants to overwrite
                    Dim msg = "This seat is already reserved. Continue?"
                    Dim title = "Think twice"
                    Dim style = MsgBoxStyle.OkCancel
                    Dim response = MsgBox(msg, style, title)
                    If response = MsgBoxResult.Ok Then                          'If Ok, reserve
                        ReservationListBox.Items.Clear()
                        updateListBox(seatManager.reserve(SeatNumberInput.Text, NameBox.Text, CDbl(PriceBox.Text)))
                    Else                                                        'Else, empty the input fields
                        SeatNumberInput.Text = ""
                        NameBox.Clear()
                        PriceBox.Clear()
                        NameBox.Select()
                    End If
                End If
            Else                                                                'Else (the cancel radiobutton is checked), ask if the user wants to cancel
                Dim msg = "Are you sure you want to cancel this reservation"
                Dim title = "Think twice"
                Dim style = MsgBoxStyle.OkCancel
                Dim response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Ok Then                              'If Ok, cancel reservation
                    ReservationListBox.Items.Clear()
                    updateListBox(seatManager.cancel(SeatNumberInput.Text))
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Updates the Listbox in the GUI
    ''' </summary>
    ''' <param name="result">A String array with the data</param>
    ''' <remarks></remarks>
    Private Sub updateListBox(result As String())
        For index As Integer = 0 To result.Length - 1
            ReservationListBox.Items.Add(result(index))
        Next
        updateLabels(seatManager.getInfo)
    End Sub
    ''' <summary>
    ''' Updates the status labels for number of seats, number of vacant seats and number of reserved seats
    ''' </summary>
    ''' <param name="result">A String array with the data</param>
    ''' <remarks></remarks>
    Public Sub updateLabels(result As String())
        NumberOfSeatsOutputLabel.Text = result(0)
        NumberOfReservedOutputLabel.Text = result(1)
        NumberOfVacantOutputLabel.Text = result(2)
    End Sub
    ''' <summary>
    ''' When a user changes the selected preview in the Combobox, the ListBox will change its content
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ShowComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShowComboBox.SelectedIndexChanged
        Select Case ShowComboBox.SelectedItem.ToString
            Case "All_Seats"
                ReserveButton.Enabled = True
                ReservationListBox.Items.Clear()
                updateListBox(seatManager.fillListBox)
            Case "Vacant_Seats"
                ReserveButton.Enabled = False
                ReservationListBox.Items.Clear()
                updateListBox(seatManager.showVacantOrReserved("Vacant"))
            Case "Reserved_Seats"
                ReserveButton.Enabled = False
                ReservationListBox.Items.Clear()
                updateListBox(seatManager.showVacantOrReserved("Reserved"))
        End Select
    End Sub
End Class
