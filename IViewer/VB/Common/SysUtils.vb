Module SysUtils
	Public Function IsKey(ByVal ip As Keys, ByVal match As Keys)
		Return (ip And match) = match
	End Function
End Module
