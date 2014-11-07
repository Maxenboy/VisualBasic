Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30

Public Class ContactForm
    Private m_contacts As ContactManager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_contacts = New ContactManager()
        InitializeGUI()

    End Sub
    Private Sub InitializeGUI()
        CountryComboBox.Items.AddRange([Enum].GetNames(GetType(Countries)))
        CountryComboBox.SelectedIndex = DirectCast(Countries.Sverige, Integer)
        DeleteButton.Enabled = False
        ChangeButton.Enabled = False
        UpdateGUI()
    End Sub

    Private Function ReadInput() As Boolean
        Dim contact As New Contact()
        Dim address As Address = ReadAddress()
        contact = New Contact(FirstNameTextBox.Text, LastNameTextBox.Text, address)
        If contact.Validate Then
            If address.Validate Then
                If IsNumeric(address.ZipCode) Or address.ZipCode = String.Empty Then
                    Return m_contacts.AddContact(contact)
                Else
                    MsgBox("The provided zipcode is not numeric, please change to numbers only")
                End If
            Else
                MsgBox(address.errMessage)
            End If
        Else
            MsgBox("Please enter the names for the person you want to add")
        End If
        Return False
    End Function

    Private Function ReadAddress() As Address
        Return New Address(StreetTextBox.Text, ZipCodeTextBox.Text, CityTextBox.Text, DirectCast([Enum].Parse(GetType(Countries), DirectCast(CountryComboBox.SelectedItem, String)), Countries))
    End Function

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ReadInput() Then
            UpdateGUI()
        End If
    End Sub

    Private Sub UpdateTextBoxes()
        Dim contact As Contact = m_contacts.GetContact(ListBox.SelectedIndex)
        CountryComboBox.SelectedIndex = DirectCast(contact.AddressData.Country, Integer)
        FirstNameTextBox.Text = contact.FirstName
        LastNameTextBox.Text = contact.LastName
        StreetTextBox.Text = contact.AddressData.Street
        ZipCodeTextBox.Text = contact.AddressData.ZipCode
        CityTextBox.Text = contact.AddressData.City
    End Sub



    Private Sub UpdateGUI()
        Dim contacts As String() = m_contacts.GetContactInfo
        ListBox.Items.Clear()
        NbrOfRegistredLabel.Text = m_contacts.Count.ToString
        If contacts IsNot Nothing Then
            ListBox.Items.AddRange(contacts)
        End If
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        DeleteButton.Enabled = True
        ChangeButton.Enabled = True
        UpdateTextBoxes()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If m_contacts.DeleteContact(ListBox.SelectedIndex) Then
            UpdateGUI()
        End If
    End Sub
End Class
