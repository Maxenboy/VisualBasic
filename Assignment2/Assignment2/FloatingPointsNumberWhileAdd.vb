Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04
Public Class FloatingPointsNumberWhileAdd
    ''' <summary>
    ''' ' Starts the application summation of real numbers using a while-statement
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        Dim total, append As Double
        Console.WriteLine("*******************Summation of real numbers*******************") 'Text output
        Console.WriteLine("                    using a while-statement") 'Text output
        Console.WriteLine()
        Console.WriteLine("Write 0 to finish!") 'Text output
        Console.WriteLine("Make sure to use the correct decimal character") 'Text output
        Console.WriteLine("--------------------------------------------------------------------") 'Text output
        Console.WriteLine()
        Console.Write("Write an amount to sum or zero to finish!: ") 'Text output
        append = Convert.ToDouble(Console.ReadLine()) 'Reads the first floating number to sum
        While (append <> 0) Or (append <> 0.0) 'A while-loop is used since the number of iterations/summations are unknown, stops when the input is 0
            total += append ' adds the floating number to the toal sum
            Console.Write("Write an amount to sum or zero to finish!: ") 'Text output
            append = Convert.ToDouble(Console.ReadLine()) 'Reads the user input to sum
        End While
        Console.WriteLine("-------------------------------") 'Text output
        Console.WriteLine()
        Console.Write("The sum is: ") 'Text output
        Console.Write(total) 'Text output with the total sum
        Console.WriteLine()
        Console.WriteLine()
        Dim menu As Menu = New Menu()
        menu.Start() 'Re-starts the menu
    End Sub
End Class
