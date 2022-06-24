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
            this.btCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.Location = new System.Drawing.Point(184, 445);
            this.btCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(163, 52);
            this.btCliente.TabIndex = 0;
            this.btCliente.Text = "Cliente";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // btProduto
            // 
            this.btProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduto.Location = new System.Drawing.Point(526, 445);
            this.btProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(163, 52);
            this.btProduto.TabIndex = 1;
            this.btProduto.Text = "Produto";
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btPet
            // 
            this.btPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPet.Location = new System.Drawing.Point(13, 445);
            this.btPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPet.Name = "btPet";
            this.btPet.Size = new System.Drawing.Size(163, 52);
            this.btPet.TabIndex = 2;
            this.btPet.Text = "Pet";
            this.btPet.UseVisualStyleBackColor = true;
            this.btPet.Click += new System.EventHandler(this.btPet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOMPET43";
            // 
            // btConsulta
            // 
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.Location = new System.Drawing.Point(355, 445);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(163, 52);
            this.btConsulta.TabIndex = 4;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPet);
            this.Controls.Add(this.btProduto);
            this.Controls.Add(this.btCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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