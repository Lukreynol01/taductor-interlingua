
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

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Form3.Show()
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
End Class
