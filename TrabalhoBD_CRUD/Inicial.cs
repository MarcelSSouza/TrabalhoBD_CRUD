using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBD_CRUD
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            CRUD_Cliente cRUD_Cliente = new CRUD_Cliente();
            cRUD_Cliente.ShowDialog();
        }

        private void btPet_Click(object sender, EventArgs e)
        {
            CRUD_Pet pet = new CRUD_Pet();
            pet.ShowDialog();
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            CRUD_Produto pd = new CRUD_Produto();
            pd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.ShowDialog();
        }
    }
}
