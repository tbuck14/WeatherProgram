<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWeatherReport = New System.Windows.Forms.Label()
        Me.btnCloudy = New System.Windows.Forms.Button()
        Me.btnRainy = New System.Windows.Forms.Button()
        Me.btnSnowy = New System.Windows.Forms.Button()
        Me.btnSunny = New System.Windows.Forms.Button()
        Me.picSunny = New System.Windows.Forms.PictureBox()
        Me.picSnowy = New System.Windows.Forms.PictureBox()
        Me.picRainy = New System.Windows.Forms.PictureBox()
        Me.picCloud = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picSunny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnowy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRainy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCloud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(521, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWeatherReport
        '
        Me.lblWeatherReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeatherReport.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeatherReport.Location = New System.Drawing.Point(75, 307)
        Me.lblWeatherReport.Name = "lblWeatherReport"
        Me.lblWeatherReport.Size = New System.Drawing.Size(308, 109)
        Me.lblWeatherReport.TabIndex = 1
        '
        'btnCloudy
        '
        Me.btnCloudy.Location = New System.Drawing.Point(75, 72)
        Me.btnCloudy.Name = "btnCloudy"
        Me.btnCloudy.Size = New System.Drawing.Size(75, 23)
        Me.btnCloudy.TabIndex = 2
        Me.btnCloudy.Text = "&Cloudy"
        Me.ToolTip1.SetToolTip(Me.btnCloudy, "Cloudy")
        Me.btnCloudy.UseVisualStyleBackColor = True
        '
        'btnRainy
        '
        Me.btnRainy.Location = New System.Drawing.Point(75, 125)
        Me.btnRainy.Name = "btnRainy"
        Me.btnRainy.Size = New System.Drawing.Size(75, 23)
        Me.btnRainy.TabIndex = 4
        Me.btnRainy.Text = "&Rainy"
        Me.ToolTip1.SetToolTip(Me.btnRainy, "Rainy")
        Me.btnRainy.UseVisualStyleBackColor = True
        '
        'btnSnowy
        '
        Me.btnSnowy.Location = New System.Drawing.Point(75, 180)
        Me.btnSnowy.Name = "btnSnowy"
        Me.btnSnowy.Size = New System.Drawing.Size(75, 23)
        Me.btnSnowy.TabIndex = 6
        Me.btnSnowy.Text = "&Snowy"
        Me.ToolTip1.SetToolTip(Me.btnSnowy, "Snowy")
        Me.btnSnowy.UseVisualStyleBackColor = True
        '
        'btnSunny
        '
        Me.btnSunny.Location = New System.Drawing.Point(75, 235)
        Me.btnSunny.Name = "btnSunny"
        Me.btnSunny.Size = New System.Drawing.Size(75, 23)
        Me.btnSunny.TabIndex = 8
        Me.btnSunny.Text = "S&unny"
        Me.ToolTip1.SetToolTip(Me.btnSunny, "Sunny")
        Me.btnSunny.UseVisualStyleBackColor = True
        '
        'picSunny
        '
        Me.picSunny.Image = Global.WindowsApp1.My.Resources.Resources.sunny_Trump
        Me.picSunny.Location = New System.Drawing.Point(385, 154)
        Me.picSunny.Name = "picSunny"
        Me.picSunny.Size = New System.Drawing.Size(138, 104)
        Me.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSunny.TabIndex = 9
        Me.picSunny.TabStop = False
        Me.picSunny.Visible = False
        '
        'picSnowy
        '
        Me.picSnowy.Image = Global.WindowsApp1.My.Resources.Resources.Snow
        Me.picSnowy.Location = New System.Drawing.Point(385, 29)
        Me.picSnowy.Name = "picSnowy"
        Me.picSnowy.Size = New System.Drawing.Size(138, 102)
        Me.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnowy.TabIndex = 7
        Me.picSnowy.TabStop = False
        Me.picSnowy.Visible = False
        '
        'picRainy
        '
        Me.picRainy.Image = Global.WindowsApp1.My.Resources.Resources.Rain
        Me.picRainy.Location = New System.Drawing.Point(226, 154)
        Me.picRainy.Name = "picRainy"
        Me.picRainy.Size = New System.Drawing.Size(131, 105)
        Me.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRainy.TabIndex = 5
        Me.picRainy.TabStop = False
        Me.picRainy.Visible = False
        '
        'picCloud
        '
        Me.picCloud.Image = Global.WindowsApp1.My.Resources.Resources.cloud
        Me.picCloud.Location = New System.Drawing.Point(223, 29)
        Me.picCloud.Name = "picCloud"
        Me.picCloud.Size = New System.Drawing.Size(134, 102)
        Me.picCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCloud.TabIndex = 3
        Me.picCloud.TabStop = False
        Me.picCloud.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 450)
        Me.Controls.Add(Me.picSunny)
        Me.Controls.Add(Me.btnSunny)
        Me.Controls.Add(Me.picSnowy)
        Me.Controls.Add(Me.btnSnowy)
        Me.Controls.Add(Me.picRainy)
        Me.Controls.Add(Me.btnRainy)
        Me.Controls.Add(Me.picCloud)
        Me.Controls.Add(Me.btnCloudy)
        Me.Controls.Add(Me.lblWeatherReport)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picSunny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnowy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRainy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCloud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblWeatherReport As Label
    Friend WithEvents btnCloudy As Button
    Friend WithEvents picCloud As PictureBox
    Friend WithEvents btnRainy As Button
    Friend WithEvents picRainy As PictureBox
    Friend WithEvents btnSnowy As Button
    Friend WithEvents picSnowy As PictureBox
    Friend WithEvents btnSunny As Button
    Friend WithEvents picSunny As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
