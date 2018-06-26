'Option Strict On
'Option Explicit On
Public Class Form1
    Dim MoveRight As Boolean
    Dim MoveUp As Boolean
    Dim Speed As Integer = 1
    Dim var As String

    'Dim Left As Integer = Integer.Parse(OvalShape1.Left)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        var = ComboBox1.Text
        If var = "Angle 1" Then
            If MoveRight = True Then
                OvalShape1.Left = OvalShape1.Left + Speed
            Else
                OvalShape1.Left = OvalShape1.Left - Speed
            End If

            If MoveUp = True Then
                OvalShape1.Top = OvalShape1.Top - Speed
            Else
                OvalShape1.Top = OvalShape1.Top + Speed
            End If
        End If

        If var = "Angle 2" Then
            If MoveRight = True Then
                OvalShape1.Left = OvalShape1.Left + Speed + 2
            Else
                OvalShape1.Left = OvalShape1.Left - Speed - 2
            End If

            
        End If

        If var = "Angle 3" Then
            If MoveRight = True Then
                OvalShape1.Left = OvalShape1.Left + Speed + 3
            Else
                OvalShape1.Left = OvalShape1.Left - Speed - 3
            End If

            If MoveUp = True Then
                OvalShape1.Top = OvalShape1.Top - Speed + 3
            Else
                OvalShape1.Top = OvalShape1.Top + Speed - 3
            End If
        End If

        If OvalShape1.Left < Me.ClientRectangle.Left Then
            MoveRight = True
        End If
        If (OvalShape1.Left + OvalShape1.Width + 150) >= Me.ClientRectangle.Right Then
            MoveRight = False
        End If
        If OvalShape1.Top <= Me.ClientRectangle.Top Then
            MoveUp = False
        End If
        If (OvalShape1.Top + OvalShape1.Height) >= Me.ClientRectangle.Bottom Then
            MoveUp = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Speed < 10) Then

            Speed = Speed + 1

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Speed > 4) Then

            Speed = Speed - 1

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Angle 1")
        ComboBox1.Items.Add("Angle 2")
        ComboBox1.Items.Add("Angle 3")
        ComboBox1.SelectedItem = "Angle 1"
    End Sub


End Class
