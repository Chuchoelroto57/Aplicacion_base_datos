
Imports System.Runtime.InteropServices
Public Class Bienvenida
    Private Sub LabelTitulo_Click(sender As Object, e As EventArgs) Handles LabelTitulo.Click

    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Iniciar_Sesion.Show()
        Me.Close()
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

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNombre.Text = Iniciar_Sesion.Nombre_Usuario
        LabelCiudad.Text = Iniciar_Sesion.Ciudad_Usuario
        LabelCorreo.Text = Iniciar_Sesion.Correo_Usuario
        LabelEdad.Text = Iniciar_Sesion.Edad_Usuario
        LabelGenero.Text = Iniciar_Sesion.Genero_Usuario


        Me.Opacity = 0
        Barra_Carga_Bienvenida.Value = 0
        TimerAbrir.Start()

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        '----------------------------MENSAJE DE CONFIRMACIÓN--------------------'
        MsgBox("Su contraseña es: " & Iniciar_Sesion.Contraseña_Usuario, MsgBoxStyle.OkOnly, "Bienvenida")

    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick

        '// Valores de una barra de carde 0 a 100
        Barra_Carga_Bienvenida.Value += 2
        Label_Carga.Text = Barra_Carga_Bienvenida.Value & "%"

        '// La opacidad se mide de 0 a 1

        If Me.Opacity < 1 Then '// Aqui el formulario no es visible

            Me.Opacity += 0.05

        End If

        If Barra_Carga_Bienvenida.Value = 100 Then
            TimerAbrir.Stop()
            TimerCerrar.Start()
        End If
    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick

        Me.Opacity -= 0.1

        If Opacity = 0 Then
            TimerCerrar.Stop()
            Me.Close()
        End If

    End Sub

End Class