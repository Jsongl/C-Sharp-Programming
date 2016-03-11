namespace ExamenPractica3
{
    partial class Form2
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
            this.txtbxGeneral = new System.Windows.Forms.RichTextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxGeneral
            // 
            this.txtbxGeneral.Location = new System.Drawing.Point(12, 12);
            this.txtbxGeneral.Name = "txtbxGeneral";
            this.txtbxGeneral.Size = new System.Drawing.Size(304, 166);
            this.txtbxGeneral.TabIndex = 0;
            this.txtbxGeneral.Text = "";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(13, 229);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(13, 294);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 20);
            this.txtContador.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Caracteres";
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(240, 290);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 4;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 324);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtbxGeneral);
            this.Name = "Form2";
            this.Text = "Despliege";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtbxGeneral;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;

    }
}