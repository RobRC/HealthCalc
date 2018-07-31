'**********************************************************
' Programmer: Crimmins, Robert
' Chemeketa Community College
' Date: 3/18/2018
' Class: CIS133VB
' Assignment: Final Project
' File Name: HelpForm.vb    
' Description: Helps the user understand how to use the 
'              application.
'**********************************************************

Public Class HelpForm

    '**********************************************************
    ' Purpose: Closes the form.
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