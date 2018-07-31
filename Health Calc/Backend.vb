'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: Backend.vb    
' Description: Handles the file validation, file handling,
'              and Display procedures and functions.
'**********************************************************

Imports System.IO

Module Backend

    'New form declarations for each calculator; they 
    ' need to be on this page so that their controls' 
    ' properties are accessable by procedures and 
    ' functions on this page.
    Public frmBMI As New BMIcalculator     'BMI/Body Fat Percentage
    Public frmBMR As New BMRcalculator     'Basal Metabolic Rate
    Public frmBAC As New BACcalculator     'Blood Alcohol Concentration
    Public frmBSA As New BSAcalculator     'Body Surface Area
    Public frmTHR As New THRcalculator     'Target Heart Rate 
    Public frmWHR As New WHRcalculator     'Waist to Height Ratio

    '***************************************************************
    ' Purpose: Changes the unit labels
    '
    ' Effects: When called, checks if blnMetric is set to false or
    '          true. If blnMetric is false, set all labels to US 
    '          units. If blnMetric is true, set all labels to Metric
    '          units.
    '***************************************************************
    Public Sub ChangeUnitLabels()

        If blnMetric = False Then

            'Set US labels to visible 
            MainForm.lblHeightInches.Visible = True
            MainForm.lblWeightLBS.Visible = True
            frmBAC.lblVolConsumedUS.Visible = True
            frmWHR.lblWaistUS.Visible = True

            'Set Metric lables to not visible
            MainForm.lblHeightCM.Visible = False
            MainForm.lblWeightKG.Visible = False
            frmBAC.lblVolConsumedMetric.Visible = False
            frmWHR.lblWaistMetric.Visible = False

        ElseIf blnMetric = True Then

            'Set US labels to not visible 
            MainForm.lblHeightInches.Visible = False
            MainForm.lblWeightLBS.Visible = False
            frmBAC.lblVolConsumedUS.Visible = False
            frmWHR.lblWaistUS.Visible = False

            'Set Metric lables to visible
            MainForm.lblHeightCM.Visible = True
            MainForm.lblWeightKG.Visible = True
            frmBAC.lblVolConsumedMetric.Visible = True
            frmWHR.lblWaistMetric.Visible = True

        End If

    End Sub

    '***************************************************************
    ' Purpose: Validates main form input
    '
    ' Effects: When called, uses TryParse to validate input. Will  
    '          also check to see if input is within certain limits.
    '          If input validates, set blnValidated to True. Else,
    '          set blnValidated to False and display an error using
    '          a Message Box.
    '***************************************************************
    Public Sub ValidateInput()

        'Validate text boxes
        If Not Integer.TryParse(MainForm.txtAge.Text, intAge) Or
            intAge <= 0 Or intAge > 120 Then

            'Show error message for incorrect age
            MessageBox.Show("Please enter your age using a whole number " &
                            "between 1 and 120.", "Error")

            blnValidated = False

        ElseIf Not Double.TryParse(MainForm.txtHeight.Text, dblHeight) Or
            dblHeight <= 0 Then

            'Show error message for incorrect height
            MessageBox.Show("Please correctly enter your height using a " &
                            "non-zero positive numeric value.", "Error")

            blnValidated = False

        ElseIf Not Double.TryParse(MainForm.txtWeight.Text, dblWeight) Or
            dblWeight <= 0 Then

            'Show error message for incorrect weight
            MessageBox.Show("Please correctly enter your weight using a " &
                            "non-zero positive numeric value.", "Error")

            blnValidated = False

        Else

            'Try to Set gender
            If MainForm.radFemale.Checked = True Then
                strGender = "Female"
                blnValidated = True
            ElseIf MainForm.radMale.Checked = True Then
                strGender = "Male"
                blnValidated = True
            Else
                'Show error message for no gender selected
                MessageBox.Show("Please select a gender.", "Error")
                blnValidated = False
            End If

        End If

    End Sub

    '***************************************************************
    ' Purpose: Validates Blood Alcohol Concentration input.
    '
    ' Returns: Boolean
    '
    ' Effects: When called, uses TryParse to validate input. Will  
    '          also check to see if input is within certain limits.
    '          If input validates, return True. Else, return false
    '          and display an error using a Message Box.
    '***************************************************************
    Public Function ValidateBAC() As Boolean

        Dim blnValidBAC As Boolean
        Dim dblVol As Double
        Dim dblABV As Double
        Dim dblHours As Double

        If Not Double.TryParse(frmBAC.txtVolume.Text, dblVol) Or
        dblVol <= 0 Then

            'Show error for incorrect hours
            MessageBox.Show("Please enter a positive number larger than " &
                            "zero for total volume consumed.", "Error")
            blnValidBAC = False

        ElseIf frmBAC.cboAlcoholUnits.SelectedIndex = -1 Then

            'Show error for no selection of alcohol unit
            MessageBox.Show("Please select either 'Alcohol Percentage (ABV)' " &
                            " or 'Proof'.", "Error")
            blnValidBAC = False

        ElseIf Not Double.TryParse(frmBAC.txtAlcoholPercent.Text, dblABV) Then

            'Show error for non numeric entry
            MessageBox.Show("Please enter a valid number for either 'Alcohol " &
                            "Percentage (ABV)' or 'Proof'.", "Error")
            blnValidBAC = False

        ElseIf frmBAC.cboAlcoholUnits.SelectedIndex = 0 And
            (dblABV < 1) Or (dblABV > 100) Then

            'Show error for wrong percentage
            MessageBox.Show("Please enter a number between 1 and 100 for percent",
                            "Error")
            blnValidBAC = False

        ElseIf frmBAC.cboAlcoholUnits.SelectedIndex = 1 And
            (dblABV < 1) Or (dblABV > 200) Then

            'Show error for wrong proof
            MessageBox.Show("Please enter a proof number between 1 and 200",
                            "Error")
            blnValidBAC = False

        ElseIf Not Double.TryParse(frmBAC.txtHours.Text, dblHours) Or
            dblHours < 0 Then

            'Show error for incorrect hours
            MessageBox.Show("Please enter a positive number zero or larger for " &
                            "hours since last drink.", "Error")
            blnValidBAC = False

        Else

            blnValidBAC = True

        End If

        Return blnValidBAC

    End Function

    '***************************************************************
    ' Purpose: Resets the main form.
    '
    ' Effects: When called, resets all text boxes, clears the 
    '          gender selection, and resets the default to US units.
    '***************************************************************
    Public Sub ResetMainForm()

        'Reset Profile
        MainForm.txtAge.Clear()
        MainForm.txtHeight.Clear()
        MainForm.txtWeight.Clear()
        MainForm.radFemale.Checked = False
        MainForm.radMale.Checked = False
        MainForm.radUS.Checked = True
        MainForm.radMetric.Checked = False
        blnMetric = False

        'Sets ischanged to false
        blnIsChanged = False

        'clear the file name
        strFilename = String.Empty

        'Sets the focus back to Age
        MainForm.txtAge.Focus()

    End Sub

    '***************************************************************
    ' Purpose: Allows the user to open a previously saved profile.
    '
    ' Effects: When called, displays the Open File dialog, retrieves
    '          the user's selection, then opens the file, reads
    '          each line to set the global variables, then closes
    '          the file.
    '***************************************************************
    Public Sub OpenProfile()

        Dim inputFile As StreamReader   'Object variable

        If MainForm.ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Retreive the selected filename
            strFilename = MainForm.ofdOpenFile.FileName

            Try

                'Open the file
                inputFile = File.OpenText(strFilename)

                'set the variables
                intAge = CInt(inputFile.ReadLine())
                dblHeight = CDbl(inputFile.ReadLine())
                dblWeight = CDbl(inputFile.ReadLine())
                strGender = inputFile.ReadLine()
                blnMetric = CBool(inputFile.ReadLine())

                'Put variables into the Textboxes
                MainForm.txtAge.Text = intAge.ToString()
                MainForm.txtHeight.Text = dblHeight.ToString()
                MainForm.txtWeight.Text = dblWeight.ToString()

                'Set the unit radio buttons
                If blnMetric Then
                    MainForm.radMetric.Checked = True
                    MainForm.radUS.Checked = False
                Else
                    MainForm.radUS.Checked = True
                    MainForm.radMetric.Checked = False
                End If

                'Set the gender radio buttons
                If strGender = "Male" Then
                    MainForm.radMale.Checked = True
                    MainForm.radFemale.Checked = False
                ElseIf strGender = "Female" Then
                    MainForm.radMale.Checked = False
                    MainForm.radFemale.Checked = True
                End If

                'Close the file
                inputFile.Close()

                'update the ischanged variable
                blnIsChanged = False

            Catch

                'Error message for file open error
                MessageBox.Show("Error opening the file.")

            End Try

        End If

    End Sub

    '***************************************************************
    ' Purpose: Allows the user to save a previously saved profile.
    '
    ' Effects: When called, opens the profile file, saves each
    '          global variable to a new line, then closes the file.
    '***************************************************************
    Public Sub SaveProfile()

        Dim outputFile As StreamWriter  'object variable

        Try

            'create the file
            outputFile = File.CreateText(strFilename)

            'Write the Text Boxes to the file
            outputFile.WriteLine(MainForm.txtAge.Text)
            outputFile.WriteLine(MainForm.txtHeight.Text)
            outputFile.WriteLine(MainForm.txtWeight.Text)
            outputFile.WriteLine(strGender)
            outputFile.WriteLine(blnMetric.ToString())

            'Close the file
            outputFile.Close()

            'Update the isChanged varaible
            blnIsChanged = False

        Catch

            'Error mesage for file creation error
            MessageBox.Show("Error creating the file.")

        End Try

    End Sub

    '**********************************************************
    ' Purpose: Displays the Basal Metabolic Rate Results
    '
    ' Effects: Calls the CalculateBMR function, calls the
    '          CalculateCalorieNeeds function, then uses the
    '          returned values to fill out the result labels
    '          on the BMR Calculator form.
    '**********************************************************
    'Displays BMR results
    Public Sub DisplayBMR()

        Dim dblBMR As Double
        Dim dblCalories As Double

        'Calculate BMR using CalculateBMR Function
        dblBMR = CalculateBMR()

        'Calculate Daily Calory Needs using CalculateCalorieNeeds Function
        dblCalories = CalculateCalorieNeeds(dblBMR,
                                            frmBMR.cboActivityLevel.SelectedIndex)

        'Show Results
        frmBMR.lblBMR.Text = dblBMR.ToString("n0")
        frmBMR.lblCalorieNeeds.Text = dblCalories.ToString("n0")

    End Sub

    '**********************************************************
    ' Purpose: Displays the BMI and Body Fat Percentage Results
    '
    ' Effects: Calls the CalculateBMI function, calls the
    '          CalculateBodyFat function, then uses the
    '          returned values to fill out the result labels
    '          on the BMR Calculator form.
    '**********************************************************
    Public Sub DisplayBMIandBF()

        Dim dblBMI As Double
        Dim dblBodyFat As Double
        Dim dblFatMass As Double
        Dim dblLeanMass As Double

        'Calculate and show BMI
        dblBMI = CalculateBMI()
        frmBMI.lblBMI.Text = dblBMI.ToString("n")

        'Calculate and show Body Fat Percent
        dblBodyFat = CalculateBodyFat(dblBMI)
        frmBMI.lblBodyFat.Text = dblBodyFat.ToString("p")

        'Calculate fat mass and lean mass
        dblFatMass = CalculateFatMass(dblBodyFat)
        dblLeanMass = CalculateLeanMass(dblFatMass)

        'Show height, weight, fat mass, and lean mass in either metric or US
        If blnMetric = False Then

            frmBMI.lblHeight.Text = dblHeight.ToString("n") & " inches"
            frmBMI.lblWeight.Text = dblWeight.ToString("n") & " pounds"
            frmBMI.lblFatMass.Text = dblFatMass.ToString("n") & " pounds"
            frmBMI.lblLeanMass.Text = dblLeanMass.ToString("n") & " pounds"

        ElseIf blnMetric = True Then

            frmBMI.lblHeight.Text = dblHeight.ToString("n") & " cm"
            frmBMI.lblWeight.Text = dblWeight.ToString("n") & " kg"
            frmBMI.lblFatMass.Text = dblFatMass.ToString("n") & " kg"
            frmBMI.lblLeanMass.Text = dblLeanMass.ToString("n") & " kg"

        End If

        'Show BMI Classification
        If dblBMI >= 30 Then
            frmBMI.lblClassification.Text = "Obese"
        ElseIf dblBMI >= 25 Then
            frmBMI.lblClassification.Text = "Overweight"
        ElseIf dblBMI >= 18.5 Then
            frmBMI.lblClassification.Text = "Normal"
        ElseIf dblBMI < 18.5 Then
            frmBMI.lblClassification.Text = "Underweight"
        End If

    End Sub

    '**********************************************************
    ' Purpose: Displays the Target Heart Rate Results
    '
    ' Effects: Calls the CalculateTHR function then uses the
    '          returned values to fill out the result labels
    '          on the THR Calculator form.
    '**********************************************************
    Public Sub DisplayTHR()

        Dim intTHR As Integer

        intTHR = CalculateTHR()

        frmTHR.lblAge.Text = intAge.ToString()
        frmTHR.lblTHR.Text = intTHR.ToString()

    End Sub

    '**********************************************************
    ' Purpose: Displays the Body Surface Area Results
    '
    ' Effects: Calls the CalculateBSA function then uses the
    '          returned values to fill out the result labels
    '          on the BSA Calculator form.
    '**********************************************************
    Public Sub DisplayBSA()

        Dim dblBSA As Double

        dblBSA = CalculateBSA()

        'Show height and weight in either metric or US depending on 
        ' user's setting
        If blnMetric = False Then

            frmBSA.lblHeight.Text = dblHeight.ToString("n") & " inches"
            frmBSA.lblWeight.Text = dblWeight.ToString("n") & " pounds"

        ElseIf blnMetric = True Then

            frmBSA.lblHeight.Text = dblHeight.ToString("n") & " cm"
            frmBSA.lblWeight.Text = dblWeight.ToString("n") & " kg"

        End If

        'Always show BSA in metric, as that is how it is always used.
        frmBSA.lblBSA.Text = dblBSA.ToString("n") & " square meters"

    End Sub

    '**********************************************************
    ' Purpose: Displays the Blood Alcohol Concentration Results
    '
    ' Effects: Calls the CalculateBAC function then uses the
    '          returned values to fill out the result labels
    '          on the BAC Calculator form.
    '**********************************************************
    Public Sub DisplayBAC()

        Dim dblBAC As Double

        dblBAC = CalculateBAC()

        'Show weight in either kg or pounds
        If blnMetric = True Then

            frmBAC.lblWeight.Text = dblWeight.ToString("n") & " kg"

        Else

            frmBAC.lblWeight.Text = dblWeight.ToString("n") & " pounds"

        End If

        'Show BAC
        frmBAC.lblBAC.Text = dblBAC.ToString("n") & "%"

    End Sub

    '**********************************************************
    ' Purpose: Displays the Waist to Height Ratio Results
    '
    ' Effects: Calls the CalculateWHR function then uses the
    '          returned values to fill out the result labels
    '          on the WHR Calculator form.
    '**********************************************************
    Public Sub DisplayWHR()

        Dim dblWHR As Double
        Dim dblWaist As Double

        'Validates input first
        If Double.TryParse(frmWHR.txtWaist.Text, dblWaist) And
            dblWaist > 0 Then

            dblWHR = CalculateWHR(dblWaist)

            'Check if metric
            If blnMetric = True Then

                frmWHR.lblHeight.Text = dblHeight.ToString("n") & " cm"

            Else

                frmWHR.lblHeight.Text = dblHeight.ToString("n") & " inches"

            End If

            'Because it's a ratio, it doesn't matter if original  
            ' measurements were metric or US.
            frmWHR.lblWHR.Text = dblWHR.ToString("n")

            'Show classification
            If dblWHR <= 0.34 Then

                frmWHR.lblClassification.Text = "Extremely Slim"

            ElseIf dblWHR >= 0.5 And intAge < 50 Then

                frmWHR.lblClassification.Text = "Increased Risk"

            ElseIf dblWHR >= 0.6 And intAge <= 50 Then

                frmWHR.lblClassification.Text = "Increased Risk"

            Else

                frmWHR.lblClassification.Text = "Healthy"

            End If

        Else

            'Show error
            MessageBox.Show("Please enter a non-zero positive number for " &
                            "waist size.", "Error")

        End If

    End Sub

End Module
