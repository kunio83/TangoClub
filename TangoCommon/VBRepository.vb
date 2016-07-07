Public Class VBRepository
    Public Shared Function SubirAftp(ByVal RutaArchivo, ByVal NombreArchivo, ByVal Host, ByVal User, ByVal Pass) As Boolean
        Try
            My.Computer.Network.UploadFile(RutaArchivo, Host & NombreArchivo, User, Pass, True, 500, FileIO.UICancelOption.ThrowException)
            SubirAftp = True
        Catch ex As Exception
            MsgBox("Carga Cancelada por el usuario")
            SubirAftp = False
        End Try
    End Function
End Class
