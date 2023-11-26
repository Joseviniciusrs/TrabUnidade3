using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
