'Clase que contiene las busquedas espeficicas compartidas por todos los winforms
Imports System.Data.SqlClient

Public Class BusquedasGlobales
    'variable para llamar a la clase donde tengo la cadena de conexion a la base de datos en sql server express
    Dim Connstr As New Conexion
    'variable para almacenar las consultas sql que voy a usar en el winform
    Dim SQL As String

#Region "Geogriafia"
    Public Function DameProvinciaCodigo(ByRef Nombre As String) As String
        SQL = "select [Codigo] from [Provincia] where [Provincia]='" & Nombre & "'"
        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()

                conn.Open()

                cmd4.CommandText = SQL

                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader
                If reader.Read() Then
                    Return reader(0).ToString
                Else
                    Return "0"
                End If
            End Using
        End Using
    End Function
    Public Function DameLocalidadCodigo(ByRef Nombre As String) As String
        SQL = "select [Codigo] from [Localidades] where [Localidad]='" & Nombre & "'"
        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()

                conn.Open()

                cmd4.CommandText = SQL

                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader
                If reader.Read() Then
                    Return reader(0).ToString
                Else
                    Return "0"
                End If
            End Using
        End Using
    End Function
#End Region

#Region "Obra Social"
    Public Function DameObraSocialCodigo(ByRef Nombre As String) As String
        SQL = "select [Codigo] from [ObraSocial] where [Descripcion]='" & Nombre & "'"
        Using conn As New SqlConnection(Connstr.cargarConexion)
            Using cmd4 As SqlCommand = conn.CreateCommand()

                conn.Open()

                cmd4.CommandText = SQL

                Dim reader As SqlDataReader = Nothing
                reader = cmd4.ExecuteReader
                If reader.Read() Then
                    Return reader(0).ToString
                Else
                    Return "0"
                End If
            End Using
        End Using
    End Function
#End Region

End Class
