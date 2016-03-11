namespace Tarea3
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.txtBxMsg = new System.Windows.Forms.TextBox();
            this.lblHombres = new System.Windows.Forms.Label();
            this.txtHombres = new System.Windows.Forms.TextBox();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.lblMujeres = new System.Windows.Forms.Label();
            this.txt18 = new System.Windows.Forms.TextBox();
            this.lbl18 = new System.Windows.Forms.Label();
            this.txt29 = new System.Windows.Forms.TextBox();
            this.lbl29 = new System.Windows.Forms.Label();
            this.txt30 = new System.Windows.Forms.TextBox();
            this.lbl30 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(25, 66);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(65, 89);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(119, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(25, 96);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(65, 62);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(51, 17);
            this.rdbMujer.TabIndex = 5;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            this.rdbMujer.CheckedChanged += new System.EventHandler(this.rdbMujer_CheckedChanged);
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Checked = true;
            this.rdbHombre.Location = new System.Drawing.Point(122, 62);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(62, 17);
            this.rdbHombre.TabIndex = 6;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            this.rdbHombre.CheckedChanged += new System.EventHandler(this.rdbHombre_CheckedChanged);
            // 
            // txtBxMsg
            // 
            this.txtBxMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBxMsg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBxMsg.Location = new System.Drawing.Point(192, 31);
            this.txtBxMsg.Multiline = true;
            this.txtBxMsg.Name = "txtBxMsg";
            this.txtBxMsg.Size = new System.Drawing.Size(178, 129);
            this.txtBxMsg.TabIndex = 8;
            this.txtBxMsg.Text = "Debe llenar un minimo de 5 sujetos para ver estadisticas.";
            this.txtBxMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHombres
            // 
            this.lblHombres.AutoSize = true;
            this.lblHombres.Location = new System.Drawing.Point(284, 34);
            this.lblHombres.Name = "lblHombres";
            this.lblHombres.Size = new System.Drawing.Size(49, 13);
            this.lblHombres.TabIndex = 9;
            this.lblHombres.Text = "Hombres";
            this.lblHombres.Visible = false;
            // 
            // txtHombres
            // 
            this.txtHombres.Location = new System.Drawing.Point(334, 31);
            this.txtHombres.Name = "txtHombres";
            this.txtHombres.Size = new System.Drawing.Size(25, 20);
            this.txtHombres.TabIndex = 10;
            this.txtHombres.Visible = false;
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(334, 57);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.Size = new System.Drawing.Size(25, 20);
            this.txtMujeres.TabIndex = 12;
            this.txtMujeres.Visible = false;
            // 
            // lblMujeres
            // 
            this.lblMujeres.AutoSize = true;
            this.lblMujeres.Location = new System.Drawing.Point(289, 60);
            this.lblMujeres.Name = "lblMujeres";
            this.lblMujeres.Size = new System.Drawing.Size(44, 13);
            this.lblMujeres.TabIndex = 11;
            this.lblMujeres.Text = "Mujeres";
            this.lblMujeres.Visible = false;
            // 
            // txt18
            // 
            this.txt18.Location = new System.Drawing.Point(286, 88);
            this.txt18.Name = "txt18";
            this.txt18.Size = new System.Drawing.Size(43, 20);
            this.txt18.TabIndex = 14;
            this.txt18.Visible = false;
            // 
            // lbl18
            // 
            this.lbl18.AutoSize = true;
            this.lbl18.Location = new System.Drawing.Point(231, 91);
            this.lbl18.Name = "lbl18";
            this.lbl18.Size = new System.Drawing.Size(22, 13);
            this.lbl18.TabIndex = 13;
            this.lbl18.Text = "-18";
            this.lbl18.Visible = false;
            // 
            // txt29
            // 
            this.txt29.Location = new System.Drawing.Point(286, 114);
            this.txt29.Name = "txt29";
            this.txt29.Size = new System.Drawing.Size(43, 20);
            this.txt29.TabIndex = 16;
            this.txt29.Visible = false;
            // 
            // lbl29
            // 
            this.lbl29.AutoSize = true;
            this.lbl29.Location = new System.Drawing.Point(231, 117);
            this.lbl29.Name = "lbl29";
            this.lbl29.Size = new System.Drawing.Size(34, 13);
            this.lbl29.TabIndex = 15;
            this.lbl29.Text = "19-26";
            this.lbl29.Visible = false;
            // 
            // txt30
            // 
            this.txt30.Location = new System.Drawing.Point(287, 140);
            this.txt30.Name = "txt30";
            this.txt30.Size = new System.Drawing.Size(43, 20);
            this.txt30.TabIndex = 18;
            this.txt30.Visible = false;
            // 
            // lbl30
            // 
            this.lbl30.AutoSize = true;
            this.lbl30.Location = new System.Drawing.Point(232, 143);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new System.Drawing.Size(25, 13);
            this.lbl30.TabIndex = 17;
            this.lbl30.Text = "30+";
            this.lbl30.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(244, 44);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(28, 20);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(207, 47);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(65, 137);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 21;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 191);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txt30);
            this.Controls.Add(this.lbl30);
            this.Controls.Add(this.txt29);
            this.Controls.Add(this.lbl29);
            this.Controls.Add(this.txt18);
            this.Controls.Add(this.lbl18);
            this.Controls.Add(this.txtMujeres);
            this.Controls.Add(this.lblMujeres);
            this.Controls.Add(this.txtHombres);
            this.Controls.Add(this.lblHombres);
            this.Controls.Add(this.txtBxMsg);
            this.Controls.Add(this.rdbHombre);
            this.Controls.Add(this.rdbMujer);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Tarea 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.TextBox txtBxMsg;
        private System.Windows.Forms.Label lblHombres;
        private System.Windows.Forms.TextBox txtHombres;
        private System.Windows.Forms.TextBox txtMujeres;
        private System.Windows.Forms.Label lblMujeres;
        private System.Windows.Forms.TextBox txt18;
        private System.Windows.Forms.Label lbl18;
        private System.Windows.Forms.TextBox txt29;
        private System.Windows.Forms.Label lbl29;
        private System.Windows.Forms.TextBox txt30;
        private System.Windows.Forms.Label lbl30;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btninsertar;
    }
}

