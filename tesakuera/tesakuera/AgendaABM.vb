Imports System.Data.SqlClient

Public Class AgendaABM
#Region "IMPLEMENTS"
    'INTERFAZ QUE UTILIZO PARA LLAMAR LOS DATOS DE LA VENTANA DE BUSQUEDA
    'PACIENTES
    Implements IFormPaciente
    'DOCTORES
    Implements IFormDoctor
#End Region
    'variable para llamar a la clase donde tengo la cadena de conexion a la base de datos en sql server express
    Dim Connstr As New Conexion
    'variable que me permite establecer un modo= Alta, Baja o Modificar
    Dim Modo As String
    'variable para almacenar las consultas sql que voy a usar en el winform
    Dim SQL As String
    Dim miBusqueda As New BusquedasGlobales
#Region "CONSTRUCTOR"
    Private Sub AgendaABM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  CrearCalendario()
        CrearCalendarioSemanal()
        CargarHoras()
    End Sub
#End Region
#Region "BOTONES"
    'BOTON DE BUSQUEDA DE PACIENTES
    Private Sub btnPacienteBuscar_Click(sender As Object, e As EventArgs) Handles btnPacienteBuscar.Click
        Dim _form3 As New PacienteBuscar
        _form3.MdiParent = Me.MdiParent
        _form3.Opener = CType(Me, IFormPaciente)
        _form3.Show()
    End Sub

    'BOTON DE BUSQUEDA
    Private Sub btnDoctorBuscar_Click(sender As Object, e As EventArgs) Handles btnDoctorBuscar.Click
        Dim _form3 As New DoctorBuscar
        _form3.MdiParent = Me.MdiParent
        _form3.Opener = CType(Me, IFormDoctor)
        _form3.Show()
    End Sub
    'BOTON DE SALIDA
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    'Boton de alta: establezco el modo Alta de registros y ademas activo la accion de grabar, por otro lado desactivo los demas botones hasta terminar la accion

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        'desactivo botones con otras acciones
        btnAlta.Enabled = False
        'activo boton grabar
        btnGrabar.Enabled = True
        'activo el modo alta
        Modo = "Alta"
    End Sub

    'Boton de Grabar: aqui depende el modo vamos a llamar a diferentes funciones
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If Modo = "Alta" Then
                If AltaRegistro() Then
                    MessageBox.Show("Registro Cargado correctamente")
                'recargo para los cambios
                CrearCalendarioSemanal()
                CargarTurnosCalendario(txtDoctorCodigo.Text)
                'reinicio todos los valores de los componentes del winform
                LimpiarTodo()
                Else

                End If

        End If
    End Sub

#End Region

#Region "ABM"
    Private Function AltaRegistro() As Boolean
        Try
            If ControlExistencia() Then
                Using conn1 As New SqlConnection(Connstr.cargarConexion)
                    Using cmd As SqlCommand = conn1.CreateCommand()
                        conn1.Open()
                        'en este comando no agrego el parametro de codigo dado que es un valor autogenerado por la base de datos
                        cmd.CommandText = "insert into [Agenda](" +
                                        "[Fecha]
                                    ,[Hora]
                                    ,[PacienteCodigo]
                                    ,[DoctorCodigo]
                                    ,[estado]" +
                                        ") VALUES (" +
                                       "@Fecha
                                      ,@Hora
                                      ,@PacienteCodigo
                                      ,@DoctorCodigo
                                      ,@estado" +
                                          ")"
                        'declaro un parametro donde almaceno la descripcion y que lo tomo del textbox txtDescripcion
                        cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = dtFecha.Value
                        cmd.Parameters.Add("@Hora", SqlDbType.Time).Value = cmbHoras.Text
                        cmd.Parameters.Add("@PacienteCodigo", SqlDbType.Int).Value = txtPacienteCodigo.Text
                        'declaro un parametro donde almaceno el telefono y que lo tomo del textbox txtTelefono
                        cmd.Parameters.Add("@DoctorCodigo", SqlDbType.Int).Value = txtDoctorCodigo.Text
                        cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = 0
                        cmd.ExecuteScalar()
                        conn1.Close()
                    End Using
                End Using
                Return True

            Else
                MessageBox.Show("La agenda no se encuentra libre en el lugar que solicita")
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error!: " & ex.Message)
        End Try
    End Function

    'vamos a controlar que no carguemos dos turnos al mismo tiempo para un mismo paciente y un mismo doctor
    Private Function ControlExistencia() As Boolean
        SQL = "SELECT count(1)
  FROM [Oculus].[dbo].[Agenda]
  where  DoctorCodigo=" & txtDoctorCodigo.Text & " and convert(date,fecha,103)=convert(date,'" & dtFecha.Value & "' ,103) 
  and convert(time,hora)=convert(time,'" & cmbHoras.Text & "')"
        'Armo una conexion al servidor
        Using conn As New SqlConnection(Connstr.cargarConexion)
            'creo la variable para conectar a los comandos sql
            Using cmd4 As SqlCommand = conn.CreateCommand()
                'abro la conexion
                conn.Open()
                'indico que comando voy a ejecutar "ES UN TIPO DE CONSULTA SQL"
                cmd4.CommandText = SQL
                'creo un recordset donde voy a almacenar los resultados
                Dim reader As SqlDataReader = Nothing
                'Pido ejecutar el comando y que me devuelva los resultados para almacenar
                reader = cmd4.ExecuteReader
                'cotejo que haya algo en el recordset
                If reader.Read Then
                    'si me devuelve nulo voy a saber que no existe nada / esto es solo en caso que la base de datos me devuelva nulo, no deberia por el tipo de consulta
                    If IsDBNull(reader(0)) Then
                        Return True
                    Else
                        'en caso de ser distinto de 0, aviso en falso, dado que existe un registro con esas caracteristicas
                        If reader(0) <> 0 Then
                            Return False
                        Else
                            Return True
                        End If
                    End If
                End If

            End Using
        End Using
    End Function
