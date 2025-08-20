Imports System.Data.SqlClient

Public Class PacienteABM
    'variable para llamar a la clase donde tengo la cadena de conexion a la base de datos en sql server express
    Dim Connstr As New Conexion
    'variable que me permite establecer un modo= Alta, Baja o Modificar
    Dim Modo As String
    'variable para almacenar las consultas sql que voy a usar en el winform
    Dim SQL As String
    Dim miBusqueda As New BusquedasGlobales
    Private Sub PacienteABM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGrabar.Enabled = False
        cargarVistaPrevia()
        CargarObrasocial()
        CargarProvincia()
    End Sub
#Region "Cargas Iniciales"
    Private Sub cargarVistaPrevia()
        'Limpio el datagridview al llamar esta sub rutina, esto sirve para recargar cada vez que hago alguna accion sobre los datos
        DataGridView1.Rows.Clear()
        'almaceno la consulta sql que se va a ejecutar en sql server express
        SQL = "SELECT Pte.[Codigo]
,Pte.[Nombre]      
,Pte.[CUIL]
      ,Pte.[Direccion]
      ,Pte.[Telefono]
      ,Pte.[Email]      
      ,prv.provincia
      ,loc.localidad
      ,Pte.[Sexo]
      ,ob.Descripcion
        ,Pte.[FechaNacimiento]
  FROM [Oculus].[dbo].[Paciente] PTE
  inner join [Oculus].[dbo].provincia prv on prv.codigo=pte.codigoprovincia
  inner join [Oculus].[dbo].localidades loc on loc.Codigo=pte.CodigoLocalidad
  inner join [Oculus].[dbo].ObraSocial OB on Ob.codigo=pte.CodigoObraSocial"
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
                'mientras tenga registros el recordset voy recorriendo la coleccion de datos
                Do While reader.Read()
                    'creo un vector para poder almacenar los resultados, lo hago tipo object para que soporte todos los tipos de datos
                    Dim fila(11) As Object
                    'cargo uno a uno los nodos del vector con los nodos del recordset
                    fila(0) = reader(0)
                    fila(1) = reader(1)
                    fila(2) = reader(2)
                    fila(3) = reader(3)
                    fila(4) = reader(4)
                    fila(5) = reader(5)
                    fila(6) = reader(6)
                    fila(7) = reader(7)
                    fila(8) = reader(8)
                    fila(9) = reader(9)
                    fila(10) = reader(10)
                    'le indico al datagridview que debe agregar una fila con el vector anteriormente cargado
                    DataGridView1.Rows.Add(fila)

                Loop

            End Using
        End Using
    End Sub

    Private Sub CargarObrasocial()
        SQL = "SELECT [Descripcion]
            FROM [Obrasocial] order by Descripcion ASC"
        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()
                conn.Open()
                cmd4.CommandText = SQL
                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader
                While reader.Read()
                    cmbObraSocial.Items.Add(reader(0))
                End While

            End Using
        End Using
    End Sub

    Private Sub CargarProvincia()
        SQL = "SELECT [Provincia]
            FROM [Provincia] order by Provincia ASC"
        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()
                conn.Open()
                cmd4.CommandText = SQL
                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader
                While reader.Read()
                    cmbProvincia.Items.Add(reader(0))
                End While

            End Using
        End Using
    End Sub

#End Region

