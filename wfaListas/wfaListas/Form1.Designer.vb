<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstIzquierda = New System.Windows.Forms.ListBox()
        Me.lstDerecha = New System.Windows.Forms.ListBox()
        Me.btnTodoDerecha = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnizquierda = New System.Windows.Forms.Button()
        Me.btnTodoIzquierda = New System.Windows.Forms.Button()
        Me.btnOrdernarLista2 = New System.Windows.Forms.Button()
        Me.lblNuevoElemento = New System.Windows.Forms.Label()
        Me.txtNuevoElemento = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblIzquierda = New System.Windows.Forms.Label()
        Me.lblDerecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstIzquierda
        '
        Me.lstIzquierda.FormattingEnabled = True
        Me.lstIzquierda.Location = New System.Drawing.Point(12, 27)
        Me.lstIzquierda.Name = "lstIzquierda"
        Me.lstIzquierda.Size = New System.Drawing.Size(113, 147)
        Me.lstIzquierda.TabIndex = 0
        '
        'lstDerecha
        '
        Me.lstDerecha.FormattingEnabled = True
        Me.lstDerecha.Location = New System.Drawing.Point(212, 27)
        Me.lstDerecha.Name = "lstDerecha"
        Me.lstDerecha.Size = New System.Drawing.Size(120, 147)
        Me.lstDerecha.TabIndex = 1
        '
        'btnTodoDerecha
        '
        Me.btnTodoDerecha.Location = New System.Drawing.Point(155, 31)
        Me.btnTodoDerecha.Name = "btnTodoDerecha"
        Me.btnTodoDerecha.Size = New System.Drawing.Size(28, 23)
        Me.btnTodoDerecha.TabIndex = 2
        Me.btnTodoDerecha.Text = ">>"
        Me.btnTodoDerecha.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.Location = New System.Drawing.Point(155, 60)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(28, 23)
        Me.btnDerecha.TabIndex = 3
        Me.btnDerecha.Text = ">"
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnizquierda
        '
        Me.btnizquierda.Location = New System.Drawing.Point(155, 89)
        Me.btnizquierda.Name = "btnizquierda"
        Me.btnizquierda.Size = New System.Drawing.Size(28, 23)
        Me.btnizquierda.TabIndex = 4
        Me.btnizquierda.Text = "<"
        Me.btnizquierda.UseVisualStyleBackColor = True
        '
        'btnTodoIzquierda
        '
        Me.btnTodoIzquierda.Location = New System.Drawing.Point(155, 118)
        Me.btnTodoIzquierda.Name = "btnTodoIzquierda"
        Me.btnTodoIzquierda.Size = New System.Drawing.Size(28, 23)
        Me.btnTodoIzquierda.TabIndex = 5
        Me.btnTodoIzquierda.Text = "<<"
        Me.btnTodoIzquierda.UseVisualStyleBackColor = True
        '
        'btnOrdernarLista2
        '
        Me.btnOrdernarLista2.Location = New System.Drawing.Point(257, 233)
        Me.btnOrdernarLista2.Name = "btnOrdernarLista2"
        Me.btnOrdernarLista2.Size = New System.Drawing.Size(75, 23)
        Me.btnOrdernarLista2.TabIndex = 6
        Me.btnOrdernarLista2.Text = "Ordenar"
        Me.btnOrdernarLista2.UseVisualStyleBackColor = True
        '
        'lblNuevoElemento
        '
        Me.lblNuevoElemento.AutoSize = True
        Me.lblNuevoElemento.Location = New System.Drawing.Point(9, 193)
        Me.lblNuevoElemento.Name = "lblNuevoElemento"
        Me.lblNuevoElemento.Size = New System.Drawing.Size(139, 13)
        Me.lblNuevoElemento.TabIndex = 7
        Me.lblNuevoElemento.Text = "Nuevo elemento para lista 1"
        '
        'txtNuevoElemento
        '
        Me.txtNuevoElemento.Location = New System.Drawing.Point(12, 209)
        Me.txtNuevoElemento.Name = "txtNuevoElemento"
        Me.txtNuevoElemento.Size = New System.Drawing.Size(100, 20)
        Me.txtNuevoElemento.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 233)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblIzquierda
        '
        Me.lblIzquierda.AutoSize = True
        Me.lblIzquierda.Location = New System.Drawing.Point(9, 11)
        Me.lblIzquierda.Name = "lblIzquierda"
        Me.lblIzquierda.Size = New System.Drawing.Size(38, 13)
        Me.lblIzquierda.TabIndex = 10
        Me.lblIzquierda.Text = "Lista 1"
        '
        'lblDerecha
        '
        Me.lblDerecha.AutoSize = True
        Me.lblDerecha.Location = New System.Drawing.Point(209, 9)
        Me.lblDerecha.Name = "lblDerecha"
        Me.lblDerecha.Size = New System.Drawing.Size(38, 13)
        Me.lblDerecha.TabIndex = 11
        Me.lblDerecha.Text = "Lista 2"
        '
        'frmListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(346, 268)
        Me.Controls.Add(Me.lblDerecha)
        Me.Controls.Add(Me.lblIzquierda)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNuevoElemento)
        Me.Controls.Add(Me.lblNuevoElemento)
        Me.Controls.Add(Me.btnOrdernarLista2)
        Me.Controls.Add(Me.btnTodoIzquierda)
        Me.Controls.Add(Me.btnizquierda)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnTodoDerecha)
        Me.Controls.Add(Me.lstDerecha)
        Me.Controls.Add(Me.lstIzquierda)
        Me.Name = "frmListas"
        Me.Text = "Ejemplo Listas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstIzquierda As System.Windows.Forms.ListBox
    Friend WithEvents lstDerecha As System.Windows.Forms.ListBox
    Friend WithEvents btnTodoDerecha As System.Windows.Forms.Button
    Friend WithEvents btnDerecha As System.Windows.Forms.Button
    Friend WithEvents btnizquierda As System.Windows.Forms.Button
    Friend WithEvents btnTodoIzquierda As System.Windows.Forms.Button
    Friend WithEvents btnOrdernarLista2 As System.Windows.Forms.Button
    Friend WithEvents lblNuevoElemento As System.Windows.Forms.Label
    Friend WithEvents txtNuevoElemento As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblIzquierda As System.Windows.Forms.Label
    Friend WithEvents lblDerecha As System.Windows.Forms.Label

End Class
