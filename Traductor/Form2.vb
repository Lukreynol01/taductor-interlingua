Public Class Form2
    Dim index As Integer
    Dim id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id = DataGridView1.Rows.Count + 1
        Me.Traduccion_Esp_Int2DataSet.Esp_Int.Rows.Add(id, TextBox1.Text, TextBox2.Text)

        'Me.DataGridView1.ClearSelection()
        DataGridView1.Rows(Me.Traduccion_Esp_Int2DataSet.Esp_Int.Rows.Count - 1).Selected = True
        DataGridView1.FirstDisplayedScrollingRowIndex = Me.Traduccion_Esp_Int2DataSet.Esp_Int.Rows.Count - 1
        Me.DataGridView1.Refresh()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Traduccion_Esp_Int2DataSet.Esp_Int' Puede moverla o quitarla según sea necesario.
        Me.Esp_IntTableAdapter.Fill(Me.Traduccion_Esp_Int2DataSet.Esp_Int)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '' get the index of the selected datagridview row
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow

        '' show data from the selected row to textboxes
        'Try
        '    selectedRow = DataGridView1.Rows(index)
        '    Label3.Text = selectedRow.Cells(0).Value.ToString()
        '    TextBox1.Text = selectedRow.Cells(1).Value.ToString()
        '    TextBox2.Text = selectedRow.Cells(2).Value.ToString()

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.RemoveAt(index)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ordena la lista de forma alfabética
        Dim direction As System.ComponentModel.ListSortDirection
        direction = System.ComponentModel.ListSortDirection.Ascending

        DataGridView1.Sort(DataGridView1.Columns(1), direction)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            Me.Validate()
            Me.EspIntBindingSource.EndEdit()
            Me.Esp_IntTableAdapter.Update(Traduccion_Esp_Int2DataSet.Esp_Int)
            Traduccion_Esp_Int2DataSet.Esp_Int.AcceptChanges()
            MsgBox("Registro guardado")

        Catch ex As Exception
            MsgBox("La actualización ha fallado")
        End Try
    End Sub

    ' Función que retorna el índice de la fila  
    '' ''''''''''''''''''''''''''''''''''''''''''''''''''''  
    Function Buscar(
        ByVal Columna As String,
        ByVal texto As String,
        ByVal BindingSource As BindingSource) As Integer

        Try
            ' si está vacio salir y no retornar nada  
            If EspIntBindingSource.DataSource Is Nothing Then
                Return -1
            End If

            ' Ejecutar el método Find pasándole los datos  
            Dim fila As Integer = BindingSource.Find(Columna.Trim, texto)

            ' Mover el cursor a la fila obtenida  
            BindingSource.Position = fila

            ' retornar el valor  
            Return fila

            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
        ' no retornar nada  
        Return -1

    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        ' Pasar el nombre del campo por el cual buscar ,   
        ' el dato, y el BindingSource enlazado al DataGridView   
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
        If TextBox1.Text IsNot "" Then


            Dim ret As Integer = Buscar(
                                   "Espanol",
                                   TextBox1.Text.Trim,
                                   EspIntBindingSource)

            ' si no se encontró ....  
            If ret = -1 Then
                ' mostrar un mensaje  
                MsgBox("No se encontró la fila", MsgBoxStyle.Critical)
            Else
                With DataGridView1
                    ' volver a enlazar  
                    .DataSource = EspIntBindingSource
                    ' Pasarle el índice para Visualizar la fila al comienzo de la grilla  
                    .FirstDisplayedScrollingRowIndex = ret
                End With
            End If


        ElseIf TextBox2.Text IsNot "" Then
            Dim ret As Integer = Buscar(
                                   "Espanol",
                                   TextBox1.Text.Trim,
                                   EspIntBindingSource)

            ' si no se encontró ....  
            If ret = -1 Then
                ' mostrar un mensaje  
                MsgBox("No se encontró la fila", MsgBoxStyle.Critical)
            Else
                With DataGridView1
                    ' volver a enlazar  
                    .DataSource = EspIntBindingSource
                    ' Pasarle el índice para Visualizar la fila al comienzo de la grilla  
                    .FirstDisplayedScrollingRowIndex = ret
                End With
            End If
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        If Traduccion_Esp_Int2DataSet.HasChanges Then
            If MessageBox.Show("¿Hay cambios sin guardar, está seguro de cerrar formulario?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        'Dim selectedRow As DataGridViewRow

        '' show data from the selected row to textboxes
        'Try


        '    selectedRow.Cells(1) = TextBox1.Text.Value.ToString()
        '    TextBox2.Text = selectedRow.Cells(2).Value.ToString()

        'Catch ex As Exception

        'End Try
    End Sub
End Class