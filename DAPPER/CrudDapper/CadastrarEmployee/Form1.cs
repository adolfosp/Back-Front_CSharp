using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dapper
{
    public partial class FormDapper : DevExpress.XtraEditors.XtraForm
    {
        public FormDapper()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;

        }

        BussinessLayer getBussinessLayer;
        Employee getData;
        int _id;


        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {

                getData = new Employee()
                {
                    Id = _id
                };
                getBussinessLayer = new BussinessLayer();
                getBussinessLayer.Delete(getData);
                MessageBox.Show("Registro removido!");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

            FillGrid();
        }



        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                getData = new Employee()
                {
                    Id = _id,
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Address = txtAddress.Text

                };
                if (_id == 0)
                {
                    getBussinessLayer = new BussinessLayer();
                    getBussinessLayer.Save(getData);
                    MessageBox.Show("Registro inserido com sucesso!");

                }
                else
                {
                    getBussinessLayer = new BussinessLayer();
                    getBussinessLayer.Update(getData);
                    MessageBox.Show("Registro atualizado com sucesso!");

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            FillGrid();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(dgvEmployee.CurrentRow.Index != -1)
                {
                    _id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells[0].Value.ToString());
                    txtName.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                    txtSurname.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
                    txtAddress.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();

                    btnExcluir.Enabled = true;
                    btnGravar.Text = "Atualizar";

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não sei o que ele digitou no vídeo");
            }
        }

        private void FillGrid()
        {
            getBussinessLayer = new BussinessLayer();
            var list  = getBussinessLayer.GetAll();
            dgvEmployee.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                FillGrid();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível trazer nenhuma informação "+ex.Message.ToString());
            }
        }
    }
}
