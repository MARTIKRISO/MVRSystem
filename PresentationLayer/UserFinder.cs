using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class UserFinder : Form
    {
        UserManager manager = new UserManager(MVRSystemDBManager.CreateContext());
        User? selectedUser;
        public UserFinder()
        {
            InitializeComponent();

            dataGridView1.DataSource = manager.ReadAll().ToList();
            TableUpdate();
        }
        private void TableUpdate()
        {
            try
            {
                dataGridView1.DataSource = manager.ReadAll().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MultyUpdate(string username)
        {
            try
            {
                dataGridView1.DataSource = manager.ReadAll().ToList().Where(x => x.Username.Contains(username)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MultyUpdate(textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedUser = row.DataBoundItem as User;

                UserChanger form = new UserChanger(selectedUser);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
