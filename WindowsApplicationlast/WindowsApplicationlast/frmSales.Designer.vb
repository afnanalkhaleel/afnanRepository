<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.CheckBoxsail = New System.Windows.Forms.CheckBox()
        Me.CheckBoxpu = New System.Windows.Forms.CheckBox()
        Me.txtWin = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Buttonnext = New System.Windows.Forms.Button()
        Me.Buttonpr = New System.Windows.Forms.Button()
        Me.butDelet = New System.Windows.Forms.Button()
        Me.Buttonview = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtItem2 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.butEnter = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtq = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBillNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buttonprint = New System.Windows.Forms.Button()
        Me.txtreset = New System.Windows.Forms.TextBox()
        Me.txtpaided = New System.Windows.Forms.TextBox()
        Me.txtbilltotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Buttonexit = New System.Windows.Forms.Button()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxsail
        '
        Me.CheckBoxsail.AutoSize = True
        Me.CheckBoxsail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxsail.Location = New System.Drawing.Point(445, 73)
        Me.CheckBoxsail.Name = "CheckBoxsail"
        Me.CheckBoxsail.Size = New System.Drawing.Size(73, 20)
        Me.CheckBoxsail.TabIndex = 116
        Me.CheckBoxsail.Text = "bill_sail"
        Me.CheckBoxsail.UseVisualStyleBackColor = True
        '
        'CheckBoxpu
        '
        Me.CheckBoxpu.AutoSize = True
        Me.CheckBoxpu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxpu.Location = New System.Drawing.Point(317, 73)
        Me.CheckBoxpu.Name = "CheckBoxpu"
        Me.CheckBoxpu.Size = New System.Drawing.Size(112, 20)
        Me.CheckBoxpu.TabIndex = 115
        Me.CheckBoxpu.Text = "bill_purchase"
        Me.CheckBoxpu.UseVisualStyleBackColor = True
        '
        'txtWin
        '
        Me.txtWin.BackColor = System.Drawing.Color.GreenYellow
        Me.txtWin.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWin.Location = New System.Drawing.Point(19, 614)
        Me.txtWin.Name = "txtWin"
        Me.txtWin.Size = New System.Drawing.Size(106, 30)
        Me.txtWin.TabIndex = 114
        Me.txtWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.GreenYellow
        Me.txtCost.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(19, 575)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(106, 30)
        Me.txtCost.TabIndex = 113
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Buttonnext
        '
        Me.Buttonnext.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonnext.Location = New System.Drawing.Point(19, 262)
        Me.Buttonnext.Name = "Buttonnext"
        Me.Buttonnext.Size = New System.Drawing.Size(52, 28)
        Me.Buttonnext.TabIndex = 112
        Me.Buttonnext.Text = ">"
        Me.Buttonnext.UseVisualStyleBackColor = True
        '
        'Buttonpr
        '
        Me.Buttonpr.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonpr.Location = New System.Drawing.Point(77, 262)
        Me.Buttonpr.Name = "Buttonpr"
        Me.Buttonpr.Size = New System.Drawing.Size(48, 28)
        Me.Buttonpr.TabIndex = 111
        Me.Buttonpr.Text = "<"
        Me.Buttonpr.UseVisualStyleBackColor = True
        '
        'butDelet
        '
        Me.butDelet.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butDelet.Location = New System.Drawing.Point(12, 152)
        Me.butDelet.Name = "butDelet"
        Me.butDelet.Size = New System.Drawing.Size(210, 42)
        Me.butDelet.TabIndex = 110
        Me.butDelet.Text = "dellet item from bill"
        Me.butDelet.UseVisualStyleBackColor = True
        '
        'Buttonview
        '
        Me.Buttonview.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonview.Location = New System.Drawing.Point(19, 296)
        Me.Buttonview.Name = "Buttonview"
        Me.Buttonview.Size = New System.Drawing.Size(106, 43)
        Me.Buttonview.TabIndex = 109
        Me.Buttonview.Text = "search_bill"
        Me.Buttonview.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.GreenYellow
        Me.txtid.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(19, 539)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(106, 30)
        Me.txtid.TabIndex = 108
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItem2
        '
        Me.txtItem2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem2.ForeColor = System.Drawing.Color.Red
        Me.txtItem2.Location = New System.Drawing.Point(607, 132)
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.Size = New System.Drawing.Size(338, 32)
        Me.txtItem2.TabIndex = 107
        Me.txtItem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.ForestGreen
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.Location = New System.Drawing.Point(607, 220)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(338, 310)
        Me.DataGridView2.TabIndex = 106
        '
        'butEnter
        '
        Me.butEnter.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butEnter.Location = New System.Drawing.Point(12, 92)
        Me.butEnter.Name = "butEnter"
        Me.butEnter.Size = New System.Drawing.Size(210, 42)
        Me.butEnter.TabIndex = 105
        Me.butEnter.Text = "enter"
        Me.butEnter.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(243, 168)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(107, 36)
        Me.txtTotal.TabIndex = 104
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Red
        Me.txtprice.Location = New System.Drawing.Point(378, 168)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(101, 36)
        Me.txtprice.TabIndex = 103
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtq
        '
        Me.txtq.CausesValidation = False
        Me.txtq.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtq.ForeColor = System.Drawing.Color.Red
        Me.txtq.Location = New System.Drawing.Point(496, 169)
        Me.txtq.Name = "txtq"
        Me.txtq.Size = New System.Drawing.Size(93, 36)
        Me.txtq.TabIndex = 102
        Me.txtq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtItem.Cursor = System.Windows.Forms.Cursors.No
        Me.txtItem.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.Color.Black
        Me.txtItem.Location = New System.Drawing.Point(607, 168)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(338, 32)
        Me.txtItem.TabIndex = 101
        Me.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(249, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 23)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(396, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 23)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(520, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 23)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "qut"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(699, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 23)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "item_name"
        '
        'txtBillNumber
        '
        Me.txtBillNumber.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNumber.Location = New System.Drawing.Point(19, 220)
        Me.txtBillNumber.Name = "txtBillNumber"
        Me.txtBillNumber.Size = New System.Drawing.Size(106, 36)
        Me.txtBillNumber.TabIndex = 96
        Me.txtBillNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "bill_number"
        '
        'Buttonprint
        '
        Me.Buttonprint.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonprint.Location = New System.Drawing.Point(19, 438)
        Me.Buttonprint.Name = "Buttonprint"
        Me.Buttonprint.Size = New System.Drawing.Size(106, 43)
        Me.Buttonprint.TabIndex = 94
        Me.Buttonprint.Text = "print"
        Me.Buttonprint.UseVisualStyleBackColor = True
        '
        'txtreset
        '
        Me.txtreset.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreset.Location = New System.Drawing.Point(151, 614)
        Me.txtreset.Name = "txtreset"
        Me.txtreset.Size = New System.Drawing.Size(287, 36)
        Me.txtreset.TabIndex = 93
        Me.txtreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpaided
        '
        Me.txtpaided.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaided.Location = New System.Drawing.Point(475, 614)
        Me.txtpaided.Name = "txtpaided"
        Me.txtpaided.Size = New System.Drawing.Size(207, 36)
        Me.txtpaided.TabIndex = 92
        Me.txtpaided.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbilltotal
        '
        Me.txtbilltotal.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbilltotal.Location = New System.Drawing.Point(720, 614)
        Me.txtbilltotal.Name = "txtbilltotal"
        Me.txtbilltotal.Size = New System.Drawing.Size(225, 36)
        Me.txtbilltotal.TabIndex = 91
        Me.txtbilltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 585)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 23)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "reset"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(573, 582)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "paided"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(805, 585)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "total_bill"
        '
        'Buttonexit
        '
        Me.Buttonexit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonexit.Location = New System.Drawing.Point(19, 487)
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(106, 43)
        Me.Buttonexit.TabIndex = 87
        Me.Buttonexit.Text = "exit"
        Me.Buttonexit.UseVisualStyleBackColor = True
        '
        'butAdd
        '
        Me.butAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAdd.Location = New System.Drawing.Point(19, 389)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(106, 43)
        Me.butAdd.TabIndex = 86
        Me.butAdd.Text = "add_new_bill"
        Me.butAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(151, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 365)
        Me.DataGridView1.TabIndex = 85
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(23, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(191, 27)
        Me.ComboBox2.TabIndex = 84
        Me.ComboBox2.Text = "عام"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"sailes", "purchases"})
        Me.ComboBox1.Location = New System.Drawing.Point(324, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 27)
        Me.ComboBox1.TabIndex = 83
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(659, 30)
        Me.DateTimePicker1.MinDate = New Date(2013, 9, 19, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(146, 27)
        Me.DateTimePicker1.TabIndex = 82
        Me.DateTimePicker1.Value = New Date(2013, 11, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 23)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(538, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Type_bill"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(830, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Date BILL"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(19, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 43)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "search_Advance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 676)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxsail)
        Me.Controls.Add(Me.CheckBoxpu)
        Me.Controls.Add(Me.txtWin)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Buttonnext)
        Me.Controls.Add(Me.Buttonpr)
        Me.Controls.Add(Me.butDelet)
        Me.Controls.Add(Me.Buttonview)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtItem2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.butEnter)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtq)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBillNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Buttonprint)
        Me.Controls.Add(Me.txtreset)
        Me.Controls.Add(Me.txtpaided)
        Me.Controls.Add(Me.txtbilltotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Buttonexit)
        Me.Controls.Add(Me.butAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSales"
        Me.Text = "frmSales"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxsail As CheckBox
    Friend WithEvents CheckBoxpu As CheckBox
    Friend WithEvents txtWin As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Buttonnext As Button
    Friend WithEvents Buttonpr As Button
    Friend WithEvents butDelet As Button
    Friend WithEvents Buttonview As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtItem2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents butEnter As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtq As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBillNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Buttonprint As Button
    Friend WithEvents txtreset As TextBox
    Friend WithEvents txtpaided As TextBox
    Friend WithEvents txtbilltotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Buttonexit As Button
    Friend WithEvents butAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
