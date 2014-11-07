Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30
Public Class Contact
    Private m_firstname As String
    Private m_lastname As String
    Private m_address As Address

    Public Sub New()
        Me.New(String.Empty, String.Empty, New Address)
    End Sub

    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal address As Address)
        m_firstname = firstName
        m_lastname = lastName
        m_address = address
    End Sub

    Public Sub New(ByVal theOther As Contact)
        Me.m_firstname = theOther.m_firstname
        Me.m_lastname = theOther.m_lastname
        Me.m_address = theOther.m_address
    End Sub

    Public Property AddressData() As Address
        Get
            Return m_address
        End Get
        Set(value As Address)
            m_address = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return m_firstname
        End Get
        Set(value As String)
            m_firstname = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return m_lastname
        End Get
        Set(value As String)
            m_lastname = value
        End Set
    End Property

    Public ReadOnly Property FullName() As String
        Get
            If lastName = "" Then
                Return firstName
            Else
                Return firstName & " " & lastName
            End If
        End Get
    End Property

    Public Function Validate() As Boolean
        If m_lastname = String.Empty Or m_firstname = String.Empty Then
            Return False
        End If
        Return True
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0,-30}{1}", FullName, m_address.ToString)
    End Function
End Class
