
namespace ReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorasTrabalhada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(118, 35);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Mínimo";
            // 
            // txtHorasTrabalhada
            // 
            this.txtHorasTrabalhada.Location = new System.Drawing.Point(118, 74);
            this.txtHorasTrabalhada.Name = "txtHorasTrabalhada";
            this.txtHorasTrabalhada.Size = new System.Drawing.Size(100, 23);
            this.txtHorasTrabalhada.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas trabalhadas";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Calouro",
            "Veterano"});
            this.cmbCategoria.Location = new System.Drawing.Point(354, 35);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoria.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cmbTurno.Location = new System.Drawing.Point(354, 74);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 23);
            this.cmbTurno.TabIndex = 9;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Ajuda";
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(354, 256);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(121, 27);
            this.btnProcessar.TabIndex = 10;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacao.Location = new System.Drawing.Point(25, 259);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(193, 24);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxResumo
            // 
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 15;
            this.lbxResumo.Location = new System.Drawing.Point(25, 108);
            this.lbxResumo.MultiColumn = true;
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxResumo.Size = new System.Drawing.Size(450, 124);
            this.lbxResumo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 292);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorasTrabalhada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Name = "Form1";
            this.Text = "Cálculo do Salário Mínimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorasTrabalhada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ListBox lbxResumo;
    }
}

