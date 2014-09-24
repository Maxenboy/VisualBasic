Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-09-04

''' <summary>
''' This class contains the back end of the gas station
''' It Takes care of the customers wishes ans calculates the total sum to pay 
''' differing on the quality and quantity of gas
''' It also gives the customer an overview of selected options and prices
''' </summary>
''' <remarks></remarks>
Public Class GasPump

    Private customerName As String 'Declares a ref variable for the customers name
    Private quality As Boolean 'Declares a ref variable for quality of gas     
    Private quantity As Double 'Declares a ref variable for the quantity the customer wants to refuel
    Private totalToPay As Double 'Declares a ref variable for the total sum to pay for the refuel
    Private Const regPrice As Double = 15.05 'Static price for the regular gas
    Private Const primePrice As Double = 15.75 'Static price for the premium gas

    Public Sub Start()
        ReadInput() 'Reads the customers input
        Calculate() 'Calculates the total the customer needs to pay
        PrintReciept() 'Prints the toal amount etc.
    End Sub

    ''' <summary>
    ''' Reads the customers name and choices 
    ''' Gives appropriate feedback and questions
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadInput()
        ReadName() 'Reads customer name
        ReadQuantity() 'Reads how many liter the customer wants to refuel
        ReadQuality() 'Reads the quality of the gas (Premium/Regular)
    End Sub

    ''' <summary>
    ''' Calculates the total sum to pay for the quantity and quality of the gas the customer has chosen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Calculate()
        If (quality) Then   'Checks which quality of gas that's been choosen 
            totalToPay = primePrice * quantity
        Else
            totalToPay = regPrice * quantity
        End If
    End Sub

    ''' <summary>
    ''' Prints the overview of the choosen options and the sum to pay for the refueling
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PrintReciept()
        Console.WriteLine("********************** WELCOME TO APU'S GAS STATION **************************")
        Console.WriteLine()
        If (quality) Then 'Checks which quality of gas that's been choosen
            Console.WriteLine("Quality" & vbTab & vbTab & vbTab & "Premium") 'vtab is the sign for a tab in a String
            Console.WriteLine("Quantity (l)" & vbTab & vbTab & quantity)
            Console.WriteLine("Price per l" & vbTab & vbTab & +primePrice)
            Console.WriteLine("Sum to pay" & vbTab & vbTab & +totalToPay)
            Console.WriteLine()
            Console.WriteLine("********************** PLEASE COME AGAIN " + customerName + "! *********************************")
        Else
            Console.WriteLine("Quality" & vbTab & vbTab & vbTab & "Regular")
            Console.WriteLine("Quantity (l)" & vbTab & vbTab & quantity)
            Console.WriteLine("Price per l" & vbTab & vbTab & +regPrice)
            Console.WriteLine("Sum to pay" & vbTab & vbTab & +totalToPay)
            Console.WriteLine()
            Console.WriteLine("********************** PLEASE COME AGAIN " + customerName + "! *********************************")
        End If


    End Sub

    ''' <summary>
    ''' Reads the customers name and gives an appropriate reply
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadName()
        Console.Write("Please let me know your nick name: ")
        customerName = Console.ReadLine()
        Console.WriteLine("Thank you very much " + customerName + "!")
        Console.WriteLine()
    End Sub

    ''' <summary>
    ''' Reads how many liters the customer wants to refuel
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadQuantity()
        Console.WriteLine("How many liters " + customerName + " (only whole liters please)?")
        quantity = CDbl(Console.ReadLine())
    End Sub

    ''' <summary>
    ''' Reads the quality of the gas the customer wants
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadQuality()
        Dim response As Char
        Console.Write("Premium quality? (y/n): ")
        response = Console.ReadLine().Chars(0)
        If ((response = "y") Or (response = "Y")) Then
            quality = True
        Else
            quality = False
        End If
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

    End Sub
End Class

