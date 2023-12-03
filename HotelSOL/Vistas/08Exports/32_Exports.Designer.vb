<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _32_Exports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_32_Exports))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Elephant", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(379, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 51)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Exportar/Importar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(225, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 33
        Me.ListBox1.Items.AddRange(New Object() {"Clientes", "Usuarios", "Habitaciones", "Servicios", "Facturas", "Reservas"})
        Me.ListBox1.Location = New System.Drawing.Point(195, 342)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(191, 202)
        Me.ListBox1.TabIndex = 39
        '
        'SelectButton
        '
        Me.SelectButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SelectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.SelectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectButton.ForeColor = System.Drawing.Color.White
        Me.SelectButton.Location = New System.Drawing.Point(463, 371)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(153, 37)
        Me.SelectButton.TabIndex = 40
        Me.SelectButton.Text = "Exportar datos"
        Me.SelectButton.UseVisualStyleBackColor = False
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImportButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ImportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportButton.ForeColor = System.Drawing.Color.White
        Me.ImportButton.Location = New System.Drawing.Point(463, 443)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(153, 37)
        Me.ImportButton.TabIndex = 41
        Me.ImportButton.Text = "Importar datos"
        Me.ImportButton.UseVisualStyleBackColor = False
        '
        '_32_Exports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 622)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "_32_Exports"
        Me.Text = "HotelSOL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SelectButton As Button
    Friend WithEvents ImportButton As Button
End Class
