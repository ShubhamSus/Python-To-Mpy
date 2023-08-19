Imports System.IO

Public Class MainForm

    Dim selectedFilePaths As New List(Of String)
    Dim currentDirectory As String = Application.StartupPath
    Dim mpyPath As String = Path.Combine(currentDirectory, "mpy.exe")

    Private Sub SelectFilesButton_Click(sender As Object, e As EventArgs) Handles SelectFilesButton.Click

        If OpenFileDialogBox.ShowDialog() = DialogResult.OK Then
            'selectedFilePaths = OpenFileDialogBox.FileNames
            For Each files In OpenFileDialogBox.FileNames
                If selectedFilePaths.Contains(files) Then
                    MessageBox.Show("Selected File Already Exist So It Would Not Be Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Continue For
                End If
                selectedFilePaths.Add(files)
            Next

            LoadDataInTreeView()
        End If

        OpenFileDialogBox.Dispose()
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        If selectedFilePaths Is Nothing OrElse selectedFilePaths.Count = 0 Then
            MessageBox.Show("No Files Are Selected!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim SaveFilesDialogBox As New FolderBrowserDialog()
        SaveFilesDialogBox.Description = "Select a Location To Save Files"
        SaveFilesDialogBox.ShowNewFolderButton = True


        If SaveFilesDialogBox.ShowDialog() = DialogResult.OK Then

            Using process As New Process()
                process.StartInfo.FileName = mpyPath
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = False
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


            Dim result As DialogResult = MessageBox.Show("All files have been converted to .Mpy. Would you like to open the directory where the files are saved?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Process.Start(SaveFilesDialogBox.SelectedPath) 'Open Folder Where Files Are Saved
            End If

        End If
    End Sub

    Private Sub RemoveFileButton_Click(sender As Object, e As EventArgs) Handles RemoveFileButton.Click
        Dim clickedNode As TreeNode = FileTreeView.SelectedNode
        If clickedNode IsNot Nothing AndAlso clickedNode.Parent IsNot Nothing Then

            selectedFilePaths.Remove(clickedNode.Tag)

            If clickedNode.Nodes.Count = 0 Then
                clickedNode.Parent.Remove()
            ElseIf clickedNode.Nodes.Count = 1 Then
                clickedNode.Remove()
            End If

        Else
            MsgBox("Select A File From TreeView To Remove It.", MsgBoxStyle.Information)
        End If

        If FileTreeView.Nodes.Count > 0 Then
            If FileTreeView.Nodes(0).Nodes.Count = 0 Then 'If All The Files are Removed, Remove The Parent Node
                FileTreeView.Nodes.Clear()
            End If
        End If
    End Sub

    Private Sub RemoveAllFilesButton_Click(sender As Object, e As EventArgs) Handles RemoveAllFilesButton.Click
        If selectedFilePaths.Count = 0 Then
            MessageBox.Show("No Files Are Selected.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        selectedFilePaths.Clear()
        FileTreeView.Nodes.Clear()
    End Sub

    'Drag And Drop
    Private Sub FileTreeView_DragEnter(sender As Object, e As DragEventArgs) Handles FileTreeView.DragEnter
        ' Check if the dragged data contains file(s)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' Get the array of file paths dropped into the ListBox
            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

            ' Check if all dropped files are Python files
            Dim allFilesArePython As Boolean = True
            For Each file In files
                If Not file.EndsWith(".py", StringComparison.OrdinalIgnoreCase) Then
                    allFilesArePython = False
                    Exit For
                End If
            Next

            If allFilesArePython Then
                ' Allow the copy operation
                e.Effect = DragDropEffects.Copy
            Else
                ' Disallow the drop
                e.Effect = DragDropEffects.None
            End If
        Else
            ' Disallow the drop
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub FileTreeView_DragDrop(sender As Object, e As DragEventArgs) Handles FileTreeView.DragDrop
        ' Get the array of file paths dropped into the ListBox
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        For Each file In files
            If selectedFilePaths.Contains(file) Then
                MessageBox.Show("Selected Files Already Exist So It Would Not Be Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Continue For
            End If
            selectedFilePaths.Add(file)
        Next

        LoadDataInTreeView()
    End Sub

    'Function
    Private Function SaveFile(folderPath As String, fileName As String)
        Dim filePath As String = Path.Combine(folderPath, fileName)
        Return filePath
    End Function

    Private Sub LoadDataInTreeView()
        FileTreeView.Nodes.Clear()

        Dim filesNode As TreeNode = FileTreeView.Nodes.Add("Python Files")

        For Each filePath As String In selectedFilePaths
            Dim fileInfo As New FileInfo(filePath)
            Dim fileName As String = fileInfo.Name
            Dim childNode As TreeNode = filesNode.Nodes.Add(fileName)
            childNode.Tag = filePath
            Dim filePathChildNode As TreeNode = childNode.Nodes.Add(filePath)
            filePathChildNode.Tag = filePath
        Next
        FileTreeView.ExpandAll()
    End Sub


End Class