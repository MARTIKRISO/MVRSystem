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
    public partial class UserChanger : Form
    {
        User user;
        UserManager manager = new UserManager(MVRSystemDBManager.GetContext());
        public UserChanger(User _user)
        {
            InitializeComponent();

            user = _user;
            if (user.IsAdmin)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            textBox1.Text = user.Username;
            textBox2.Text = user.Password;
            textBox3.Text = user.Email;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                user.Username = textBox1.Text;
                user.Password = textBox2.Text;
                user.Email = textBox3.Text;

                if (radioButton1.Checked)
                {
                    user.IsAdmin = true;
                }
                else
                {
                    user.IsAdmin = false;
                }

                manager.Update(user);
                MessageBox.Show("Успешно променен потребител");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                manager.Delete(user.ID);
                MessageBox.Show("Успешно изтрит потребител");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
