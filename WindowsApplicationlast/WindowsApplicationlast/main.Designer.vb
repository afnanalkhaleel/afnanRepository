<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersAndCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SealsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurcheringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsractionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Butsales = New System.Windows.Forms.Button()
        Me.Butclasses = New System.Windows.Forms.Button()
        Me.butpur = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoo = New System.Windows.Forms.TextBox()
        Me.DataGridViewmain = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SuppliersAndCustomersToolStripMenuItem, Me.ClassesToolStripMenuItem, Me.SealsToolStripMenuItem, Me.PurcheringToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.InsractionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 23)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'SuppliersAndCustomersToolStripMenuItem
        '
        Me.SuppliersAndCustomersToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersAndCustomersToolStripMenuItem.Name = "SuppliersAndCustomersToolStripMenuItem"
        Me.SuppliersAndCustomersToolStripMenuItem.Size = New System.Drawing.Size(183, 23)
        Me.SuppliersAndCustomersToolStripMenuItem.Text = "Suppliers and customers"
        '
        'ClassesToolStripMenuItem
        '
        Me.ClassesToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem"
        Me.ClassesToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.ClassesToolStripMenuItem.Text = "classes"
        '
        'SealsToolStripMenuItem
        '
        Me.SealsToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SealsToolStripMenuItem.Name = "SealsToolStripMenuItem"
        Me.SealsToolStripMenuItem.Size = New System.Drawing.Size(55, 23)
        Me.SealsToolStripMenuItem.Text = "sales"
        '
        'PurcheringToolStripMenuItem
        '
        Me.PurcheringToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurcheringToolStripMenuItem.Name = "PurcheringToolStripMenuItem"
        Me.PurcheringToolStripMenuItem.Size = New System.Drawing.Size(89, 23)
        Me.PurcheringToolStripMenuItem.Text = "Purchases"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'InsractionsToolStripMenuItem
        '
        Me.InsractionsToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsractionsToolStripMenuItem.Name = "InsractionsToolStripMenuItem"
        Me.InsractionsToolStripMenuItem.Size = New System.Drawing.Size(93, 23)
        Me.InsractionsToolStripMenuItem.Text = "insructions"
        '
        'Butsales
        '
        Me.Butsales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Butsales.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Butsales.FlatAppearance.BorderSize = 3
        Me.Butsales.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butsales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butsales.Location = New System.Drawing.Point(69, 56)
        Me.Butsales.Name = "Butsales"
        Me.Butsales.Size = New System.Drawing.Size(133, 44)
        Me.Butsales.TabIndex = 1
        Me.Butsales.Text = "customers"
        Me.Butsales.UseVisualStyleBackColor = False
        '
        'Butclasses
        '
        Me.Butclasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Butclasses.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Butclasses.FlatAppearance.BorderSize = 3
        Me.Butclasses.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butclasses.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butclasses.Location = New System.Drawing.Point(249, 56)
        Me.Butclasses.Name = "Butclasses"
        Me.Butclasses.Size = New System.Drawing.Size(149, 44)
        Me.Butclasses.TabIndex = 2
        Me.Butclasses.Text = "The Classes"
        Me.Butclasses.UseVisualStyleBackColor = False
        '
        'butpur
        '
        Me.butpur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butpur.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butpur.FlatAppearance.BorderSize = 3
        Me.butpur.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butpur.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butpur.Location = New System.Drawing.Point(87, 115)
        Me.butpur.Name = "butpur"
        Me.butpur.Size = New System.Drawing.Size(175, 44)
        Me.butpur.TabIndex = 3
        Me.butpur.Text = "The Purchases"
        Me.butpur.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(446, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoo
        '
        Me.TextBoo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoo.Location = New System.Drawing.Point(12, 178)
        Me.TextBoo.Name = "TextBoo"
        Me.TextBoo.Size = New System.Drawing.Size(611, 20)
        Me.TextBoo.TabIndex = 5
        '
        'DataGridViewmain
        '
        Me.DataGridViewmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewmain.Location = New System.Drawing.Point(21, 204)
        Me.DataGridViewmain.Name = "DataGridViewmain"
        Me.DataGridViewmain.Size = New System.Drawing.Size(611, 193)
        Me.DataGridViewmain.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(299, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "The sales"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(674, 434)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridViewmain)
        Me.Controls.Add(Me.TextBoo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.butpur)
        Me.Controls.Add(Me.Butclasses)
        Me.Controls.Add(Me.Butsales)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuppliersAndCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SealsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurcheringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsractionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Butsales As Button
    Friend WithEvents Butclasses As Button
    Friend WithEvents butpur As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoo As TextBox
    Friend WithEvents DataGridViewmain As DataGridView
    Friend WithEvents Button2 As Button
End Class
