Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04
Public Class WorkingSchedule
    ''' <summary>
    ''' Starts the application working schedule where there's options to choose from
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        Dim reply As String
        Dim ok As Boolean = False
        Console.WriteLine("                     YOUR SCHEDULE PROGRAM") 'Text output
        Console.WriteLine("Select from the menu wich type of schedule you would like to see.") 'Text output
        Console.WriteLine("-----------------------------------------------------------------") 'Text output
        Console.WriteLine()
        Console.WriteLine("1 Show a list of the weekends to work") 'Text output
        Console.WriteLine("2 Show a list of the nights to work") 'Text output
        Console.WriteLine("0 Return to Main Menu") 'Text output
        Console.WriteLine()
        Console.WriteLine()
        Do While (Not ok)
            Console.Write("Your choice: ") 'Text output
            reply = Console.ReadLine() 'Reads the users choice of wich kind of schedule that should be visualized
            Select Case reply
                Case "1" 'Shows a list of the weekends to work
                    Console.WriteLine()
                    Console.WriteLine("Your schedule  of the above option is as follows:") 'Text output
                    Console.WriteLine()
                    Dim count As Integer = 0 'Counter for text columns
                    For counter = 1 To 52 Step 3 'A for-loop is used with the step 3 since it's only every 3rd week 
                        Console.Write(vbTab & "Week " & counter) 'Text output with the weeks the user works
                        count += 1 'Increments the counter for outputs on same row
                        If count Mod 3 = 0 Then 'After every third iteration a new line is used
                            Console.WriteLine()
                        End If
                    Next
                    count = 0
                    Console.WriteLine()
                    Exit Select
                Case "2" 'Shows a list of the nights to work
                    Console.WriteLine()
                    Console.WriteLine("Your schedule  of the above option is as follows:") 'Text output
                    Console.WriteLine()
                    Dim count As Integer = 0 'Counter for text columns
                    For counter = 6 To 52 Step 5 'A for-loop is used with the step 5 since it's only every 5th week
                        Console.Write(vbTab & "Week " & counter) 'Text output with the weeks the user works
                        count += 1 'Increments the counter for outputs on same row
                        If count Mod 3 = 0 Then 'After every third iteration a new line is used
                            Console.WriteLine()
                        End If
                    Next
                    Console.WriteLine()
                    Exit Select
                Case "0" 'Return to the Main Menu
                    Console.WriteLine()
                    Dim menu As Menu = New Menu()
                    menu.Start() 'Re-starts the menu
                    Exit Select
            End Select

        Loop
    End Sub
End Class
