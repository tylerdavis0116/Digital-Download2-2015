'PROGRAM: Digital Downloads2
'AUTHOR: Tyler Davis 
'DATE: FEBRUARY 14,2016
'PURPOSE: This application calcualtes and displays 
' the total cost of music downloads

Option Strict On

Public Class frmDigitalDownloads

    Const _cdecPricePerDownload As Decimal = 0.99D

    Private Sub frmDigitalDownloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler is executed when the form is loaded. It displays 
        ' the cost heading, clears the Text property of the Total Cost of Downloads 
        ' label, and sets the focus on the txtNumberOfSongs Textbox object.

        lblCostHeading.Text = _cdecPricePerDownload.ToString("C") & "Per Download"
        lblTotalCost.Text = ""
        txtNumberOfDownloads.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler is executed when the user clicks the Calculate
        ' button. It calculates and displays  the cost of music downloads 
        ' which is (Number od Downloads x Cost per Download

        Dim strNumberofSongs As String
        Dim intNumberOfSongs As Integer
        Dim decTotalCostOfDownloads As Decimal

        strNumberofSongs = txtNumberOfDownloads.Text
        intNumberOfSongs = Convert.ToInt32(strNumberofSongs)
        decTotalCostOfDownloads = intNumberOfSongs * _cdecPricePerDownload

        lblTotalCost.Text = decTotalCostOfDownloads.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler is executed when the user clicks the 
        'Clear button. It clears the number of songs text box 
        'and the Text property of the Total Cost of DOwnloads label. 
        ' Then, it sets the focus on the txtNumberOfDownloads textbox object.

        txtNumberOfDownloads.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDownloads.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the window and terminate the application 

        Close()
    End Sub
End Class
