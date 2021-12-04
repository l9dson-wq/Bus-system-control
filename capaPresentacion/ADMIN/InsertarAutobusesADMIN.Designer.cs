namespace capaPresentacion
{
    partial class InsertarAutobusesADMIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PARA INSERTASR AUTOBUSES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MARCA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 159);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(66, 230);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(141, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(66, 279);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(141, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MODELO";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(234, 230);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(141, 20);
            this.txtPlaca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLACA";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(234, 279);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(141, 20);
            this.txtColor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "COLOR";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(392, 230);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(141, 20);
            this.txtYear.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AñO";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(66, 319);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // InsertarAutobusesADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 354);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertarAutobusesADMIN";
            this.Text = "InsertarAutobusesADMIN";
            this.Load += new System.EventHandler(this.InsertarAutobusesADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
    }
}