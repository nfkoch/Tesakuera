<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    '   Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        ObrasSocialesToolStripMenuItem = New ToolStripMenuItem()
        AdministracionToolStripMenuItem = New ToolStripMenuItem()
        PacientesToolStripMenuItem = New ToolStripMenuItem()
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        HIstoriaClinicaToolStripMenuItem = New ToolStripMenuItem()
        AdministracionToolStripMenuItem1 = New ToolStripMenuItem()
        DoctoresToolStripMenuItem = New ToolStripMenuItem()
        AdministracionToolStripMenuItem2 = New ToolStripMenuItem()
        AgendaToolStripMenuItem = New ToolStripMenuItem()
        TurneroToolStripMenuItem = New ToolStripMenuItem()
        AdministracionToolStripMenuItem3 = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        dgvCalendario = New DataGridView()
        dtFecha = New DateTimePicker()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvCalendario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ObrasSocialesToolStripMenuItem, PacientesToolStripMenuItem, DoctoresToolStripMenuItem, AgendaToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 697)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1198, 72)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ObrasSocialesToolStripMenuItem
        ' 
        ObrasSocialesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdministracionToolStripMenuItem})
        ObrasSocialesToolStripMenuItem.ForeColor = Color.White
        ObrasSocialesToolStripMenuItem.Image = CType(resources.GetObject("ObrasSocialesToolStripMenuItem.Image"), Image)
        ObrasSocialesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        ObrasSocialesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ObrasSocialesToolStripMenuItem.Name = "ObrasSocialesToolStripMenuItem"
        ObrasSocialesToolStripMenuItem.Size = New Size(162, 68)
        ObrasSocialesToolStripMenuItem.Text = "Obras Sociales"
        ' 
        ' AdministracionToolStripMenuItem
        ' 
        AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        AdministracionToolStripMenuItem.Size = New Size(157, 22)
        AdministracionToolStripMenuItem.Text = "Administracion"
        ' 
        ' PacientesToolStripMenuItem
        ' 
        PacientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConsultasToolStripMenuItem, HIstoriaClinicaToolStripMenuItem, AdministracionToolStripMenuItem1})
        PacientesToolStripMenuItem.ForeColor = Color.White
        PacientesToolStripMenuItem.Image = CType(resources.GetObject("PacientesToolStripMenuItem.Image"), Image)
        PacientesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        PacientesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        PacientesToolStripMenuItem.Size = New Size(136, 68)
        PacientesToolStripMenuItem.Text = "Pacientes"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(157, 22)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' HIstoriaClinicaToolStripMenuItem
        ' 
        HIstoriaClinicaToolStripMenuItem.Name = "HIstoriaClinicaToolStripMenuItem"
        HIstoriaClinicaToolStripMenuItem.Size = New Size(157, 22)
        HIstoriaClinicaToolStripMenuItem.Text = "HIstoria clinica"
        ' 
        ' AdministracionToolStripMenuItem1
        ' 
        AdministracionToolStripMenuItem1.Name = "AdministracionToolStripMenuItem1"
        AdministracionToolStripMenuItem1.Size = New Size(157, 22)
        AdministracionToolStripMenuItem1.Text = "Administracion"
        ' 
        ' DoctoresToolStripMenuItem
        ' 
        DoctoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdministracionToolStripMenuItem2})
        DoctoresToolStripMenuItem.ForeColor = Color.White
        DoctoresToolStripMenuItem.Image = CType(resources.GetObject("DoctoresToolStripMenuItem.Image"), Image)
        DoctoresToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        DoctoresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DoctoresToolStripMenuItem.Name = "DoctoresToolStripMenuItem"
        DoctoresToolStripMenuItem.Size = New Size(134, 68)
        DoctoresToolStripMenuItem.Text = "Doctores"
        ' 
        ' AdministracionToolStripMenuItem2
        ' 
        AdministracionToolStripMenuItem2.Name = "AdministracionToolStripMenuItem2"
        AdministracionToolStripMenuItem2.Size = New Size(157, 22)
        AdministracionToolStripMenuItem2.Text = "Administracion"
        ' 
        ' AgendaToolStripMenuItem
        ' 
        AgendaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TurneroToolStripMenuItem, AdministracionToolStripMenuItem3})
        AgendaToolStripMenuItem.ForeColor = Color.White
        AgendaToolStripMenuItem.Image = CType(resources.GetObject("AgendaToolStripMenuItem.Image"), Image)
        AgendaToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        AgendaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        AgendaToolStripMenuItem.Size = New Size(125, 68)
        AgendaToolStripMenuItem.Text = "Agenda"
        ' 
        ' TurneroToolStripMenuItem
        ' 
        TurneroToolStripMenuItem.Name = "TurneroToolStripMenuItem"
        TurneroToolStripMenuItem.Size = New Size(157, 22)
        TurneroToolStripMenuItem.Text = "Turnero"
        ' 
        ' AdministracionToolStripMenuItem3
        ' 
        AdministracionToolStripMenuItem3.Name = "AdministracionToolStripMenuItem3"
        AdministracionToolStripMenuItem3.Size = New Size(157, 22)
        AdministracionToolStripMenuItem3.Text = "Administracion"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.ForeColor = Color.White
        SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), Image)
        SalirToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        SalirToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(107, 68)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvCalendario)
        GroupBox1.Controls.Add(dtFecha)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(8, 71)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(871, 611)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mis Turnos:"
        ' 
        ' dgvCalendario
        ' 
        dgvCalendario.AllowUserToAddRows = False
        dgvCalendario.AllowUserToDeleteRows = False
        dgvCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCalendario.DefaultCellStyle = DataGridViewCellStyle1
        dgvCalendario.Location = New Point(18, 46)
        dgvCalendario.Name = "dgvCalendario"
        dgvCalendario.Size = New Size(847, 559)
        dgvCalendario.TabIndex = 2
        ' 
        ' dtFecha
        ' 
        dtFecha.Format = DateTimePickerFormat.Short
        dtFecha.Location = New Point(65, 17)
        dtFecha.Name = "dtFecha"
        dtFecha.Size = New Size(106, 23)
        dtFecha.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Fecha:"
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1198, 769)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MenuPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bienvenido"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvCalendario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ObrasSocialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HIstoriaClinicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TurneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCalendario As DataGridView
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label1 As Label

End Class
