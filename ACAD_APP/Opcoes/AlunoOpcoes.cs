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
using MODEL;
using ACAD_APP.Outros;
using ACAD_APP.model;
using ACAD_APP.Outros.Remove;

namespace ACAD_APP
{
    public partial class AlunoOpcoes : Form
    {
        HttpClient httpClient = new HttpClient();
        public AlunoOpcoes()
        {
            InitializeComponent();
        }

        private void but_insereAluno_Click(object sender, EventArgs e)
        {
            AddAluno form = new AddAluno();
            form.ShowDialog();
        }

        private void but_deletaAluno_Click(object sender, EventArgs e)
        {
            RemoveAluno form = new RemoveAluno();
            form.ShowDialog();      
        }

        private void but_buscaAluno_Click(object sender, EventArgs e)
        {

        }

        private async void but_allAluno_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Aluno";
            

            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<Aluno> clientes = JsonConvert.DeserializeObject<List<Aluno>>(content);

            Tabela tabela = new Tabela(clientes);
            tabela.ShowDialog();
        }

        private void but_voltarAluno_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
