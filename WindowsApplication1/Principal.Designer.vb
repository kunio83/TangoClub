<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.txtTema = New System.Windows.Forms.TextBox()
        Me.lbltema = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttrack = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInterprete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodAlbum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkfecha = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSello = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.rdbOtro = New System.Windows.Forms.RadioButton()
        Me.rdbVals = New System.Windows.Forms.RadioButton()
        Me.rdbTango = New System.Windows.Forms.RadioButton()
        Me.rdbMilonga = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOrquesta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompositor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVocalista = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnListados = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(30, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(260, 190)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(306, 12)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(237, 189)
        Me.TreeView2.TabIndex = 1
        '
        'txtTema
        '
        Me.txtTema.Location = New System.Drawing.Point(85, 225)
        Me.txtTema.Name = "txtTema"
        Me.txtTema.Size = New System.Drawing.Size(269, 20)
        Me.txtTema.TabIndex = 2
        '
        'lbltema
        '
        Me.lbltema.AutoSize = True
        Me.lbltema.Location = New System.Drawing.Point(27, 232)
        Me.lbltema.Name = "lbltema"
        Me.lbltema.Size = New System.Drawing.Size(34, 13)
        Me.lbltema.TabIndex = 3
        Me.lbltema.Text = "Tema"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(27, 258)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(36, 13)
        Me.lblAlbum.TabIndex = 5
        Me.lblAlbum.Text = "Álbum"
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(85, 251)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(269, 20)
        Me.txtAlbum.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Track"
        '
        'txttrack
        '
        Me.txttrack.Location = New System.Drawing.Point(456, 225)
        Me.txttrack.Name = "txttrack"
        Me.txttrack.Size = New System.Drawing.Size(87, 20)
        Me.txttrack.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(85, 280)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Interprete/s"
        '
        'txtInterprete
        '
        Me.txtInterprete.Location = New System.Drawing.Point(30, 400)
        Me.txtInterprete.Name = "txtInterprete"
        Me.txtInterprete.Size = New System.Drawing.Size(513, 20)
        Me.txtInterprete.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cod. Álbum"
        '
        'txtCodAlbum
        '
        Me.txtCodAlbum.Location = New System.Drawing.Point(456, 251)
        Me.txtCodAlbum.Name = "txtCodAlbum"
        Me.txtCodAlbum.Size = New System.Drawing.Size(87, 20)
        Me.txtCodAlbum.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha"
        '
        'chkfecha
        '
        Me.chkfecha.AutoSize = True
        Me.chkfecha.Location = New System.Drawing.Point(273, 284)
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Size = New System.Drawing.Size(69, 17)
        Me.chkfecha.TabIndex = 5
        Me.chkfecha.Text = "Solo Año"
        Me.chkfecha.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(387, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Sello"
        '
        'txtSello
        '
        Me.txtSello.Location = New System.Drawing.Point(423, 282)
        Me.txtSello.Name = "txtSello"
        Me.txtSello.Size = New System.Drawing.Size(120, 20)
        Me.txtSello.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGenero)
        Me.GroupBox1.Controls.Add(Me.rdbOtro)
        Me.GroupBox1.Controls.Add(Me.rdbVals)
        Me.GroupBox1.Controls.Add(Me.rdbTango)
        Me.GroupBox1.Controls.Add(Me.rdbMilonga)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 52)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genero"
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(286, 20)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(204, 20)
        Me.txtGenero.TabIndex = 13
        '
        'rdbOtro
        '
        Me.rdbOtro.AutoSize = True
        Me.rdbOtro.Location = New System.Drawing.Point(222, 23)
        Me.rdbOtro.Name = "rdbOtro"
        Me.rdbOtro.Size = New System.Drawing.Size(45, 17)
        Me.rdbOtro.TabIndex = 12
        Me.rdbOtro.TabStop = True
        Me.rdbOtro.Text = "Otro"
        Me.rdbOtro.UseVisualStyleBackColor = True
        '
        'rdbVals
        '
        Me.rdbVals.AutoSize = True
        Me.rdbVals.Location = New System.Drawing.Point(162, 23)
        Me.rdbVals.Name = "rdbVals"
        Me.rdbVals.Size = New System.Drawing.Size(45, 17)
        Me.rdbVals.TabIndex = 11
        Me.rdbVals.TabStop = True
        Me.rdbVals.Text = "Vals"
        Me.rdbVals.UseVisualStyleBackColor = True
        '
        'rdbTango
        '
        Me.rdbTango.AutoSize = True
        Me.rdbTango.Location = New System.Drawing.Point(87, 23)
        Me.rdbTango.Name = "rdbTango"
        Me.rdbTango.Size = New System.Drawing.Size(56, 17)
        Me.rdbTango.TabIndex = 10
        Me.rdbTango.TabStop = True
        Me.rdbTango.Text = "Tango"
        Me.rdbTango.UseVisualStyleBackColor = True
        '
        'rdbMilonga
        '
        Me.rdbMilonga.AutoSize = True
        Me.rdbMilonga.Location = New System.Drawing.Point(19, 23)
        Me.rdbMilonga.Name = "rdbMilonga"
        Me.rdbMilonga.Size = New System.Drawing.Size(62, 17)
        Me.rdbMilonga.TabIndex = 9
        Me.rdbMilonga.TabStop = True
        Me.rdbMilonga.Text = "Milonga"
        Me.rdbMilonga.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Orquesta / Acompañamiento"
        '
        'txtOrquesta
        '
        Me.txtOrquesta.Location = New System.Drawing.Point(29, 450)
        Me.txtOrquesta.Name = "txtOrquesta"
        Me.txtOrquesta.Size = New System.Drawing.Size(513, 20)
        Me.txtOrquesta.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Compositor/es"
        '
        'txtCompositor
        '
        Me.txtCompositor.Location = New System.Drawing.Point(29, 502)
        Me.txtCompositor.Name = "txtCompositor"
        Me.txtCompositor.Size = New System.Drawing.Size(513, 20)
        Me.txtCompositor.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 535)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Autor/es"
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(29, 551)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(513, 20)
        Me.txtAutor.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 577)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Vocalista/s"
        '
        'txtVocalista
        '
        Me.txtVocalista.Location = New System.Drawing.Point(29, 593)
        Me.txtVocalista.Name = "txtVocalista"
        Me.txtVocalista.Size = New System.Drawing.Size(513, 20)
        Me.txtVocalista.TabIndex = 18
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(84, 632)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(147, 28)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnListados
        '
        Me.btnListados.Location = New System.Drawing.Point(237, 632)
        Me.btnListados.Name = "btnListados"
        Me.btnListados.Size = New System.Drawing.Size(143, 28)
        Me.btnListados.TabIndex = 20
        Me.btnListados.Text = "Ir a Listados"
        Me.btnListados.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 673)
        Me.Controls.Add(Me.btnListados)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVocalista)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCompositor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOrquesta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSello)
        Me.Controls.Add(Me.chkfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodAlbum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInterprete)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttrack)
        Me.Controls.Add(Me.lblAlbum)
        Me.Controls.Add(Me.txtAlbum)
        Me.Controls.Add(Me.lbltema)
        Me.Controls.Add(Me.txtTema)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Principal"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents txtTema As TextBox
    Friend WithEvents lbltema As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttrack As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInterprete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodAlbum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkfecha As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSello As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents rdbOtro As RadioButton
    Friend WithEvents rdbVals As RadioButton
    Friend WithEvents rdbTango As RadioButton
    Friend WithEvents rdbMilonga As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOrquesta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCompositor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVocalista As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnListados As Button
End Class
