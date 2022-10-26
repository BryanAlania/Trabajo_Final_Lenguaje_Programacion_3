Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Cerrar la aplicacion,¿Desea salir?  ", vbYesNo, "Salir del sistema")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub

        End If

    End Sub
End Class
