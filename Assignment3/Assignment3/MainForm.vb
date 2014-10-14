Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-14
''' <summary>
''' The class that creates the form for FuelCalculator and CalorieCalculator
''' </summary>
''' <remarks></remarks>
Public Class MainForm
    Private carMilage As FuelCalculator = New FuelCalculator()      'Global variable for the FuelCalculator
    Private bmrCalc As CalorieCalculator = New CalorieCalculator()  'Global variable for the CalorieCalculator
    ''' <summary>
    ''' Constructor for the form
    ''' Initialises the form
    ''' Initialises the default values of the controls
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub
    ''' <summary>
    ''' Initialises the default values of the controls
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub InitializeGUI()
        MaleButton.Checked = True
        SedentaryButton.Checked = True
    End Sub
    ''' <summary>
    ''' The methods that is called when the user clicks the FuelCalculators calculate button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles FuelButton.Click
        ClearAll()
        If CDbl(CurrentKM.Text) > CDbl(PreviousKM.Text) Then        'Checks if the previous odometer reading is less then the current
            Dim input(3) As String
            input(0) = CurrentKM.Text
            input(1) = PreviousKM.Text
            input(2) = FuelAmount.Text
            input(3) = PricePerLit.Text
            carMilage.ReadInput(input)                              'Reads the input from the Fuelcalculator part of the form
            KmPerLit.Text = CStr(carMilage.KMPerLit)                'Sets the km per liter the fueltank/car can drive
            LitPerMetric.Text = CStr(carMilage.LitPerMetricMile)    'Sets the liter per km the fueltank/car uses
            LitPerKm.Text = CStr(carMilage.LitPerKM)                'Sets the liter per metric mile the fueltank/car uses
            LitPerMil.Text = CStr(carMilage.LitPerSwedMil)          'Sets the liter per swedish mile the fueltank/car uses
            CostPerKm.Text = CStr(carMilage.CostPerKM)              'Sets the cost per km the fueltank/car costs
        Else
            MsgBox("The previous odometer reading is larger than the current odometer reading, change this!") 'If the previous odometer reading is greater then the current, a messagebox apppears with an appropriate text
        End If
    End Sub
    ''' <summary>
    ''' Clears all the FuelCalculators control values
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearAll()
        KmPerLit.Text = String.Empty
        LitPerKm.Text = String.Empty
        LitPerMetric.Text = String.Empty
        LitPerMil.Text = String.Empty
        CostPerKm.Text = String.Empty
    End Sub
    ''' <summary>
    ''' The methods that is called when the user clicks the CalorieCalculators calculate button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BMRButton_Click(sender As Object, e As EventArgs) Handles BMRButton.Click
        BMRResult.Items.Clear()     'Clears the ListBox's item/rows of text
        Dim input(3) As String
        input(0) = MaleButton.Checked.ToString
        input(1) = Age.Text
        input(2) = Height.Text
        input(3) = Weight.Text
        bmrCalc.ReadInput(input)    'Reads the input from the Caloriecalculator part of the form
        BMRResult.Items.Add("Your BMR (calories/day)" + vbTab + vbTab + vbTab + bmrCalc.CalculateBMR)
        BMRResult.Items.Add("Calories to maintain your weight" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek)))
        BMRResult.Items.Add("Calories to lose 0,5 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) - 500))
        BMRResult.Items.Add("Calories to lose 1 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) - 1000))
        BMRResult.Items.Add("Calories to gain 0,5 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) + 500))
        BMRResult.Items.Add("Calories to gain 1 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) + 1000))
    End Sub
    ''' <summary>
    ''' The method that is called when a row is clicked/selected in the ListBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BMRResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BMRResult.SelectedIndexChanged
        SelectionLabel.Text = "Selected item: " + CStr(BMRResult.SelectedIndex + 1)
    End Sub
    ''' <summary>
    ''' The method that is called when the unselect button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub UnselectButton_Click(sender As Object, e As EventArgs) Handles UnselectButton.Click
        BMRResult.ClearSelected()
        SelectionLabel.Text = "Selected item:"
    End Sub
End Class
