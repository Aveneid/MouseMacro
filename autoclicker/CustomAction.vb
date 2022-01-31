Imports System.Windows.Forms

Public Class CustomAction

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles action.SelectedValueChanged
        Select Case action.SelectedItem
            Case "# Set Cursor pos"
                arg.Visible = False
                arg.Enabled = False
                argLb.Visible = False
                yTb.Visible = True
                xTb.Visible = True
                xTb.Enabled = True
                yTb.Enabled = True
                yLb.Visible = True
                xLb.Visible = True

            Case "! Wait"
                arg.Visible = True
                arg.Enabled = True
                argLb.Text = "Time (ms)"
                argLb.Visible = True
                xTb.Enabled = False
                yTb.Enabled = False
                yTb.Visible = False
                xTb.Visible = False
                xLb.Visible = False
                yLb.Visible = False

            Case "( Left Click"
                arg.Enabled = False
                arg.Visible = False
                xTb.Enabled = False
                yTb.Enabled = False
                yTb.Visible = False
                xTb.Visible = False
                xLb.Visible = False
                yLb.Visible = False
                argLb.Visible = False
            Case ") Right Click"
                arg.Enabled = False
                arg.Visible = False
                xTb.Enabled = False
                yTb.Enabled = False
                yTb.Visible = False
                xTb.Visible = False
                xLb.Visible = False
                yLb.Visible = False
                argLb.Visible = False

        End Select
    End Sub
    Private Sub CustomAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        action.SelectedIndex = 0
    End Sub
End Class
