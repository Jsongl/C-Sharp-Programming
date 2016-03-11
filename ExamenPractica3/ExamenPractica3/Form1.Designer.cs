namespace ExamenPractica3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manejoArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manejoArchivosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manejoArchivosToolStripMenuItem
            // 
            this.manejoArchivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarArchivoToolStripMenuItem,
            this.modificarArchivoToolStripMenuItem});
            this.manejoArchivosToolStripMenuItem.Name = "manejoArchivosToolStripMenuItem";
            this.manejoArchivosToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.manejoArchivosToolStripMenuItem.Text = "Manejo Archivos";
            // 
            // mostrarArchivoToolStripMenuItem
            // 
            this.mostrarArchivoToolStripMenuItem.Name = "mostrarArchivoToolStripMenuItem";
            this.mostrarArchivoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mostrarArchivoToolStripMenuItem.Text = "Mostrar Archivo";
            this.mostrarArchivoToolStripMenuItem.Click += new System.EventHandler(this.mostrarArchivoToolStripMenuItem_Click);
            // 
            // modificarArchivoToolStripMenuItem
            // 
            this.modificarArchivoToolStripMenuItem.Name = "modificarArchivoToolStripMenuItem";
            this.modificarArchivoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modificarArchivoToolStripMenuItem.Text = "Modificar Archivo";
            this.modificarArchivoToolStripMenuItem.Click += new System.EventHandler(this.modificarArchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Manejo de Archivos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manejoArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

