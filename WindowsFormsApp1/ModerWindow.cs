using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModerWindow : Form
    {
        public ModerWindow()
        {
            InitializeComponent();
            dataGridView1.DataSource = DBHELPERUS.ShowDataToDataGridOfModerWindow();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string b = DBHELPERUS.ShowDataToDataGridOfModerWindow().Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("фото");
            pictureBox1.Image = Image.FromFile("C:\\Users\\Sikol\\OneDrive\\Рабочий стол\\" + b);
        }
    }
}
