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
        Me.DarkLabel1 = New DarkUI.Controls.DarkLabel()
        Me.RemoveAllFilesButton = New DarkUI.Controls.DarkButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RemoveFileButton
        '
        Me.RemoveFileButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemoveFileButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveFileButton.Location = New System.Drawing.Point(1, 43)
        Me.RemoveFileButton.Margin = New System.Windows.Forms.Padding(1)
        Me.RemoveFileButton.Name = "RemoveFileButton"
        Me.RemoveFileButton.Padding = New System.Windows.Forms.Padding(5)
        Me.RemoveFileButton.Size = New System.Drawing.Size(141, 40)
        Me.RemoveFileButton.TabIndex = 16
        Me.RemoveFileButton.Text = "Remove File"
        '
        'DarkLabel3
        '
        Me.DarkLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DarkLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DarkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel3.Location = New System.Drawing.Point(15, 359)
        Me.DarkLabel3.Margin = New System.Windows.Forms.Padding(1, 3, 2, 3)
        Me.DarkLabel3.Name = "DarkLabel3"
        Me.DarkLabel3.Size = New System.Drawing.Size(287, 19)
        Me.DarkLabel3.TabIndex = 15
        Me.DarkLabel3.Text = "(Developed By Shubham Patel)"
        Me.DarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConvertButton
        '
        Me.ConvertButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConvertButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ConvertButton.Location = New System.Drawing.Point(144, 1)
        Me.ConvertButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Padding = New System.Windows.Forms.Padding(5)
        Me.ConvertButton.Size = New System.Drawing.Size(142, 40)
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
        Me.FileTreeView.AllowDrop = True
        Me.FileTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileTreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.FileTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileTreeView.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.FileTreeView.ForeColor = System.Drawing.Color.Gainsboro
        Me.FileTreeView.ItemHeight = 18
        Me.FileTreeView.LineColor = System.Drawing.Color.White
        Me.FileTreeView.Location = New System.Drawing.Point(15, 35)
        Me.FileTreeView.Name = "FileTreeView"
        Me.FileTreeView.Size = New System.Drawing.Size(287, 226)
        Me.FileTreeView.TabIndex = 12
        '
        'SelectFilesButton
        '
        Me.SelectFilesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectFilesButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SelectFilesButton.Location = New System.Drawing.Point(1, 1)
        Me.SelectFilesButton.Margin = New System.Windows.Forms.Padding(1)
        Me.SelectFilesButton.Name = "SelectFilesButton"
        Me.SelectFilesButton.Padding = New System.Windows.Forms.Padding(5)
        Me.SelectFilesButton.Size = New System.Drawing.Size(141, 40)
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
        'DarkLabel1
        '
        Me.DarkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DarkLabel1.AutoSize = True
        Me.DarkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DarkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DarkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DarkLabel1.Location = New System.Drawing.Point(121, 14)
        Me.DarkLabel1.Margin = New System.Windows.Forms.Padding(1, 3, 2, 3)
        Me.DarkLabel1.Name = "DarkLabel1"
        Me.DarkLabel1.Size = New System.Drawing.Size(181, 13)
        Me.DarkLabel1.TabIndex = 17
        Me.DarkLabel1.Text = "(Select or Drag Python Files Here)"
        Me.DarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemoveAllFilesButton
        '
        Me.RemoveAllFilesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemoveAllFilesButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveAllFilesButton.Location = New System.Drawing.Point(144, 43)
        Me.RemoveAllFilesButton.Margin = New System.Windows.Forms.Padding(1)
        Me.RemoveAllFilesButton.Name = "RemoveAllFilesButton"
        Me.RemoveAllFilesButton.Padding = New System.Windows.Forms.Padding(5)
        Me.RemoveAllFilesButton.Size = New System.Drawing.Size(142, 40)
        Me.RemoveAllFilesButton.TabIndex = 18
        Me.RemoveAllFilesButton.Text = "Remove All Files "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RemoveAllFilesButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectFilesButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ConvertButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RemoveFileButton, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 267)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(287, 84)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(314, 390)
        Me.Controls.Add(Me.DarkLabel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DarkLabel1)
        Me.Controls.Add(Me.DarkLabel2)
        Me.Controls.Add(Me.FileTreeView)
        Me.MinimumSize = New System.Drawing.Size(312, 302)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Python To Mpy"
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents DarkLabel1 As DarkUI.Controls.DarkLabel
    Friend WithEvents RemoveAllFilesButton As DarkUI.Controls.DarkButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
