Imports System.Windows
Imports System
Imports System.IO
Imports HundredMilesSoftware
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports TangoClubUploader
Imports TangoClubUploader.Modelo


Public Class Principal

    Dim con As New SqlConnection

    Dim rutaRaiz, UltimaRuta, UltimoArchivo As String
    Dim Archivon, archivoSelecc As String



    Public Sub cargarSubcarpetas(ByVal rutaRaiz As String,
              ByVal nodoTree As System.Windows.Forms.TreeNode)
        On Error Resume Next
        Dim carpetaActual, subCarpeta As String
        Dim indice As Integer


        If nodoTree.Nodes.Count = 0 Then
            For Each carpetaActual In
                    My.Computer.FileSystem.GetDirectories(rutaRaiz)
                indice = carpetaActual.LastIndexOf(System.IO.Path.PathSeparator)
                subCarpeta = carpetaActual.Substring(indice + 1, carpetaActual.Length - indice - 1)
                subCarpeta = subCarpeta.Remove(0, subCarpeta.LastIndexOf("\") + 1)
                nodoTree.Nodes.Add(subCarpeta)
                nodoTree.LastNode.Tag = carpetaActual
                nodoTree.LastNode.ImageIndex = 0
            Next
        End If
    End Sub

    Public Sub cargarCarpetas(ByVal rutaRaiz As String)
        Dim nodoBase As System.Windows.Forms.TreeNode

        If IO.Directory.Exists(rutaRaiz) Then
            If rutaRaiz.Length <= 3 Then
                nodoBase = TreeView1.Nodes.Add(rutaRaiz)
            Else
                nodoBase = TreeView1.Nodes.Add(
                    My.Computer.FileSystem.GetName(rutaRaiz))
            End If
            nodoBase.Tag = rutaRaiz
            cargarSubcarpetas(rutaRaiz, nodoBase)
        Else
            Throw New System.IO.DirectoryNotFoundException()
        End If
    End Sub

    Private Sub TreeView1_AfterExpand(sender As System.Object,
               e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        Dim n As System.Windows.Forms.TreeNode
        For Each n In e.Node.Nodes
            cargarSubcarpetas(n.Tag, n)
        Next
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(local);Initial Catalog=TangoClubCatalogo;Integrated Security=True"

        ' rutaRaiz = Directory.GetCurrentDirectory
        rutaRaiz = "D:\Documents\id\TANGO CLUB\tango club C"
        cargarCarpetas(rutaRaiz)
        rdbTango.Checked = True
        txtGenero.Enabled = False
    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
        Dim rutaArchivo As String
        Dim InfoTag As New HundredMilesSoftware.UltraID3Lib.UltraID3()
        UltimoArchivo = TreeView2.SelectedNode.Text
        rutaArchivo = TreeView1.SelectedNode.Tag & "\" & TreeView2.SelectedNode.Text
        InfoTag.Read(rutaArchivo)
        Limipar_datos_Tema()

        txtTema.Text = InfoTag.Title
        If txtAlbum.Text = "" Then txtAlbum.Text = InfoTag.Album
        If IsNothing(InfoTag.TrackNum) Then
            txttrack.Text = ""
        Else
            txttrack.Text = InfoTag.TrackNum
        End If

        txtInterprete.Text = InfoTag.Artist







    End Sub



    Private Sub cargarARchivos()
        TreeView2.Nodes.Clear()
        Dim Extension, Artista As String
        Artista = ""
        For Each Archivo In My.Computer.FileSystem.GetFiles(UltimaRuta)
            Dim InfoTag As New HundredMilesSoftware.UltraID3Lib.UltraID3()
            InfoTag.Read(Archivo)
            Artista = InfoTag.Artist
            Archivon = Archivo.Remove(0, Archivo.LastIndexOf("\") + 1)
            Extension = Archivon.Remove(0, Archivon.LastIndexOf(".") + 1)
            If Extension.ToLower = "mp3" And Artista = "" Then
                TreeView2.Nodes.Add(Archivon)
            End If
        Next


    End Sub
    Public Sub SubirAftp(ByVal RutaArchivo, ByVal NombreArchivo)
        My.Computer.Network.UploadFile(RutaArchivo, "ftp://fs000512.ferozo.com/" & NombreArchivo, "uploadmp3@fs000512.ferozo.com", "Batc2016", True, 500)

    End Sub
    Private Sub rdbOtro_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOtro.CheckedChanged
        If rdbOtro.Checked = True Then
            txtGenero.Enabled = True
        Else
            txtGenero.Text = ""
            txtGenero.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim rutaArchivo, Genero, Estilo, CodigTrack, Fecha As String
        Dim InfoTag As New HundredMilesSoftware.UltraID3Lib.UltraID3()
        rutaArchivo = UltimaRuta & "\" & UltimoArchivo
        InfoTag.Read(rutaArchivo)
        InfoTag.ID3v2Tag.Title = txtTema.Text
        InfoTag.ID3v2Tag.Album = txtAlbum.Text
        If rdbMilonga.Checked = True Then Genero = "MILONGA"
        If rdbTango.Checked = True Then Genero = "TANGO"
        If rdbVals.Checked = True Then Genero = "VALS"
        If rdbOtro.Checked = True Then Genero = txtGenero.Text
        InfoTag.ID3v2Tag.Genre = Genero
        InfoTag.ID3v2Tag.Artist = txtInterprete.Text
        InfoTag.ID3v2Tag.Year = DateTimePicker1.Text.Remove(0, DateTimePicker1.Text.LastIndexOf("/") + 1)
        InfoTag.Write()
        CodigTrack = txtCodAlbum.Text & "-" & txttrack.Text
        If chkfecha.Checked = True Then
            Fecha = DateTimePicker1.Text.Remove(0, DateTimePicker1.Text.LastIndexOf("/") + 1)
            Fecha = DateTimePicker1.Text
        End If
        Estilo = "CANTADO"
        con.Open()
        Dim cmd As New SqlCommand(("INSERT INTO dbo.TangoClub VALUES('" & CodigTrack & "','" &
                                  txtTema.Text & "', '" & Fecha & "','" & txtAlbum.Text &
                                  "', '" & txtCodAlbum.Text & "','" & txtSello.Text & "', '" &
                                  txtGenero.Text & "','" & Estilo & "', '" & txtInterprete.Text & "', '" & txtOrquesta.Text &
                                  "', '" & txtCompositor.Text & "','" & txtVocalista.Text & "','" &
                                  txtAutor.Text & "','" & txttrack.Text & "','" & rutaArchivo & "')"), con)

        cmd.ExecuteNonQuery()
        con.Close()

        'My.Computer.Network.UploadFile(rutaArchivo, "ftp://fs000512.ferozo.com/" & UltimoArchivo, "uploadmp3@fs000512.ferozo.com", "Batc2016", True, 500)
        cargarARchivos()

        Dim cancion As New TangoClub()
        cancion.Album = txtAlbum.Text
        cancion.Path = rutaArchivo
        cancion.Autor = txtAutor.Text
        cancion.CodigoAlbum = txtCodAlbum.Text
        cancion.CodigTrack = CodigTrack
        cancion.Compositor = txtCompositor.Text
        cancion.Estilo = txtGenero.Text
        cancion.Genero = Estilo
        cancion.Fecha = Fecha
        cancion.Interprete = txtInterprete.Text
        cancion.Orquesta = txtOrquesta.Text
        cancion.Sello = txtSello.Text
        cancion.Tema = txtTema.Text
        cancion.Track = txttrack.Text
        cancion.Vocalista = txtVocalista.Text


        Dim productRepo As New ProductTangoRepository()
        productRepo.CargarCancionProducto(cancion)


    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        UltimaRuta = e.Node.Tag
        cargarARchivos()
    End Sub


    Private Sub Limipar_datos_Todo()
        txtTema.Clear()
        txttrack.Clear()
        txtAlbum.Clear()
        txtAutor.Clear()
        txtCodAlbum.Clear()
        txtCompositor.Clear()
        txtGenero.Clear()
        txtInterprete.Clear()
        txtOrquesta.Clear()
        txtSello.Clear()
        txtVocalista.Clear()
    End Sub

    Private Sub Limipar_datos_Tema()
        txtTema.Clear()
        txttrack.Clear()
    End Sub

End Class

