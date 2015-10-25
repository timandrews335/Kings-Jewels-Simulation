Public Class Form1
    Dim mJewels As New ArrayList
    Dim mSeenJewels As New ArrayList
    Dim mResults As New ArrayList
    Dim HighestSeen As Integer = -1
    Dim res As Results


    Private Function FindJewel(ID As Integer) As Jewel
        For Each j As Jewel In Me.mJewels
            If j.ID = ID Then
                Return j
            End If
        Next
        Return Nothing
    End Function

    Private Sub Simulate()
        'Resest Highest seen
        HighestSeen = -1

        'Clear the bags of jewels
        Me.mJewels.Clear()
        Me.mSeenJewels.Clear()

        'Randomly fill the first bag
        Dim r As New Random
        For i As Integer = 0 To 9
            Me.mJewels.Add(New Jewel(r.Next(0, 10), i))
        Next

        'Find the highest one
        Me.mJewels.Sort()
        Me.mJewels(Me.mJewels.Count - 1).Highest = True


        'Look at jewels until you stop 
        Dim current As Jewel = Nothing
        For i As Integer = 0 To nudLookCount.Value
            current = FindJewel(i)
            If HighestSeen = -1 Then HighestSeen = current.Value
            'If we are going to look at least one jewel
            If Me.nudLookCount.Value > 0 And i > 0 Then
                'Get a referene to the prior jewel
                Dim prior As Jewel = FindJewel(i - 1)

                'Add the prior jewel to the seen jewels
                Me.mSeenJewels.Add(prior)

                'See if this is the highest seen jewel
                If prior.Value > HighestSeen Then HighestSeen = prior.Value
            End If
        Next

        'If we are to look at one jewel or more, find the new jewel that is of a higher value than the highest seen
        If Me.nudLookCount.Value > 0 Then
            For i As Integer = nudLookCount.Value To Me.mJewels.Count - 1
                If FindJewel(i).Value > HighestSeen Then
                    current = FindJewel(i)
                    Exit For
                End If
            Next

        End If

        'Save off our j jewel as the the one that picked
        res = New Results(Me.nudLookCount.Value, current.Highest, current.Value, current.ID)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "King's Jewels Simulation"
    End Sub

    Private Sub btnSimulate_Click(sender As Object, e As EventArgs) Handles btnSimulate.Click
        Me.grpSimulation.Enabled = False
        For i As Integer = 1 To Me.nudIterations.Value

            'Simulate
            Call Me.Simulate()

            'Clear the displays
            Me.lvJewelBag.Items.Clear()
            Me.lvSeenJewels.Items.Clear()

            'Display the items in the bag
            For Each j As Jewel In Me.mJewels
                Dim li As New ListViewItem
                li.Text = j.ID.ToString
                li.SubItems.Add(j.Value.ToString)
                li.SubItems.Add(j.Highest.ToString)
                Me.lvJewelBag.Items.Add(li)
            Next

            'Display the seen items in the seen bag
            For Each prior As Jewel In Me.mSeenJewels
                Dim lip As New ListViewItem
                lip.Text = prior.ID.ToString
                lip.SubItems.Add(prior.Value.ToString)
                lip.SubItems.Add(prior.Highest.ToString)
                lvSeenJewels.Items.Add(lip)
            Next


            Me.Label5.Text = HighestSeen


            'Display the result
            Dim liv As New ListViewItem
            liv.Text = res.NumberSeen
            liv.SubItems.Add(res.ID)
            liv.SubItems.Add(res.value)
            liv.SubItems.Add(res.Highest)
            Me.lvResults.Items.Add(liv)

            'Update the progress counter
            Me.lblProgress.Text = i.ToString & " of " & Me.nudIterations.Value.ToString
            Application.DoEvents()
        Next
        If Me.nudIterations.Value > 100 Then MessageBox.Show("Finished")
        Me.grpSimulation.Enabled = True
    End Sub

    Private Sub btnClearResults_Click(sender As Object, e As EventArgs) Handles btnClearResults.Click
        Me.lvResults.Items.Clear()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim s As String
        s = "How many" & ControlChars.Tab & "ID" & ControlChars.Tab & "Value" & ControlChars.Tab & "Highest" & Environment.NewLine
        For Each li As ListViewItem In Me.lvResults.Items
            s &= li.Text & ControlChars.Tab & li.SubItems(1).Text & ControlChars.Tab & li.SubItems(2).Text & ControlChars.Tab & li.SubItems(3).Text
            s &= Environment.NewLine
        Next
        My.Computer.Clipboard.SetText(s)
    End Sub



End Class

Friend Class Jewel
    Implements IComparable

    Public Value As Integer
    Public ID As Integer
    Public Highest As Boolean = False

    Sub New(_value As Integer, _id As Integer)
        Value = _value
        ID = _id
    End Sub

    Public Overloads Function CompareTo(ByVal obj As Object) As Integer _
    Implements IComparable.CompareTo

        If obj Is Nothing Then Return 1

        Dim OtherJewel As Jewel = TryCast(obj, Jewel)
        If OtherJewel IsNot Nothing Then
            Return Me.Value.CompareTo(OtherJewel.Value)
        Else
            Throw New ArgumentException("Object is not a Jewel")
        End If
    End Function
End Class

Friend Class Results
    Public NumberSeen As Integer = 0
    Public Highest As Boolean = False
    Public ID As Integer
    Public value As Integer = 0

    Sub New(_numberseen As Integer, _highest As Boolean, _value As Integer, _id As Integer)
        NumberSeen = _numberseen
        Highest = _highest
        value = _value
        ID = _id
    End Sub
End Class
