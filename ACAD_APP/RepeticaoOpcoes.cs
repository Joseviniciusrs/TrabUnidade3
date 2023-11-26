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
    public partial class RepeticaoOpcoes : Form
    {
        public RepeticaoOpcoes()
        {
            InitializeComponent();
        }

        private void but_voltarTreino_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.ShowDialog();
        }

        private void but_allTreino_Click(object sender, EventArgs e)
        {

        }

        private void but_buscaTreino_Click(object sender, EventArgs e)
        {

        }

        private void but_deletaTreino_Click(object sender, EventArgs e)
        {

        }

        private void but_insereTreino_Click(object sender, EventArgs e)
        {

        }
    }
}
