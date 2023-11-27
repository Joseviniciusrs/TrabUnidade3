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

namespace ACAD_APP
{
    public partial class AlunoOpcoes : Form
    {
        HttpClient httpClient = new HttpClient();
        public AlunoOpcoes()
        {
            InitializeComponent();
        }

        private async void but_insereAluno_Click(object sender, EventArgs e)
        {
            Aluno item = new Aluno();
            item.nomeA = "joao";
            item.cpf = "4545454545";
            item.ddd = "71";
            item.email = "joao@email.com";
            item.numero = "98765432";
            


            string c = JsonConvert.SerializeObject(item);
            var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7263/api/Aluno", conteudo);

            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Aluno Adiconado com Sucesso\n" + retorno);
        }

        private void but_deletaAluno_Click(object sender, EventArgs e)
        {

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
