Public Class Form1

    Dim num1 As String
    Dim num2 As String
    Dim sign As String
    Dim answer As Single

    Private Sub bntEquel_Click(sender As Object, e As EventArgs) Handles bntEquel.Click


        If Not String.IsNullOrEmpty(num1) And Not String.IsNullOrEmpty(num2) Then

            If sign = "+" Then
                'zamiana string na single
                answer = CSng(num1) + CSng(num2)

            ElseIf sign = "-" Then

                answer = CSng(num1) - CSng(num2)

            ElseIf sign = "*" Then

                answer = CSng(num1) * CSng(num2)

            ElseIf sign = "/" Then

                answer = CSng(num1) / CSng(num2)
            End If

            'zmiana single na string
            TextBox1.Text = CStr(answer)
        End If

        If String.IsNullOrEmpty(num1) And Not String.IsNullOrEmpty(num2) Then

            If sign = "+" Then
                'zamiana string na single
                answer = answer + CSng(num2)

            ElseIf sign = "-" Then

                answer = answer - CSng(num2)

            ElseIf sign = "*" Then

                answer = answer * CSng(num2)

            ElseIf sign = "/" Then

                answer = answer / CSng(num2)
            End If

            'zmiana single na string
            TextBox1.Text = CStr(answer)
        End If

        If String.IsNullOrEmpty(num1) And String.IsNullOrEmpty(num2) Then
            TextBox1.Text = "Input error"
        End If

        num1 = ""
        num2 = ""
        sign = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(sign) Then
            num1 += "1"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "1"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(sign) Then
            num1 += "2"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "2"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "3"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "3"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "4"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "4"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "5"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "5"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "6"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "6"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "7"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "7"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "8"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "8"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "9"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "9"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "0"
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "0"
        End If

        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub bntPrzecinek_Click(sender As Object, e As EventArgs) Handles bntPrzecinek.Click

        If String.IsNullOrEmpty(sign) Then
            num1 += "."
        End If
        If Not String.IsNullOrEmpty(sign) Then
            num2 += "."
        End If

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        sign = "+"
        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        sign = "-"
        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub btnMnoznik_Click(sender As Object, e As EventArgs) Handles btnMnoznik.Click
        sign = "*"
        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub btnDzielnik_Click(sender As Object, e As EventArgs) Handles btnDzielnik.Click
        sign = "/"
        TextBox1.Text = num1 + " " + sign + " " + num2
    End Sub

    Private Sub bntReset_Click(sender As Object, e As EventArgs) Handles bntReset.Click
        answer = 0
        num1 = ""
        num2 = ""
        sign = ""
        TextBox1.Text = CStr(answer)
    End Sub
End Class
