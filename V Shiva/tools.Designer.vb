<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tools
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbThemes = New System.Windows.Forms.ComboBox()
        Me.ThemePic = New System.Windows.Forms.PictureBox()
        Me.btnDefaultTheme = New System.Windows.Forms.Button()
        Me.btnChangeTheme = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "V Shiva : Virus Distructor"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Controls.Add(Me.cmbThemes)
        Me.GroupBox1.Controls.Add(Me.ThemePic)
        Me.GroupBox1.Controls.Add(Me.btnDefaultTheme)
        Me.GroupBox1.Controls.Add(Me.btnChangeTheme)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(9, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 321)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'cmbThemes
        '
        Me.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThemes.FormattingEnabled = True
        Me.cmbThemes.Location = New System.Drawing.Point(51, 240)
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.Size = New System.Drawing.Size(367, 29)
        Me.cmbThemes.TabIndex = 3
        '
        'ThemePic
        '
        Me.ThemePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThemePic.Image = Global.V_Shiva.My.Resources.Resources.vs_indigo_th
        Me.ThemePic.Location = New System.Drawing.Point(51, 22)
        Me.ThemePic.Name = "ThemePic"
        Me.ThemePic.Size = New System.Drawing.Size(367, 212)
        Me.ThemePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThemePic.TabIndex = 2
        Me.ThemePic.TabStop = False
        '
        'btnDefaultTheme
        '
        Me.btnDefaultTheme.BackColor = System.Drawing.Color.Red
        Me.btnDefaultTheme.Location = New System.Drawing.Point(262, 279)
        Me.btnDefaultTheme.Name = "btnDefaultTheme"
        Me.btnDefaultTheme.Size = New System.Drawing.Size(156, 36)
        Me.btnDefaultTheme.TabIndex = 1
        Me.btnDefaultTheme.Text = "Default Theme"
        Me.btnDefaultTheme.UseVisualStyleBackColor = False
        '
        'btnChangeTheme
        '
        Me.btnChangeTheme.BackColor = System.Drawing.Color.Red
        Me.btnChangeTheme.Location = New System.Drawing.Point(51, 279)
        Me.btnChangeTheme.Name = "btnChangeTheme"
        Me.btnChangeTheme.Size = New System.Drawing.Size(156, 36)
        Me.btnChangeTheme.TabIndex = 0
        Me.btnChangeTheme.Text = "Change Theme"
        Me.btnChangeTheme.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.V_Shiva.My.Resources.Resources.close_window_48px
        Me.PictureBox3.Location = New System.Drawing.Point(452, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "tools"
        Me.Size = New System.Drawing.Size(486, 375)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ThemePic As PictureBox
    Friend WithEvents btnDefaultTheme As Button
    Friend WithEvents btnChangeTheme As Button
    Friend WithEvents cmbThemes As ComboBox
End Class
