'//Se importan librerias para la conexión de la DBA
Imports System.Data
Imports System.Data.OleDb

Public Class Album_Musica
    Private Sub Album_Musica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Musica()
        Limpiar_Texto()
    End Sub

    Public Comandos As New OleDb.OleDbCommand

    Private Sub Registrar_album()
        Try
            Comandos.Connection = Conexion
            Comandos = New OleDb.OleDbCommand("INSERT INTO Album_Musica(Codigo, Nombre_Album, Artista, No_de_canciones, Genero, Año_lanzamiento)" & Chr(13) &
            "VALUES(Codigo, Nombre_Album, Artista, No_de_canciones, Genero, Año_lanzamiento)", Conexion)

            Comandos.Parameters.AddWithValue("@Codigo", TextBoxCodigo.Text)
            Comandos.Parameters.AddWithValue("@Nombre_Album", TextBoxNombre.Text)
            Comandos.Parameters.AddWithValue("@Artista", TextBoxArtista.Text)
            Comandos.Parameters.AddWithValue("@No_de_canciones", TextBoxCanciones.Text)
            Comandos.Parameters.AddWithValue("@Genero", TextBoxGenero.Text)
            Comandos.Parameters.AddWithValue("@Año_lanzamiento", TextBoxAño.Text)

            Comandos.ExecuteNonQuery() 'Se ejecuta dodas las instrucciones anteriores

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        If TextBoxCodigo.Text = Nothing Or
             TextBoxNombre.Text = Nothing Or
             TextBoxArtista.Text = Nothing Or
             TextBoxCanciones.Text = Nothing Or
             TextBoxGenero.Text = Nothing Or
             TextBoxAño.Text = Nothing Then
            MsgBox("Espacios en blanco, ingrese la información completa", MsgBoxStyle.Critical, "Nuevo Registro")
        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se registrara un nuevo album, ¿Deseas contunuar?", "Nuevo Registro", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                Registrar_album()
                Mostrar_Musica()
                Limpiar_Texto()
            ElseIf Respuesta = DialogResult.No Then

            End If
        End If
    End Sub

    Private Sub Mostrar_Musica()
        Try

            '//Guarda la información de la tabla completa en paquete
            Dim Paquete As New DataSet

            '//Consult a la base de datos de lo que quieres mostrar
            Dim ConsultaSql As String

            '// Conecta la conlta a con la base de datos
            Dim Adaptador As New OleDbDataAdapter

            '//Consulta para mostrar toda la tabla de alumnos
            ConsultaSql = "SELECT * FROM Album_Musica Order by Nombre_Album Asc"

            '//Conecta la consulta SQL con la conexion de la basa de datos
            Adaptador = New OleDbDataAdapter(ConsultaSql, Conexion)

            '//Agrega la tabla alumnos a la variable Paquete.
            Paquete.Tables.Add("Album_Musica")

            'Llena la informacion la variable paquetee con la tabla alumnos
            Adaptador.Fill(Paquete.Tables("Album_Musica"))
            DataGridMusica.DataSource = Paquete.Tables("Album_Musica")
            '//Muestra la información de alumnos en el datagrid (Todas la columnas)
            DataGridMusica.Columns("Codigo").Width = 90

            DataGridMusica.Columns("Nombre_Album").Width = 90

            DataGridMusica.Columns("Artista").Width = 90

            DataGridMusica.Columns("No_de_canciones").Width = 90

            DataGridMusica.Columns("Genero").Width = 90

            DataGridMusica.Columns("Año_lanzamiento").Width = 90

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Buscar_Codigo_Repetido()
        Try
            If TextBoxCodigo.Text <> Nothing Then
                Dim Paquete As New DataSet
                Dim Adaptador As New OleDbDataAdapter
                Dim Consultasql As String
                Dim Registro As Long
                Consultasql = "SELECT * FROM Album_Musica WHERE Codigo = " & TextBoxCodigo.Text
                Adaptador = New OleDbDataAdapter(Consultasql, Conexion)
                Paquete = New DataSet
                Adaptador.Fill(Paquete, "Album_Musica")
                Registro = Paquete.Tables("Album_Musica").Rows.Count
                If Registro <> 0 Then
                    MsgBox("Codigo existente, ingrese nuevamente", MsgBoxStyle.Critical, "Nuevo Registro")
                    TextBoxCodigo.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Limpiar_Texto()
        TextBoxCodigo.Clear()
        TextBoxNombre.Clear()
        TextBoxArtista.Clear()
        TextBoxCanciones.Clear()
        TextBoxGenero.Clear()
        TextBoxAño.Clear()
        DataGridMusica.ClearSelection()
        ButtonRegistrar.Visible = True
        ButtonActualizar.Visible = False

    End Sub

    Private Sub TextBoxCodigo_Leave(sender As Object, e As EventArgs) Handles TextBoxCodigo.Leave
        Buscar_Codigo_Repetido()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try
            If DataGridMusica.Rows.Count = 0 Then

                MsgBox("No existe la fila seleccionada", MsgBoxStyle.Critical, "Eliminar Registro")

            Else

                Dim Respuesta As DialogResult = MessageBox.Show("Se eliminara el registro seleccionado, ¿Desa continuar?, ¿Deseas contunuar?", "Nuevo Registro", MessageBoxButtons.YesNo)
                If Respuesta = DialogResult.Yes Then

                    Dim Comando_Eliminar As New OleDbCommand
                    For Each Fila As DataGridViewRow In DataGridMusica.SelectedRows

                        Dim Codigo As Double = Fila.Cells("Codigo").Value
                        Comando_Eliminar.Connection = Conexion
                        Comando_Eliminar.CommandText = "DELETE  FROM Album_Musica WHERE Codigo =" & Codigo
                        Comando_Eliminar.ExecuteNonQuery()



                    Next
                    Mostrar_Musica() '// Siempre se coloca fuera del for Each
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

        For Each Fila As DataGridViewRow In DataGridMusica.SelectedRows

            Dim Codigo As Double = Fila.Cells("Codigo").Value
            Dim Nombre As String = Fila.Cells("Nombre_Album").Value
            Dim Artista As String = Fila.Cells("Artista").Value
            Dim Canciones As String = Fila.Cells("No_de_canciones").Value
            Dim Genero As String = Fila.Cells("Genero").Value
            Dim Año As String = Fila.Cells("Año_lanzamiento").Value

            TextBoxCodigo.Text = Codigo
            TextBoxNombre.Text = Nombre
            TextBoxArtista.Text = Artista
            TextBoxCanciones.Text = Canciones
            TextBoxGenero.Text = Genero
            TextBoxAño.Text = Año


        Next


    End Sub
    Private Sub DataGridMusica_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMusica.CellDoubleClick
        Selecciona_Doble_Click()
        ButtonActualizar.Visible = True
        ButtonRegistrar.Visible = False
    End Sub

    Private Sub Actualizar_Musica()


        Try
            Dim Comando_Actualizar As New OleDbCommand
            Dim Codigo As Double
            Codigo = TextBoxCodigo.Text

            Comando_Actualizar.Connection = Conexion

            Comando_Actualizar.CommandText = "UPDATE Album_Musica SET Nombre_Album = '" & TextBoxNombre.Text &
                "', Artista = '" & TextBoxArtista.Text &
                "', No_de_canciones = '" & TextBoxCanciones.Text &
                "', Genero = '" & TextBoxGenero.Text &
                "', Año_lanzamiento = '" & TextBoxAño.Text &
                "'WHERE Codigo = " & Codigo

            Comando_Actualizar.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If TextBoxCodigo.Text = Nothing Or
                TextBoxNombre.Text = Nothing Or
                TextBoxArtista.Text = Nothing Or
                TextBoxCanciones.Text = Nothing Or
                TextBoxGenero.Text = Nothing Or
                TextBoxAño.Text = Nothing Then
            MsgBox("Espacios en blanco, checa los espacios", MsgBoxStyle.Critical, "Actualizar registro")
        Else

            Dim Respuesta As DialogResult = MessageBox.Show("Se actualizara el registro seleccionado, ¿Deseas contunuar?", "Nuevo Registro", MessageBoxButtons.YesNo)
            If Respuesta = DialogResult.Yes Then
                '// Instrucciones si el usuario dice que si
                Actualizar_Musica()
                Mostrar_Musica()
                Limpiar_Texto()

            ElseIf Respuesta = DialogResult.No Then

            End If
        End If
    End Sub


End Class