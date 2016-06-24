Public Class VBRepository
    Public Shared Sub SubirAftp(ByVal RutaArchivo, ByVal NombreArchivo, ByVal Host, ByVal User, ByVal Pass)
        'My.Computer.Network.UploadFile(RutaArchivo, "ftp://fs000512.ferozo.com/" & NombreArchivo, "uploadmp3@prestashoptesting.com", "Batc2016", True, 500)
        My.Computer.Network.UploadFile(RutaArchivo, Host & NombreArchivo, User, Pass, True, 500)


    End Sub
End Class
