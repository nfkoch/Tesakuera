Imports System.Data.SqlClient

Public Class ObraSocialAbm
#Region "Variables"
    'variable para llamar a la clase donde tengo la cadena de conexion a la base de datos en sql server express
    Dim Connstr As New Conexion
    'variable que me permite establecer un modo= Alta, Baja o Modificar
    Dim Modo As String
    'variable para almacenar las consultas sql que voy a usar en el winform
    Dim SQL As String
#End Region

#Region "Constructor"
    'EN ESTA SUB RUTINA SE LLAMA TODO LO QUE QUEREMOS QUE SE EJECUTE AL INCIAR EL WINFORM
    Private Sub ObraSocialAbm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LLAMO A LA SUB cargarVistaPrevia para cargar el datagridview incial
        cargarVistaPrevia()
        'ACA INDICO QUE EL BOTON DE GRABAR QUEDE ANULADO HASTA SELECCIONAR UNA ACCION
        btnGrabar.Enabled = False
    End Sub
#End Region

#Region "Cargas Iniciales"
    Private Sub cargarVistaPrevia()
        'Limpio el datagridview al llamar esta sub rutina, esto sirve para recargar cada vez que hago alguna accion sobre los datos
        DataGridView1.Rows.Clear()
        'almaceno la consulta sql que se va a ejecutar en sql server express
        SQL = "SELECT  [codigo]
      ,[Descripcion]
      ,[Telefono]
  FROM [Oculus].[dbo].[ObraSocial]"
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
                    Dim fila(4) As Object
                    'cargo uno a uno los nodos del vector con los nodos del recordset
                    fila(0) = reader(0)
                    fila(1) = reader(1)
                    fila(2) = reader(2)
                    'le indico al datagridview que debe agregar una fila con el vector anteriormente cargado
                    DataGridView1.Rows.Add(fila)

                Loop

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

    Private Function AltaRegistro() As Boolean
        Dim Bandera As Boolean
        'cerramos todo en un try y catch "esto se utiliza para control de errores
        Try
            Using conn1 As New SqlConnection(Connstr.cargarConexion)
                Using cmd As SqlCommand = conn1.CreateCommand()
                    conn1.Open()
                    'en este comando no agrego el parametro de codigo dado que es un valor autogenerado por la base de datos
                    cmd.CommandText = "insert into [ObraSocial](" +
                                    "[Descripcion]" +
                                    ",[Telefono]" +
                                    ") VALUES (" +
                                    "@Descripcion" +
                                     ",@Telefono" +
                                      ")"
                    'declaro un parametro donde almaceno la descripcion y que lo tomo del textbox txtDescripcion
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50).Value = txtDescripcion.Text
                    'declaro un parametro donde almaceno el telefono y que lo tomo del textbox txtTelefono
                    cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 100).Value = txtTelefono.Text
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
                    cmd.CommandText = "delete  FROM [ObraSocial] where [codigo]=@Codigo "
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
                    'declaro un parametro donde almaceno la descripcion y que lo tomo del textbox txtDescripcion
                    cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50).Value = txtDescripcion.Text
                    'declaro un parametro donde almaceno el telefono y que lo tomo del textbox txtTelefono
                    cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 100).Value = txtTelefono.Text

                    cmd.CommandText = "update ObraSocial set" +
                                    "[Descripcion]" + "=@Descripcion " +
                                    ",[Telefono]" + "=@Telefono " +
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
        txtTelefono.Text = DataGridView1.Rows(I).Cells(2).Value
    End Sub

#End Region

End Class