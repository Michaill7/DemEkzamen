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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            var dt = DBHELPERUS.gay(login.Text, pass.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Пользователь отсутствует в системе");
                return;
            }
            string role = dt.Rows[0].Field<string>("role");
            if (role == "Модератор")
            {
                var moderwindow = new ModerWindow();
                moderwindow.ShowDialog();
            }
        }
    }
}
