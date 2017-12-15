namespace WindowsFormsApp1
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
            this.btncalcualr = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.fcuadro = new System.Windows.Forms.PictureBox();
            this.frectangulo = new System.Windows.Forms.PictureBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fcuadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frectangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btncalcualr
            // 
            this.btncalcualr.Location = new System.Drawing.Point(222, 170);
            this.btncalcualr.Name = "btncalcualr";
            this.btncalcualr.Size = new System.Drawing.Size(75, 23);
            this.btncalcualr.TabIndex = 0;
            this.btncalcualr.Text = "Calcular";
            this.btncalcualr.UseVisualStyleBackColor = true;
            this.btncalcualr.Click += new System.EventHandler(this.btncalcualr_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(222, 215);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(222, 258);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // fcuadro
            // 
            this.fcuadro.BackColor = System.Drawing.Color.Red;
            this.fcuadro.Location = new System.Drawing.Point(33, 159);
            this.fcuadro.Name = "fcuadro";
            this.fcuadro.Size = new System.Drawing.Size(100, 100);
            this.fcuadro.TabIndex = 3;
            this.fcuadro.TabStop = false;
            // 
            // frectangulo
            // 
            this.frectangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.frectangulo.Location = new System.Drawing.Point(22, 170);
            this.frectangulo.Name = "frectangulo";
            this.frectangulo.Size = new System.Drawing.Size(125, 75);
            this.frectangulo.TabIndex = 4;
            this.frectangulo.TabStop = false;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(81, 31);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(81, 57);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 6;
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(81, 87);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 20);
            this.tba.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lado 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lado 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Area:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(327, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.frectangulo);
            this.Controls.Add(this.fcuadro);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcualr);
            this.Name = "Form1";
            this.Text = "Calcular area de cuadrados";
            ((System.ComponentModel.ISupportInitialize)(this.fcuadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frectangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcualr;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox fcuadro;
        private System.Windows.Forms.PictureBox frectangulo;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

