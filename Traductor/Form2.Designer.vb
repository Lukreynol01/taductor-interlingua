<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspanolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterlinguaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PluralfemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PluralmascDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MorfologiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EspIntBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Traduccion_Esp_Int2DataSet = New Traductor.Traduccion_Esp_Int2DataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Esp_IntTableAdapter = New Traductor.Traduccion_Esp_Int2DataSetTableAdapters.Esp_IntTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspIntBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Traduccion_Esp_Int2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EspanolDataGridViewTextBoxColumn, Me.InterlinguaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.PluralfemDataGridViewTextBoxColumn, Me.PluralmascDataGridViewTextBoxColumn, Me.MorfologiaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EspIntBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(474, 174)
        Me.DataGridView1.TabIndex = 9
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'EspanolDataGridViewTextBoxColumn
        '
        Me.EspanolDataGridViewTextBoxColumn.DataPropertyName = "Espanol"
        Me.EspanolDataGridViewTextBoxColumn.HeaderText = "Español"
        Me.EspanolDataGridViewTextBoxColumn.Name = "EspanolDataGridViewTextBoxColumn"
        '
        'InterlinguaDataGridViewTextBoxColumn
        '
        Me.InterlinguaDataGridViewTextBoxColumn.DataPropertyName = "Interlingua"
        Me.InterlinguaDataGridViewTextBoxColumn.HeaderText = "Interlingua"
        Me.InterlinguaDataGridViewTextBoxColumn.Name = "InterlinguaDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Sustantivo", "Pronombre", "Adjetivo", "Verbo", "Adverbio", "Preposición", "Determinante", "Conjunción", "Interjección"})
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PluralfemDataGridViewTextBoxColumn
        '
        Me.PluralfemDataGridViewTextBoxColumn.DataPropertyName = "Plural_fem"
        Me.PluralfemDataGridViewTextBoxColumn.HeaderText = "Plural Femenino"
        Me.PluralfemDataGridViewTextBoxColumn.Name = "PluralfemDataGridViewTextBoxColumn"
        '
        'PluralmascDataGridViewTextBoxColumn
        '
        Me.PluralmascDataGridViewTextBoxColumn.DataPropertyName = "Plural_masc"
        Me.PluralmascDataGridViewTextBoxColumn.HeaderText = "Plural Masculino"
        Me.PluralmascDataGridViewTextBoxColumn.Name = "PluralmascDataGridViewTextBoxColumn"
        '
        'MorfologiaDataGridViewTextBoxColumn
        '
        Me.MorfologiaDataGridViewTextBoxColumn.DataPropertyName = "Morfologia"
        Me.MorfologiaDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MorfologiaDataGridViewTextBoxColumn.HeaderText = "Morfología"
        Me.MorfologiaDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Lexema o raíz", "Prefijo", "Sufijo", "Interfijo", "Morfema de número", "Morfema de género", "Desinencia verbal"})
        Me.MorfologiaDataGridViewTextBoxColumn.Name = "MorfologiaDataGridViewTextBoxColumn"
        Me.MorfologiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MorfologiaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'EspIntBindingSource
        '
        Me.EspIntBindingSource.DataMember = "Esp_Int"
        Me.EspIntBindingSource.DataSource = Me.Traduccion_Esp_Int2DataSet
        '
        'Traduccion_Esp_Int2DataSet
        '
        Me.Traduccion_Esp_Int2DataSet.DataSetName = "Traduccion_Esp_Int2DataSet"
        Me.Traduccion_Esp_Int2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Español"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Interlingua"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 46)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Esp_IntTableAdapter
        '
        Me.Esp_IntTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 44)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Reordenar tabla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(101, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 44)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(391, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 94)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "GUARDAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(306, 74)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 46)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 310)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edición de Diccionario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspIntBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Traduccion_Esp_Int2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Traduccion_Esp_Int2DataSet As Traduccion_Esp_Int2DataSet
    Friend WithEvents EspIntBindingSource As BindingSource
    Friend WithEvents Esp_IntTableAdapter As Traduccion_Esp_Int2DataSetTableAdapters.Esp_IntTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspanolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterlinguaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents PluralfemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PluralmascDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MorfologiaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
