Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04
''' <summary>
''' This is the main menu of the application. A menu with 5 choices is displayed
'''  on the screen and, depending on the users input, the respective operation is
'''  executed by creating an objectn of the respective class.
''' </summary>
''' <remarks></remarks>
Public Class Menu
    ''' <summary>
    ''' Displays the menu alternatives for the user.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        Console.WriteLine("---------------------------------------")
        Console.WriteLine("               MAIN MENU               ")
        Console.WriteLine("---------------------------------------")
        Console.WriteLine("Whole Number with For                :1")
        Console.WriteLine("Floating Point Numbers with While    :2")
        Console.WriteLine("Currency Converter with Do While loop:3")
        Console.WriteLine("Work Schedule                        :4")
        Console.WriteLine("Exit the Program                     :5")
        Console.WriteLine("---------------------------------------")
        Read() ' Reads the users choice of application
    End Sub
    Private Sub Read()
        Dim reply As String
        Dim ok As Boolean = False
        Do While (Not ok) ' Asks the user for the choice of application and loops until approved choice is choosen
            Console.Write("Your choice: ")
            reply = Console.ReadLine()
            Select Case reply
                Case "1" ' Starts the application summation of whole numbers using a for-statement
                    Dim whole As WholeNumbersForAdd = New WholeNumbersForAdd()
                    Console.WriteLine()
                    Console.WriteLine()
                    whole.Start()
                    ok = True
                    Exit Select
                Case "2" ' Starts the application summation of real numbers using a while-statement
                    Dim float As FloatingPointsNumberWhileAdd = New FloatingPointsNumberWhileAdd()
                    Console.WriteLine()
                    Console.WriteLine()
                    float.Start()
                    ok = True
                    Exit Select
                Case "3" ' Starts the application currency coonverter
                    Dim currency As CurrencyConverter = New CurrencyConverter()
                    Console.WriteLine()
                    Console.WriteLine()
                    currency.Start()
                    ok = True
                    Exit Select
                Case "4" ' Starts the application working schedule
                    Dim schedule As WorkingSchedule = New WorkingSchedule()
                    Console.WriteLine()
                    Console.WriteLine()
                    schedule.Start()
                    ok = True
                    Exit Select
                Case "5" ' Closes the program
                    Environment.Exit(0)
                    ok = True
            End Select
        Loop
    End Sub
End Class
