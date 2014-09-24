Option Explicit Off
Option Strict On

' Created: By Max Åberg 2014-09-04
Module MainProgram
    ''' <summary>
    ''' This is where the program begins when it starts
    ''' </summary>
    ''' <remarks></remarks>
    Sub Main()
        Dim menu As Menu = New Menu()
        menu.Start()

        'Makes the Console window wait on the screen by putting it in a read-mode
        Console.ReadKey()
    End Sub

End Module
