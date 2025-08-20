<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorABM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorABM))
        GroupBox1 = New GroupBox()
        btnGrabar = New Button()
        btnEditar = New Button()
        btnBaja = New Button()
        btnAlta = New Button()
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
        txtFiltro = New TextBox()
        Label10 = New Label()
        DataGridView1 = New DataGridView()
        CODIGO = New DataGridViewTextBoxColumn()
        DESCRIPCION = New DataGridViewTextBoxColumn()
        DNI = New DataGridViewTextBoxColumn()
        MATRICULA = New DataGridViewTextBoxColumn()
        TELEFONO = New DataGridViewTextBoxColumn()
        EMAIL = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnGrabar)
        GroupBox1.Controls.Add(btnEditar)
        GroupBox1.Controls.Add(btnBaja)
        GroupBox1.Controls.Add(btnAlta)
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
        GroupBox1.Location = New Point(12, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 487)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Basicos"
        ' 
        ' btnGrabar
        ' 
        btnGrabar.BackColor = Color.DarkSlateGray
        btnGrabar.FlatStyle = FlatStyle.Flat
        btnGrabar.ForeColor = Color.White
        btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), Image)
        btnGrabar.ImageAlign = ContentAlignment.TopCenter
        btnGrabar.Location = New Point(185, 379)
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
        btnEditar.Location = New Point(76, 379)
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
        btnBaja.Location = New Point(185, 280)
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
        btnAlta.Location = New Point(76, 280)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(103, 93)
        btnAlta.TabIndex = 17
        btnAlta.Text = "Alta"
        btnAlta.TextAlign = ContentAlignment.BottomCenter
        btnAlta.UseVisualStyleBackColor = False
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
        Label4.Text = "Matricula:"
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
        btnSalir.Location = New Point(1491, 676)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(103, 93)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.BottomCenter
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(447, 85)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(345, 23)
        txtFiltro.TabIndex = 11
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(396, 88)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 15)
        Label10.TabIndex = 10
        Label10.Text = "Buscar:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CODIGO, DESCRIPCION, DNI, MATRICULA, TELEFONO, EMAIL})
        DataGridView1.Location = New Point(396, 117)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1170, 553)
        DataGridView1.TabIndex = 9
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
        ' MATRICULA
        ' 
        MATRICULA.HeaderText = "MATRICULA"
        MATRICULA.Name = "MATRICULA"
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
        ' DoctorABM
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1606, 791)
        ControlBox = False
        Controls.Add(txtFiltro)
        Controls.Add(Label10)
        Controls.Add(DataGridView1)
        Controls.Add(btnSalir)
        Controls.Add(GroupBox1)
        Name = "DoctorABM"
        Sizable = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Doctor Administracion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCuil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents MATRICULA As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
End Class
