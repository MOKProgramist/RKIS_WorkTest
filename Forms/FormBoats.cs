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
    public partial class FormBoats : Form
    {
        public FormBoats()
        {
            InitializeComponent();
        }

        private void FormBoats_Load(object sender, EventArgs e)
        {
            LoadDataOrder();
        }

        ModelEF modelEF = new ModelEF();

        private void LoadDataOrder()
        {
            boatDataGridView.DataSource = modelEF.Boat.ToList();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                boatBindingSource.EndEdit();
                boatBindingSource.ResetBindings(true);
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
            FormMain formMain = new FormMain();
            formMain.Show();
            Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void boatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
