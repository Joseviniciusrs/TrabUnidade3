namespace ACAD_APP.Control
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            but_allAluno = new Button();
            but_buscaAluno = new Button();
            but_deletaAluno = new Button();
            label2 = new Label();
            but_insereAluno = new Button();
            label1 = new Label();
            but_voltarAluno = new Button();
            SuspendLayout();
            // 
            // but_allAluno
            // 
            but_allAluno.Location = new Point(150, 359);
            but_allAluno.Name = "but_allAluno";
            but_allAluno.Size = new Size(192, 47);
            but_allAluno.TabIndex = 12;
            but_allAluno.Text = "Ver alunos";
            but_allAluno.UseVisualStyleBackColor = true;
            // 
            // but_buscaAluno
            // 
            but_buscaAluno.Location = new Point(150, 306);
            but_buscaAluno.Name = "but_buscaAluno";
            but_buscaAluno.Size = new Size(192, 47);
            but_buscaAluno.TabIndex = 11;
            but_buscaAluno.Text = "Buscar aluno";
            but_buscaAluno.UseVisualStyleBackColor = true;
            // 
            // but_deletaAluno
            // 
            but_deletaAluno.Location = new Point(150, 253);
            but_deletaAluno.Name = "but_deletaAluno";
            but_deletaAluno.Size = new Size(192, 47);
            but_deletaAluno.TabIndex = 10;
            but_deletaAluno.Text = "Deletar aluno";
            but_deletaAluno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(194, 117);
            label2.MaximumSize = new Size(450, 200);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(106, 47);
            label2.TabIndex = 9;
            label2.Text = "Aluno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereAluno
            // 
            but_insereAluno.Location = new Point(150, 200);
            but_insereAluno.Name = "but_insereAluno";
            but_insereAluno.Size = new Size(192, 47);
            but_insereAluno.TabIndex = 8;
            but_insereAluno.Text = "Inserir aluno";
            but_insereAluno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(41, 44);
            label1.MaximumSize = new Size(450, 200);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(418, 56);
            label1.TabIndex = 7;
            label1.Text = "Academia do Seu José";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_voltarAluno
            // 
            but_voltarAluno.Location = new Point(397, 389);
            but_voltarAluno.Name = "but_voltarAluno";
            but_voltarAluno.Size = new Size(91, 47);
            but_voltarAluno.TabIndex = 13;
            but_voltarAluno.Text = "Voltar";
            but_voltarAluno.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(but_voltarAluno);
            Controls.Add(but_allAluno);
            Controls.Add(but_buscaAluno);
            Controls.Add(but_deletaAluno);
            Controls.Add(label2);
            Controls.Add(but_insereAluno);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(500, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_allAluno;
        private Button but_buscaAluno;
        private Button but_deletaAluno;
        private Label label2;
        private Button but_insereAluno;
        private Label label1;
        private Button but_voltarAluno;
    }
}
