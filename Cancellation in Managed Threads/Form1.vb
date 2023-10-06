Imports System.Diagnostics.Metrics
Imports System.Threading

Public Class Form1
    Dim thread1 As Thread = Nothing
    ' Create the token source.
    Dim cts As CancellationTokenSource = New CancellationTokenSource()
    Private cuncel As Boolean = False
    Private Sub work(ByVal cancelToken As CancellationToken)
        Label2.BeginInvoke(Sub() Label2.Text = "Running")
        Dim i As Integer
        Do Until i = 100
            If cancelToken.IsCancellationRequested Then
                'Clean up here
                Debug.WriteLine("inside If cancelToken.IsCancellationRequested")
                Label2.BeginInvoke(Sub() Label2.Text = "Canceled")
                cuncel = True
                Return
            End If
            i += 1
            Label1.BeginInvoke(Sub() Label1.Text = $"{i}%")
            ProgressBar1.BeginInvoke(Sub() ProgressBar1.Value = i)
            Thread.Sleep(10)
        Loop
        Label2.BeginInvoke(Sub() Label2.Text = "Done")
    End Sub
    Structure para
        Private obj As Object
        Private cts As CancellationTokenSource
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cts Is Nothing Then cts = New CancellationTokenSource()
        thread1 = New System.Threading.Thread(AddressOf work)
        thread1.Start(cts.Token)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Request cancellation.
        cts.Cancel()
        Debug.WriteLine("Cancellation set in token source...")
        Thread.Sleep(100)
        ' Cancellation should have happened, so call Dispose.
        cts.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Navigate to a URL.
        System.Diagnostics.Process.Start("https://learn.microsoft.com/en-us/dotnet/standard/threading/cancellation-in-managed-threads#code-example")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/task-cancellation")
    End Sub
    'https://stackoverflow.com/questions/15067865/how-to-use-the-cancellationtoken-without-throwing-catching-an-exception
    'https://www.youtube.com/watch?v=TKc5A3exKBQ
End Class
