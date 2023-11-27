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
            SuspendLayout();
            // 
            // but_voltarFicha
            // 
            but_voltarFicha.Location = new Point(422, 471);
            but_voltarFicha.Margin = new Padding(3, 4, 3, 4);
            but_voltarFicha.Name = "but_voltarFicha";
            but_voltarFicha.Size = new Size(104, 63);
            but_voltarFicha.TabIndex = 14;
            but_voltarFicha.Text = "Voltar";
            but_voltarFicha.UseVisualStyleBackColor = true;
            but_voltarFicha.Click += but_voltarFicha_Click;
            // 
            // but_allFicha
            // 
            but_allFicha.Location = new Point(153, 433);
            but_allFicha.Margin = new Padding(3, 4, 3, 4);
            but_allFicha.Name = "but_allFicha";
            but_allFicha.Size = new Size(219, 63);
            but_allFicha.TabIndex = 13;
            but_allFicha.Text = "Ver fichas";
            but_allFicha.UseVisualStyleBackColor = true;
            but_allFicha.Click += but_allFicha_Click;
            // 
            // but_buscaFicha
            // 
            but_buscaFicha.Location = new Point(153, 363);
            but_buscaFicha.Margin = new Padding(3, 4, 3, 4);
            but_buscaFicha.Name = "but_buscaFicha";
            but_buscaFicha.Size = new Size(219, 63);
            but_buscaFicha.TabIndex = 12;
            but_buscaFicha.Text = "Buscar ficha";
            but_buscaFicha.UseVisualStyleBackColor = true;
            but_buscaFicha.Click += but_buscaFicha_Click;
            // 
            // but_deletaFicha
            // 
            but_deletaFicha.Location = new Point(153, 292);
            but_deletaFicha.Margin = new Padding(3, 4, 3, 4);
            but_deletaFicha.Name = "but_deletaFicha";
            but_deletaFicha.Size = new Size(219, 63);
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
            label2.Location = new Point(205, 72);
            label2.MaximumSize = new Size(514, 266);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(116, 56);
            label2.TabIndex = 10;
            label2.Text = "Ficha";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereFicha
            // 
            but_insereFicha.Location = new Point(153, 221);
            but_insereFicha.Margin = new Padding(3, 4, 3, 4);
            but_insereFicha.Name = "but_insereFicha";
            but_insereFicha.Size = new Size(219, 63);
            but_insereFicha.TabIndex = 9;
            but_insereFicha.Text = "Inserir ficha";
            but_insereFicha.UseVisualStyleBackColor = true;
            but_insereFicha.Click += but_insereFicha_Click;
            // 
            // FichaOpcoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(553, 548);
            Controls.Add(but_voltarFicha);
            Controls.Add(but_allFicha);
            Controls.Add(but_buscaFicha);
            Controls.Add(but_deletaFicha);
            Controls.Add(label2);
            Controls.Add(but_insereFicha);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}