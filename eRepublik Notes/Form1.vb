Public Class Form1
    <System.Runtime.InteropServices.DllImport("user32")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Dim ok As Boolean = False
    Dim ok2 As Boolean = True
    Dim hotkey As Boolean
    Dim efectID As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        scurtatura.Start()
        efect_inceput.Interval = 500
        efect_sfarsit.Interval = 15
        avertisment.Interval = 100
        intarziere.Interval = 400
    End Sub

    Private Sub pornire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pornire.Click
        pornire.Visible = 0
        oprire.Visible = 1
        efect_inceput.Start()
        reclama.Enabled = 0
        buton_informatii.Enabled = 0
        buton_credite.Enabled = 0
        cronometru_interval.Enabled = 0
        efect.Enabled = 0
        scurtatura.Stop()
        ok = True
    End Sub

    Private Sub pornire_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pornire.MouseEnter
        pornire.Image = My.Resources.start2
    End Sub

    Private Sub pornire_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pornire.MouseLeave
        pornire.Image = My.Resources.start1
    End Sub

    Private Sub oprire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oprire.Click
        pornire.Visible = 1
        oprire.Visible = 0
        efect_inceput.Stop()
        reclama.Enabled = 1
        buton_informatii.Enabled = 1
        buton_credite.Enabled = 1
        cronometru_interval.Enabled = 1
        efect.Enabled = 1
        scurtatura.Start()
        ok = False
    End Sub

    Private Sub oprire_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles oprire.MouseEnter
        oprire.Image = My.Resources.stop2
    End Sub

    Private Sub oprire_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles oprire.MouseLeave
        oprire.Image = My.Resources.stop1
    End Sub

    Private Sub cronometru_interval_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cronometru_interval.ValueChanged
        efect_inceput.Interval = cronometru_interval.Value
    End Sub

    Private Sub efect_inceput_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efect_inceput.Tick
        If efectID = 0 Then
            avertisment.Start()
        ElseIf efectID = 1 Then
            SendKeys.Send("[ [ ")
            avertisment.Start()
        ElseIf efectID = 2 Then
            SendKeys.Send(">>> ")
            avertisment.Start()
        ElseIf efectID = 3 Then
            SendKeys.Send("=== ")
            avertisment.Start()
        End If
    End Sub

    Private Sub efect_sfarsit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efect_sfarsit.Tick
        If efectID = 1 Then
            SendKeys.Send(" ] ]")
        ElseIf efectID = 2 Then
            SendKeys.Send(" <<<")
        ElseIf efectID = 3 Then
            SendKeys.Send(" ===")
        End If
        SendKeys.Send("{ENTER}")
        efect_sfarsit.Stop()
    End Sub

    Private Sub avertisment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles avertisment.Tick
        If efectID = 0 Then
            SendKeys.Send(reclama.Text & "{ENTER}")
        ElseIf efectID = 1 Then
            SendKeys.Send(reclama.Text)
            efect_sfarsit.Start()
        ElseIf efectID = 2 Then
            SendKeys.Send(reclama.Text)
            efect_sfarsit.Start()
        ElseIf efectID = 3 Then
            SendKeys.Send(reclama.Text)
            efect_sfarsit.Start()
        End If
        avertisment.Stop()
    End Sub

    Private Sub scuratura_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scurtatura.Tick
        hotkey = GetAsyncKeyState(Keys.F12)
        If ok2 Then
            If hotkey = True Then
                If ok = False Then
                    pornire.Visible = 0
                    oprire.Visible = 1
                    efect_inceput.Start()
                    reclama.Enabled = 0
                    buton_informatii.Enabled = 0
                    buton_credite.Enabled = 0
                    cronometru_interval.Enabled = 0
                    efect.Enabled = 0
                    ok = True
                    ok2 = False
                    intarziere.Start()
                ElseIf ok = True Then
                    pornire.Visible = 1
                    oprire.Visible = 0
                    efect_inceput.Stop()
                    reclama.Enabled = 1
                    buton_informatii.Enabled = 1
                    buton_credite.Enabled = 1
                    cronometru_interval.Enabled = 1
                    efect.Enabled = 1
                    ok = False
                    ok2 = False
                    intarziere.Start()
                End If
            End If
        End If
    End Sub

    Private Sub intarziere_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intarziere.Tick
        ok2 = True
        intarziere.Stop()
    End Sub

    Private Sub buton_credite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buton_credite.Click
        MsgBox("Advertiser 1.0" & vbNewLine & vbNewLine & "Made by Horatiu Mlendea" & vbNewLine)
    End Sub

    Private Sub buton_informatii_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buton_informatii.Click
        MsgBox("Usage:" & vbNewLine & vbNewLine & vbNewLine & "1. Write your advertisment in the textbox" & vbNewLine & vbNewLine & "2. Choose the milliseconds interval between messages (1000 = 1 second)" & vbNewLine & vbNewLine & "3. Click Start or use the F12 Hotkey tostart it" & vbNewLine & vbNewLine & "4. Your active window will recive the messages" & vbNewLine & vbNewLine & "5. Click Stop or use the F12 Hotkey to stop it")
    End Sub

    Private Sub efect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles efect.SelectedIndexChanged
        If efect.Text = "" Then
            efectID = 0
        ElseIf efect.Text = "[ [                   ] ]" Then
            efectID = 1
        ElseIf efect.Text = ">>>             <<<" Then
            efectID = 2
        ElseIf efect.Text = "===                 ===" Then
            efectID = 3
        End If
    End Sub
End Class
