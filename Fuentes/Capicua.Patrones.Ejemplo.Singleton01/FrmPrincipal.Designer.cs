namespace Capicua.Patrones.Ejemplo.Singleton01
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarVentanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaHija1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaHija2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.cargarVentanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cargarVentanasToolStripMenuItem
            // 
            this.cargarVentanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formaHija1ToolStripMenuItem,
            this.formaHija2ToolStripMenuItem});
            this.cargarVentanasToolStripMenuItem.Name = "cargarVentanasToolStripMenuItem";
            this.cargarVentanasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.cargarVentanasToolStripMenuItem.Text = "Cargar Ventanas";
            // 
            // formaHija1ToolStripMenuItem
            // 
            this.formaHija1ToolStripMenuItem.Name = "formaHija1ToolStripMenuItem";
            this.formaHija1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formaHija1ToolStripMenuItem.Text = "Forma Hija 1";
            this.formaHija1ToolStripMenuItem.Click += new System.EventHandler(this.formaHija1ToolStripMenuItem_Click);
            // 
            // formaHija2ToolStripMenuItem
            // 
            this.formaHija2ToolStripMenuItem.Name = "formaHija2ToolStripMenuItem";
            this.formaHija2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formaHija2ToolStripMenuItem.Text = "Forma Hija 2";
            this.formaHija2ToolStripMenuItem.Click += new System.EventHandler(this.formaHija2ToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 404);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Forma Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarVentanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaHija1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaHija2ToolStripMenuItem;
    }
}

