namespace ACAD_APP.Outros
{
    partial class AddAluno
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 43);
            label1.Name = "label1";
            label1.Size = new Size(158, 67);
            label1.TabIndex = 0;
            label1.Text = "Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 167);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "nome: ";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 215);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 3;
            label3.Text = "cpf:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 262);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 306);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 309);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 7;
            label5.Text = "DDD:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(249, 306);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 27);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 309);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 9;
            label6.Text = "numero:";
            // 
            // button1
            // 
            button1.Location = new Point(180, 387);
            button1.Name = "button1";
            button1.Size = new Size(202, 63);
            button1.TabIndex = 11;
            button1.Text = "inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddAluno
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
            Name = "AddAluno";
            Text = "AddAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
    }
}