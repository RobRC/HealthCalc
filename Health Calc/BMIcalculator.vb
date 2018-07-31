'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: BMIcalculator.vb    
' Description: Allows the user to calculate their Body Mass
'              Index and their Body Fat Percentage.
'**********************************************************

Public Class BMIcalculator

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
        If lklHelpTip.Visible Then

            lklHelpTip.Visible = False

        Else

            lklHelpTip.Visible = True

        End If

    End Sub

    '**********************************************************
    ' Purpose: Opens the website URL in the tag property of the
    '          lklHelpTip control.
    '
    ' Effects: On button click, takes the user to the URL in
    '          the tag property of the lklHelpTip control.
    '**********************************************************
    Private Sub lklHelpTip_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles lklHelpTip.LinkClicked

        'Opens the website URL in the tag property of the link label
        Process.Start(lklHelpTip.Tag.ToString)

    End Sub

    '**********************************************************
    ' Purpose: Displays and calculates the BMI and Body Fat 
    '          percentage results.
    '
    ' Inputs: button click.
    '
    ' Effects: Calls the procedure to display and calculate 
    '          the BMI and Body Fat percentage.
    '**********************************************************
    Private Sub btnCalculateBMI_Click(sender As Object, e As EventArgs) Handles _
        btnCalculateBMI.Click

        'Make sure the main form hasn't changed since last click
        If blnIsChanged = False Then

            DisplayBMIandBF()

        Else

            'If main form has changed, validate input again, then
            ' display info if validate works
            ValidateInput()

            If blnValidated = True Then

                DisplayBMIandBF()

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

        'Resets the form
        lblHeight.Text = String.Empty
        lblWeight.Text = String.Empty
        lblBMI.Text = String.Empty
        lblBodyFat.Text = String.Empty
        lblFatMass.Text = String.Empty
        lblLeanMass.Text = String.Empty
        lblClassification.Text = String.Empty

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