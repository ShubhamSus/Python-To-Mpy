<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.ResetButton = New DarkUI.Controls.DarkButton()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.ConvertButton = New DarkUI.Controls.DarkButton()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.FileTreeView = New System.Windows.Forms.TreeView()
        Me.SelectFilesButton = New DarkUI.Controls.DarkButton()
        Me.OpenFileDialogBox = New System.Windows.Forms.OpenFileDialog()
        Me.RemoveFileContextMenu = New DarkUI.Controls.DarkContextMenu()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFileContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DarkLabel1
        '
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(9, 298)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(1, 3, 2, 3)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(253, 13)
        Me.DarkLabel1.TabIndex = 17
        Me.DarkLabel1.Text = "(Right Click On Nodes To Remove Particular File)"
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ResetButton.Location = New System.Drawing.Point(15, 262)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Padding = New System.Windows.Forms.Padding(5)
        Me.ResetButton.Size = New System.Drawing.Size(241, 30)
        Me.ResetButton.TabIndex = 16
        Me.ResetButton.Text = "(Reset) Remove All Files "
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(54, 317)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(1, 3, 2, 3)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(162, 13)
        Me.DarkLabel3.TabIndex = 15
        Me.DarkLabel3.Text = "(Developed By Shubham Patel)"
        '
        'ConvertButton
        '
        Me.ConvertButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ConvertButton.Location = New System.Drawing.Point(140, 221)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Padding = New System.Windows.Forms.Padding(5)
        Me.ConvertButton.Size = New System.Drawing.Size(116, 35)
        Me.ConvertButton.TabIndex = 14
        Me.ConvertButton.Text = "Convert To Mpy"
        '
        'DarkLabel2
        '
        Me.DarkLabel2.AutoSize = True
        Me.DarkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.DarkLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel2.Location = New System.Drawing.Point(12, 12)
        Me.DarkLabel2.Margin = New System.Windows.Forms.Padding(3)
        Me.DarkLabel2.Name = "DarkLabel2"
        Me.DarkLabel2.Size = New System.Drawing.Size(91, 17)
        Me.DarkLabel2.TabIndex = 13
        Me.DarkLabel2.Text = "Selected Files"
        '
        'FileTreeView
        '
        Me.FileTreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.FileTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileTreeView.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.FileTreeView.ForeColor = System.Drawing.Color.Gainsboro
        Me.FileTreeView.ItemHeight = 18
        Me.FileTreeView.LineColor = System.Drawing.Color.White
        Me.FileTreeView.Location = New System.Drawing.Point(15, 35)
        Me.FileTreeView.Name = "FileTreeView"
        Me.FileTreeView.Size = New System.Drawing.Size(241, 180)
        Me.FileTreeView.TabIndex = 12
        '
        'SelectFilesButton
        '
        Me.SelectFilesButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SelectFilesButton.Location = New System.Drawing.Point(15, 221)
        Me.SelectFilesButton.Name = "SelectFilesButton"
        Me.SelectFilesButton.Padding = New System.Windows.Forms.Padding(5)
        Me.SelectFilesButton.Size = New System.Drawing.Size(116, 35)
        Me.SelectFilesButton.TabIndex = 11
        Me.SelectFilesButton.Text = "Select Py Files"
        '
        'RemoveFileContextMenu
        '
        Me.RemoveFileContextMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.RemoveFileContextMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RemoveFileContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.RemoveFileContextMenu.Name = "RemoveFileContextMenu"
        Me.RemoveFileContextMenu.Size = New System.Drawing.Size(139, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove File"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(271, 339)
        Me.Controls.Add(Me.DarkLabel1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DarkLabel3)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.DarkLabel2)
        Me.Controls.Add(Me.FileTreeView)
        Me.Controls.Add(Me.SelectFilesButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "Python To Mpy"
        Me.RemoveFileContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents ResetButton As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents ConvertButton As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents FileTreeView As TreeView
    Friend WithEvents SelectFilesButton As DarkUI.Controls.DarkButton
    Friend WithEvents OpenFileDialogBox As OpenFileDialog
    Friend WithEvents RemoveFileContextMenu As DarkUI.Controls.DarkContextMenu
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
End Class
