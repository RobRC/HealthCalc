'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: BMRcalculator.vb    
' Description: Allows the user to calculate their Basal
'              Metablic Rate and their daily calorie needs. 
'**********************************************************

Public Class BMRcalculator

    '**********************************************************
    ' Purpose: Initializes the combo box 
    '
    ' Effects: Initializes the combo box so that the first item
    '          on the list (Sedentary) is showing and gives the
    '          combo box focus.
    '**********************************************************
    Private Sub BMRcalculator_Load(sender As Object, e As EventArgs) Handles _
        MyBase.Load

        cboActivityLevel.SelectedIndex = 0
        cboActivityLevel.Focus()
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
    ' Purpose: Displays and calculates the Basal Metabolic Rate
    '
    ' Inputs: button click.
    '
    ' Effects: Calls the procedure to display and calculate 
    '          the user's Basal Metabolic Rate.
    '**********************************************************
    Private Sub btnCalculateBMR_Click(sender As Object, e As EventArgs) _
        Handles btnCalculateBMR.Click

        'Make sure the main form hasn't changed since last click and that
        ' an activity level selection has been made.
        If blnIsChanged = False And
            cboActivityLevel.SelectedIndex <> -1 Then

            DisplayBMR()

        ElseIf blnIsChanged = True And
            cboActivityLevel.SelectedIndex <> -1 Then


            'If main form has changed, validate input again, then
            ' display info if validate works
            ValidateInput()

            If blnValidated = True Then

                DisplayBMR()

            End If

        Else

            'Show error for no selection of activity level
            MessageBox.Show("Please select an activity level.", "Error")

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

        'Reset the form
        cboActivityLevel.SelectedIndex = -1
        lblBMR.Text = String.Empty
        lblCalorieNeeds.Text = String.Empty

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