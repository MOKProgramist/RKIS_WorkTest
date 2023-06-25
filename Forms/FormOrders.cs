using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RKIS_WorkTest.Models;

namespace RKIS_WorkTest.Forms
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        ModelEF modelEF = new ModelEF();
        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadDataOrder();
        }
        
        private void LoadDataOrder() {
            orderDataGridView.DataSource = modelEF.Order.ToList();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                orderBindingSource.EndEdit();
                orderBindingSource.ResetBindings(true);
                modelEF.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LoadDataOrder();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            Hide();
        }

        private void orderBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            LoadDataOrder();
        }
    }
}
