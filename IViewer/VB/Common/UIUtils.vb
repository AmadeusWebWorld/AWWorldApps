Public Module UIUtils

	Public Sub AlignToRight(ByVal ctl As Control)
		ctl.Left = ctl.Parent.Width - ctl.Width - 10
	End Sub

	''' <summary>
	''' Set Text (if nothing, will turn invisible) and then align to right
	''' </summary>
	Public Sub SetAndAlign(ByVal lbl As Label, Optional ByVal str As String = Nothing)
		If str Is Nothing Then
			lbl.Visible = False
		Else
			lbl.Visible = True
			lbl.Text = str
			AlignToRight(lbl)
		End If
	End Sub

End Module
