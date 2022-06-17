namespace TrabalhoBD_CRUD
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.btCliente = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.btPet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btConsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(162, 389);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(122, 42);
            this.btCliente.TabIndex = 0;
            this.btCliente.Text = "Cliente";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // btProduto
            // 
            this.btProduto.Location = new System.Drawing.Point(470, 391);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(122, 43);
            this.btProduto.TabIndex = 1;
            this.btProduto.Text = "Produto";
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btPet
            // 
            this.btPet.Location = new System.Drawing.Point(12, 391);
            this.btPet.Name = "btPet";
            this.btPet.Size = new System.Drawing.Size(122, 40);
            this.btPet.TabIndex = 2;
            this.btPet.Text = "Pet";
            this.btPet.UseVisualStyleBackColor = true;
            this.btPet.Click += new System.EventHandler(this.btPet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOMPET43";
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(320, 394);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(122, 40);
            this.btConsulta.TabIndex = 4;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPet);
            this.Controls.Add(this.btProduto);
            this.Controls.Add(this.btCliente);
            this.Name = "Inicial";
            this.Text = "DOMPET43";
            this.Load += new System.EventHandler(this.Inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}