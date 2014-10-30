Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30
''' <summary>
''' The class thata manages the reservations and cancelations
''' </summary>
''' <remarks></remarks>
Public Class SeatManager
    Private seats As Integer
    Private m_nameList As String()
    Private m_priceList As Double()
    Private status As String()
    ''' <summary>
    ''' The constructor of the seat manager
    ''' </summary>
    ''' <param name="maxNbrOfSeats"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal maxNbrOfSeats As Integer)
        seats = maxNbrOfSeats
        m_nameList = New String(maxNbrOfSeats) {}
        m_priceList = New Double(maxNbrOfSeats) {}
        status = New String(maxNbrOfSeats) {}
        For index As Integer = 0 To maxNbrOfSeats               'fills the arrays with deafult values
            m_nameList(index) = ".............."
            m_priceList(index) = 0.0
            status(index) = "Vacant"
        Next
    End Sub
    ''' <summary>
    ''' Fills an array with updated values from the different arrays in a formated string
    ''' </summary>
    ''' <returns>An updated array</returns>
    ''' <remarks></remarks>
    Public Function fillListBox() As String()
        Dim result As String() = New String(seats) {}
        For index As Integer = 0 To seats
            result(index) = (String.Format("{0,-6}{1,-10}{2,-35}{3,-20}", index, status(index), m_nameList(index), m_priceList(index).ToString))
        Next
        Return result
    End Function
    ''' <summary>
    ''' Gets the name of a reservation
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns>The name of a reservation</returns>
    ''' <remarks></remarks>
    Public Function getName(index As String) As String
        Return m_nameList(CInt(index))
    End Function
    ''' <summary>
    ''' Gets the price of a reservation
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns>The price of a reservation</returns>
    ''' <remarks></remarks>
    Public Function getPrice(index As String) As String
        Return m_priceList(CInt(index)).ToString
    End Function
    ''' <summary>
    ''' Simluates a reservation by changing the status, the name and the price in seperate arrays
    ''' </summary>
    ''' <param name="seat">the seat (index in the arrays) of the reservation</param>
    ''' <param name="name">the name provided by the user</param>
    ''' <param name="price">the price provided by the user</param>
    ''' <returns>The updated array</returns>
    ''' <remarks></remarks>
    Public Function reserve(seat As String, name As String, price As Double) As String()
        status(CInt(seat)) = "Reserved"
        m_nameList(CInt(seat)) = name
        m_priceList(CInt(seat)) = price
        Return fillListBox()
    End Function
    ''' <summary>
    ''' Simluates a cancelation of a reservation by changing the status, the name and the price in seperate arrays to default values
    ''' </summary>
    ''' <param name="seat">the seat (index in the arrays) of the reservation</param>
    ''' <returns>The updated array</returns>
    ''' <remarks></remarks>
    Public Function cancel(seat As String) As String()
        status(CInt(seat)) = "Vacant"
        m_nameList(CInt(seat)) = ".............."
        m_priceList(CInt(seat)) = 0.0
        Return fillListBox()
    End Function
    ''' <summary>
    ''' Checks if a seat is vacant
    ''' </summary>
    ''' <param name="seat">The seat to check</param>
    ''' <returns>True or false</returns>
    ''' <remarks></remarks>
    Public Function isvacant(seat As String) As Boolean
        If status(CInt(seat)) = "Vacant" Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Checks the different states of the seats
    ''' </summary>
    ''' <returns>A String array with the number of seats, vacant seats and reserved seats</returns>
    ''' <remarks></remarks>
    Public Function getInfo() As String()
        Dim array As String() = New String(2) {}
        array(0) = (seats + 1).ToString
        array(1) = getNbr("Reserved")
        array(2) = getNbr("Vacant")
        Return array
    End Function
    ''' <summary>
    ''' Gets the number of vacant and reserved seats
    ''' </summary>
    ''' <param name="desc">The state of the seat</param>
    ''' <returns>The number of vacant and reserved seats</returns>
    ''' <remarks></remarks>
    Public Function getNbr(desc As String) As String
        Dim count As Integer = 0
        For index As Integer = 0 To status.Length - 1
            If status(index) = desc Then
                count += 1
            End If
        Next
        Return count.ToString
    End Function
    ''' <summary>
    ''' Creates an array with only the seats of a certain state
    ''' </summary>
    ''' <param name="type">The state of seats to show</param>
    ''' <returns>An array with seat information</returns>
    ''' <remarks></remarks>
    Public Function showVacantOrReserved(type As String) As String()
        Dim result As String() = New String(seats) {}
        Dim index As Integer = 0
        For i As Integer = 0 To seats
            If status(i) = type Then
                result(index) = String.Format("{0,-6}{1,-10}{2,-35}{3,-20}", i, status(i), m_nameList(i), m_priceList(i))
                index += 1
            End If
        Next
        ReDim Preserve result(index - 1)
        Return result
    End Function
End Class
