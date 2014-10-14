Public Class CalorieCalculator
    Private age As Double
    Private weight As Double
    Private height As Double
    Private male As Boolean
    Private bmr As Double
    Private maintain As Double
    Private Const sedantary As Double = 1.2
    Private Const light As Double = 1.375
    Private Const moderate As Double = 1.55
    Private Const very As Double = 1.725
    Private Const extra As Double = 1.9
    Public Sub New()

    End Sub
    Public Sub ReadInput(input() As String)
        If (input(0) = "True") Then
            male = True
        Else : male = False
        End If
        age = CDbl(input(1))
        height = CDbl(input(2))
        weight = CDbl(input(3))
    End Sub
    Public Function CalculateBMR() As String
        If (male) Then
            bmr = (10 * weight + 6.25 * height + 5 * age) + 5
        Else
            bmr = (10 * weight + 6.25 * height + 5 * age) - 161
        End If
        Return CStr(bmr)
    End Function
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
