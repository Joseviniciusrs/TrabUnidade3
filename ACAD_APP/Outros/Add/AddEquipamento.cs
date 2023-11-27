using ACAD_APP.model;
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

namespace ACAD_APP.Outros
{
    public partial class AddEquipamento : Form
    {
        HttpClient httpClient = new HttpClient();
        public AddEquipamento()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            Equipamento eqp = new Equipamento();
            eqp.nomeEqp = val1;


            string c = JsonConvert.SerializeObject(eqp);
            var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7263/api/Equipamento", conteudo);

            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Registro Adiconado com Sucesso\n" + retorno);
            this.Close();
        }
    }
}
