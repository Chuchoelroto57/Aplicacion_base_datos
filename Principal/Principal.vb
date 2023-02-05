'Librerias para mover
Imports System.Runtime.InteropServices

Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelNombre.Text = Iniciar_Sesion.Nombre_Usuario
        LabelCiudad.Text = Iniciar_Sesion.Ciudad_Usuario
        LabelCorreo.Text = Iniciar_Sesion.Correo_Usuario
        LabelEdad.Text = Iniciar_Sesion.Edad_Usuario
        LabelGenero.Text = Iniciar_Sesion.Genero_Usuario


        ButtonInicio.FlatAppearance.BorderSize = 2
        ButtonInicio.FlatAppearance.BorderColor = Color.Black

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

    Private Sub PanelBarradeTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarradeTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelMenuLateral_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenuLateral.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Application.Exit()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim LocalizacionX As Integer  '//Aqui se guarda la localización X del formulario
    Dim LocalizacionY As Integer '//Aqui se guarda la localizacion Y del formulario
    Dim TamañoAnchura As Integer '// Aqui el ancho
    Dim TamañoAltura As Integer '// Aqui lo alto
    Private Sub Maximizar_Ventana()

        Me.LocalizacionX = Me.Location.X
        Me.LocalizacionY = Me.Location.Y
        Me.TamañoAnchura = Me.Size.Height
        Me.TamañoAltura = Me.Size.Width

        ButtonAgrandar.Visible = False
        ButtonRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location




    End Sub

    Private Sub ButtonAgrandar_Click(sender As Object, e As EventArgs) Handles ButtonAgrandar.Click

        Maximizar_Ventana()

    End Sub

    Private Sub ButtonRestaurar_Click(sender As Object, e As EventArgs) Handles ButtonRestaurar.Click

        Me.Size = New Size(TamañoAltura, TamañoAnchura)
        Me.Location = New Point(LocalizacionX, LocalizacionY)

        ButtonAgrandar.Visible = True
        ButtonRestaurar.Visible = False

    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick

        LabelHora.Text = DateTime.Now.ToString("HH:mm:ss")
        LabelFecha.Text = DateTime.Now.ToLongDateString

    End Sub

    '// Proceso para abrir formularios dentro del panel contenedor

    Dim FormularioActivo As Form = Nothing

    Sub Abrir_Formulario_Contenedor(ByVal FormularioHijo As Form)
        If FormularioActivo IsNot Nothing Then '// Si hay algo abierto

            FormularioActivo.Close()

        End If
        FormularioActivo = FormularioHijo '// El formuñlario que se abre pasa a ser el activo
        FormularioHijo.TopLevel = False '// Esto permite trabajar con todos los formularios a la vez
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill   '//Toma el tamaño del panel contenedor
        PanelContenedor.Controls.Add(FormularioHijo) '// Agrega el formulario deseado
        PanelContenedor.Tag = FormularioHijo 'Permite rabajar de manera simultanea con las demas cosas
        FormularioHijo.BringToFront() '// Encia el formulario a la parte frontal
        FormularioHijo.Show()

    End Sub

    Private Sub ButtonMaterias_Click(sender As Object, e As EventArgs) Handles ButtonMaterias.Click
        Regresar_Colores_Botones()
        Abrir_Formulario_Contenedor(New Materias)
        ButtonMaterias.FlatAppearance.BorderSize = 1
        ButtonMaterias.FlatAppearance.BorderColor = Color.Black




    End Sub

    Private Sub ButtonAlumnos_Click(sender As Object, e As EventArgs) Handles ButtonAlumnos.Click
        Regresar_Colores_Botones()
        Abrir_Formulario_Contenedor(New Alumnos)
        ButtonAlumnos.FlatAppearance.BorderSize = 1
        ButtonAlumnos.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Regresar_Colores_Botones()
        ButtonInicio.FlatAppearance.BorderSize = 0
        ButtonInicio.FlatAppearance.BorderColor = Color.Silver

        ButtonAlumnos.FlatAppearance.BorderSize = 0
        ButtonAlumnos.FlatAppearance.BorderColor = Color.Silver

        ButtonMaterias.FlatAppearance.BorderSize = 0
        ButtonMaterias.FlatAppearance.BorderColor = Color.Silver

        ButtonProductos.FlatAppearance.BorderSize = 0
        ButtonProductos.FlatAppearance.BorderColor = Color.Silver

        ButtonDocentes.FlatAppearance.BorderSize = 0
        ButtonDocentes.FlatAppearance.BorderColor = Color.Silver

        ButtonLibros.FlatAppearance.BorderSize = 0
        ButtonLibros.FlatAppearance.BorderColor = Color.Silver

        ButtonMusica.FlatAppearance.BorderSize = 0
        ButtonMusica.FlatAppearance.BorderColor = Color.Silver

    End Sub

    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        If FormularioActivo IsNot Nothing Then '//

            FormularioActivo.Close()

        End If
        Regresar_Colores_Botones()
        ButtonInicio.FlatAppearance.BorderSize = 2
        ButtonInicio.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        Regresar_Colores_Botones()
        Abrir_Formulario_Contenedor(New Producto_Farmaceuticos)
        ButtonAlumnos.FlatAppearance.BorderSize = 1
        ButtonAlumnos.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ButtonDocentes_Click(sender As Object, e As EventArgs) Handles ButtonDocentes.Click
        Regresar_Colores_Botones()
        Abrir_Formulario_Contenedor(New Docentes)
        ButtonDocentes.FlatAppearance.BorderSize = 1
        ButtonDocentes.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ButtonLibros_Click(sender As Object, e As EventArgs) Handles ButtonLibros.Click
        Regresar_Colores_Botones()
        Abrir_Formulario_Contenedor(New Libros)
        ButtonLibros.FlatAppearance.BorderSize = 1
        ButtonLibros.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub ButtonMusica_Click(sender As Object, e As EventArgs) Handles ButtonMusica.Click
        Regresar_Colores_Botones()
        Abrir_Formulario_Contenedor(New Album_Musica)
        ButtonMusica.FlatAppearance.BorderSize = 1
        ButtonMusica.FlatAppearance.BorderColor = Color.Black
    End Sub

End Class