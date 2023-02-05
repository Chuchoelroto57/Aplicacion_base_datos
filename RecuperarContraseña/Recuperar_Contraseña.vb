Imports System.Runtime.InteropServices

Public Class Recuperar_Contraseña
    Public Nombre_Usuario As String
    Public Correo_Usuario As String
    Public Tipo_Usuario As String
    Public Contraseña_Usuario As String
    Public Expediente_Usuario As String

    Private Sub Recuperar_Contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboUsuario.SelectedIndex = 0
        Me.Opacity = 0
        TimerAbrir.Start()
    End Sub
    Private Sub ComboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUsuario.SelectedIndexChanged
        If ComboUsuario.Text = "Jose de Jesus" Then
            TextBoxCorreo.Text = "josej@gmail.com"
            Tipo_Usuario = "Estudiante"
            Expediente_Usuario = 256024
            Contraseña_Usuario = "Kakaroto"
            Nombre_Usuario = ComboUsuario.Text

        ElseIf ComboUsuario.Text = "Juan Pedro" Then
            TextBoxCorreo.Text = "juanp@gmail.com"
            Tipo_Usuario = "Estudiante"
            Expediente_Usuario = 256789
            Contraseña_Usuario = "Perro"
            Nombre_Usuario = ComboUsuario.Text


        ElseIf ComboUsuario.Text = "Nirvana Belen" Then
            TextBoxCorreo.Text = "nirvanab@gmail.com"
            Tipo_Usuario = "Estudiante"
            Expediente_Usuario = 266889
            Contraseña_Usuario = "Gato"

        End If
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Limpiar_Variables()
        TimerCerrar.Start()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click

    End Sub
    Private Sub Limpiar_Variables()
        Nombre_Usuario = Nothing
        Tipo_Usuario = Nothing
        Expediente_Usuario = Nothing
        Contraseña_Usuario = Nothing
        Correo_Usuario = Nothing

    End Sub
    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick

        Me.Opacity -= 0.1

        If Opacity = 0 Then
            TimerCerrar.Stop()
            Me.Close()
            Iniciar_Sesion.Show()
        End If

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

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        '----------------------------MENSAJE DE CONFIRMACIÓN--------------------'
        MsgBox("La nueva contraseña ha sido enviada a: " & Iniciar_Sesion.Correo_Usuario, MsgBoxStyle.OkOnly, "Recuperar_Contraseña")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar_Variables()
        TimerCerrar.Start()
    End Sub
End Class