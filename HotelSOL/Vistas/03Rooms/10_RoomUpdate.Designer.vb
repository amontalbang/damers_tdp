﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumHabTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(540, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 25)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Baja:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(524, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Media:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(546, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 25)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Alta:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(87, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Capacidad:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(148, 453)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Tipo:"
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CapacityTextBox.Location = New System.Drawing.Point(225, 503)
        Me.CapacityTextBox.MaximumSize = New System.Drawing.Size(216, 20)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(216, 20)
        Me.CapacityTextBox.TabIndex = 61
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TypeTextBox.Location = New System.Drawing.Point(225, 458)
        Me.TypeTextBox.MaximumSize = New System.Drawing.Size(216, 20)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(216, 20)
        Me.TypeTextBox.TabIndex = 60
        '
        'PriceHTextBox
        '
        Me.PriceHTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PriceHTextBox.Location = New System.Drawing.Point(607, 415)
        Me.PriceHTextBox.MaximumSize = New System.Drawing.Size(115, 20)
        Me.PriceHTextBox.Name = "PriceHTextBox"
        Me.PriceHTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PriceHTextBox.TabIndex = 59
        '
        'PriceMTextBox
        '
        Me.PriceMTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PriceMTextBox.Location = New System.Drawing.Point(607, 459)
        Me.PriceMTextBox.MaximumSize = New System.Drawing.Size(115, 20)
        Me.PriceMTextBox.Name = "PriceMTextBox"
        Me.PriceMTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PriceMTextBox.TabIndex = 58
        '
        'PriceLTextBox
        '
        Me.PriceLTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PriceLTextBox.Location = New System.Drawing.Point(607, 505)
        Me.PriceLTextBox.MaximumSize = New System.Drawing.Size(115, 20)
        Me.PriceLTextBox.Name = "PriceLTextBox"
        Me.PriceLTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PriceLTextBox.TabIndex = 57
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 40
        Me.DataGridView1.Size = New System.Drawing.Size(794, 167)
        Me.DataGridView1.TabIndex = 85
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(67, 409)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 25)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Número hab.:"
        '
        'NumHabTextBox
        '
        Me.NumHabTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NumHabTextBox.Location = New System.Drawing.Point(225, 414)
        Me.NumHabTextBox.MaximumSize = New System.Drawing.Size(216, 20)
        Me.NumHabTextBox.Name = "NumHabTextBox"
        Me.NumHabTextBox.Size = New System.Drawing.Size(216, 20)
        Me.NumHabTextBox.TabIndex = 93
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(683, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 25)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "€"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(683, 459)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 25)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "€"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(683, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 25)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "€"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 167)
        Me.Panel1.TabIndex = 98
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 622)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumHabTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
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
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumHabTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
End Class
