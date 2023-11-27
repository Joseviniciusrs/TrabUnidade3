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
            SuspendLayout();
            // 
            // but_voltarAluno
            // 
            but_voltarAluno.Location = new Point(422, 471);
            but_voltarAluno.Margin = new Padding(3, 4, 3, 4);
            but_voltarAluno.Name = "but_voltarAluno";
            but_voltarAluno.Size = new Size(104, 63);
            but_voltarAluno.TabIndex = 14;
            but_voltarAluno.Text = "Voltar";
            but_voltarAluno.UseVisualStyleBackColor = true;
            but_voltarAluno.Click += but_voltarAluno_Click;
            // 
            // but_allProf
            // 
            but_allProf.Location = new Point(153, 433);
            but_allProf.Margin = new Padding(3, 4, 3, 4);
            but_allProf.Name = "but_allProf";
            but_allProf.Size = new Size(219, 63);
            but_allProf.TabIndex = 13;
            but_allProf.Text = "Ver professores";
            but_allProf.UseVisualStyleBackColor = true;
            but_allProf.Click += but_allProf_Click;
            // 
            // but_buscaProf
            // 
            but_buscaProf.Location = new Point(153, 363);
            but_buscaProf.Margin = new Padding(3, 4, 3, 4);
            but_buscaProf.Name = "but_buscaProf";
            but_buscaProf.Size = new Size(219, 63);
            but_buscaProf.TabIndex = 12;
            but_buscaProf.Text = "Buscar professor";
            but_buscaProf.UseVisualStyleBackColor = true;
            but_buscaProf.Click += but_buscaProf_Click;
            // 
            // but_deletaProf
            // 
            but_deletaProf.Location = new Point(153, 292);
            but_deletaProf.Margin = new Padding(3, 4, 3, 4);
            but_deletaProf.Name = "but_deletaProf";
            but_deletaProf.Size = new Size(219, 63);
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
            label2.Location = new Point(170, 61);
            label2.MaximumSize = new Size(514, 266);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(189, 56);
            label2.TabIndex = 10;
            label2.Text = "Professor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereProf
            // 
            but_insereProf.Location = new Point(153, 221);
            but_insereProf.Margin = new Padding(3, 4, 3, 4);
            but_insereProf.Name = "but_insereProf";
            but_insereProf.Size = new Size(219, 63);
            but_insereProf.TabIndex = 9;
            but_insereProf.Text = "Inserir professor";
            but_insereProf.UseVisualStyleBackColor = true;
            but_insereProf.Click += but_insereProf_Click;
            // 
            // ProfessorOpcoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(553, 548);
            Controls.Add(but_voltarAluno);
            Controls.Add(but_allProf);
            Controls.Add(but_buscaProf);
            Controls.Add(but_deletaProf);
            Controls.Add(label2);
            Controls.Add(but_insereProf);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}