#End Region

#Region "LIMPIAR TODO"
    Private Sub LimpiarTodo()
        txtCodigo.Text = ""
        txtDoctorCodigo.Text = ""
        txtDoctorNombre.Text = ""
        txtPacienteCodigo.Text = ""
        txtPacienteNombre.Text = ""
        'activo botones con otras acciones
        btnAlta.Enabled = True
        'desactivo boton grabar
        btnGrabar.Enabled = False
        'activo el modo alta
        Modo = ""
    End Sub
#End Region

#Region "IMPLEMENTS DE LAS INTERFACES"
    'FUNCION PARA IMPLEMENTAR FUNCION DE LA INTERFAZ
    Public Function LoadDataPaciente(dataTableParam As DataTable) As Boolean Implements IFormPaciente.LoadDataPaciente

        For Each row As DataRow In dataTableParam.Rows
            txtPacienteCodigo.Text = row.Item(0)
            txtPacienteNombre.Text = row.Item(1)
        Next

        Return True
    End Function
    'FUNCION PARA IMPLEMENTAR FUNCION DE LA INTERFAZ
    Public Function LoadDataDoctor(dataTableParam As DataTable) As Boolean Implements IFormDoctor.LoadDataDoctor

        For Each row As DataRow In dataTableParam.Rows
            txtDoctorCodigo.Text = row.Item(0)
            txtDoctorNombre.Text = row.Item(1)
        Next
        'CADA VEZ QUE TRAIGO UN DOCTOR NUEVO, CARGO SU AGENDA EN EL CALENDARIO
        CargarTurnosCalendario(txtDoctorCodigo.Text)
        Return True
    End Function
#End Region
#Region "ARMADO DEL CALENDARIO"
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

    Private Sub CargarTurnosCalendario(doctorCodigo As String)
        'CARGO LA CADENA DE CONEXION
        Dim connectionString As String = Connstr.cargarConexion
        'REFINE UN POCO LA CONSULTA PARA QUE ME TRAIGA EL NOMBRE DEL PACIENTE Y NO EL CODIGO
        Dim query As String = "SELECT Fecha, Hora, Paciente.nombre
FROM Agenda inner join paciente on paciente.codigo=agenda.pacienteCodigo WHERE DoctorCodigo = '" & txtDoctorCodigo.Text & "' AND Fecha >= CONVERT(date, GETDATE()) AND Fecha <= CONVERT(date, GETDATE() + 6)"
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            '    cmd.Parameters.AddWithValue("@DoctorCodigo", doctorCodigo)
            conn.Open()

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim fecha As Date = reader.GetDateTime(0)
                    Dim hora As TimeSpan = reader.GetTimeSpan(1)
                    Dim paciente As String = reader.GetString(2)

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

    Private Sub CargarHoras()
        cmbHoras.Items.Clear()

        Dim horaInicio As DateTime = DateTime.Today.AddHours(8)  ' 08:00
        Dim horaFin As DateTime = DateTime.Today.AddHours(18)    ' 18:00

        Dim horaActual As DateTime = horaInicio
        While horaActual <= horaFin
            cmbHoras.Items.Add(horaActual.ToString("HH:mm"))
            horaActual = horaActual.AddMinutes(30)
        End While

        cmbHoras.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

#End Region
End Class