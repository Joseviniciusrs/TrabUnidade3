namespace ACAD_APP
{
    partial class EquipamentoOpcoes
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
            but_voltarEqp = new Button();
            but_allEqp = new Button();
            but_buscaEqp = new Button();
            but_deletaEqp = new Button();
            label2 = new Label();
            but_insereEqp = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // but_voltarEqp
            // 
            but_voltarEqp.Location = new Point(369, 353);
            but_voltarEqp.Name = "but_voltarEqp";
            but_voltarEqp.Size = new Size(91, 47);
            but_voltarEqp.TabIndex = 14;
            but_voltarEqp.Text = "Voltar";
            but_voltarEqp.UseVisualStyleBackColor = true;
            but_voltarEqp.Click += but_voltarEqp_Click;
            // 
            // but_allEqp
            // 
            but_allEqp.Location = new Point(134, 325);
            but_allEqp.Name = "but_allEqp";
            but_allEqp.Size = new Size(192, 47);
            but_allEqp.TabIndex = 13;
            but_allEqp.Text = "Ver equipamentos";
            but_allEqp.UseVisualStyleBackColor = true;
            // 
            // but_buscaEqp
            // 
            but_buscaEqp.Location = new Point(134, 272);
            but_buscaEqp.Name = "but_buscaEqp";
            but_buscaEqp.Size = new Size(192, 47);
            but_buscaEqp.TabIndex = 12;
            but_buscaEqp.Text = "Buscar equipamento";
            but_buscaEqp.UseVisualStyleBackColor = true;
            // 
            // but_deletaEqp
            // 
            but_deletaEqp.Location = new Point(134, 219);
            but_deletaEqp.Name = "but_deletaEqp";
            but_deletaEqp.Size = new Size(192, 47);
            but_deletaEqp.TabIndex = 11;
            but_deletaEqp.Text = "Deletar equipamento";
            but_deletaEqp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(125, 79);
            label2.MaximumSize = new Size(450, 200);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(211, 47);
            label2.TabIndex = 10;
            label2.Text = "Equipamento";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // but_insereEqp
            // 
            but_insereEqp.Location = new Point(134, 166);
            but_insereEqp.Name = "but_insereEqp";
            but_insereEqp.Size = new Size(192, 47);
            but_insereEqp.TabIndex = 9;
            but_insereEqp.Text = "Inserir equipamento";
            but_insereEqp.UseVisualStyleBackColor = true;
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
            // EquipamentoOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(484, 411);
            Controls.Add(but_voltarEqp);
            Controls.Add(but_allEqp);
            Controls.Add(but_buscaEqp);
            Controls.Add(but_deletaEqp);
            Controls.Add(label2);
            Controls.Add(but_insereEqp);
            Controls.Add(label1);
            Name = "EquipamentoOpcoes";
            Text = "EquipamentoOpcoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_voltarEqp;
        private Button but_allEqp;
        private Button but_buscaEqp;
        private Button but_deletaEqp;
        private Label label2;
        private Button but_insereEqp;
        private Label label1;
    }
}