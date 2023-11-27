namespace ACAD_APP.Outros
{
    partial class AddEquipamento
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
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(181, 212);
            button1.Name = "button1";
            button1.Size = new Size(202, 63);
            button1.TabIndex = 27;
            button1.Text = "inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 27);
            textBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 159);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 25;
            label2.Text = "nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 48);
            label1.Name = "label1";
            label1.Size = new Size(320, 67);
            label1.TabIndex = 24;
            label1.Text = "Equipamento";
            // 
            // AddEquipamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 353);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddEquipamento";
            Text = "AddEquipamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}