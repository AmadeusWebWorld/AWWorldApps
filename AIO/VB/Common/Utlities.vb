Public Class Utilities

    Private Shared chars() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray

    Public Shared Function Humanize(ByVal str As String) As String

        Dim pos As Integer
        pos = str.IndexOfAny(chars, 2)
        While pos <> -1
            str = str.Insert(pos, " ")
            pos = str.IndexOfAny(chars, pos + 2)
        End While
        Return str

    End Function



End Class
