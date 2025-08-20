<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendaABM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgendaABM))
        GroupBox1 = New GroupBox()
        btnGrabar = New Button()
        btnAlta = New Button()
        GroupBox3 = New GroupBox()
        btnDoctorBuscar = New Button()
        txtDoctorNombre = New TextBox()
        Label6 = New Label()
        txtDoctorCodigo = New TextBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        btnPacienteBuscar = New Button()
        txtPacienteNombre = New TextBox()
        Label5 = New Label()
        txtPacienteCodigo = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        dtFecha = New DateTimePicker()
        Label2 = New Label()
        txtCodigo = New TextBox()
        Label1 = New Label()
        dgvCalendario = New DataGridView()
        btnSalir = New Button()
        cmbHoras = New ComboBox()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvCalendario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbHoras)
        GroupBox1.Controls.Add(btnGrabar)
        GroupBox1.Controls.Add(btnAlta)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(dtFecha)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtCodigo)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 72)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(530, 530)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Basicos:"
        ' 
        ' btnGrabar
        ' 
        btnGrabar.BackColor = Color.DarkSlateGray
        btnGrabar.FlatStyle = FlatStyle.Flat
        btnGrabar.ForeColor = Color.White
        btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), Image)
        btnGrabar.ImageAlign = ContentAlignment.TopCenter
        btnGrabar.Location = New Point(219, 419)
        btnGrabar.Name = "btnGrabar"
        btnGrabar.Size = New Size(103, 93)
        btnGrabar.TabIndex = 24
        btnGrabar.Text = "Grabar"
        btnGrabar.TextAlign = ContentAlignment.BottomCenter
        btnGrabar.UseVisualStyleBackColor = False
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = Color.ForestGreen
        btnAlta.FlatAppearance.BorderColor = Color.ForestGreen
        btnAlta.FlatStyle = FlatStyle.Flat
        btnAlta.ForeColor = Color.White
        btnAlta.Image = CType(resources.GetObject("btnAlta.Image"), Image)
        btnAlta.ImageAlign = ContentAlignment.TopCenter
        btnAlta.Location = New Point(110, 419)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(103, 93)
        btnAlta.TabIndex = 21
        btnAlta.Text = "Alta"
        btnAlta.TextAlign = ContentAlignment.BottomCenter
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnDoctorBuscar)
        GroupBox3.Controls.Add(txtDoctorNombre)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(txtDoctorCodigo)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(9, 273)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(515, 116)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Doctor"
        ' 
        ' btnDoctorBuscar
        ' 
        btnDoctorBuscar.Image = CType(resources.GetObject("btnDoctorBuscar.Image"), Image)
        btnDoctorBuscar.ImageAlign = ContentAlignment.TopCenter
        btnDoctorBuscar.Location = New Point(368, 22)
        btnDoctorBuscar.Name = "btnDoctorBuscar"
        btnDoctorBuscar.Size = New Size(73, 81)
        btnDoctorBuscar.TabIndex = 4
        btnDoctorBuscar.Text = "Buscar"
        btnDoctorBuscar.TextAlign = ContentAlignment.BottomCenter
        btnDoctorBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtDoctorNombre
        ' 
        txtDoctorNombre.Enabled = False
        txtDoctorNombre.Location = New Point(77, 68)
        txtDoctorNombre.Name = "txtDoctorNombre"
        txtDoctorNombre.Size = New Size(268, 23)
        txtDoctorNombre.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 2
        Label6.Text = "Nombre:"
        ' 
        ' txtDoctorCodigo
        ' 
        txtDoctorCodigo.Enabled = False
        txtDoctorCodigo.Location = New Point(73, 28)
        txtDoctorCodigo.Name = "txtDoctorCodigo"
        txtDoctorCodigo.Size = New Size(63, 23)
        txtDoctorCodigo.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 31)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 0
        Label7.Text = "Codigo:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnPacienteBuscar)
        GroupBox2.Controls.Add(txtPacienteNombre)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtPacienteCodigo)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(9, 151)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(515, 116)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Paciente"
        ' 
        ' btnPacienteBuscar
        ' 
        btnPacienteBuscar.Image = CType(resources.GetObject("btnPacienteBuscar.Image"), Image)
        btnPacienteBuscar.ImageAlign = ContentAlignment.TopCenter
        btnPacienteBuscar.Location = New Point(368, 22)
        btnPacienteBuscar.Name = "btnPacienteBuscar"
        btnPacienteBuscar.Size = New Size(73, 81)
        btnPacienteBuscar.TabIndex = 4
        btnPacienteBuscar.Text = "Buscar"
        btnPacienteBuscar.TextAlign = ContentAlignment.BottomCenter
        btnPacienteBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtPacienteNombre
        ' 
        txtPacienteNombre.Enabled = False
        txtPacienteNombre.Location = New Point(77, 68)
        txtPacienteNombre.Name = "txtPacienteNombre"
        txtPacienteNombre.Size = New Size(268, 23)
        txtPacienteNombre.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 2
        Label5.Text = "Nombre:"
        ' 
        ' txtPacienteCodigo
        ' 
        txtPacienteCodigo.Enabled = False
        txtPacienteCodigo.Location = New Point(73, 28)
        txtPacienteCodigo.Name = "txtPacienteCodigo"
        txtPacienteCodigo.Size = New Size(63, 23)
        txtPacienteCodigo.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 0
        Label4.Text = "Codigo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 4
        Label3.Text = "Hora:"
        ' 
        ' dtFecha
        ' 
        dtFecha.Format = DateTimePickerFormat.Short
        dtFecha.Location = New Point(56, 69)
        dtFecha.Name = "dtFecha"
        dtFecha.Size = New Size(120, 23)
        dtFecha.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fecha:"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Enabled = False
        txtCodigo.Location = New Point(64, 32)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(100, 23)
        txtCodigo.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Codigo:"
        ' 
        ' dgvCalendario
        ' 
        dgvCalendario.AllowUserToAddRows = False
        dgvCalendario.AllowUserToDeleteRows = False
        dgvCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCalendario.Location = New Point(556, 89)
        dgvCalendario.Name = "dgvCalendario"
        dgvCalendario.Size = New Size(1015, 574)
        dgvCalendario.TabIndex = 1
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Firebrick
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.White
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.ImageAlign = ContentAlignment.TopCenter
        btnSalir.Location = New Point(1468, 681)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(103, 93)
        btnSalir.TabIndex = 5
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.BottomCenter
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' cmbHoras
        ' 
        cmbHoras.FormattingEnabled = True
        cmbHoras.Location = New Point(51, 111)
        cmbHoras.Name = "cmbHoras"
        cmbHoras.Size = New Size(121, 23)
        cmbHoras.TabIndex = 25
        ' 
        ' AgendaABM
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1583, 786)
        ControlBox = False
        Controls.Add(btnSalir)
        Controls.Add(dgvCalendario)
        Controls.Add(GroupBox1)
        Name = "AgendaABM"
        Sizable = False
        Text = "Agenda Administacion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvCalendario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDoctorBuscar As Button
    Friend WithEvents txtDoctorNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDoctorCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPacienteBuscar As Button
    Friend WithEvents txtPacienteNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPacienteCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents dgvCalendario As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbHoras As ComboBox
End Class
