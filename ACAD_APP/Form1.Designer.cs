namespace ACAD_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            but_Aluno = new Button();
            but_Prof = new Button();
            but_Treino = new Button();
            but_Equip = new Button();
            but_Ficha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(113, 44);
            label1.MaximumSize = new Size(514, 266);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(330, 91);
            label1.TabIndex = 0;
            label1.Text = "Academia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_Aluno
            // 
            but_Aluno.Location = new Point(167, 185);
            but_Aluno.Margin = new Padding(3, 4, 3, 4);
            but_Aluno.Name = "but_Aluno";
            but_Aluno.Size = new Size(219, 63);
            but_Aluno.TabIndex = 1;
            but_Aluno.Text = "Aluno";
            but_Aluno.UseVisualStyleBackColor = true;
            but_Aluno.Click += but_Aluno_Click;
            // 
            // but_Prof
            // 
            but_Prof.Location = new Point(167, 256);
            but_Prof.Margin = new Padding(3, 4, 3, 4);
            but_Prof.Name = "but_Prof";
            but_Prof.Size = new Size(219, 63);
            but_Prof.TabIndex = 2;
            but_Prof.Text = "Professor";
            but_Prof.UseVisualStyleBackColor = true;
            but_Prof.Click += but_Prof_Click;
            // 
            // but_Treino
            // 
            but_Treino.Location = new Point(167, 327);
            but_Treino.Margin = new Padding(3, 4, 3, 4);
            but_Treino.Name = "but_Treino";
            but_Treino.Size = new Size(219, 63);
            but_Treino.TabIndex = 3;
            but_Treino.Text = "Treino";
            but_Treino.UseVisualStyleBackColor = true;
            but_Treino.Click += but_Treino_Click;
            // 
            // but_Equip
            // 
            but_Equip.Location = new Point(167, 397);
            but_Equip.Margin = new Padding(3, 4, 3, 4);
            but_Equip.Name = "but_Equip";
            but_Equip.Size = new Size(219, 63);
            but_Equip.TabIndex = 4;
            but_Equip.Text = "Equipamento";
            but_Equip.UseVisualStyleBackColor = true;
            but_Equip.Click += but_Equip_Click;
            // 
            // but_Ficha
            // 
            but_Ficha.Location = new Point(167, 468);
            but_Ficha.Margin = new Padding(3, 4, 3, 4);
            but_Ficha.Name = "but_Ficha";
            but_Ficha.Size = new Size(219, 63);
            but_Ficha.TabIndex = 5;
            but_Ficha.Text = "Ficha";
            but_Ficha.UseVisualStyleBackColor = true;
            but_Ficha.Click += but_Ficha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(553, 548);
            Controls.Add(but_Ficha);
            Controls.Add(but_Equip);
            Controls.Add(but_Treino);
            Controls.Add(but_Prof);
            Controls.Add(but_Aluno);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button but_Aluno;
        private Button but_Prof;
        private Button but_Treino;
        private Button but_Equip;
        private Button but_Ficha;
    }
}