﻿namespace TrabalhoBD_CRUD
{
    partial class formDOMPET43
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDOMPET43));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtCuidados = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNovo = new System.Windows.Forms.ToolStripButton();
            this.btCancelar = new System.Windows.Forms.ToolStripButton();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btDeletar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btPesquisar = new System.Windows.Forms.ToolStripButton();
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
            this.txtNome.Location = new System.Drawing.Point(22, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(181, 175);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(44, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(181, 133);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(44, 20);
            this.txtPorte.TabIndex = 2;
            // 
            // txtCuidados
            // 
            this.txtCuidados.Location = new System.Drawing.Point(327, 41);
            this.txtCuidados.Multiline = true;
            this.txtCuidados.Name = "txtCuidados";
            this.txtCuidados.Size = new System.Drawing.Size(218, 64);
            this.txtCuidados.TabIndex = 4;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(23, 176);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 6;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(22, 131);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(97, 20);
            this.txtEspecie.TabIndex = 7;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(22, 85);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(100, 20);
            this.txtRaca.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovo,
            this.btCancelar,
            this.btSalvar,
            this.btDeletar,
            this.btEditar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtPesquisa,
            this.btPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNovo
            // 
            this.btNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(23, 22);
            this.btNovo.Text = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(23, 22);
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(23, 22);
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(23, 22);
            this.btDeletar.Text = "Deletar";
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btEditar
            // 
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(23, 22);
            this.btEditar.Text = "Editar";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(113, 22);
            this.toolStripLabel1.Text = "Pesquisa por Nome:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 25);
            // 
            // btPesquisar
            // 
            this.btPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(23, 22);
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // txtUltimoDiagnostico
            // 
            this.txtUltimoDiagnostico.Location = new System.Drawing.Point(327, 133);
            this.txtUltimoDiagnostico.Multiline = true;
            this.txtUltimoDiagnostico.Name = "txtUltimoDiagnostico";
            this.txtUltimoDiagnostico.Size = new System.Drawing.Size(218, 64);
            this.txtUltimoDiagnostico.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ultimo Diagnostico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Raça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Espécie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Porte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gênero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cuidados";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(181, 41);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(51, 20);
            this.txtIdade.TabIndex = 21;
            // 
            // txtPeso
            // 
            this.txtPeso.DecimalPlaces = 2;
            this.txtPeso.Location = new System.Drawing.Point(181, 86);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(51, 20);
            this.txtPeso.TabIndex = 22;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 217);
            this.dataGridView1.TabIndex = 23;
            // 
            // formDOMPET43
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 456);
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
            this.MaximizeBox = false;
            this.Name = "formDOMPET43";
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
        private System.Windows.Forms.ToolStripButton btNovo;
        private System.Windows.Forms.ToolStripButton btCancelar;
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
    }
}

