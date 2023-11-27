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
using BLLservice;
using ACAD_APP.model;
using System.Net.Http.Headers;
using ACAD_APP.Outros;
using ACAD_APP.Outros.Remove;

namespace ACAD_APP
{
    public partial class EquipamentoOpcoes : Form
    {
        HttpClient httpClient = new HttpClient();
        public EquipamentoOpcoes()
        {
            InitializeComponent();
        }

        private void but_voltarEqp_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void but_buscaEqp_Click(object sender, EventArgs e)
        {

        }

        private async void but_allEqp_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7263/api/Equipamento";


            HttpResponseMessage resposta = await httpClient.GetAsync(url);

            var content = await resposta.Content.ReadAsStringAsync();

            List<Equipamento> eqp = JsonConvert.DeserializeObject<List<Equipamento>>(content);

            Outros.Tabela tabela = new Outros.Tabela(eqp);
            tabela.ShowDialog();
        }

        private void but_insereEqp_Click(object sender, EventArgs e)
        {
            AddEquipamento eqp = new AddEquipamento();
            eqp.ShowDialog();
        }

        private void but_deletaEqp_Click(object sender, EventArgs e)
        {
            RemoveEquip form = new RemoveEquip();
            form.ShowDialog();
        }
    }
}
