using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace TrabalhoBD_CRUD
{
    public partial class CRUD_Produto : Form
    {
        private SqlConnection sqlCon;
        private string strSql;
        private string strCon = "Data Source=PET-PC;Initial Catalog=DOMPET43;Integrated Security=True";

        public CRUD_Produto()
        {
            InitializeComponent();
            txtId.Enabled = false;

        }

        private SqlConnection getSGBDConnection()
        {

            return new SqlConnection(strCon);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            strSql = "EXEC InserirProduto @Nome, @Preco, @Quantidade, @Hipoalergenico, @Vencimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Preco", SqlDbType.Float).Value = txtPreco.Text;
            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = txtQuantidade.Text;
            comando.Parameters.Add("@Hipoalergenico", SqlDbType.Bit).Value = checkboxHipoalergenico.Checked == true ? 1 : 0;
            comando.Parameters.Add("@Vencimento", SqlDbType.Date).Value = Convert.ToDateTime(txtVencimento.Text);
            txtId.Enabled = false;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO PRODUTO REALIZADO COM SUCESSO!");
                SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosProduto", sqlCon);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally

            {
                txtNome.Text = "";
                txtId.Text = "";
                txtPreco.Text = "";
                txtQuantidade.Text = "";
                txtVencimento.Text = "";
                sqlCon.Close();
            }
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void CRUD_Produto_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosProduto", sqlCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir este PRODUTO da base de dados?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                MessageBox.Show("Operação Cancelada");
            }

            else
            {
                strSql = "EXEC DeleteProdutoNomeId @IdProduto, @Nome ";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@IdProduto", SqlDbType.Int).Value = txtId.Text;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EXCLUSÃO DO PRODUTO REALIZADA COM SUCESSO!");
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosProduto", sqlCon);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtNome.Text = "";
                    txtId.Text = "";
                    txtPreco.Text = "";
                    txtQuantidade.Text = "";
                    txtVencimento.Text = "";
                    sqlCon.Close();
                }
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            {
                strSql = "EXEC PesquisaProdutoNome @Nome";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtPesquisa.Text;

                try
                {
                    if (txtPesquisa.Text == String.Empty)
                    {
                        throw new Exception("Digite algo!");
                    }

                    sqlCon.Open();

                    SqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows == false)
                    {
                        throw new Exception("Nome não presente no banco de dados!");
                    }

                    dr.Read();

                    txtNome.Text = Convert.ToString(dr["Nome"]);
                    txtId.Text = Convert.ToString(dr["IdProduto"]);
                    txtPreco.Text = Convert.ToString(dr["Preco"]);
                    txtQuantidade.Text = Convert.ToString(dr["Quantidade"]);
                    txtVencimento.Text = Convert.ToString(dr["Vencimento"]);
                    if (Convert.ToString(dr["Hipoalergenico"]) == "True")
                    {
                        checkboxHipoalergenico.Checked = true;
                    }
                    else
                    {
                        checkboxHipoalergenico.Checked = false;
                    }

                    dr.Close();
                    SqlDataAdapter ad = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    sqlCon.Close();
                }


            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            strSql = "Exec UpdateProduto  @Nome, @Preco, @Quantidade, @Hipoalergenico, @Vencimento, @IdProduto ";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Preco", SqlDbType.Float).Value = txtPreco.Text;
            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = txtQuantidade.Text;
            comando.Parameters.Add("@IdProduto", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("@Hipoalergenico", SqlDbType.Bit).Value = checkboxHipoalergenico.Checked ==true? 1:0;
            comando.Parameters.Add("@Vencimento", SqlDbType.Date).Value = Convert.ToDateTime(txtVencimento.Text);
            txtId.Enabled = false;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO PRODUTO REALIZADA COM SUCESSO!");
                SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosProduto", sqlCon);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btPesquisaPorId_Click(object sender, EventArgs e)
        {
            {
                strSql = "EXEC PesquisaProdutoId @IdProduto";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@IdProduto", SqlDbType.Int).Value = txtPesquisaPorId.Text;

                try
                {
                    if (txtPesquisaPorId.Text== String.Empty)
                    {
                        throw new Exception("Digite algo!");
                    }

                    sqlCon.Open();

                    SqlDataReader dr = comando.ExecuteReader();

                    if (dr.HasRows == false)
                    {
                        throw new Exception("ID não presente no banco de dados!");
                    }

                    dr.Read();

                    txtNome.Text = Convert.ToString(dr["Nome"]);
                    txtId.Text = Convert.ToString(dr["IdProduto"]);
                    txtPreco.Text = Convert.ToString(dr["Preco"]);
                    txtQuantidade.Text = Convert.ToString(dr["Quantidade"]);
                    txtVencimento.Text = Convert.ToString(dr["Vencimento"]);
                    if (Convert.ToString(dr["Hipoalergenico"]) == "True")
                    {
                        checkboxHipoalergenico.Checked = true;
                    }
                    else
                    {
                        checkboxHipoalergenico.Checked = false;
                    }

                    dr.Close();

                    SqlDataAdapter ad = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    sqlCon.Close();
                }


            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            txtVencimento.Text = "";
            checkboxHipoalergenico.Checked = false;
        }

        private void btValidade_Click(object sender, EventArgs e)
        {
            strSql = "EXEC ValidadeProxima";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            SqlDataAdapter ad = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
