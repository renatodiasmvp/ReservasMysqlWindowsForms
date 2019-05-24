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
        // objeto da classe ReservaTemporaria
        // que vai receber os dados do objeto
        // passado pelo Form1 como parametro
        ReservaTemporaria reservaTemporaria;

        // Criado um objeto da classe Cliente
        // Esse objeto será preenchido após incluir um novo cliente
        // Esse objeto será adicionado ao Form3 como parametro do seu construtor
        // o objeto vai com seus dados para o Form3
        Cliente cliente = new Cliente();

        // Classe criada para acesso e persistencia de dados de cliente
        ClienteDados clienteDados = new ClienteDados();

        // esse é o construtor do Form2 que tem um objeto da classe ReservaTemporaria como parametro
        public Form2(ReservaTemporaria reserva)
        {
            InitializeComponent();

            // o objeto da classe ReservaTemporaria criado para este form
            // está recebendo o objeto que foi passado como parametro pelo Form1
            reservaTemporaria = reserva;
            // o TextBox txtTipoQuarto está recebendo o valor
            // da propriedade TipoQuarto do objeto reservaTemporaria
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

            // Preenchendo o objeto cliente com os dados digitados no Form2
            cliente.Id = 0;
            cliente.Nome = txtNomeCliente.Text;
            cliente.CPF = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Email = txtEmail.Text;
        }

        private void btnOutroForm_Click(object sender, EventArgs e)
        {
            // criada uma instancia do Form3
            // e passado o objeto cliente como parametro do seu construtor
            Form3 TerceiroForm = new Form3(cliente);
            // abrindo esta instancia do Form3
            TerceiroForm.Show();
        }
    }
}
