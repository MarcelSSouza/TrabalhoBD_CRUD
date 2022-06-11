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
    public partial class formDOMPET43 : Form
    {
        private SqlConnection sqlCon;
        private int currentContact;
        private bool adding;
        private string strSql;
        private string strCon = "Data Source=MARCEL\\SQLEXPRESS;Initial Catalog=DOMPET43;Integrated Security=True";

        public formDOMPET43()
        {
            InitializeComponent();
        }

        private SqlConnection getSGBDConnection()
        {

            return new SqlConnection(strCon);
        }



        private void formDOMPET43_Load(object sender, EventArgs e)
        {
            sqlCon = getSGBDConnection();
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtPeso.Enabled = false;
            txtRaca.Enabled = false;
            txtEspecie.Enabled = false;
            txtGenero.Enabled = false;
            txtIdade.Enabled = false;
            txtEspecie.Enabled = false;
            txtPorte.Enabled = false;
            btCancelar.Enabled = false;
            btDeletar.Enabled = false;
            btEditar.Enabled = false;
            btSalvar.Enabled = false;
            txtUltimoDiagnostico.Enabled = false;
            txtCuidados.Enabled = false;
            sqlCon.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM PET", sqlCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtId.Text = "";
            txtIdade.Text = "";
            txtRaca.Text = "";
            txtPeso.Text = "";
            txtPorte.Text = "";
            txtEspecie.Text = "";
            txtGenero.Text = "";
            txtUltimoDiagnostico.Text = "";
            txtCuidados.Text = "";
        }

        private string GetStrCon()
        {
            return strCon;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtPeso.Enabled = true;
            txtRaca.Enabled = true;
            txtEspecie.Enabled = true;
            txtGenero.Enabled = true;
            txtIdade.Enabled = true;
            txtEspecie.Enabled = true;
            txtPorte.Enabled = true;
            btCancelar.Enabled = true;
            btDeletar.Enabled = false;
            btEditar.Enabled = false;
            btSalvar.Enabled = true;
            txtUltimoDiagnostico.Enabled = true;
            txtCuidados.Enabled = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            strSql = "INSERT INTO PET (Nome,Idade,Genero,Raca,Especie,Peso,Porte) VALUES(@Nome,@Idade, @Genero,@Raca,@Especie,@Peso,@Porte) ";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Idade", SqlDbType.Int).Value = txtIdade.Text;
            comando.Parameters.Add("@Genero", SqlDbType.Char).Value = txtGenero.Text;
            comando.Parameters.Add("@Raca", SqlDbType.VarChar).Value = txtRaca.Text;
            comando.Parameters.Add("@Especie", SqlDbType.Char).Value = txtEspecie.Text;
            comando.Parameters.Add("@Peso", SqlDbType.Float).Value = txtPeso.Text;
            comando.Parameters.Add("@Porte", SqlDbType.Char).Value = txtPorte.Text;
            txtId.Enabled = false;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DO PET REALIZADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally

            {
                txtNome.Text = "";
                txtId.Text = "";
                txtIdade.Text = "";
                txtRaca.Text = "";
                txtPeso.Text = "";
                txtPorte.Text = "";
                txtEspecie.Text = "";
                txtGenero.Text = "";
                txtUltimoDiagnostico.Text = "";
                txtCuidados.Text = "";
                sqlCon.Close();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            btDeletar.Enabled = true;
            btEditar.Enabled = true;
            txtId.Enabled = false;
            strSql = "SELECT * FROM PET WHERE Nome=@Nome";
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
                txtId.Text = Convert.ToString(dr["IdPet"]);
                txtIdade.Text = Convert.ToString(dr["Idade"]);
                txtRaca.Text = Convert.ToString(dr["Raca"]);
                txtPeso.Text = Convert.ToString(dr["Peso"]);
                txtPorte.Text = Convert.ToString(dr["Porte"]);
                txtEspecie.Text = Convert.ToString(dr["Especie"]);
                txtGenero.Text = Convert.ToString(dr["Genero"]);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlDataAdapter ad = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }

      


        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente excluir este PET da base de dados?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                MessageBox.Show("Operação Cancelada");
            }

            else
            {
                strSql = "DELETE FROM PET WHERE @Nome=Nome AND @IdPet=IdPet";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtId.Text;


                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EXCLUSÃO DO PET REALIZADA COM SUCESSO!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtNome.Text = "";
                    txtId.Text = "";
                    txtIdade.Text = "";
                    txtRaca.Text = "";
                    txtPeso.Text = "";
                    txtPorte.Text = "";
                    txtEspecie.Text = "";
                    txtGenero.Text = "";
                    txtUltimoDiagnostico.Text = "";
                    txtCuidados.Text = "";
                    sqlCon.Close();
                }
            }



        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            strSql = "UPDATE PET SET @Nome=Nome,@Idade=Idade, @Genero=Genero,@Raca=Raca,@Especie=Especie,@Peso=Peso,@Porte=Porte WHERE  @Nome=Nome AND @IdPet=IdPet";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Idade", SqlDbType.Int).Value = txtIdade.Text;
            comando.Parameters.Add("@Genero", SqlDbType.Char).Value = txtGenero.Text;
            comando.Parameters.Add("@Raca", SqlDbType.VarChar).Value = txtRaca.Text;
            comando.Parameters.Add("@Especie", SqlDbType.Char).Value = txtEspecie.Text;
            comando.Parameters.Add("@Peso", SqlDbType.Float).Value = txtPeso.Text;
            comando.Parameters.Add("@Porte", SqlDbType.Char).Value = txtPorte.Text;
            txtId.Enabled = false;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO PET REALIZADA COM SUCESSO!");
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
}
