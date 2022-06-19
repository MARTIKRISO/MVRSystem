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
    public partial class PassportChanger : Form
    {
        PassportManager managerPassport = new PassportManager(MVRSystemDBManager.GetContext());
        Passport passport;
        CardManager managerCard = new CardManager(MVRSystemDBManager.GetContext());
        string IDCard = "000000001";
        public PassportChanger(Passport _passport)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            passport = _passport;
            textBox1.Text = passport.EGN;
            textBox2.Text = passport.Destinations;
           
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Card card = managerCard.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                Passport updPass = new Passport(passport.Id, card, textBox2.Text);
                managerPassport.Update(updPass);

                MessageBox.Show("Успешно променен паспорт");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
             managerPassport.Delete(managerPassport.ReadAll().Where(x=> x.EGN == textBox1.Text).First().Id);
                MessageBox.Show("Успешно изтрит паспорт");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
