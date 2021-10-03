Imports System.Net
Public Class NewPkg

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.StartsWith("http://") Then
            If TextBox2.Text.EndsWith(".exe") Or TextBox2.Text.EndsWith(".msi") Or TextBox2.Text.EndsWith(".zip") Or TextBox2.Text.EndsWith(".7z") Or TextBox2.Text.EndsWith(".rar") Then
                My.Computer.FileSystem.WriteAllText("pkgs/" + TextBox1.Text + ".txt", TextBox2.Text, True)

                Dim form1 = New Main()
                form1.Show()
                Me.Close()
            Else
                MsgBox("Invalid file extension!" & vbCrLf & "(Is it a direct link to the file?)", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Address must be valid and over HTTP (not HTTPS)", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim form1 = New Main()
        form1.Show()
        Me.Close()
    End Sub
End Class