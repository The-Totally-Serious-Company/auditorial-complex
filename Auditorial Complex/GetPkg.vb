Imports System
Imports System.IO
Imports System.Net
Imports ComponentAce.Compression.ZipForge
Imports ComponentAce.Compression.Archiver

Public Class GetPkg

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim main = New Main()
        main.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim url As New System.Uri("http://evynhh.ddns.net:4007/H:/Uploaded%20Files/jordiisepic/2000s%20Games.zip")
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            My.Computer.Network.DownloadFile("http://evynhh.ddns.net:4007/H:/Uploaded%20Files/jordiisepic/2000s%20Games.zip", "2000s Games.zip", "", "", True, 500, True)
        Catch ex As Exception
            MsgBox("The download may be down currently, sorry about that.", MsgBoxStyle.Critical)
        End Try

        Dim archiver As New ZipForge()
        Try
            archiver.FileName = "2000s Games.zip"
            archiver.OpenArchive(System.IO.FileMode.Open)
            archiver.BaseDir = "pkgs/2000s"
            archiver.ExtractFiles("*.*")
            archiver.CloseArchive()
        Catch ae As ArchiverException
            MsgBox("I ran into an error, try again.", MsgBoxStyle.Critical, "Exception Occurred")
        End Try

        My.Computer.FileSystem.DeleteFile("2000s Games.zip")
    End Sub
End Class