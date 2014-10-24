Imports cm = System.Configuration.ConfigurationManager
Imports System.IO

Public Class App

    Public Shared ReadOnly DataFolder As String = IIf(cm.AppSettings("DataFolder").Contains(":") = False _
                                             , New DirectoryInfo(".\").FullName, String.Empty) & cm.AppSettings("DataFolder")

    Public Shared ReadOnly GenDataFolder As String = Path.Combine(DataFolder, "Gen Library")
    Public Shared ReadOnly DiffUtil As String = cm.AppSettings("ExternalDiffTool")
    Public Shared ReadOnly SDImageUrl As String = cm.AppSettings("SDImageUrl").Replace("%26", "&")
    Public Shared ReadOnly SDTemplatesUrl As String = cm.AppSettings("SDTemplatesUrl")
    Public Shared ReadOnly SDTemplateReplaces() As String = Split(cm.AppSettings("SDTemplateReplaces"), "|")
    Public Shared ReadOnly Encoding = System.Text.Encoding.GetEncoding(1250)

    Public Shared Function GetDataPath(ByVal relPath As String) As String
        Return Path.Combine(DataFolder, relPath)
    End Function

    Public Shared Function GetGenDataPath(ByVal relPath As String) As String
        Return Path.Combine(GenDataFolder, relPath)
    End Function

    Public Shared Function FileEquals(ByVal one As FileInfo, ByVal other As FileInfo) As Boolean
        If one.Length <> other.Length Then
            Return False
        Else
            If one.Length <> other.Length Then
                Return False
            Else
                Return File.ReadAllText(one.FullName).Equals(File.ReadAllText(other.FullName))
            End If
        End If
    End Function

    Public Shared Resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIOMain))

End Class
