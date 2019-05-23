using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaMysqlWinForms
{
    public partial class Form2 : Form
    {
        Form1 PrimeiroForm;

        public Form2(Form1 frm1)
        {
            InitializeComponent();

            PrimeiroForm = frm1;

            txtTipoQuarto.Text = PrimeiroForm.TipoQuartoSelecionado;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
