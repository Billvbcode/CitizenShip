Public Class FrmMenu
    Private Sub BtnWordSearch_Click(sender As Object, e As EventArgs) Handles BtnWordSearch.Click
        FrmWord.ShowDialog()
    End Sub

    Private Sub BtnSpell_Click(sender As Object, e As EventArgs) Handles BtnSpell.Click
        Form4.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmSnakevb.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmJoke.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmBook.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmStory1.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmMemory.ShowDialog()
    End Sub

    Private Sub BtnBear_Click(sender As Object, e As EventArgs) Handles BtnBear.Click
        FrmBearDunk.ShowDialog()
    End Sub

    Private Sub BtnBoggle_Click(sender As Object, e As EventArgs) Handles BtnBoggle.Click
        Form1.ShowDialog()
    End Sub

    Private Sub btnABC_Click(sender As Object, e As EventArgs) Handles btnABC.Click
        FrmABC.ShowDialog()
    End Sub

    Private Sub BtnRace_Click(sender As Object, e As EventArgs) Handles BtnRace.Click
        FrmRacevb.ShowDialog()
    End Sub

    Private Sub BtnCitizen_Click(sender As Object, e As EventArgs) Handles BtnCitizen.Click
        FrmCitizen.ShowDialog()
    End Sub

    Private Sub BtnChoose_Click(sender As Object, e As EventArgs) Handles BtnChoose.Click
        FrmChoose.ShowDialog()
    End Sub
End Class