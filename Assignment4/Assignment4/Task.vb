Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-26
Public Class Task
    Private desc As String
    Private hour As String
    Private day As String
    Private month As String
    Private year As String
    Private priority As PriorityTypes

    Public Sub New(datum As DateTime)
        hour = Format(datum, "HH:00")
        day = Format(datum, "dd")
        month = Format(datum, "MMMM")
        year = Format(datum, "yyyy")
    End Sub


    Private Function dateString() As String
        Return "den " + day + " " + month + " " + year
    End Function
    Public Sub setPrio(prio As String)

    End Sub
    Public Sub setDescription(description As String)
        desc = description
    End Sub
    Public Function getToString() As String
        Return dateString() + vbTab + hour
    End Function

End Class
