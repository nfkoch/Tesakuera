<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacienteABM
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PacienteABM))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        dtFechaNacimiento = New DateTimePicker()
        Label12 = New Label()
        cmbObraSocial = New ComboBox()
        Label11 = New Label()
        btnGrabar = New Button()
        btnEditar = New Button()
        btnBaja = New Button()
        btnAlta = New Button()
        cmbSexo = New ComboBox()
        Label9 = New Label()
        cmbLocalidad = New ComboBox()
        Label8 = New Label()
        cmbProvincia = New ComboBox()
        Label7 = New Label()
        txtEmail = New TextBox()
        Label6 = New Label()
        txtTelefono = New TextBox()
        Label5 = New Label()
        txtDireccion = New TextBox()
        Label4 = New Label()
        txtCuil = New TextBox()
        Label3 = New Label()
        txtDescripcion = New TextBox()
        Label2 = New Label()
        txtCodigo = New TextBox()
        Label1 = New Label()
        btnSalir = New Button()
        Label10 = New Label()
        DataGridView1 = New DataGridView()
        CODIGO = New DataGridViewTextBoxColumn()
        DESCRIPCION = New DataGridViewTextBoxColumn()
        DNI = New DataGridViewTextBoxColumn()
        DIRECCION = New DataGridViewTextBoxColumn()
        TELEFONO = New DataGridViewTextBoxColumn()
        EMAIL = New DataGridViewTextBoxColumn()
        PROVINCIA = New DataGridViewTextBoxColumn()
        LOCALIDAD = New DataGridViewTextBoxColumn()
        SEXO = New DataGridViewTextBoxColumn()
        OBRASOCIAL = New DataGridViewTextBoxColumn()
        FECHANACIMIENTO = New DataGridViewTextBoxColumn()
        txtFiltro = New TextBox()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dtFechaNacimiento)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(cmbObraSocial)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(btnGrabar)
        GroupBox1.Controls.Add(btnEditar)
        GroupBox1.Controls.Add(btnBaja)
        GroupBox1.Controls.Add(btnAlta)
        GroupBox1.Controls.Add(cmbSexo)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(cmbLocalidad)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cmbProvincia)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtTelefono)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtDireccion)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtCuil)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtDescripcion)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCodigo)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 75)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 686)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Basicos"
        ' 
        ' dtFechaNacimiento
        ' 
        dtFechaNacimiento.Format = DateTimePickerFormat.Short
        dtFechaNacimiento.Location = New Point(115, 422)
        dtFechaNacimiento.Name = "dtFechaNacimiento"
        dtFechaNacimiento.Size = New Size(107, 23)
        dtFechaNacimiento.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(3, 428)
        Label12.Name = "Label12"
        Label12.Size = New Size(106, 15)
        Label12.TabIndex = 23
        Label12.Text = "Fecha Nacimiento:"
        ' 
        ' cmbObraSocial
        ' 
        cmbObraSocial.FormattingEnabled = True
        cmbObraSocial.Location = New Point(79, 382)
        cmbObraSocial.Name = "cmbObraSocial"
        cmbObraSocial.Size = New Size(209, 23)
        cmbObraSocial.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(3, 385)
        Label11.Name = "Label11"
        Label11.Size = New Size(70, 15)
        Label11.TabIndex = 21
        Label11.Text = "Obra Social:"
        ' 
        ' btnGrabar
        ' 
        btnGrabar.BackColor = Color.DarkSlateGray
        btnGrabar.FlatStyle = FlatStyle.Flat
        btnGrabar.ForeColor = Color.White
        btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), Image)
        btnGrabar.ImageAlign = ContentAlignment.TopCenter
        btnGrabar.Location = New Point(178, 578)
        btnGrabar.Name = "btnGrabar"
        btnGrabar.Size = New Size(103, 93)
        btnGrabar.TabIndex = 20
        btnGrabar.Text = "Grabar"
        btnGrabar.TextAlign = ContentAlignment.BottomCenter
        btnGrabar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.LightSkyBlue
        btnEditar.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.ForeColor = Color.White
        btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), Image)
        btnEditar.ImageAlign = ContentAlignment.TopCenter
        btnEditar.Location = New Point(69, 578)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(103, 93)
        btnEditar.TabIndex = 19
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.BottomCenter
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnBaja
        ' 
        btnBaja.BackColor = Color.Red
        btnBaja.FlatAppearance.BorderColor = Color.Red
        btnBaja.FlatStyle = FlatStyle.Flat
        btnBaja.ForeColor = Color.White
        btnBaja.Image = CType(resources.GetObject("btnBaja.Image"), Image)
        btnBaja.ImageAlign = ContentAlignment.TopCenter
        btnBaja.Location = New Point(178, 479)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(103, 93)
        btnBaja.TabIndex = 18
        btnBaja.Text = "Baja"
        btnBaja.TextAlign = ContentAlignment.BottomCenter
        btnBaja.UseVisualStyleBackColor = False
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = Color.ForestGreen
        btnAlta.FlatAppearance.BorderColor = Color.ForestGreen
        btnAlta.FlatStyle = FlatStyle.Flat
        btnAlta.ForeColor = Color.White
        btnAlta.Image = CType(resources.GetObject("btnAlta.Image"), Image)
        btnAlta.ImageAlign = ContentAlignment.TopCenter
        btnAlta.Location = New Point(69, 479)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(103, 93)
        btnAlta.TabIndex = 17
        btnAlta.Text = "Alta"
        btnAlta.TextAlign = ContentAlignment.BottomCenter
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' cmbSexo
        ' 
        cmbSexo.FormattingEnabled = True
        cmbSexo.Items.AddRange(New Object() {"F", "M", "X"})
        cmbSexo.Location = New Point(43, 340)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(55, 23)
        cmbSexo.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 343)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 15)
        Label9.TabIndex = 15
        Label9.Text = "Sexo:"
        ' 
        ' cmbLocalidad
        ' 
        cmbLocalidad.FormattingEnabled = True
        cmbLocalidad.Location = New Point(69, 303)
        cmbLocalidad.Name = "cmbLocalidad"
        cmbLocalidad.Size = New Size(219, 23)
        cmbLocalidad.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 306)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 13
        Label8.Text = "Localidad:"
        ' 
        ' cmbProvincia
        ' 
        cmbProvincia.FormattingEnabled = True
        cmbProvincia.Location = New Point(69, 266)
        cmbProvincia.Name = "cmbProvincia"
        cmbProvincia.Size = New Size(219, 23)
        cmbProvincia.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(3, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 11
        Label7.Text = "Provincia:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(53, 228)
        txtEmail.MaxLength = 50
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(235, 23)
        txtEmail.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 9
        Label6.Text = "Email:"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(69, 187)
        txtTelefono.MaxLength = 50
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(190, 23)
        txtTelefono.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 1
        Label5.Text = "Telefono:"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(69, 151)
        txtDireccion.MaxLength = 50
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(291, 23)
        txtDireccion.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 6
        Label4.Text = "Direccion:"
        ' 
        ' txtCuil
        ' 
        txtCuil.Location = New Point(39, 114)
        txtCuil.MaxLength = 11
        txtCuil.Name = "txtCuil"
        txtCuil.Size = New Size(199, 23)
        txtCuil.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 4
        Label3.Text = "DNI:"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(81, 74)
        txtDescripcion.MaxLength = 50
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(279, 23)
        txtDescripcion.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 2
        Label2.Text = "Descripcion:"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Enabled = False
        txtCodigo.Location = New Point(58, 31)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(90, 23)
        txtCodigo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Codigo:"
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Firebrick
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.White
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.ImageAlign = ContentAlignment.TopCenter
        btnSalir.Location = New Point(1478, 668)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(103, 93)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.BottomCenter
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(411, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 15)
        Label10.TabIndex = 6
        Label10.Text = "Buscar:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.Silver
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CODIGO, DESCRIPCION, DNI, DIRECCION, TELEFONO, EMAIL, PROVINCIA, LOCALIDAD, SEXO, OBRASOCIAL, FECHANACIMIENTO})
        DataGridView1.Location = New Point(411, 109)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1170, 553)
        DataGridView1.TabIndex = 5
        ' 
        ' CODIGO
        ' 
        CODIGO.HeaderText = "CODIGO"
        CODIGO.Name = "CODIGO"
        ' 
        ' DESCRIPCION
        ' 
        DESCRIPCION.HeaderText = "DESCRIPCION"
        DESCRIPCION.Name = "DESCRIPCION"
        DESCRIPCION.Width = 300
        ' 
        ' DNI
        ' 
        DNI.HeaderText = "DNI"
        DNI.Name = "DNI"
        ' 
        ' DIRECCION
        ' 
        DIRECCION.HeaderText = "DIRECCION"
        DIRECCION.Name = "DIRECCION"
        ' 
        ' TELEFONO
        ' 
        TELEFONO.HeaderText = "TELEFONO"
        TELEFONO.Name = "TELEFONO"
        TELEFONO.Width = 200
        ' 
        ' EMAIL
        ' 
        EMAIL.HeaderText = "EMAIL"
        EMAIL.Name = "EMAIL"
        ' 
        ' PROVINCIA
        ' 
        PROVINCIA.HeaderText = "PROVINCIA"
        PROVINCIA.Name = "PROVINCIA"
        ' 
        ' LOCALIDAD
        ' 
        LOCALIDAD.HeaderText = "LOCALIDAD"
        LOCALIDAD.Name = "LOCALIDAD"
        ' 
        ' SEXO
        ' 
        SEXO.HeaderText = "SEXO"
        SEXO.Name = "SEXO"
        ' 
        ' OBRASOCIAL
        ' 
        OBRASOCIAL.HeaderText = "OBRA SOCIAL"
        OBRASOCIAL.Name = "OBRASOCIAL"
        ' 
        ' FECHANACIMIENTO
        ' 
        FECHANACIMIENTO.HeaderText = "FECHA DE NACIMIENTO"
        FECHANACIMIENTO.Name = "FECHANACIMIENTO"
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(462, 75)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(345, 23)
        txtFiltro.TabIndex = 7
        ' 
        ' PacienteABM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1595, 773)
        ControlBox = False
        Controls.Add(txtFiltro)
        Controls.Add(Label10)
        Controls.Add(DataGridView1)
        Controls.Add(btnSalir)
        Controls.Add(GroupBox1)
        Name = "PacienteABM"
        Sizable = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Paciente Administracion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCuil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbLocalidad As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbObraSocial As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtFechaNacimiento As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents PROVINCIA As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIDAD As DataGridViewTextBoxColumn
    Friend WithEvents SEXO As DataGridViewTextBoxColumn
    Friend WithEvents OBRASOCIAL As DataGridViewTextBoxColumn
    Friend WithEvents FECHANACIMIENTO As DataGridViewTextBoxColumn
    Friend WithEvents txtFiltro As TextBox
End Class
