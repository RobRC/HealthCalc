'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: BACcalculator.vb    
' Description: Allows the user to calculate their Body
'              Alcohol Concentration 
'**********************************************************

Public Class BACcalculator

    '**********************************************************
    ' Purpose: Initializes the combo box 
    '
    ' Effects: Initializes the combo box so that the first item
    '          on the list (ABV) is showing
    '**********************************************************
    Private Sub BACcalculator_Load(sender As Object, e As EventArgs) Handles _
        MyBase.Load

        'Initializes the combo box so that the first item in the list is 
        ' showing.
        cboAlcoholUnits.SelectedIndex = 0

    End Sub

    '**********************************************************
    ' Purpose: Shows the Help Tip
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, displays the Help Tip if it is
    '          not visible, or hides it if it is.
    '**********************************************************
    Private Sub btnHelpTip_Click(sender As Object, e As EventArgs) Handles _
        btnHelpTip.Click

        'Displays help tip if not visible, hides it if it is.
        If txtHelpTip.Visible Then

            txtHelpTip.Visible = False

        Else

            txtHelpTip.Visible = True

        End If

    End Sub

    '**********************************************************
    ' Purpose: Displays and calculates the Blood Alcohol
    '          concentration.
    '
    ' Inputs: button click.
    '
    ' Effects: Calls the procedure to display and calculate 
    '          the user's Blood Alcohol Concentration.
    '**********************************************************
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles _
        btnCalculate.Click

        'First, validate user entered values for the BACcalcualtor
        If ValidateBAC() = True Then

            'Then make sure the main form hasn't changed since last click 
            If blnIsChanged = False Then

                'If nothing has changed, display the results
                DisplayBAC()

            ElseIf blnIsChanged = True And ValidateBAC() Then

                'If main form has changed, validate input again, then
                ' display info if validate works
                ValidateInput()

                If blnValidated = True Then

                    DisplayBAC()

                End If

            End If

        End If

    End Sub

    '************************************************************
    ' Purpose: Resets the form
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, resets all of the results labels.
    '************************************************************
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles _
        btnReset.Click

        'Resets form
        txtVolume.Clear()
        txtAlcoholPercent.Clear()
        txtHours.Clear()
        cboAlcoholUnits.SelectedIndex = 0
        lblWeight.Text = String.Empty
        lblBAC.Text = String.Empty

        'Sets focus back on Volume
        txtVolume.Focus()

    End Sub

    '**********************************************************
    ' Purpose: Closes the form
    '    
    ' Inputs: Button click.
    '
    ' Effects: On button click, uses the Me.Close() function to
    ' 		close the form.
    '**********************************************************
    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles _
        btnCLose.Click

        Me.Close()

    End Sub

End Class