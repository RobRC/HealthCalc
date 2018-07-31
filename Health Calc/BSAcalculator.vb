'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: BSAcalculator.vb    
' Description: Allows the user to calculate their Body 
'              Surface Area. 
'**********************************************************

Public Class BSAcalculator

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
    ' Purpose: Displays and calculates the Body Surface Area
    '
    ' Inputs: button click.
    '
    ' Effects: Calls the procedure to display and calculate 
    '          the user's Body Surface Area.
    '**********************************************************
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles _
        btnCalculate.Click

        'Make sure the main form hasn't changed since last click
        If blnIsChanged = False Then

            DisplayBSA()

        Else

            'If main form has changed, validate input again, then
            ' display info if validate works
            ValidateInput()

            If blnValidated = True Then

                DisplayBSA()

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

        'Reset Form
        lblHeight.Text = String.Empty
        lblWeight.Text = String.Empty
        lblBSA.Text = String.Empty

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