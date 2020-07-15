Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click
        Dim form2 As New Form2

        MessageBox.Show("Case " & sender.Tag & " selected")


        form2.Show()




        MessageBox.Show("Welcome to Deal or No deal, Please select 3 cases")





    End Sub


End Class
