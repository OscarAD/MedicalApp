<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class patientFindForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.onlyLastCheck = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Datepick = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.onlyLastCheck)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Datepick)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(259, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(494, 378)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient"
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
        'onlyLastCheck
        '
        Me.onlyLastCheck.AutoSize = True
        Me.onlyLastCheck.BackColor = System.Drawing.Color.Black
        Me.onlyLastCheck.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onlyLastCheck.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.onlyLastCheck.Location = New System.Drawing.Point(214, 329)
        Me.onlyLastCheck.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.onlyLastCheck.Name = "onlyLastCheck"
        Me.onlyLastCheck.Size = New System.Drawing.Size(274, 34)
        Me.onlyLastCheck.TabIndex = 18
        Me.onlyLastCheck.Text = "Search only by last name"
        Me.onlyLastCheck.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(22, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last name:"
        '
        'Datepick
        '
        Me.Datepick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Datepick.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Datepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Datepick.Location = New System.Drawing.Point(160, 216)
        Me.Datepick.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Datepick.MaxDate = New Date(2015, 12, 31, 0, 0, 0, 0)
        Me.Datepick.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Datepick.Name = "Datepick"
        Me.Datepick.Size = New System.Drawing.Size(319, 35)
        Me.Datepick.TabIndex = 15
        Me.Datepick.Value = New Date(2011, 1, 11, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 214)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of birth:"
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtLname.Location = New System.Drawing.Point(160, 154)
        Me.txtLname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(319, 29)
        Me.txtLname.TabIndex = 12
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtFname.Location = New System.Drawing.Point(160, 91)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(319, 29)
        Me.txtFname.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.searchBtn)
        Me.Panel1.Location = New System.Drawing.Point(305, 478)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 81)
        Me.Panel1.TabIndex = 29
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
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchBtn.FlatAppearance.BorderSize = 2
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.searchBtn.Font = New System.Drawing.Font("Arial Unicode MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchBtn.Location = New System.Drawing.Point(6, 9)
        Me.searchBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(151, 63)
        Me.searchBtn.TabIndex = 16
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
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
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "PATIENT SEARCH"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 593)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 31)
        Me.StatusStrip1.TabIndex = 30
        '
        'statLabel
        '
        Me.statLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.statLabel.Name = "statLabel"
        Me.statLabel.Size = New System.Drawing.Size(0, 26)
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'patientFindForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Asg2.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 624)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "patientFindForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "patientFindForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents onlyLastCheck As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Datepick As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBtn As Button
    Friend WithEvents searchBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statLabel As ToolStripStatusLabel
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
