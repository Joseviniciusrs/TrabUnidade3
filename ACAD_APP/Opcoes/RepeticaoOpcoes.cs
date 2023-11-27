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
    public partial class RepeticaoOpcoes : Form
    {
        HttpClient httpClient = new HttpClient();
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
            string url = "https://localhost:7263/api/Repeticao/";


            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<TbRepeticao>? clientes = JsonConvert.DeserializeObject<List<TbRepeticao>>(content);

            Outros.Tabela tabela = new Outros.Tabela(clientes);
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
