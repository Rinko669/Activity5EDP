<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vision
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vision))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.visionidtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.visionnametxt = New System.Windows.Forms.TextBox()
        Me.charactertxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.VisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.VisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(232, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHARACTER VISION"
        '
        'visionidtxt
        '
        Me.visionidtxt.Location = New System.Drawing.Point(152, 135)
        Me.visionidtxt.Name = "visionidtxt"
        Me.visionidtxt.Size = New System.Drawing.Size(435, 27)
        Me.visionidtxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(152, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vision_Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(152, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Vision Name"
        '
        'visionnametxt
        '
        Me.visionnametxt.Location = New System.Drawing.Point(152, 196)
        Me.visionnametxt.Name = "visionnametxt"
        Me.visionnametxt.Size = New System.Drawing.Size(435, 27)
        Me.visionnametxt.TabIndex = 4
        '
        'charactertxt
        '
        Me.charactertxt.Location = New System.Drawing.Point(152, 266)
        Me.charactertxt.Name = "charactertxt"
        Me.charactertxt.Size = New System.Drawing.Size(435, 27)
        Me.charactertxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(152, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Character_ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(22, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(22, 278)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 28)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "WEAPONS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(22, 329)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 28)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "BACK"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'VisionBindingSource
        '
        Me.VisionBindingSource.DataSource = GetType(Activity5_EDP.Vision)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Activity5_EDP.My.Resources.Resources.KITA
        Me.PictureBox1.Location = New System.Drawing.Point(593, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 457)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Vision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(790, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.charactertxt)
        Me.Controls.Add(Me.visionnametxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.visionidtxt)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Vision"
        Me.Text = "CHARACTER VISION"
        CType(Me.VisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents visionidtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents visionnametxt As TextBox
    Friend WithEvents charactertxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VisionBindingSource As BindingSource
End Class
