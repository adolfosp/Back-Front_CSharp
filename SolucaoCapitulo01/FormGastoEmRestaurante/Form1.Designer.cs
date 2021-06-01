
namespace FormGastoEmRestaurante
{
    partial class Form1
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
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotalPor = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(115, 40);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(100, 23);
            this.txtDespesa.TabIndex = 0;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(59, 43);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(50, 15);
            this.lblDespesa.TabIndex = 1;
            this.lblDespesa.Text = "Despesa";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(267, 40);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(77, 100);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotalPor
            // 
            this.lblTotalPor.AutoSize = true;
            this.lblTotalPor.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPor.Location = new System.Drawing.Point(12, 120);
            this.lblTotalPor.Name = "lblTotalPor";
            this.lblTotalPor.Size = new System.Drawing.Size(97, 15);
            this.lblTotalPor.TabIndex = 3;
            this.lblTotalPor.Text = "Total com 10 %";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.Location = new System.Drawing.Point(115, 117);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 23);
            this.txtValorTotal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 260);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTotalPor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txtDespesa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotalPor;
        private System.Windows.Forms.TextBox txtValorTotal;
    }
}

