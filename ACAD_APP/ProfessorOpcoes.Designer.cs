namespace ACAD_APP
{
    partial class ProfessorOpcoes
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
            but_voltarAluno = new Button();
            but_allProf = new Button();
            but_buscaProf = new Button();
            but_deletaProf = new Button();
            label2 = new Label();
            but_insereProf = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // but_voltarAluno
            // 
            but_voltarAluno.Location = new Point(369, 353);
            but_voltarAluno.Name = "but_voltarAluno";
            but_voltarAluno.Size = new Size(91, 47);
            but_voltarAluno.TabIndex = 14;
            but_voltarAluno.Text = "Voltar";
            but_voltarAluno.UseVisualStyleBackColor = true;
            but_voltarAluno.Click += but_voltarAluno_Click;
            // 
            // but_allProf
            // 
            but_allProf.Location = new Point(134, 325);
            but_allProf.Name = "but_allProf";
            but_allProf.Size = new Size(192, 47);
            but_allProf.TabIndex = 13;
            but_allProf.Text = "Ver professores";
            but_allProf.UseVisualStyleBackColor = true;
            but_allProf.Click += but_allProf_Click;
            // 
            // but_buscaProf
            // 
            but_buscaProf.Location = new Point(134, 272);
            but_buscaProf.Name = "but_buscaProf";
            but_buscaProf.Size = new Size(192, 47);
            but_buscaProf.TabIndex = 12;
            but_buscaProf.Text = "Buscar professor";
            but_buscaProf.UseVisualStyleBackColor = true;
            but_buscaProf.Click += but_buscaProf_Click;
            // 
            // but_deletaProf
            // 
            but_deletaProf.Location = new Point(134, 219);
            but_deletaProf.Name = "but_deletaProf";
            but_deletaProf.Size = new Size(192, 47);
            but_deletaProf.TabIndex = 11;
            but_deletaProf.Text = "Deletar professor";
            but_deletaProf.UseVisualStyleBackColor = true;
            but_deletaProf.Click += but_deletaProf_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(155, 82);
            label2.MaximumSize = new Size(450, 200);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(155, 47);
            label2.TabIndex = 10;
            label2.Text = "Professor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereProf
            // 
            but_insereProf.Location = new Point(134, 166);
            but_insereProf.Name = "but_insereProf";
            but_insereProf.Size = new Size(192, 47);
            but_insereProf.TabIndex = 9;
            but_insereProf.Text = "Inserir professor";
            but_insereProf.UseVisualStyleBackColor = true;
            but_insereProf.Click += but_insereProf_Click;
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
            // ProfessorOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(484, 411);
            Controls.Add(but_voltarAluno);
            Controls.Add(but_allProf);
            Controls.Add(but_buscaProf);
            Controls.Add(but_deletaProf);
            Controls.Add(label2);
            Controls.Add(but_insereProf);
            Controls.Add(label1);
            Name = "ProfessorOpcoes";
            Text = "ProfessorOpcoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_voltarAluno;
        private Button but_allProf;
        private Button but_buscaProf;
        private Button but_deletaProf;
        private Label label2;
        private Button but_insereProf;
        private Label label1;
    }
}