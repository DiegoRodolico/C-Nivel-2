namespace Apps_winform
{
    partial class txt_algo2
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
            this.btn_algo = new System.Windows.Forms.Button();
            this.lbl_algo = new System.Windows.Forms.Label();
            this.txt_algo = new System.Windows.Forms.TextBox();
            this.txt_algo_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_algo
            // 
            this.btn_algo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_algo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_algo.Image = global::Apps_winform.Properties.Resources.guitarra_electrica;
            this.btn_algo.Location = new System.Drawing.Point(441, 166);
            this.btn_algo.Name = "btn_algo";
            this.btn_algo.Size = new System.Drawing.Size(75, 23);
            this.btn_algo.TabIndex = 0;
            this.btn_algo.Text = "algo";
            this.btn_algo.UseVisualStyleBackColor = false;
            this.btn_algo.Click += new System.EventHandler(this.btn_algo_Click);
            this.btn_algo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_algo_MouseClick);
            // 
            // lbl_algo
            // 
            this.lbl_algo.AutoSize = true;
            this.lbl_algo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_algo.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_algo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_algo.Location = new System.Drawing.Point(218, 165);
            this.lbl_algo.Name = "lbl_algo";
            this.lbl_algo.Size = new System.Drawing.Size(37, 21);
            this.lbl_algo.TabIndex = 1;
            this.lbl_algo.Text = "algo";
            this.lbl_algo.MouseLeave += new System.EventHandler(this.lbl_algo_MouseLeave);
            this.lbl_algo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_algo_MouseMove);
            // 
            // txt_algo
            // 
            this.txt_algo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_algo.Location = new System.Drawing.Point(298, 168);
            this.txt_algo.MaxLength = 20;
            this.txt_algo.Name = "txt_algo";
            this.txt_algo.Size = new System.Drawing.Size(100, 20);
            this.txt_algo.TabIndex = 2;
            this.txt_algo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_algo_KeyPress);
            // 
            // txt_algo_2
            // 
            this.txt_algo_2.Location = new System.Drawing.Point(298, 227);
            this.txt_algo_2.Multiline = true;
            this.txt_algo_2.Name = "txt_algo_2";
            this.txt_algo_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_algo_2.Size = new System.Drawing.Size(100, 20);
            this.txt_algo_2.TabIndex = 3;
            this.txt_algo_2.Leave += new System.EventHandler(this.txt_algo_2_Leave);
            // 
            // txt_algo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_algo_2);
            this.Controls.Add(this.txt_algo);
            this.Controls.Add(this.lbl_algo);
            this.Controls.Add(this.btn_algo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "txt_algo2";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Name_FormClosed);
            this.Load += new System.EventHandler(this.Name_Load);
            this.Click += new System.EventHandler(this.Name_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_algo;
        private System.Windows.Forms.Label lbl_algo;
        private System.Windows.Forms.TextBox txt_algo;
        private System.Windows.Forms.TextBox txt_algo_2;
    }
}

