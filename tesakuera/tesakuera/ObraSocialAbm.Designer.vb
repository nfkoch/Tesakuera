<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObraSocialAbm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ObraSocialAbm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnGrabar = New Button()
        btnEditar = New Button()
        btnBaja = New Button()
        btnAlta = New Button()
        txtTelefono = New TextBox()
        Label3 = New Label()
        txtDescripcion = New TextBox()
        Label2 = New Label()
        txtCodigo = New TextBox()
        btnSalir = New Button()
        DataGridView1 = New DataGridView()
        CODIGO = New DataGridViewTextBoxColumn()
        DESCRIPCION = New DataGridViewTextBoxColumn()
        TELEFONO = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Codigo:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(btnGrabar)
        GroupBox1.Controls.Add(btnEditar)
        GroupBox1.Controls.Add(btnBaja)
        GroupBox1.Controls.Add(btnAlta)
        GroupBox1.Controls.Add(txtTelefono)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtDescripcion)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCodigo)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(17, 80)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(337, 367)
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
        btnGrabar.Location = New Point(143, 254)
        btnGrabar.Name = "btnGrabar"
        btnGrabar.Size = New Size(103, 93)
        btnGrabar.TabIndex = 9
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
        btnEditar.Location = New Point(34, 254)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(103, 93)
        btnEditar.TabIndex = 8
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
        btnBaja.Location = New Point(143, 155)
        btnBaja.Name = "btnBaja"
        btnBaja.Size = New Size(103, 93)
        btnBaja.TabIndex = 7
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
        btnAlta.Location = New Point(34, 155)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(103, 93)
        btnAlta.TabIndex = 6
        btnAlta.Text = "Alta"
        btnAlta.TextAlign = ContentAlignment.BottomCenter
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(68, 122)
        txtTelefono.MaxLength = 20
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(213, 23)
        txtTelefono.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 4
        Label3.Text = "Telefono:"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(84, 78)
        txtDescripcion.MaxLength = 50
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(234, 23)
        txtDescripcion.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 2
        Label2.Text = "Descripcion:"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Enabled = False
        txtCodigo.Location = New Point(61, 32)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(100, 23)
        txtCodigo.TabIndex = 1
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Firebrick
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.White
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.ImageAlign = ContentAlignment.TopCenter
        btnSalir.Location = New Point(901, 498)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(103, 93)
        btnSalir.TabIndex = 2
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.BottomCenter
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.Silver
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CODIGO, DESCRIPCION, TELEFONO})
        DataGridView1.Location = New Point(360, 115)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(644, 377)
        DataGridView1.TabIndex = 3
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
        ' TELEFONO
        ' 
        TELEFONO.HeaderText = "TELEFONO"
        TELEFONO.Name = "TELEFONO"
        TELEFONO.Width = 200
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(367, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 4
        Label4.Text = "Buscar:"
        ' 
        ' ObraSocialAbm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1020, 603)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(btnSalir)
        Controls.Add(GroupBox1)
        Name = "ObraSocialAbm"
        Sizable = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Obra Social Administracion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
End Class
