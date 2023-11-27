using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAD_APP.Outros.Remove
{
    public partial class RemoveEquip : Form
    {
        HttpClient httpClient = new HttpClient();
        public RemoveEquip()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text;
            var response = await httpClient.DeleteAsync($"https://localhost:7263/api/Equipamento?Id={val}");
            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Registro deletado com sucesso!\n\n" + retorno);
            this.Close();
        }
    }
}
