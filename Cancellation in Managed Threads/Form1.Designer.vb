<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        ProgressBar1 = New ProgressBar()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(233, 114)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(233, 270)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "stop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(53, 185)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(475, 18)
        ProgressBar1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(266, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 28)
        Label1.TabIndex = 3
        Label1.Text = "0%"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(258, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 28)
        Label2.TabIndex = 4
        Label2.Text = "Run"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(115, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(392, 28)
        Label3.TabIndex = 5
        Label3.Text = "Cancellation in Managed Threads - .NET"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.DimGray
        LinkLabel1.Location = New Point(12, 54)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(602, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "https://learn.microsoft.com/en-us/dotnet/standard/threading/cancellation-in-managed-threads#code-example"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel2.LinkColor = Color.DimGray
        LinkLabel2.Location = New Point(53, 80)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(497, 15)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/task-cancellation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 343)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
