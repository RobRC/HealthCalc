'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: Math.vb    
' Description: Handles all of the math for each calculator
'              and declares the global variables/constants.
'***********************************************************

Module Math

    'Public constants
    Public Const strTITLE_CHANGED = "Health Calculator*"
    Public Const strTITLE_UNCHANGED = "Health Calculator"

    'Public variables
    Public strFilename As String = String.Empty
    Public blnIsChanged As Boolean = False
    Public blnValidated As Boolean

    'Public Profile Variables
    Public blnMetric As Boolean
    Public intAge As Integer
    Public dblHeight As Double
    Public dblWeight As Double
    Public strGender As String

    '**********************************************************
    ' Purpose: Calulates the Basal Metabolic Rate
    '
    ' Returns: dblBMR As Double
    '
    ' Effects: When called, calculates the BMR for either gender
    '          in either Metric or US units, then returns the
    '          results.
    '**********************************************************
    Public Function CalculateBMR() As Double

        Dim dblBMR As Double

        If strGender = "Male" Then

            'Use the formula for males
            If blnMetric = False Then

                'Use the US Units formula
                dblBMR = 66 + (6.23 * dblWeight) + (12.7 * dblHeight) -
                         (6.8 * intAge)

            ElseIf blnMetric = True Then

                'Use the metric formula
                dblBMR = 66 + (13.7 * dblWeight) + (5 * dblHeight) -
                         (6.8 * intAge)

            End If


        ElseIf strGender = "Female" Then

            'Use the formula for females
            If blnMetric = False Then

                'Use the US Units formula
                dblBMR = 655 + (4.35 * dblWeight) + (4.7 * dblHeight) -
                         (4.7 * intAge)

            ElseIf blnMetric = True Then

                'Use the metric formula
                dblBMR = 655 + (9.6 * dblWeight) + (1.8 * dblHeight) -
                         (4.7 * intAge)

            End If

        End If

        Return dblBMR

    End Function

    '**********************************************************
    ' Purpose: Calulates the Daily Calorie Needs
    '
    ' Inputs: BMR as Double, intIndex as Integer
    '
    ' Returns: dblDailyCalories As Double
    '
    ' Effects: When called, calculates the Daily Calorie needs
    '          using the user's BMR and activity level, then
    '          returns the results.
    '**********************************************************
    Public Function CalculateCalorieNeeds(ByVal dblBMR As Double, intIndex As Integer) As Double

        Dim dblDailyCalories As Double

        Select Case intIndex
            Case 0
                'Sedentary
                dblDailyCalories = dblBMR * 1.2
            Case 1
                'Lightly active
                dblDailyCalories = dblBMR * 1.375
            Case 2
                'Moderately active
                dblDailyCalories = dblBMR * 1.55
            Case 3
                'Very active
                dblDailyCalories = dblBMR * 1.725
            Case 4
                'Extra active
                dblDailyCalories = dblBMR * 1.9
        End Select

        Return dblDailyCalories

    End Function

    '**********************************************************
    ' Purpose: Calulates the Body Mass Index
    '
    ' Returns: dblBMI As Double
    '
    ' Effects: When called, calculates the user's Body Mass
    '          Index using the Metric formula.
    '**********************************************************
    Public Function CalculateBMI() As Double

        Dim dblBMI As Double
        Dim dblMeters As Double
        Dim dblKilograms As Double

        'Convert height to meters and weight to kilograms; BMI needs to be metric for
        ' body fat calculations, but the end result looks the same to the user
        If blnMetric = True Then

            dblMeters = dblHeight / 100
            dblKilograms = dblWeight

        Else

            dblMeters = dblHeight * 2.54 / 100
            dblKilograms = dblWeight / 2.20464

        End If

        dblBMI = dblKilograms / dblMeters ^ 2

        Return dblBMI

    End Function

    '**********************************************************
    ' Purpose: Calulates the Body Fat Percentage
    '
    ' Inputs: dblBMI as Double
    '
    ' Returns: dblBodyFat As Double
    '
    ' Effects: When called, derives the user's Body Fat 
    '          Percentage from their BMI using the formula 
    '          developed by Deurenberg, et al.
    '**********************************************************
    Public Function CalculateBodyFat(ByVal dblBMI As Double) As Double

        Dim dblBodyFat As Double
        Dim intSex As Integer

        'Check gender; formula has a 1 multiplier for males, and a 0 
        ' multiplier for females
        If strGender = "Male" Then
            intSex = 1
        Else
            intSex = 0
        End If

        'Check for age; the formula is different for children younger than 15
        If intAge <= 15 Then

            'Use the child formula: (1.51 × BMI) − (0.70 × Age) − (3.6 × sex) + 1.4
            dblBodyFat = (1.51 * dblBMI) - (0.7 * intAge) - (3.6 * intSex) + 1.4
            dblBodyFat = dblBodyFat / 100

        ElseIf intAge > 15 Then

            'Use the adult formula: (1.20 × BMI) + (0.23 × Age) − (10.8 × sex) − 5.4
            dblBodyFat = (1.2 * dblBMI) + (0.23 * intAge) - (10.8 * intSex) - 5.4
            dblBodyFat = dblBodyFat / 100

        End If

        Return dblBodyFat

    End Function

    '**********************************************************
    ' Purpose: Calulates the fat mass
    '
    ' Inputs: dblBodyFatPercent as Double
    '
    ' Returns: dblFat As Double
    '
    ' Effects: When called, calculates the user's fat mass
    '          based on their weight and body fat percent.
    '**********************************************************
    'Calculates the fat mass
    Public Function CalculateFatMass(ByVal dblBodyFatPercent As Double) As Double

        Dim dblFat As Double

        dblFat = dblWeight * dblBodyFatPercent

        Return dblFat

    End Function

    '**********************************************************
    ' Purpose: Calculates the lean mass
    '
    ' Inputs: dblFat as Double
    '
    ' Returns: dblLean As Double
    '
    ' Effects: When called, calculates the user's lean mass
    '          based on their weight and body fat mass.
    '**********************************************************
    Public Function CalculateLeanMass(ByVal dblFat As Double) As Double

        Dim dblLean As Double

        dblLean = dblWeight - dblFat

        Return dblLean

    End Function

    '**********************************************************
    ' Purpose: Calculates the user's Target Heart Rate
    '
    ' Returns: intTHR As Integer
    '
    ' Effects: When called, calculates the user's target max 
    '          heart rate on their age.
    '**********************************************************
    Public Function CalculateTHR() As Integer

        Dim intTHR As Integer

        intTHR = 220 - intAge

        Return intTHR

    End Function

    '**********************************************************
    ' Purpose: Calculates the user's Body Surface Area
    '
    ' Returns: dblBSA As Double
    '
    ' Effects: When called, calculates the user's body surface
    '          area based on their height and their weight.
    '**********************************************************
    Public Function CalculateBSA() As Double

        Dim dblBSA As Double
        Dim dblCM As Double
        Dim dblKG As Double


        If blnMetric = False Then

            'Convert to Metric
            dblCM = dblHeight * 2.54
            dblKG = dblWeight / 2.20464

        ElseIf blnMetric = True Then

            dblCM = dblHeight
            dblKG = dblWeight

        End If

        'Use DuBois Formula: BSA (m2) = 0.007184 x Height(cm)^0.725 x Weight(kg)^0.425
        dblBSA = 0.007184 * (dblCM ^ 0.725) * (dblKG ^ 0.425)

        Return dblBSA

    End Function

    '***********************************************************
    ' Purpose: Calculates the user's Blood Alcohol Concentration
    '
    ' Returns: dblBAC As Double
    '
    ' Effects: When called, calculates the user's Blood Alcohol
    '          Concentration using the Widmark formula.
    '***********************************************************
    Public Function CalculateBAC() As Double

        Dim dblVolume As Double = CDbl(frmBAC.txtVolume.Text)
        Dim dblAlcoholPercent As Double = CDbl(frmBAC.txtAlcoholPercent.Text)
        Dim dblHours As Double = CDbl(frmBAC.txtHours.Text)
        Dim intIndex As Integer = frmBAC.cboAlcoholUnits.SelectedIndex

        Dim dblBAC As Double
        Dim dblAlcoholMass As Double
        Dim dblLiters As Double
        Dim dblKG As Double                 'Kilograms
        Dim dblSD As Double                 'Standard Drinks

        'Figure out whether proof or ABV is used, then convert to percentage
        Select Case intIndex
            Case 0 'ABV

                dblAlcoholPercent = dblAlcoholPercent / 100

            Case 1 'Proof

                dblAlcoholPercent = dblAlcoholPercent / 200

        End Select

        'convert to metric
        If blnMetric = False Then

            dblKG = dblWeight / 2.20464
            dblLiters = dblVolume * 29.5735 / 1000

        Else

            dblLiters = dblVolume / 1000
            dblKG = dblWeight

        End If

        'Figure out pure alcohol mass
        dblAlcoholMass = dblLiters * (dblAlcoholPercent * 789.24)

        'Figure out standard drinks
        dblSD = dblAlcoholMass / 10

        'Figure out the Blood Alcohol Concentration using the Widmark formula
        ' EBAC = ((0.806 x SD / BW x Wt) - MR * H)
        If strGender = "Male" Then

            'In males, the average BW is 0.58 and average MR is 0.015
            dblBAC = ((0.806 * dblSD) / (0.58 * dblKG)) - (0.015 * dblHours)

        ElseIf strGender = "Female" Then

            'In females, the average BW is 0.49 and average MR is 0.017
            dblBAC = ((0.806 * dblSD) / (0.49 * dblKG) - (0.017 * dblHours))

        End If

        'Since it's possible for this formula to return a negative value when small
        ' volumes of alcohol are involved, make sure the smallest number returned is 
        ' zero. 
        If dblBAC < 0 Then
            dblBAC = 0
        End If

        Return dblBAC

    End Function

    '***********************************************************
    ' Purpose: Calculates the user's Waist to Height Ratio.
    '
    ' Inputs: dblWaist as Double
    '
    ' Returns: dblWHR As Double
    '
    ' Effects: When called, calculates the user's Waist to Height
    '          Ratio.
    '***********************************************************
    Public Function CalculateWHR(ByVal dblWaist As Double) As Double

        Dim dblWHR As Double

        'no need to check measurement system as this is a simple ratio
        dblWHR = dblWaist / dblHeight

        Return dblWHR

    End Function

End Module
