<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpSimulation = New System.Windows.Forms.GroupBox()
        Me.nudIterations = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnClearResults = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lvResults = New System.Windows.Forms.ListView()
        Me.colHowMany = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colResultsID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colResultsValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colResultsHighest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudLookCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvSeenJewels = New System.Windows.Forms.ListView()
        Me.colSeenJewelsID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSeenJewelsValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSeenJewelsHighest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvJewelBag = New System.Windows.Forms.ListView()
        Me.colJewelID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colJewelValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colHighest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.grpSimulation.SuspendLayout()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLookCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSimulation
        '
        Me.grpSimulation.Controls.Add(Me.nudIterations)
        Me.grpSimulation.Controls.Add(Me.Label7)
        Me.grpSimulation.Controls.Add(Me.btnCopy)
        Me.grpSimulation.Controls.Add(Me.btnClearResults)
        Me.grpSimulation.Controls.Add(Me.Label6)
        Me.grpSimulation.Controls.Add(Me.Label5)
        Me.grpSimulation.Controls.Add(Me.Label4)
        Me.grpSimulation.Controls.Add(Me.lvResults)
        Me.grpSimulation.Controls.Add(Me.Label3)
        Me.grpSimulation.Controls.Add(Me.nudLookCount)
        Me.grpSimulation.Controls.Add(Me.Label2)
        Me.grpSimulation.Controls.Add(Me.lvSeenJewels)
        Me.grpSimulation.Controls.Add(Me.Label1)
        Me.grpSimulation.Controls.Add(Me.lvJewelBag)
        Me.grpSimulation.Controls.Add(Me.btnSimulate)
        Me.grpSimulation.Location = New System.Drawing.Point(12, 33)
        Me.grpSimulation.Name = "grpSimulation"
        Me.grpSimulation.Size = New System.Drawing.Size(576, 554)
        Me.grpSimulation.TabIndex = 15
        Me.grpSimulation.TabStop = False
        Me.grpSimulation.Text = "Simulation"
        '
        'nudIterations
        '
        Me.nudIterations.Location = New System.Drawing.Point(229, 255)
        Me.nudIterations.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudIterations.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIterations.Name = "nudIterations"
        Me.nudIterations.Size = New System.Drawing.Size(55, 20)
        Me.nudIterations.TabIndex = 24
        Me.nudIterations.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(159, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 32)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Iterations"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(142, 516)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(117, 23)
        Me.btnCopy.TabIndex = 29
        Me.btnCopy.Text = "Copy Results"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnClearResults
        '
        Me.btnClearResults.Location = New System.Drawing.Point(6, 516)
        Me.btnClearResults.Name = "btnClearResults"
        Me.btnClearResults.Size = New System.Drawing.Size(117, 23)
        Me.btnClearResults.TabIndex = 28
        Me.btnClearResults.Text = "Clear Results"
        Me.btnClearResults.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(452, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Highest Value Seen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(452, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Results"
        '
        'lvResults
        '
        Me.lvResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colHowMany, Me.colResultsID, Me.colResultsValue, Me.colResultsHighest})
        Me.lvResults.Location = New System.Drawing.Point(6, 315)
        Me.lvResults.Name = "lvResults"
        Me.lvResults.Size = New System.Drawing.Size(253, 194)
        Me.lvResults.TabIndex = 27
        Me.lvResults.UseCompatibleStateImageBehavior = False
        Me.lvResults.View = System.Windows.Forms.View.Details
        '
        'colHowMany
        '
        Me.colHowMany.Text = "How many"
        Me.colHowMany.Width = 75
        '
        'colResultsID
        '
        Me.colResultsID.Text = "ID"
        Me.colResultsID.Width = 40
        '
        'colResultsValue
        '
        Me.colResultsValue.Text = "Value"
        Me.colResultsValue.Width = 50
        '
        'colResultsHighest
        '
        Me.colResultsHighest.Text = "Highest"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "How many to look at"
        '
        'nudLookCount
        '
        Me.nudLookCount.Location = New System.Drawing.Point(78, 255)
        Me.nudLookCount.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudLookCount.Name = "nudLookCount"
        Me.nudLookCount.Size = New System.Drawing.Size(55, 20)
        Me.nudLookCount.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Seen Jewels"
        '
        'lvSeenJewels
        '
        Me.lvSeenJewels.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSeenJewelsID, Me.colSeenJewelsValue, Me.colSeenJewelsHighest})
        Me.lvSeenJewels.Location = New System.Drawing.Point(229, 44)
        Me.lvSeenJewels.Name = "lvSeenJewels"
        Me.lvSeenJewels.Size = New System.Drawing.Size(217, 205)
        Me.lvSeenJewels.TabIndex = 18
        Me.lvSeenJewels.UseCompatibleStateImageBehavior = False
        Me.lvSeenJewels.View = System.Windows.Forms.View.Details
        '
        'colSeenJewelsID
        '
        Me.colSeenJewelsID.Text = "ID"
        '
        'colSeenJewelsValue
        '
        Me.colSeenJewelsValue.Text = "Value"
        '
        'colSeenJewelsHighest
        '
        Me.colSeenJewelsHighest.Text = "Highest"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Jewel Bag"
        '
        'lvJewelBag
        '
        Me.lvJewelBag.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colJewelID, Me.colJewelValue, Me.colHighest})
        Me.lvJewelBag.Location = New System.Drawing.Point(6, 44)
        Me.lvJewelBag.Name = "lvJewelBag"
        Me.lvJewelBag.Size = New System.Drawing.Size(217, 207)
        Me.lvJewelBag.TabIndex = 16
        Me.lvJewelBag.UseCompatibleStateImageBehavior = False
        Me.lvJewelBag.View = System.Windows.Forms.View.Details
        '
        'colJewelID
        '
        Me.colJewelID.Text = "ID"
        '
        'colJewelValue
        '
        Me.colJewelValue.Text = "Value"
        '
        'colHighest
        '
        Me.colHighest.Text = "Highest"
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(312, 255)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(134, 23)
        Me.btnSimulate.TabIndex = 25
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.Location = New System.Drawing.Point(14, 9)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 20)
        Me.lblProgress.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 599)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.grpSimulation)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "King's Jewels Simulation"
        Me.grpSimulation.ResumeLayout(False)
        Me.grpSimulation.PerformLayout()
        CType(Me.nudIterations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLookCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSimulation As System.Windows.Forms.GroupBox
    Friend WithEvents nudIterations As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnClearResults As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvResults As System.Windows.Forms.ListView
    Friend WithEvents colHowMany As System.Windows.Forms.ColumnHeader
    Friend WithEvents colResultsID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colResultsValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colResultsHighest As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudLookCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvSeenJewels As System.Windows.Forms.ListView
    Friend WithEvents colSeenJewelsID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSeenJewelsValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSeenJewelsHighest As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvJewelBag As System.Windows.Forms.ListView
    Friend WithEvents colJewelID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colJewelValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHighest As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSimulate As System.Windows.Forms.Button
    Friend WithEvents lblProgress As System.Windows.Forms.Label

End Class
