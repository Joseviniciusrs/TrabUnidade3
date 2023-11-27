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
            SuspendLayout();
            // 
            // but_voltarTreino
            // 
            but_voltarTreino.Location = new Point(422, 471);
            but_voltarTreino.Margin = new Padding(3, 4, 3, 4);
            but_voltarTreino.Name = "but_voltarTreino";
            but_voltarTreino.Size = new Size(104, 63);
            but_voltarTreino.TabIndex = 14;
            but_voltarTreino.Text = "Voltar";
            but_voltarTreino.UseVisualStyleBackColor = true;
            but_voltarTreino.Click += but_voltarTreino_Click;
            // 
            // but_allTreino
            // 
            but_allTreino.Location = new Point(153, 433);
            but_allTreino.Margin = new Padding(3, 4, 3, 4);
            but_allTreino.Name = "but_allTreino";
            but_allTreino.Size = new Size(219, 63);
            but_allTreino.TabIndex = 13;
            but_allTreino.Text = "Ver treinos";
            but_allTreino.UseVisualStyleBackColor = true;
            but_allTreino.Click += but_allTreino_Click;
            // 
            // but_buscaTreino
            // 
            but_buscaTreino.Location = new Point(153, 363);
            but_buscaTreino.Margin = new Padding(3, 4, 3, 4);
            but_buscaTreino.Name = "but_buscaTreino";
            but_buscaTreino.Size = new Size(219, 63);
            but_buscaTreino.TabIndex = 12;
            but_buscaTreino.Text = "Buscar treino";
            but_buscaTreino.UseVisualStyleBackColor = true;
            but_buscaTreino.Click += but_buscaTreino_Click;
            // 
            // but_deletaTreino
            // 
            but_deletaTreino.Location = new Point(153, 292);
            but_deletaTreino.Margin = new Padding(3, 4, 3, 4);
            but_deletaTreino.Name = "but_deletaTreino";
            but_deletaTreino.Size = new Size(219, 63);
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
            label2.Location = new Point(201, 84);
            label2.MaximumSize = new Size(514, 266);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(134, 56);
            label2.TabIndex = 10;
            label2.Text = "Treino";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // but_insereTreino
            // 
            but_insereTreino.Location = new Point(153, 221);
            but_insereTreino.Margin = new Padding(3, 4, 3, 4);
            but_insereTreino.Name = "but_insereTreino";
            but_insereTreino.Size = new Size(219, 63);
            but_insereTreino.TabIndex = 9;
            but_insereTreino.Text = "Inserir treino";
            but_insereTreino.UseVisualStyleBackColor = true;
            but_insereTreino.Click += but_insereTreino_Click;
            // 
            // RepeticaoOpcoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(553, 548);
            Controls.Add(but_voltarTreino);
            Controls.Add(but_allTreino);
            Controls.Add(but_buscaTreino);
            Controls.Add(but_deletaTreino);
            Controls.Add(label2);
            Controls.Add(but_insereTreino);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}