using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Bean
{
    class Cls_Cliente
    {
        private int _codigo;
        private string _nome;
        private string _cadastro;
        private string _telefone;
        private Cls_Endereco _endereco = new Cls_Endereco();
        private string _email;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cadastro { get => _cadastro; set => _cadastro = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email { get => _email; set => _email = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        internal Cls_Endereco Endereco { get => _endereco; set => _endereco = value; }
    }
    class Cls_Endereco
    {
        private string _endereco;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _uf;
        private string _cep;

        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Cep { get => _cep; set => _cep = value; }
    }
}
