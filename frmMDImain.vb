Public Class frmMDImain

    Private Sub frmMDImain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMDImain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub SubmitABugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitABugToolStripMenuItem.Click
        Dim MDIChildFrmSubmitIssue As New frmSubmitIssue
        MDIChildFrmSubmitIssue.MdiParent = Me
        MDIChildFrmSubmitIssue.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MDIChildFrmAbout As New frmAbout
        MDIChildFrmAbout.MdiParent = Me
        MDIChildFrmAbout.Show()
    End Sub

   
    Private Sub FoodJournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodJournalToolStripMenuItem.Click
        Dim MDIChildFrmFoodJournal As New frmFoodJournal
        MDIChildFrmFoodJournal.MdiParent = Me
        MDIChildFrmFoodJournal.Show()
    End Sub
End Class
