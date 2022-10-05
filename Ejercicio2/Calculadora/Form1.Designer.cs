namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(12, 52);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(273, 31);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Red;
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlimpiar.Location = new System.Drawing.Point(90, 295);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(113, 33);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "CE";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.PaleGreen;
            this.btn7.Location = new System.Drawing.Point(26, 155);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 43);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.PaleGreen;
            this.btn4.Location = new System.Drawing.Point(26, 204);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 42);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.PaleGreen;
            this.btn1.Location = new System.Drawing.Point(26, 251);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 38);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btndivision
            // 
            this.btndivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndivision.Location = new System.Drawing.Point(87, 102);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(52, 47);
            this.btndivision.TabIndex = 1;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = false;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnmultiplicacion.Location = new System.Drawing.Point(148, 104);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(55, 43);
            this.btnmultiplicacion.TabIndex = 1;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = false;
            this.btnmultiplicacion.Click += new System.EventHandler(this.btnmultiplicacion_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnresta.Location = new System.Drawing.Point(209, 104);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(52, 45);
            this.btnresta.TabIndex = 1;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.PaleGreen;
            this.btn8.Location = new System.Drawing.Point(87, 155);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 43);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.PaleGreen;
            this.btn9.Location = new System.Drawing.Point(148, 155);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 43);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsuma.Location = new System.Drawing.Point(209, 155);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(55, 43);
            this.btnsuma.TabIndex = 1;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.PaleGreen;
            this.btn5.Location = new System.Drawing.Point(87, 204);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 42);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.PaleGreen;
            this.btn6.Location = new System.Drawing.Point(148, 204);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 42);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.PaleGreen;
            this.btn2.Location = new System.Drawing.Point(87, 251);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnigual.Location = new System.Drawing.Point(209, 204);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(55, 129);
            this.btnigual.TabIndex = 1;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.PaleGreen;
            this.btn0.Location = new System.Drawing.Point(26, 295);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 33);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.PaleGreen;
            this.btn3.Location = new System.Drawing.Point(148, 252);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 38);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
    }
}

