
namespace ReajusteDeSalario
{
    partial class frmReajusteSalarial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblInfoTotalSemRea = new System.Windows.Forms.Label();
            this.lblValorTotalSemRea = new System.Windows.Forms.Label();
            this.lblInfoTotalReajuste = new System.Windows.Forms.Label();
            this.lblValorTotalReajuste = new System.Windows.Forms.Label();
            this.lblInfoPercenReajuste = new System.Windows.Forms.Label();
            this.lblValorPercenReajuste = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(13, 13);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(510, 23);
            this.txtArquivo.TabIndex = 0;
            // 
            // lblInfoTotalSemRea
            // 
            this.lblInfoTotalSemRea.AutoSize = true;
            this.lblInfoTotalSemRea.Location = new System.Drawing.Point(12, 39);
            this.lblInfoTotalSemRea.Name = "lblInfoTotalSemRea";
            this.lblInfoTotalSemRea.Size = new System.Drawing.Size(104, 15);
            this.lblInfoTotalSemRea.TabIndex = 2;
            this.lblInfoTotalSemRea.Text = "Total sem Reajuste";
            // 
            // lblValorTotalSemRea
            // 
            this.lblValorTotalSemRea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorTotalSemRea.Location = new System.Drawing.Point(13, 65);
            this.lblValorTotalSemRea.Name = "lblValorTotalSemRea";
            this.lblValorTotalSemRea.Size = new System.Drawing.Size(103, 25);
            this.lblValorTotalSemRea.TabIndex = 3;
            // 
            // lblInfoTotalReajuste
            // 
            this.lblInfoTotalReajuste.AutoSize = true;
            this.lblInfoTotalReajuste.Location = new System.Drawing.Point(242, 39);
            this.lblInfoTotalReajuste.Name = "lblInfoTotalReajuste";
            this.lblInfoTotalReajuste.Size = new System.Drawing.Size(103, 15);
            this.lblInfoTotalReajuste.TabIndex = 4;
            this.lblInfoTotalReajuste.Text = "Total com reajuste";
            // 
            // lblValorTotalReajuste
            // 
            this.lblValorTotalReajuste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorTotalReajuste.Location = new System.Drawing.Point(242, 65);
            this.lblValorTotalReajuste.Name = "lblValorTotalReajuste";
            this.lblValorTotalReajuste.Size = new System.Drawing.Size(103, 25);
            this.lblValorTotalReajuste.TabIndex = 5;
            // 
            // lblInfoPercenReajuste
            // 
            this.lblInfoPercenReajuste.AutoSize = true;
            this.lblInfoPercenReajuste.Location = new System.Drawing.Point(497, 39);
            this.lblInfoPercenReajuste.Name = "lblInfoPercenReajuste";
            this.lblInfoPercenReajuste.Size = new System.Drawing.Size(107, 15);
            this.lblInfoPercenReajuste.TabIndex = 6;
            this.lblInfoPercenReajuste.Text = "Percentual reajuste";
            // 
            // lblValorPercenReajuste
            // 
            this.lblValorPercenReajuste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorPercenReajuste.Location = new System.Drawing.Point(497, 65);
            this.lblValorPercenReajuste.Name = "lblValorPercenReajuste";
            this.lblValorPercenReajuste.Size = new System.Drawing.Size(107, 24);
            this.lblValorPercenReajuste.TabIndex = 7;
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(12, 111);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 25;
            this.dgvLeitura.Size = new System.Drawing.Size(592, 327);
            this.dgvLeitura.TabIndex = 8;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(529, 13);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "...";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Selecionar o arquivo";
            // 
            // frmReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.lblValorPercenReajuste);
            this.Controls.Add(this.lblInfoPercenReajuste);
            this.Controls.Add(this.lblValorTotalReajuste);
            this.Controls.Add(this.lblInfoTotalReajuste);
            this.Controls.Add(this.lblValorTotalSemRea);
            this.Controls.Add(this.lblInfoTotalSemRea);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtArquivo);
            this.Name = "frmReajusteSalarial";
            this.Text = "Reajuste de Salário";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblInfoTotalSemRea;
        private System.Windows.Forms.Label lblValorTotalSemRea;
        private System.Windows.Forms.Label lblInfoTotalReajuste;
        private System.Windows.Forms.Label lblValorTotalReajuste;
        private System.Windows.Forms.Label lblInfoPercenReajuste;
        private System.Windows.Forms.Label lblValorPercenReajuste;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

