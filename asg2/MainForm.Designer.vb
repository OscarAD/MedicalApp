<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.patientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.patientAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.patientList = New System.Windows.Forms.ToolStripMenuItem()
        Me.patientFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.physicianMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.patientMenu, Me.physicianMenu, Me.AppointmentsToolStripMenuItem, Me.aboutProgram})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 42)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'patientMenu
        '
        Me.patientMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.patientAdd, Me.patientList, Me.patientFind})
        Me.patientMenu.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientMenu.ForeColor = System.Drawing.SystemColors.Desktop
        Me.patientMenu.Name = "patientMenu"
        Me.patientMenu.Size = New System.Drawing.Size(116, 38)
        Me.patientMenu.Text = "Patient"
        '
        'patientAdd
        '
        Me.patientAdd.Name = "patientAdd"
        Me.patientAdd.Size = New System.Drawing.Size(152, 36)
        Me.patientAdd.Text = "Add"
        '
        'patientList
        '
        Me.patientList.Name = "patientList"
        Me.patientList.Size = New System.Drawing.Size(152, 36)
        Me.patientList.Text = "List"
        '
        'patientFind
        '
        Me.patientFind.Name = "patientFind"
        Me.patientFind.Size = New System.Drawing.Size(152, 36)
        Me.patientFind.Text = "Find"
        '
        'physicianMenu
        '
        Me.physicianMenu.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!)
        Me.physicianMenu.ForeColor = System.Drawing.SystemColors.Desktop
        Me.physicianMenu.Name = "physicianMenu"
        Me.physicianMenu.Size = New System.Drawing.Size(138, 38)
        Me.physicianMenu.Text = "Physician"
        '
        'AppointmentsToolStripMenuItem
        '
        Me.AppointmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduleToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.AppointmentsToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!)
        Me.AppointmentsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem"
        Me.AppointmentsToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.AppointmentsToolStripMenuItem.Text = "Appointments"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'aboutProgram
        '
        Me.aboutProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.aboutProgram.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!)
        Me.aboutProgram.ForeColor = System.Drawing.SystemColors.Desktop
        Me.aboutProgram.Name = "aboutProgram"
        Me.aboutProgram.Size = New System.Drawing.Size(84, 38)
        Me.aboutProgram.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(281, 36)
        Me.AboutToolStripMenuItem.Text = "About Program"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnExit.Location = New System.Drawing.Point(933, 1)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 41)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Black
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDateTime.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblDateTime.Location = New System.Drawing.Point(0, 583)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(1024, 41)
        Me.lblDateTime.TabIndex = 25
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BackgroundImage = Global.Asg2.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 624)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents patientMenu As ToolStripMenuItem
    Friend WithEvents patientAdd As ToolStripMenuItem
    Friend WithEvents physicianMenu As ToolStripMenuItem
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents aboutProgram As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents patientList As ToolStripMenuItem
    Friend WithEvents patientFind As ToolStripMenuItem
    Friend WithEvents AppointmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
End Class
