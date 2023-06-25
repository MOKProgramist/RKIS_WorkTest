using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RKIS_WorkTest.Forms;

namespace RKIS_WorkTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBoats bormBoats = new FormBoats();
            bormBoats.Show();
            Hide();
        }
    }
}
