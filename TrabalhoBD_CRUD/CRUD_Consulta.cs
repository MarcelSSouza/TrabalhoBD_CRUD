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
    public partial class Consulta : Form
    {
        private SqlConnection sqlCon;
        private string strSql;
        private string strCon = "Data Source=PET-PC;Initial Catalog=DOMPET43;Integrated Security=True"; //STRING DE CONEXAO!!
        public Consulta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            strSql = "Exec InserirConsulta ( @IdVeterinario,@NifDono,@Preco,@UltimoDiagnostico, @Procedimentos,@IdPet, @DataConsulta);";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@IdVeterinario", SqlDbType.Int).Value = txtIdVeterinario.Text;
            comando.Parameters.Add("@NifDono", SqlDbType.Int).Value = txtNifDono.Text;
            comando.Parameters.Add("@Preco", SqlDbType.Float).Value = txtPreco.Text;
            comando.Parameters.Add("@UltimoDiagnostico", SqlDbType.VarChar).Value = txtDiagnostico.Text;
            comando.Parameters.Add("@Procedimentos", SqlDbType.VarChar).Value = txtProcedimento.Text;
            comando.Parameters.Add("@IdPet", SqlDbType.Int).Value = txtIdPet.Text;
            comando.Parameters.Add("@DataConsulta", SqlDbType.Date).Value =  Convert.ToDateTime(txtDataConsulta.Text);
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DA CONSULTA REALIZADA COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtProcedimento.Text = "";
                txtPreco.Text = "";
                txtDiagnostico.Text = "";
                txtIdPet.Text = "";
                txtIdVeterinario.Text = "";
                txtNifDono.Text = "";
                txtDataConsulta.Text = "";
                sqlCon.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDataConsulta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
