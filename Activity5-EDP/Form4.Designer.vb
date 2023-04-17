<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Archons))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.archonidtxt = New System.Windows.Forms.TextBox()
        Me.archonnametext = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sextxt = New System.Windows.Forms.TextBox()
        Me.characteridtxt = New System.Windows.Forms.TextBox()
        Me.charactername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.archidtxt = New System.Windows.Forms.TextBox()
        Me.UPDATE = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Form5 = New System.Windows.Forms.Button()
        Me.ArchonsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchonsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Archon Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(220, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 54)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CHARACTERS ARCHONS"
        '
        'archonidtxt
        '
        Me.archonidtxt.Location = New System.Drawing.Point(217, 144)
        Me.archonidtxt.Name = "archonidtxt"
        Me.archonidtxt.Size = New System.Drawing.Size(502, 27)
        Me.archonidtxt.TabIndex = 4
        '
        'archonnametext
        '
        Me.archonnametext.Location = New System.Drawing.Point(219, 197)
        Me.archonnametext.Name = "archonnametext"
        Me.archonnametext.Size = New System.Drawing.Size(502, 27)
        Me.archonnametext.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sex"
        '
        'sextxt
        '
        Me.sextxt.Location = New System.Drawing.Point(217, 250)
        Me.sextxt.Name = "sextxt"
        Me.sextxt.Size = New System.Drawing.Size(502, 27)
        Me.sextxt.TabIndex = 7
        '
        'characteridtxt
        '
        Me.characteridtxt.Location = New System.Drawing.Point(217, 303)
        Me.characteridtxt.Name = "characteridtxt"
        Me.characteridtxt.Size = New System.Drawing.Size(503, 27)
        Me.characteridtxt.TabIndex = 8
        '
        'charactername
        '
        Me.charactername.Location = New System.Drawing.Point(217, 356)
        Me.charactername.Name = "charactername"
        Me.charactername.Size = New System.Drawing.Size(504, 27)
        Me.charactername.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Character ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Character Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Archon_ID from Character Info"
        '
        'archidtxt
        '
        Me.archidtxt.Location = New System.Drawing.Point(217, 424)
        Me.archidtxt.Name = "archidtxt"
        Me.archidtxt.Size = New System.Drawing.Size(505, 27)
        Me.archidtxt.TabIndex = 13
        '
        'UPDATE
        '
        Me.UPDATE.Location = New System.Drawing.Point(12, 211)
        Me.UPDATE.Name = "UPDATE"
        Me.UPDATE.Size = New System.Drawing.Size(166, 52)
        Me.UPDATE.TabIndex = 15
        Me.UPDATE.Text = "UPDATE"
        Me.UPDATE.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(12, 277)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(166, 53)
        Me.Delete.TabIndex = 16
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.Form5.Location = New System.Drawing.Point(12, 343)
        Me.Form5.Name = "Form5"
        Me.Form5.Size = New System.Drawing.Size(166, 53)
        Me.Form5.TabIndex = 17
        Me.Form5.Text = "CHARACTER VISIONS"
        Me.Form5.UseVisualStyleBackColor = True
        '
        'ArchonsBindingSource
        '
        Me.ArchonsBindingSource.DataSource = GetType(Activity5_EDP.Archons)
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(12, 408)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(166, 52)
        Me.Back.TabIndex = 18
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 56)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Archon ID"
        '
        'Archons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Activity5_EDP.My.Resources.Resources.sibulyas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Form5)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.UPDATE)
        Me.Controls.Add(Me.archidtxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.charactername)
        Me.Controls.Add(Me.characteridtxt)
        Me.Controls.Add(Me.sextxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.archonnametext)
        Me.Controls.Add(Me.archonidtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Archons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Characters Archon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchonsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents archonidtxt As TextBox
    Friend WithEvents archonnametext As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sextxt As TextBox
    Friend WithEvents characteridtxt As TextBox
    Friend WithEvents charactername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents archidtxt As TextBox
    Friend WithEvents UPDATE As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Form5 As Button
    Friend WithEvents ArchonsBindingSource As BindingSource
    Friend WithEvents Back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
