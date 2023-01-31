using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesRestaurante
{
    public partial class FrmTicket : Form
    {
        public FrmTicket()
        {
            InitializeComponent();
        }

        private void btnRecogerTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket entregado");
            Close();
        }
    }
}
