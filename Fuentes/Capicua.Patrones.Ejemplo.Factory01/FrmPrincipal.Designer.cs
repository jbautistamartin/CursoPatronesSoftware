namespace Capicua.Patrones.Ejemplo.Factory01
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
            this.btnObtener = new System.Windows.Forms.Button();
            this.rdbLocal = new System.Windows.Forms.RadioButton();
            this.rdbRemoto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(195, 81);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(75, 23);
            this.btnObtener.TabIndex = 0;
            this.btnObtener.Text = "Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // rdbLocal
            // 
            this.rdbLocal.AutoSize = true;
            this.rdbLocal.Checked = true;
            this.rdbLocal.Location = new System.Drawing.Point(31, 23);
            this.rdbLocal.Name = "rdbLocal";
            this.rdbLocal.Size = new System.Drawing.Size(77, 17);
            this.rdbLocal.TabIndex = 1;
            this.rdbLocal.TabStop = true;
            this.rdbLocal.Text = "Hora Local";
            this.rdbLocal.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.rdbRemoto.AutoSize = true;
            this.rdbRemoto.Location = new System.Drawing.Point(31, 46);
            this.rdbRemoto.Name = "radioButton2";
            this.rdbRemoto.Size = new System.Drawing.Size(88, 17);
            this.rdbRemoto.TabIndex = 2;
            this.rdbRemoto.TabStop = true;
            this.rdbRemoto.Text = "Hora Remota";
            this.rdbRemoto.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 116);
            this.Controls.Add(this.rdbRemoto);
            this.Controls.Add(this.rdbLocal);
            this.Controls.Add(this.btnObtener);
            this.Name = "FrmPrincipal";
            this.Text = "Forma Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.RadioButton rdbLocal;
        private System.Windows.Forms.RadioButton rdbRemoto;
    }
}

