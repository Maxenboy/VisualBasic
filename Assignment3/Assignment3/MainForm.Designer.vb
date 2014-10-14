<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Fuel = New System.Windows.Forms.GroupBox()
        Me.FuelButton = New System.Windows.Forms.Button()
        Me.PreviousLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.PricePerLiterLabel = New System.Windows.Forms.Label()
        Me.CurrentLabel = New System.Windows.Forms.Label()
        Me.PreviousKM = New System.Windows.Forms.TextBox()
        Me.FuelAmount = New System.Windows.Forms.TextBox()
        Me.PricePerLit = New System.Windows.Forms.TextBox()
        Me.CurrentKM = New System.Windows.Forms.TextBox()
        Me.Results = New System.Windows.Forms.GroupBox()
        Me.CostPerKm = New System.Windows.Forms.Label()
        Me.LitPerMetric = New System.Windows.Forms.Label()
        Me.LitPerKm = New System.Windows.Forms.Label()
        Me.LitPerMil = New System.Windows.Forms.Label()
        Me.KmPerLit = New System.Windows.Forms.Label()
        Me.CostPerKmLabel = New System.Windows.Forms.Label()
        Me.LitPerMetricLabel = New System.Windows.Forms.Label()
        Me.LitPerKmLabel = New System.Windows.Forms.Label()
        Me.LitPerMilLabel = New System.Windows.Forms.Label()
        Me.KmPerLitLabel = New System.Windows.Forms.Label()
        Me.BMR = New System.Windows.Forms.GroupBox()
        Me.UnselectButton = New System.Windows.Forms.Button()
        Me.SelectionLabel = New System.Windows.Forms.Label()
        Me.BMRButton = New System.Windows.Forms.Button()
        Me.BMRResult = New System.Windows.Forms.ListBox()
        Me.ActivityLevelPerWeek = New System.Windows.Forms.GroupBox()
        Me.VeryButton = New System.Windows.Forms.RadioButton()
        Me.ExtraButton = New System.Windows.Forms.RadioButton()
        Me.ModerateButton = New System.Windows.Forms.RadioButton()
        Me.LightlyButton = New System.Windows.Forms.RadioButton()
        Me.SedentaryButton = New System.Windows.Forms.RadioButton()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.TextBox()
        Me.Weight = New System.Windows.Forms.TextBox()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.FemaleButton = New System.Windows.Forms.RadioButton()
        Me.MaleButton = New System.Windows.Forms.RadioButton()
        Me.Fuel.SuspendLayout()
        Me.Results.SuspendLayout()
        Me.BMR.SuspendLayout()
        Me.ActivityLevelPerWeek.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fuel
        '
        Me.Fuel.Controls.Add(Me.FuelButton)
        Me.Fuel.Controls.Add(Me.PreviousLabel)
        Me.Fuel.Controls.Add(Me.AmountLabel)
        Me.Fuel.Controls.Add(Me.PricePerLiterLabel)
        Me.Fuel.Controls.Add(Me.CurrentLabel)
        Me.Fuel.Controls.Add(Me.PreviousKM)
        Me.Fuel.Controls.Add(Me.FuelAmount)
        Me.Fuel.Controls.Add(Me.PricePerLit)
        Me.Fuel.Controls.Add(Me.CurrentKM)
        Me.Fuel.Controls.Add(Me.Results)
        Me.Fuel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Fuel.Location = New System.Drawing.Point(0, 0)
        Me.Fuel.Name = "Fuel"
        Me.Fuel.Size = New System.Drawing.Size(371, 300)
        Me.Fuel.TabIndex = 0
        Me.Fuel.TabStop = False
        Me.Fuel.Text = "Fuel"
        '
        'FuelButton
        '
        Me.FuelButton.Location = New System.Drawing.Point(86, 117)
        Me.FuelButton.Name = "FuelButton"
        Me.FuelButton.Size = New System.Drawing.Size(75, 23)
        Me.FuelButton.TabIndex = 5
        Me.FuelButton.Text = "Calculate"
        Me.FuelButton.UseVisualStyleBackColor = True
        '
        'PreviousLabel
        '
        Me.PreviousLabel.AutoSize = True
        Me.PreviousLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PreviousLabel.Location = New System.Drawing.Point(5, 42)
        Me.PreviousLabel.Name = "PreviousLabel"
        Me.PreviousLabel.Size = New System.Drawing.Size(156, 13)
        Me.PreviousLabel.TabIndex = 8
        Me.PreviousLabel.Text = "Previous odometer reading (km)"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AmountLabel.Location = New System.Drawing.Point(6, 68)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(141, 13)
        Me.AmountLabel.TabIndex = 7
        Me.AmountLabel.Text = "Amount of fuel tanked (liters)"
        '
        'PricePerLiterLabel
        '
        Me.PricePerLiterLabel.AutoSize = True
        Me.PricePerLiterLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PricePerLiterLabel.Location = New System.Drawing.Point(6, 94)
        Me.PricePerLiterLabel.Name = "PricePerLiterLabel"
        Me.PricePerLiterLabel.Size = New System.Drawing.Size(68, 13)
        Me.PricePerLiterLabel.TabIndex = 6
        Me.PricePerLiterLabel.Text = "Price per liter"
        '
        'CurrentLabel
        '
        Me.CurrentLabel.AutoSize = True
        Me.CurrentLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrentLabel.Location = New System.Drawing.Point(6, 16)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(149, 13)
        Me.CurrentLabel.TabIndex = 5
        Me.CurrentLabel.Text = "Current odometer reading (km)"
        '
        'PreviousKM
        '
        Me.PreviousKM.Location = New System.Drawing.Point(161, 39)
        Me.PreviousKM.Name = "PreviousKM"
        Me.PreviousKM.Size = New System.Drawing.Size(100, 20)
        Me.PreviousKM.TabIndex = 2
        '
        'FuelAmount
        '
        Me.FuelAmount.Location = New System.Drawing.Point(161, 65)
        Me.FuelAmount.Name = "FuelAmount"
        Me.FuelAmount.Size = New System.Drawing.Size(100, 20)
        Me.FuelAmount.TabIndex = 3
        '
        'PricePerLit
        '
        Me.PricePerLit.Location = New System.Drawing.Point(161, 91)
        Me.PricePerLit.Name = "PricePerLit"
        Me.PricePerLit.Size = New System.Drawing.Size(100, 20)
        Me.PricePerLit.TabIndex = 4
        '
        'CurrentKM
        '
        Me.CurrentKM.Location = New System.Drawing.Point(161, 13)
        Me.CurrentKM.Name = "CurrentKM"
        Me.CurrentKM.Size = New System.Drawing.Size(100, 20)
        Me.CurrentKM.TabIndex = 1
        '
        'Results
        '
        Me.Results.Controls.Add(Me.CostPerKm)
        Me.Results.Controls.Add(Me.LitPerMetric)
        Me.Results.Controls.Add(Me.LitPerKm)
        Me.Results.Controls.Add(Me.LitPerMil)
        Me.Results.Controls.Add(Me.KmPerLit)
        Me.Results.Controls.Add(Me.CostPerKmLabel)
        Me.Results.Controls.Add(Me.LitPerMetricLabel)
        Me.Results.Controls.Add(Me.LitPerKmLabel)
        Me.Results.Controls.Add(Me.LitPerMilLabel)
        Me.Results.Controls.Add(Me.KmPerLitLabel)
        Me.Results.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Results.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Results.Location = New System.Drawing.Point(8, 138)
        Me.Results.Name = "Results"
        Me.Results.Size = New System.Drawing.Size(357, 152)
        Me.Results.TabIndex = 0
        Me.Results.TabStop = False
        Me.Results.Text = "Results"
        '
        'CostPerKm
        '
        Me.CostPerKm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostPerKm.AutoSize = True
        Me.CostPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CostPerKm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CostPerKm.Location = New System.Drawing.Point(251, 124)
        Me.CostPerKm.MinimumSize = New System.Drawing.Size(100, 0)
        Me.CostPerKm.Name = "CostPerKm"
        Me.CostPerKm.Size = New System.Drawing.Size(100, 15)
        Me.CostPerKm.TabIndex = 10
        '
        'LitPerMetric
        '
        Me.LitPerMetric.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LitPerMetric.AutoSize = True
        Me.LitPerMetric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LitPerMetric.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LitPerMetric.Location = New System.Drawing.Point(251, 50)
        Me.LitPerMetric.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LitPerMetric.Name = "LitPerMetric"
        Me.LitPerMetric.Size = New System.Drawing.Size(100, 15)
        Me.LitPerMetric.TabIndex = 7
        '
        'LitPerKm
        '
        Me.LitPerKm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LitPerKm.AutoSize = True
        Me.LitPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LitPerKm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LitPerKm.Location = New System.Drawing.Point(251, 76)
        Me.LitPerKm.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LitPerKm.Name = "LitPerKm"
        Me.LitPerKm.Size = New System.Drawing.Size(100, 15)
        Me.LitPerKm.TabIndex = 8
        '
        'LitPerMil
        '
        Me.LitPerMil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LitPerMil.AutoSize = True
        Me.LitPerMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LitPerMil.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LitPerMil.Location = New System.Drawing.Point(251, 102)
        Me.LitPerMil.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LitPerMil.Name = "LitPerMil"
        Me.LitPerMil.Size = New System.Drawing.Size(100, 15)
        Me.LitPerMil.TabIndex = 9
        '
        'KmPerLit
        '
        Me.KmPerLit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KmPerLit.AutoSize = True
        Me.KmPerLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KmPerLit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KmPerLit.Location = New System.Drawing.Point(251, 24)
        Me.KmPerLit.MinimumSize = New System.Drawing.Size(100, 0)
        Me.KmPerLit.Name = "KmPerLit"
        Me.KmPerLit.Size = New System.Drawing.Size(100, 15)
        Me.KmPerLit.TabIndex = 6
        '
        'CostPerKmLabel
        '
        Me.CostPerKmLabel.AutoSize = True
        Me.CostPerKmLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CostPerKmLabel.Location = New System.Drawing.Point(4, 126)
        Me.CostPerKmLabel.Name = "CostPerKmLabel"
        Me.CostPerKmLabel.Size = New System.Drawing.Size(91, 13)
        Me.CostPerKmLabel.TabIndex = 16
        Me.CostPerKmLabel.Text = "Cost per kilometer"
        '
        'LitPerMetricLabel
        '
        Me.LitPerMetricLabel.AutoSize = True
        Me.LitPerMetricLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LitPerMetricLabel.Location = New System.Drawing.Point(3, 52)
        Me.LitPerMetricLabel.Name = "LitPerMetricLabel"
        Me.LitPerMetricLabel.Size = New System.Drawing.Size(160, 13)
        Me.LitPerMetricLabel.TabIndex = 13
        Me.LitPerMetricLabel.Text = "Fuel consumption (lit/metric mile)"
        '
        'LitPerKmLabel
        '
        Me.LitPerKmLabel.AutoSize = True
        Me.LitPerKmLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LitPerKmLabel.Location = New System.Drawing.Point(4, 78)
        Me.LitPerKmLabel.Name = "LitPerKmLabel"
        Me.LitPerKmLabel.Size = New System.Drawing.Size(125, 13)
        Me.LitPerKmLabel.TabIndex = 12
        Me.LitPerKmLabel.Text = "Fuel consumption (lit/km)"
        '
        'LitPerMilLabel
        '
        Me.LitPerMilLabel.AutoSize = True
        Me.LitPerMilLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LitPerMilLabel.Location = New System.Drawing.Point(4, 104)
        Me.LitPerMilLabel.Name = "LitPerMilLabel"
        Me.LitPerMilLabel.Size = New System.Drawing.Size(153, 13)
        Me.LitPerMilLabel.TabIndex = 11
        Me.LitPerMilLabel.Text = "Fuel consumption (lit/Swe mile)"
        '
        'KmPerLitLabel
        '
        Me.KmPerLitLabel.AutoSize = True
        Me.KmPerLitLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KmPerLitLabel.Location = New System.Drawing.Point(4, 26)
        Me.KmPerLitLabel.Name = "KmPerLitLabel"
        Me.KmPerLitLabel.Size = New System.Drawing.Size(125, 13)
        Me.KmPerLitLabel.TabIndex = 10
        Me.KmPerLitLabel.Text = "Fuel consumption (km/lit)"
        '
        'BMR
        '
        Me.BMR.Controls.Add(Me.UnselectButton)
        Me.BMR.Controls.Add(Me.SelectionLabel)
        Me.BMR.Controls.Add(Me.BMRButton)
        Me.BMR.Controls.Add(Me.BMRResult)
        Me.BMR.Controls.Add(Me.ActivityLevelPerWeek)
        Me.BMR.Controls.Add(Me.HeightLabel)
        Me.BMR.Controls.Add(Me.WeightLabel)
        Me.BMR.Controls.Add(Me.AgeLabel)
        Me.BMR.Controls.Add(Me.Height)
        Me.BMR.Controls.Add(Me.Weight)
        Me.BMR.Controls.Add(Me.Age)
        Me.BMR.Controls.Add(Me.FemaleButton)
        Me.BMR.Controls.Add(Me.MaleButton)
        Me.BMR.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BMR.Location = New System.Drawing.Point(0, 306)
        Me.BMR.Name = "BMR"
        Me.BMR.Size = New System.Drawing.Size(597, 310)
        Me.BMR.TabIndex = 1
        Me.BMR.TabStop = False
        Me.BMR.Text = "BMR"
        '
        'UnselectButton
        '
        Me.UnselectButton.Location = New System.Drawing.Point(513, 281)
        Me.UnselectButton.Name = "UnselectButton"
        Me.UnselectButton.Size = New System.Drawing.Size(75, 23)
        Me.UnselectButton.TabIndex = 19
        Me.UnselectButton.Text = "Unselect"
        Me.UnselectButton.UseVisualStyleBackColor = True
        '
        'SelectionLabel
        '
        Me.SelectionLabel.AutoSize = True
        Me.SelectionLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SelectionLabel.Location = New System.Drawing.Point(277, 281)
        Me.SelectionLabel.Name = "SelectionLabel"
        Me.SelectionLabel.Size = New System.Drawing.Size(74, 13)
        Me.SelectionLabel.TabIndex = 18
        Me.SelectionLabel.Text = "Selected item:"
        '
        'BMRButton
        '
        Me.BMRButton.Location = New System.Drawing.Point(99, 281)
        Me.BMRButton.Name = "BMRButton"
        Me.BMRButton.Size = New System.Drawing.Size(75, 23)
        Me.BMRButton.TabIndex = 17
        Me.BMRButton.Text = "Calculate"
        Me.BMRButton.UseVisualStyleBackColor = True
        '
        'BMRResult
        '
        Me.BMRResult.FormattingEnabled = True
        Me.BMRResult.Location = New System.Drawing.Point(280, 95)
        Me.BMRResult.Name = "BMRResult"
        Me.BMRResult.Size = New System.Drawing.Size(308, 160)
        Me.BMRResult.TabIndex = 10
        '
        'ActivityLevelPerWeek
        '
        Me.ActivityLevelPerWeek.Controls.Add(Me.VeryButton)
        Me.ActivityLevelPerWeek.Controls.Add(Me.ExtraButton)
        Me.ActivityLevelPerWeek.Controls.Add(Me.ModerateButton)
        Me.ActivityLevelPerWeek.Controls.Add(Me.LightlyButton)
        Me.ActivityLevelPerWeek.Controls.Add(Me.SedentaryButton)
        Me.ActivityLevelPerWeek.Location = New System.Drawing.Point(7, 130)
        Me.ActivityLevelPerWeek.Name = "ActivityLevelPerWeek"
        Me.ActivityLevelPerWeek.Size = New System.Drawing.Size(254, 130)
        Me.ActivityLevelPerWeek.TabIndex = 16
        Me.ActivityLevelPerWeek.TabStop = False
        Me.ActivityLevelPerWeek.Text = "Activity level per week"
        '
        'VeryButton
        '
        Me.VeryButton.AutoSize = True
        Me.VeryButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VeryButton.Location = New System.Drawing.Point(3, 85)
        Me.VeryButton.Name = "VeryButton"
        Me.VeryButton.Size = New System.Drawing.Size(141, 17)
        Me.VeryButton.TabIndex = 8
        Me.VeryButton.TabStop = True
        Me.VeryButton.Text = "Very active (6 to 7 times)"
        Me.VeryButton.UseVisualStyleBackColor = True
        '
        'ExtraButton
        '
        Me.ExtraButton.AutoSize = True
        Me.ExtraButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExtraButton.Location = New System.Drawing.Point(3, 108)
        Me.ExtraButton.Name = "ExtraButton"
        Me.ExtraButton.Size = New System.Drawing.Size(190, 17)
        Me.ExtraButton.TabIndex = 9
        Me.ExtraButton.TabStop = True
        Me.ExtraButton.Text = "Extra active, hard excercises or job"
        Me.ExtraButton.UseVisualStyleBackColor = True
        '
        'ModerateButton
        '
        Me.ModerateButton.AutoSize = True
        Me.ModerateButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ModerateButton.Location = New System.Drawing.Point(3, 62)
        Me.ModerateButton.Name = "ModerateButton"
        Me.ModerateButton.Size = New System.Drawing.Size(172, 17)
        Me.ModerateButton.TabIndex = 7
        Me.ModerateButton.TabStop = True
        Me.ModerateButton.Text = "Moderately active (3 to 5 times)"
        Me.ModerateButton.UseVisualStyleBackColor = True
        '
        'LightlyButton
        '
        Me.LightlyButton.AutoSize = True
        Me.LightlyButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LightlyButton.Location = New System.Drawing.Point(3, 39)
        Me.LightlyButton.Name = "LightlyButton"
        Me.LightlyButton.Size = New System.Drawing.Size(150, 17)
        Me.LightlyButton.TabIndex = 6
        Me.LightlyButton.TabStop = True
        Me.LightlyButton.Text = "Lightly active (1 to 3 times)"
        Me.LightlyButton.UseVisualStyleBackColor = True
        '
        'SedentaryButton
        '
        Me.SedentaryButton.AutoSize = True
        Me.SedentaryButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SedentaryButton.Location = New System.Drawing.Point(3, 16)
        Me.SedentaryButton.Name = "SedentaryButton"
        Me.SedentaryButton.Size = New System.Drawing.Size(175, 17)
        Me.SedentaryButton.TabIndex = 5
        Me.SedentaryButton.TabStop = True
        Me.SedentaryButton.Text = "Sedentary (little or no excercise)"
        Me.SedentaryButton.UseVisualStyleBackColor = True
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HeightLabel.Location = New System.Drawing.Point(4, 72)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(61, 13)
        Me.HeightLabel.TabIndex = 14
        Me.HeightLabel.Text = "Height (cm)"
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WeightLabel.Location = New System.Drawing.Point(5, 98)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(62, 13)
        Me.WeightLabel.TabIndex = 13
        Me.WeightLabel.Text = "Weight (kg)"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AgeLabel.Location = New System.Drawing.Point(5, 46)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 12
        Me.AgeLabel.Text = "Age"
        '
        'Height
        '
        Me.Height.Location = New System.Drawing.Point(160, 69)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(100, 20)
        Me.Height.TabIndex = 3
        '
        'Weight
        '
        Me.Weight.Location = New System.Drawing.Point(160, 95)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(100, 20)
        Me.Weight.TabIndex = 4
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(160, 43)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(100, 20)
        Me.Age.TabIndex = 2
        '
        'FemaleButton
        '
        Me.FemaleButton.AutoSize = True
        Me.FemaleButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FemaleButton.Location = New System.Drawing.Point(99, 16)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleButton.TabIndex = 2
        Me.FemaleButton.TabStop = True
        Me.FemaleButton.Text = "Female"
        Me.FemaleButton.UseVisualStyleBackColor = True
        '
        'MaleButton
        '
        Me.MaleButton.AutoSize = True
        Me.MaleButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaleButton.Location = New System.Drawing.Point(3, 16)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleButton.TabIndex = 1
        Me.MaleButton.TabStop = True
        Me.MaleButton.Text = "Male"
        Me.MaleButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 623)
        Me.Controls.Add(Me.BMR)
        Me.Controls.Add(Me.Fuel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "MainForm"
        Me.Text = "Calculators"
        Me.Fuel.ResumeLayout(False)
        Me.Fuel.PerformLayout()
        Me.Results.ResumeLayout(False)
        Me.Results.PerformLayout()
        Me.BMR.ResumeLayout(False)
        Me.BMR.PerformLayout()
        Me.ActivityLevelPerWeek.ResumeLayout(False)
        Me.ActivityLevelPerWeek.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fuel As System.Windows.Forms.GroupBox
    Friend WithEvents FuelButton As System.Windows.Forms.Button
    Friend WithEvents PreviousLabel As System.Windows.Forms.Label
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents PricePerLiterLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentLabel As System.Windows.Forms.Label
    Friend WithEvents PreviousKM As System.Windows.Forms.TextBox
    Friend WithEvents FuelAmount As System.Windows.Forms.TextBox
    Friend WithEvents PricePerLit As System.Windows.Forms.TextBox
    Friend WithEvents CurrentKM As System.Windows.Forms.TextBox
    Friend WithEvents Results As System.Windows.Forms.GroupBox
    Friend WithEvents BMR As System.Windows.Forms.GroupBox
    Friend WithEvents CostPerKm As System.Windows.Forms.Label
    Friend WithEvents LitPerMetric As System.Windows.Forms.Label
    Friend WithEvents LitPerKm As System.Windows.Forms.Label
    Friend WithEvents LitPerMil As System.Windows.Forms.Label
    Friend WithEvents KmPerLit As System.Windows.Forms.Label
    Friend WithEvents CostPerKmLabel As System.Windows.Forms.Label
    Friend WithEvents LitPerMetricLabel As System.Windows.Forms.Label
    Friend WithEvents LitPerKmLabel As System.Windows.Forms.Label
    Friend WithEvents LitPerMilLabel As System.Windows.Forms.Label
    Friend WithEvents KmPerLitLabel As System.Windows.Forms.Label
    Friend WithEvents ActivityLevelPerWeek As System.Windows.Forms.GroupBox
    Friend WithEvents VeryButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExtraButton As System.Windows.Forms.RadioButton
    Friend WithEvents ModerateButton As System.Windows.Forms.RadioButton
    Friend WithEvents LightlyButton As System.Windows.Forms.RadioButton
    Friend WithEvents SedentaryButton As System.Windows.Forms.RadioButton
    Friend WithEvents HeightLabel As System.Windows.Forms.Label
    Friend WithEvents WeightLabel As System.Windows.Forms.Label
    Friend WithEvents AgeLabel As System.Windows.Forms.Label
    Friend WithEvents Height As System.Windows.Forms.TextBox
    Friend WithEvents Weight As System.Windows.Forms.TextBox
    Friend WithEvents Age As System.Windows.Forms.TextBox
    Friend WithEvents FemaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents MaleButton As System.Windows.Forms.RadioButton
    Friend WithEvents BMRResult As System.Windows.Forms.ListBox
    Friend WithEvents BMRButton As System.Windows.Forms.Button
    Friend WithEvents UnselectButton As System.Windows.Forms.Button
    Friend WithEvents SelectionLabel As System.Windows.Forms.Label

End Class
