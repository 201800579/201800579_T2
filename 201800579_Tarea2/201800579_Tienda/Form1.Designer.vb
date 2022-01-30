<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.LabelArroz = New System.Windows.Forms.Label()
        Me.LabelFrijol = New System.Windows.Forms.Label()
        Me.LabelAzucar = New System.Windows.Forms.Label()
        Me.LbArroz = New System.Windows.Forms.TextBox()
        Me.LbFrijol = New System.Windows.Forms.TextBox()
        Me.LbAzucar = New System.Windows.Forms.TextBox()
        Me.Ingresos = New System.Windows.Forms.GroupBox()
        Me.DescuentoOpcion = New System.Windows.Forms.TextBox()
        Me.LabelDescuento = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salidas = New System.Windows.Forms.GroupBox()
        Me.TPagar = New System.Windows.Forms.TextBox()
        Me.BoxDescuento = New System.Windows.Forms.TextBox()
        Me.LabelTPagar = New System.Windows.Forms.Label()
        Me.LabelDescuento2 = New System.Windows.Forms.Label()
        Me.PIVA = New System.Windows.Forms.TextBox()
        Me.boxIVA = New System.Windows.Forms.TextBox()
        Me.PParcial = New System.Windows.Forms.TextBox()
        Me.LabelPrecioIVA = New System.Windows.Forms.Label()
        Me.LabelIVA = New System.Windows.Forms.Label()
        Me.LabelPParcial = New System.Windows.Forms.Label()
        Me.Botones = New System.Windows.Forms.GroupBox()
        Me.Ingresos.SuspendLayout()
        Me.Salidas.SuspendLayout()
        Me.Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelArroz
        '
        Me.LabelArroz.AutoSize = True
        Me.LabelArroz.BackColor = System.Drawing.Color.MediumAquamarine
        Me.LabelArroz.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelArroz.Location = New System.Drawing.Point(28, 45)
        Me.LabelArroz.Name = "LabelArroz"
        Me.LabelArroz.Size = New System.Drawing.Size(132, 23)
        Me.LabelArroz.TabIndex = 0
        Me.LabelArroz.Text = "Libras de Arroz"
        '
        'LabelFrijol
        '
        Me.LabelFrijol.AutoSize = True
        Me.LabelFrijol.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelFrijol.Location = New System.Drawing.Point(28, 81)
        Me.LabelFrijol.Name = "LabelFrijol"
        Me.LabelFrijol.Size = New System.Drawing.Size(129, 23)
        Me.LabelFrijol.TabIndex = 1
        Me.LabelFrijol.Text = "Libras de Frijol"
        '
        'LabelAzucar
        '
        Me.LabelAzucar.AutoSize = True
        Me.LabelAzucar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelAzucar.Location = New System.Drawing.Point(28, 121)
        Me.LabelAzucar.Name = "LabelAzucar"
        Me.LabelAzucar.Size = New System.Drawing.Size(142, 23)
        Me.LabelAzucar.TabIndex = 2
        Me.LabelAzucar.Text = "Libras de Azucar"
        '
        'LbArroz
        '
        Me.LbArroz.Location = New System.Drawing.Point(186, 37)
        Me.LbArroz.Name = "LbArroz"
        Me.LbArroz.Size = New System.Drawing.Size(203, 34)
        Me.LbArroz.TabIndex = 3
        Me.LbArroz.Text = "0"
        '
        'LbFrijol
        '
        Me.LbFrijol.Location = New System.Drawing.Point(186, 73)
        Me.LbFrijol.Name = "LbFrijol"
        Me.LbFrijol.Size = New System.Drawing.Size(203, 34)
        Me.LbFrijol.TabIndex = 4
        Me.LbFrijol.Text = "0"
        '
        'LbAzucar
        '
        Me.LbAzucar.Location = New System.Drawing.Point(186, 113)
        Me.LbAzucar.Name = "LbAzucar"
        Me.LbAzucar.Size = New System.Drawing.Size(203, 34)
        Me.LbAzucar.TabIndex = 5
        Me.LbAzucar.Text = "0"
        '
        'Ingresos
        '
        Me.Ingresos.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Ingresos.Controls.Add(Me.DescuentoOpcion)
        Me.Ingresos.Controls.Add(Me.LabelDescuento)
        Me.Ingresos.Controls.Add(Me.LbAzucar)
        Me.Ingresos.Controls.Add(Me.LbFrijol)
        Me.Ingresos.Controls.Add(Me.LbArroz)
        Me.Ingresos.Controls.Add(Me.LabelAzucar)
        Me.Ingresos.Controls.Add(Me.LabelFrijol)
        Me.Ingresos.Controls.Add(Me.LabelArroz)
        Me.Ingresos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Ingresos.Location = New System.Drawing.Point(37, 12)
        Me.Ingresos.Name = "Ingresos"
        Me.Ingresos.Size = New System.Drawing.Size(426, 205)
        Me.Ingresos.TabIndex = 6
        Me.Ingresos.TabStop = False
        Me.Ingresos.Text = "Ingresos "
        '
        'DescuentoOpcion
        '
        Me.DescuentoOpcion.Location = New System.Drawing.Point(186, 154)
        Me.DescuentoOpcion.Name = "DescuentoOpcion"
        Me.DescuentoOpcion.Size = New System.Drawing.Size(203, 34)
        Me.DescuentoOpcion.TabIndex = 7
        Me.DescuentoOpcion.Text = "si/no"
        '
        'LabelDescuento
        '
        Me.LabelDescuento.AutoSize = True
        Me.LabelDescuento.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDescuento.Location = New System.Drawing.Point(18, 162)
        Me.LabelDescuento.Name = "LabelDescuento"
        Me.LabelDescuento.Size = New System.Drawing.Size(162, 23)
        Me.LabelDescuento.TabIndex = 6
        Me.LabelDescuento.Text = "Aplica a Descuento"
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Calcular.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Calcular.Location = New System.Drawing.Point(30, 37)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(209, 36)
        Me.Calcular.TabIndex = 7
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Limpiar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Limpiar.Location = New System.Drawing.Point(30, 88)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(209, 36)
        Me.Limpiar.TabIndex = 8
        Me.Limpiar.Text = "Limpiar Datos"
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Salir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Salir.Location = New System.Drawing.Point(30, 141)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(209, 36)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Salidas
        '
        Me.Salidas.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Salidas.Controls.Add(Me.TPagar)
        Me.Salidas.Controls.Add(Me.BoxDescuento)
        Me.Salidas.Controls.Add(Me.LabelTPagar)
        Me.Salidas.Controls.Add(Me.LabelDescuento2)
        Me.Salidas.Controls.Add(Me.PIVA)
        Me.Salidas.Controls.Add(Me.boxIVA)
        Me.Salidas.Controls.Add(Me.PParcial)
        Me.Salidas.Controls.Add(Me.LabelPrecioIVA)
        Me.Salidas.Controls.Add(Me.LabelIVA)
        Me.Salidas.Controls.Add(Me.LabelPParcial)
        Me.Salidas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Salidas.Location = New System.Drawing.Point(12, 237)
        Me.Salidas.Name = "Salidas"
        Me.Salidas.Size = New System.Drawing.Size(776, 191)
        Me.Salidas.TabIndex = 7
        Me.Salidas.TabStop = False
        Me.Salidas.Text = "Total Detallado"
        '
        'TPagar
        '
        Me.TPagar.Location = New System.Drawing.Point(553, 73)
        Me.TPagar.Name = "TPagar"
        Me.TPagar.ReadOnly = True
        Me.TPagar.Size = New System.Drawing.Size(203, 34)
        Me.TPagar.TabIndex = 10
        Me.TPagar.Text = "Q. 0"
        '
        'BoxDescuento
        '
        Me.BoxDescuento.Location = New System.Drawing.Point(553, 37)
        Me.BoxDescuento.Name = "BoxDescuento"
        Me.BoxDescuento.ReadOnly = True
        Me.BoxDescuento.Size = New System.Drawing.Size(203, 34)
        Me.BoxDescuento.TabIndex = 9
        Me.BoxDescuento.Text = "Q. 0"
        '
        'LabelTPagar
        '
        Me.LabelTPagar.AutoSize = True
        Me.LabelTPagar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTPagar.Location = New System.Drawing.Point(495, 81)
        Me.LabelTPagar.Name = "LabelTPagar"
        Me.LabelTPagar.Size = New System.Drawing.Size(49, 23)
        Me.LabelTPagar.TabIndex = 7
        Me.LabelTPagar.Text = "Total"
        '
        'LabelDescuento2
        '
        Me.LabelDescuento2.AutoSize = True
        Me.LabelDescuento2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.LabelDescuento2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelDescuento2.Location = New System.Drawing.Point(439, 45)
        Me.LabelDescuento2.Name = "LabelDescuento2"
        Me.LabelDescuento2.Size = New System.Drawing.Size(93, 23)
        Me.LabelDescuento2.TabIndex = 6
        Me.LabelDescuento2.Text = "Descuento"
        '
        'PIVA
        '
        Me.PIVA.Location = New System.Drawing.Point(186, 113)
        Me.PIVA.Name = "PIVA"
        Me.PIVA.ReadOnly = True
        Me.PIVA.Size = New System.Drawing.Size(203, 34)
        Me.PIVA.TabIndex = 5
        Me.PIVA.Text = "Q. 0"
        '
        'boxIVA
        '
        Me.boxIVA.Location = New System.Drawing.Point(186, 73)
        Me.boxIVA.Name = "boxIVA"
        Me.boxIVA.ReadOnly = True
        Me.boxIVA.Size = New System.Drawing.Size(203, 34)
        Me.boxIVA.TabIndex = 4
        Me.boxIVA.Text = "Q. 0"
        '
        'PParcial
        '
        Me.PParcial.Location = New System.Drawing.Point(186, 37)
        Me.PParcial.Name = "PParcial"
        Me.PParcial.ReadOnly = True
        Me.PParcial.Size = New System.Drawing.Size(203, 34)
        Me.PParcial.TabIndex = 3
        Me.PParcial.Text = "Q. 0"
        '
        'LabelPrecioIVA
        '
        Me.LabelPrecioIVA.AutoSize = True
        Me.LabelPrecioIVA.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPrecioIVA.Location = New System.Drawing.Point(28, 121)
        Me.LabelPrecioIVA.Name = "LabelPrecioIVA"
        Me.LabelPrecioIVA.Size = New System.Drawing.Size(124, 23)
        Me.LabelPrecioIVA.TabIndex = 2
        Me.LabelPrecioIVA.Text = "Precio con IVA"
        '
        'LabelIVA
        '
        Me.LabelIVA.AutoSize = True
        Me.LabelIVA.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelIVA.Location = New System.Drawing.Point(28, 81)
        Me.LabelIVA.Name = "LabelIVA"
        Me.LabelIVA.Size = New System.Drawing.Size(37, 23)
        Me.LabelIVA.TabIndex = 1
        Me.LabelIVA.Text = "IVA"
        '
        'LabelPParcial
        '
        Me.LabelPParcial.AutoSize = True
        Me.LabelPParcial.BackColor = System.Drawing.Color.MediumAquamarine
        Me.LabelPParcial.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPParcial.Location = New System.Drawing.Point(28, 45)
        Me.LabelPParcial.Name = "LabelPParcial"
        Me.LabelPParcial.Size = New System.Drawing.Size(117, 23)
        Me.LabelPParcial.TabIndex = 0
        Me.LabelPParcial.Text = "Precio Parcial"
        '
        'Botones
        '
        Me.Botones.Controls.Add(Me.Salir)
        Me.Botones.Controls.Add(Me.Limpiar)
        Me.Botones.Controls.Add(Me.Calcular)
        Me.Botones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Botones.Location = New System.Drawing.Point(486, 12)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(269, 188)
        Me.Botones.TabIndex = 10
        Me.Botones.TabStop = False
        Me.Botones.Text = "Botones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.Salidas)
        Me.Controls.Add(Me.Ingresos)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tienda de Abarrotes "
        Me.Ingresos.ResumeLayout(False)
        Me.Ingresos.PerformLayout()
        Me.Salidas.ResumeLayout(False)
        Me.Salidas.PerformLayout()
        Me.Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelArroz As Label
    Friend WithEvents LabelFrijol As Label
    Friend WithEvents LabelAzucar As Label
    Friend WithEvents LbArroz As TextBox
    Friend WithEvents LbFrijol As TextBox
    Friend WithEvents LbAzucar As TextBox
    Friend WithEvents Ingresos As GroupBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salidas As GroupBox
    Friend WithEvents PIVA As TextBox
    Friend WithEvents boxIVA As TextBox
    Friend WithEvents PParcial As TextBox
    Friend WithEvents LabelPrecioIVA As Label
    Friend WithEvents LabelIVA As Label
    Friend WithEvents LabelPParcial As Label
    Friend WithEvents Botones As GroupBox
    Friend WithEvents DescuentoOpcion As TextBox
    Friend WithEvents LabelDescuento As Label
    Friend WithEvents TPagar As TextBox
    Friend WithEvents BoxDescuento As TextBox
    Friend WithEvents LabelTPagar As Label
    Friend WithEvents LabelDescuento2 As Label
End Class
