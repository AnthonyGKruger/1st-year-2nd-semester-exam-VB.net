<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommuteCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbModeOfTransport = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTripsPM = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblYearCost = New System.Windows.Forms.Label()
        Me.txtTripsPerMonth = New System.Windows.Forms.TextBox()
        Me.txtCostPerTrip = New System.Windows.Forms.TextBox()
        Me.txtCostPerYear = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbModeOfTransport
        '
        Me.cmbModeOfTransport.FormattingEnabled = True
        Me.cmbModeOfTransport.Location = New System.Drawing.Point(174, 53)
        Me.cmbModeOfTransport.Name = "cmbModeOfTransport"
        Me.cmbModeOfTransport.Size = New System.Drawing.Size(100, 21)
        Me.cmbModeOfTransport.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mode of transport:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Commute calculator"
        '
        'lblTripsPM
        '
        Me.lblTripsPM.AutoSize = True
        Me.lblTripsPM.Location = New System.Drawing.Point(26, 95)
        Me.lblTripsPM.Name = "lblTripsPM"
        Me.lblTripsPM.Size = New System.Drawing.Size(83, 13)
        Me.lblTripsPM.TabIndex = 3
        Me.lblTripsPM.Text = "Trips per month:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(26, 131)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(96, 13)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost per round trip:"
        '
        'lblYearCost
        '
        Me.lblYearCost.AutoSize = True
        Me.lblYearCost.Location = New System.Drawing.Point(26, 167)
        Me.lblYearCost.Name = "lblYearCost"
        Me.lblYearCost.Size = New System.Drawing.Size(72, 13)
        Me.lblYearCost.TabIndex = 5
        Me.lblYearCost.Text = "Cost per year:"
        '
        'txtTripsPerMonth
        '
        Me.txtTripsPerMonth.Location = New System.Drawing.Point(174, 90)
        Me.txtTripsPerMonth.Name = "txtTripsPerMonth"
        Me.txtTripsPerMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtTripsPerMonth.TabIndex = 6
        '
        'txtCostPerTrip
        '
        Me.txtCostPerTrip.Location = New System.Drawing.Point(174, 126)
        Me.txtCostPerTrip.Name = "txtCostPerTrip"
        Me.txtCostPerTrip.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerTrip.TabIndex = 7
        '
        'txtCostPerYear
        '
        Me.txtCostPerYear.Location = New System.Drawing.Point(174, 162)
        Me.txtCostPerYear.Name = "txtCostPerYear"
        Me.txtCostPerYear.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerYear.TabIndex = 8
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(80, 200)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(159, 35)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmCommuteCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 247)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtCostPerYear)
        Me.Controls.Add(Me.txtCostPerTrip)
        Me.Controls.Add(Me.txtTripsPerMonth)
        Me.Controls.Add(Me.lblYearCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTripsPM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbModeOfTransport)
        Me.Name = "frmCommuteCalculator"
        Me.Text = "Commute calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbModeOfTransport As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTripsPM As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblYearCost As System.Windows.Forms.Label
    Friend WithEvents txtTripsPerMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerTrip As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerYear As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
