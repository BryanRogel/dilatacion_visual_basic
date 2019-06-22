<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dilatación
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dilatación))
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbopcion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.res = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Lineal", "Superficial", "Volumétrica"})
        Me.cmbtipo.Location = New System.Drawing.Point(201, 58)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(259, 23)
        Me.cmbtipo.TabIndex = 0
        Me.cmbtipo.Text = "Seleccione..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de dilatación:"
        '
        'cmbopcion
        '
        Me.cmbopcion.FormattingEnabled = True
        Me.cmbopcion.Location = New System.Drawing.Point(201, 111)
        Me.cmbopcion.Name = "cmbopcion"
        Me.cmbopcion.Size = New System.Drawing.Size(259, 23)
        Me.cmbopcion.TabIndex = 1
        Me.cmbopcion.Text = "Seleccione..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Busco:"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(119, 200)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(116, 22)
        Me.txt1.TabIndex = 2
        Me.txt1.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(116, 182)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(103, 15)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "                                "
        Me.lbl1.Visible = False
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(119, 281)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(116, 22)
        Me.txt2.TabIndex = 2
        Me.txt2.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(116, 263)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(103, 15)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "                                "
        Me.lbl2.Visible = False
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(360, 200)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(116, 22)
        Me.txt4.TabIndex = 4
        Me.txt4.Visible = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(357, 181)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(103, 15)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "                                "
        Me.lbl4.Visible = False
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(360, 281)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(116, 22)
        Me.txt5.TabIndex = 5
        Me.txt5.Visible = False
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(357, 263)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(103, 15)
        Me.lbl5.TabIndex = 3
        Me.lbl5.Text = "                                "
        Me.lbl5.Visible = False
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(120, 281)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(115, 23)
        Me.cmb1.TabIndex = 3
        Me.cmb1.Text = "Seleccione..."
        Me.cmb1.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(162, 337)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(113, 44)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        Me.btnCalcular.Visible = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(301, 337)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 44)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        Me.BtnLimpiar.Visible = False
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'res
        '
        Me.res.AutoSize = True
        Me.res.Font = New System.Drawing.Font("Noto Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res.Location = New System.Drawing.Point(157, 412)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(174, 28)
        Me.res.TabIndex = 10
        Me.res.Text = "El resultado es :"
        Me.res.Visible = False
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Noto Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(328, 412)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(82, 28)
        Me.total.TabIndex = 10
        Me.total.Text = "              "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 497)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "                                                                                 " & _
    "ITCA FEPADE"
        '
        'Dilatación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(559, 512)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbopcion)
        Me.Controls.Add(Me.cmbtipo)
        Me.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dilatación"
        Me.Text = "Dilatación"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbopcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider
    Friend WithEvents res As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
