<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomAction
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.action = New System.Windows.Forms.ComboBox()
        Me.argLb = New System.Windows.Forms.Label()
        Me.arg = New System.Windows.Forms.MaskedTextBox()
        Me.xLb = New System.Windows.Forms.Label()
        Me.yLb = New System.Windows.Forms.Label()
        Me.xTb = New System.Windows.Forms.NumericUpDown()
        Me.yTb = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.xTb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yTb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(70, 108)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Action"
        '
        'action
        '
        Me.action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.action.FormattingEnabled = True
        Me.action.Items.AddRange(New Object() {"# Set Cursor pos", "( Left Click", ") Right Click", "! Wait"})
        Me.action.Location = New System.Drawing.Point(73, 21)
        Me.action.Name = "action"
        Me.action.Size = New System.Drawing.Size(140, 21)
        Me.action.TabIndex = 2
        '
        'argLb
        '
        Me.argLb.AutoSize = True
        Me.argLb.Location = New System.Drawing.Point(12, 58)
        Me.argLb.Name = "argLb"
        Me.argLb.Size = New System.Drawing.Size(57, 13)
        Me.argLb.TabIndex = 3
        Me.argLb.Text = "Arguments"
        '
        'arg
        '
        Me.arg.Location = New System.Drawing.Point(75, 55)
        Me.arg.Name = "arg"
        Me.arg.Size = New System.Drawing.Size(138, 20)
        Me.arg.TabIndex = 5
        '
        'xLb
        '
        Me.xLb.AutoSize = True
        Me.xLb.Location = New System.Drawing.Point(35, 58)
        Me.xLb.Name = "xLb"
        Me.xLb.Size = New System.Drawing.Size(14, 13)
        Me.xLb.TabIndex = 6
        Me.xLb.Text = "X"
        Me.xLb.Visible = False
        '
        'yLb
        '
        Me.yLb.AutoSize = True
        Me.yLb.Location = New System.Drawing.Point(126, 58)
        Me.yLb.Name = "yLb"
        Me.yLb.Size = New System.Drawing.Size(14, 13)
        Me.yLb.TabIndex = 7
        Me.yLb.Text = "Y"
        '
        'xTb
        '
        Me.xTb.Location = New System.Drawing.Point(55, 55)
        Me.xTb.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.xTb.Name = "xTb"
        Me.xTb.Size = New System.Drawing.Size(65, 20)
        Me.xTb.TabIndex = 8
        '
        'yTb
        '
        Me.yTb.Location = New System.Drawing.Point(146, 56)
        Me.yTb.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.yTb.Name = "yTb"
        Me.yTb.Size = New System.Drawing.Size(65, 20)
        Me.yTb.TabIndex = 9
        '
        'CustomAction
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(228, 149)
        Me.Controls.Add(Me.yTb)
        Me.Controls.Add(Me.xTb)
        Me.Controls.Add(Me.yLb)
        Me.Controls.Add(Me.xLb)
        Me.Controls.Add(Me.arg)
        Me.Controls.Add(Me.argLb)
        Me.Controls.Add(Me.action)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomAction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add action..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.xTb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yTb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents action As ComboBox
    Friend WithEvents argLb As Label
    Friend WithEvents arg As MaskedTextBox
    Friend WithEvents xLb As Label
    Friend WithEvents yLb As Label
    Friend WithEvents xTb As NumericUpDown
    Friend WithEvents yTb As NumericUpDown
End Class
