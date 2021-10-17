<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GetNewPackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearPackageListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.textURL = New System.Windows.Forms.TextBox
        Me.buttonDownload = New System.Windows.Forms.Button
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.listPkgs = New System.Windows.Forms.ListBox
        Me.textDesc = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.InfoToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(502, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPackageToolStripMenuItem, Me.GetNewPackagesToolStripMenuItem, Me.ClearPackageListToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AddPackageToolStripMenuItem
        '
        Me.AddPackageToolStripMenuItem.Name = "AddPackageToolStripMenuItem"
        Me.AddPackageToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AddPackageToolStripMenuItem.Text = "Custom Package"
        '
        'GetNewPackagesToolStripMenuItem
        '
        Me.GetNewPackagesToolStripMenuItem.Name = "GetNewPackagesToolStripMenuItem"
        Me.GetNewPackagesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GetNewPackagesToolStripMenuItem.Text = "Get New Packages"
        '
        'ClearPackageListToolStripMenuItem
        '
        Me.ClearPackageListToolStripMenuItem.Name = "ClearPackageListToolStripMenuItem"
        Me.ClearPackageListToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClearPackageListToolStripMenuItem.Text = "Clear Package List"
        '
        'InfoToolStripMenuItem1
        '
        Me.InfoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1"
        Me.InfoToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.InfoToolStripMenuItem1.Text = "Info"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.95174!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.32204!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.67797!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(502, 221)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.textURL, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.buttonDownload, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 189)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(496, 29)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'textURL
        '
        Me.textURL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textURL.Location = New System.Drawing.Point(3, 3)
        Me.textURL.Name = "textURL"
        Me.textURL.ReadOnly = True
        Me.textURL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.textURL.Size = New System.Drawing.Size(400, 20)
        Me.textURL.TabIndex = 3
        '
        'buttonDownload
        '
        Me.buttonDownload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonDownload.Location = New System.Drawing.Point(409, 3)
        Me.buttonDownload.Name = "buttonDownload"
        Me.buttonDownload.Size = New System.Drawing.Size(84, 23)
        Me.buttonDownload.TabIndex = 4
        Me.buttonDownload.Text = "Download"
        Me.buttonDownload.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.54839!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.45161!))
        Me.TableLayoutPanel4.Controls.Add(Me.listPkgs, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.textDesc, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(496, 180)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'listPkgs
        '
        Me.listPkgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listPkgs.FormattingEnabled = True
        Me.listPkgs.Location = New System.Drawing.Point(3, 3)
        Me.listPkgs.Name = "listPkgs"
        Me.listPkgs.Size = New System.Drawing.Size(210, 173)
        Me.listPkgs.TabIndex = 3
        '
        'textDesc
        '
        Me.textDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textDesc.Location = New System.Drawing.Point(219, 3)
        Me.textDesc.Multiline = True
        Me.textDesc.Name = "textDesc"
        Me.textDesc.ReadOnly = True
        Me.textDesc.Size = New System.Drawing.Size(274, 174)
        Me.textDesc.TabIndex = 4
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 245)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auditorial Complex"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPackageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetNewPackagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearPackageListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents listPkgs As System.Windows.Forms.ListBox
    Friend WithEvents textDesc As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents textURL As System.Windows.Forms.TextBox
    Friend WithEvents buttonDownload As System.Windows.Forms.Button

End Class
