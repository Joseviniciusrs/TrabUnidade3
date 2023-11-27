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

        private async void but_allAluno_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Aluno/GetAluno";
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<Aluno>? clientes = JsonConvert.DeserializeObject<List<Aluno>>(content);

            Outros.Tabela tabela = new Outros.Tabela(clientes);
            tabela.ShowDialog();
        }

        private void but_voltarAluno_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
