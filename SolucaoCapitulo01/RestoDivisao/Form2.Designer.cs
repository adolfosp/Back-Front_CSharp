
namespace RestoDivisao
{
    partial class frmRestoDeDivisao
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
            this.btnOperacao = new System.Windows.Forms.Button();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperacao
            // 
            this.btnOperacao.Location = new System.Drawing.Point(81, 84);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(100, 23);
            this.btnOperacao.TabIndex = 0;
            this.btnOperacao.Text = "Realizar Cálculo";
            this.btnOperacao.UseVisualStyleBackColor = true;
            this.btnOperacao.Click += new System.EventHandler(this.btnOperacao_Click_1);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(81, 33);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 23);
            this.txtDividendo.TabIndex = 1;
            // 
            // txtResto
            // 
            this.txtResto.Location = new System.Drawing.Point(278, 84);
            this.txtResto.Name = "txtResto";
            this.txtResto.ReadOnly = true;
            this.txtResto.Size = new System.Drawing.Size(100, 23);
            this.txtResto.TabIndex = 2;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(278, 33);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 23);
            this.txtDivisor.TabIndex = 3;
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(226, 36);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(46, 15);
            this.lblDivisor.TabIndex = 4;
            this.lblDivisor.Text = "Divisor:";
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(12, 36);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(64, 15);
            this.lblDividendo.TabIndex = 5;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(236, 88);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(36, 15);
            this.lblResto.TabIndex = 6;
            this.lblResto.Text = "Resto";
            // 
            // frmRestoDeDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 140);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.btnOperacao);
            this.Name = "frmRestoDeDivisao";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblResto;
    }
}