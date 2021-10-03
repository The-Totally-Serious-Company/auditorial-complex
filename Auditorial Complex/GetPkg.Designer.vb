<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetPkg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GetPkg))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.ZipForge1 = New ComponentAce.Compression.ZipForge.ZipForge
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2000s Games"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ZipForge1
        '
        Me.ZipForge1.Active = False
        Me.ZipForge1.BaseDir = ""
        Me.ZipForge1.CompressionLevel = ComponentAce.Compression.Archiver.CompressionLevel.Fastest
        Me.ZipForge1.CompressionMethod = ComponentAce.Compression.Archiver.CompressionMethod.Deflate
        Me.ZipForge1.CompressionMode = CType(1, Byte)
        Me.ZipForge1.EncryptionAlgorithm = ComponentAce.Compression.Archiver.EncryptionAlgorithm.None
        Me.ZipForge1.ExtractCorruptedFiles = False
        Me.ZipForge1.FileName = ""
        Me.ZipForge1.InMemory = False
        Me.ZipForge1.OpenCorruptedArchives = True
        Me.ZipForge1.Password = ""
        Me.ZipForge1.SFXStub = ""
        Me.ZipForge1.SpanningMode = ComponentAce.Compression.Archiver.SpanningMode.None
        Me.ZipForge1.StoreNTFSTimeStamps = False
        Me.ZipForge1.TempDir = Nothing
        Me.ZipForge1.UnicodeFilenames = True
        Me.ZipForge1.Zip64Mode = ComponentAce.Compression.Archiver.Zip64Mode.[Auto]
        '
        'GetPkg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 207)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GetPkg"
        Me.Text = "Get New Packages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ZipForge1 As ComponentAce.Compression.ZipForge.ZipForge
End Class
