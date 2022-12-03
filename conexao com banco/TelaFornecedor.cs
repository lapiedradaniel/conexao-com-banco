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
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
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
                strSQL = "INSERT INTO `bd_exercicio`.`fornecedor` (`idcnpj`, `razao_social`, `endereco`, `email`, `fantasia`, `telefone`, `inscricao_estadual`) VALUES (@idcnpj, @razao_social, @endereco, @email, @fantasia, @telefone, @inscricao_estadual);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idcnpj", txtcnpj.Text);
                comando.Parameters.AddWithValue("@razao_social", txtsocial.Text);
                comando.Parameters.AddWithValue("@endereco", txtendereco.Text);
                comando.Parameters.AddWithValue("@email", txtemail.Text);
                comando.Parameters.AddWithValue("@fantasia", txtfantasia.Text);
                comando.Parameters.AddWithValue("@telefone", msktelefone.Text);
                comando.Parameters.AddWithValue("@inscricao_estadual", txtinscricao.Text);
               MessageBox.Show("cadastrado");

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
                strSQL = "SELECT * FROM bd_exercicio.fornecedor WHERE(`idcnpj` = @idcnpj);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idcnpj", txtcnpj.Text);


                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtcnpj.Text = Convert.ToString(dr["idcnpj"]);
                    txtsocial.Text = Convert.ToString(dr["razao_social"]);
                    txtendereco.Text = Convert.ToString(dr["endereco"]);
                    txtemail.Text = Convert.ToString(dr["email"]);
                    txtfantasia.Text = Convert.ToString(dr["fantasia"]);
                    msktelefone.Text = Convert.ToString(dr["telefone"]);
                    txtinscricao.Text = Convert.ToString(dr["inscricao_estadual"]);
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

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
                strSQL = "DELETE FROM `bd_exercicio`.`fornecedor` WHERE(`idcnpj` = @idcnpj);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idcnpj", txtcnpj.Text);
                MessageBox.Show("Excluido");

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
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_exercicio;User=root;Pwd=1234");
                strSQL = "UPDATE `bd_exercicio`.`fornecedor` SET `idcnpj` = @idcnpj, `razao_social` = @razao_social, `endereco` = @endereco, `email` = @email, `fantasia` = @fantasia, `telefone` = @telefone, `inscricao_estadual` = @inscricao_estadual WHERE(`idcnpj` = @idcnpj);";
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@idcnpj", txtcnpj.Text);
                comando.Parameters.AddWithValue("@razao_social", txtsocial.Text);
                comando.Parameters.AddWithValue("@endereco", txtendereco.Text);
                comando.Parameters.AddWithValue("@email", txtemail.Text);
                comando.Parameters.AddWithValue("@fantasia", txtfantasia.Text);
                comando.Parameters.AddWithValue("@telefone", msktelefone.Text);
                comando.Parameters.AddWithValue("@inscricao_estadual", txtinscricao.Text);
                MessageBox.Show("Dados alterados");

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
    }
}
