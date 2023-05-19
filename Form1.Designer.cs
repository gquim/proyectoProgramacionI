namespace CalculadoraIMC
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
            this.LblEdad = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.LblAltura = new System.Windows.Forms.Label();
            this.TxtPESO = new System.Windows.Forms.TextBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblMujer = new System.Windows.Forms.Label();
            this.LblHombre = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.Location = new System.Drawing.Point(106, 119);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(59, 24);
            this.LblEdad.TabIndex = 0;
            this.LblEdad.Text = "Edad";
            this.LblEdad.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(189, 117);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(97, 29);
            this.TxtEdad.TabIndex = 1;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAltura.Location = new System.Drawing.Point(189, 171);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(97, 29);
            this.TxtAltura.TabIndex = 3;
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.Location = new System.Drawing.Point(106, 173);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(64, 24);
            this.LblAltura.TabIndex = 2;
            this.LblAltura.Text = "Altura";
            // 
            // TxtPESO
            // 
            this.TxtPESO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPESO.Location = new System.Drawing.Point(189, 224);
            this.TxtPESO.Name = "TxtPESO";
            this.TxtPESO.Size = new System.Drawing.Size(97, 29);
            this.TxtPESO.TabIndex = 5;
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Location = new System.Drawing.Point(106, 226);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(57, 24);
            this.LblPeso.TabIndex = 4;
            this.LblPeso.Text = "Peso";
            // 
            // LblMujer
            // 
            this.LblMujer.AutoSize = true;
            this.LblMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMujer.Location = new System.Drawing.Point(133, 47);
            this.LblMujer.Name = "LblMujer";
            this.LblMujer.Size = new System.Drawing.Size(85, 24);
            this.LblMujer.TabIndex = 6;
            this.LblMujer.Text = "Mujeres";
            // 
            // LblHombre
            // 
            this.LblHombre.AutoSize = true;
            this.LblHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHombre.Location = new System.Drawing.Point(330, 47);
            this.LblHombre.Name = "LblHombre";
            this.LblHombre.Size = new System.Drawing.Size(95, 24);
            this.LblHombre.TabIndex = 7;
            this.LblHombre.Text = "Hombres";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(188, 299);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(155, 62);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblHombre);
            this.Controls.Add(this.LblMujer);
            this.Controls.Add(this.TxtPESO);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblEdad);
            this.Name = "Form1";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.TextBox TxtPESO;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label LblMujer;
        private System.Windows.Forms.Label LblHombre;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

