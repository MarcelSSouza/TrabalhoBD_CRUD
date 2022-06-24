namespace TrabalhoBD_CRUD
{
    partial class CRUD_Pet
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Pet));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtCuidados = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btDeletar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisarPorId = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisarPorId = new System.Windows.Forms.ToolStripButton();
            this.txtUltimoDiagnostico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.NumericUpDown();
            this.txtPeso = new System.Windows.Forms.NumericUpDown();
            this.dOMPET43DataSet = new TrabalhoBD_CRUD.DOMPET43DataSet();
            this.dOMPET43DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(134, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(658, 59);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(330, 59);
            this.txtPorte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(85, 22);
            this.txtPorte.TabIndex = 2;
            this.txtPorte.TextChanged += new System.EventHandler(this.txtPorte_TextChanged);
            // 
            // txtCuidados
            // 
            this.txtCuidados.Location = new System.Drawing.Point(191, 114);
            this.txtCuidados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuidados.Name = "txtCuidados";
            this.txtCuidados.Size = new System.Drawing.Size(224, 22);
            this.txtCuidados.TabIndex = 4;
            this.txtCuidados.TextChanged += new System.EventHandler(this.txtCuidados_TextChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(556, 59);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(83, 22);
            this.txtGenero.TabIndex = 6;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(444, 59);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(88, 22);
            this.txtEspecie.TabIndex = 7;
            this.txtEspecie.TextChanged += new System.EventHandler(this.txtEspecie_TextChanged);
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(28, 114);
            this.txtRaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(134, 22);
            this.txtRaca.TabIndex = 8;
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
            this.txtPesquisa,
            this.btPesquisar,
            this.toolStripLabel2,
            this.txtPesquisarPorId,
            this.btPesquisarPorId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 27);
            this.toolStrip1.TabIndex = 9;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 24);
            this.toolStripLabel1.Text = "Pesquisa por Nome:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(132, 27);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 24);
            this.toolStripLabel2.Text = "Por ID:";
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
            // txtUltimoDiagnostico
            // 
            this.txtUltimoDiagnostico.Enabled = false;
            this.txtUltimoDiagnostico.Location = new System.Drawing.Point(444, 114);
            this.txtUltimoDiagnostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUltimoDiagnostico.Multiline = true;
            this.txtUltimoDiagnostico.Name = "txtUltimoDiagnostico";
            this.txtUltimoDiagnostico.Size = new System.Drawing.Size(282, 22);
            this.txtUltimoDiagnostico.TabIndex = 10;
            this.txtUltimoDiagnostico.TextChanged += new System.EventHandler(this.txtUltimoDiagnostico_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ultimo Diagnostico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Raça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Idade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Espécie (C/G)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Porte (P/M/G)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Peso";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gênero (M/F)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cuidados";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(191, 59);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(50, 22);
            this.txtIdade.TabIndex = 21;
            this.txtIdade.ValueChanged += new System.EventHandler(this.txtIdade_ValueChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.DecimalPlaces = 2;
            this.txtPeso.Location = new System.Drawing.Point(252, 59);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(68, 22);
            this.txtPeso.TabIndex = 22;
            this.txtPeso.ValueChanged += new System.EventHandler(this.txtPeso_ValueChanged);
            // 
            // dOMPET43DataSet
            // 
            this.dOMPET43DataSet.DataSetName = "DOMPET43DataSet";
            this.dOMPET43DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOMPET43DataSetBindingSource
            // 
            this.dOMPET43DataSetBindingSource.DataSource = this.dOMPET43DataSet;
            this.dOMPET43DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(698, 244);
            this.dataGridView1.TabIndex = 23;
            // 
            // CRUD_Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUltimoDiagnostico);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtCuidados);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CRUD_Pet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DOMPET43";
            this.Load += new System.EventHandler(this.formDOMPET43_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.TextBox txtCuidados;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btSalvar;
        private System.Windows.Forms.ToolStripButton btDeletar;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripButton btPesquisar;
        private System.Windows.Forms.TextBox txtUltimoDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtIdade;
        private System.Windows.Forms.NumericUpDown txtPeso;
        private System.Windows.Forms.BindingSource dOMPET43DataSetBindingSource;
        private DOMPET43DataSet dOMPET43DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtPesquisarPorId;
        private System.Windows.Forms.ToolStripButton btPesquisarPorId;
    }
}

