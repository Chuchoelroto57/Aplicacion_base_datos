Public Class Materias
    Private Sub Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxFacultad.Text = "Selecciona Facultad"
        ComboBoxSemestre.Text = "Selecciona Semestre"
        Reiniciar_Valores()
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Try

            If TextBoxID.Text = Nothing Or
                TextBoxDescripcion.Text = Nothing Or
                TextBoxNombre.Text = Nothing Or
                ComboBoxFacultad.Text = "Selecciona Facultad" Or
                ComboBoxSemestre.Text = "Selecciona Semestre" Then

                MsgBox("Existen espacios en blanco, CHECALO!!!", MsgBoxStyle.Critical, "Materias")

            Else

                DataGridMaterias.Rows.Add(TextBoxID.Text, TextBoxNombre.Text, ComboBoxSemestre.Text, TextBoxDescripcion.Text, ComboBoxFacultad.Text)
                Reiniciar_Valores()

            End If

        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ComboBoxSemestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxSemestre.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub ComboBoxFacultad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxFacultad.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Reiniciar_Valores()
        TextBoxID.Clear()
        TextBoxDescripcion.Clear()
        TextBoxNombre.Clear()
        ComboBoxSemestre.Text = "Selecciona a semestre"
        ComboBoxFacultad.Text = "Selecciona Facultad"
        DataGridMaterias.ClearSelection()
        TextBoxTotal.Text = DataGridMaterias.Rows.Count
    End Sub

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        Reiniciar_Valores()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Try

            If DataGridMaterias.SelectedRows.Count = 0 Then

                MsgBox("No existen filas seleccionadas, CHECALO!!!", MsgBoxStyle.Critical, "Materias")

            Else

                DataGridMaterias.Rows.Remove(DataGridMaterias.CurrentRow)
                Reiniciar_Valores()

            End If






        Catch ex As Exception
            MsgBox("Error de Operacion: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class