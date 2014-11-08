Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30
''' <summary>
''' The class representing the form 
''' </summary>
''' <remarks></remarks>
Public Class ContactForm
    Private m_contacts As ContactManager

    ''' <summary>
    ''' Constructor of the form
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_contacts = New ContactManager()
        InitializeGUI()

    End Sub

    ''' <summary>
    '''  The default settings of the GUI
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitializeGUI()
        CountryComboBox.Items.AddRange([Enum].GetNames(GetType(Countries)))
        CountryComboBox.SelectedIndex = DirectCast(Countries.Sverige, Integer)
        DeleteButton.Enabled = False
        ChangeButton.Enabled = False
        UpdateGUI()
    End Sub

    ''' <summary>
    ''' Reads the input in the form, gives appropriate messages if the input doesn't match the prerequisites
    ''' </summary>
    ''' <returns>True if the input is accepted, False otherwise</returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Reads the address input from the form 
    ''' </summary>
    ''' <returns>An address with the given inputs as values</returns>
    ''' <remarks></remarks>
    Private Function ReadAddress() As Address
        Return New Address(StreetTextBox.Text, ZipCodeTextBox.Text, CityTextBox.Text, DirectCast([Enum].Parse(GetType(Countries), DirectCast(CountryComboBox.SelectedItem, String)), Countries)) 'Casts the object returned from the country combobox to a enum country
    End Function

    ''' <summary>
    ''' When the add button is clicked, the inputs are read and added as a new contact in the registry. 
    ''' The visual representation of the registry is then updated
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ReadInput() Then
            UpdateGUI()
        End If
    End Sub

    ''' <summary>
    ''' Updates all the input fields with values from a selected contact in the combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateTextBoxes()
        Dim contact As Contact = m_contacts.GetContact(ListBox.SelectedIndex)
        CountryComboBox.SelectedIndex = DirectCast(contact.AddressData.Country, Integer)
        FirstNameTextBox.Text = contact.FirstName
        LastNameTextBox.Text = contact.LastName
        StreetTextBox.Text = contact.AddressData.Street
        ZipCodeTextBox.Text = contact.AddressData.ZipCode
        CityTextBox.Text = contact.AddressData.City
    End Sub

    ''' <summary>
    ''' Updates the visual representation of the registry in the form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateGUI()
        Dim contacts As String() = m_contacts.GetContactInfo
        ListBox.Items.Clear()
        NbrOfRegistredLabel.Text = m_contacts.Count.ToString
        If contacts IsNot Nothing Then
            ListBox.Items.AddRange(contacts)
        End If
    End Sub

    ''' <summary>
    ''' When a contact/row is selected in the ListBox the input fields are updated
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        DeleteButton.Enabled = True
        ChangeButton.Enabled = True
        UpdateTextBoxes()
    End Sub

    ''' <summary>
    ''' When the delete button is clicked the selected row/contact in the forms ListBox is deleted from the registry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If m_contacts.DeleteContact(ListBox.SelectedIndex) Then
            UpdateGUI()
        End If
    End Sub

    ''' <summary>
    ''' When the change button is clicked the selected row/contact in the forms ListBox is changed with the values given in the textboxes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Dim contact As Contact = New Contact(FirstNameTextBox.Text, LastNameTextBox.Text, ReadAddress)
        If m_contacts.ChangeContact(contact, ListBox.SelectedIndex) Then
            UpdateGUI()
        End If
    End Sub
End Class
