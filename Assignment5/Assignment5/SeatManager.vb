Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-28
Public Class SeatManager
    Private seats As Integer
    Private m_nameList As String()
    Private m_priceList As Double()
    Private status As String()
    Public Sub New(ByVal maxNbrOfSeats As Integer)
        seats = maxNbrOfSeats
        m_nameList = New String(maxNbrOfSeats) {}
        m_priceList = New Double(maxNbrOfSeats) {}
        status = New String(maxNbrOfSeats) {}
        For index As Integer = 0 To maxNbrOfSeats
            m_nameList(index) = ".............."
            m_priceList(index) = 0.0
            status(index) = "Vacant"
        Next

    End Sub

    Public Function fillListBox() As String()
        Dim result As String() = New String(seats) {}
        For index As Integer = 0 To seats
            result(index) = (String.Format("{0,-6}{1,-10}{2,-35}{3,-20}", index, status(index), m_nameList(index), m_priceList(index).ToString))
        Next
        Return result
    End Function
    Public Function getName(index As String) As String
        Return m_nameList(CInt(index))
    End Function
    Public Function getPrice(index As String) As String
        Return m_priceList(CInt(index)).ToString
    End Function
    Public Function reserve(seat As String, name As String, price As Double) As String()
        status(CInt(seat)) = "Reserved"
        m_nameList(CInt(seat)) = name
        m_priceList(CInt(seat)) = price
        Return fillListBox()
    End Function
    Public Function cancel(seat As String, name As String, price As Double) As String()
        status(CInt(seat)) = "Vacant"
        m_nameList(CInt(seat)) = ".............."
        m_priceList(CInt(seat)) = 0.0
        Return fillListBox()
    End Function
    Public Function isvacant(seat As String) As Boolean
        If status(CInt(seat)) = "Vacant" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function getInfo() As String()
        Dim array As String() = New String(2) {}
        array(0) = (seats + 1).ToString
        array(1) = getNbr("Reserved")
        array(2) = getNbr("Vacant")
        Return array
    End Function
    Public Function getNbr(desc As String) As String
        Dim count As Integer = 0
        For index As Integer = 0 To status.Length - 1
            If status(index) = desc Then
                count += 1
            End If
        Next
        Return count.ToString
    End Function
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
