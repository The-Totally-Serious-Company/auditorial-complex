Imports System.IO
Imports System.Net
Public Class Main

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists("pkgs") Then
            System.IO.Directory.CreateDirectory("pkgs")
        End If

        Dim files() As String = IO.Directory.GetFiles("pkgs", "*.txt", SearchOption.AllDirectories)
        ListBox1.Items.AddRange(files)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim content As String
        Dim fileName As String

        If ListBox1.SelectedItem IsNot Nothing Then
            fileName = ListBox1.SelectedItem.ToString()

            If System.IO.File.Exists(fileName) Then
                content = My.Computer.FileSystem.ReadAllText(fileName)

                If content.EndsWith(".exe") Or content.EndsWith(".msi") Or content.EndsWith(".zip") Or content.EndsWith(".7z") Or content.EndsWith(".rar") Or content.EndsWith(".iso") Then
                    Dim url As New System.Uri(content)
                    Dim req As System.Net.WebRequest
                    req = System.Net.WebRequest.Create(url)
                    Dim resp As System.Net.WebResponse
                    Try
                        Dim file = Path.GetFileNameWithoutExtension(fileName)
                        Dim extension = Path.GetExtension(content)

                        resp = req.GetResponse()
                        resp.Close()
                        req = Nothing
                        My.Computer.Network.DownloadFile(content, file + extension, "", "", True, 500, True)
                    Catch ex As System.OperationCanceledException
                        Dim file = Path.GetFileNameWithoutExtension(fileName)
                        Dim extension = Path.GetExtension(content)

                        MsgBox("Download cancelled.", MsgBoxStyle.Exclamation)
                        My.Computer.FileSystem.DeleteFile(file + extension)
                    Catch ex As Exception
                        MsgBox("Address is not valid or it's over HTTPS (needs to be over HTTP)", MsgBoxStyle.Exclamation)
                    End Try
                Else
                    Dim file = Path.GetFileNameWithoutExtension(fileName)
                    Dim extension = Path.GetExtension(content)

                    MsgBox("Invalid file extension!" & vbCrLf & "(Is it a direct link to the file?)", MsgBoxStyle.Exclamation)
                    My.Computer.FileSystem.DeleteFile(file + extension)
                End If
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim content As String
        Dim fileName As String

        If ListBox1.SelectedItem IsNot Nothing Then
            fileName = ListBox1.SelectedItem.ToString()

            If System.IO.File.Exists(fileName) Then
                content = My.Computer.FileSystem.ReadAllText(fileName)
                TextBox1.Text = content
            End If

        End If
    End Sub

    Private Sub AddPackageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPackageToolStripMenuItem.Click
        Dim input = New NewPkg()
        input.Show()
        Me.Close()
    End Sub


    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click
        Dim credits = New Credits()
        credits.Show()
    End Sub

    Private Sub ClearPackageListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearPackageListToolStripMenuItem.Click
        Select Case MsgBox("Are you sure you want to clear your packages list?", vbYesNo + vbQuestion, "Clear Packages")
            Case MsgBoxResult.Yes
                IO.Directory.Delete("pkgs", True)
                IO.Directory.CreateDirectory("pkgs")
                ListBox1.Items.Clear()
                TextBox1.Clear()
                MsgBox("Completed.", MsgBoxStyle.Information, "Clear Packages")
        End Select
    End Sub

    Private Sub GetNewPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetNewPackagesToolStripMenuItem.Click
        Dim getpkg = New GetPkg()
        getpkg.Show()
        Me.Close()
    End Sub
End Class
