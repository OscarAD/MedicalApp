<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patientForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Datepick = New System.Windows.Forms.DateTimePicker()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.insuranceCheck = New System.Windows.Forms.CheckBox()
        Me.insuranceBox = New System.Windows.Forms.GroupBox()
        Me.txtPlanID = New System.Windows.Forms.TextBox()
        Me.txtSubsID = New System.Windows.Forms.TextBox()
        Me.comboPlan = New System.Windows.Forms.ComboBox()
        Me.comboProvider = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.statStrip = New System.Windows.Forms.StatusStrip()
        Me.statLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.insuranceBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.statStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(106, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(22, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(71, 286)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of birth:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(62, 236)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(22, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(218, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Insurance provider:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label8.Location = New System.Drawing.Point(73, 137)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 33)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Subscriber ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label9.Location = New System.Drawing.Point(86, 86)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 33)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Type of plan:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label10.Location = New System.Drawing.Point(136, 188)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 33)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Plan ID:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtID.Location = New System.Drawing.Point(160, 38)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(319, 35)
        Me.txtID.TabIndex = 10
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtFname.Location = New System.Drawing.Point(160, 88)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(319, 35)
        Me.txtFname.TabIndex = 11
        Me.txtFname.Text = "Carlos"
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtLname.Location = New System.Drawing.Point(160, 137)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(319, 35)
        Me.txtLname.TabIndex = 12
        Me.txtLname.Text = "Martinez"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtPhone.Location = New System.Drawing.Point(160, 236)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(319, 35)
        Me.txtPhone.TabIndex = 13
        Me.txtPhone.Text = "7864567723"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(160, 286)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(319, 35)
        Me.txtEmail.TabIndex = 14
        Me.txtEmail.Text = "Cmart@yahoo.com"
        '
        'Datepick
        '
        Me.Datepick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Datepick.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Datepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Datepick.Location = New System.Drawing.Point(160, 187)
        Me.Datepick.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Datepick.MaxDate = New Date(2015, 12, 31, 0, 0, 0, 0)
        Me.Datepick.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Datepick.Name = "Datepick"
        Me.Datepick.Size = New System.Drawing.Size(319, 35)
        Me.Datepick.TabIndex = 15
        Me.Datepick.Value = New Date(1970, 7, 19, 0, 0, 0, 0)
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveBtn.FlatAppearance.BorderSize = 2
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.saveBtn.Font = New System.Drawing.Font("Arial Unicode MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveBtn.Location = New System.Drawing.Point(6, 9)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(151, 63)
        Me.saveBtn.TabIndex = 16
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'insuranceCheck
        '
        Me.insuranceCheck.AutoSize = True
        Me.insuranceCheck.BackColor = System.Drawing.Color.Black
        Me.insuranceCheck.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insuranceCheck.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.insuranceCheck.Location = New System.Drawing.Point(291, 332)
        Me.insuranceCheck.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.insuranceCheck.Name = "insuranceCheck"
        Me.insuranceCheck.Size = New System.Drawing.Size(202, 34)
        Me.insuranceCheck.TabIndex = 18
        Me.insuranceCheck.Text = "Include Insurance"
        Me.insuranceCheck.UseVisualStyleBackColor = False
        '
        'insuranceBox
        '
        Me.insuranceBox.BackColor = System.Drawing.Color.Black
        Me.insuranceBox.Controls.Add(Me.txtPlanID)
        Me.insuranceBox.Controls.Add(Me.txtSubsID)
        Me.insuranceBox.Controls.Add(Me.comboPlan)
        Me.insuranceBox.Controls.Add(Me.comboProvider)
        Me.insuranceBox.Controls.Add(Me.Label7)
        Me.insuranceBox.Controls.Add(Me.Label8)
        Me.insuranceBox.Controls.Add(Me.Label9)
        Me.insuranceBox.Controls.Add(Me.Label10)
        Me.insuranceBox.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.insuranceBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.insuranceBox.Location = New System.Drawing.Point(525, 94)
        Me.insuranceBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.insuranceBox.Name = "insuranceBox"
        Me.insuranceBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.insuranceBox.Size = New System.Drawing.Size(474, 249)
        Me.insuranceBox.TabIndex = 19
        Me.insuranceBox.TabStop = False
        Me.insuranceBox.Text = "Insurance"
        Me.insuranceBox.Visible = False
        '
        'txtPlanID
        '
        Me.txtPlanID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtPlanID.Location = New System.Drawing.Point(240, 188)
        Me.txtPlanID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPlanID.Name = "txtPlanID"
        Me.txtPlanID.Size = New System.Drawing.Size(221, 35)
        Me.txtPlanID.TabIndex = 13
        Me.txtPlanID.Text = "1001"
        '
        'txtSubsID
        '
        Me.txtSubsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtSubsID.Location = New System.Drawing.Point(240, 137)
        Me.txtSubsID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSubsID.Name = "txtSubsID"
        Me.txtSubsID.Size = New System.Drawing.Size(221, 35)
        Me.txtSubsID.TabIndex = 12
        Me.txtSubsID.Text = "9375258"
        '
        'comboPlan
        '
        Me.comboPlan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.comboPlan.FormattingEnabled = True
        Me.comboPlan.Items.AddRange(New Object() {"HMO", "PPO"})
        Me.comboPlan.Location = New System.Drawing.Point(240, 86)
        Me.comboPlan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comboPlan.Name = "comboPlan"
        Me.comboPlan.Size = New System.Drawing.Size(221, 37)
        Me.comboPlan.TabIndex = 11
        '
        'comboProvider
        '
        Me.comboProvider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProvider.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.comboProvider.FormattingEnabled = True
        Me.comboProvider.Items.AddRange(New Object() {"Blue Cross Blue Shield", "Humana", "Kaiser Permanente", "Aetna", "United Healthcare", "Cigna", "Assurant", "Estrella"})
        Me.comboProvider.Location = New System.Drawing.Point(240, 38)
        Me.comboProvider.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comboProvider.Name = "comboProvider"
        Me.comboProvider.Size = New System.Drawing.Size(221, 37)
        Me.comboProvider.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.insuranceCheck)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Datepick)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(26, 94)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(494, 378)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.closeBtn.FlatAppearance.BorderSize = 2
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.closeBtn.Font = New System.Drawing.Font("Arial Unicode MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Firebrick
        Me.closeBtn.Location = New System.Drawing.Point(244, 9)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(151, 63)
        Me.closeBtn.TabIndex = 21
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Arial Unicode MS", 19.8!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(-28, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1080, 42)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "ADD NEW PATIENT"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial Unicode MS", 19.8!)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnExit.Location = New System.Drawing.Point(950, 2)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 41)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'statStrip
        '
        Me.statStrip.AutoSize = False
        Me.statStrip.BackColor = System.Drawing.Color.Black
        Me.statStrip.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statLabel})
        Me.statStrip.Location = New System.Drawing.Point(0, 593)
        Me.statStrip.Name = "statStrip"
        Me.statStrip.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.statStrip.Size = New System.Drawing.Size(1024, 31)
        Me.statStrip.SizingGrip = False
        Me.statStrip.TabIndex = 24
        '
        'statLabel
        '
        Me.statLabel.Name = "statLabel"
        Me.statLabel.Size = New System.Drawing.Size(0, 26)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.saveBtn)
        Me.Panel1.Location = New System.Drawing.Point(364, 486)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 81)
        Me.Panel1.TabIndex = 25
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'patientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = Global.Asg2.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.statStrip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.insuranceBox)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "patientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "patientForm"
        Me.insuranceBox.ResumeLayout(False)
        Me.insuranceBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.statStrip.ResumeLayout(False)
        Me.statStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Datepick As DateTimePicker
    Friend WithEvents saveBtn As Button
    Friend WithEvents insuranceCheck As CheckBox
    Friend WithEvents insuranceBox As GroupBox
    Friend WithEvents txtPlanID As TextBox
    Friend WithEvents txtSubsID As TextBox
    Friend WithEvents comboPlan As ComboBox
    Friend WithEvents comboProvider As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents statStrip As StatusStrip
    Friend WithEvents statLabel As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