#Region "BOTONES"
    'Boton de alta: establezco el modo Alta de registros y ademas activo la accion de grabar, por otro lado desactivo los demas botones hasta terminar la accion

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        'desactivo botones con otras acciones
        btnAlta.Enabled = False
        btnBaja.Enabled = False
        btnEditar.Enabled = False
        'activo boton grabar
        btnGrabar.Enabled = True
        'activo el modo alta
        Modo = "Alta"
    End Sub
    'boton de Baja: establezco el modo baja de registros y ademas activo la accion de grabar, por otro lado desactivo los demas botones hasta terminar la accion
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        'desactivo botones con otras acciones
        btnAlta.Enabled = False
        btnBaja.Enabled = False
        btnEditar.Enabled = False
        'activo boton grabar
        btnGrabar.Enabled = True
        'activo el modo baja
        Modo = "Baja"
    End Sub
    'boton de Editar: establezco el modo Editar de registros y ademas activo la accion de grabar, por otro lado desactivo los demas botones hasta terminar la accion
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'desactivo botones con otras acciones
        btnAlta.Enabled = False
        btnBaja.Enabled = False
        btnEditar.Enabled = False
        'activo boton grabar
        btnGrabar.Enabled = True
        'activo el modo editar
        Modo = "Editar"
    End Sub
    'Boton de salida del programa
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Con esta sentencia establezco la salida del winform
        Me.Close()
    End Sub
    'Boton de Grabar: aqui depende el modo vamos a llamar a diferentes funciones
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Modo = "Baja" Then
            If BajaRegistro() Then
                MessageBox.Show("Registro eliminado correctamente")
                'recargo para los cambios
                cargarVistaPrevia()
                'reinicio todos los valores de los componentes del winform
                LimpiarTodo()
            Else

            End If
        Else
            If Modo = "Alta" Then
                If AltaRegistro() Then
                    MessageBox.Show("Registro Cargado correctamente")
                    'recargo para los cambios
                    cargarVistaPrevia()
                    'reinicio todos los valores de los componentes del winform
                    LimpiarTodo()
                Else

                End If
            Else
                If Modo = "Editar" Then
                    If EditarRegistro() Then
                        MessageBox.Show("Registro Editado correctamente")
                        'recargo para los cambios
                        cargarVistaPrevia()
                        'reinicio todos los valores de los componentes del winform
                        LimpiarTodo()
                    Else

                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "ABM"
    Private Function AltaRegistro() As Boolean
        Dim Bandera As Boolean
        'cerramos todo en un try y catch "esto se utiliza para control de errores
        Try
            Using conn1 As New SqlConnection(Connstr.cargarConexion)
                Using cmd As SqlCommand = conn1.CreateCommand()
                    conn1.Open()
                    'en este comando no agrego el parametro de codigo dado que es un valor autogenerado por la base de datos
                    cmd.CommandText = "insert into [Paciente](" +
                                    "[CUIL]
      ,[Nombre]
      ,[FechaNacimiento]
      ,[Direccion]
      ,[Telefono]
      ,[Email]
      ,[CodigoLocalidad]
      ,[CodigoProvincia]
      ,[CodigoObraSocial]
      ,[Sexo]" +
                                    ") VALUES (" +
                                    "@CUIL
      ,@Nombre
      ,@FechaNacimiento
      ,@Direccion
      ,@Telefono
      ,@Email
      ,@CodigoLocalidad
      ,@CodigoProvincia
      ,@CodigoObraSocial
      ,@Sexo" +
                                      ")"
                    'declaro un parametro donde almaceno la descripcion y que lo tomo del textbox txtDescripcion
                    cmd.Parameters.Add("@Cuil", SqlDbType.NVarChar, 11).Value = txtCuil.Text
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = txtDescripcion.Text
                    cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = dtFechaNacimiento.Value
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 50).Value = txtDireccion.Text
                    'declaro un parametro donde almaceno el telefono y que lo tomo del textbox txtTelefono
                    cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 100).Value = txtTelefono.Text
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = txtEmail.Text
                    cmd.Parameters.Add("@CodigoLocalidad", SqlDbType.Int).Value = miBusqueda.DameLocalidadCodigo(cmbLocalidad.Text)
                    cmd.Parameters.Add("@CodigoProvincia", SqlDbType.Int).Value = miBusqueda.DameProvinciaCodigo(cmbProvincia.Text)
                    cmd.Parameters.Add("@CodigoObraSocial", SqlDbType.Int).Value = miBusqueda.DameObraSocialCodigo(cmbObraSocial.Text)
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar, 1).Value = cmbSexo.Text
                    cmd.ExecuteScalar()
                    conn1.Close()
                End Using
            End Using
            Return True
        Catch ex As Exception
            ' si algo falla muestro el error
            MessageBox.Show("Algo fallo!: " & vbNewLine & ex.Message)
            Return False
        End Try

    End Function

    Private Function BajaRegistro() As Boolean
        Dim Bandera As Boolean
        'cerramos todo en un try y catch "esto se utiliza para control de errores
        Try
            'Armo una conexion al servidor
            Using conn As New SqlConnection(Connstr.cargarConexion)
                'creo la variable para conectar a los comandos sql
                Using cmd As SqlCommand = conn.CreateCommand()
                    'abro la conexion
                    conn.Open()
                    'indico que comando voy a ejecutar "ES UN TIPO DE CONSULTA SQL"
                    cmd.CommandText = "delete  FROM [Paciente] where [codigo]=@Codigo "
                    'creo los parametros que recibira la consulta, con su tipo de dato y extension y de donde va a salir ese dato
                    cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = txtCodigo.Text
                    'ejecuto la consulta sin devolucion de resultados
                    cmd.ExecuteScalar()
                    'cierro la conexion
                    conn.Close()

                End Using
            End Using

            Return True
        Catch ex As Exception
            ' si algo falla muestro el error
            MessageBox.Show("Algo fallo!: " & vbNewLine & ex.Message)
            Return False
        End Try


    End Function

    Private Function EditarRegistro() As Boolean
        Dim Bandera As Boolean
        Try
            Using conn1 As New SqlConnection(Connstr.cargarConexion)
                Using cmd As SqlCommand = conn1.CreateCommand()
                    conn1.Open()

                    cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = txtCodigo.Text
                    cmd.Parameters.Add("@Cuil", SqlDbType.NVarChar, 11).Value = txtCuil.Text
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = txtDescripcion.Text
                    cmd.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = dtFechaNacimiento.Value
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 50).Value = txtDireccion.Text
                    'declaro un parametro donde almaceno el telefono y que lo tomo del textbox txtTelefono
                    cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 100).Value = txtTelefono.Text
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = txtEmail.Text
                    cmd.Parameters.Add("@CodigoLocalidad", SqlDbType.Int).Value = miBusqueda.DameLocalidadCodigo(cmbLocalidad.Text)
                    cmd.Parameters.Add("@CodigoProvincia", SqlDbType.Int).Value = miBusqueda.DameProvinciaCodigo(cmbProvincia.Text)
                    cmd.Parameters.Add("@CodigoObraSocial", SqlDbType.Int).Value = miBusqueda.DameObraSocialCodigo(cmbObraSocial.Text)
                    cmd.Parameters.Add("@Sexo", SqlDbType.VarChar, 1).Value = cmbSexo.Text

                    cmd.CommandText = "update Paciente set " +
                                    "CUIL=@CUIL
      ,Nombre=@Nombre
      ,FechaNacimiento=@FechaNacimiento
      ,Direccion=@Direccion
      ,Telefono=@Telefono
      ,Email=@Email
      ,CodigoLocalidad=@CodigoLocalidad
      ,CodigoProvincia=@CodigoProvincia
      ,CodigoObraSocial=@CodigoObraSocial
      ,Sexo=@Sexo " +
                                    " where [Codigo]=@Codigo"

                    cmd.ExecuteScalar()
                    conn1.Close()
                End Using
            End Using
            Return True
        Catch ex As Exception
            ' si algo falla muestro el error
            MessageBox.Show("Algo fallo!: " & vbNewLine & ex.Message)
            Return False
        End Try

    End Function
    'Con esta funcion vamos a resetear todos los elementos del winform 
    Private Function LimpiarTodo()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtTelefono.Text = ""
        txtCuil.Text = ""
        txtDireccion.Text = ""
        txtEmail.Text = ""
        cmbLocalidad.Text = ""
        cmbObraSocial.Text = ""
        cmbProvincia.Text = ""
        cmbSexo.Text = ""
        'activo botones con otras acciones
        btnAlta.Enabled = True
        btnBaja.Enabled = True
        btnEditar.Enabled = True
        'desactivo boton grabar
        btnGrabar.Enabled = False
        'desactivo cualquier modo activo
        Modo = ""
        'recargo datagridview
        cargarVistaPrevia()
    End Function
