Public Class Form1
    'Trevor J. Buck'
    'CIS 125-01'
    'Fall 2018'
    'Mr. Hinz'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changed form back color'
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Ends Program'
        End

    End Sub

    Private Sub btnCloudy_Click(sender As Object, e As EventArgs) Handles btnCloudy.Click
        'displays cloud photo'
        picCloud.Visible = True
        picRainy.Visible = False
        picSnowy.Visible = False
        picSunny.Visible = False
        lblWeatherReport.Text = "The clouds will cover the sky today"

    End Sub

    Private Sub btnRainy_Click(sender As Object, e As EventArgs) Handles btnRainy.Click
        'displays rainy photo'
        picRainy.Visible = True
        picCloud.Visible = False
        picSnowy.Visible = False
        picSunny.Visible = False
        lblWeatherReport.Text = "Rain will shower the earth today"
    End Sub

    Private Sub btnSnowy_Click(sender As Object, e As EventArgs) Handles btnSnowy.Click
        'displays snowy photo'
        picSnowy.Visible = True
        picCloud.Visible = False
        picRainy.Visible = False
        picSunny.Visible = False
        lblWeatherReport.Text = "Snow is on the radar today"
    End Sub

    Private Sub btnSunny_Click(sender As Object, e As EventArgs) Handles btnSunny.Click
        'displays sunny photo'
        picSunny.Visible = True
        picCloud.Visible = False
        picRainy.Visible = False
        picSnowy.Visible = False
        lblWeatherReport.Text = "A sunny Trump will fill the sky today"


    End Sub
End Class
