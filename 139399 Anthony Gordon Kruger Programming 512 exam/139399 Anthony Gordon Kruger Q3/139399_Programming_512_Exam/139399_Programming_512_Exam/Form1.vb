Imports System.IO
Public Class frmCommuteCalculator

    Dim fileName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtCostPerTrip.Hide()
        txtCostPerYear.Hide()
        txtTripsPerMonth.Hide()
        lblCost.Hide()
        lblTripsPM.Hide()
        lblYearCost.Hide()
        btnCalc.Hide()

        fileName = "Cost.txt"

        With cmbModeOfTransport.Items
            .Add("Uber")
            .Add("Subway")
            .Add("Bus")
        End With


    End Sub


    Private Sub cmbModeOfTransport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModeOfTransport.SelectedIndexChanged


        txtCostPerTrip.Show()
        txtCostPerYear.Show()
        txtTripsPerMonth.Show()
        lblCost.Show()
        lblTripsPM.Show()
        lblYearCost.Show()
        btnCalc.Show()


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Try

            If txtTripsPerMonth.Text = "" Or (IsNumeric(txtTripsPerMonth.Text) = False) Then

                MessageBox.Show("Please enter a valid number for trips per month.", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf Val(txtTripsPerMonth.Text) < 1 Then

                MessageBox.Show("Please enter a valid number for trips per month.", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf txtCostPerTrip.Text = "" Or (IsNumeric(txtCostPerTrip.Text) = False) Then

                MessageBox.Show("Please enter a valid number for cost per trip.", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf Val(txtCostPerTrip.Text) < 1 Then

                MessageBox.Show("Please enter a valid number for cost per trip.", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                Dim obj_writer As New IO.StreamWriter(fileName, True)

                Select Case cmbModeOfTransport.SelectedIndex
                    Case 0
                        txtCostPerYear.Text = (((Val(txtCostPerTrip.Text) * Val(txtTripsPerMonth.Text)) * 12) + (((Val(txtCostPerTrip.Text) * Val(txtTripsPerMonth.Text)) * 12) * 0.2)).ToString("C")
                        obj_writer.WriteLine("Mode of transport: " & cmbModeOfTransport.SelectedItem & vbNewLine & "Trips per Month: " & txtTripsPerMonth.Text & vbNewLine & "Cost per trip: R" & txtCostPerTrip.Text & vbNewLine & "Cost per year: " & txtCostPerYear.Text & vbNewLine)
                        obj_writer.Close()
                    Case 1
                        txtCostPerYear.Text = (((Val(txtCostPerTrip.Text) * Val(txtTripsPerMonth.Text)) * 12)).ToString("C")
                        obj_writer.WriteLine("Mode of transport: " & cmbModeOfTransport.SelectedItem & vbNewLine & "Trips per Month: " & txtTripsPerMonth.Text & vbNewLine & "Cost per trip: R" & txtCostPerTrip.Text & vbNewLine & "Cost per year: " & txtCostPerYear.Text & vbNewLine)
                        obj_writer.Close()
                    Case 2
                        txtCostPerYear.Text = (((Val(txtCostPerTrip.Text) * Val(txtTripsPerMonth.Text)) * 12)).ToString("C")
                        obj_writer.WriteLine("Mode of transport: " & cmbModeOfTransport.SelectedItem & vbNewLine & "Trips per Month: " & txtTripsPerMonth.Text & vbNewLine & "Cost per trip: R" & txtCostPerTrip.Text & vbNewLine & "Cost per year: " & txtCostPerYear.Text & vbNewLine)
                        obj_writer.Close()
                End Select

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
