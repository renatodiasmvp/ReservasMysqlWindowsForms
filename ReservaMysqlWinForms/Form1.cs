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
    public partial class Form1 : Form
    {
        

        public string TipoQuartoSelecionado = "";
        ReservaTemporaria reservaTemp = new ReservaTemporaria();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();

            reserva.Incluir(0, DateTime.Parse(txtDataEntrada.Text), DateTime.Parse(txtDataSaida.Text), Double.Parse(txtValorTotal.Text));

            reservaTemp.DataEntrada = DateTime.Parse(txtDataEntrada.Text);
            reservaTemp.DataSaida = DateTime.Parse(txtDataSaida.Text);
            reservaTemp.ValorTotal = Double.Parse(txtValorTotal.Text);

            //var dados = reserva.BuscaReserva(DateTime.Parse(txtDataEntrada.Text), DateTime.Parse(txtDataSaida.Text), Double.Parse(txtValorTotal.Text));
            var dados = reserva.Listar();

            int colunas = dados.FieldCount;
            for (int i = 0; i < colunas; i++)
            {
                dgvReservas.Columns.Add(dados.GetName(i).ToString(), dados.GetName(i).ToString());
            }

            string[] linhaDados = new string[colunas];

            while (dados.Read())
            {
                for (int a = 0; a < colunas; a++)
                {
                    //verifica o tipo de dados da coluna
                    if (dados.GetFieldType(a).ToString() == "System.Int32")
                    {
                        linhaDados[a] = dados.GetInt32(a).ToString();
                    }
                    if (dados.GetFieldType(a).ToString() == "System.String")
                    {
                        linhaDados[a] = dados.GetString(a).ToString();
                    }
                    if (dados.GetFieldType(a).ToString() == "System.DateTime")
                    {
                        linhaDados[a] = dados.GetDateTime(a).ToString();
                    }
                    if (dados.GetFieldType(a).ToString() == "System.Double")
                    {
                        linhaDados[a] = dados.GetDouble(a).ToString();
                    }
                    if (dados.GetFieldType(a).ToString() == "System.Decimal")
                    {
                        linhaDados[a] = dados.GetDecimal(a).ToString();
                    }
                }
                //atribui a linha ao datagridview
                dgvReservas.Rows.Add(linhaDados);
            }

           

            
        }

        private void chkSolteiro_CheckedChanged(object sender, EventArgs e)
        {
            chkCasal.Checked = false;
            chkCompartilhado.Checked = false;
        }

        private void chkCasal_CheckedChanged(object sender, EventArgs e)
        {
            chkSolteiro.Checked = false;
            chkCompartilhado.Checked = false;
        }

        private void chkCompartilhado_CheckedChanged(object sender, EventArgs e)
        {
            chkCasal.Checked = false;
            chkSolteiro.Checked = false;
        }

        private void btnAbreOutroForm_Click(object sender, EventArgs e)
        {
            if (chkSolteiro.Checked)
            {
                reservaTemp.TipoQuarto = "Solteiro";
            }
            else if (chkCasal.Checked)
            {
                reservaTemp.TipoQuarto = "Casal";
            }
            else if (chkCompartilhado.Checked)
            {
                reservaTemp.TipoQuarto = "Compartilhado";
            }

            Form2 SegundoForm = new Form2(reservaTemp);
            SegundoForm.Show();
        }
    }
}
