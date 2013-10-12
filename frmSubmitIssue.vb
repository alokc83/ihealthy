Public Class frmSubmitIssue

    Private Sub frmSubmitABug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wbBug.Navigate("http://code.google.com/p/ihealthy/issues/list")
    End Sub
End Class