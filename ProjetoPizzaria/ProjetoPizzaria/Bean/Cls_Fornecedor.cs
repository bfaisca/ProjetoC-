using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPizzaria.Bean
{
    class Cls_Fornecedor
    {
        private string _nome;
        private string _cadastro;
        private Cls_Endereco _endereco;
        private string _telefone;
        public string Nome { get => _nome; set => _nome = value; }
        public string Cadastro { get => _cadastro; set => _cadastro = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        internal Cls_Endereco Endereco { get => _endereco; set => _endereco = value; }
    }
}
