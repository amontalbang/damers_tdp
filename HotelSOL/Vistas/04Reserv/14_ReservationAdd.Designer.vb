<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BoardTextBox = New System.Windows.Forms.TextBox()
        Me.ClientIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RoomIdTextBox = New System.Windows.Forms.TextBox()
        Me.DepartureDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EntryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Elephant", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(139, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 26)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Reserva"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 51)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Añadir"
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
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(170, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Núm. hab.:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(175, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "ID Cliente:"
        '
        'BoardTextBox
        '
        Me.BoardTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BoardTextBox.Location = New System.Drawing.Point(331, 294)
        Me.BoardTextBox.MaximumSize = New System.Drawing.Size(300, 20)
        Me.BoardTextBox.MinimumSize = New System.Drawing.Size(300, 20)
        Me.BoardTextBox.Name = "BoardTextBox"
        Me.BoardTextBox.Size = New System.Drawing.Size(300, 20)
        Me.BoardTextBox.TabIndex = 62
        '
        'ClientIdTextBox
        '
        Me.ClientIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClientIdTextBox.Location = New System.Drawing.Point(331, 194)
        Me.ClientIdTextBox.MaximumSize = New System.Drawing.Size(300, 20)
        Me.ClientIdTextBox.MinimumSize = New System.Drawing.Size(300, 20)
        Me.ClientIdTextBox.Name = "ClientIdTextBox"
        Me.ClientIdTextBox.Size = New System.Drawing.Size(300, 20)
        Me.ClientIdTextBox.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(183, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Régimen:"
        '
        'RoomIdTextBox
        '
        Me.RoomIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoomIdTextBox.Location = New System.Drawing.Point(331, 243)
        Me.RoomIdTextBox.MaximumSize = New System.Drawing.Size(300, 20)
        Me.RoomIdTextBox.MinimumSize = New System.Drawing.Size(300, 20)
        Me.RoomIdTextBox.Name = "RoomIdTextBox"
        Me.RoomIdTextBox.Size = New System.Drawing.Size(300, 20)
        Me.RoomIdTextBox.TabIndex = 75
        '
        'DepartureDatePicker
        '
        Me.DepartureDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DepartureDatePicker.Location = New System.Drawing.Point(441, 399)
        Me.DepartureDatePicker.MaximumSize = New System.Drawing.Size(158, 20)
        Me.DepartureDatePicker.MinimumSize = New System.Drawing.Size(158, 20)
        Me.DepartureDatePicker.Name = "DepartureDatePicker"
        Me.DepartureDatePicker.Size = New System.Drawing.Size(158, 20)
        Me.DepartureDatePicker.TabIndex = 80
        '
        'EntryDatePicker
        '
        Me.EntryDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EntryDatePicker.Location = New System.Drawing.Point(180, 399)
        Me.EntryDatePicker.MaximumSize = New System.Drawing.Size(158, 20)
        Me.EntryDatePicker.MinimumSize = New System.Drawing.Size(158, 20)
        Me.EntryDatePicker.Name = "EntryDatePicker"
        Me.EntryDatePicker.Size = New System.Drawing.Size(158, 20)
        Me.EntryDatePicker.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(436, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 25)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Fecha salida:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(175, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 25)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Fecha entrada:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 622)
        Me.Controls.Add(Me.DepartureDatePicker)
        Me.Controls.Add(Me.EntryDatePicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RoomIdTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BoardTextBox)
        Me.Controls.Add(Me.ClientIdTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form14"
        Me.Text = "HotelSOL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BoardTextBox As TextBox
    Friend WithEvents ClientIdTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RoomIdTextBox As TextBox
    Friend WithEvents DepartureDatePicker As DateTimePicker
    Friend WithEvents EntryDatePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
