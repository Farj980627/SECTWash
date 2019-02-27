<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gpPaquetes = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtNewPrecio = New System.Windows.Forms.TextBox()
        Me.txtNewNombre = New System.Windows.Forms.TextBox()
        Me.lblNewPrecio = New System.Windows.Forms.Label()
        Me.lblNewNombre = New System.Windows.Forms.Label()
        Me.lblPaquete = New System.Windows.Forms.Label()
        Me.cbPaquetes = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDelPaquete = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gpPaquetes.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1145, 654)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gpPaquetes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1137, 625)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Actualizar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gpPaquetes
        '
        Me.gpPaquetes.Controls.Add(Me.btnActualizar)
        Me.gpPaquetes.Controls.Add(Me.txtNewPrecio)
        Me.gpPaquetes.Controls.Add(Me.txtNewNombre)
        Me.gpPaquetes.Controls.Add(Me.lblNewPrecio)
        Me.gpPaquetes.Controls.Add(Me.lblNewNombre)
        Me.gpPaquetes.Controls.Add(Me.lblPaquete)
        Me.gpPaquetes.Controls.Add(Me.cbPaquetes)
        Me.gpPaquetes.Location = New System.Drawing.Point(24, 59)
        Me.gpPaquetes.Name = "gpPaquetes"
        Me.gpPaquetes.Size = New System.Drawing.Size(532, 227)
        Me.gpPaquetes.TabIndex = 1
        Me.gpPaquetes.TabStop = False
        Me.gpPaquetes.Text = "Modificar Paquetes"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(409, 192)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(96, 29)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtNewPrecio
        '
        Me.txtNewPrecio.Location = New System.Drawing.Point(199, 152)
        Me.txtNewPrecio.Name = "txtNewPrecio"
        Me.txtNewPrecio.Size = New System.Drawing.Size(121, 22)
        Me.txtNewPrecio.TabIndex = 5
        '
        'txtNewNombre
        '
        Me.txtNewNombre.Location = New System.Drawing.Point(199, 100)
        Me.txtNewNombre.Name = "txtNewNombre"
        Me.txtNewNombre.Size = New System.Drawing.Size(121, 22)
        Me.txtNewNombre.TabIndex = 4
        '
        'lblNewPrecio
        '
        Me.lblNewPrecio.AutoSize = True
        Me.lblNewPrecio.Location = New System.Drawing.Point(65, 152)
        Me.lblNewPrecio.Name = "lblNewPrecio"
        Me.lblNewPrecio.Size = New System.Drawing.Size(93, 17)
        Me.lblNewPrecio.TabIndex = 3
        Me.lblNewPrecio.Text = "Nuevo Precio"
        '
        'lblNewNombre
        '
        Me.lblNewNombre.AutoSize = True
        Me.lblNewNombre.Location = New System.Drawing.Point(65, 100)
        Me.lblNewNombre.Name = "lblNewNombre"
        Me.lblNewNombre.Size = New System.Drawing.Size(103, 17)
        Me.lblNewNombre.TabIndex = 2
        Me.lblNewNombre.Text = "Nuevo Nombre"
        '
        'lblPaquete
        '
        Me.lblPaquete.AutoSize = True
        Me.lblPaquete.Location = New System.Drawing.Point(65, 44)
        Me.lblPaquete.Name = "lblPaquete"
        Me.lblPaquete.Size = New System.Drawing.Size(65, 17)
        Me.lblPaquete.TabIndex = 1
        Me.lblPaquete.Text = "Paquete:"
        '
        'cbPaquetes
        '
        Me.cbPaquetes.FormattingEnabled = True
        Me.cbPaquetes.Location = New System.Drawing.Point(199, 41)
        Me.cbPaquetes.Name = "cbPaquetes"
        Me.cbPaquetes.Size = New System.Drawing.Size(121, 24)
        Me.cbPaquetes.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1137, 625)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCrear)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 227)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Paquete"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(385, 182)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(96, 29)
        Me.btnCrear.TabIndex = 6
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(199, 120)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(121, 22)
        Me.txtPrecio.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(199, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 22)
        Me.txtNombre.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1137, 625)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Eliminar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbDelPaquete)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 227)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrar Paquete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Paquete:"
        '
        'cbDelPaquete
        '
        Me.cbDelPaquete.FormattingEnabled = True
        Me.cbDelPaquete.Location = New System.Drawing.Point(207, 68)
        Me.cbDelPaquete.Name = "cbDelPaquete"
        Me.cbDelPaquete.Size = New System.Drawing.Size(121, 24)
        Me.cbDelPaquete.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 678)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gpPaquetes.ResumeLayout(False)
        Me.gpPaquetes.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gpPaquetes As GroupBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtNewPrecio As TextBox
    Friend WithEvents txtNewNombre As TextBox
    Friend WithEvents lblNewPrecio As Label
    Friend WithEvents lblNewNombre As Label
    Friend WithEvents lblPaquete As Label
    Friend WithEvents cbPaquetes As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDelPaquete As ComboBox
    Friend WithEvents Button1 As Button
End Class
