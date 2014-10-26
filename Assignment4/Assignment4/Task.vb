Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-26
''' <summary>
''' The class that represents a task
''' </summary>
''' <remarks></remarks>
Public Class Task
    Private desc As String 'The reminder text description
    Private hour As String 'The hour of the task
    Private day As String 'The day of the task
    Private month As String 'The month of the task
    Private year As String 'The year of the task
    Private priority As String 'The priority of the task
    ''' <summary>
    ''' The constructor of a task, sets the above variables that involve date
    ''' </summary>
    ''' <param name="datum"></param>
    ''' <remarks></remarks>
    Public Sub New(datum As DateTime)
        hour = Format(datum, "HH:mm")
        day = Format(datum, "dd")
        month = Format(datum, "MMMM")
        year = Format(datum, "yyyy")
    End Sub

    ''' <summary>
    ''' Makes a string representation of the different variables of the date
    ''' </summary>
    ''' <returns>A string representation of the different variables of the date</returns>
    ''' <remarks></remarks>
    Private Function dateString() As String
        Return "den " + day + " " + month + " " + year
    End Function
    ''' <summary>
    ''' Sets the priority of the task
    ''' </summary>
    ''' <param name="prio">String from the selected enum priority in the priority combobox</param>
    ''' <remarks></remarks>
    Public Sub setPrio(prio As String)
        Select Case (prio)
            Case "Very_important"
                priority = "Very Important"
            Case "Less_Important"
                priority = "Less Important"
            Case Else
                priority = prio
        End Select
    End Sub
    ''' <summary>
    ''' Sets the tasks text description
    ''' </summary>
    ''' <param name="description">String from the forms textbox</param>
    ''' <remarks></remarks>
    Public Sub setDescription(description As String)
        desc = description
    End Sub
    ''' <summary>
    ''' Makes a String representation of the tasks data
    ''' </summary>
    ''' <returns>A String of the reminders data</returns>
    ''' <remarks></remarks>
    Public Function getToString() As String
        Return String.Format("{0,-22}{1,-7}{2,-16}{3,-100}", dateString(), hour, priority, desc)
    End Function

End Class
