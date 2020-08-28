Public Class Register
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFName.Text = ""
        txtLName.Text = ""
        txtLPlateNo.Text = ""
        txtDLNo.Text = ""
        txtContactNo.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtFName.Text = "" Or txtLName.Text = "" Or txtLPlateNo.Text = "" Or txtDLNo.Text = "" Or txtContactNo.Text = "" Then
            MsgBox("Please enter all the information", MsgBoxStyle.OkOnly, "Invalid")
        Else
            login.Show()
            Counter = Counter + 1
            If CheckBox1.Checked = True Then
                str &= CheckBox1.Text
                str &= ", "
                ServiceCharges = ServiceCharges + OilPrice
            End If
            If CheckBox2.Checked = True Then
                str &= CheckBox2.Text
                str &= ", "
                ServiceCharges = ServiceCharges + CoolantPrice
            End If
            If CheckBox3.Checked = True Then
                str &= CheckBox3.Text
                str &= ", "
                ServiceCharges = ServiceCharges + TirePrice
            End If
            If CheckBox4.Checked = True Then
                str &= CheckBox4.Text
                str &= ", "
                ServiceCharges = ServiceCharges + WashPrice
            End If
        End If


    End Sub

    Private Sub btnPickCar_Click(sender As Object, e As EventArgs) Handles btnPickCar.Click
        login.Show()
        login.txtPassword.Text = ""
        login.txtUsername.Text = ""
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub
End Class
