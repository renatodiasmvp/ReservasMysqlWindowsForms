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
using ReservaMysqlWinForms.AcessoDados;

namespace ReservaMysqlWinForms
{
    public partial class Form2 : Form
    {
        ReservaTemporaria reservaTemporaria;

        Cliente cliente = new Cliente();

        ClienteDados clienteDados = new ClienteDados();

        public Form2(ReservaTemporaria reserva)
        {
            InitializeComponent();

            reservaTemporaria = reserva;

            txtTipoQuarto.Text = reservaTemporaria.TipoQuarto;            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            clienteDados.Incluir(txtNomeCliente.Text, txtCpf.Text, txtTelefone.Text, txtEndereco.Text, txtEmail.Text);

            cliente.Id = 0;
            cliente.Nome = txtNomeCliente.Text;
            cliente.CPF = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Email = txtEmail.Text;
        }

        private void btnOutroForm_Click(object sender, EventArgs e)
        {
            Form3 TerceiroForm = new Form3(cliente);

            TerceiroForm.Show();
        }
    }
}
