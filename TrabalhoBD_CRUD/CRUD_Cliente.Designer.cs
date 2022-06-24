namespace TrabalhoBD_CRUD
{
    partial class CRUD_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btDeletar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisaPorPet = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisarPorId = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisarPorId = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Pet";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSalvar,
            this.btDeletar,
            this.btEditar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtPesquisaPorPet,
            this.btPesquisar,
            this.toolStripLabel2,
            this.txtPesquisarPorId,
            this.btPesquisarPorId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btSalvar
            // 
            this.btSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(29, 24);
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(29, 24);
            this.btDeletar.Text = "Deletar";
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btEditar
            // 
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(29, 24);
            this.btEditar.Text = "Editar";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(119, 24);
            this.toolStripLabel1.Text = "Pesquisa por Pet:";
            // 
            // txtPesquisaPorPet
            // 
            this.txtPesquisaPorPet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesquisaPorPet.Name = "txtPesquisaPorPet";
            this.txtPesquisaPorPet.Size = new System.Drawing.Size(132, 27);
            // 
            // btPesquisar
            // 
            this.btPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(29, 24);
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 24);
            this.toolStripLabel2.Text = "Por NIF:";
            // 
            // txtPesquisarPorId
            // 
            this.txtPesquisarPorId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesquisarPorId.Name = "txtPesquisarPorId";
            this.txtPesquisarPorId.Size = new System.Drawing.Size(132, 27);
            // 
            // btPesquisarPorId
            // 
            this.btPesquisarPorId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPesquisarPorId.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisarPorId.Image")));
            this.btPesquisarPorId.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPesquisarPorId.Name = "btPesquisarPorId";
            this.btPesquisarPorId.Size = new System.Drawing.Size(29, 24);
            this.btPesquisarPorId.Text = "toolStripButton1";
            this.btPesquisarPorId.Click += new System.EventHandler(this.btPesquisarPorId_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 63);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(538, 22);
            this.txtNome.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(594, 119);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(97, 22);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(594, 172);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 22);
            this.txtId.TabIndex = 14;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(20, 119);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(538, 75);
            this.txtEndereco.TabIndex = 15;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(594, 63);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(97, 22);
            this.txtNif.TabIndex = 16;
            this.txtNif.TextChanged += new System.EventHandler(this.txtNif_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(671, 279);
            this.dataGridView1.TabIndex = 17;
            // 
            // CRUD_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CRUD_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRUD_Cliente";
            this.Load += new System.EventHandler(this.CRUD_Cliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btSalvar;
        private System.Windows.Forms.ToolStripButton btDeletar;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisaPorPet;
        private System.Windows.Forms.ToolStripButton btPesquisar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtPesquisarPorId;
        private System.Windows.Forms.ToolStripButton btPesquisarPorId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}