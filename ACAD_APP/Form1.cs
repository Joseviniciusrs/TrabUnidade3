using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ACAD_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void but_Equip_Click(object sender, EventArgs e)
        {
            EquipamentoOpcoes form = new EquipamentoOpcoes();
            form.ShowDialog();


        }

        private void but_Aluno_Click(object sender, EventArgs e)
        {
            AlunoOpcoes form = new AlunoOpcoes();
            form.ShowDialog();


        }

        private void but_Prof_Click(object sender, EventArgs e)
        {
            ProfessorOpcoes form = new ProfessorOpcoes();
            form.ShowDialog();


        }

        private void but_Treino_Click(object sender, EventArgs e)
        {
            RepeticaoOpcoes form = new RepeticaoOpcoes();
            form.ShowDialog();


        }

        private void but_Ficha_Click(object sender, EventArgs e)
        {
            FichaOpcoes form = new FichaOpcoes();
            form.ShowDialog();


        }
    }
}