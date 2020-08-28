<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblWelcome1 = New System.Windows.Forms.Label()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblLPlateNo = New System.Windows.Forms.Label()
        Me.lblDLNo = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtLPlateNo = New System.Windows.Forms.TextBox()
        Me.txtDLNo = New System.Windows.Forms.TextBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.grpboxServices = New System.Windows.Forms.GroupBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.btnPickCar = New System.Windows.Forms.Button()
        Me.grpboxServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome1
        '
        Me.lblWelcome1.AutoSize = True
        Me.lblWelcome1.Font = New System.Drawing.Font("Castellar", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome1.Location = New System.Drawing.Point(176, 39)
        Me.lblWelcome1.Name = "lblWelcome1"
        Me.lblWelcome1.Size = New System.Drawing.Size(591, 34)
        Me.lblWelcome1.TabIndex = 0
        Me.lblWelcome1.Text = "Welcome to the Parking Garage"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.Location = New System.Drawing.Point(243, 120)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(123, 27)
        Me.lblFname.TabIndex = 1
        Me.lblFname.Text = "First Name: "
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(243, 166)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(120, 27)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name: "
        '
        'lblLPlateNo
        '
        Me.lblLPlateNo.AutoSize = True
        Me.lblLPlateNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLPlateNo.Location = New System.Drawing.Point(243, 211)
        Me.lblLPlateNo.Name = "lblLPlateNo"
        Me.lblLPlateNo.Size = New System.Drawing.Size(177, 27)
        Me.lblLPlateNo.TabIndex = 3
        Me.lblLPlateNo.Text = "License Plate No.: "
        '
        'lblDLNo
        '
        Me.lblDLNo.AutoSize = True
        Me.lblDLNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDLNo.Location = New System.Drawing.Point(243, 255)
        Me.lblDLNo.Name = "lblDLNo"
        Me.lblDLNo.Size = New System.Drawing.Size(200, 27)
        Me.lblDLNo.TabIndex = 4
        Me.lblDLNo.Text = "Drivers Licence No.: "
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(243, 296)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(125, 27)
        Me.lblContactNo.TabIndex = 5
        Me.lblContactNo.Text = "Contact No.:"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(442, 117)
        Me.txtFName.Multiline = True
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(260, 30)
        Me.txtFName.TabIndex = 6
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(442, 163)
        Me.txtLName.Multiline = True
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(260, 30)
        Me.txtLName.TabIndex = 7
        '
        'txtLPlateNo
        '
        Me.txtLPlateNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPlateNo.Location = New System.Drawing.Point(442, 208)
        Me.txtLPlateNo.Multiline = True
        Me.txtLPlateNo.Name = "txtLPlateNo"
        Me.txtLPlateNo.Size = New System.Drawing.Size(260, 30)
        Me.txtLPlateNo.TabIndex = 8
        '
        'txtDLNo
        '
        Me.txtDLNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDLNo.Location = New System.Drawing.Point(442, 252)
        Me.txtDLNo.Multiline = True
        Me.txtDLNo.Name = "txtDLNo"
        Me.txtDLNo.Size = New System.Drawing.Size(260, 30)
        Me.txtDLNo.TabIndex = 9
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(442, 293)
        Me.txtContactNo.Multiline = True
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(260, 30)
        Me.txtContactNo.TabIndex = 10
        '
        'grpboxServices
        '
        Me.grpboxServices.Controls.Add(Me.CheckBox4)
        Me.grpboxServices.Controls.Add(Me.CheckBox3)
        Me.grpboxServices.Controls.Add(Me.CheckBox2)
        Me.grpboxServices.Controls.Add(Me.CheckBox1)
        Me.grpboxServices.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxServices.Location = New System.Drawing.Point(280, 344)
        Me.grpboxServices.Name = "grpboxServices"
        Me.grpboxServices.Size = New System.Drawing.Size(422, 169)
        Me.grpboxServices.TabIndex = 11
        Me.grpboxServices.TabStop = False
        Me.grpboxServices.Text = "Select Services"
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(324, 557)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(119, 42)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(521, 557)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 42)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(44, 53)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 30)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Oil Change"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(44, 108)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(164, 30)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "Coolant Change"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(235, 53)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(135, 30)
        Me.CheckBox3.TabIndex = 17
        Me.CheckBox3.Text = "Tire Change"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(235, 108)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(113, 30)
        Me.CheckBox4.TabIndex = 18
        Me.CheckBox4.Text = "Car Wash"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'btnPickCar
        '
        Me.btnPickCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickCar.Location = New System.Drawing.Point(718, 557)
        Me.btnPickCar.Name = "btnPickCar"
        Me.btnPickCar.Size = New System.Drawing.Size(119, 42)
        Me.btnPickCar.TabIndex = 14
        Me.btnPickCar.Text = "Pick Car"
        Me.btnPickCar.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 620)
        Me.Controls.Add(Me.btnPickCar)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.grpboxServices)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.txtDLNo)
        Me.Controls.Add(Me.txtLPlateNo)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblDLNo)
        Me.Controls.Add(Me.lblLPlateNo)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.lblWelcome1)
        Me.Name = "Register"
        Me.Text = "Register to Park Your Car"
        Me.grpboxServices.ResumeLayout(False)
        Me.grpboxServices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome1 As Label
    Friend WithEvents lblFname As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblLPlateNo As Label
    Friend WithEvents lblDLNo As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtLPlateNo As TextBox
    Friend WithEvents txtDLNo As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents grpboxServices As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblID As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents btnPickCar As Button
End Class
