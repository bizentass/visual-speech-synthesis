Public Class Mainfrm

    Private Sub Okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Okbtn.Click
        If RadioButton1.Checked = True Then
            AnimateFaceGM.Show()
        ElseIf femalebtn.Checked = True Then
            AnimateFaceG.Show()
        ElseIf realbtn.Checked = True Then
            AnimateFaceRM.Show()
        End If

    End Sub

    Private Sub Cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label.Click

    End Sub
End Class
