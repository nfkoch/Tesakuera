<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacienteBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PacienteBuscar))
        Label1 = New Label()
        txtFiltro = New TextBox()
        DataGridView1 = New DataGridView()
        CODIGO = New DataGridViewTextBoxColumn()
        DNI = New DataGridViewTextBoxColumn()
        NOMBRE = New DataGridViewTextBoxColumn()
        btnSalir = New Button()
        btnAlta = New Button()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "Filtrar"
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(55, 85)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(253, 23)
        txtFiltro.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CODIGO, DNI, NOMBRE})
        DataGridView1.Location = New Point(12, 114)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(544, 464)
        DataGridView1.TabIndex = 2
        ' 
        ' CODIGO
        ' 
        CODIGO.HeaderText = "CODIGO"
        CODIGO.Name = "CODIGO"
        ' 
        ' DNI
        ' 
        DNI.HeaderText = "DNI"
        DNI.Name = "DNI"
        ' 
        ' NOMBRE
        ' 
        NOMBRE.HeaderText = "NOMBRE"
        NOMBRE.Name = "NOMBRE"
        NOMBRE.Width = 300
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Firebrick
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.White
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.ImageAlign = ContentAlignment.TopCenter
        btnSalir.Location = New Point(453, 584)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(103, 93)
        btnSalir.TabIndex = 18
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.BottomCenter
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = Color.ForestGreen
        btnAlta.FlatAppearance.BorderColor = Color.ForestGreen
        btnAlta.FlatStyle = FlatStyle.Flat
        btnAlta.ForeColor = Color.White
        btnAlta.Image = CType(resources.GetObject("btnAlta.Image"), Image)
        btnAlta.ImageAlign = ContentAlignment.TopCenter
        btnAlta.Location = New Point(344, 584)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(103, 93)
        btnAlta.TabIndex = 19
        btnAlta.Text = "Seleccionar"
        btnAlta.TextAlign = ContentAlignment.BottomCenter
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.FlatAppearance.BorderColor = Color.ForestGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(235, 584)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 93)
        Button1.TabIndex = 20
        Button1.Text = "Pacientes ABM"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PacienteBuscar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(578, 689)
        Controls.Add(Button1)
        Controls.Add(btnAlta)
        Controls.Add(btnSalir)
        Controls.Add(DataGridView1)
        Controls.Add(txtFiltro)
        Controls.Add(Label1)
        Name = "PacienteBuscar"
        Text = "PacienteBuscar"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents Button1 As Button
End Class
