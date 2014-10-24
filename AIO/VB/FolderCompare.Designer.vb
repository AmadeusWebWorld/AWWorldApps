<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderCompare
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
		Me.Directory1 = New TextBoxEx
		Me.Directory2 = New TextBoxEx
        Me.Compare = New System.Windows.Forms.Button
        Me.FilesFound = New System.Windows.Forms.ListView
        Me.ColRelPath = New System.Windows.Forms.ColumnHeader
        Me.ColLeft = New System.Windows.Forms.ColumnHeader
        Me.ColRight = New System.Windows.Forms.ColumnHeader
        Me.ColSame = New System.Windows.Forms.ColumnHeader
        Me.ColLevel = New System.Windows.Forms.ColumnHeader
        Me.WhatToShow = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Directory1
        '
        Me.Directory1.AllowDrop = True
        Me.Directory1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Directory1.Location = New System.Drawing.Point(12, 11)
        Me.Directory1.Name = "Directory1"
        Me.Directory1.Size = New System.Drawing.Size(669, 20)
        Me.Directory1.TabIndex = 3
        Me.Directory1.Text = "..\..\Data\Gen Library"
        '
        'Directory2
        '
        Me.Directory2.AllowDrop = True
        Me.Directory2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Directory2.Location = New System.Drawing.Point(12, 34)
        Me.Directory2.Name = "Directory2"
        Me.Directory2.Size = New System.Drawing.Size(669, 20)
        Me.Directory2.TabIndex = 3
        Me.Directory2.Text = ".\Gen Library"
        '
        'Compare
        '
        Me.Compare.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Compare.Enabled = False
        Me.Compare.Location = New System.Drawing.Point(768, 11)
        Me.Compare.Name = "Compare"
        Me.Compare.Size = New System.Drawing.Size(40, 43)
        Me.Compare.TabIndex = 4
        Me.Compare.Text = "Compare"
        Me.Compare.UseVisualStyleBackColor = True
        '
        'FilesFound
        '
        Me.FilesFound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilesFound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColRelPath, Me.ColLeft, Me.ColRight, Me.ColSame, Me.ColLevel})
        Me.FilesFound.FullRowSelect = True
        Me.FilesFound.GridLines = True
        Me.FilesFound.HideSelection = False
        Me.FilesFound.Location = New System.Drawing.Point(12, 60)
        Me.FilesFound.Name = "FilesFound"
        Me.FilesFound.Size = New System.Drawing.Size(796, 268)
        Me.FilesFound.TabIndex = 5
        Me.FilesFound.UseCompatibleStateImageBehavior = False
        Me.FilesFound.View = System.Windows.Forms.View.Details
        '
        'ColRelPath
        '
        Me.ColRelPath.Text = "Relative Path"
        Me.ColRelPath.Width = 431
        '
        'ColLeft
        '
        Me.ColLeft.Text = "Left"
        '
        'ColRight
        '
        Me.ColRight.Text = "Right"
        '
        'ColSame
        '
        Me.ColSame.Text = "Same"
        '
        'ColLevel
        '
        Me.ColLevel.Text = "Level"
        '
        'WhatToShow
        '
        Me.WhatToShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhatToShow.FormattingEnabled = True
        Me.WhatToShow.Location = New System.Drawing.Point(687, 11)
        Me.WhatToShow.Name = "WhatToShow"
        Me.WhatToShow.Size = New System.Drawing.Size(75, 43)
        Me.WhatToShow.TabIndex = 6
        '
        'FolderCompare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 340)
        Me.Controls.Add(Me.WhatToShow)
        Me.Controls.Add(Me.FilesFound)
        Me.Controls.Add(Me.Compare)
        Me.Controls.Add(Me.Directory2)
        Me.Controls.Add(Me.Directory1)
        Me.Name = "FolderCompare"
        Me.Text = "FolderCompare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents Directory1 As TextBoxEx
	Friend WithEvents Directory2 As TextBoxEx
    Friend WithEvents Compare As System.Windows.Forms.Button
    Friend WithEvents FilesFound As System.Windows.Forms.ListView
    Friend WithEvents ColRelPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColLeft As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColRight As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColSame As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColLevel As System.Windows.Forms.ColumnHeader
    Friend WithEvents WhatToShow As System.Windows.Forms.ListBox
End Class
