Public Class Form1

    Dim Cash As Double = 100.0
    Dim Difficulty As Integer = 0
    Dim BetValue As Integer
    'Cash = 100.0



    Private Sub SpinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpinButton.Click
        

        Label1.Text = CStr(Int(Rnd() * 10)) 'Changes the Labels for Slots
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))

        If (Label1.Text = Label2.Text And Label2.Text = Label3.Text) Then 'For when you win
            MsgBox("YOU WIN!  CONGRATSULATIONS!")
        End If



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        

        Button1.Visible = False 'Makes the BET buttons invis.
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False

        MsgBox("Please select your difficulty from the 'Difficulty' menu.")



    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by:  Michael Buchler")
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
    End Sub

   Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        
    End Sub

    Private Sub CasualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasualToolStripMenuItem.Click
        Difficulty = 2
        Label5.Text = "Your difficulty:  Casual"
       
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True

    End Sub

    Private Sub FunnoCashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FunnoCashToolStripMenuItem.Click
        Difficulty = 1
        Label5.Text = "Your difficulty:  Fun"

        Button1.Visible = False 'Makes the BET buttons invis.
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub GamblerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GamblerToolStripMenuItem.Click
        Difficulty = 3
        Label5.Text = "Your difficulty:  Gambler"

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub ProfessionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfessionalToolStripMenuItem.Click
        Difficulty = 4
        Label5.Text = "Your difficulty:  Professional"

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BetValue = BetValue + Cash
        If (BetValue > Cash) Then

        End If
        Label6.Text = CStr(BetValue)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BetValue = BetValue + 10
        Label6.Text = CStr(BetValue)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BetValue = BetValue + 50
        Label6.Text = CStr(BetValue)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BetValue = BetValue + 100
        Label6.Text = CStr(BetValue)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BetValue = 0
        Label6.Text = CStr(BetValue)

    End Sub
End Class
