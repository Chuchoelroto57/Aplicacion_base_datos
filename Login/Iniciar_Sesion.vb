Imports System.Data
Imports System.Data.OleDb

Imports System.Runtime.InteropServices

Public Class Iniciar_Sesion

    '// VARIABLES PUBLICAS Y PRIVADAS
    '// VARIABLES PUBLICAS SE UTILIZAN EN CUALQUIER FORMULARIO.
    '// VARIABLES PRIVADAS SE UTILIZAN DENTRO DEL FORMULARIO ACTUAL.
    '// DECLARACIÓN DE VARIABLES PRIVADAS: DIM, NOMBRE AS TIPO DATO
    '// DECLARACIÓN DE VARIABLES PUBLICAS: PUBLIC, NOMBRE AS TIPO DATO
    '// TIPO DE DATO: INTEGER, DOUBLE, STRING.

    Public Nombre_Usuario As String
    Public Correo_Usuario As String
    Public Edad_Usuario As Double
    Public Contraseña_Usuario As String
    Public Genero_Usuario As String
    Public Ciudad_Usuario As String

    Private Sub Iniciar_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enlace()
        ComboUsuario.Text = "Selecciona Usuarios"
        'ComboUsuario.SelectedIndex = 0
        Me.Opacity = 0 '// Indica que el formulario sea invisible
        TimerAbrir.Start()
        Cargar_Usuarios()

    End Sub
    Private Sub Cargar_Usuarios()

        Try

            Dim Tabla As New DataTable
            Dim ConsultaSql As String = "Select Nombre From Usuarios"
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)
            Adaptador.Fill(Tabla)
            ComboUsuario.DataSource = Tabla
            ComboUsuario.DisplayMember = "Nombre"

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Limpiar_Variables()
        TimerCerrar.Start()

    End Sub
    '//**************************************************************
    '// Librearias y eventos para poder mover de lugar el formulario
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Iniciar_Sesion_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelInferior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelInferior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        InicioSesion()

    End Sub

    Private Sub ComboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUsuario.SelectedIndexChanged

        Cargar_Datos_Usuario()


        ''   If ComboUsuario.Text = "Jose de Jesus" Then
        ' Correo_Usuario = "josej@gmail.com"
        'Tipo_Usuario = "Estudiante"
        'Expediente_Usuario = 256024
        'Contraseña_Usuario = "Kakaroto"
        'Nombre_Usuario = ComboUsuario.Text
        'TextBoxContraseña.Text = Contraseña_Usuario
        'ElseIf ComboUsuario.Text = "Juan Pedro" Then
        'Correo_Usuario = "juanp@gmail.com"
        'Tipo_Usuario = "Estudiante"
        'Expediente_Usuario = 256789
        'Contraseña_Usuario = "Perro"
        'Nombre_Usuario = ComboUsuario.Text

        'TextBoxContraseña.Text = Contraseña_Usuario
        'ElseIf ComboUsuario.Text = "Nirvana Belen" Then
        'Correo_Usuario = "nirvanab@gmail.com"
        'Tipo_Usuario = "Estudiante"
        'Expediente_Usuario = 266889
        ' Contraseña_Usuario = "Gato"
        '  Nombre_Usuario = ComboUsuario.Text
        '   TextBoxContraseña.Text = Contraseña_Usuario
        'End If
    End Sub

    'Private Sub LinkLabelEtiquetaOcultar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEtiquetaOcultar.LinkClicked
    '    LabelExpediente.Visible = False
    '    LabelCorreo.Visible = False
    '    LabelTipo.Visible = False
    '    LinkLabelEtiquetaOcultar.Visible = False
    '    LinkLabelEtiquetaMostrar.Visible = True

    'End Sub

    'Private Sub LinkLabelEtiquetaMostrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEtiquetaMostrar.LinkClicked
    '    LabelExpediente.Visible = True
    '    LabelCorreo.Visible = True
    '    LabelTipo.Visible = True
    '    LinkLabelEtiquetaOcultar.Visible = True
    '    LinkLabelEtiquetaMostrar.Visible = False


    'End Sub
    Private Sub InicioSesion()

        Try

            Dim ConsultaSQL As String
            Dim Adaptador As New OleDb.OleDbDataAdapter
            Dim Comando As New OleDb.OleDbCommand
            Dim Lector As OleDb.OleDbDataReader

            ConsultaSQL = "SELECT * FROM Usuarios WHERE Nombre ='" & ComboUsuario.Text & "' AND CLave = '" & TextBoxContraseña.Text & "'"
            Comando = New OleDb.OleDbCommand(ConsultaSQL, Conexion)
            Adaptador.SelectCommand = Comando
            Lector = Comando.ExecuteReader

            If Lector.Read = True Then
                Me.Hide()
                Bienvenida.ShowDialog()
                Principal.Show()

            Else
                '-----------Mensaje de error------------------------------------
                MsgBox("CONTRASEÑA INCORRECTA, INTENDA DE NUEVO", MsgBoxStyle.Critical, "Inicio Sesión")
                TextBoxContraseña.Clear()
                TextBoxContraseña.Focus()

                '---------------------------------------------------------------
            End If



        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ComboUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboUsuario.KeyPress

        e.KeyChar = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureMostrar.Click
        TextBoxContraseña.PasswordChar = ""
        PictureOcultar.Visible = True


    End Sub

    Private Sub TextBoxContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxContraseña.KeyDown

        If e.KeyCode = Keys.Enter Then
            InicioSesion()
        End If

    End Sub

    '// PROCESOS PRIVADOS Y PÚBLICOS
    '// PROCESOS PRIVADOS SOLAMENTE SE UTILIZAN EN EL FORMULARIO ACTUAL
    '// LOS PROCESOS PUBLICOS, SE PUEDEN MANDAR LLAMAR DESDE CUALQUIER FORMULARIO
    '// DECLARACIÓN DE PROCESOS PRIVADOS: PRIVATE SUB, NOMBRE, END SUB
    '// DECLARACIÓN DE PROCESOS PÚBLICOS: SUB, NOMBRE, END SUB

    Private Sub Inicio_de_sesion()
        If ComboUsuario.Text = "Jose de Jesus" And TextBoxContraseña.Text = "Kakaroto" Or
          ComboUsuario.Text = "Juan Pedro" And TextBoxContraseña.Text = "Perro" Or
          ComboUsuario.Text = "Nirvana Belen" And TextBoxContraseña.Text = "Gato" Then

            Me.Hide()
            Bienvenida.ShowDialog()
            Principal.Show()

            '// ESTRUCUTAS DE MENSAJES DE ERROR O DE ALERTA
            '// MSGBOX, MENSAJE (ENTRE COMILLAS), TIPO DE ESTILO DE LA VENTANA TITULO
        Else
            '-----------Mensaje de error------------------------------------
            MsgBox("CONTRASEÑA INCORRECTA, INTENDA DE NUEVO", MsgBoxStyle.Critical, "Inicio Sesión")
            TextBoxContraseña.Clear()
            TextBoxContraseña.Focus()

            '---------------------------------------------------------------

        End If
    End Sub

    Private Sub Limpiar_Variables()
        ' Nombre_Usuario = Nothing
        'Tipo_Usuario = Nothing
        'Expediente_Usuario = Nothing
        ' Contraseña_Usuario = Nothing
        ' Correo_Usuario = Nothing

    End Sub

    Private Sub PictureOcultar_Click(sender As Object, e As EventArgs) Handles PictureOcultar.Click
        TextBoxContraseña.PasswordChar = "*"
        PictureMostrar.Visible = True
        PictureOcultar.Visible = False
    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick

        '// La opacidad se mide de 0 a 1

        If Me.Opacity < 1 Then '// Aqui el formulario no es visible

            Me.Opacity += 0.05

        End If

        If Me.Opacity = 1 Then

            TimerAbrir.Stop() '// El temporizador se detiene cuando la opacidad es igual a 1

        End If


    End Sub



    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick

        Me.Opacity -= 0.1

        If Opacity = 0 Then
            TimerCerrar.Stop()
            Me.Close()
        End If

    End Sub

    Private Sub LinkRecuperarContraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRecuperarContraseña.LinkClicked
        Me.Hide()
        Recuperar_Contraseña.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    '-----------------------------------------------------------------
    '------------------PROCESO PARA CARGAR DATOS DEL USUARIO QUE SE SELECCIONA-------------
    '----------------------------------------------------------------
    Private Sub Cargar_Datos_Usuario()

        Dim ConsultaSQL As String
        Dim Adaptador As OleDbDataAdapter
        Dim Registro As DataSet
        Dim Lista As Long

        ConsultaSQL = "SELECT Nombre, Clave, Correo, Edad, Genero, Ciudad FROM Usuarios WHERE Nombre = '" & ComboUsuario.Text & "'"
        Adaptador = New OleDbDataAdapter(ConsultaSQL, Conexion)
        Try
            Registro = New DataSet

            Adaptador.Fill(Registro, "Usuarios")
            Lista = Registro.Tables("Usuarios").Rows.Count

            If Lista <> 0 Then

                Nombre_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Nombre")
                Contraseña_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Clave")
                Correo_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Correo")
                Edad_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Edad")
                Genero_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Genero")
                Ciudad_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Ciudad")

            End If

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class