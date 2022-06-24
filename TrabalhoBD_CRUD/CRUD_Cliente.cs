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

namespace TrabalhoBD_CRUD
{
    public partial class CRUD_Cliente : Form
    { 
        private SqlConnection sqlCon;
        private string strSql;
        private string strCon = "Data Source=PET-PC;Initial Catalog=DOMPET43;Integrated Security=True";
        public CRUD_Cliente()
        {
            InitializeComponent();
        }

        private SqlConnection getSGBDConnection()
        {

            return new SqlConnection(strCon);
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            strSql = "Exec InserirCliente @Nif, @Nome, @Telefone, @Endereco, @IdPet";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nif", SqlDbType.Int).Value = txtNif.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtId.Text;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO CLIENTE REALIZADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally

            {
                txtNome.Text = "";
                txtId.Text = "";
                txtNif.Text = "";
                txtTelefone.Text = "";
                txtId.Text = "";
                txtEndereco.Text = "";
                SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosCliente", sqlCon);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }


        }

        private void CRUD_Cliente_Load(object sender, EventArgs e)
        {
            
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosCliente", sqlCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtId.Text = "";
            txtNif.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

            strSql = "EXEC PesquisaClienteIdPet @IdPet";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtPesquisaPorPet.Text;

            try
            {
                if (txtPesquisaPorPet.Text == String.Empty)
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
                txtId.Text = Convert.ToString(dr["IdPet"]);
                txtTelefone.Text = Convert.ToString(dr["Telefone"]);
                txtNif.Text = Convert.ToString(dr["Nif"]);
                txtEndereco.Text = Convert.ToString(dr["Endereco"]);
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

        private void btPesquisarPorId_Click(object sender, EventArgs e)
        {
            strSql = "Exec PesquisaClienteNif @Nif";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nif", SqlDbType.Int).Value = txtPesquisarPorId.Text;

            try
            {
                if (txtPesquisarPorId.Text == String.Empty)
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
                txtId.Text = Convert.ToString(dr["IdPet"]);
                txtTelefone.Text = Convert.ToString(dr["Telefone"]);
                txtNif.Text = Convert.ToString(dr["Nif"]);
                txtEndereco.Text = Convert.ToString(dr["Endereco"]);
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

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir este cliente da base de dados?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                MessageBox.Show("Operação Cancelada");
            }

            else
            {
                strSql = "Exec DeleteClienteNif @Nif";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@Nif", SqlDbType.Int).Value = txtNif.Text;


                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EXCLUSÃO DO CLIENTE REALIZADA COM SUCESSO!");
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosCliente", sqlCon);
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
                    txtNif.Text = "";
                    txtEndereco.Text = "";
                    txtTelefone.Text = "";
                    sqlCon.Close();
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            strSql = "EXEC UpdateCliente @Nif, @Nome, @Telefone, @Endereco, @IdPet";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nif", SqlDbType.Int).Value = txtNif.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtId.Text;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO CLIENTE REALIZADA COM SUCESSO!");
                SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosCliente", sqlCon);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