#End Region

#Region "Movimientos del DataGridView"
    'vamos a usar esta sub rutina, donde el usuario puede dar doble click en cualquier columna del grid y esto hara que se traspasen los datos del grid view
    'a sus objetos correspondientes
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'Creo un indice que voy a usar para identificar la fila seleccionada
        Dim I As Integer = DataGridView1.CurrentCell.RowIndex
        'Con esto indico que se almacene lo que esta en la primera columna de la fila seleccionada en el txtCodigo
        txtCodigo.Text = DataGridView1.Rows(I).Cells(0).Value
        txtDescripcion.Text = DataGridView1.Rows(I).Cells(1).Value
        txtCuil.Text = DataGridView1.Rows(I).Cells(2).Value
        txtDireccion.Text = DataGridView1.Rows(I).Cells(3).Value
        txtTelefono.Text = DataGridView1.Rows(I).Cells(4).Value
        txtEmail.Text = DataGridView1.Rows(I).Cells(5).Value
        cmbProvincia.Text = DataGridView1.Rows(I).Cells(6).Value
        cmbLocalidad.Text = DataGridView1.Rows(I).Cells(7).Value
        cmbSexo.Text = DataGridView1.Rows(I).Cells(8).Value
        cmbObraSocial.Text = DataGridView1.Rows(I).Cells(9).Value
    End Sub

