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
            string url = "https://localhost:7263/api/Repeticao";

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

        private async void but_insereTreino_Click(object sender, EventArgs e)
        {
            Repeticao item = new Repeticao();
            item.idFichatr = 0;
            item.repeticao = 15;
            item.serie = 3;
            item.idEquipamento = 0;


            string c = JsonConvert.SerializeObject(item);
            var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7263/api/Repeticao", conteudo);

            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Repeticao Adiconada com Sucesso\n" + retorno);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
