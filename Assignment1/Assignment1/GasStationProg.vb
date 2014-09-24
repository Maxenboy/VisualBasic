Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04

''' <summary>
''' This program is made for pay-at-pump- gas staation. It interacts
''' with the customer and calculates the amount to be paid before filling up the car  
''' </summary>
''' <remarks></remarks>
Module GasStationProg
    ''' <summary>
    ''' This is where the program begins when it starts
    ''' </summary>
    ''' <remarks></remarks>
    Sub Main()
        Console.Title = "Apu's Gas Station"
        Dim pump As GasPump 'Declares a ref variable for the pump
        pump = New GasPump() 'Creates the actual pump (object)
        pump.Start() 'Starts the interaction with a customer


        'Makes the Console window wait on the screen by putting it in a read-mode
        Console.ReadKey()

    End Sub

End Module
