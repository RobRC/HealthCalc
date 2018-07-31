'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: MainForm.vb    
' Description: An application that provides various health
'              calculators to help people manage their 
'              health and weight.
'**********************************************************

Imports System.ComponentModel

Public Class MainForm

    '************************************************************************
    ' Purpose: Load event handler initializes the application and loads 
    '          defaults.
    '
    ' Effects: Defaults units to US units, initializes blnIsChanged to false, 
    '          and defaults title to unachanged state.
    '************************************************************************
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        radUS.Checked = True
        blnMetric = False
        blnIsChanged = False
        Me.Text = strTITLE_UNCHANGED


    End Sub

    '************************************************************************
    ' Purpose: Checks to see if user wants to save profile before closing
    '
    ' Inputs: Button click
    '
    ' Effects: On close, checks to see if anything on the main form has 
    '          changed. If something has changed, presents the user with a 
    '          message box that asks if they want to save the changes first.
    '************************************************************************
    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'If the profile has been modified, confirm before exiting
        If blnIsChanged = True Then

            'Confirm before clearing and replacing
            If MessageBox.Show("The current document is not saved. " &
                               "Do you wish to discard your changes?",
                               "Confirm", MessageBoxButtons.YesNo) =
                               Windows.Forms.DialogResult.Yes Then

                e.Cancel = False

            Else

                e.Cancel = True

            End If

        End If

    End Sub

    '************************************************************************
    ' Purpose: If the user selects New Profile, resets the form
    '
    ' Inputs: Button click
    '
    ' Effects: First checks to see if anything has been changed. If so, asks
    '          the user if they want to save their profile before resetting
    '          the form. Else, just resets the form.
    '************************************************************************
    'Calls ResetForm procedure
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles _
        mnuFileNew.Click

        'has the current form changed?
        If blnIsChanged = True Then

            'Confirm before clearing the form
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm", MessageBoxButtons.YesNo) =
                               Windows.Forms.DialogResult.Yes Then

                ResetMainForm()
                Me.Text = strTITLE_UNCHANGED

            End If

        Else

            'Form has not changed, so clear it
            ResetMainForm()
            Me.Text = strTITLE_UNCHANGED

        End If

    End Sub

    '************************************************************************
    ' Purpose: Opens a previously saved profile.
    '
    ' Inputs: Button click
    '
    ' Effects: When user clicks, checks to see if anything on the current
    '          profile has changed, and if so asks the user if they want to 
    '          save the current form, then opens the Open file dialog. Else, 
    '          just opens the Open File dialog.
    '************************************************************************
    'Open Profile
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles _
        mnuFileOpen.Click

        'Has the current form changed?
        If blnIsChanged = True Then

            'Confirm before clearing and replacing
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm", MessageBoxButtons.YesNo) =
                               Windows.Forms.DialogResult.Yes Then
                ResetMainForm()
                OpenProfile()
                Me.Text = strTITLE_UNCHANGED

            End If

        Else

            'Profile has not changed, so replace it
            ResetMainForm()
            OpenProfile()
            Me.Text = strTITLE_UNCHANGED

        End If

    End Sub

    '************************************************************************
    ' Purpose: Saves the user's profile to a text file.
    '
    ' Inputs: Button click
    '
    ' Effects: On click, validates the user's input and then calls the 
    '          SaveProfile procedure. If profile doesn't already exist, 
    '          open the Save File dialog.
    '************************************************************************
    'Save
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles _
        mnuFileSave.Click

        'Call the input validation procedure
        ValidateInput()

        'Does the input validate, and does the current profile have a filename?
        If blnValidated = True And strFilename = String.Empty Then

            'The input validates And the profile has not been saved, 
            ' so use SaveAs dialog box
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

                strFilename = sfdSaveFile.FileName
                SaveProfile()
                Me.Text = strTITLE_UNCHANGED

            End If

        ElseIf blnValidated = True Then

            'Save the profile with the current filename if input validates
            SaveProfile()
            Me.Text = strTITLE_UNCHANGED

        End If

    End Sub

    '************************************************************************
    ' Purpose: Saves the user's profile to a new file.
    '
    ' Inputs: Button click
    '
    ' Effects: Validates the user's input, then opens the Save File dialog
    '          and allows the user to save their profile as a text file.
    '************************************************************************
    'Save As
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles _
        mnuFileSaveAs.Click

        'Call the input validation procedure
        ValidateInput()

        'Save the current profile under a new filename if the data validates
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK And
            blnValidated = True Then

            strFilename = sfdSaveFile.FileName
            SaveProfile()
            Me.Text = strTITLE_UNCHANGED

        End If


    End Sub

    '**********************************************************
    ' Purpose: Closes the application
    '    
    ' Inputs: Button click.
    '
    ' Effects: On button click, uses the Me.Close() function to
    ' 		close the form and the app.
    '**********************************************************
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
        mnuFileExit.Click

        Me.Close()

    End Sub

    '************************************************************************
    ' Purpose: Shows the Basal Metabolic Rate Calculator form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, validates user input and then shows the 
    '          BMR calculator.
    '************************************************************************
    'BMR calculator
    Private Sub mnuCalcBMR_Click(sender As Object, e As EventArgs) Handles _
        mnuCalcBMR.Click

        'Call the input validation procedure
        ValidateInput()

        'Only show calculator if main form input validates
        If blnValidated = True Then

            'Show BMR calculator; if form has already been closed at least once, 
            ' reinitialize the form to prevent a System.ObjectDisposedException
            'Focus is given to the cboActivityLevel combobox here because it 
            ' cannot be ge given anywhere else for some unknown reason.
            If frmBMR.IsDisposed() Then
                frmBMR = New BMRcalculator
                frmBMR.Show()
                frmBMR.cboActivityLevel.Focus()
            Else
                frmBMR.Show()
                frmBMR.cboActivityLevel.Focus()
            End If

        End If

    End Sub

    '************************************************************************
    ' Purpose: Shows the BMI and Body Fat Percentage Calculator form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, validates user input and then shows the 
    '          BMI calculator.
    '************************************************************************
    'BMI and Body Fat Percentage calculator
    Private Sub mnuCalcBMI_Click(sender As Object, e As EventArgs) Handles _
        mnuCalcBMI.Click

        'Call the input validation procedure
        ValidateInput()

        'Only show calculator if main form input validates
        If blnValidated = True Then

            'Show BMI & Body Fat calculator; if form has already been   
            ' closed at least once, reinitialize the form to prevent a
            ' System.ObjectDisposedException
            If frmBMI.IsDisposed() Then
                frmBMI = New BMIcalculator
                frmBMI.Show()
            Else
                frmBMI.Show()
            End If

        End If

    End Sub

    '************************************************************************
    ' Purpose: Shows the Blood Alcohol Concentration Calculator form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, validates user input and then shows the 
    '          BAC calculator.
    '************************************************************************
    Private Sub mnuCalcBAC_Click(sender As Object, e As EventArgs) Handles _
        mnuCalcBAC.Click

        'Call the input validation procedure
        ValidateInput()

        'Only show calculator if main form input validates
        If blnValidated = True Then

            'Show BAC calculator. If form has already been closed at least once, 
            ' reinitialize the form to prevent a System.ObjectDisposedException
            If frmBAC.IsDisposed() Then
                frmBAC = New BACcalculator
                frmBAC.Show()
            Else
                frmBAC.Show()
            End If

        End If


    End Sub

    '************************************************************************
    ' Purpose: Shows the Body Surface Area Calculator form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, validates user input and then shows the 
    '          BSA calculator.
    '************************************************************************
    Private Sub mnuCalcBodySurfaceArea_Click(sender As Object, e As EventArgs) _
        Handles mnuCalcBodySurfaceArea.Click

        'Call the input validation procedure
        ValidateInput()

        'Only show calculator if main form input validates
        If blnValidated = True Then

            'Show BMR calculator; if form has already been closed at least once, 
            ' reinitialize the form to prevent a System.ObjectDisposedException
            If frmBSA.IsDisposed() Then
                frmBSA = New BSAcalculator
                frmBSA.Show()
            Else
                frmBSA.Show()
            End If

        End If

    End Sub

    '************************************************************************
    ' Purpose: Shows the Target Heart Rate Calculator form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, validates user input and then shows the 
    '          THR calculator.
    '************************************************************************
    Private Sub mnuCalcTargetHeartRate_Click(sender As Object, e As EventArgs) _
        Handles mnuCalcTargetHeartRate.Click

        'Call the input validation procedure
        ValidateInput()

        'Only show calculator if main form input validates
        If blnValidated = True Then

            'Show BMR calculator; if form has already been closed at least once, 
            ' reinitialize the form to prevent a System.ObjectDisposedException
            If frmTHR.IsDisposed() Then
                frmTHR = New THRcalculator
                frmTHR.Show()
            Else
                frmTHR.Show()
            End If

        End If

    End Sub

    '************************************************************************
    ' Purpose: Shows the Waist to Hip Ratio Calculator form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, validates user input and then shows the 
    '          WHR calculator.
    '************************************************************************
    Private Sub mnuCalcWHR_Click(sender As Object, e As EventArgs) Handles _
        mnuCalcWHR.Click

        'Call the input validation procedure
        ValidateInput()

        'Only show calculator if main form input validates
        If blnValidated = True Then

            'Show BMR calculator; if form has already been closed at least once, 
            ' reinitialize the form to prevent a System.ObjectDisposedException.
            'Focus is given to the txtWaist textbox control here because for some
            ' unknown reason it won't work literally anywhere else.
            If frmWHR.IsDisposed() Then
                frmWHR = New WHRcalculator
                frmWHR.Show()
                frmWHR.txtWaist.Focus()
            Else
                frmWHR.Show()
                frmWHR.txtWaist.Focus()
            End If

        End If


    End Sub

    '************************************************************************
    ' Purpose: Shows the Help form.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, shows the Help Form.
    '************************************************************************
    Private Sub mnuHelpHelp_Click(sender As Object, e As EventArgs) Handles _
        mnuHelpHelp.Click

        Dim frmHelp As New HelpForm

        frmHelp.Show()

    End Sub

    '************************************************************************
    ' Purpose: Shows the About Box.
    '
    ' Inputs: Button click
    '
    ' Effects: On button click, shows the About Box form.
    '************************************************************************
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles _
        mnuHelpAbout.Click

        Dim frmAbout As New AboutBox

        frmAbout.Show()

    End Sub

    '************************************************************************
    ' Purpose: Checks to see if the Age text control has changed.
    '
    ' Inputs: User input in txtAge control
    '
    ' Effects: Checks if the text in the txtAge control has changed.
    '          If it has changed, set blnIsChanged to True and add a * to
    '          the title to remind the user.
    '************************************************************************
    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles _
        txtAge.TextChanged

        blnIsChanged = True
        Me.Text = strTITLE_CHANGED

    End Sub

    '************************************************************************
    ' Purpose: Checks to see if the Height text control has changed.
    '
    ' Inputs: User input in txtHeight control
    '
    ' Effects: Checks if the text in the txtHeight control has changed.
    '          If it has changed, set blnIsChanged to True and add a * to
    '          the title to remind the user.
    '************************************************************************
    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles _
        txtHeight.TextChanged

        blnIsChanged = True
        Me.Text = strTITLE_CHANGED

    End Sub

    '************************************************************************
    ' Purpose: Checks to see if the Weight text control has changed.
    '
    ' Inputs: User input in txtWeight control
    '
    ' Effects: Checks if the text in the txtWeight control has changed.
    '          If it has changed, set blnIsChanged to True and add a * to
    '          the title to remind the user.
    '************************************************************************
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles _
        txtWeight.TextChanged

        blnIsChanged = True
        Me.Text = strTITLE_CHANGED

    End Sub

    '************************************************************************
    ' Purpose: Checks to see if the Female radio button has changed.
    '
    ' Inputs: Button click on radFemale radio button control
    '
    ' Effects: Checks if the text in the radFemale radio button has changed.
    '          If it has changed, set blnIsChanged to True and add a * to
    '          the title to remind the user.
    '************************************************************************
    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles _
        radFemale.CheckedChanged

        blnIsChanged = True
        Me.Text = strTITLE_CHANGED

    End Sub

    '************************************************************************
    ' Purpose: Checks to see if the US radio button has changed.
    '
    ' Inputs: Button click on radUS radio button control
    '
    ' Effects: Checks if the text in the radUS radio button has changed.
    '          If it has changed, set blnIsChanged to True and add a * to
    '          the title to remind the user.
    '************************************************************************
    Private Sub radUS_CheckedChanged(sender As Object, e As EventArgs) Handles _
     radUS.CheckedChanged

        'Set units to US
        If radUS.Checked = True Then
            blnMetric = False
            ChangeUnitLabels()
            blnIsChanged = True
            Me.Text = strTITLE_CHANGED
        End If

    End Sub

    '************************************************************************
    ' Purpose: Checks to see if the Metric radio button has changed.
    '
    ' Inputs: Button click on radMetric radio button control
    '
    ' Effects: Checks if the text in the radMetric radio button has changed.
    '          If it has changed, set blnIsChanged to True and add a * to
    '          the title to remind the user.
    '************************************************************************
    Private Sub radMetric_CheckedChanged(sender As Object, e As EventArgs) Handles _
        radMetric.CheckedChanged

        'Set units to Metric
        If radMetric.Checked = True Then
            blnMetric = True
            ChangeUnitLabels()
            blnIsChanged = True
            Me.Text = strTITLE_CHANGED
        End If

    End Sub

End Class
