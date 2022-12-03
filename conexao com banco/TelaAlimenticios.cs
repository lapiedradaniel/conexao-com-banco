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
    public partial class TelaAlimenticios : Form
    {
        public TelaAlimenticios()
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
                strSQL = "INSERT INTO `bd_exercicio`.`alimenticio` (`idmedida`, `tipo`) VALUES (@idmedida, @tipo);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idmedida", txtmedida.Text);
                comando.Parameters.AddWithValue("@tipo", txttipo.Text);
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
                strSQL = "DELETE FROM `bd_exercicio`.`alimenticio` WHERE(`idmedida` = @idmedida);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idmedida", txtmedida.Text);
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
                strSQL = strSQL = "UPDATE `bd_exercicio`.`alimenticio` SET `idmedida` = @idmedida, `tipo` = @tipo WHERE(`idmedia` = @idmedida);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@medida", txtmedida.Text);
                comando.Parameters.AddWithValue("@tipo", txttipo.Text);
                MessageBox.Show("alterado");

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
                strSQL = "SELECT * FROM bd_exercicio.alimenticio WHERE(`idmedida` = @idmedida);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idmedida", txtmedida.Text);


                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtmedida.Text = Convert.ToString(dr["idmedida"]);
                    txttipo.Text = Convert.ToString(dr["tipo"]);
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
