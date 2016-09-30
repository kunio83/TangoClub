Public Class VBRepository
    Public Shared Function SubirAftp(ByVal RutaArchivo, ByVal NombreArchivo, ByVal Host, ByVal User, ByVal Pass, ByVal Timeout) As Boolean
        Try
            My.Computer.Network.UploadFile(RutaArchivo, Host & NombreArchivo, User, Pass, True, Timeout, FileIO.UICancelOption.ThrowException)
            SubirAftp = True
        Catch ex As Exception
            'MsgBox(ex.Message)
            SubirAftp = False
        End Try
    End Function
End Class
