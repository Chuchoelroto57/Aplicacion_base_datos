'//Se importan librerias para la conexión de la DBA
Imports System.Data
Imports System.Data.OleDb



Module Conexion_Base

    '// Guarda la tura hasta la carpeta Debug
    Public Ruta As String = Application.StartupPath

    '// Variable para realizar la conexion
    Public Conexion As New OleDbConnection

    Sub Enlace()
        Try
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + Ruta + "\Recursos\Base_Principal2.accdb"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module
