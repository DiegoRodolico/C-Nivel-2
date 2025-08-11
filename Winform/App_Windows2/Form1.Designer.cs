namespace App_Windows2
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
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(12, 13);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(59, 13);
            this.lbl_apellido.TabIndex = 0;
            this.lbl_apellido.Text = "APELLIDO";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(12, 66);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(37, 13);
            this.lbl_edad.TabIndex = 2;
            this.lbl_edad.Text = "EDAD";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(12, 96);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(66, 13);
            this.lbl_direccion.TabIndex = 3;
            this.lbl_direccion.Text = "DIRECCION";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(12, 128);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(73, 13);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "RESULTADO";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apellido.Location = new System.Drawing.Point(87, 6);
            this.txt_apellido.MaxLength = 30;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(300, 20);
            this.txt_apellido.TabIndex = 5;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(87, 33);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(300, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(87, 59);
            this.txt_edad.MaxLength = 3;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(49, 20);
            this.txt_edad.TabIndex = 7;
            this.txt_edad.TextChanged += new System.EventHandler(this.txt_edad_TextChanged);
            this.txt_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edad_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion.Location = new System.Drawing.Point(87, 89);
            this.txt_direccion.MaxLength = 40;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(300, 20);
            this.txt_direccion.TabIndex = 8;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultado.Location = new System.Drawing.Point(12, 144);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_resultado.Size = new System.Drawing.Size(372, 91);
            this.txt_resultado.TabIndex = 9;
            this.txt_resultado.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(87, 252);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseCompatibleTextRendering = true;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(199, 252);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseCompatibleTextRendering = true;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 287);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_apellido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}

