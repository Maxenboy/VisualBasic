Public Class FuelCalculator
    Private km As Double
    Private lit As Double
    Private price As Double
    Private Const kmToMileFactor As Double = 0.621371192
    Public Sub New()

    End Sub
    Public Sub ReadInput(input As String())
        km = CDbl(input(0)) - CDbl(input(1))
        lit = CDbl(input(2))
        price = CDbl(input(3))
    End Sub
    Public Function KMPerLit() As Double
        Return km / lit
    End Function
    Public Function LitPerKM() As Double
        Return lit / km
    End Function
    Public Function LitPerMetricMile() As Double
        Return LitPerKM() / kmToMileFactor
    End Function
    Public Function LitPerSwedMil() As Double
        Return LitPerKM() * 10
    End Function
    Public Function CostPerKM() As Double
        Return LitPerKM() * price
    End Function

End Class
