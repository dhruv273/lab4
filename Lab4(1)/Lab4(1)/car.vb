Option Strict On
Public Class car
    Private Shared carCount As Integer
    Private carPrice As String = String.Empty
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private cartVeryImportantPersonStatus As Boolean = False
    Private _carIdentificationNumber As Integer = 0
    ''' <summary>
    ''' Constructor - Default - creates a new customer object
    ''' </summary>
    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        _carIdentificationNumber = carCount ' assign the customers id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new customer object
    ''' </summary>
    ''' <param name="Mark"></param>
    ''' <param name="Model"></param>
    ''' <param name="Year"></param>
    ''' <param name="veryImportantPersonStatus"></param>
    Public Sub New(Mark As String, Model As String, Year As String, veryImportantPersonStatus As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()


        carMake = Mark         ' set the car title
        carModel = Model  ' set the car first name
        carYear = Year    ' set the car last name
        cartVeryImportantPersonStatus = veryImportantPersonStatus        ' set the car status
        carPrice = price
    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of car that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific car identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property price() As String
        Get
            Return carPrice
        End Get
    End Property

    ''' <summary>
    ''' VeryImportantPersonStatus Property - >Gets and Sets the Very Important Person status of a car
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property VeryImportantPersonStatus() As Boolean
        Get
            Return cartVeryImportantPersonStatus
        End Get
        Set(ByVal value As Boolean)
            cartVeryImportantPersonStatus = value
        End Set
    End Property

    Public ReadOnly Property CarIdentificationNumber() As Integer
        Get
            Return _CarIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the title of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the first name of a c
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the last name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get

            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "Hi  " & carMake & " " & carModel & " " & carModel & ", " & IIf(cartVeryImportantPersonStatus = True, "I am a VIP", "I am not a VIP").ToString()

    End Function
End Class
