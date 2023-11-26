namespace ACAD_APP
{
    partial class RepeticaoOpcoes
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
            but_voltarTreino = new Button();
            but_allTreino = new Button();
            but_buscaTreino = new Button();
            but_deletaTreino = new Button();
            label2 = new Label();
            but_insereTreino = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // but_voltarTreino
            // 
            but_voltarTreino.Location = new Point(369, 353);
            but_voltarTreino.Name = "but_voltarTreino";
            but_voltarTreino.Size = new Size(91, 47);
            but_voltarTreino.TabIndex = 14;
            but_voltarTreino.Text = "Voltar";
            but_voltarTreino.UseVisualStyleBackColor = true;
            but_voltarTreino.Click += but_voltarTreino_Click;
            // 
            // but_allTreino
            // 
            but_allTreino.Location = new Point(134, 325);
            but_allTreino.Name = "but_allTreino";
            but_allTreino.Size = new Size(192, 47);
            but_allTreino.TabIndex = 13;
            but_allTreino.Text = "Ver treinos";
            but_allTreino.UseVisualStyleBackColor = true;
            but_allTreino.Click += but_allTreino_Click;
            // 
            // but_buscaTreino
            // 
            but_buscaTreino.Location = new Point(134, 272);
            but_buscaTreino.Name = "but_buscaTreino";
            but_buscaTreino.Size = new Size(192, 47);
            but_buscaTreino.TabIndex = 12;
            but_buscaTreino.Text = "Buscar treino";
            but_buscaTreino.UseVisualStyleBackColor = true;
            but_buscaTreino.Click += but_buscaTreino_Click;
            // 
            // but_deletaTreino
            // 
            but_deletaTreino.Location = new Point(134, 219);
            but_deletaTreino.Name = "but_deletaTreino";
            but_deletaTreino.Size = new Size(192, 47);
            but_deletaTreino.TabIndex = 11;
            but_deletaTreino.Text = "Deletar treino";
            but_deletaTreino.UseVisualStyleBackColor = true;
            but_deletaTreino.Click += but_deletaTreino_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(178, 83);
            label2.MaximumSize = new Size(450, 200);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(109, 47);
            label2.TabIndex = 10;
            label2.Text = "Treino";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereTreino
            // 
            but_insereTreino.Location = new Point(134, 166);
            but_insereTreino.Name = "but_insereTreino";
            but_insereTreino.Size = new Size(192, 47);
            but_insereTreino.TabIndex = 9;
            but_insereTreino.Text = "Inserir treino";
            but_insereTreino.UseVisualStyleBackColor = true;
            but_insereTreino.Click += but_insereTreino_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(25, 10);
            label1.MaximumSize = new Size(450, 200);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(418, 56);
            label1.TabIndex = 8;
            label1.Text = "Academia do Seu José";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RepeticaoOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(484, 411);
            Controls.Add(but_voltarTreino);
            Controls.Add(but_allTreino);
            Controls.Add(but_buscaTreino);
            Controls.Add(but_deletaTreino);
            Controls.Add(label2);
            Controls.Add(but_insereTreino);
            Controls.Add(label1);
            Name = "RepeticaoOpcoes";
            Text = "RepeticaoOpcoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_voltarTreino;
        private Button but_allTreino;
        private Button but_buscaTreino;
        private Button but_deletaTreino;
        private Label label2;
        private Button but_insereTreino;
        private Label label1;
    }
}