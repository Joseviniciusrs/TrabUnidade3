using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAD_APP
{
    public partial class AlunoOpcoes : Form
    {
        public AlunoOpcoes()
        {
            InitializeComponent();
        }

        private void but_insereAluno_Click(object sender, EventArgs e)
        {

        }

        private void but_deletaAluno_Click(object sender, EventArgs e)
        {

        }

        private void but_buscaAluno_Click(object sender, EventArgs e)
        {

        }

        private void but_allAluno_Click(object sender, EventArgs e)
        {

        }

        private void but_voltarAluno_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.ShowDialog();
        }
    }
}
