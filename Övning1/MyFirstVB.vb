Module HelloWorld 
 Sub Main() 
	Dim name As String
	Dim d As DateTime
	d=System.DateTime.Now()
 	System.Console.WriteLine("What is Your Name?")
	name=System.Console.ReadLine()
	System.Console.WriteLine("Oh, hi "+name+ " How are you today?") 
	System.Console.WriteLine("The date is now: den "+Format(d,"dd mmmm yyyy"))
	System.Console.WriteLine("The time is now: den "+Format(d,"hh:mm:ss"))
 End Sub 
End Module 