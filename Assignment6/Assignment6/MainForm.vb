Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30

Public Class ContactForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeGUI()
    End Sub
    Public Sub InitializeGUI()
        CountryComboBox.Items.AddRange([Enum].GetNames(GetType(Countries)))
        CountryComboBox.SelectedIndex = DirectCast(Countries.Sverige, Integer)
    End Sub
End Class
