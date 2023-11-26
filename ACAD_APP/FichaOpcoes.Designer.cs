namespace ACAD_APP
{
    partial class FichaOpcoes
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
            but_voltarFicha = new Button();
            but_allFicha = new Button();
            but_buscaFicha = new Button();
            but_deletaFicha = new Button();
            label2 = new Label();
            but_insereFicha = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // but_voltarFicha
            // 
            but_voltarFicha.Location = new Point(369, 353);
            but_voltarFicha.Name = "but_voltarFicha";
            but_voltarFicha.Size = new Size(91, 47);
            but_voltarFicha.TabIndex = 14;
            but_voltarFicha.Text = "Voltar";
            but_voltarFicha.UseVisualStyleBackColor = true;
            but_voltarFicha.Click += but_voltarFicha_Click;
            // 
            // but_allFicha
            // 
            but_allFicha.Location = new Point(134, 325);
            but_allFicha.Name = "but_allFicha";
            but_allFicha.Size = new Size(192, 47);
            but_allFicha.TabIndex = 13;
            but_allFicha.Text = "Ver fichas";
            but_allFicha.UseVisualStyleBackColor = true;
            but_allFicha.Click += but_allFicha_Click;
            // 
            // but_buscaFicha
            // 
            but_buscaFicha.Location = new Point(134, 272);
            but_buscaFicha.Name = "but_buscaFicha";
            but_buscaFicha.Size = new Size(192, 47);
            but_buscaFicha.TabIndex = 12;
            but_buscaFicha.Text = "Buscar ficha";
            but_buscaFicha.UseVisualStyleBackColor = true;
            but_buscaFicha.Click += but_buscaFicha_Click;
            // 
            // but_deletaFicha
            // 
            but_deletaFicha.Location = new Point(134, 219);
            but_deletaFicha.Name = "but_deletaFicha";
            but_deletaFicha.Size = new Size(192, 47);
            but_deletaFicha.TabIndex = 11;
            but_deletaFicha.Text = "Deletar ficha";
            but_deletaFicha.UseVisualStyleBackColor = true;
            but_deletaFicha.Click += but_deletaFicha_Click;
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
            label2.Size = new Size(95, 47);
            label2.TabIndex = 10;
            label2.Text = "Ficha";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereFicha
            // 
            but_insereFicha.Location = new Point(134, 166);
            but_insereFicha.Name = "but_insereFicha";
            but_insereFicha.Size = new Size(192, 47);
            but_insereFicha.TabIndex = 9;
            but_insereFicha.Text = "Inserir ficha";
            but_insereFicha.UseVisualStyleBackColor = true;
            but_insereFicha.Click += but_insereFicha_Click;
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
            // FichaOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(484, 411);
            Controls.Add(but_voltarFicha);
            Controls.Add(but_allFicha);
            Controls.Add(but_buscaFicha);
            Controls.Add(but_deletaFicha);
            Controls.Add(label2);
            Controls.Add(but_insereFicha);
            Controls.Add(label1);
            Name = "FichaOpcoes";
            Text = "FichaOpcoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_voltarFicha;
        private Button but_allFicha;
        private Button but_buscaFicha;
        private Button but_deletaFicha;
        private Label label2;
        private Button but_insereFicha;
        private Label label1;
    }
}