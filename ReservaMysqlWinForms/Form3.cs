using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservaMysqlWinForms.Entidades;

namespace ReservaMysqlWinForms
{
    public partial class Form3 : Form
    {
        Cliente clienteForm2;

        public Form3(Cliente cliente)
        {
            InitializeComponent();

            clienteForm2 = cliente;

            lblCliente.Text = cliente.Nome;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
