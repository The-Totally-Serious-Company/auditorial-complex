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

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim fileName As String

        If ListBox1.SelectedItem IsNot Nothing Then
            fileName = ListBox1.SelectedItem.ToString()
            Dim lines() As String = IO.File.ReadAllLines(fileName)

            If System.IO.File.Exists(fileName) Then
                TextBox2.Text = lines(0)
            End If

            Dim reader = File.OpenText(fileName)
            Dim line As String = ""
            Dim line2 As String = ""
            Dim line3 As String = ""

            Do
                line3 = line2
                line2 = line
                line = reader.ReadLine
            Loop Until line Is Nothing

            reader.Close()

            If String.IsNullOrEmpty(line2) And String.IsNullOrEmpty(line3) Then
                TextBox1.Text = "No description provided."
            Else
                TextBox1.Text = lines(lines.Length - 1)
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
                TextBox2.Clear()
                MsgBox("Completed.", MsgBoxStyle.Information, "Clear Packages")
        End Select
    End Sub

    Private Sub GetNewPackagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetNewPackagesToolStripMenuItem.Click
        Dim getpkg = New GetPkg()
        getpkg.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("No item selected.", MsgBoxStyle.Information)
        Else
            Dim content As String
            Dim fileName As String

            If ListBox1.SelectedItem IsNot Nothing Then
                fileName = ListBox1.SelectedItem.ToString()

                If System.IO.File.Exists(fileName) Then
                    content = My.Computer.FileSystem.ReadAllText(fileName)

                    Dim lines() As String = IO.File.ReadAllLines(fileName)

                    If lines(0).EndsWith(".exe") Or lines(0).EndsWith(".msi") Or lines(0).EndsWith(".zip") Or lines(0).EndsWith(".7z") Or lines(0).EndsWith(".rar") Or lines(0).EndsWith(".iso") Then
                        Dim url As New System.Uri(lines(0))
                        Dim req As System.Net.WebRequest
                        req = System.Net.WebRequest.Create(url)
                        Dim resp As System.Net.WebResponse
                        Try
                            Dim file = Path.GetFileNameWithoutExtension(fileName)
                            Dim extension = Path.GetExtension(lines(0))

                            resp = req.GetResponse()
                            resp.Close()
                            req = Nothing
                            My.Computer.Network.DownloadFile(lines(0), file + extension, "", "", True, 500, True)
                        Catch ex As System.OperationCanceledException
                            Dim file = Path.GetFileNameWithoutExtension(fileName)
                            Dim extension = Path.GetExtension(lines(0))

                            MsgBox("Download cancelled.", MsgBoxStyle.Exclamation)
                            My.Computer.FileSystem.DeleteFile(file + extension)
                        Catch ex As Exception
                            MsgBox("Address is not valid or it's over HTTPS (needs to be over HTTP)", MsgBoxStyle.Exclamation)
                        End Try
                    Else
                        Dim file = Path.GetFileNameWithoutExtension(fileName)
                        Dim extension = Path.GetExtension(lines(0))

                        MsgBox("Invalid file extension!" & vbCrLf & "(Is it a direct link to the file?)", MsgBoxStyle.Exclamation)
                        My.Computer.FileSystem.DeleteFile(file + extension)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("No item selected.", MsgBoxStyle.Information)
        Else
            Select Case MsgBox("Are you sure you want to remove this package?", vbYesNo + vbQuestion, "Remove Package")
                Case MsgBoxResult.Yes
                    Dim fileName = ListBox1.SelectedItem.ToString()
                    My.Computer.FileSystem.DeleteFile(fileName)
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    MsgBox("Completed.", MsgBoxStyle.Information, "Remove Package")
            End Select
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("If your download is a .7z or .rar, use 7-Zip to extract it." & vbCrLf & "If your download is an .iso, use Daemon Tools or WinCDEmu to mount it.", MsgBoxStyle.Information, "Help")
    End Sub
End Class
