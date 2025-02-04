namespace AplicacionWindows2_TP_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_apellido
            // 
            resources.ApplyResources(this.lbl_apellido, "lbl_apellido");
            this.lbl_apellido.BackColor = System.Drawing.Color.Olive;
            this.lbl_apellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_apellido.Name = "lbl_apellido";
            // 
            // lbl_nombre
            // 
            resources.ApplyResources(this.lbl_nombre, "lbl_nombre");
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombre.Name = "lbl_nombre";
            // 
            // lbl_edad
            // 
            resources.ApplyResources(this.lbl_edad, "lbl_edad");
            this.lbl_edad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_edad.Name = "lbl_edad";
            // 
            // lbl_direccion
            // 
            resources.ApplyResources(this.lbl_direccion, "lbl_direccion");
            this.lbl_direccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_direccion.Name = "lbl_direccion";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_apellido, "txt_apellido");
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_nombre, "txt_nombre");
            this.txt_nombre.Name = "txt_nombre";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_direccion, "txt_direccion");
            this.txt_direccion.Name = "txt_direccion";
            // 
            // txt_edad
            // 
            this.txt_edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_edad, "txt_edad");
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.TextChanged += new System.EventHandler(this.txt_edad_TextChanged);
            this.txt_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edad_KeyPress);
            // 
            // lbl_resultado
            // 
            resources.ApplyResources(this.lbl_resultado, "lbl_resultado");
            this.lbl_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resultado.Name = "lbl_resultado";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btn_aceptar, "btn_aceptar");
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btn_cancelar, "btn_cancelar");
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_resultado
            // 
            resources.ApplyResources(this.txt_resultado, "txt_resultado");
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_apellido);
            this.ForeColor = System.Drawing.Color.DarkKhaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_resultado;
    }
}

