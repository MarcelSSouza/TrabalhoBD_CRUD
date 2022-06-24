namespace TrabalhoBD_CRUD
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtIdPet = new System.Windows.Forms.TextBox();
            this.txtNifDono = new System.Windows.Forms.TextBox();
            this.txtIdVeterinario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcedimento = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.NumericUpDown();
            this.txtDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(16, 91);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(476, 170);
            this.txtDiagnostico.TabIndex = 0;
            // 
            // txtIdPet
            // 
            this.txtIdPet.Location = new System.Drawing.Point(16, 32);
            this.txtIdPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPet.Name = "txtIdPet";
            this.txtIdPet.Size = new System.Drawing.Size(132, 22);
            this.txtIdPet.TabIndex = 2;
            // 
            // txtNifDono
            // 
            this.txtNifDono.Location = new System.Drawing.Point(360, 32);
            this.txtNifDono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNifDono.Name = "txtNifDono";
            this.txtNifDono.Size = new System.Drawing.Size(132, 22);
            this.txtNifDono.TabIndex = 3;
            // 
            // txtIdVeterinario
            // 
            this.txtIdVeterinario.Location = new System.Drawing.Point(189, 32);
            this.txtIdVeterinario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdVeterinario.Name = "txtIdVeterinario";
            this.txtIdVeterinario.Size = new System.Drawing.Size(132, 22);
            this.txtIdVeterinario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIF Dono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Veterinário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Pet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preço";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Procedimentos Realizados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtProcedimento
            // 
            this.txtProcedimento.Location = new System.Drawing.Point(16, 296);
            this.txtProcedimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcedimento.Multiline = true;
            this.txtProcedimento.Name = "txtProcedimento";
            this.txtProcedimento.Size = new System.Drawing.Size(324, 154);
            this.txtProcedimento.TabIndex = 10;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(360, 400);
            this.btEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(134, 50);
            this.btEnviar.TabIndex = 14;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Diagnostico";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(360, 353);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(132, 22);
            this.txtPreco.TabIndex = 16;
            this.txtPreco.ValueChanged += new System.EventHandler(this.txtPreco_ValueChanged);
            // 
            // txtDataConsulta
            // 
            this.txtDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataConsulta.Location = new System.Drawing.Point(360, 296);
            this.txtDataConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataConsulta.Name = "txtDataConsulta";
            this.txtDataConsulta.Size = new System.Drawing.Size(132, 22);
            this.txtDataConsulta.TabIndex = 17;
            this.txtDataConsulta.Value = new System.DateTime(2022, 6, 13, 11, 58, 28, 0);
            this.txtDataConsulta.ValueChanged += new System.EventHandler(this.txtDataConsulta_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data da Consulta:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataConsulta);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProcedimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdVeterinario);
            this.Controls.Add(this.txtNifDono);
            this.Controls.Add(this.txtIdPet);
            this.Controls.Add(this.txtDiagnostico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtIdPet;
        private System.Windows.Forms.TextBox txtNifDono;
        private System.Windows.Forms.TextBox txtIdVeterinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcedimento;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtPreco;
        private System.Windows.Forms.DateTimePicker txtDataConsulta;
        private System.Windows.Forms.Label label7;
    }
}