<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RemoveFileButton = New DarkUI.Controls.DarkButton()
        Me.DarkLabel3 = New DarkUI.Controls.DarkLabel()
        Me.ConvertButton = New DarkUI.Controls.DarkButton()
        Me.DarkLabel2 = New DarkUI.Controls.DarkLabel()
        Me.FileTreeView = New System.Windows.Forms.TreeView()
        Me.SelectFilesButton = New DarkUI.Controls.DarkButton()
        Me.OpenFileDialogBox = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'RemoveFileButton
        '
        Me.RemoveFileButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveFileButton.Location = New System.Drawing.Point(15, 311)
        Me.RemoveFileButton.Name = "RemoveFileButton"
        Me.RemoveFileButton.Padding = New System.Windows.Forms.Padding(5)
        Me.RemoveFileButton.Size = New System.Drawing.Size(292, 35)
        Me.RemoveFileButton.TabIndex = 16
        Me.RemoveFileButton.Text = "Remove Files "
        '
        'DarkLabel3
        '
        Me.DarkLabel3.AutoSize = True
        Me.DarkLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(75, 352)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(1, 3, 2, 3)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(169, 13)
        Me.DarkLabel3.TabIndex = 15
        Me.DarkLabel3.Text = "(Developed By Shubham Patel)"
        '
        'ConvertButton
        '
        Me.ConvertButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ConvertButton.Location = New System.Drawing.Point(165, 270)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Padding = New System.Windows.Forms.Padding(5)
        Me.ConvertButton.Size = New System.Drawing.Size(142, 35)
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
        Me.FileTreeView.Size = New System.Drawing.Size(292, 229)
        Me.FileTreeView.TabIndex = 12
        '
        'SelectFilesButton
        '
        Me.SelectFilesButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SelectFilesButton.Location = New System.Drawing.Point(15, 270)
        Me.SelectFilesButton.Name = "SelectFilesButton"
        Me.SelectFilesButton.Padding = New System.Windows.Forms.Padding(5)
        Me.SelectFilesButton.Size = New System.Drawing.Size(141, 35)
        Me.SelectFilesButton.TabIndex = 11
        Me.SelectFilesButton.Text = "Select Py Files"
        '
        'OpenFileDialogBox
        '
        Me.OpenFileDialogBox.DefaultExt = "py"
        Me.OpenFileDialogBox.Filter = "Python Files (*.py)|*.py"
        Me.OpenFileDialogBox.Multiselect = True
        Me.OpenFileDialogBox.Title = "Select Python Files"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(319, 375)
        Me.Controls.Add(Me.RemoveFileButton)
        Me.Controls.Add(Me.DarkLabel3)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.DarkLabel2)
        Me.Controls.Add(Me.FileTreeView)
        Me.Controls.Add(Me.SelectFilesButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Python To Mpy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemoveFileButton As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel3 As DarkUI.Controls.DarkLabel
    Friend WithEvents ConvertButton As DarkUI.Controls.DarkButton
    Friend WithEvents DarkLabel2 As DarkUI.Controls.DarkLabel
    Friend WithEvents FileTreeView As TreeView
    Friend WithEvents SelectFilesButton As DarkUI.Controls.DarkButton
    Friend WithEvents OpenFileDialogBox As OpenFileDialog
End Class
