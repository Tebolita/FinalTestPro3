namespace FinalTestProgra3
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memoria = new System.Windows.Forms.ComboBox();
            this.procesadores = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.procesador3 = new System.Windows.Forms.Label();
            this.procesador16 = new System.Windows.Forms.Label();
            this.procesador15 = new System.Windows.Forms.Label();
            this.procesador14 = new System.Windows.Forms.Label();
            this.procesador13 = new System.Windows.Forms.Label();
            this.procesador12 = new System.Windows.Forms.Label();
            this.procesador11 = new System.Windows.Forms.Label();
            this.procesador10 = new System.Windows.Forms.Label();
            this.procesador9 = new System.Windows.Forms.Label();
            this.procesador8 = new System.Windows.Forms.Label();
            this.procesador7 = new System.Windows.Forms.Label();
            this.procesador6 = new System.Windows.Forms.Label();
            this.procesador5 = new System.Windows.Forms.Label();
            this.procesador4 = new System.Windows.Forms.Label();
            this.procesador2 = new System.Windows.Forms.Label();
            this.procesador1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parametrizar cantidad de procesadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parametrizar cantidad de memoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargar archivo con listado de procesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Ciclos de procesamiento";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Configuraciones";
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.memoria);
            this.panel1.Controls.Add(this.procesadores);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 212);
            this.panel1.TabIndex = 9;
            this.panel1.Tag = "Configuraciones";
            // 
            // memoria
            // 
            this.memoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoria.FormattingEnabled = true;
            this.memoria.Location = new System.Drawing.Point(220, 52);
            this.memoria.Name = "memoria";
            this.memoria.Size = new System.Drawing.Size(96, 21);
            this.memoria.TabIndex = 15;
            this.memoria.SelectedIndexChanged += new System.EventHandler(this.memoria_SelectedIndexChanged);
            // 
            // procesadores
            // 
            this.procesadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.procesadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procesadores.FormattingEnabled = true;
            this.procesadores.Location = new System.Drawing.Point(220, 14);
            this.procesadores.Name = "procesadores";
            this.procesadores.Size = new System.Drawing.Size(96, 21);
            this.procesadores.TabIndex = 14;
            this.procesadores.SelectedIndexChanged += new System.EventHandler(this.procesadores_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Abrir Archivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(220, 117);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Establecer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "|*.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Configuraciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 228);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(19, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 256);
            this.panel2.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Procesos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tareas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.procesador3);
            this.groupBox1.Controls.Add(this.procesador16);
            this.groupBox1.Controls.Add(this.procesador15);
            this.groupBox1.Controls.Add(this.procesador14);
            this.groupBox1.Controls.Add(this.procesador13);
            this.groupBox1.Controls.Add(this.procesador12);
            this.groupBox1.Controls.Add(this.procesador11);
            this.groupBox1.Controls.Add(this.procesador10);
            this.groupBox1.Controls.Add(this.procesador9);
            this.groupBox1.Controls.Add(this.procesador8);
            this.groupBox1.Controls.Add(this.procesador7);
            this.groupBox1.Controls.Add(this.procesador6);
            this.groupBox1.Controls.Add(this.procesador5);
            this.groupBox1.Controls.Add(this.procesador4);
            this.groupBox1.Controls.Add(this.procesador2);
            this.groupBox1.Controls.Add(this.procesador1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(903, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 285);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesadores Activos";
            // 
            // procesador3
            // 
            this.procesador3.AutoSize = true;
            this.procesador3.BackColor = System.Drawing.SystemColors.Control;
            this.procesador3.Location = new System.Drawing.Point(26, 53);
            this.procesador3.Name = "procesador3";
            this.procesador3.Size = new System.Drawing.Size(82, 13);
            this.procesador3.TabIndex = 16;
            this.procesador3.Text = "Procesador 3";
            // 
            // procesador16
            // 
            this.procesador16.AutoSize = true;
            this.procesador16.BackColor = System.Drawing.SystemColors.Control;
            this.procesador16.Location = new System.Drawing.Point(135, 253);
            this.procesador16.Name = "procesador16";
            this.procesador16.Size = new System.Drawing.Size(89, 13);
            this.procesador16.TabIndex = 15;
            this.procesador16.Text = "Procesador 16";
            // 
            // procesador15
            // 
            this.procesador15.AutoSize = true;
            this.procesador15.BackColor = System.Drawing.SystemColors.Control;
            this.procesador15.Location = new System.Drawing.Point(26, 253);
            this.procesador15.Name = "procesador15";
            this.procesador15.Size = new System.Drawing.Size(89, 13);
            this.procesador15.TabIndex = 14;
            this.procesador15.Text = "Procesador 15";
            // 
            // procesador14
            // 
            this.procesador14.AutoSize = true;
            this.procesador14.BackColor = System.Drawing.SystemColors.Control;
            this.procesador14.Location = new System.Drawing.Point(135, 215);
            this.procesador14.Name = "procesador14";
            this.procesador14.Size = new System.Drawing.Size(89, 13);
            this.procesador14.TabIndex = 13;
            this.procesador14.Text = "Procesador 14";
            // 
            // procesador13
            // 
            this.procesador13.AutoSize = true;
            this.procesador13.BackColor = System.Drawing.SystemColors.Control;
            this.procesador13.Location = new System.Drawing.Point(26, 215);
            this.procesador13.Name = "procesador13";
            this.procesador13.Size = new System.Drawing.Size(89, 13);
            this.procesador13.TabIndex = 12;
            this.procesador13.Text = "Procesador 13";
            // 
            // procesador12
            // 
            this.procesador12.AutoSize = true;
            this.procesador12.BackColor = System.Drawing.SystemColors.Control;
            this.procesador12.Location = new System.Drawing.Point(135, 182);
            this.procesador12.Name = "procesador12";
            this.procesador12.Size = new System.Drawing.Size(89, 13);
            this.procesador12.TabIndex = 11;
            this.procesador12.Text = "Procesador 12";
            // 
            // procesador11
            // 
            this.procesador11.AutoSize = true;
            this.procesador11.BackColor = System.Drawing.SystemColors.Control;
            this.procesador11.Location = new System.Drawing.Point(26, 182);
            this.procesador11.Name = "procesador11";
            this.procesador11.Size = new System.Drawing.Size(89, 13);
            this.procesador11.TabIndex = 10;
            this.procesador11.Text = "Procesador 11";
            // 
            // procesador10
            // 
            this.procesador10.AutoSize = true;
            this.procesador10.BackColor = System.Drawing.SystemColors.Control;
            this.procesador10.Location = new System.Drawing.Point(135, 150);
            this.procesador10.Name = "procesador10";
            this.procesador10.Size = new System.Drawing.Size(89, 13);
            this.procesador10.TabIndex = 9;
            this.procesador10.Text = "Procesador 10";
            // 
            // procesador9
            // 
            this.procesador9.AutoSize = true;
            this.procesador9.BackColor = System.Drawing.SystemColors.Control;
            this.procesador9.Location = new System.Drawing.Point(26, 150);
            this.procesador9.Name = "procesador9";
            this.procesador9.Size = new System.Drawing.Size(82, 13);
            this.procesador9.TabIndex = 8;
            this.procesador9.Text = "Procesador 9";
            // 
            // procesador8
            // 
            this.procesador8.AutoSize = true;
            this.procesador8.BackColor = System.Drawing.SystemColors.Control;
            this.procesador8.Location = new System.Drawing.Point(135, 120);
            this.procesador8.Name = "procesador8";
            this.procesador8.Size = new System.Drawing.Size(82, 13);
            this.procesador8.TabIndex = 7;
            this.procesador8.Text = "Procesador 8";
            // 
            // procesador7
            // 
            this.procesador7.AutoSize = true;
            this.procesador7.BackColor = System.Drawing.SystemColors.Control;
            this.procesador7.Location = new System.Drawing.Point(26, 120);
            this.procesador7.Name = "procesador7";
            this.procesador7.Size = new System.Drawing.Size(82, 13);
            this.procesador7.TabIndex = 6;
            this.procesador7.Text = "Procesador 7";
            // 
            // procesador6
            // 
            this.procesador6.AutoSize = true;
            this.procesador6.BackColor = System.Drawing.SystemColors.Control;
            this.procesador6.Location = new System.Drawing.Point(135, 85);
            this.procesador6.Name = "procesador6";
            this.procesador6.Size = new System.Drawing.Size(82, 13);
            this.procesador6.TabIndex = 5;
            this.procesador6.Text = "Procesador 6";
            // 
            // procesador5
            // 
            this.procesador5.AutoSize = true;
            this.procesador5.BackColor = System.Drawing.SystemColors.Control;
            this.procesador5.Location = new System.Drawing.Point(26, 85);
            this.procesador5.Name = "procesador5";
            this.procesador5.Size = new System.Drawing.Size(82, 13);
            this.procesador5.TabIndex = 4;
            this.procesador5.Text = "Procesador 5";
            // 
            // procesador4
            // 
            this.procesador4.AutoSize = true;
            this.procesador4.BackColor = System.Drawing.SystemColors.Control;
            this.procesador4.Location = new System.Drawing.Point(135, 53);
            this.procesador4.Name = "procesador4";
            this.procesador4.Size = new System.Drawing.Size(82, 13);
            this.procesador4.TabIndex = 3;
            this.procesador4.Text = "Procesador 4";
            // 
            // procesador2
            // 
            this.procesador2.AutoSize = true;
            this.procesador2.BackColor = System.Drawing.SystemColors.Control;
            this.procesador2.Location = new System.Drawing.Point(135, 23);
            this.procesador2.Name = "procesador2";
            this.procesador2.Size = new System.Drawing.Size(82, 13);
            this.procesador2.TabIndex = 1;
            this.procesador2.Text = "Procesador 2";
            // 
            // procesador1
            // 
            this.procesador1.AutoSize = true;
            this.procesador1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.procesador1.Location = new System.Drawing.Point(26, 23);
            this.procesador1.Name = "procesador1";
            this.procesador1.Size = new System.Drawing.Size(82, 13);
            this.procesador1.TabIndex = 0;
            this.procesador1.Text = "Procesador 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1155, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox memoria;
        private System.Windows.Forms.ComboBox procesadores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label procesador1;
        private System.Windows.Forms.Label procesador16;
        private System.Windows.Forms.Label procesador15;
        private System.Windows.Forms.Label procesador14;
        private System.Windows.Forms.Label procesador13;
        private System.Windows.Forms.Label procesador12;
        private System.Windows.Forms.Label procesador11;
        private System.Windows.Forms.Label procesador10;
        private System.Windows.Forms.Label procesador9;
        private System.Windows.Forms.Label procesador8;
        private System.Windows.Forms.Label procesador7;
        private System.Windows.Forms.Label procesador6;
        private System.Windows.Forms.Label procesador5;
        private System.Windows.Forms.Label procesador4;
        private System.Windows.Forms.Label procesador2;
        private System.Windows.Forms.Label procesador3;
    }
}

