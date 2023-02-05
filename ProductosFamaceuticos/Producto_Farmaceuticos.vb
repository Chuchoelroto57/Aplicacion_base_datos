'//Se importan librerias para la conexión de la DBA
Imports System.Data
Imports System.Data.OleDb

Public Class Producto_Farmaceuticos
    Private Sub Producto_Farmaceuticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_ProductoFarma()
        Cargar_Laboratorio()
        TextBoxTotalregistros.Text = DataGridProductos.Rows.Count
    End Sub
    Private Sub Mostrar_ProductoFarma()
        Try

            '//Guarda la información de la tabla completa en paquete
            Dim Paquete As New DataSet

            '//Consult a la base de datos de lo que quieres mostrar
            Dim ConsultaSql As String

            '// Conecta la conlta a con la base de datos
            Dim Adaptador As New OleDbDataAdapter

            '//Consulta para mostrar toda la tabla de alumnos
            ConsultaSql = "SELECT * FROM Productos_Farmaceuticos Order by Nombre Asc"

            '//Conecta la consulta SQL con la conexion de la basa de datos
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Agrega la tabla alumnos a la variable Paquete.
            Paquete.Tables.Add("Productos_Farmaceuticos")

            'Llena la informacion la variable paquetee con la tabla alumnos
            Adaptador.Fill(Paquete.Tables("Productos_Farmaceuticos"))
            DataGridProductos.DataSource = Paquete.Tables("Productos_Farmaceuticos")

            '//Muestra la información de alumnos en el datagrid (Todas la columnas)
            DataGridProductos.DataSource = Paquete.Tables("Productos_Farmaceuticos")
            DataGridProductos.Columns("PrecioCosto").Width = 100
            DataGridProductos.Columns("PrecioCosto").DefaultCellStyle.Format = "C2"
            DataGridProductos.Columns("PrecioFinal").Width = 100
            DataGridProductos.Columns("PrecioFinal").DefaultCellStyle.Format = "C2"

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    '//Proceso para cargar las facultades en una COMBOBOX

    Private Sub Cargar_Laboratorio()
        Try
            '//Variable que guarda los datos de una columna
            Dim Tabla_Columna As New DataTable

            '// Consulta para mostrar las facultades de la tabla alumnos
            Dim ConsultaSql As String = "SELECT Laboratorio FROM Productos_Farmaceuticos"
            '//Conecta la consulta con la base de datos
            Dim adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Llena la variable tabla_columna con los datos de la facultades
            adaptador.Fill(Tabla_Columna)
            '//Llena de facultades e
            'l combobox
            ComboBoxLaboratorio.DataSource = Tabla_Columna
            '//Muestra las facultades en el combobox
            ComboBoxLaboratorio.DisplayMember = "Laboratorio"


        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class