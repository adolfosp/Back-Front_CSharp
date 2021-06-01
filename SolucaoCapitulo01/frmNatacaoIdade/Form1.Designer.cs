
namespace frmNatacaoIdade
{
    partial class frmNatacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bntVerificarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dtpAnoNascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(390, 23);
            this.txtNome.TabIndex = 2;
            // 
            // bntVerificarCategoria
            // 
            this.bntVerificarCategoria.Location = new System.Drawing.Point(115, 161);
            this.bntVerificarCategoria.Name = "bntVerificarCategoria";
            this.bntVerificarCategoria.Size = new System.Drawing.Size(100, 45);
            this.bntVerificarCategoria.TabIndex = 6;
            this.bntVerificarCategoria.Text = "Verificar catergoria";
            this.bntVerificarCategoria.UseVisualStyleBackColor = true;
            this.bntVerificarCategoria.Click += new System.EventHandler(this.bntVerificarCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Location = new System.Drawing.Point(325, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 21);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpAnoNascimento
            // 
            this.dtpAnoNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnoNascimento.Location = new System.Drawing.Point(115, 85);
            this.dtpAnoNascimento.Name = "dtpAnoNascimento";
            this.dtpAnoNascimento.Size = new System.Drawing.Size(100, 23);
            this.dtpAnoNascimento.TabIndex = 0;
            // 
            // frmNatacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 215);
            this.Controls.Add(this.dtpAnoNascimento);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntVerificarCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNatacao";
            this.Text = "Natação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button bntVerificarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DateTimePicker dtpAnoNascimento;
    }
}

