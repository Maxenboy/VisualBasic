
Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30
Public Class MainForm
    Dim seatManager As SeatManager
    Dim nbrOfSeats As Integer = 80
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub

    Public Sub InitializeGUI()
        seatManager = New SeatManager(nbrOfSeats)
        ReservationListBox.Items.Clear()
        ReserveRadioButton.Checked = True
        ShowComboBox.Items.AddRange([Enum].GetNames(GetType(DisplayOption.typeOfSeats)))
        ShowComboBox.SelectedIndex = 0
        updateListBox(seatManager.fillListBox())
        NameBox.Select()
    End Sub

    Private Sub CancelRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CancelRadioButton.CheckedChanged
        ReserveButton.Text = "Cancel"
        NameBox.Enabled = False
        PriceBox.Enabled = False
    End Sub

    Private Sub ReserveRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ReserveRadioButton.CheckedChanged
        ReserveButton.Text = "Reserve"
        NameBox.Enabled = True
        PriceBox.Enabled = True
    End Sub

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

    Private Sub ReserveButton_Click(sender As Object, e As EventArgs) Handles ReserveButton.Click
        If SeatNumberInput.Text.Length = 0 Then
            MsgBox("Please select a seat in the listbox")
        ElseIf PriceBox.Text.Length = 0 Then
            MsgBox("Please enter a price")
        ElseIf Not IsNumeric(PriceBox.Text) Then
            MsgBox("Please enter only numbers in the price input.")
        ElseIf NameBox.Text.Trim.Length = 0 Or CDbl(PriceBox.Text) < 0 Then
            Dim msg = "Can't have an empty name or neagtive price"
            Dim title = "Think twice"
            Dim style = MsgBoxStyle.OkCancel
            MsgBox(msg, style, title)

        Else
            If ReserveRadioButton.Checked Then
                Dim reserve As Boolean = False
                If seatManager.isvacant(SeatNumberInput.Text) Then
                    ReservationListBox.Items.Clear()
                    updateListBox(seatManager.reserve(SeatNumberInput.Text, NameBox.Text, CDbl(PriceBox.Text)))
                Else
                    Dim msg = "This seat is already reserved. Continue?"
                    Dim title = "Think twice"
                    Dim style = MsgBoxStyle.OkCancel
                    Dim response = MsgBox(msg, style, title)
                    If response = MsgBoxResult.Ok Then
                        ReservationListBox.Items.Clear()
                        updateListBox(seatManager.reserve(SeatNumberInput.Text, NameBox.Text, CDbl(PriceBox.Text)))
                    Else
                        SeatNumberInput.Text = ""
                        NameBox.Clear()
                        PriceBox.Clear()
                        NameBox.Select()
                    End If
                End If
            Else
                Dim msg = "Are you sure you want to cancel this reservation"
                Dim title = "Think twice"
                Dim style = MsgBoxStyle.OkCancel
                Dim response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Ok Then
                    ReservationListBox.Items.Clear()
                    updateListBox(seatManager.cancel(SeatNumberInput.Text, NameBox.Text, CDbl(PriceBox.Text)))
                End If
            End If
        End If
    End Sub
    Private Sub updateListBox(result As String())
        For index As Integer = 0 To result.Length - 1
            ReservationListBox.Items.Add(result(index))
        Next
        updateLabels(seatManager.getInfo)
    End Sub
    Public Sub updateLabels(result As String())
        NumberOfSeatsOutputLabel.Text = result(0)
        NumberOfReservedOutputLabel.Text = result(1)
        NumberOfVacantOutputLabel.Text = result(2)
    End Sub

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
