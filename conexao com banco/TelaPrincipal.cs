using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexao_com_banco
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela;

        private void btnproduto_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaProduto();
            {
                TopLevel = false;
                FormBorderStyle = FormBorderStyle.None;
                Dock = DockStyle.Fill;
            };
            
            
            tela.Show();

        }
        

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaFornecedor();
            {
                TopLevel = false;
                FormBorderStyle = FormBorderStyle.None;
                Dock = DockStyle.Fill;
            };
           
            tela.Show();
        }

        private void btnalimenticio_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaAlimenticios();
            {
                TopLevel = false;
                FormBorderStyle = FormBorderStyle.None;
                Dock = DockStyle.Fill;
            };
            
            tela.Show();
        }
    }
}
