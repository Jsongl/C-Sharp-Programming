namespace Tarea4
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
            this.lstHangar1 = new System.Windows.Forms.ListBox();
            this.lstHangar2 = new System.Windows.Forms.ListBox();
            this.lstHangar3 = new System.Windows.Forms.ListBox();
            this.lstPista3 = new System.Windows.Forms.ListBox();
            this.lstPista2 = new System.Windows.Forms.ListBox();
            this.lstPista1 = new System.Windows.Forms.ListBox();
            this.lblHangar = new System.Windows.Forms.Label();
            this.lblPistas = new System.Windows.Forms.Label();
            this.btnHangar = new System.Windows.Forms.Button();
            this.btnPista = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHangar1
            // 
            this.lstHangar1.FormattingEnabled = true;
            this.lstHangar1.Location = new System.Drawing.Point(15, 51);
            this.lstHangar1.Name = "lstHangar1";
            this.lstHangar1.Size = new System.Drawing.Size(92, 173);
            this.lstHangar1.TabIndex = 0;
            // 
            // lstHangar2
            // 
            this.lstHangar2.FormattingEnabled = true;
            this.lstHangar2.Location = new System.Drawing.Point(113, 51);
            this.lstHangar2.Name = "lstHangar2";
            this.lstHangar2.Size = new System.Drawing.Size(92, 173);
            this.lstHangar2.TabIndex = 1;
            // 
            // lstHangar3
            // 
            this.lstHangar3.FormattingEnabled = true;
            this.lstHangar3.Location = new System.Drawing.Point(211, 51);
            this.lstHangar3.Name = "lstHangar3";
            this.lstHangar3.Size = new System.Drawing.Size(92, 173);
            this.lstHangar3.TabIndex = 2;
            // 
            // lstPista3
            // 
            this.lstPista3.FormattingEnabled = true;
            this.lstPista3.Location = new System.Drawing.Point(211, 291);
            this.lstPista3.Name = "lstPista3";
            this.lstPista3.Size = new System.Drawing.Size(92, 69);
            this.lstPista3.TabIndex = 5;
            // 
            // lstPista2
            // 
            this.lstPista2.FormattingEnabled = true;
            this.lstPista2.Location = new System.Drawing.Point(113, 291);
            this.lstPista2.Name = "lstPista2";
            this.lstPista2.Size = new System.Drawing.Size(92, 69);
            this.lstPista2.TabIndex = 4;
            // 
            // lstPista1
            // 
            this.lstPista1.FormattingEnabled = true;
            this.lstPista1.Location = new System.Drawing.Point(15, 291);
            this.lstPista1.Name = "lstPista1";
            this.lstPista1.Size = new System.Drawing.Size(92, 69);
            this.lstPista1.TabIndex = 3;
            // 
            // lblHangar
            // 
            this.lblHangar.AutoSize = true;
            this.lblHangar.Location = new System.Drawing.Point(12, 35);
            this.lblHangar.Name = "lblHangar";
            this.lblHangar.Size = new System.Drawing.Size(53, 13);
            this.lblHangar.TabIndex = 6;
            this.lblHangar.Text = "Hangares";
            // 
            // lblPistas
            // 
            this.lblPistas.AutoSize = true;
            this.lblPistas.Location = new System.Drawing.Point(12, 275);
            this.lblPistas.Name = "lblPistas";
            this.lblPistas.Size = new System.Drawing.Size(35, 13);
            this.lblPistas.TabIndex = 7;
            this.lblPistas.Text = "Pistas";
            // 
            // btnHangar
            // 
            this.btnHangar.Location = new System.Drawing.Point(90, 230);
            this.btnHangar.Name = "btnHangar";
            this.btnHangar.Size = new System.Drawing.Size(131, 23);
            this.btnHangar.TabIndex = 8;
            this.btnHangar.Text = "Mover a pista";
            this.btnHangar.UseVisualStyleBackColor = true;
            this.btnHangar.Click += new System.EventHandler(this.btnHangar_Click);
            // 
            // btnPista
            // 
            this.btnPista.Location = new System.Drawing.Point(90, 366);
            this.btnPista.Name = "btnPista";
            this.btnPista.Size = new System.Drawing.Size(131, 23);
            this.btnPista.TabIndex = 9;
            this.btnPista.Text = "Mover a hangar";
            this.btnPista.UseVisualStyleBackColor = true;
            this.btnPista.Click += new System.EventHandler(this.btnPista_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.agregarDemoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(319, 24);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Agregar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agregarDemoToolStripMenuItem
            // 
            this.agregarDemoToolStripMenuItem.Name = "agregarDemoToolStripMenuItem";
            this.agregarDemoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.agregarDemoToolStripMenuItem.Text = "Agregar Demo";
            this.agregarDemoToolStripMenuItem.Click += new System.EventHandler(this.agregarDemoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(319, 398);
            this.Controls.Add(this.btnPista);
            this.Controls.Add(this.btnHangar);
            this.Controls.Add(this.lblPistas);
            this.Controls.Add(this.lblHangar);
            this.Controls.Add(this.lstPista3);
            this.Controls.Add(this.lstPista2);
            this.Controls.Add(this.lstPista1);
            this.Controls.Add(this.lstHangar3);
            this.Controls.Add(this.lstHangar2);
            this.Controls.Add(this.lstHangar1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Aeropuerto Santa Ana";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHangar1;
        private System.Windows.Forms.ListBox lstHangar2;
        private System.Windows.Forms.ListBox lstHangar3;
        private System.Windows.Forms.ListBox lstPista3;
        private System.Windows.Forms.ListBox lstPista2;
        private System.Windows.Forms.ListBox lstPista1;
        private System.Windows.Forms.Label lblHangar;
        private System.Windows.Forms.Label lblPistas;
        private System.Windows.Forms.Button btnHangar;
        private System.Windows.Forms.Button btnPista;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDemoToolStripMenuItem;
    }
}

