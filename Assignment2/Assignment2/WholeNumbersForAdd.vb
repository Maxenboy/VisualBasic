Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04
Public Class WholeNumbersForAdd
    ''' <summary>
    '''  Starts the application summation of whole numbers using a for-statement
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        Dim sums As String
        Dim total As Long
        Console.WriteLine("*******************Summation of whole numbers*******************") 'Text output
        Console.WriteLine("                    using a for-statement") 'Text output
        Console.WriteLine()
        Console.Write("Number of values to sum? ") 'Text output
        sums = Console.ReadLine() 'Reads the number of summations the application skould do
        For counter = 0 To Convert.ToInt32(sums) - 1 ' Since the number of iteratons is known a for-loop is used
            Console.Write("Please give the value no ") 'Text output
            Console.Write(counter + 1) 'Text output
            Console.Write(" (whole number): ") 'Text output
            total += Convert.ToInt32(Console.ReadLine()) 'Sums up the given whole numbers
        Next
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
