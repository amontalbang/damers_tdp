<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CapacityTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.PriceHTextBox = New System.Windows.Forms.TextBox()
        Me.PriceMTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CradleCheckBox = New System.Windows.Forms.CheckBox()
        Me.AnimalsCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Elephant", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(180, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 26)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Habitación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 51)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Actualizar"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label3.Location = New System.Drawing.Point(555, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 36)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "PRECIO NOCHE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(temporada)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(497, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 25)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Baja:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(481, 458)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Media:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(503, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 25)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Alta:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(87, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Capacidad:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(148, 409)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Tipo:"
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CapacityTextBox.Location = New System.Drawing.Point(225, 459)
        Me.CapacityTextBox.MaximumSize = New System.Drawing.Size(216, 20)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(216, 20)
        Me.CapacityTextBox.TabIndex = 61
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TypeTextBox.Location = New System.Drawing.Point(225, 414)
        Me.TypeTextBox.MaximumSize = New System.Drawing.Size(216, 20)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(216, 20)
        Me.TypeTextBox.TabIndex = 60
        '
        'PriceHTextBox
        '
        Me.PriceHTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceHTextBox.Location = New System.Drawing.Point(591, 414)
        Me.PriceHTextBox.MaximumSize = New System.Drawing.Size(115, 20)
        Me.PriceHTextBox.Name = "PriceHTextBox"
        Me.PriceHTextBox.Size = New System.Drawing.Size(115, 20)
        Me.PriceHTextBox.TabIndex = 59
        '
        'PriceMTextBox
        '
        Me.PriceMTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceMTextBox.Location = New System.Drawing.Point(591, 458)
        Me.PriceMTextBox.MaximumSize = New System.Drawing.Size(115, 20)
        Me.PriceMTextBox.Name = "PriceMTextBox"
        Me.PriceMTextBox.Size = New System.Drawing.Size(115, 20)
        Me.PriceMTextBox.TabIndex = 58
        '
        'PriceLTextBox
        '
        Me.PriceLTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceLTextBox.Location = New System.Drawing.Point(591, 504)
        Me.PriceLTextBox.MaximumSize = New System.Drawing.Size(115, 20)
        Me.PriceLTextBox.Name = "PriceLTextBox"
        Me.PriceLTextBox.Size = New System.Drawing.Size(115, 20)
        Me.PriceLTextBox.TabIndex = 57
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(331, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 40
        Me.DataGridView1.Size = New System.Drawing.Size(794, 165)
        Me.DataGridView1.TabIndex = 85
        '
        'CradleCheckBox
        '
        Me.CradleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CradleCheckBox.AutoSize = True
        Me.CradleCheckBox.Location = New System.Drawing.Point(340, 514)
        Me.CradleCheckBox.MaximumSize = New System.Drawing.Size(15, 14)
        Me.CradleCheckBox.Name = "CradleCheckBox"
        Me.CradleCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CradleCheckBox.TabIndex = 89
        Me.CradleCheckBox.UseVisualStyleBackColor = True
        '
        'AnimalsCheckBox
        '
        Me.AnimalsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AnimalsCheckBox.AutoSize = True
        Me.AnimalsCheckBox.Location = New System.Drawing.Point(214, 512)
        Me.AnimalsCheckBox.MaximumSize = New System.Drawing.Size(15, 14)
        Me.AnimalsCheckBox.Name = "AnimalsCheckBox"
        Me.AnimalsCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.AnimalsCheckBox.TabIndex = 88
        Me.AnimalsCheckBox.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(102, 503)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 25)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Animales:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(265, 505)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Cuna:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label11.Location = New System.Drawing.Point(300, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 25)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Número hab.:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label12.Location = New System.Drawing.Point(447, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 25)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = " "
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 622)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CradleCheckBox)
        Me.Controls.Add(Me.AnimalsCheckBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CapacityTextBox)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.PriceHTextBox)
        Me.Controls.Add(Me.PriceMTextBox)
        Me.Controls.Add(Me.PriceLTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form10"
        Me.Text = "HotelSOL"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CapacityTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents PriceHTextBox As TextBox
    Friend WithEvents PriceMTextBox As TextBox
    Friend WithEvents PriceLTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CradleCheckBox As CheckBox
    Friend WithEvents AnimalsCheckBox As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
