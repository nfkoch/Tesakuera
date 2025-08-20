Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Conexion
    Public Function cargarConexion() As String
        Dim cadena As String

        cadena = "Data Source=MORGANA\SQLEXPRESS;Initial Catalog=oculus;Persist Security Info=True;User ID=sa;Password=root"

        Return cadena
    End Function
End Class
