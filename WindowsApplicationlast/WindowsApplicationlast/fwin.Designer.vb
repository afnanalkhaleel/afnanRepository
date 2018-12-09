<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fwin
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttotalbill = New System.Windows.Forms.TextBox()
        Me.Buttonsh = New System.Windows.Forms.Button()
        Me.Buttonview = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttonex = New System.Windows.Forms.Button()
        Me.txtbillnumber = New System.Windows.Forms.TextBox()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(28, 117)
        Me.DateTimePicker2.MinDate = New Date(2013, 9, 19, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(184, 27)
        Me.DateTimePicker2.TabIndex = 25
        Me.DateTimePicker2.Value = New Date(2013, 11, 1, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(475, 117)
        Me.DateTimePicker1.MinDate = New Date(2013, 9, 19, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 27)
        Me.DateTimePicker1.TabIndex = 24
        Me.DateTimePicker1.Value = New Date(2013, 11, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(564, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "total"
        '
        'txttotalbill
        '
        Me.txttotalbill.BackColor = System.Drawing.Color.Yellow
        Me.txttotalbill.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalbill.ForeColor = System.Drawing.Color.Red
        Me.txttotalbill.Location = New System.Drawing.Point(346, 400)
        Me.txttotalbill.Name = "txttotalbill"
        Me.txttotalbill.Size = New System.Drawing.Size(212, 30)
        Me.txttotalbill.TabIndex = 22
        Me.txttotalbill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Buttonsh
        '
        Me.Buttonsh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonsh.Location = New System.Drawing.Point(243, 117)
        Me.Buttonsh.Name = "Buttonsh"
        Me.Buttonsh.Size = New System.Drawing.Size(203, 27)
        Me.Buttonsh.TabIndex = 21
        Me.Buttonsh.Text = "البحث بين تاريخين"
        Me.Buttonsh.UseVisualStyleBackColor = True
        '
        'Buttonview
        '
        Me.Buttonview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonview.Location = New System.Drawing.Point(399, 38)
        Me.Buttonview.Name = "Buttonview"
        Me.Buttonview.Size = New System.Drawing.Size(122, 30)
        Me.Buttonview.TabIndex = 20
        Me.Buttonview.Text = "view"
        Me.Buttonview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "bill number"
        '
        'Buttonex
        '
        Me.Buttonex.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonex.Location = New System.Drawing.Point(11, 400)
        Me.Buttonex.Name = "Buttonex"
        Me.Buttonex.Size = New System.Drawing.Size(128, 41)
        Me.Buttonex.TabIndex = 18
        Me.Buttonex.Text = "exit"
        Me.Buttonex.UseVisualStyleBackColor = True
        '
        'txtbillnumber
        '
        Me.txtbillnumber.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillnumber.Location = New System.Drawing.Point(172, 35)
        Me.txtbillnumber.Name = "txtbillnumber"
        Me.txtbillnumber.Size = New System.Drawing.Size(182, 30)
        Me.txtbillnumber.TabIndex = 17
        Me.txtbillnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview1.Location = New System.Drawing.Point(11, 150)
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.datagridview1.Size = New System.Drawing.Size(667, 244)
        Me.datagridview1.TabIndex = 16
        '
        'fwin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 528)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttotalbill)
        Me.Controls.Add(Me.Buttonsh)
        Me.Controls.Add(Me.Buttonview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonex)
        Me.Controls.Add(Me.txtbillnumber)
        Me.Controls.Add(Me.datagridview1)
        Me.Name = "fwin"
        Me.Text = "fwin"
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txttotalbill As TextBox
    Friend WithEvents Buttonsh As Button
    Friend WithEvents Buttonview As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonex As Button
    Friend WithEvents txtbillnumber As TextBox
    Friend WithEvents datagridview1 As DataGridView
End Class
