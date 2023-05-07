namespace MyProject.APPv1
{
    partial class Form3
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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(172, 194);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(237, 23);
            dateTimePicker2.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(172, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 23);
            dateTimePicker1.TabIndex = 35;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 295);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(308, 129);
            textBox6.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 194);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 33;
            label6.Text = "Data fim do Projeto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 260);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 32;
            label5.Text = "Resumo do Projeto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 135);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 31;
            label4.Text = "Data inicio do Projeto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 78);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 30;
            label3.Text = "Nome do Gerente do Projeto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(544, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 75);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 28;
            label2.Text = "Nome do Projeto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 27;
            // 
            // button3
            // 
            button3.Location = new Point(634, 160);
            button3.Name = "button3";
            button3.Size = new Size(116, 53);
            button3.TabIndex = 26;
            button3.Text = "Lista";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(634, 360);
            button2.Name = "button2";
            button2.Size = new Size(116, 53);
            button2.TabIndex = 25;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(634, 268);
            button1.Name = "button1";
            button1.Size = new Size(116, 53);
            button1.TabIndex = 24;
            button1.Text = "Cadastro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 37);
            label1.TabIndex = 23;
            label1.Text = "Atualização de Projetos";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 19);
            radioButton1.TabIndex = 42;
            radioButton1.TabStop = true;
            radioButton1.Text = "Em Andamento";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackgroundImageLayout = ImageLayout.None;
            radioButton2.Location = new Point(12, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 19);
            radioButton2.TabIndex = 43;
            radioButton2.TabStop = true;
            radioButton2.Text = "Concluido";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 19);
            radioButton3.TabIndex = 44;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cancelado";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(427, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 100);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status do Projeto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
    }
}