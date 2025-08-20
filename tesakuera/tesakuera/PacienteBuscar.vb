Imports System.Data.SqlClient

Public Class PacienteBuscar
    Private formOpener As IFormPaciente

    Public Property Opener() As IFormPaciente
        Get
            Return formOpener
        End Get
        Set(ByVal value As IFormPaciente)
            formOpener = value
        End Set
    End Property
    'variable para llamar a la clase donde tengo la cadena de conexion a la base de datos en sql server express
    Dim Connstr As New Conexion
    'variable que me permite establecer un modo= Alta, Baja o Modificar
    Dim Modo As String
    'variable para almacenar las consultas sql que voy a usar en el winform
    Dim SQL As String
    Dim miBusqueda As New BusquedasGlobales
    Private Sub PacienteBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPaciente()
    End Sub
#Region "LOADDATATABLE"

    Private Function LoadDataTable() As DataTable
        Dim dt As New DataTable
        Dim I As Integer = DataGridView1.CurrentCell.RowIndex
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Nombre")
        Dim row1 As DataRow = dt.NewRow()
        row1(0) = DataGridView1.Rows(I).Cells(0).Value
        row1(1) = DataGridView1.Rows(I).Cells(2).Value
        dt.Rows.Add(row1)
        Return dt
    End Function

#End Region
#Region "CARGAS"

    Private Function CargarPaciente()
        SQL = "SELECT TOP (100) Pte.[Codigo]
      ,Pte.[CUIL]
      ,Pte.[Nombre]
     
  FROM [Oculus].[dbo].[Paciente] PTE "

        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()

                conn.Open()

                cmd4.CommandText = SQL

                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader

                Do While reader.Read()
                    Dim fila(4) As Object

                    fila(0) = reader(0)
                    fila(1) = reader(1)
                    fila(2) = reader(2)

                    DataGridView1.Rows.Add(fila)

                Loop

            End Using
        End Using
    End Function

#End Region

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        DataGridView1.Rows.Clear()
        SQL = "SELECT TOP (100) Pte.[Codigo]
      ,Pte.[CUIL]
      ,Pte.[Nombre]     
  FROM [Oculus].[dbo].[Paciente] PTE  where nombre like '%" & txtFiltro.Text & "%'"

        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()

                conn.Open()

                cmd4.CommandText = SQL

                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader

                Do While reader.Read()
                    Dim fila(4) As Object

                    fila(0) = reader(0)
                    fila(1) = reader(1)
                    fila(2) = reader(2)

                    DataGridView1.Rows.Add(fila)

                Loop

            End Using
        End Using
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim _dataTable = LoadDataTable()
        Dim estadoOperacion = Opener.LoadDataPaciente(_dataTable)
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unPaciente As New PacienteABM
        unPaciente.Show()
    End Sub
End Class