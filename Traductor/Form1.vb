
Public Class Form1

    Dim Tabla As New DataTable()



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Traduccion_Esp_Int2DataSet.Esp_Int' Puede moverla o quitarla según sea necesario.
        'Me.Table_TradTableAdapter.Fill(Me.dbTraductorDataSet.Esp_Int)
        '-> Settings
        'Tabla.Columns.Add("Length")
        'Tabla.Columns.Add("Español")
        'Tabla.Columns.Add("Interlingua")

        '-> Rellenar la Tabla con los datos del DataBase.txt
        'Try
        '    Dim DataBase As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\DataBasex2.txt", System.Text.Encoding.UTF7)
        '    Dim row As String() = {}
        '    For Each i In DataBase.Split(vbCrLf)
        '        i = i.Trim(vbLf)
        '        If i = "" Then Continue For
        '        row = i.Split("=")
        '        Tabla.Rows.Add(row(0).Length, row(0), row(1))
        '    Next
        '    Dim dataView As New DataView(Tabla) With {.Sort = "Length DESC"}
        '    Tabla = dataView.ToTable()
        '    Tabla.Columns.RemoveAt(0)
        '    'DataGridView1.DataSource = Tabla
        'Catch
        '    MessageBox.Show("Posible error de base de datos", "My Application",
        '    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        'End Try

    End Sub

    Private Sub Traducir() Handles Button1.Click


        Dim Buffer As New System.Text.StringBuilder(TextBox1.Text)
        Dim ColumnHeader1 As Integer = 0
        Dim ColumnHeader2 As Integer = 0
        Me.Table_TradTableAdapter.Fill(Me.dbTraductorDataSet.Esp_Int)
        'Me.Table_TradTableAdapter.Update(Me.dbTraductorDataSet.Esp_Int)
        'Dim Buffer As String = TextBox1.Text
        If ComboBox1.SelectedIndex = 0 Then
            ColumnHeader1 = 1
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ColumnHeader1 = 2
        End If
        If ComboBox2.SelectedIndex = 0 Then
            ColumnHeader2 = 1
        ElseIf ComboBox2.SelectedIndex = 1 Then
            ColumnHeader2 = 2
        End If

        For i = 0 To Me.dbTraductorDataSet.Esp_Int.Rows.Count - 1

            Dim p1 As String = Me.dbTraductorDataSet.Esp_Int.Rows(i)(ColumnHeader1)
            Dim p2 As String = Me.dbTraductorDataSet.Esp_Int.Rows(i)(ColumnHeader2)

            Buffer = Buffer.Replace(" " & p1.Trim(vbLf) & " ", " " & p2.Trim(vbLf) & " ") _
            .Replace(" " & p1.Trim(vbLf) & ", ", " " & p2.Trim(vbLf) & ", ") _
            .Replace(" " & p1.Trim(vbLf) & ". ", " " & p2.Trim(vbLf) & ". ") _
            .Replace(" " & p1.Trim(vbLf) & ": ", " " & p2.Trim(vbLf) & ": ") _
            .Replace(" '" & p1.Trim(vbLf) & "' ", " '" & p2.Trim(vbLf) & "'") _
            .Replace(" !" & p1.Trim(vbLf) & "¡ ", " !" & p2.Trim(vbLf) & "¡ ") _
            .Replace(" ¿" & p1.Trim(vbLf) & "? ", " ¿" & p2.Trim(vbLf) & "?") _
            .Replace(Chr(34) & p1.Trim(vbLf) & Chr(34), Chr(34) & p2.Trim(vbLf) & Chr(34)) _
            .Replace(StrConv(p1.Trim(vbLf), VbStrConv.ProperCase), StrConv(p2.Trim(vbLf), VbStrConv.ProperCase))

        Next
        TextBox2.Text = Buffer.ToString()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ComboBox1.SelectedIndex = ComboBox1.SelectedIndex Xor 1
        ComboBox2.SelectedIndex = ComboBox2.SelectedIndex Xor 1
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Form2.Show()
    End Sub

    Private Sub DiccionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiccionarioToolStripMenuItem.Click


        Form2.Show()
    End Sub



    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Refresh()
        'Me.dbTraductorDataSet.Esp_Int.Refresh()
        Me.Table_TradTableAdapter.Fill(Me.dbTraductorDataSet.Esp_Int)
        Me.Table_TradTableAdapter.Update(Me.dbTraductorDataSet.Esp_Int)
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.SelectAll()
    End Sub

    Private Sub RestaurarBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarBaseDeDatosToolStripMenuItem.Click

        Dim caption As String = "Restaurar copia de seguridad"
        Dim dr As DialogResult =
            MessageBox.Show("¿Desea restaurar la copia de seguridad?",
                            caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If (dr <> DialogResult.Yes) Then
            ' No se desea restaurar la copia de seguridad;
            ' Abandonar el procedimiento sin más.
            Return
        End If

        Try
            ' Procedemos a restaurar la copia de seguridad, por lo que
            ' se sobrescribirá la base de datos del sistema.
            '

            Restore(caption)
            MessageBox.Show("Se ha restaurado satisfactoriamente la copia de seguridad.",
                            caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Se ha producido un error
            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub RespaldarBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarBaseDeDatosToolStripMenuItem.Click
        Dim caption As String = "Copia de seguridad"
        Dim dr As DialogResult =
            MessageBox.Show("¿Desea crear una copia de seguridad de la base del sistema?",
                            caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If (dr <> DialogResult.Yes) Then
            ' No se desea crear la copia de seguridad;
            ' Abandonar el procedimiento sin más.
            Return
        End If

        Try
            dr = BackUp(caption)

            Dim msg As String = String.Empty

            If (dr = DialogResult.OK) Then
                msg = "Se ha realizado satisfactoriamente la copia de seguridad."

            Else
                msg = "Se ha cancelado la operación."

            End If

            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Se ha producido un error
            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub




    Private Function BackUp(caption As String) As DialogResult

        ' Ruta de la base de datos del sistema.
        Dim baseSistema As String = IO.Path.Combine(Application.StartupPath, "Traduccion_Esp_Int2.mdb")

        ' Ruta de la copia de seguridad de la base de datos del sistema.
        Dim copiaBase As String = IO.Path.Combine(Application.StartupPath, "BackUp", "Back_Traduccion_Esp_Int2.mdb")

        If (IO.File.Exists(copiaBase)) Then
            Dim msg As String = "Ya existe un archivo de copia de seguridad. ¿Desea sobrescribirlo?"
            Dim dr As DialogResult = MessageBox.Show(msg, caption,
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If (dr <> DialogResult.Yes) Then
                ' No se desea sobrescribir el archivo existente;
                ' cancelamos la operación de BackUp.
                Return DialogResult.Cancel
            End If
        End If

        ' Si no existe la carpeta de BackUp la creamos.
        '
        Dim path As String = IO.Path.GetDirectoryName(copiaBase)
        If (Not IO.Directory.Exists(path)) Then
            IO.Directory.CreateDirectory(path)
        End If

        ' Procedemos a realizar la copia de seguridad,
        ' sobrescribiendo el archivo existente.
        '
        IO.File.Copy(baseSistema, copiaBase, True)

        ' Indicamos que la copia de seguridad se ha efectuado.
        Return DialogResult.OK

    End Function

    Private Sub Restore(caption As String)

        ' Ruta de la copia de seguridad de la base de datos del sistema.
        Dim copiaBase As String = IO.Path.Combine(Application.StartupPath, "BackUp", "Back_Traduccion_Esp_Int2.mdb")
        If (Not IO.File.Exists(copiaBase)) Then
            Throw New IO.FileNotFoundException("No existe ningún archivo de copia de seguridad.")
        End If

        ' Ruta de la base de datos del sistema.
        Dim baseSistema As String = IO.Path.Combine(Application.StartupPath, "Traduccion_Esp_Int2.mdb")

        ' Procedemos a restaurar la copia de seguridad,
        ' sobrescribiendo la base de datos del sistema.
        '
        IO.File.Copy(copiaBase, baseSistema, True)

    End Sub

    Private Sub VerSiHayCopiaDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSiHayCopiaDeSeguridadToolStripMenuItem.Click
        Dim folder As String = String.Empty
        Using browser As New FolderBrowserDialog()

            browser.Description = "Seleccione el directorio de copia de seguridad."

            ' Por defecto seleccionamos la carpeta de la aplicación.
            browser.SelectedPath = Application.StartupPath

            Dim dr As DialogResult = browser.ShowDialog()
            If (dr <> DialogResult.OK) Then
                ' Se ha cancelado el cuadro de diálogo.
                Return
            End If

            folder = browser.SelectedPath

        End Using
    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Form3.Show()
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        CheckForUpdates()

    End Sub
    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://interlingua-translate.000webhostapp.com/Update.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("Tienes la última versión!")
        Else
            Dialog1.Show()
        End If



    End Sub
End Class
