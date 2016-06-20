Public Class VBRepository
    Public Shared Sub SubirAftp(ByVal RutaArchivo, ByVal NombreArchivo)
        My.Computer.Network.UploadFile(RutaArchivo, "ftp://fs000512.ferozo.com/" & NombreArchivo, "uploadmp3@fs000512.ferozo.com", "Batc2016", True, 500)

    End Sub
End Class
