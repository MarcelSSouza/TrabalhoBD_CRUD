namespace TrabalhoBD_CRUD
{
    partial class CRUD_Produto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Produto));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.checkboxHipoalergenico = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOMPET43DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOMPET43DataSet = new TrabalhoBD_CRUD.DOMPET43DataSet();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btDeletar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisaPorId = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisaPorId = new System.Windows.Forms.ToolStripButton();
            this.txtPreco = new System.Windows.Forms.NumericUpDown();
            this.dOMPET43DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btValidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 60);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(533, 58);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 22);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(19, 38);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(530, 38);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidades";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Location = new System.Drawing.Point(227, 38);
            this.preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(43, 16);
            this.preco.TabIndex = 11;
            this.preco.Text = "Preço";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(324, 59);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 22);
            this.txtQuantidade.TabIndex = 12;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkboxHipoalergenico
            // 
            this.checkboxHipoalergenico.AutoSize = true;
            this.checkboxHipoalergenico.Location = new System.Drawing.Point(621, 60);
            this.checkboxHipoalergenico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxHipoalergenico.Name = "checkboxHipoalergenico";
            this.checkboxHipoalergenico.Size = new System.Drawing.Size(122, 20);
            this.checkboxHipoalergenico.TabIndex = 13;
            this.checkboxHipoalergenico.Text = "Hipoalergênico";
            this.checkboxHipoalergenico.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(721, 263);
            this.dataGridView1.TabIndex = 14;
            // 
            // dOMPET43DataSetBindingSource
            // 
            this.dOMPET43DataSetBindingSource.DataSource = this.dOMPET43DataSet;
            this.dOMPET43DataSetBindingSource.Position = 0;
            // 
            // dOMPET43DataSet
            // 
            this.dOMPET43DataSet.DataSetName = "DOMPET43DataSet";
            this.dOMPET43DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtVencimento
            // 
            this.txtVencimento.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(419, 58);
            this.txtVencimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(88, 22);
            this.txtVencimento.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vencimento";
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
            this.txtPesquisaPorId,
            this.btPesquisaPorId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(771, 27);
            this.toolStrip1.TabIndex = 18;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabel2.Text = "Por Id:";
            // 
            // txtPesquisaPorId
            // 
            this.txtPesquisaPorId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesquisaPorId.Name = "txtPesquisaPorId";
            this.txtPesquisaPorId.Size = new System.Drawing.Size(132, 27);
            // 
            // btPesquisaPorId
            // 
            this.btPesquisaPorId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPesquisaPorId.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisaPorId.Image")));
            this.btPesquisaPorId.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPesquisaPorId.Name = "btPesquisaPorId";
            this.btPesquisaPorId.Size = new System.Drawing.Size(29, 24);
            this.btPesquisaPorId.Text = "toolStripButton1";
            this.btPesquisaPorId.Click += new System.EventHandler(this.btPesquisaPorId_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.DecimalPlaces = 2;
            this.txtPreco.Location = new System.Drawing.Point(230, 59);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(69, 22);
            this.txtPreco.TabIndex = 19;
            this.txtPreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dOMPET43DataSetBindingSource1
            // 
            this.dOMPET43DataSetBindingSource1.DataSource = this.dOMPET43DataSet;
            this.dOMPET43DataSetBindingSource1.Position = 0;
            // 
            // btValidade
            // 
            this.btValidade.Location = new System.Drawing.Point(507, 382);
            this.btValidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btValidade.Name = "btValidade";
            this.btValidade.Size = new System.Drawing.Size(236, 28);
            this.btValidade.TabIndex = 20;
            this.btValidade.Text = "Verificação de Validade (30 dias)";
            this.btValidade.UseVisualStyleBackColor = true;
            this.btValidade.Click += new System.EventHandler(this.btValidade_Click);
            // 
            // CRUD_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 423);
            this.Controls.Add(this.btValidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkboxHipoalergenico);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CRUD_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRUD_Produto";
            this.Load += new System.EventHandler(this.CRUD_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOMPET43DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.CheckBox checkboxHipoalergenico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dOMPET43DataSetBindingSource;
        private DOMPET43DataSet dOMPET43DataSet;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btSalvar;
        private System.Windows.Forms.ToolStripButton btDeletar;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripButton btPesquisar;
        private System.Windows.Forms.NumericUpDown txtPreco;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtPesquisaPorId;
        private System.Windows.Forms.ToolStripButton btPesquisaPorId;
        private System.Windows.Forms.BindingSource dOMPET43DataSetBindingSource1;
        private System.Windows.Forms.Button btValidade;
    }
}