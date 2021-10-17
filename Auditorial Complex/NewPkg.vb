Imports System.Net
Public Class NewPkg

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.StartsWith("http://") Or TextBox2.Text.StartsWith("https://") Then
            If TextBox2.Text.EndsWith(".exe") Or TextBox2.Text.EndsWith(".msi") Or TextBox2.Text.EndsWith(".zip") Or TextBox2.Text.EndsWith(".7z") Or TextBox2.Text.EndsWith(".rar") Or TextBox2.Text.EndsWith(".iso") Then
                Try
                    My.Computer.FileSystem.WriteAllText("pkgs/" + TextBox1.Text + ".txt", TextBox2.Text + Environment.NewLine + TextBox3.Text, True)

                    Dim form1 = New Main()
                    form1.Show()
                    Me.Close()
                Catch ex As System.NotSupportedException
                    MsgBox("Invalid file name.", MsgBoxStyle.Exclamation)
                End Try
            Else
                Select Case MsgBox("File doesn't appear to look be executable or an archive, are you sure you want to add?", vbYesNo + vbQuestion, "Uncommon File Extension")
                    Case MsgBoxResult.Yes
                        Try
                            My.Computer.FileSystem.WriteAllText("pkgs/" + TextBox1.Text + ".txt", TextBox2.Text + Environment.NewLine + TextBox3.Text, True)

                            Dim form1 = New Main()
                            form1.Show()
                            Me.Close()
                        Catch ex As System.NotSupportedException
                            MsgBox("Invalid file name.", MsgBoxStyle.Exclamation)
                        End Try
                End Select
            End If
        Else
            MsgBox("An exception has occurred!" & vbCrLf & "(If you're on XP, is the download over HTTP?)", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim form1 = New Main()
        form1.Show()
        Me.Close()
    End Sub
End Class