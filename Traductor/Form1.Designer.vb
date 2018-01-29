<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dbTraductorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbTraductorDataSet = New Traductor.Traduccion_Esp_Int2DataSet()
        Me.Table_TradTableAdapter = New Traductor.Traduccion_Esp_Int2DataSetTableAdapters.Esp_IntTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldarBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarBaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSiHayCopiaDeSeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiccionarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarActualizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EspIntBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbTraductorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbTraductorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EspIntBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(11, 90)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(353, 185)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(381, 90)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(352, 185)
        Me.TextBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "0"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Español", "Interlingua"})
        Me.ComboBox1.Location = New System.Drawing.Point(92, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Español"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "De"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(488, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "traducir a"
        '
        'ComboBox2
        '
        Me.ComboBox2.DisplayMember = "0"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Español", "Interlingua"})
        Me.ComboBox2.Location = New System.Drawing.Point(566, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.Text = "Interlingua"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(342, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(302, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "TRADUCIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dbTraductorDataSetBindingSource
        '
        Me.dbTraductorDataSetBindingSource.DataSource = Me.dbTraductorDataSet
        Me.dbTraductorDataSetBindingSource.Position = 0
        '
        'dbTraductorDataSet
        '
        Me.dbTraductorDataSet.DataSetName = "dbTraductorDataSet"
        Me.dbTraductorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_TradTableAdapter
        '
        Me.Table_TradTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(542, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Agregar palabras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.DiccionarioToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(746, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.RespaldarBaseDeDatosToolStripMenuItem, Me.RestaurarBaseDeDatosToolStripMenuItem, Me.VerSiHayCopiaDeSeguridadToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RespaldarBaseDeDatosToolStripMenuItem
        '
        Me.RespaldarBaseDeDatosToolStripMenuItem.Name = "RespaldarBaseDeDatosToolStripMenuItem"
        Me.RespaldarBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RespaldarBaseDeDatosToolStripMenuItem.Text = "Respaldar Base de Datos"
        '
        'RestaurarBaseDeDatosToolStripMenuItem
        '
        Me.RestaurarBaseDeDatosToolStripMenuItem.Name = "RestaurarBaseDeDatosToolStripMenuItem"
        Me.RestaurarBaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RestaurarBaseDeDatosToolStripMenuItem.Text = "Restaurar Base de Datos"
        '
        'VerSiHayCopiaDeSeguridadToolStripMenuItem
        '
        Me.VerSiHayCopiaDeSeguridadToolStripMenuItem.Name = "VerSiHayCopiaDeSeguridadToolStripMenuItem"
        Me.VerSiHayCopiaDeSeguridadToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.VerSiHayCopiaDeSeguridadToolStripMenuItem.Text = "Ver si hay copia de seguridad"
        '
        'DiccionarioToolStripMenuItem
        '
        Me.DiccionarioToolStripMenuItem.Name = "DiccionarioToolStripMenuItem"
        Me.DiccionarioToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.DiccionarioToolStripMenuItem.Text = "Diccionario"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1, Me.BuscarActualizacionesToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'BuscarActualizacionesToolStripMenuItem
        '
        Me.BuscarActualizacionesToolStripMenuItem.Name = "BuscarActualizacionesToolStripMenuItem"
        Me.BuscarActualizacionesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BuscarActualizacionesToolStripMenuItem.Text = "Buscar actualizaciones"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(542, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Refrescar base de datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EspIntBindingSource
        '
        Me.EspIntBindingSource.DataMember = "Esp_Int"
        Me.EspIntBindingSource.DataSource = Me.dbTraductorDataSetBindingSource
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(746, 371)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traductor Español - Interlingua"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbTraductorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbTraductorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EspIntBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dbTraductorDataSet As Traduccion_Esp_Int2DataSet
    Friend WithEvents dbTraductorDataSetBindingSource As BindingSource
    Friend WithEvents Table_TradTableAdapter As Traduccion_Esp_Int2DataSetTableAdapters.Esp_IntTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiccionarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspanolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterlinguaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PluralfemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PluralmascDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MorfologiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspIntBindingSource As BindingSource
    Friend WithEvents RespaldarBaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaurarBaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSiHayCopiaDeSeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BuscarActualizacionesToolStripMenuItem As ToolStripMenuItem
End Class
