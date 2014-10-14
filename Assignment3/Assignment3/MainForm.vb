Public Class MainForm
    Private carMilage As FuelCalculator = New FuelCalculator()
    Private bmrCalc As CalorieCalculator = New CalorieCalculator()
    Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()

    End Sub
    Public Sub InitializeGUI()
        MaleButton.Checked = True
        SedentaryButton.Checked = True
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles FuelButton.Click
        ClearAll()
        If CDbl(CurrentKM.Text) > CDbl(PreviousKM.Text) Then
            Dim input(3) As String
            input(0) = CurrentKM.Text
            input(1) = PreviousKM.Text
            input(2) = FuelAmount.Text
            input(3) = PricePerLit.Text
            carMilage.ReadInput(input)
            KmPerLit.Text = CStr(carMilage.KMPerLit)
            LitPerMetric.Text = CStr(carMilage.LitPerMetricMile)
            LitPerKm.Text = CStr(carMilage.LitPerKM)
            LitPerMil.Text = CStr(carMilage.LitPerSwedMil)
            CostPerKm.Text = CStr(carMilage.CostPerKM)
        Else
            MsgBox("The previous odometer reading is larger than the current odometer reading, change this!")
        End If
    End Sub
    Private Sub ClearAll()
        KmPerLit.Text = String.Empty
        LitPerKm.Text = String.Empty
        LitPerMetric.Text = String.Empty
        LitPerMil.Text = String.Empty
        CostPerKm.Text = String.Empty
    End Sub

    Private Sub BMRButton_Click(sender As Object, e As EventArgs) Handles BMRButton.Click
        BMRResult.Items.Clear()
        Dim input(3) As String
        input(0) = MaleButton.Checked.ToString
        input(1) = Age.Text
        input(2) = Height.Text
        input(3) = Weight.Text
        bmrCalc.ReadInput(input)
        BMRResult.Items.Add("Your BMR (calories/day)" + vbTab + vbTab + vbTab + bmrCalc.CalculateBMR)
        BMRResult.Items.Add("Calories to maintain your weight" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek)))
        BMRResult.Items.Add("Calories to lose 0,5 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) - 500))
        BMRResult.Items.Add("Calories to lose 1 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) - 1000))
        BMRResult.Items.Add("Calories to gain 0,5 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) + 500))
        BMRResult.Items.Add("Calories to gain 1 kg per week" + vbTab + vbTab + CStr(bmrCalc.CalculateMaintain(ActivityLevelPerWeek) + 1000))
    End Sub

    Private Sub BMRResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BMRResult.SelectedIndexChanged
        SelectionLabel.Text = "Selected item: " + CStr(BMRResult.SelectedIndex + 1)
    End Sub

    Private Sub UnselectButton_Click(sender As Object, e As EventArgs) Handles UnselectButton.Click
        BMRResult.ClearSelected()
        SelectionLabel.Text = "Selected item:"
    End Sub
End Class
