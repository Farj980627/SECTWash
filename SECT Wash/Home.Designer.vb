<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.cbPaquetes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdministrador = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdministrador)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.btnVender)
        Me.Panel1.Controls.Add(Me.cbPaquetes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 662)
        Me.Panel1.TabIndex = 0
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(559, 48)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(65, 17)
        Me.lblPrecio.TabIndex = 3
        Me.lblPrecio.Text = "precio D:"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(562, 125)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(107, 31)
        Me.btnVender.TabIndex = 2
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'cbPaquetes
        '
        Me.cbPaquetes.FormattingEnabled = True
        Me.cbPaquetes.Location = New System.Drawing.Point(92, 41)
        Me.cbPaquetes.Name = "cbPaquetes"
        Me.cbPaquetes.Size = New System.Drawing.Size(229, 24)
        Me.cbPaquetes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paquete: "
        '
        'btnAdministrador
        '
        Me.btnAdministrador.Location = New System.Drawing.Point(1125, 14)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(137, 51)
        Me.btnAdministrador.TabIndex = 4
        Me.btnAdministrador.Text = "Configuraciones Avanzadas"
        Me.btnAdministrador.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 686)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents cbPaquetes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdministrador As Button
End Class
