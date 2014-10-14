Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-14
''' <summary>
''' The class that reads input from the form and calculates the different functions such as cost per km etc.
''' </summary>
''' <remarks></remarks>
Public Class FuelCalculator
    Private km As Double    'global variables for the car's attributes 
    Private lit As Double
    Private price As Double
    Private Const kmToMileFactor As Double = 0.621371192    'global constant for metric mile 
    ''' <summary>
    ''' Constructor for the FuelCalculator
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub
    ''' <summary>
    ''' Reads the input from the form and sets the global variables
    ''' </summary>
    ''' <param name="input"> The argument is a vector with strings, it's elements are converted to double with CDbl</param>
    ''' <remarks></remarks>
    Public Sub ReadInput(input As String())
        km = CDbl(input(0)) - CDbl(input(1))
        lit = CDbl(input(2))
        price = CDbl(input(3))
    End Sub
    ''' <summary>
    ''' Calculates the km per liter the fueltank/car can drive
    ''' </summary>
    ''' <returns>Returns a Double value for km per liter</returns>
    ''' <remarks></remarks>
    Public Function KMPerLit() As Double
        Return km / lit
    End Function
    ''' <summary>
    ''' Calculates the liter per km the fueltank/car uses
    ''' </summary>
    ''' <returns>Returns a Double value for liter per km</returns>
    ''' <remarks></remarks>
    Public Function LitPerKM() As Double
        Return lit / km
    End Function
    ''' <summary>
    ''' Calculates the liter per metric mile the fueltank/car uses
    ''' </summary>
    ''' <returns>Returns a Double value for liter per metric mile</returns>
    ''' <remarks></remarks>
    Public Function LitPerMetricMile() As Double
        Return LitPerKM() / kmToMileFactor
    End Function
    ''' <summary>
    ''' Calculates the liter per swedish mile the fueltank/car uses
    ''' </summary>
    ''' <returns>Returns a Double value for liter per swedish mile</returns>
    ''' <remarks></remarks>
    Public Function LitPerSwedMil() As Double
        Return LitPerKM() * 10
    End Function
    ''' <summary>
    ''' Calculates the cost per km the fueltank/car costs
    ''' </summary>
    ''' <returns>Returns a Double value for cost per km</returns>
    ''' <remarks></remarks>
    Public Function CostPerKM() As Double
        Return LitPerKM() * price
    End Function

End Class
