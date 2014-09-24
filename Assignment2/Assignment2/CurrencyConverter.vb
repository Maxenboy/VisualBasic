Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04
Public Class CurrencyConverter
    ''' <summary>
    ''' Starts the application currency coonverter
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        Dim total, append, rate As Double
        Dim currency As String

        Console.WriteLine("+++++++++++++++++ Currency converter ++++++++++++++++++++") 'Text output 
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Write 0 to finish!") 'Text output
        Console.WriteLine("Make sure to use the correct decimal character") 'Text output
        Console.WriteLine()
        Do 'A do while loop is used since the number of iterations/summations are unknown
            Console.Write("Write an amount to sum or zero to finish!: ") 'Text output
            append = Convert.ToDouble(Console.ReadLine()) 'Reads the user input to sum
            total += append ' adds the floating number to the toal sum
        Loop While (append <> 0) Or (append <> 0.0) 'stops when the input is 0
        Console.WriteLine()
        Console.Write("Name of the forregin currency: ") 'Text input
        currency = Console.ReadLine() 'Reads the type of currency
        Console.Write("Exchange rate: ") 'Text output
        rate = Convert.ToDouble(Console.ReadLine()) 'Reads the currency rate of the give currency
        Console.WriteLine()
        Console.WriteLine("-------------------------------") 'Text output
        Console.WriteLine("The sum is: " & total & " kr") 'Text output with the total sum
        Console.WriteLine()
        Console.WriteLine(total & " kr is converted to " & total / rate & " " & currency & " at the rate of " & rate & " kr/" & currency) 'Text output with the total sum, converted currency, currency and currency rate
        Console.WriteLine()
        Console.WriteLine()
        Dim menu As Menu = New Menu()
        menu.Start() 'Re-starts the menu
    End Sub
End Class
