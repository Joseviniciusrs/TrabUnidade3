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
    public partial class FichaOpcoes : Form
    {
        
        public FichaOpcoes()
        {
            InitializeComponent();
        }

        private void but_insereFicha_Click(object sender, EventArgs e)
        {

        }

        private void but_deletaFicha_Click(object sender, EventArgs e)
        {

        }

        private void but_buscaFicha_Click(object sender, EventArgs e)
        {

        }

        private async void but_allFicha_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Ficha";
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<Ficha> clientes = JsonConvert.DeserializeObject<List<Ficha>>(content);

            Tabela tabela = new Tabela(clientes);
            tabela.ShowDialog();
        }

        private void but_voltarFicha_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
