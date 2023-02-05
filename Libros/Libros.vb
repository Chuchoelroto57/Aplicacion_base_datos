'//Se importan librerias para la conexión de la DBA
Imports System.Data
Imports System.Data.OleDb

Public Class Libros
    Private Sub Libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Libros()
        Limpiar_Texto()
        ComboBoxSucursal.Text = "Selcciona sucursal"
    End Sub

    Public Comandos As New OleDb.OleDbCommand


    Private Sub Registrar_libros()
        Try
            Comandos.Connection = Conexion
            Comandos = New OleDb.OleDbCommand("INSERT INTO Libros(Folio, Nombre, Autor, Descripcion, Sucursal_Venta)" & Chr(13) &
            "VALUES(Folio, Nombre, Autor, Descripcion, Sucursal_Venta)", Conexion)

            Comandos.Parameters.AddWithValue("@Folio", TextBoxFol.Text)
            Comandos.Parameters.AddWithValue("@Nombre", TextBoxNombre.Text)
            Comandos.Parameters.AddWithValue("@Autor", TextBoxAutor.Text)
            Comandos.Parameters.AddWithValue("@Descripcion", TextBoxDescripcion.Text)
            Comandos.Parameters.AddWithValue("@Sucursal_Venta", ComboBoxSucursal.Text)

            Comandos.ExecuteNonQuery() 'Se ejecuta dodas las instrucciones anteriores

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click

        If TextBoxFol.Text = Nothing Or
                TextBoxNombre.Text = Nothing Or
                TextBoxAutor.Text = Nothing Or
                TextBoxDescripcion.Text = Nothing Or
                ComboBoxSucursal.Text = "Selecciona sucursal" Then
            MsgBox("Espacios en blanco, ingrese la información completa", MsgBoxStyle.Critical, "Nuevo Registro")
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se registrara un nuevo libro, ¿Deseas contunuar?", "Nuevo Registro", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                Registrar_libros()
                Mostrar_Libros()
                Limpiar_Texto()
            ElseIf Respuesta = DialogResult.No Then

            End If
        End If
    End Sub

    Private Sub Mostrar_Libros()
        Try

            '//Guarda la información de la tabla completa en paquete
            Dim Paquete As New DataSet

            '//Consult a la base de datos de lo que quieres mostrar
            Dim ConsultaSql As String

            '// Conecta la conlta a con la base de datos
            Dim Adaptador As New OleDbDataAdapter

            '//Consulta para mostrar toda la tabla de alumnos
            ConsultaSql = "SELECT * FROM Libros Order by Nombre Asc"

            '//Conecta la consulta SQL con la conexion de la basa de datos
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Agrega la tabla alumnos a la variable Paquete.
            Paquete.Tables.Add("Libros")

            'Llena la informacion la variable paquetee con la tabla alumnos
            Adaptador.Fill(Paquete.Tables("Libros"))
            DataGridLibros.DataSource = Paquete.Tables("Libros")
            '//Muestra la información de alumnos en el datagrid (Todas la columnas)
            DataGridLibros.Columns("Folio").Width = 90

            DataGridLibros.Columns("Nombre").Width = 100

            DataGridLibros.Columns("Autor").Width = 100

            DataGridLibros.Columns("Descripcion").Width = 100

            DataGridLibros.Columns("Sucursal_Venta").Width = 100


        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Buscar_Folio_Repetido()
        Try
            If TextBoxFol.Text <> Nothing Then
                Dim Paquete As New DataSet
                Dim Adaptador As New OleDbDataAdapter
                Dim Consultasql As String
                Dim Registro As Long
                Consultasql = "SELECT * FROM Libros WHERE Folio = " & TextBoxFol.Text
                Adaptador = New OleDbDataAdapter(Consultasql, Conexion)
                Paquete = New DataSet
                Adaptador.Fill(Paquete, "Libros")
                Registro = Paquete.Tables("Libros").Rows.Count
                If Registro <> 0 Then
                    MsgBox("Folio existente, ingrese nuevamente", MsgBoxStyle.Critical, "Nuevo Registro")
                    TextBoxFol.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Limpiar_Texto()
        TextBoxFol.Clear()
        TextBoxNombre.Clear()
        TextBoxAutor.Clear()
        TextBoxDescripcion.Clear()
        ComboBoxSucursal.Text = "Selecciona sucursal"
        DataGridLibros.ClearSelection()
        ButtonRegistrar.Visible = True
        ButtonActualizar.Visible = False

    End Sub
    Private Sub TextBoxFol_Leave(sender As Object, e As EventArgs) Handles TextBoxFol.Leave
        Buscar_Folio_Repetido()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            If DataGridLibros.Rows.Count = 0 Then

                MsgBox("No existe la fila seleccionada", MsgBoxStyle.Critical, "Eliminar Registro")

            Else

                Dim Respuesta As DialogResult = MessageBox.Show("Se eliminara el registro seleccionado, ¿Desa continuar?, ¿Deseas contunuar?", "Nuevo Registro", MessageBoxButtons.YesNo)
                If Respuesta = DialogResult.Yes Then

                    Dim Comando_Eliminar As New OleDbCommand
                    For Each Fila As DataGridViewRow In DataGridLibros.SelectedRows

                        Dim Folio As Double = Fila.Cells("Folio").Value
                        Comando_Eliminar.Connection = Conexion
                        Comando_Eliminar.CommandText = "DELETE  FROM Libros WHERE Folio =" & Folio
                        Comando_Eliminar.ExecuteNonQuery()



                    Next
                    Mostrar_Libros() '// Siempre se coloca fuera del for Each
                    '// Instrucciones si el usuario dice que si

                ElseIf Respuesta = DialogResult.No Then

                    '// Instrucciones si el usuario dice que no

                End If

            End If






        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        Limpiar_Texto()
    End Sub

    Private Sub Selecciona_Doble_Click()

        For Each Fila As DataGridViewRow In DataGridLibros.SelectedRows

            Dim Folio As Double = Fila.Cells("Folio").Value
            Dim Nombre As String = Fila.Cells("Nombre").Value
            Dim Autor As String = Fila.Cells("Autor").Value
            Dim Descripcion As String = Fila.Cells("Descripcion").Value
            Dim Sucursal_Venta As String = Fila.Cells("Sucursal_Venta").Value

            TextBoxFol.Text = Folio
            TextBoxAutor.Text = Autor
            TextBoxNombre.Text = Nombre
            TextBoxDescripcion.Text = Descripcion
            ComboBoxSucursal.Text = Sucursal_Venta

        Next


    End Sub

    Private Sub DataGridLibros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridLibros.CellDoubleClick
        Selecciona_Doble_Click()
        ButtonActualizar.Visible = True
        ButtonRegistrar.Visible = False
    End Sub
    '//
    Private Sub Actualizar_Libros()


        Try
            Dim Comando_Actualizar As New OleDbCommand
            Dim Folio As Double
            Folio = TextBoxFol.Text

            Comando_Actualizar.Connection = Conexion

            Comando_Actualizar.CommandText = "UPDATE Libros SET Nombre = '" & TextBoxNombre.Text &
                "', Autor = '" & TextBoxAutor.Text &
                "', Descripcion = '" & TextBoxDescripcion.Text &
                "', Sucursal_Venta = '" & ComboBoxSucursal.Text &
                "'WHERE Folio = " & Folio

            Comando_Actualizar.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If TextBoxFol.Text = Nothing Or
                TextBoxNombre.Text = Nothing Or
                TextBoxAutor.Text = Nothing Or
                TextBoxDescripcion.Text = Nothing Or
                ComboBoxSucursal.Text = "Selecciona sucursal" Then
            MsgBox("Espacios en blanco, checa los espacios", MsgBoxStyle.Critical, "Actualizar registro")
        Else

            Dim Respuesta As DialogResult = MessageBox.Show("Se actualizara el registro seleccionado, ¿Deseas contunuar?", "Nuevo Registro", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                '// Instrucciones si el usuario dice que si
                Actualizar_Libros()
                Mostrar_Libros()
                Limpiar_Texto()

            ElseIf Respuesta = DialogResult.No Then

            End If
        End If
    End Sub


End Class