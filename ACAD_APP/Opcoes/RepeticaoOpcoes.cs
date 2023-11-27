using ACAD_APP.model;
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
           
            this.Close();
        }

        private async void but_allTreino_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Repeticao";
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<Repeticao> clientes = JsonConvert.DeserializeObject<List<Repeticao>>(content);

            Tabela tabela = new Tabela(clientes);
            tabela.ShowDialog();
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
