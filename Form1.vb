


Public Class Form1
    Dim x As Double
    Dim y As Double



    Private Sub txtT_TextChanged(sender As Object, e As EventArgs) Handles txtT.TextChanged
        Try
            x = Convert.ToDouble(txtT.Text)

        Catch ex As Exception
            txtT.Text = ""
            x = 0
            y = 0


        End Try
    End Sub

    Private Sub cmdCeiling_Click(sender As Object, e As EventArgs) Handles cmdCeiling.Click
        txtT.Text = Math.Ceiling(x)
    End Sub

    Private Sub cmdFloor_Click(sender As Object, e As EventArgs) Handles cmdFloor.Click
        txtT.Text = Math.Floor(x)
    End Sub

    Private Sub cmdRound_Click(sender As Object, e As EventArgs) Handles cmdRound.Click
        txtT.Text = Math.Round(x)
    End Sub

    Private Sub cmdTruncate_Click(sender As Object, e As EventArgs) Handles cmdTruncate.Click
        txtT.Text = Math.Truncate(x)
    End Sub

    Private Sub CmdC_Click(sender As Object, e As EventArgs) Handles CmdC.Click
        txtT.Text = ""
    End Sub

    Private Sub cmdBS_Click(sender As Object, e As EventArgs) Handles cmdBS.Click
        txtT.Text = txtT.Text.Substring(0, txtT.Text.Length - 1)
    End Sub

    Private Sub cmdPlusMinus_Click(sender As Object, e As EventArgs) Handles cmdPlusMinus.Click
        txtT.Text = x * -1.0
    End Sub

    Private Sub cmd1durchX_Click(sender As Object, e As EventArgs) Handles cmd1durchX.Click
        txtT.Text = 1.0 / x
    End Sub

    Private Sub cmdPi_Click(sender As Object, e As EventArgs) Handles cmdPi.Click
        txtT.Text = Math.PI
    End Sub

    Private Sub cmdE_Click(sender As Object, e As EventArgs) Handles cmdE.Click
        txtT.Text = Math.E
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click, cmd9.Click, cmd8.Click, cmd7.Click, cmd6.Click, cmd5.Click, cmd4.Click, cmd3.Click, cmd2.Click, cmd1.Click
        txtT.Text &= sender.Text
    End Sub

    Private Sub cmdKomma_Click(sender As Object, e As EventArgs) Handles cmdKomma.Click
        If txtT.Text.IndexOf(",") < 0 Then
            txtT.Text &= ","
        End If
    End Sub

    Private Sub cmdX2_Click(sender As Object, e As EventArgs) Handles cmdX2.Click
        If chkInv.Checked Then
            txtT.Text = Math.Sqrt(x)
        Else
            txtT.Text = Math.Pow(x, 2.0)
        End If
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        If chkInv.Checked Then
            txtT.Text = Math.Asin(x) * 180 / Math.PI
            chkInv.Checked = False
        Else
            txtT.Text = Math.Sin(x / 180.0 * Math.PI)
        End If

    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        If chkInv.Checked Then
            txtT.Text = Math.Acos(x) * 180 / Math.PI
            chkInv.Checked = False
        Else
            txtT.Text = Math.Cos(x / 180.0 * Math.PI)
        End If
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        If chkInv.Checked Then
            txtT.Text = Math.Atan(x) * 180 / Math.PI
            chkInv.Checked = False
        Else
            txtT.Text = Math.Tan(x / 180.0 * Math.PI)
        End If
    End Sub

    Private Sub cmdLn_Click(sender As Object, e As EventArgs) Handles cmdLn.Click
        If chkInv.Checked Then
            txtT.Text = Math.Exp(x)
            chkInv.Checked = False
        Else
            txtT.Text = Math.Log(x)
        End If
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        If chkInv.Checked Then
            txtT.Text = Math.Pow(10.0, x)
            chkInv.Checked = False
        Else
            txtT.Text = Math.Log10(x)
        End If
    End Sub


End Class
