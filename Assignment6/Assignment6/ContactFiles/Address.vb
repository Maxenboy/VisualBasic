Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30

Public Class Address
    Private m_city As String
    Private m_zipCode As String
    Private m_street As String
    Private m_country As Countries
    Private m_errMessage As String
    Public Sub New()
        Me.New(String.Empty, String.Empty, String.Empty)
    End Sub
    Public Sub New(ByVal street As String, ByVal zip As String, ByVal city As String)
        Me.New(street, zip, city, Countries.Sverige)
    End Sub

    Public Sub New(ByVal street As String, ByVal zip As String, ByVal city As String, ByVal country As Countries)
        Me.m_city = city
        Me.m_street = street
        Me.m_zipCode = zip
        Me.m_country = country
    End Sub

    Public Sub New(theOther As Address)
        Me.m_city = theOther.m_city
        Me.m_street = theOther.m_street
        Me.m_zipCode = theOther.m_zipCode
        Me.m_country = theOther.m_country
    End Sub

    Public Property City() As String
        Get
            Return m_city
        End Get
        Set(value As String)
            m_city = value
        End Set
    End Property

    Public Property Country() As Countries
        Get
            Return m_country
        End Get
        Set(value As Countries)
            m_country = value
        End Set
    End Property

    Public Property Street() As String
        Get
            Return m_street
        End Get
        Set(value As String)
            m_street = value
        End Set
    End Property

    Public Property ZipCode() As String
        Get
            Return m_zipCode
        End Get
        Set(value As String)
            m_zipCode = value
        End Set
    End Property

    Public ReadOnly Property errMessage() As String
        Get
            Return m_errMessage
        End Get
    End Property

    Public Function Validate() As Boolean
        If m_city = String.Empty Then
            m_errMessage = "No city is provided, please do so"
            Return False
        End If
        Return True
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0,-40}{1,-10}{2,-10}{3,-10}", m_street, m_zipCode, m_city, m_country)
    End Function
End Class
