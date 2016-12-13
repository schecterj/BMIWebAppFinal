'Program Name: BMI Calculator - WebSite
'CIS 141 Project: 8
'Date: 12/14/16
'Author: Jonathan Schecter
'Purpose: User enters weight, height (feet & inches). After clicking Calculate button,
'           the program will display BMI and the BMI health status. The user can click 
'           clear to reenter the variables. App must be located on published website. 
'To Do: 

Option Strict On
Option Explicit On


Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        focusOn()
    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearText()
        focusOn()
    End Sub

    Protected Sub clearText()
        txtHeightFeet.Text = Nothing
        txtHeightInches.Text = Nothing
        txtWeight.Text = Nothing

        hideBMILabels()
    End Sub

    Protected Sub hideBMILabels()
        lblBMIOutput.Visible = False
        lblBMIStatus.Visible = False
    End Sub

    Protected Sub focusOn()
        txtWeight.Focus()
    End Sub

    Protected Function preventGarbageInput(decWeight As Decimal, intHeightFeet As Integer) As Boolean

        Dim check As Boolean = True

        If decWeight < 20 Or decWeight > 300 Then
            MsgBox("Please enter valid weight")
            clearText()
            check = False
        End If

        If intHeightFeet < 2 Or intHeightFeet > 8 Then
            MsgBox("Please enter valid height")
            clearText()
            check = False
        End If

        Return check

    End Function

    Protected Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declarations
        Dim strWeight As String
        Dim decWeight As Decimal
        Dim strHeightFeet As String
        Dim intHeightFeet As Integer
        Dim strHeightInches As String
        Dim decHeightInches As Decimal
        Dim decHeightInInches As Decimal
        Dim decBMI As Decimal
        Dim strHealthStatus As String
        Const cBMIConst As Integer = 703

        'User entry converted
        strWeight = txtWeight.Text

        Try
            decWeight = Convert.ToDecimal(strWeight)
        Catch ex As FormatException
            MsgBox("Error with conversion")
        End Try
        ' decWeight = Convert.ToDecimal(strWeight)

        strHeightFeet = txtHeightFeet.Text

        Try
            intHeightFeet = Convert.ToInt32(strHeightFeet)
        Catch ex As FormatException
            MsgBox("Error with conversion")
        End Try


        strHeightInches = txtHeightInches.Text
        'If inches = 0 no input is required, this prevents errors
        If txtHeightInches.Text = "" Then
            strHeightInches = "0"
        End If

        Try
            decHeightInches = Convert.ToDecimal(strHeightInches)
        Catch ex As FormatException
            MsgBox("Error with conversion")

        End Try




        'turn user data into one height variable
        decHeightInInches = (intHeightFeet * 12) + decHeightInches

        ' I used the CDec because of the Option Strict. Without it there was an error thrown.
        decBMI = CDec((decWeight * cBMIConst) / (decHeightInInches ^ 2))

        Dim preventGarbage As Boolean = preventGarbageInput(decWeight, intHeightFeet)
        If preventGarbage = False Then
            Exit Sub
        End If

        If ((decWeight > 0) And (decHeightInches >= 0) And (intHeightFeet > 0)) Then

            'make output label visible and display output
            lblBMIOutput.Visible = True
            lblBMIOutput.Text = "BMI: " & decBMI.ToString("F1")
            'BMI status
            If decBMI < 18.5 Then
                strHealthStatus = "Underweight"
            ElseIf decBMI < 24.9 Then
                strHealthStatus = "Normal"
            ElseIf decBMI < 29.9 Then
                strHealthStatus = "Overweight"
            Else
                strHealthStatus = "Obese"
            End If

            'make label for status visible and display output 
            lblBMIStatus.Visible = True
            lblBMIStatus.Text = "BMI Health Status is:" + vbCrLf + strHealthStatus
        Else
            hideBMILabels()
            'lblBMIStatus.Visible = False
            'lblBMIOutput.Visible = False

            'input validation for negative input, non numeric is handlef by another function
            MsgBox("Enter a positive number", vbCritical, "Input Error")
            clearText()
            focusOn()
        End If


    End Sub
End Class