using ProjetoPizzaria.Acoes;
using ProjetoPizzaria.Bean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria.Formulario
{
    public partial class Frm_CadCliente : Form
    {
        public Frm_CadCliente()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Cls_Cliente objcliente = new Cls_Cliente();
            Cls_ClienteAcoes objClienteAcao = new Cls_ClienteAcoes();

            objcliente.Nome = Txt_Nome.Text;
            objcliente.Cadastro = Txt_Cadastro.Text;
            objcliente.Email= Txt_Email.Text;
            objcliente.Telefone= Txt_Nome.Text;
            objcliente.Endereco.Endereco = Txt_Rua.Text;
            objcliente.Endereco.Cidade= Txt_Cidade.Text;
            objcliente.Endereco.Bairro = Txt_Bairro.Text;
            objcliente.Endereco.Numero = Txt_Numero.Text;
            objcliente.Endereco.Cep = Txt_CEP.Text;
            objcliente.Endereco.Uf = Txt_UF.Text;

            objClienteAcao.Inserir(objcliente);

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Cls_ClienteAcoes objClienteAcao = new Cls_ClienteAcoes();
            GrdView_Cliente.DataSource= objClienteAcao.consultaCliente(Txt_NomePesquisa.Text, Txt_CadastroPesquisa.Text, Convert.ToInt32(Txt_CodigoPesquisa.Text));
        }
    }
}
