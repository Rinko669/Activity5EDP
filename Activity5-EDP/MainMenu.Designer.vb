<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(180, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAIN MENU"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(41, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 53)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Character Information"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(224, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 53)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Character Archon"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(224, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 51)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Character Weapons"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(41, 187)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 55)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Character Vision"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(41, 263)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 53)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Character Level"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Upload CSV"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(431, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "BackUp"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(664, 337)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
