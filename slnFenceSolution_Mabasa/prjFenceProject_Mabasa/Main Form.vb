Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Display total cost

        Dim fence As New Rectangle

        Dim dblPerimeter As Double
        Dim dblPrice As Double
        Dim dblTotalCost As Double

        Double.TryParse(txtLength.Text, fence.Length)
        Double.TryParse(txtWidth.Text, fence.Width)
        Double.TryParse(txtCost.Text, dblPrice)

        'calculate
        dblPerimeter = fence.GetPerimeter
        dblTotalCost = dblPerimeter * dblPrice

        'display
        lblTotalCost.Text = dblTotalCost.ToString("C2")
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtLength.TextChanged, txtCost.TextChanged, txtWidth.TextChanged
        lblTotalCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub SelectAll(sender As Object, e As EventArgs) Handles txtLength.Click, txtCost.Click, txtWidth.Click
        txtCost.SelectAll()
        txtLength.SelectAll()
        txtWidth.SelectAll()
    End Sub

    Private Sub txtPrice1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress, txtLength.KeyPress, txtWidth.KeyPress
        ' allow only numbers and the Backspace, dot

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
