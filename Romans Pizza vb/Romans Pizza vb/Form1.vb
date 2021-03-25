Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim small As Double = 25.75
        Dim medium As Double = 69.46
        Dim large As Double = 98.21
        Dim extraCheese As Double = 5.12
        Dim mushrooms As Double = 5.75
        Dim blackOlives As Double = 5.25
        Dim onions As Double = 4.0
        Dim greenPepper As Double = 4.5
        Dim tomatoes As Double = 4.25
        Dim change As Double
        Dim total As Double
        Dim amountGiven As Double
        Dim pizzaSize As Double
        Dim pizzaToppings As Double

       

        If (smallCheckbox.Checked) = True Then
            pizzaSize = pizzaSize + small
        End If
        If mediumCheckbox.Checked = True Then
            pizzaSize = pizzaSize + medium
        End If
        If largeCheckbox.Checked = True Then
            pizzaSize = pizzaSize + large
        End If
        If extraCheeseCheckbox.Checked = True Then

            pizzaToppings = pizzaToppings + extraCheese
        End If
        If mushroomsCheckbox.Checked = True Then
            pizzaToppings = pizzaToppings + mushrooms
        End If
        If blackOlivesCheckbox.Checked = True Then
            pizzaToppings = pizzaToppings + blackOlives
        End If
        If onionsCheckbox.Checked = True Then
            pizzaToppings = pizzaToppings + onions
        End If
        If greenPepperCheckbox.Checked = True Then
            pizzaToppings = pizzaToppings + greenPepper
        End If
        If tomatoesCheckbox.Checked = True Then
            pizzaToppings = pizzaToppings + tomatoes

        End If


        total = (pizzaSize + pizzaToppings) * NumericUpDown1.Value
        totalTextbox.Text = total

        amountGiven = TextBox2.Text
        change = amountGiven - total
        TextBox3.Text = change

        ListBox1.Items.Add("==========================================")

        If smallCheckbox.Checked Then
            ListBox1.Items.Add("Pizza size : Small")
        End If
        If mediumCheckbox.Checked Then
            ListBox1.Items.Add("Pizza size : Medium")
        End If
        If largeCheckbox.Checked Then
            ListBox1.Items.Add("Pizza size : Large")
        End If


        ListBox1.Items.Add("Quantity : " & NumericUpDown1.Value)
        ListBox1.Items.Add("Total Cost : " & total.ToString)
        ListBox1.Items.Add("Amount Tendered : " & amountGiven)
        ListBox1.Items.Add("Change : " & change)
        ListBox1.Items.Add("==========================================")
        ListBox1.Items.Add("                                          ")
        ListBox1.Items.Add("==========================================")

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        smallCheckbox.Checked = False
        mediumCheckbox.Checked = False
        largeCheckbox.Checked = False
        extraCheeseCheckbox.Checked = False
        mushroomsCheckbox.Checked = False
        blackOlivesCheckbox.Checked = False
        onionsCheckbox.Checked = False
        greenPepperCheckbox.Checked = False
        tomatoesCheckbox.Checked = False
        totalTextbox.Clear()
        TextBox2.Clear()
        TextBox3.Clear()


    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        MsgBox("Please make a selection if you wish to exit")

    End Sub


    Private Sub extraCheeseCheckbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles extraCheeseCheckbox.CheckedChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
