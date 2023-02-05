'//Se importan librerias para la conexión de la DBA
Imports System.Data
Imports System.Data.OleDb



Public Class Alumnos

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Alumnos()
        Cargar_Facultades()
    End Sub

    '//Proceso para mostar la tabla Alumnos
    Private Sub Mostrar_Alumnos()
        Try

            '//Guarda la información de la tabla completa en paquete
            Dim Paquete As New DataSet

            '//Consult a la base de datos de lo que quieres mostrar
            Dim ConsultaSql As String

            '// Conecta la conlta a con la base de datos
            Dim Adaptador As New OleDbDataAdapter

            '//Consulta para mostrar toda la tabla de alumnos
            ConsultaSql = "SELECT * FROM Alumnos"

            '//Conecta la consulta SQL con la conexion de la basa de datos
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Agrega la tabla alumnos a la variable Paquete.
            Paquete.Tables.Add("Alumnos")

            'Llena la informacion la variable paquetee con la tabla alumnos
            Adaptador.Fill(Paquete.Tables("Alumnos"))
            '//Muestra la información de alumnos en el datagrid (Todas la columnas)
            DataGridAlumnos.DataSource = Paquete.Tables("Alumnos")


        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    '//Proceso para cargar las facultades en una COMBOBOX

    Private Sub Cargar_Facultades()
        Try
            '//Variable que guarda los datos de una columna
            Dim Tabla_Columna As New DataTable

            '// Consulta para mostrar las facultades de la tabla alumnos
            Dim ConsultaSql As String = "SELECT Facultad FROM Alumnos"
            '//Conecta la consulta con la base de datos
            Dim adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Llena la variable tabla_columna con los datos de la facultades
            adaptador.Fill(Tabla_Columna)
            '//Llena de facultades el combobox
            ComboBoxFacultad.DataSource = Tabla_Columna
            '//Muestra las facultades en el combobox
            ComboBoxFacultad.DisplayMember = "Facultad"


        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class