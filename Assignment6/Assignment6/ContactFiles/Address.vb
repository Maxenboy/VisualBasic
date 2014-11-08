Option Explicit On
Option Strict On

' Created: By Max Åberg 2014-10-30
''' <summary>
''' The class that represents a contacts address
''' </summary>
''' <remarks></remarks>
Public Class Address
    Private m_city As String
    Private m_zipCode As String
    Private m_street As String
    Private m_country As Countries
    Private m_errMessage As String

    ''' <summary>
    ''' A default constructor witch no parameters, chaincalls to the constructor with three parameters
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty, String.Empty)
    End Sub

    ''' <summary>
    ''' A constructor with three parameters, is called by the default constructor, chaincalls to the constructor with four parameters
    ''' </summary>
    ''' <param name="street">A contacts street</param>
    ''' <param name="zip">A contacts zipcode</param>
    ''' <param name="city">A contacts city</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal street As String, ByVal zip As String, ByVal city As String)
        Me.New(street, zip, city, Countries.Sverige)
    End Sub

    ''' <summary>
    ''' A constructor with four parameters, is called by the constructor with three parameters
    ''' </summary>
    ''' <param name="street">A contacts street</param>
    ''' <param name="zip">A contacts zipcode</param>
    ''' <param name="city">A contacts city</param>
    ''' <param name="country">A contacs country</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal street As String, ByVal zip As String, ByVal city As String, ByVal country As Countries)
        Me.m_city = city
        Me.m_street = street
        Me.m_zipCode = zip
        Me.m_country = country
    End Sub

    ''' <summary>
    ''' A constructor with an address as parameter, used for copying address
    ''' </summary>
    ''' <param name="theOther">The address that should be copied</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal theOther As Address)
        Me.m_city = theOther.m_city
        Me.m_street = theOther.m_street
        Me.m_zipCode = theOther.m_zipCode
        Me.m_country = theOther.m_country
    End Sub

    ''' <summary>
    ''' A property with get and set for the city
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing the city</returns>
    ''' <remarks></remarks>
    Public Property City() As String
        Get
            Return m_city
        End Get
        Set(value As String)
            m_city = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get and set for the country
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representating the country</returns>
    ''' <remarks></remarks>
    Public Property Country() As Countries
        Get
            Return m_country
        End Get
        Set(value As Countries)
            m_country = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get and set for the street
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing the street</returns>
    ''' <remarks></remarks>
    Public Property Street() As String
        Get
            Return m_street
        End Get
        Set(value As String)
            m_street = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get and set for the zipcode
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing the zipcode</returns>
    ''' <remarks></remarks>
    Public Property ZipCode() As String
        Get
            Return m_zipCode
        End Get
        Set(value As String)
            m_zipCode = value
        End Set
    End Property

    ''' <summary>
    ''' A property with get for an errormessage
    ''' </summary>
    ''' <value></value>
    ''' <returns>A string representing an error message</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property errMessage() As String
        Get
            Return m_errMessage
        End Get
    End Property

    ''' <summary>
    ''' Validates the addresses fields, the user needs to specify at least a city
    ''' </summary>
    ''' <returns>True if a city is given, False otherwise</returns>
    ''' <remarks></remarks>
    Public Function Validate() As Boolean
        If m_city = String.Empty Then
            m_errMessage = "No city is provided, please do so"
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Overrides the ToString method, uses String.Format to represent the addresse's different fields
    ''' </summary>
    ''' <returns>A string representation of all the addresses fields</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return String.Format("{0,-35}{1,-7}{2,-20}{3,-15}", m_street, m_zipCode, m_city, m_country)
    End Function
End Class
