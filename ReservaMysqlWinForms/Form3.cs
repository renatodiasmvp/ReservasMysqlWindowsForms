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
        // objeto da classe Cliente
        // que vai receber os dados
        // do objeto passado pelo Form2 como parametro
        Cliente clienteForm2;

        // construtor do Form3 com um objeto da classe Cliente como parametro
        public Form3(Cliente cliente)
        {
            InitializeComponent();

            // o objeto clienteForm2 recebe os valores
            // do objeto cliente que for passado como parametro
            // pelo Form2
            clienteForm2 = cliente;
            // label lblCliente recebe o valor da proprieda Nome do objeto cliente
            lblCliente.Text = cliente.Nome;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
