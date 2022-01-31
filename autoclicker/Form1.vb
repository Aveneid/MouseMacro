﻿Imports System.Threading

Public Class Form1
    Dim recording As Boolean = False
    Dim t As New Thread(AddressOf execMacro)
    Public Structure POINTAPI
        Public Property X As Int32
        Public Property Y As Int32
    End Structure

    Dim p As POINTAPI
    Public Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Boolean
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If recording = False Then
            Button1.Text = "Stop"
            recording = True
            Me.KeyPreview = True
        Else
            Button1.Text = "Record"
            recording = False
            Me.KeyPreview = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If recording = False Then
            t = New Thread(AddressOf execMacro)
            Select Case t.ThreadState
                Case ThreadState.Suspended
                    t.Resume()
                    ToolStripStatusLabel1.Text = "Running"
                Case ThreadState.Stopped
                Case ThreadState.Aborted
                Case ThreadState.Unstarted
                    t.Start()
                    ToolStripStatusLabel1.Text = "Running"
                Case ThreadState.Running
                    t.Abort()
                    ToolStripStatusLabel1.Text = "Waiting"
            End Select
        End If
    End Sub

    Sub execMacro()
        'SetCursorPos(0, 0)
        For Each i As ListViewItem In ListBox1.Items
            Select Case i.Text.Substring(1, 1)
                Case "#"
                    SetCursorPos(i.Text.Substring(2).Split(",")(0), i.Text.Substring(3).Split(",")(1))
                Case "("
                    mouse_event(&H2, 0, 0, 0, 0)
                    mouse_event(&H4, 0, 0, 0, 0)
                Case ")"
                    mouse_event(&H8, 0, 0, 0, 0)
                    mouse_event(&H10, 0, 0, 0, 0)
                Case "!"
                    t.Sleep(Int(i.Text.Substring(2)))
            End Select
            If i.Index = ListBox1.Items.Count Then
                t.Abort()
                StatusStrip1.Text = "Waiting...."
            End If
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.KeyPreview = False
                recording = False
                Button1.Text = "Record"
            Case Keys.Insert
                GetCursorPos(p)
                ListBox1.Items.Add(New ListViewItem(" # " & CStr(p.X) & "," & CStr(p.Y)))
            Case Keys.PageUp
                ListBox1.Items.Add(New ListViewItem(" ( Left click"))
            Case Keys.PageDown
                ListBox1.Items.Add(New ListViewItem(" ( Right Click"))
            Case Keys.Home
                Dim ms = InputBox("Time in ms: ")
                While Not IsNumeric(ms) Or ms < 0
                    ms = InputBox("Time in ms: ")
                End While
                If ms.Length > 0 Then
                    ListBox1.Items.Add(New ListViewItem(" ! " & ms))
                End If
            Case Keys.Delete
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If t IsNot Nothing Then
            t.Abort()
        End If
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "AutoClicker Macro (*.atc)|*.atc"
        Dim tmpStr = ""
        For Each i As ListViewItem In ListBox1.Items
            tmpStr &= i.Text & vbNewLine
        Next
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, tmpStr, False)
        End If

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        OpenFileDialog1.Filter = "AutoClicker Macro (*.atc)|*.atc"
        Dim tmpStr = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            tmpStr = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Dim tmpStrEx = tmpStr.Split(vbNewLine)
            For Each t As String In tmpStrEx
                t.Replace(vbLf, "")
                If t.Length > 1 Then ListBox1.Items.Add(New ListViewItem(t))
            Next
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CustomAction.ShowDialog = DialogResult.OK Then
            Dim action As String = CustomAction.action.SelectedItem
            Select Case action
                Case "# Set Cursor pos"
                    ListBox1.Items.Add(New ListViewItem(" # " & CStr(CustomAction.xTb.Text) & "," & CStr(CustomAction.yTb.Text)))
                Case "! Wait"
                    ListBox1.Items.Add(New ListViewItem(" ! " & CustomAction.arg.Text))
                Case "( Left Click"
                    ListBox1.Items.Add(New ListViewItem(" " & action))
                Case ") Right Click"
                    ListBox1.Items.Add(New ListViewItem(" " & action))
            End Select
        End If
    End Sub
End Class
