namespace Capicua.Patrones.Ejemplo.Decorator03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnValidarAmbiente1 = new System.Windows.Forms.Button();
            this.btnValidarAmbiente2 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValidarAmbiente3 = new System.Windows.Forms.Button();
            this.validationProvider = new Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(108, 30);
            this.txtNombre.Name = "txtNombre";
            this.validationProvider.SetPerformValidation(this.txtNombre, true);
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.validationProvider.SetSourcePropertyName(this.txtNombre, "Nombre");
            this.txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(108, 56);
            this.txtEmail.Name = "txtEmail";
            this.validationProvider.SetPerformValidation(this.txtEmail, true);
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.validationProvider.SetSourcePropertyName(this.txtEmail, "Email");
            this.txtEmail.TabIndex = 3;
            // 
            // btnValidarAmbiente1
            // 
            this.btnValidarAmbiente1.Location = new System.Drawing.Point(202, 82);
            this.btnValidarAmbiente1.Name = "btnValidarAmbiente1";
            this.btnValidarAmbiente1.Size = new System.Drawing.Size(140, 23);
            this.btnValidarAmbiente1.TabIndex = 4;
            this.btnValidarAmbiente1.Text = "Validar Ambiente 1";
            this.btnValidarAmbiente1.UseVisualStyleBackColor = true;
            this.btnValidarAmbiente1.Click += new System.EventHandler(this.btnValidarAmbiente1_Click);
            // 
            // btnValidarAmbiente2
            // 
            this.btnValidarAmbiente2.Location = new System.Drawing.Point(202, 111);
            this.btnValidarAmbiente2.Name = "btnValidarAmbiente2";
            this.btnValidarAmbiente2.Size = new System.Drawing.Size(140, 23);
            this.btnValidarAmbiente2.TabIndex = 5;
            this.btnValidarAmbiente2.Text = "Validar Ambiente 2";
            this.btnValidarAmbiente2.UseVisualStyleBackColor = true;
            this.btnValidarAmbiente2.Click += new System.EventHandler(this.btnValidarAmbiente2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // btnValidarAmbiente3
            // 
            this.btnValidarAmbiente3.Location = new System.Drawing.Point(202, 140);
            this.btnValidarAmbiente3.Name = "btnValidarAmbiente3";
            this.btnValidarAmbiente3.Size = new System.Drawing.Size(140, 23);
            this.btnValidarAmbiente3.TabIndex = 6;
            this.btnValidarAmbiente3.Text = "Validar Ambiente 3";
            this.btnValidarAmbiente3.UseVisualStyleBackColor = true;
            this.btnValidarAmbiente3.Click += new System.EventHandler(this.btnValidarAmbiente3_Click);
            // 
            // validationProvider
            // 
            this.validationProvider.ErrorProvider = this.errorProvider;
            this.validationProvider.RulesetName = "";
            this.validationProvider.SourceTypeName = "Capicua.Patrones.Ejemplo.Decorator03.Usuario,Capicua.Patrones.Ejemplo.Decorator03" +
    ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Capicua.Patrones.Ejemplo.Decorator03.Usuario);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 168);
            this.Controls.Add(this.btnValidarAmbiente3);
            this.Controls.Add(this.btnValidarAmbiente2);
            this.Controls.Add(this.btnValidarAmbiente1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.validationProvider.SetPerformValidation(this, true);
            this.Text = "Ejemplo Decorador 3";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button btnValidarAmbiente1;
        private System.Windows.Forms.Button btnValidarAmbiente2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnValidarAmbiente3;
        private Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WinForms.ValidationProvider validationProvider;
    }
}

