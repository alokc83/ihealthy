<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDImain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDImain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NutritionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodJournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageFoodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMealToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRecipesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePentryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitABugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShoppingLIstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.WorkoutToolStripMenuItem, Me.NutritionToolStripMenuItem, Me.ProgressToolStripMenuItem, Me.SubmitABugToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'WorkoutToolStripMenuItem
        '
        Me.WorkoutToolStripMenuItem.Name = "WorkoutToolStripMenuItem"
        Me.WorkoutToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.WorkoutToolStripMenuItem.Text = "Workout"
        '
        'NutritionToolStripMenuItem
        '
        Me.NutritionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FoodJournalToolStripMenuItem, Me.ManageFoodToolStripMenuItem, Me.ManageMealToolStripMenuItem, Me.ManageRecipesToolStripMenuItem, Me.ManagePentryToolStripMenuItem, Me.ShoppingLIstToolStripMenuItem})
        Me.NutritionToolStripMenuItem.Name = "NutritionToolStripMenuItem"
        Me.NutritionToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.NutritionToolStripMenuItem.Text = "Nutrition"
        '
        'FoodJournalToolStripMenuItem
        '
        Me.FoodJournalToolStripMenuItem.Name = "FoodJournalToolStripMenuItem"
        Me.FoodJournalToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FoodJournalToolStripMenuItem.Text = "Food Journal"
        '
        'ManageFoodToolStripMenuItem
        '
        Me.ManageFoodToolStripMenuItem.Name = "ManageFoodToolStripMenuItem"
        Me.ManageFoodToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ManageFoodToolStripMenuItem.Text = "Manage Food"
        '
        'ManageMealToolStripMenuItem
        '
        Me.ManageMealToolStripMenuItem.Name = "ManageMealToolStripMenuItem"
        Me.ManageMealToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ManageMealToolStripMenuItem.Text = "Manage Meals"
        '
        'ManageRecipesToolStripMenuItem
        '
        Me.ManageRecipesToolStripMenuItem.Name = "ManageRecipesToolStripMenuItem"
        Me.ManageRecipesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ManageRecipesToolStripMenuItem.Text = "Manage Recipes"
        '
        'ManagePentryToolStripMenuItem
        '
        Me.ManagePentryToolStripMenuItem.Name = "ManagePentryToolStripMenuItem"
        Me.ManagePentryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ManagePentryToolStripMenuItem.Text = "Manage Pantry"
        '
        'ProgressToolStripMenuItem
        '
        Me.ProgressToolStripMenuItem.Name = "ProgressToolStripMenuItem"
        Me.ProgressToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ProgressToolStripMenuItem.Text = "Progress"
        '
        'SubmitABugToolStripMenuItem
        '
        Me.SubmitABugToolStripMenuItem.Name = "SubmitABugToolStripMenuItem"
        Me.SubmitABugToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.SubmitABugToolStripMenuItem.Text = "Submit a bug"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ShoppingLIstToolStripMenuItem
        '
        Me.ShoppingLIstToolStripMenuItem.Name = "ShoppingLIstToolStripMenuItem"
        Me.ShoppingLIstToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShoppingLIstToolStripMenuItem.Text = "Shopping LIst"
        '
        'frmMDImain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 292)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMDImain"
        Me.Text = "iHealthy - Workout and Diet Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NutritionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubmitABugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoodJournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageFoodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageMealToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageRecipesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagePentryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShoppingLIstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
