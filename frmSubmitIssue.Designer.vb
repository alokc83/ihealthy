﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubmitIssue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubmitIssue))
        Me.wbBug = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbBug
        '
        Me.wbBug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbBug.Location = New System.Drawing.Point(0, 0)
        Me.wbBug.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbBug.Name = "wbBug"
        Me.wbBug.Size = New System.Drawing.Size(643, 308)
        Me.wbBug.TabIndex = 0
        '
        'frmSubmitABug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 308)
        Me.Controls.Add(Me.wbBug)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSubmitABug"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Submit a issue"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbBug As System.Windows.Forms.WebBrowser
End Class
