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
            this.button2 = new System.Windows.Forms.Button();
            this.txtidenticador = new System.Windows.Forms.TextBox();
            this.txtdato1 = new System.Windows.Forms.TextBox();
            this.txtdato2 = new System.Windows.Forms.TextBox();
            this.txtdato3 = new System.Windows.Forms.TextBox();
            this.txtdato4 = new System.Windows.Forms.TextBox();
            this.txtdato5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtidenticador
            // 
            this.txtidenticador.Location = new System.Drawing.Point(51, 45);
            this.txtidenticador.Name = "txtidenticador";
            this.txtidenticador.Size = new System.Drawing.Size(100, 20);
            this.txtidenticador.TabIndex = 1;
            // 
            // txtdato1
            // 
            this.txtdato1.Location = new System.Drawing.Point(245, 45);
            this.txtdato1.Name = "txtdato1";
            this.txtdato1.Size = new System.Drawing.Size(100, 20);
            this.txtdato1.TabIndex = 2;
            // 
            // txtdato2
            // 
            this.txtdato2.Location = new System.Drawing.Point(426, 45);
            this.txtdato2.Name = "txtdato2";
            this.txtdato2.Size = new System.Drawing.Size(100, 20);
            this.txtdato2.TabIndex = 3;
            // 
            // txtdato3
            // 
            this.txtdato3.Location = new System.Drawing.Point(51, 102);
            this.txtdato3.Name = "txtdato3";
            this.txtdato3.Size = new System.Drawing.Size(100, 20);
            this.txtdato3.TabIndex = 4;
            // 
            // txtdato4
            // 
            this.txtdato4.Location = new System.Drawing.Point(245, 102);
            this.txtdato4.Name = "txtdato4";
            this.txtdato4.Size = new System.Drawing.Size(100, 20);
            this.txtdato4.TabIndex = 5;
            // 
            // txtdato5
            // 
            this.txtdato5.Location = new System.Drawing.Point(426, 102);
            this.txtdato5.Name = "txtdato5";
            this.txtdato5.Size = new System.Drawing.Size(100, 20);
            this.txtdato5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ProductID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "SustainabilityScore";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "StockQuantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "ProductName";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(163, 152);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 13;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(284, 152);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 136);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnmostrar
            // 
            this.ClientSize = new System.Drawing.Size(586, 351);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdato5);
            this.Controls.Add(this.txtdato4);
            this.Controls.Add(this.txtdato3);
            this.Controls.Add(this.txtdato2);
            this.Controls.Add(this.txtdato1);
            this.Controls.Add(this.txtidenticador);
            this.Controls.Add(this.button2);
            this.Name = "btnmostrar";
            this.Text = "Eco Friendly Solutions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtidenticador;
        private System.Windows.Forms.TextBox txtdato1;
        private System.Windows.Forms.TextBox txtdato2;
        private System.Windows.Forms.TextBox txtdato3;
        private System.Windows.Forms.TextBox txtdato4;
        private System.Windows.Forms.TextBox txtdato5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

