Public Class Rule

	Shared sample As String = "<ReturnValue>"

	Public Function GetSubItems() As String()
		Dim subitems(5) As String
		'subitems(0) = Me.Name
		subitems(0) = Me.AppliesTo
		subitems(1) = Me.ResultType
		subitems(2) = Me.MatchType
		If Me.MatchType = "String" Then
			subitems(3) = String.Format("{1}{0}{2}", sample, Me.StringMatchStartsWith, Me.StringMatchEndsWith)
		Else
			subitems(3) = Me.RegexMatchString
		End If
		Return subitems
	End Function

	Public Sub New()

	End Sub

	Public Sub New(ByVal lin As String)
		lin = "|" + lin
		Dim s() As String = lin.Split("|")
		Group = s(1)
		Name = s(2)
		AppliesTo = s(3)
		ResultType = s(4)
		MatchType = s(5)
		StringMatchStartsWith = s(6)
		StringMatchEndsWith = s(7)
		RegexMatchString = s(8)
		RegexMatchString = s(9)
	End Sub

	Public Overrides Function ToString() As String
		Return String.Format("{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}", "Rule", Me.Group, Me.Name, Me.AppliesTo, Me.ResultType, Me.MatchType, Me.StringMatchStartsWith, Me.StringMatchEndsWith, Me.RegexMatchString, Me.RegexMatchSubString)
	End Function

	Public Group As String
	Public Name As String
	Public AppliesTo As String
	Public ResultType As String
	Public MatchType As String
	Public StringMatchStartsWith As String
	Public StringMatchEndsWith As String
	Public RegexMatchString As String
	Public RegexMatchSubString As String

	Private _1 As String

	Public Property p1() As String
		Get
			Return _1
		End Get
		Set(ByVal value As String)
			_1 = value
		End Set
	End Property

End Class

