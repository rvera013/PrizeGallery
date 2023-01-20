Public Class frmMain
    Private IntResult As Integer
    Private sngWinnings As Single
    Private rndVal As New Random

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblForfeit.Visible = False
        timSpin.Start()
    End Sub

    Private Sub timSpin_Tick(sender As Object, e As EventArgs) Handles timSpin.Tick
        lblResult.Text = rndVal.Next(500)
        lblResult.Refresh()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timSpin.Stop()
        If lblResult.Text <> "" Then
            CalculateWinnings()
        End If
    End Sub
    Private Sub CalculateWinnings()
        Dim intSpinVal As Integer
        Dim intPriceNum As Integer
        Dim sngPrizeVal As Single
        Dim strImage As String
        intSpinVal = CInt(lblResult.Text) 'convert the label's contents to an integer'
        Select Case intSpinVal
            Case Is < 100
                intPriceNum = 1
                sngPrizeVal = 50
                strImage = "Prize-1.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize

            Case Is < 200
                intPriceNum = 2
                sngPrizeVal = 75
                strImage = "Prize-2.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Is < 300
                intPriceNum = 3
                sngPrizeVal = 60
                strImage = "Prize-3.png"
                picPrize.SizeMode = PictureBoxSizeMode.AutoSize
            Case Else 'default. For any other value no in the case statement"
                intPriceNum = 4
                sngPrizeVal = 0
                strImage = "consolation price.png"
                picPrize.SizeMode = PictureBoxSizeMode.Zoom
                lblForfeit.Visible = True

        End Select
    End Sub
End Class
