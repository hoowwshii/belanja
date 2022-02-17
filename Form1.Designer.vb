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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txttotalharga = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEM INFORMASI BELANJA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA BARANG :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KODE BARANG :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HARGA :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "JUMLAH :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL HARGA :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10"})
        Me.ComboBox1.Location = New System.Drawing.Point(235, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(235, 163)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.ReadOnly = True
        Me.txtnamabarang.Size = New System.Drawing.Size(100, 22)
        Me.txtnamabarang.TabIndex = 7
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(235, 211)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(100, 22)
        Me.txtharga.TabIndex = 7
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(235, 256)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 22)
        Me.txtjumlah.TabIndex = 7
        '
        'txttotalharga
        '
        Me.txttotalharga.Location = New System.Drawing.Point(235, 300)
        Me.txttotalharga.Name = "txttotalharga"
        Me.txttotalharga.ReadOnly = True
        Me.txttotalharga.Size = New System.Drawing.Size(100, 22)
        Me.txttotalharga.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "ULANG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(403, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotalharga)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txttotalharga As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
