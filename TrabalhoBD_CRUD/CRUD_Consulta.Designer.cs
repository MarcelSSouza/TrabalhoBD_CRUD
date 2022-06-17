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
            this.txtDiagnostico.Location = new System.Drawing.Point(12, 83);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(464, 164);
            this.txtDiagnostico.TabIndex = 0;
            // 
            // txtIdPet
            // 
            this.txtIdPet.Location = new System.Drawing.Point(16, 26);
            this.txtIdPet.Name = "txtIdPet";
            this.txtIdPet.Size = new System.Drawing.Size(100, 20);
            this.txtIdPet.TabIndex = 2;
            // 
            // txtNifDono
            // 
            this.txtNifDono.Location = new System.Drawing.Point(376, 27);
            this.txtNifDono.Name = "txtNifDono";
            this.txtNifDono.Size = new System.Drawing.Size(100, 20);
            this.txtNifDono.TabIndex = 3;
            // 
            // txtIdVeterinario
            // 
            this.txtIdVeterinario.Location = new System.Drawing.Point(192, 27);
            this.txtIdVeterinario.Name = "txtIdVeterinario";
            this.txtIdVeterinario.Size = new System.Drawing.Size(100, 20);
            this.txtIdVeterinario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIF Dono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Veterinário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Pet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Procedimento";
            // 
            // txtProcedimento
            // 
            this.txtProcedimento.Location = new System.Drawing.Point(192, 280);
            this.txtProcedimento.Name = "txtProcedimento";
            this.txtProcedimento.Size = new System.Drawing.Size(284, 20);
            this.txtProcedimento.TabIndex = 10;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(348, 325);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(128, 41);
            this.btEnviar.TabIndex = 14;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Diagnostico";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 280);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 16;
            // 
            // txtDataConsulta
            // 
            this.txtDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataConsulta.Location = new System.Drawing.Point(12, 333);
            this.txtDataConsulta.Name = "txtDataConsulta";
            this.txtDataConsulta.Size = new System.Drawing.Size(104, 20);
            this.txtDataConsulta.TabIndex = 17;
            this.txtDataConsulta.Value = new System.DateTime(2022, 6, 13, 11, 58, 28, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data da Consulta:";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 384);
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
            this.Name = "Consulta";
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