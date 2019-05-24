using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaMysqlWinForms.Entidades
{
    public class Cliente
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cpf;
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
