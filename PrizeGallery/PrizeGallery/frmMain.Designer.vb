<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblWinnings = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPriceVal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblForfeit = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Label()
        Me.picPrize = New System.Windows.Forms.PictureBox()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Panther Price Gallery - Spin to Win Prices"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(18, 66)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(153, 45)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinnings
        '
        Me.lblWinnings.BackColor = System.Drawing.Color.White
        Me.lblWinnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinnings.Location = New System.Drawing.Point(18, 220)
        Me.lblWinnings.Name = "lblWinnings"
        Me.lblWinnings.Size = New System.Drawing.Size(153, 45)
        Me.lblWinnings.TabIndex = 2
        Me.lblWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Your total winnings"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPriceVal
        '
        Me.lblPriceVal.BackColor = System.Drawing.Color.White
        Me.lblPriceVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceVal.Location = New System.Drawing.Point(18, 141)
        Me.lblPriceVal.Name = "lblPriceVal"
        Me.lblPriceVal.Size = New System.Drawing.Size(153, 47)
        Me.lblPriceVal.TabIndex = 4
        Me.lblPriceVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Prize Value"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblForfeit
        '
        Me.lblForfeit.BackColor = System.Drawing.Color.Transparent
        Me.lblForfeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForfeit.ForeColor = System.Drawing.Color.Red
        Me.lblForfeit.Location = New System.Drawing.Point(16, 278)
        Me.lblForfeit.Name = "lblForfeit"
        Me.lblForfeit.Size = New System.Drawing.Size(139, 30)
        Me.lblForfeit.TabIndex = 6
        Me.lblForfeit.Text = "You Lose!"
        Me.lblForfeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblForfeit.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(18, 319)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(153, 31)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Start the spin"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(18, 359)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(153, 31)
        Me.btnStop.TabIndex = 8
        Me.btnStop.Text = "Stop the spin"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.White
        Me.btnQuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(18, 400)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(153, 31)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picPrize
        '
        Me.picPrize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPrize.Image = Global.PrizeGallery.My.Resources.Resources.prize_1
        Me.picPrize.Location = New System.Drawing.Point(207, 72)
        Me.picPrize.Name = "picPrize"
        Me.picPrize.Size = New System.Drawing.Size(174, 263)
        Me.picPrize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPrize.TabIndex = 10
        Me.picPrize.TabStop = False
        '
        'timSpin
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picPrize)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblForfeit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPriceVal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWinnings)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "frmMain"
        Me.Text = "Mystery Prices"
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lblWinnings As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPriceVal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblForfeit As Label
    Friend WithEvents btnStart As Label
    Friend WithEvents btnStop As Label
    Friend WithEvents btnQuit As Label
    Friend WithEvents picPrize As PictureBox
    Friend WithEvents timSpin As Timer
End Class
