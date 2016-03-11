namespace Tarea5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkPrestamos = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAnosLabo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAñosLabo = new System.Windows.Forms.Label();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblSalaTitulo = new System.Windows.Forms.Label();
            this.lblDeducciones = new System.Windows.Forms.Label();
            this.lblIncentivos = new System.Windows.Forms.Label();
            this.lblDedu = new System.Windows.Forms.Label();
            this.lblInce = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblSalarioTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkPrestamos
            // 
            this.chkPrestamos.AutoSize = true;
            this.chkPrestamos.Location = new System.Drawing.Point(224, 103);
            this.chkPrestamos.Name = "chkPrestamos";
            this.chkPrestamos.Size = new System.Drawing.Size(35, 17);
            this.chkPrestamos.TabIndex = 41;
            this.chkPrestamos.Text = "Si";
            this.chkPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(263, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(158, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 23);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(224, 186);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 38;
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(224, 164);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(100, 20);
            this.txtOficina.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(224, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // txtAnosLabo
            // 
            this.txtAnosLabo.Location = new System.Drawing.Point(239, 122);
            this.txtAnosLabo.Name = "txtAnosLabo";
            this.txtAnosLabo.Size = new System.Drawing.Size(85, 20);
            this.txtAnosLabo.TabIndex = 35;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(224, 79);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 34;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(224, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(224, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(224, 16);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 31;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(157, 189);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 30;
            this.lblSalario.Text = "Salario";
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Location = new System.Drawing.Point(157, 167);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(40, 13);
            this.lblOficina.TabIndex = 29;
            this.lblOficina.Text = "Oficina";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(157, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // lblAñosLabo
            // 
            this.lblAñosLabo.AutoSize = true;
            this.lblAñosLabo.Location = new System.Drawing.Point(157, 125);
            this.lblAñosLabo.Name = "lblAñosLabo";
            this.lblAñosLabo.Size = new System.Drawing.Size(76, 13);
            this.lblAñosLabo.TabIndex = 27;
            this.lblAñosLabo.Text = "Años laborales";
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Location = new System.Drawing.Point(157, 103);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(56, 13);
            this.lblPrestamos.TabIndex = 26;
            this.lblPrestamos.Text = "Prestamos";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(157, 82);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 25;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(157, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 24;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(157, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(157, 19);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 22;
            this.lblCedula.Text = "Cedula";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(58, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(79, 20);
            this.txtBuscar.TabIndex = 43;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 42;
            this.lblBuscar.Text = "Cedula";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(12, 52);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 44;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblSalaTitulo
            // 
            this.lblSalaTitulo.AutoSize = true;
            this.lblSalaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaTitulo.Location = new System.Drawing.Point(12, 124);
            this.lblSalaTitulo.Name = "lblSalaTitulo";
            this.lblSalaTitulo.Size = new System.Drawing.Size(125, 13);
            this.lblSalaTitulo.TabIndex = 45;
            this.lblSalaTitulo.Text = "Salario / deucciones";
            // 
            // lblDeducciones
            // 
            this.lblDeducciones.AutoSize = true;
            this.lblDeducciones.Location = new System.Drawing.Point(12, 148);
            this.lblDeducciones.Name = "lblDeducciones";
            this.lblDeducciones.Size = new System.Drawing.Size(70, 13);
            this.lblDeducciones.TabIndex = 46;
            this.lblDeducciones.Text = "Deducciones";
            // 
            // lblIncentivos
            // 
            this.lblIncentivos.AutoSize = true;
            this.lblIncentivos.Location = new System.Drawing.Point(13, 167);
            this.lblIncentivos.Name = "lblIncentivos";
            this.lblIncentivos.Size = new System.Drawing.Size(56, 13);
            this.lblIncentivos.TabIndex = 47;
            this.lblIncentivos.Text = "Incentivos";
            // 
            // lblDedu
            // 
            this.lblDedu.AutoSize = true;
            this.lblDedu.Location = new System.Drawing.Point(89, 148);
            this.lblDedu.Name = "lblDedu";
            this.lblDedu.Size = new System.Drawing.Size(13, 13);
            this.lblDedu.TabIndex = 48;
            this.lblDedu.Text = "0";
            // 
            // lblInce
            // 
            this.lblInce.AutoSize = true;
            this.lblInce.Location = new System.Drawing.Point(89, 167);
            this.lblInce.Name = "lblInce";
            this.lblInce.Size = new System.Drawing.Size(13, 13);
            this.lblInce.TabIndex = 49;
            this.lblInce.Text = "0";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(89, 188);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(13, 13);
            this.lblSala.TabIndex = 51;
            this.lblSala.Text = "0";
            // 
            // lblSalarioTotal
            // 
            this.lblSalarioTotal.AutoSize = true;
            this.lblSalarioTotal.Location = new System.Drawing.Point(13, 188);
            this.lblSalarioTotal.Name = "lblSalarioTotal";
            this.lblSalarioTotal.Size = new System.Drawing.Size(66, 13);
            this.lblSalarioTotal.TabIndex = 50;
            this.lblSalarioTotal.Text = "Salario Total";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 262);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblSalarioTotal);
            this.Controls.Add(this.lblInce);
            this.Controls.Add(this.lblDedu);
            this.Controls.Add(this.lblIncentivos);
            this.Controls.Add(this.lblDeducciones);
            this.Controls.Add(this.lblSalaTitulo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.chkPrestamos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAnosLabo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAñosLabo);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Name = "Form3";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPrestamos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAnosLabo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAñosLabo;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblSalaTitulo;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.Label lblIncentivos;
        private System.Windows.Forms.Label lblDedu;
        private System.Windows.Forms.Label lblInce;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblSalarioTotal;
    }
}