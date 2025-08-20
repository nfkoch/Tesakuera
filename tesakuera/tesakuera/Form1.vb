Imports System.Data.SqlClient
Imports MaterialSkin

Public Class MenuPrincipal

#Region "VARIABLES"
    'variable para obtener desde la clase conexion la cadena de conexion a la base de datos
    Dim Connstr As New Conexion
    'variable para almacenar las consultas sql que voy a utilizar en el formulario
    Dim sql As String
#End Region

#Region "CONSTRUCTOR"
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'codigo para darle un poco de color
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        CrearCalendarioSemanal()
        CargarTurnosCalendario()
    End Sub
#End Region

#Region "Calendario"
    'SUB RUTINA QUE GENERA EL CALENDARIO EN EL DATAGRID VIEW
    'CODIGO GENERADO POR MICROSOFT COPILOT
    Private Sub CrearCalendarioSemanal()
        dgvCalendario.Columns.Clear()
        dgvCalendario.Rows.Clear()

        ' Crear columnas para los próximos 7 días
        For i As Integer = 0 To 6
            Dim fecha As Date = Date.Today.AddDays(i)
            dgvCalendario.Columns.Add("col" & i, fecha.ToString("ddd dd/MM"))
        Next

        ' Crear filas para horarios de 08:00 a 18:00 cada 30 minutos
        For h As Integer = 8 To 18
            For m As Integer = 0 To 30 Step 30
                Dim hora As String = New DateTime(1, 1, 1, h, m, 0).ToString("HH:mm")
                dgvCalendario.Rows.Add()
                dgvCalendario.Rows(dgvCalendario.Rows.Count - 1).HeaderCell.Value = hora
            Next
        Next

        dgvCalendario.RowHeadersWidth = 70
        dgvCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarTurnosCalendario()
        'CARGO LA CADENA DE CONEXION
        Dim connectionString As String = Connstr.cargarConexion
        'REFINE UN POCO LA CONSULTA PARA QUE ME TRAIGA EL NOMBRE DEL PACIENTE Y NO EL CODIGO
        'vamos a agregar a consulta los datos del doctor

        Dim query As String = "SELECT Fecha, Hora, Paciente.nombre,Doctor.nombre
FROM Agenda 
inner join paciente on paciente.codigo=agenda.pacienteCodigo 
inner join doctor on doctor.codigo=agenda.doctorCodigo
WHERE Fecha >= CONVERT(date, GETDATE()) AND Fecha <= CONVERT(date, GETDATE() + 6)"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            '    cmd.Parameters.AddWithValue("@DoctorCodigo", doctorCodigo)
            conn.Open()

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim fecha As Date = reader.GetDateTime(0)
                    Dim hora As TimeSpan = reader.GetTimeSpan(1)
                    Dim paciente As String = reader.GetString(2) & " Dr." & reader.GetString(3)

                    ' Buscar columna por fecha
                    Dim colIndex As Integer = fecha.Subtract(Date.Today).Days
                    If colIndex >= 0 AndAlso colIndex < dgvCalendario.Columns.Count Then
                        ' Buscar fila por hora
                        For i As Integer = 0 To dgvCalendario.Rows.Count - 1
                            If dgvCalendario.Rows(i).HeaderCell.Value.ToString() = hora.ToString("hh\:mm") Then
                                dgvCalendario.Rows(i).Cells(colIndex).Value = paciente
                                dgvCalendario.Rows(i).Cells(colIndex).Style.BackColor = Color.LightSalmon
                                Exit For
                            End If
                        Next
                    End If
                End While
            End Using
        End Using
    End Sub
#End Region

#Region "BOTONES"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click
        Dim unaObra As New ObraSocialAbm
        unaObra.Show()
    End Sub

    Private Sub AdministracionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem1.Click
        Dim unPaciente As New PacienteABM
        unPaciente.Show()
    End Sub

    Private Sub AdministracionToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem2.Click
        Dim unDoctor As New DoctorABM
        unDoctor.Show()
    End Sub

    Private Sub AdministracionToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem3.Click
        Dim unaAgenda As New AgendaABM
        unaAgenda.Show()
    End Sub
#End Region
End Class
