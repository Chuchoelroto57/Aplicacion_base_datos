'//Se importan librerias para la conexión de la DBA
Imports System.Data
Imports System.Data.OleDb

Public Class Docentes

    '// VARIABLES PUBLICAS Y PRIVADAS
    '// VARIABLES PUBLICAS SE UTILIZAN EN CUALQUIER FORMULARIO.
    '// VARIABLES PRIVADAS SE UTILIZAN DENTRO DEL FORMULARIO ACTUAL.
    '// DECLARACIÓN DE VARIABLES PRIVADAS: DIM, NOMBRE AS TIPO DATO
    '// DECLARACIÓN DE VARIABLES PUBLICAS: PUBLIC, NOMBRE AS TIPO DATO
    '// TIPO DE DATO: INTEGER, DOUBLE, STRING.

    Public Correo_Docente As String
    Public Ciudad_Docente As String
    Public Facultad_Docente As String
    Public Materia_Docente As String
    Public Tipo_Docente As String


    Private Sub Docentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostar_Docentes()
        Cargar_Docentes()

    End Sub

    Private Sub Mostar_Docentes()
        Try

            '//Guarda la información de la tabla completa en paquete
            Dim Paquete As New DataSet

            '//Consult a la base de datos de lo que quieres mostrar
            Dim ConsultaSql As String

            '// Conecta la conlta a con la base de datos
            Dim Adaptador As New OleDbDataAdapter

            '//Consulta para mostrar toda la tabla de alumnos
            ConsultaSql = "SELECT * FROM DOCENTES Order by Nombre Asc"

            '//Conecta la consulta SQL con la conexion de la basa de datos
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Agrega la tabla alumnos a la variable Paquete.
            Paquete.Tables.Add("Docentes")

            'Llena la informacion la variable paquetee con la tabla alumnos
            Adaptador.Fill(Paquete.Tables("Docentes"))
            '//Muestra la información de alumnos en el datagrid (Todas la columnas)
            DataGridDocentes.DataSource = Paquete.Tables("Docentes")
            'DataGridDocentes.Columns("PrecioCosto").Width = 100
            'DataGridDocentes.Columns("PrecioCosto").DefaultCellStyle.Format = "C2"
            'DataGridDocentes.Columns("PrecioFinal").Width = 100
            ' DataGridDocentes.Columns("PrecioFinal").DefaultCellStyle.Format = "C2"

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Cargar_Docentes()
        Try
            '//Variable que guarda los datos de una columna
            Dim Tabla_Columna As New DataTable

            '// Consulta para mostrar las facultades de la tabla docentes
            Dim ConsultaSql As String = "SELECT Nombre FROM Docentes"
            '//Conecta la consulta con la base de datos
            Dim adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Llena la variable tabla_columna con los datos de la facultades
            adaptador.Fill(Tabla_Columna)
            '//Llena de facultades e
            'l combobox
            ComboBoxDocentes.DataSource = Tabla_Columna
            '//Muestra las facultades en el combobox
            ComboBoxDocentes.DisplayMember = "Nombre"


        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Cargar_Datos_Docentes()
        Try


            Dim ConsultaSQL As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSQL = "SELECT Folio, Nombre, Correo, Ciudad, Facultad, Materia, Tipo FROM Docentes WHERE Nombre = '" & ComboBoxDocentes.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, Conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "Docentes")
            Lista = Registro.Tables("Docentes").Rows.Count

            If Lista <> 0 Then

                Correo_Docente = Registro.Tables("Docentes").Rows(0).Item("Correo")
                Ciudad_Docente = Registro.Tables("Docentes").Rows(0).Item("Ciudad")
                Facultad_Docente = Registro.Tables("Docentes").Rows(0).Item("Facultad")
                Tipo_Docente = Registro.Tables("Docentes").Rows(0).Item("Tipo")
                Materia_Docente = Registro.Tables("Docentes").Rows(0).Item("Materia")


            End If

            LabelCiudad.Text = Ciudad_Docente
            LabelCorreo.Text = Correo_Docente
            LabelFacultad.Text = Facultad_Docente
            LabelMateria.Text = Materia_Docente
            LabelTipo.Text = Tipo_Docente

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBoxDocentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDocentes.SelectedIndexChanged
        Cargar_Datos_Docentes()
    End Sub
End Class