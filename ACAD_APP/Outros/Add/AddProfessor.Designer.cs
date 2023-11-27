namespace ACAD_APP.Outros
{
    partial class AddProfessor
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
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 362);
            button1.Name = "button1";
            button1.Size = new Size(202, 63);
            button1.TabIndex = 23;
            button1.Text = "inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(234, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 27);
            textBox5.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 284);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 21;
            label6.Text = "numero:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(79, 281);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 27);
            textBox4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 284);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 19;
            label5.Text = "DDD:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 27);
            textBox3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 237);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 27);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 190);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 15;
            label3.Text = "cnpj:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 142);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 13;
            label2.Text = "nome: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 24);
            label1.Name = "label1";
            label1.Size = new Size(233, 67);
            label1.TabIndex = 12;
            label1.Text = "Professor";
            label1.Click += label1_Click;
            // 
            // AddProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 548);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProfessor";
            Text = "AddProfessor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}