<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.txtVirtualFolder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBaseName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.cbShowErrors = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server name or address:"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(15, 44)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(188, 20)
        Me.txtServerName.TabIndex = 1
        Me.txtServerName.Text = "support1"
        '
        'txtVirtualFolder
        '
        Me.txtVirtualFolder.Location = New System.Drawing.Point(15, 95)
        Me.txtVirtualFolder.Name = "txtVirtualFolder"
        Me.txtVirtualFolder.Size = New System.Drawing.Size(188, 20)
        Me.txtVirtualFolder.TabIndex = 3
        Me.txtVirtualFolder.Text = "DocsVision45"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Virtual folder name:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(499, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Use basic authentication"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Enabled = False
        Me.txtLogin.Location = New System.Drawing.Point(583, 44)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(234, 20)
        Me.txtLogin.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Login:"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(583, 70)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(234, 20)
        Me.txtPassword.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(744, 454)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(224, 44)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(188, 20)
        Me.txtPort.TabIndex = 9
        Me.txtPort.Text = "8888"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Port (for HTTP connections):"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 177)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(802, 240)
        Me.txtResult.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Result:"
        '
        'txtBaseName
        '
        Me.txtBaseName.Location = New System.Drawing.Point(224, 94)
        Me.txtBaseName.Name = "txtBaseName"
        Me.txtBaseName.Size = New System.Drawing.Size(188, 20)
        Me.txtBaseName.TabIndex = 13
        Me.txtBaseName.Text = "dv1988"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Base name:"
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(15, 454)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(723, 23)
        Me.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbProgress.TabIndex = 27
        Me.pbProgress.Visible = False
        '
        'cbShowErrors
        '
        Me.cbShowErrors.AutoSize = True
        Me.cbShowErrors.Location = New System.Drawing.Point(499, 98)
        Me.cbShowErrors.Name = "cbShowErrors"
        Me.cbShowErrors.Size = New System.Drawing.Size(138, 17)
        Me.cbShowErrors.TabIndex = 28
        Me.cbShowErrors.Text = "Show connection errors"
        Me.cbShowErrors.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 505)
        Me.Controls.Add(Me.cbShowErrors)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.txtBaseName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtVirtualFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "DocsVisionSpeedTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents txtVirtualFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBaseName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents cbShowErrors As System.Windows.Forms.CheckBox

End Class
