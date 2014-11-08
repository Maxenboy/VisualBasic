Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30

''' <summary>
''' The class that represents a contact
''' </summary>
''' <remarks></remarks>
Public Class Contact
    Private m_firstname As String
    Private m_lastname As String
    Private m_address As Address

    ''' <summary>
    ''' A default constructor witch no parameters, chaincalls to the constructor with three parameters
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty, New Address)
    End Sub

    ''' <summary>
    ''' A constructor with three parameters, is called by the default constructor
    ''' </summary>
    ''' <param name="firstName">A contacs firstname</param>
    ''' <param name="lastName">A contacts lastname</param>
    ''' <param name="address">A contacts address</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal address As Address)
        m_firstname = firstName
        m_lastname = lastName
        m_address = address
    End Sub

    ''' <summary>
    ''' A constructor with a contact as parameter, used for copying a contact
    ''' </summary>
    ''' <param name="theOther">The contact that should be copied</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal theOther As Contact)
        Me.m_firstname = theOther.m_firstname
        Me.m_lastname = theOther.m_lastname
        Me.m_address = theOther.m_address
    End Sub

    ''' <summary>
    ''' A property with get and set for the address
    ''' </summary>
    ''' <value></value>
    ''' <returns>This contacts address</returns>
    ''' <remarks></remarks>
    Public Property AddressData() As Address
        Get
            Return m_address
        End Get
        Set(value As Address)
            m_address = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get and set for the firstname
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing this contacts firstname</returns>
    ''' <remarks></remarks>
    Public Property FirstName() As String
        Get
            Return m_firstname
        End Get
        Set(value As String)
            m_firstname = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get and set for the lastname
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing this contacts lastname</returns>
    ''' <remarks></remarks>
    Public Property LastName() As String
        Get
            Return m_lastname
        End Get
        Set(value As String)
            m_lastname = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get for the contacts first- and lastname
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing this contacts first- and lastname</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FullName() As String
        Get
            If lastName = "" Then
                Return firstName
            Else
                Return firstName & " " & lastName
            End If
        End Get
    End Property

    ''' <summary>
    ''' Validates the contacts fields, the address has its own validation, the user needs to specify both first- and lastname
    ''' </summary>
    ''' <returns>True if both first- and lastname are given, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function Validate() As Boolean
        If m_lastname = String.Empty Or m_firstname = String.Empty Then
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Overrides the ToString method, uses String.Format to represent the contacts different fields
    ''' </summary>
    ''' <returns>A string representation of all the contacts fields</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return String.Format("{0,-25}{1}", FullName, m_address.ToString)
    End Function
End Class
