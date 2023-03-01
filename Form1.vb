Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LblRegi.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblGSize.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblReg.Click

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        If IsNumeric(TxtGroup.Text) Then
            intGroup = Convert.ToInt32(TxtGroup.Text)
            If intGroup > 0 And intGroup < 20 Then
                If RBtnConSup.Checked Then
                    decRegistration = decSuperHero
                ElseIf RBtnConAuto.Checked Then
                    decRegistration = decAutographs
                ElseIf RBtnCon.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = intGroup * decRegistration
                LblRegTotal.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a possitive number between 1 - 20", , "Invalid Number Error")
            End If
        Else
            MsgBox("Enter a reasonable number between 1 - 20", , "Invalid Number Error")
        End If

    End Sub

    Private Sub BnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtGroup.Clear()
        LblRegTotal.Text = " "
        RBtnConSup.Checked = True
        RBtnConAuto.Checked = False
        RBtnCon.Checked = False

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        LblRegTotal.Text = " "
    End Sub
End Class
