using MODEL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAD_APP
{
    public partial class ProfessorOpcoes : Form
    {
        HttpClient httpClient = new HttpClient();
        public ProfessorOpcoes()
        {
            InitializeComponent();
        }

        private void but_insereProf_Click(object sender, EventArgs e)
        {

        }

        private void but_deletaProf_Click(object sender, EventArgs e)
        {

        }

        private void but_buscaProf_Click(object sender, EventArgs e)
        {

        }

        private async void but_allProf_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Professor/";


            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<TbProfessor>? clientes = JsonConvert.DeserializeObject<List<TbProfessor>>(content);

            Outros.Tabela tabela = new Outros.Tabela(clientes);
            tabela.ShowDialog();
        }

        private void but_voltarAluno_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
