Option Explicit On

Public Class Rectangle
	Private width As Double
	Private height As Double
	Private area As Double
	Private circum As Double

Public Sub Start()
	ReadInput()
	Calculate()
	ShowResult()
End Sub

Private Sub ReadInput()
	System.Console.WriteLine("State the width and the height of the rectangle you want to calculate:")
	System.Console.WriteLine()
	System.Console.WriteLine("width:   ")
	width=System.Console.ReadLine()
	width=Convert.ToDouble(width)
	System.Console.WriteLine("height:   ")
	height=System.Console.ReadLine()
	height=Convert.ToDOuble(height)
End Sub

Private Sub Calculate()
	area=width*height
	circum=2*(width+height)
End Sub

Private Sub ShowResult()
	System.Console.WriteLine("********* R E S U L T*********")
	System.Console.WriteLine()
	System.Console.WriteLine("Area		: "+area)
	System.Console.WriteLine("Circumference : "+circum)
	System.Console.WriteLine()
End Sub
End Class