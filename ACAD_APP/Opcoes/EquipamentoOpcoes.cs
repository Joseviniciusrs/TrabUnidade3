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
using MODEL;
using BLL;

namespace ACAD_APP
{
    public partial class EquipamentoOpcoes : Form
    {
        
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
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage resposta = await httpClient.GetAsync("https://localhost:7263/api/Equipamento/");

            var content = await resposta.Content.ReadAsStringAsync();

            List<TbEquipamento> eqp = JsonConvert.DeserializeObject<List<TbEquipamento>>(content);

            Outros.Tabela tabela = new Outros.Tabela(eqp);
            tabela.ShowDialog();
        }

        private async void but_insereEqp_Click(object sender, EventArgs e)
        {
            TbEquipamento eqp = new TbEquipamento();
            eqp.NomeEqp = "Supino";
            HttpClient httpClient = new HttpClient();

            string c = JsonConvert.SerializeObject(eqp);
            var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:7263/api/Equipamento", conteudo);
            
            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Registro Adiconado com Sucesso\n" + retorno);
        }
    }
}
