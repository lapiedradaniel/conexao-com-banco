using MySql.Data.MySqlClient;
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
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;
        
        

        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
                strSQL = "INSERT INTO `bd_exercicio`.`produto` (`idProduto`, `descricao`, `dtavalidade`, `preco`, `estoque`,`codigo`) VALUES (@idProduto, @descricao, @dtavalidade, @preco, @estoque,@codigo);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idProduto", txtidProduto.Text);
                comando.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                comando.Parameters.AddWithValue("@dtavalidade", mskvalidade.Text);
                comando.Parameters.AddWithValue("@preco", txtpreco.Text);
                comando.Parameters.AddWithValue("@estoque", txtquantidade.Text);
                comando.Parameters.AddWithValue("@codigo", txtcodigo.Text);
                MessageBox.Show("Produto cadastrado");

                conexao.Open();

                comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
                strSQL = "DELETE FROM `bd_exercicio`.`produto` WHERE(`idProduto` = @idProduto);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idProduto", txtidProduto.Text);
                MessageBox.Show("Produto excluido");

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
                strSQL = strSQL = "UPDATE `bd_exercicio`.`produto` SET `idProduto` = @idProduto, `descricao` = @descricao, `dtavalidade` = @dtavalidade, `preco` = @preco, `quantidade` = @quantidade, `codigo` = @codigo, WHERE(`idProduto` = @idProduto);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idProduto", txtidProduto.Text);               
                comando.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                comando.Parameters.AddWithValue("@dtavalidade", mskvalidade.Text);
                comando.Parameters.AddWithValue("@preco", txtpreco.Text);
                comando.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                comando.Parameters.AddWithValue("@codigo", txtcodigo.Text);
                MessageBox.Show("Dados Alterados");

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
                strSQL = "SELECT * FROM bd_exercicio.produto WHERE(`idProduto` = @idProduto);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idProduto", txtidProduto.Text);


                conexao.Open();




                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtidProduto.Text = Convert.ToString(dr["idProduto"]);
                    txtdescricao.Text = Convert.ToString(dr["descricao"]);
                    mskvalidade.Text = Convert.ToString(dr["dtavalidade"]);
                    txtpreco.Text = Convert.ToString(dr["preco"]);
                    txtquantidade.Text = Convert.ToString(dr["quantidade"]);
                    txtcodigo.Text = Convert.ToString(dr["codigo"]);
                }

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
