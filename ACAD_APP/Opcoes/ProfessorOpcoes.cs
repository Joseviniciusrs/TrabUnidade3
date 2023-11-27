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
using ACAD_APP.Outros;
using ACAD_APP.model;

namespace ACAD_APP
{
    public partial class ProfessorOpcoes : Form
    {
        HttpClient httpClient = new HttpClient();
        public ProfessorOpcoes()
        {
            InitializeComponent();
        }

        private async void but_insereProf_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            prof.nomeP = "carlos";
            prof.cnpj = "123456789";
            prof.ddd = "71";
            prof.email = "carlos@email.com";
            prof.numero = "12345678";


            string c = JsonConvert.SerializeObject(prof);
            var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7263/api/Professor", conteudo);

            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Professor Adiconado com Sucesso\n" + retorno);
        }

        private void but_deletaProf_Click(object sender, EventArgs e)
        {

        }

        private void but_buscaProf_Click(object sender, EventArgs e)
        {

        }

        private async void but_allProf_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Professor";

            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<Professor> clientes = JsonConvert.DeserializeObject<List<Professor>>(content);

            Tabela tabela = new Tabela(clientes);
            tabela.ShowDialog();
        }

        private void but_voltarAluno_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
