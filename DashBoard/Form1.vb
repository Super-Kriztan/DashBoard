Imports System.Diagnostics

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim url As String = "https://www.instagram.com/nxgen2024"
        OpenUrl(url)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url As String = "https://www.facebook.com/profile.php?id=61569804850113"
        OpenUrl(url)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url As String = "https://x.com/nxgen2024"
        OpenUrl(url)
    End Sub

    Private Sub OpenUrl(url As String)
        Try
            Dim psi As New ProcessStartInfo() With {
                .FileName = url,
                .UseShellExecute = True
            }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show($"Failed to open URL: {url}. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
