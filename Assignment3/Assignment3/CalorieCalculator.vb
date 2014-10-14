Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-14
''' <summary>
''' The class that reads input from the form and calculates the persons bmr and weightgaining/loss depending on activity level
''' </summary>
''' <remarks></remarks>
Public Class CalorieCalculator
    Private age As Double   'global variables for a persons body attributes
    Private weight As Double
    Private height As Double
    Private male As Boolean
    Private bmr As Double
    Private maintain As Double
    Private Const sedantary As Double = 1.2 'global constants for activitylevel per week
    Private Const light As Double = 1.375
    Private Const moderate As Double = 1.55
    Private Const very As Double = 1.725
    Private Const extra As Double = 1.9
    ''' <summary>
    ''' Constructor for the CalorieCalculator
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub
    ''' <summary>
    ''' Reads the input from the form and sets the global variables
    ''' </summary>
    ''' <param name="input">The argument is a vector with strings, it is converted to double with CDbl</param>
    ''' <remarks></remarks>
    Public Sub ReadInput(input() As String)
        If (input(0) = "True") Then
            male = True
        Else : male = False
        End If
        age = CDbl(input(1))
        height = CDbl(input(2))
        weight = CDbl(input(3))
    End Sub
    ''' <summary>
    ''' Calculates the persons bmr
    ''' </summary>
    ''' <returns>Returns a String with the bmr</returns>
    ''' <remarks></remarks>
    Public Function CalculateBMR() As String
        If (male) Then
            bmr = (10 * weight + 6.25 * height + 5 * age) + 5
        Else
            bmr = (10 * weight + 6.25 * height + 5 * age) - 161
        End If
        Return CStr(bmr)
    End Function
    ''' <summary>
    ''' Calculates the amount of calories to take in to maintain the current weight
    ''' </summary>
    ''' <param name="group">The argument is the groupbox that contains the different radiobuttons for the activitylevel per week</param>
    ''' <returns>Returns a Double value of calories to take in to maintain the current weight</returns>
    ''' <remarks></remarks>
    Public Function CalculateMaintain(group As GroupBox) As Double
        Dim level As String = ""
        For Each control As RadioButton In group.Controls
            If control.GetType.Name = "RadioButton" Then
                Dim radio As RadioButton = control
                If (radio.Checked) Then
                    level = radio.Text
                End If
            End If
        Next

        If level.Contains("Sedentary") Then
            maintain = bmr * sedantary
        ElseIf level.Contains("Light") Then
            maintain = bmr * light
        ElseIf level.Contains("Mod") Then
            maintain = bmr * moderate
        ElseIf level.Contains("Very") Then
            maintain = bmr * very
        Else
            maintain = bmr * extra
        End If

        Return maintain
    End Function
End Class
