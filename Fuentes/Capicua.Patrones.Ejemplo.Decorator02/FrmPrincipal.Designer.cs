namespace Capicua.Patrones.Ejemplo.Decorator02
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.proveedorSeguridad = new Capicua.Patrones.Ejemplo.Decorator02.Seguridad.ProveedorSeguridad(this.components);
            this.btnHabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorSeguridad)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.proveedorSeguridad.SetAction(this.button1, "Accion1");
            this.button1.Location = new System.Drawing.Point(97, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.proveedorSeguridad.SetAction(this.button2, "Accion2");
            this.button2.Location = new System.Drawing.Point(97, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.proveedorSeguridad.SetAction(this.button3, "Accion3");
            this.button3.Location = new System.Drawing.Point(97, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // proveedorSeguridad
            // 
            this.proveedorSeguridad.Usuario = "Juan";
            // 
            // btnHabilitar
            // 
            this.proveedorSeguridad.SetAction(this.btnHabilitar, null);
            this.btnHabilitar.Location = new System.Drawing.Point(239, 45);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 3;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // FrmPrincipal
            // 
            this.proveedorSeguridad.SetAction(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmPrincipal";
            this.Text = "Ejemplo Decorador 2";
            ((System.ComponentModel.ISupportInitialize)(this.proveedorSeguridad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Seguridad.ProveedorSeguridad proveedorSeguridad;
        private System.Windows.Forms.Button btnHabilitar;
    }
}

