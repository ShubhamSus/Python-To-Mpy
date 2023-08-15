Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DarkUI.Controls

Public Class MainForm

    Dim selectedFilePaths As String()
    Dim currentDirectory As String = Application.StartupPath

    Private Sub SelectFilesButton_Click(sender As Object, e As EventArgs) Handles SelectFilesButton.Click

        If OpenFileDialogBox.ShowDialog() = DialogResult.OK Then
            selectedFilePaths = OpenFileDialogBox.FileNames

            FileTreeView.Nodes.Clear()
            Dim filesNode As TreeNode = FileTreeView.Nodes.Add("Python Files")

            For Each filePath As String In selectedFilePaths
                Dim fileInfo As New FileInfo(filePath)
                Dim fileName As String = fileInfo.Name
                Dim childNode As TreeNode = filesNode.Nodes.Add(fileName)
                childNode.Tag = filePath
            Next
            filesNode.Expand()
        End If

        OpenFileDialogBox.Dispose()
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        If selectedFilePaths Is Nothing Then
            MessageBox.Show("No Files Are Selected!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim SaveFilesDialogBox As New FolderBrowserDialog()
        SaveFilesDialogBox.Description = "Select a Location To Save Files"
        SaveFilesDialogBox.ShowNewFolderButton = True

        Dim totalFiles As Integer = selectedFilePaths.Length
        Dim completedFiles As Integer = 0

        If SaveFilesDialogBox.ShowDialog() = DialogResult.OK Then
            Dim mpyPath As String = Path.Combine(currentDirectory, "mpy.exe")

            Using process As New Process()
                process.StartInfo.FileName = mpyPath
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.CreateNoWindow = True

                For Each filePath In selectedFilePaths
                    If filePath Is Nothing Then
                        'Skip That
                    End If
                    Dim fileName As String = Path.GetFileNameWithoutExtension(filePath)
                    Dim outputFile As String = Path.Combine(SaveFilesDialogBox.SelectedPath, fileName & ".mpy")

                    process.StartInfo.Arguments = String.Format("-o ""{0}"" ""{1}""", outputFile, filePath)

                    process.Start()
                    process.WaitForExit()
                Next
            End Using

            SaveFilesDialogBox.Dispose()

            'MessageBox.Show("All Files Converted To .Mpy!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(SaveFilesDialogBox.SelectedPath) 'Open Folder Where Files Are Saved
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub

    Private Sub Reset()
        FileTreeView.Nodes.Clear()
        selectedFilePaths = Nothing
    End Sub

    Private Function SaveFile(folderPath As String, fileName As String)
        Dim filePath As String = Path.Combine(folderPath, fileName)
        Return filePath
    End Function


    'Context Menu
    Private Sub FileTreeView_MouseClick(sender As Object, e As MouseEventArgs) Handles FileTreeView.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim clickedNode As TreeNode = FileTreeView.GetNodeAt(e.Location)

            If clickedNode IsNot Nothing AndAlso Not clickedNode.Parent Is Nothing Then
                FileTreeView.SelectedNode = clickedNode
                RemoveFileContextMenu.Show(FileTreeView, e.Location)
            End If
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim selectedFileName As String = FileTreeView.SelectedNode.Text
        FileTreeView.Nodes.Remove(FileTreeView.SelectedNode)
        selectedFilePaths = selectedFilePaths.Where(Function(filePath) Not filePath.EndsWith(selectedFileName)).ToArray()
    End Sub


End Class
