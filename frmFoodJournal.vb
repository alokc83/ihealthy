Public Class frmFoodJournal

    Private Sub frmFoodJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim todaysDate As Date
        lblDate.Text = "This Food Journal for " + todaysDate.Day
    End Sub

    
End Class