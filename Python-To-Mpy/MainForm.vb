Imports System.IO

Public Class MainForm

    Dim selectedFilePaths As New List(Of String) 'List To Store Path Of Selected Files
    Dim currentDirectory As String = Application.StartupPath 'Getting Current Application Directory
    Dim mpyApplicationPath As String = Path.Combine(currentDirectory, "mpy-cross.exe") 'Mpy Application Path

    'Select File Button Click Event
    Private Sub SelectFilesButton_Click(sender As Object, e As EventArgs) Handles SelectFilesButton.Click
        'Check If Dialog Result is OK
        If OpenFileDialogBox.ShowDialog() = DialogResult.OK Then
            'Looping Through Each Files Selected From Dialog Box
            For Each file In OpenFileDialogBox.FileNames
                'If Files Are Already in List Don't Add It Again In List And In TreeView
                If selectedFilePaths.Contains(file) Then

                    MessageBox.Show($"{Path.GetFileName(file)} Exists So It Would Not Be Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Continue For
                End If
                'Adding FilePath In List
                selectedFilePaths.Add(file)
            Next

            'Loading FilePath In TreeView According To Data In List
            LoadDataInTreeView()
        End If

        'Disposing the Dialog Box After Its Use
        OpenFileDialogBox.Dispose()
    End Sub

    'Convert To Mpy Button Click Event
    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        'Check If List Is Empty Or Is Nothing
        If selectedFilePaths Is Nothing OrElse selectedFilePaths.Count = 0 Then
            MessageBox.Show("No Files Are Selected!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Creating A FolderBrowserDialog Box Object
        Dim SaveFilesDialogBox As New FolderBrowserDialog()
        SaveFilesDialogBox.Description = "Select a Location To Save Files"
        SaveFilesDialogBox.ShowNewFolderButton = True

        'If Dialog Result Is OK
        If SaveFilesDialogBox.ShowDialog() = DialogResult.OK Then
            'Create a New Process To Run Mpy Application
            Using process As New Process()
                process.StartInfo.FileName = mpyApplicationPath 'Path To Mpy Application .exe File
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = False
                process.StartInfo.CreateNoWindow = True 'Dont Create Terminal Window

                'Looping Through Each FilePath Present In List
                For Each filePath In selectedFilePaths
                    'Just a Safe Check If File Is Nothing Skip That File
                    If filePath Is Nothing Then
                        'Skip That
                        'MsgBox("File Is Nothing.")
                        Continue For
                    End If


                    Try
                        Dim fileName As String = Path.GetFileNameWithoutExtension(filePath) 'Getting FileName Without Its Extension 
                        Dim outputFile As String = Path.Combine(SaveFilesDialogBox.SelectedPath, fileName & ".mpy") 'Combining SelectedFolder Path & FileName To Store .Mpy

                        process.StartInfo.Arguments = $"-o ""{outputFile}"" ""{filePath}""" 'Setting Argument For Mpy Application '-o' For Output Directory And .Py File

                        process.Start() 'Starting The Mpy Application

                        process.WaitForExit() 'Wait Until Its Execution Is Finished
                    Catch ex As Exception
                        MessageBox.Show($"Can't Find 'mpy.exe' in '{currentDirectory}', Please Paste Your 'mpy-cross.exe' In Application Directory.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try

                Next
            End Using

            'Disposing Save File DialogBox
            SaveFilesDialogBox.Dispose()

            'Showing A MsgBox If User Want To Open The Directory Where .Mpy Files Are Saved
            Dim result As DialogResult = MessageBox.Show("All files have been converted to .Mpy. Would you like to open the directory where the files are saved?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                'If Yes Open The Selected Folder Path
                Process.Start(SaveFilesDialogBox.SelectedPath) 'Open Folder Where Files Are Saved
            End If

        End If
    End Sub

    'Remove Selected File Button Click Event
    Private Sub RemoveFileButton_Click(sender As Object, e As EventArgs) Handles RemoveFileButton.Click
        Dim clickedNode As TreeNode = FileTreeView.SelectedNode 'Getting Current Selected Node

        'Checking If Selected Node Is Not Nothing And It Contain A Parent 
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

                MessageBox.Show($"{Path.GetFileName(file)} Exists So It Would Not Be Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Continue For
            End If
            selectedFilePaths.Add(file)
        Next

        LoadDataInTreeView()
    End Sub


    Private Sub LoadDataInTreeView()
        'Clear The Whole TreeView
        FileTreeView.Nodes.Clear()

        Dim filesNode As TreeNode = FileTreeView.Nodes.Add("Python Files") 'Create A Parent Node With A Root Node Called 'Python Files'

        'Looping Through Each Path From List
        For Each filePath As String In selectedFilePaths
            Dim fileInfo As New FileInfo(filePath) 'Creating a FileInfo Object To Fetch Its Name
            Dim fileName As String = fileInfo.Name 'Getting its FileName With Extension

            Dim childNode As TreeNode = filesNode.Nodes.Add(fileName) 'Creating A Node Under Root Node With Text as File Name
            childNode.Tag = filePath 'Storing Whole Path In Tag Of That Node
            Dim filePathChildNode As TreeNode = childNode.Nodes.Add(filePath) 'Creating A Child Node With Full File Path
            filePathChildNode.Tag = filePath 'Storing Whole Path In Tag Of That Node
        Next

        'Expanding All The Nodes In TreeView
        FileTreeView.ExpandAll()
    End Sub


End Class