
namespace LeituraDadosTxt
{
    partial class frmFuncionarioEmpresa
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumFuncionario = new System.Windows.Forms.TextBox();
            this.btnCriarLinhaRegistro = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(13, 51);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowTemplate.Height = 25;
            this.dgvFuncionarios.Size = new System.Drawing.Size(405, 334);
            this.dgvFuncionarios.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr. de Funcionários";
            // 
            // txtNumFuncionario
            // 
            this.txtNumFuncionario.Location = new System.Drawing.Point(129, 10);
            this.txtNumFuncionario.Name = "txtNumFuncionario";
            this.txtNumFuncionario.Size = new System.Drawing.Size(100, 23);
            this.txtNumFuncionario.TabIndex = 2;
            // 
            // btnCriarLinhaRegistro
            // 
            this.btnCriarLinhaRegistro.Location = new System.Drawing.Point(280, 9);
            this.btnCriarLinhaRegistro.Name = "btnCriarLinhaRegistro";
            this.btnCriarLinhaRegistro.Size = new System.Drawing.Size(138, 23);
            this.btnCriarLinhaRegistro.TabIndex = 3;
            this.btnCriarLinhaRegistro.Text = "Criar linhas para registro";
            this.btnCriarLinhaRegistro.UseVisualStyleBackColor = true;
            this.btnCriarLinhaRegistro.Click += new System.EventHandler(this.btnCriarLinhaRegistro_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Enabled = false;
            this.btnCriarArquivo.Location = new System.Drawing.Point(13, 404);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(138, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(280, 404);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(138, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivo";
            // 
            // frmFuncionarioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnCriarLinhaRegistro);
            this.Controls.Add(this.txtNumFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "frmFuncionarioEmpresa";
            this.Text = "Dados dos Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumFuncionario;
        private System.Windows.Forms.Button btnCriarLinhaRegistro;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
    }
}

