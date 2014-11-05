Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30

Public Class ContactManager
    Private m_contactRegister As List(Of Contact)

    Public Sub New()
        m_contactRegister = New List(Of Contact)
    End Sub

    Public Function GetContact(index As Integer) As Contact
        If index > 0 And index < m_contactRegister.Count Then
            Return New Contact(m_contactRegister(index).FirstName, m_contactRegister(index).LastName, m_contactRegister(index).AddressData)
        End If
        Return Nothing
    End Function

    Public ReadOnly Property Count() As Integer
        Get
            Return m_contactRegister.Count
        End Get
    End Property

    Public Function AddContact(firstname As String, lastname As String, address As Address) As Boolean
        Dim contact As Contact = New Contact(firstname, lastname, address)
        If contact.Validate And address.Validate Then
            m_contactRegister.Add(contact)
            Return True
        End If
        Return False
    End Function

    Public Function AddContact(theOther As Contact) As Boolean
        If theOther.Validate Then
            m_contactRegister.Add(theOther)
            Return True
        End If
        Return False
    End Function

    Public Function ChangeContact(contact As Contact, index As Integer) As Boolean
        If contact.Validate Then
            m_contactRegister(index) = contact
            Return True
        End If
        Return False
    End Function

    Public Function DeleteContact(index As Integer) As Boolean
        If index >= 0 And index <= m_contactRegister.Count Then
            m_contactRegister.RemoveAt(index)
            Return True
        End If
        Return False
    End Function

    Public Function GetContactInfo() As String()
        If (m_contactRegister.Count = 0) Then Return Nothing
        Dim array As String() = New String(m_contactRegister.Count - 1) {}
        Dim i As Integer = 0
        For Each Contact As Contact In m_contactRegister
            array(i) = Contact.ToString
            i += 1
        Next
        Return array
    End Function
End Class
