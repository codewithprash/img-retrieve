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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.car = New System.Windows.Forms.PictureBox()
        Me.keyboad = New System.Windows.Forms.PictureBox()
        Me.love = New System.Windows.Forms.PictureBox()
        Me.moon = New System.Windows.Forms.PictureBox()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.keyboad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.love, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.moon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"love", "car", "keyboad", "moon"})
        Me.ComboBox1.Location = New System.Drawing.Point(161, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(250, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "show img"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(55, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "img list"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "keyboard.jpg")
        Me.ImageList1.Images.SetKeyName(1, "car.jpg")
        Me.ImageList1.Images.SetKeyName(2, "love.jpg")
        Me.ImageList1.Images.SetKeyName(3, "moon.jpg")
        '
        'car
        '
        Me.car.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.car.Image = Global.showimg.My.Resources.Resources.car
        Me.car.Location = New System.Drawing.Point(12, 106)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(373, 266)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 0
        Me.car.TabStop = False
        Me.car.Visible = False
        '
        'keyboad
        '
        Me.keyboad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.keyboad.Image = Global.showimg.My.Resources.Resources.keyboard
        Me.keyboad.Location = New System.Drawing.Point(12, 106)
        Me.keyboad.Name = "keyboad"
        Me.keyboad.Size = New System.Drawing.Size(373, 266)
        Me.keyboad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.keyboad.TabIndex = 5
        Me.keyboad.TabStop = False
        Me.keyboad.Visible = False
        '
        'love
        '
        Me.love.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.love.Image = Global.showimg.My.Resources.Resources.love
        Me.love.Location = New System.Drawing.Point(12, 106)
        Me.love.Name = "love"
        Me.love.Size = New System.Drawing.Size(373, 266)
        Me.love.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.love.TabIndex = 6
        Me.love.TabStop = False
        Me.love.Visible = False
        '
        'moon
        '
        Me.moon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.moon.Image = Global.showimg.My.Resources.Resources.moon
        Me.moon.Location = New System.Drawing.Point(12, 106)
        Me.moon.Name = "moon"
        Me.moon.Size = New System.Drawing.Size(373, 266)
        Me.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.moon.TabIndex = 7
        Me.moon.TabStop = False
        Me.moon.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 438)
        Me.Controls.Add(Me.moon)
        Me.Controls.Add(Me.love)
        Me.Controls.Add(Me.keyboad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.car)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.keyboad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.love, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.moon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents car As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents keyboad As PictureBox
    Friend WithEvents love As PictureBox
    Friend WithEvents moon As PictureBox
End Class
