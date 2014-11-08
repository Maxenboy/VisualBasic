Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30

''' <summary>
''' The class that represents the contact registry, uses a list to store all the contacts
''' </summary>
''' <remarks></remarks>
Public Class ContactManager
    Private m_contactRegister As List(Of Contact)

    ''' <summary>
    ''' A default constructor with no parameters
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        m_contactRegister = New List(Of Contact)
    End Sub

    ''' <summary>
    ''' Gets a specific contact from the list/registry with a given index
    ''' </summary>
    ''' <param name="index">The place the contact is stored in the list/registry</param>
    ''' <returns>Returns the specific contact from the list/registry</returns>
    ''' <remarks></remarks>
    Public Function GetContact(index As Integer) As Contact
        If index >= 0 And index < m_contactRegister.Count Then  'A validation that the index isn't out of bounds
            Return New Contact(m_contactRegister(index))
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' A property with get list/registry's amount of contacts/length
    ''' </summary>
    ''' <value></value>
    ''' <returns>Returns the amount of registered contacts</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Count() As Integer
        Get
            Return m_contactRegister.Count
        End Get
    End Property

    ''' <summary>
    ''' Adds a contact to the list/registry
    ''' </summary>
    ''' <param name="firstname">A contacts firstname</param>
    ''' <param name="lastname">A contacts lastname</param>
    ''' <param name="address">A contacts address</param>
    ''' <returns>True if the addition was successful, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function AddContact(firstname As String, lastname As String, address As Address) As Boolean
        Dim contact As Contact = New Contact(firstname, lastname, address)
        If contact.Validate And address.Validate Then
            m_contactRegister.Add(contact)
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Adds a contact to the list/registry
    ''' </summary>
    ''' <param name="theOther">The contact tha will be added to the list/registry</param>
    ''' <returns>True if the addition was successful, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function AddContact(theOther As Contact) As Boolean
        If theOther.Validate Then
            m_contactRegister.Add(theOther)
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Changes an existing contacts values in the list/registry
    ''' </summary>
    ''' <param name="contact">The contact to be changed</param>
    ''' <param name="index">The place of the contact in the list/registry</param>
    ''' <returns>True if the change was successful, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function ChangeContact(contact As Contact, index As Integer) As Boolean
        If contact.Validate Then
            m_contactRegister(index) = contact
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Deletes an existing contact from the list/registry
    ''' </summary>
    ''' <param name="index">The place of the contact in the list/registry to delete</param>
    ''' <returns>True if the deletion was successful, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function DeleteContact(index As Integer) As Boolean
        If index >= 0 And index <= m_contactRegister.Count Then
            m_contactRegister.RemoveAt(index)
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Gets all the registered contacts information from the list/registry
    ''' </summary>
    ''' <returns>An array of strings representing all the contacts information</returns>
    ''' <remarks></remarks>
    Public Function GetContactInfo() As String()
        If (m_contactRegister.Count = 0) Then Return Nothing 'No registered contacts
        Dim array As String() = New String(m_contactRegister.Count - 1) {}
        Dim i As Integer = 0
        For Each Contact As Contact In m_contactRegister
            array(i) = Contact.ToString
            i += 1
        Next
        Return array
    End Function
End Class
