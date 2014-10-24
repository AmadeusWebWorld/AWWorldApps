<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveSync
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"default.thtml", "D:\imu\mystuff 2\cake php\source\cake\libs\view\templates\layouts\default.thtml"}, -1)
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActiveSync))
		Me.Files = New System.Windows.Forms.ListView
		Me.FileName = New System.Windows.Forms.ColumnHeader
		Me.FilePath = New System.Windows.Forms.ColumnHeader
		Me.Action = New System.Windows.Forms.ColumnHeader
		Me.icons = New System.Windows.Forms.ImageList(Me.components)
		Me.Log = New System.Windows.Forms.TextBox
		Me.Sync = New System.Windows.Forms.Button
		Me.splitter1 = New System.Windows.Forms.SplitContainer
		Me.DeleteLocal = New System.Windows.Forms.Button
		Me.DeleteFTP = New System.Windows.Forms.Button
		Me.Pause = New System.Windows.Forms.Button
		Me.fsw = New System.IO.FileSystemWatcher
		Me.splitter1.Panel1.SuspendLayout()
		Me.splitter1.Panel2.SuspendLayout()
		Me.splitter1.SuspendLayout()
		CType(Me.fsw, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Files
		'
		Me.Files.AllowDrop = True
		Me.Files.CheckBoxes = True
		Me.Files.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileName, Me.FilePath, Me.Action})
		Me.Files.Dock = System.Windows.Forms.DockStyle.Fill
		ListViewItem1.StateImageIndex = 0
		Me.Files.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
		Me.Files.LargeImageList = Me.icons
		Me.Files.Location = New System.Drawing.Point(0, 0)
		Me.Files.Name = "Files"
		Me.Files.Size = New System.Drawing.Size(822, 290)
		Me.Files.SmallImageList = Me.icons
		Me.Files.TabIndex = 0
		Me.Files.UseCompatibleStateImageBehavior = False
		Me.Files.View = System.Windows.Forms.View.Details
		'
		'FileName
		'
		Me.FileName.Text = "FileName"
		Me.FileName.Width = 132
		'
		'FilePath
		'
		Me.FilePath.Text = "FilePath"
		Me.FilePath.Width = 404
		'
		'Action
		'
		Me.Action.Text = "Action"
		'
		'icons
		'
		Me.icons.ImageStream = CType(resources.GetObject("icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.icons.TransparentColor = System.Drawing.Color.Transparent
		Me.icons.Images.SetKeyName(0, "purp.ico")
		Me.icons.Images.SetKeyName(1, "file.gif")
		Me.icons.Images.SetKeyName(2, "text.ICO")
		Me.icons.Images.SetKeyName(3, "Find.gif")
		'
		'Log
		'
		Me.Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Log.Location = New System.Drawing.Point(0, 2)
		Me.Log.Multiline = True
		Me.Log.Name = "Log"
		Me.Log.Size = New System.Drawing.Size(741, 117)
		Me.Log.TabIndex = 1
		'
		'Sync
		'
		Me.Sync.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Sync.Location = New System.Drawing.Point(747, 5)
		Me.Sync.Name = "Sync"
		Me.Sync.Size = New System.Drawing.Size(67, 23)
		Me.Sync.TabIndex = 2
		Me.Sync.Text = "&Sync"
		Me.Sync.UseVisualStyleBackColor = True
		'
		'splitter1
		'
		Me.splitter1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitter1.Location = New System.Drawing.Point(0, 0)
		Me.splitter1.Name = "splitter1"
		Me.splitter1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'splitter1.Panel1
		'
		Me.splitter1.Panel1.Controls.Add(Me.Files)
		'
		'splitter1.Panel2
		'
		Me.splitter1.Panel2.Controls.Add(Me.Log)
		Me.splitter1.Panel2.Controls.Add(Me.DeleteLocal)
		Me.splitter1.Panel2.Controls.Add(Me.DeleteFTP)
		Me.splitter1.Panel2.Controls.Add(Me.Pause)
		Me.splitter1.Panel2.Controls.Add(Me.Sync)
		Me.splitter1.Size = New System.Drawing.Size(822, 416)
		Me.splitter1.SplitterDistance = 290
		Me.splitter1.TabIndex = 3
		'
		'DeleteLocal
		'
		Me.DeleteLocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DeleteLocal.Location = New System.Drawing.Point(747, 92)
		Me.DeleteLocal.Name = "DeleteLocal"
		Me.DeleteLocal.Size = New System.Drawing.Size(67, 23)
		Me.DeleteLocal.TabIndex = 2
		Me.DeleteLocal.Text = "Del &Local"
		Me.DeleteLocal.UseVisualStyleBackColor = True
		'
		'DeleteFTP
		'
		Me.DeleteFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DeleteFTP.Location = New System.Drawing.Point(747, 63)
		Me.DeleteFTP.Name = "DeleteFTP"
		Me.DeleteFTP.Size = New System.Drawing.Size(67, 23)
		Me.DeleteFTP.TabIndex = 2
		Me.DeleteFTP.Text = "Del &FTP"
		Me.DeleteFTP.UseVisualStyleBackColor = True
		'
		'Pause
		'
		Me.Pause.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Pause.Location = New System.Drawing.Point(747, 34)
		Me.Pause.Name = "Pause"
		Me.Pause.Size = New System.Drawing.Size(67, 23)
		Me.Pause.TabIndex = 2
		Me.Pause.Text = "&Pause"
		Me.Pause.UseVisualStyleBackColor = True
		'
		'fsw
		'
		Me.fsw.EnableRaisingEvents = True
		Me.fsw.SynchronizingObject = Me
		'
		'ActiveSync
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(822, 416)
		Me.Controls.Add(Me.splitter1)
		Me.Name = "ActiveSync"
		Me.Text = "ActiveSync"
		Me.splitter1.Panel1.ResumeLayout(False)
		Me.splitter1.Panel2.ResumeLayout(False)
		Me.splitter1.Panel2.PerformLayout()
		Me.splitter1.ResumeLayout(False)
		CType(Me.fsw, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
  Friend WithEvents splitter1 As System.Windows.Forms.SplitContainer
  Friend WithEvents Sync As System.Windows.Forms.Button
  Friend WithEvents Log As System.Windows.Forms.TextBox
  Friend WithEvents Files As System.Windows.Forms.ListView
  Friend WithEvents FileName As System.Windows.Forms.ColumnHeader
  Friend WithEvents FilePath As System.Windows.Forms.ColumnHeader
  Friend WithEvents fsw As System.IO.FileSystemWatcher
    Friend WithEvents icons As System.Windows.Forms.ImageList
    Friend WithEvents Pause As System.Windows.Forms.Button
    Friend WithEvents DeleteLocal As System.Windows.Forms.Button
	Friend WithEvents DeleteFTP As System.Windows.Forms.Button
	Friend WithEvents Action As System.Windows.Forms.ColumnHeader
End Class
