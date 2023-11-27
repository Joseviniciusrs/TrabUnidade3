using ACAD_APP.model;
using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAD_APP.Outros
{
    public partial class Tabela : Form
    {
        List<Aluno>? list1;
        List<Professor>? list2;
        List<Equipamento>? list3;
        List<Repeticao>? list4;
        List<Ficha>? list5;
        public Tabela(List<Aluno>? lista)
        {
            InitializeComponent();
            this.list1 = lista;
        }
        public Tabela(List<Professor>? lista)
        {
            InitializeComponent();
            this.list2 = lista;
        }
        public Tabela(List<Equipamento>? lista)
        {
            InitializeComponent();
            this.list3 = lista;
        }
        public Tabela(List<Repeticao>? lista)
        {
            InitializeComponent();
            this.list4 = lista;
        }
        public Tabela(List<Ficha>? lista)
        {
            InitializeComponent();
            this.list5 = lista;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            

        }

        private void Tabela_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list1 != null)
            {
                dataGridView1.DataSource = list1;
            }
            else if (list2 != null)
            {
                dataGridView1.DataSource = list2;
            }
            else if (list3 != null)
            {
                dataGridView1.DataSource = list3;
            }
            else if (list4 != null)
            {
                dataGridView1.DataSource = list4;
            }
            else if (list5 != null)
            {
                dataGridView1.DataSource = list5;
            }
        }
    }
}
