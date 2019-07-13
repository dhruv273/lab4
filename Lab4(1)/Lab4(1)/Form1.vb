Option Strict On
''' <summary>
''' Name= dhruv vyas
''' project name= CarInventory
''' Date= 12/7/2019
''' </summary>
Public Class frmCarInventory

    Private carList As New SortedList                                 ' collection of all the carList in the list
    Private currentCardentificationNumber As String = String.Empty ' current selected car identification number
    Private editMode As Boolean = False                                 '

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a car object will be create using the  
    '''                - parameterized constructor. It will also insert the new car details
    '''                
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific car object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As car        ' declare a Car class
        Dim carItem As ListViewItem    ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lblResult.Text = "It worked!"


            If currentCardentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New car(cmbMake.Text, txtModel.Text, cmbYear.Text, chkNew.Checked)

                carList.Add(car.CarIdentificationNumber.ToString(), car)

            Else
                ' if the current car identification number has a value
                ' then the user has selected something from the list view
                ' so the data in the car object in the carList collection
                ' must be updated

                ' so get the car from the custmers collection
                ' using the selected key
                car = CType(carList.Item(currentCardentificationNumber), car)

                ' update the data in the specific object
                ' from the controls

            End If

            ' clear the items from the listview control
            lvwCar.Items.Clear()

            ' loop through the carList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, car)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.VeryImportantPersonStatus
                carItem.SubItems.Add(car.CarIdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add("$ " + car.price)

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCar.Items.Add(carItem)

            Next carEntry



            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()


        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lblResult.Text = String.Empty

        currentCardentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim price As Integer = 0
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the title has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the customer's title." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please select the car make name." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If cmbYear.Text.Trim.Length = -1 Then

            ' If not set the error message
            outputMessage += "Please enter the car year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        If Not (txtPrice.Text.Trim.Length) = 0 Then
            If Integer.TryParse(txtPrice.Text, price) Then
                If CInt(txtPrice.Text) > 0 Then
                Else
                    ' If not set the error message
                    outputMessage += "Please don't enter the numeric value." & vbCrLf

                    ' And, set the return value to false
                    returnValue = False
                End If
            Else
                ' If not set the error message
                outputMessage += "Please enter the Numeric Value." & vbCrLf

                ' And, set the return value to false
                returnValue = False
            End If
        Else
            ' If not set the error message
            outputMessage += "Please enter the Price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCar.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCar.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the customer identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the customer identification number 
        currentCardentificationNumber = lvwCar.Items(lvwCar.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the customer identification number to get the customer from the collection object
        Dim car As car = CType(carList.Item(currentCardentificationNumber), car)

        ' set the controls on the form
        txtModel.Text = car.Model             ' get the first name and set the text box
        txtPrice.Text = car.price                 ' get the last name and set the text box
        cmbMake.Text = car.Make                  ' get the title and set the combo box
        chkNew.Checked = car.VeryImportantPersonStatus ' get the very important person status and set the combo box
        lblYear.Text = car.Year
        lblResult.Text = car.GetSalutation()


    End Sub

    Private Sub frmCarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub lvwCustomers_Click(sender As Object, e As EventArgs) Handles lvwCustomers.Click
    '    lbResult.Text = "aaa"
    'End Sub
End Class