#End Region

#Region "COMBOS"
    Private Sub cmbProvincia_TextChanged(sender As Object, e As EventArgs) Handles cmbProvincia.TextChanged
        SQL = "SELECT [Localidad]
            FROM [Localidades] where CodigoProvincia='" & miBusqueda.DameProvinciaCodigo(cmbProvincia.Text) & "' order by Localidad ASC"
        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()
                conn.Open()
                cmd4.CommandText = SQL
                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader
                While reader.Read()
                    cmbLocalidad.Items.Add(reader(0))
                End While

            End Using
        End Using
    End Sub

#End Region

#Region "TEXT BOX"

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        'Limpio el datagridview al llamar esta sub rutina, esto sirve para recargar cada vez que hago alguna accion sobre los datos
        DataGridView1.Rows.Clear()
        'almaceno la consulta sql que se va a ejecutar en sql server express
        SQL = "SELECT top(100) Pte.[Codigo]
,Pte.[Nombre]      
,Pte.[CUIL]
      ,Pte.[Direccion]
      ,Pte.[Telefono]
      ,Pte.[Email]      
      ,prv.provincia
      ,loc.localidad
      ,Pte.[Sexo]
      ,ob.Descripcion
        ,Pte.[FechaNacimiento]
  FROM [Oculus].[dbo].[Paciente] PTE
  inner join [Oculus].[dbo].provincia prv on prv.codigo=pte.codigoprovincia
  inner join [Oculus].[dbo].localidades loc on loc.Codigo=pte.CodigoLocalidad
  inner join [Oculus].[dbo].ObraSocial OB on Ob.codigo=pte.CodigoObraSocial where Nombre like '%" & txtFiltro.Text & "%'"
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
                'mientras tenga registros el recordset voy recorriendo la coleccion de datos
                Do While reader.Read()
                    'creo un vector para poder almacenar los resultados, lo hago tipo object para que soporte todos los tipos de datos
                    Dim fila(11) As Object
                    'cargo uno a uno los nodos del vector con los nodos del recordset
                    fila(0) = reader(0)
                    fila(1) = reader(1)
                    fila(2) = reader(2)
                    fila(3) = reader(3)
                    fila(4) = reader(4)
                    fila(5) = reader(5)
                    fila(6) = reader(6)
                    fila(7) = reader(7)
                    fila(8) = reader(8)
                    fila(9) = reader(9)
                    fila(10) = reader(10)
                    'le indico al datagridview que debe agregar una fila con el vector anteriormente cargado
                    DataGridView1.Rows.Add(fila)

                Loop

            End Using
        End Using
    End Sub
#End Region
End Class