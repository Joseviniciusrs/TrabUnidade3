﻿namespace ACAD_APP
{
    partial class AlunoOpcoes
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
            but_insereAluno = new Button();
            label2 = new Label();
            but_deletaAluno = new Button();
            but_buscaAluno = new Button();
            but_allAluno = new Button();
            but_voltarAluno = new Button();
            SuspendLayout();
            // 
            // but_insereAluno
            // 
            but_insereAluno.Location = new Point(167, 220);
            but_insereAluno.Margin = new Padding(3, 4, 3, 4);
            but_insereAluno.Name = "but_insereAluno";
            but_insereAluno.Size = new Size(219, 63);
            but_insereAluno.TabIndex = 2;
            but_insereAluno.Text = "Inserir aluno";
            but_insereAluno.UseVisualStyleBackColor = true;
            but_insereAluno.Click += but_insereAluno_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(211, 63);
            label2.MaximumSize = new Size(514, 266);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(130, 56);
            label2.TabIndex = 3;
            label2.Text = "Aluno";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_deletaAluno
            // 
            but_deletaAluno.Location = new Point(167, 291);
            but_deletaAluno.Margin = new Padding(3, 4, 3, 4);
            but_deletaAluno.Name = "but_deletaAluno";
            but_deletaAluno.Size = new Size(219, 63);
            but_deletaAluno.TabIndex = 4;
            but_deletaAluno.Text = "Deletar aluno";
            but_deletaAluno.UseVisualStyleBackColor = true;
            but_deletaAluno.Click += but_deletaAluno_Click;
            // 
            // but_buscaAluno
            // 
            but_buscaAluno.Location = new Point(167, 361);
            but_buscaAluno.Margin = new Padding(3, 4, 3, 4);
            but_buscaAluno.Name = "but_buscaAluno";
            but_buscaAluno.Size = new Size(219, 63);
            but_buscaAluno.TabIndex = 5;
            but_buscaAluno.Text = "Buscar aluno";
            but_buscaAluno.UseVisualStyleBackColor = true;
            but_buscaAluno.Click += but_buscaAluno_Click;
            // 
            // but_allAluno
            // 
            but_allAluno.Location = new Point(167, 432);
            but_allAluno.Margin = new Padding(3, 4, 3, 4);
            but_allAluno.Name = "but_allAluno";
            but_allAluno.Size = new Size(219, 63);
            but_allAluno.TabIndex = 6;
            but_allAluno.Text = "Ver alunos";
            but_allAluno.UseVisualStyleBackColor = true;
            but_allAluno.Click += but_allAluno_Click;
            // 
            // but_voltarAluno
            // 
            but_voltarAluno.Location = new Point(435, 469);
            but_voltarAluno.Margin = new Padding(3, 4, 3, 4);
            but_voltarAluno.Name = "but_voltarAluno";
            but_voltarAluno.Size = new Size(104, 63);
            but_voltarAluno.TabIndex = 7;
            but_voltarAluno.Text = "Voltar";
            but_voltarAluno.UseVisualStyleBackColor = true;
            but_voltarAluno.Click += but_voltarAluno_Click;
            // 
            // AlunoOpcoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(553, 548);
            Controls.Add(but_voltarAluno);
            Controls.Add(but_allAluno);
            Controls.Add(but_buscaAluno);
            Controls.Add(but_deletaAluno);
            Controls.Add(label2);
            Controls.Add(but_insereAluno);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AlunoOpcoes";
            Text = "AlunoOpcoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button but_insereAluno;
        private Label label2;
        private Button but_deletaAluno;
        private Button but_buscaAluno;
        private Button but_allAluno;
        private Button but_voltarAluno;
    }
}