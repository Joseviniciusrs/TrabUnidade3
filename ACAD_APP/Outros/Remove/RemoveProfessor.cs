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
    public partial class RemoveProfessor : Form
    {
        HttpClient httpClient = new HttpClient();
        public RemoveProfessor()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text;
            var response = await httpClient.DeleteAsync($"https://localhost:7263/api/Professor?Id={val}");
            var retorno = await response.Content.ReadAsStringAsync();

            MessageBox.Show("Registro deletado com sucesso!\n\n" + retorno);
            this.Close();
        }
    }
}
