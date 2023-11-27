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
    public partial class AddProfessor : Form
    {
        HttpClient httpClient = new HttpClient();
        public AddProfessor()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            string val2 = textBox2.Text;
            string val3 = textBox3.Text;
            string val4 = textBox4.Text;
            string val5 = textBox5.Text;
            
            Professor item = new Professor();
            item.nomeP = val1;
            item.cnpj = val2;
            item.ddd = val3;
            item.email = val4;
            item.numero = val5;


            string c = JsonConvert.SerializeObject(item);
            var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:7263/api/Professor", conteudo);

            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Professor Adiconado com Sucesso\n" + retorno);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
