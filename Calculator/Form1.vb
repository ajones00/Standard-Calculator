Public Class Form1
    'variables to hold data
    Dim firstNumber, secondNumber, result As Double
    Dim operate As String

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles decimalButton.Click, button9.Click, button8.Click, button7.Click, button6.Click, button5.Click, button4.Click, button3.Click, button2.Click, button1.Click, button0.Click
        Dim holder As Button = sender
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
            TextBox1.Text = holder.Text
        ElseIf (holder.Text = ".") Then
            If (Not TextBox1.Text.Contains(".")) Then
                TextBox1.Text = TextBox1.Text + holder.Text
            End If
        Else
            TextBox1.Text = TextBox1.Text + holder.Text
        End If
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles equalsButton.Click
        secondNumber = TextBox1.Text
        If (operate = "/") Then
            result = firstNumber / secondNumber
            TextBox1.Text = result
        ElseIf (operate = "x") Then
            result = firstNumber * secondNumber
            TextBox1.Text = result
        ElseIf (operate = "-") Then
            result = firstNumber - secondNumber
            TextBox1.Text = result
        ElseIf (operate = "+") Then
            result = firstNumber + secondNumber
            TextBox1.Text = result
        End If
    End Sub

    Private Sub PosNegButton_Click(sender As Object, e As EventArgs) Handles posNegButton.Click
        If (TextBox1.Text.Contains("-")) Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        Else
            TextBox1.Text = "-" + TextBox1.Text
        End If
    End Sub

    Private Sub BackspaceButton_Click(sender As Object, e As EventArgs) Handles backspaceButton.Click
        If (TextBox1.Text.Length > 0) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
        If (TextBox1.Text = ".") Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles subtractButton.Click, multiplyButton.Click, divideButton.Click, addButton.Click
        Dim holder As Button = sender
        firstNumber = TextBox1.Text
        operate = holder.Text
        TextBox1.Text = ""
    End Sub
End Class
