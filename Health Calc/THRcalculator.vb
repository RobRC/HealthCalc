'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: BSAcalculator.vb    
' Description: Allows the user to calculate their Target 
'              Maximum Heart Rate. 
'**********************************************************

Public Class THRcalculator

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
    ' Purpose: Displays and calculates the Target Heart Rate
    '
    ' Inputs: button click.
    '
    ' Effects: Calls the procedure to display and calculate 
    '          the user's Target Heart Rate.
    '**********************************************************
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles _
        btnCalculate.Click

        'Make sure the main form hasn't changed since last click
        If blnIsChanged = False Then

            DisplayTHR()

        Else

            'if main form has changed, validate input again, then
            ' display info if validate works
            ValidateInput()

            If blnValidated = True Then

                DisplayTHR()

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

        lblAge.Text = String.Empty
        lblTHR.Text = String.Empty

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