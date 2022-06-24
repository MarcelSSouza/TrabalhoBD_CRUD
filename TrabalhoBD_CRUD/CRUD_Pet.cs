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
    public partial class CRUD_Pet : Form
    {
        private SqlConnection sqlCon;
        private string strSql;
        private string strCon = "Data Source=PET-PC;Initial Catalog=DOMPET43;Integrated Security=True";

        public CRUD_Pet()
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
            sqlCon.Open();
            SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosPet", sqlCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }





        private void btSalvar_Click(object sender, EventArgs e)
        {
            strSql = "Exec InserirPet @Nome,@Idade, @Genero,@Raca,@Especie,@Peso,@Porte,@Cuidados ";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Idade", SqlDbType.Int).Value = txtIdade.Text;
            comando.Parameters.Add("@Genero", SqlDbType.Char).Value = txtGenero.Text;
            comando.Parameters.Add("@Raca", SqlDbType.VarChar).Value = txtRaca.Text;
            comando.Parameters.Add("@Especie", SqlDbType.Char).Value = txtEspecie.Text;
            comando.Parameters.Add("@Peso", SqlDbType.Float).Value = txtPeso.Text;
            comando.Parameters.Add("@Porte", SqlDbType.Char).Value = txtPorte.Text;
            comando.Parameters.Add("@Cuidados", SqlDbType.VarChar).Value = txtCuidados.Text;
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
                SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosPet", sqlCon);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            strSql = "EXEC PesquisaPetNome @Nome";
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
                txtCuidados.Text = Convert.ToString(dr["Cuidados"]);
                txtUltimoDiagnostico.Text= Convert.ToString(dr["UltimoDiagnostico"]);
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
            if (MessageBox.Show("Deseja Realmente excluir este PET da base de dados?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                MessageBox.Show("Operação Cancelada");
            }

            else
            {
                strSql = "Exec DeletePet @Nome, @IdPet";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtId.Text;


                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EXCLUSÃO DO PET REALIZADA COM SUCESSO!");
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosPet", sqlCon);
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
            strSql = "EXEC UpdatePet @Nome, @Idade, @Genero, @Raca, @Especie, @Peso ,@Porte ,@Cuidados ,@IdPet";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Idade", SqlDbType.Int).Value = txtIdade.Text;
            comando.Parameters.Add("@Genero", SqlDbType.Char).Value = txtGenero.Text;
            comando.Parameters.Add("@Raca", SqlDbType.VarChar).Value = txtRaca.Text;
            comando.Parameters.Add("@Especie", SqlDbType.Char).Value = txtEspecie.Text;
            comando.Parameters.Add("@Peso", SqlDbType.Float).Value = txtPeso.Text;
            comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("@Porte", SqlDbType.Char).Value = txtPorte.Text;
            comando.Parameters.Add("@Cuidados", SqlDbType.VarChar).Value = txtCuidados.Text;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("ALTERAÇÃO DO PET REALIZADA COM SUCESSO!");
                SqlDataAdapter ad = new SqlDataAdapter("EXEC DadosPet", sqlCon);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
                txtIdade.Text = dataGridView1.Rows[e.RowIndex].Cells["Idade"].FormattedValue.ToString();
                txtGenero.Text = dataGridView1.Rows[e.RowIndex].Cells["Genero"].FormattedValue.ToString();
                txtRaca.Text = dataGridView1.Rows[e.RowIndex].Cells["Raca"].FormattedValue.ToString();
                txtEspecie.Text = dataGridView1.Rows[e.RowIndex].Cells["Especie"].FormattedValue.ToString();
                txtPeso.Text = dataGridView1.Rows[e.RowIndex].Cells["Peso"].FormattedValue.ToString();
                txtPorte.Text = dataGridView1.Rows[e.RowIndex].Cells["Porte"].FormattedValue.ToString();
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["IdPet"].FormattedValue.ToString();
            }
        }

        private void txtCuidados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPesquisarPorId_Click(object sender, EventArgs e)
        {
            btDeletar.Enabled = true;
            btEditar.Enabled = true;
            txtId.Enabled = false;
            strSql = "EXEC PesquisaPetId @IdPet";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtPesquisarPorId.Text;

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
                    throw new Exception("PET não presente no banco de dados!");
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
                txtCuidados.Text = Convert.ToString(dr["Cuidados"]);
                txtUltimoDiagnostico.Text = Convert.ToString(dr["UltimoDiagnostico"]);
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

        private void txtUltimoDiagnostico_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIdade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPorte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
