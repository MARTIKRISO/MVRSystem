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
    public partial class DrivingLicenseChanger : Form
    {
        CardManager managerCard = new CardManager(MVRSystemDBManager.GetContext());
        DrivingLicenseManager managerDLicense = new DrivingLicenseManager(MVRSystemDBManager.GetContext());
        DrivingLicense drivingLicense;

        public DrivingLicenseChanger(DrivingLicense _drivingLicense)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            drivingLicense = _drivingLicense;

            textBox1.Text = drivingLicense.EGN;
            textBox2.Text = drivingLicense.Category;
            numericUpDown1.Value = drivingLicense.DrivingPoints;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Card card = managerCard.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                drivingLicense.OwnerCard = card;
                drivingLicense.DrivingPoints = Convert.ToInt32(numericUpDown1.Value);
                drivingLicense.Category = textBox2.Text; 
                  
                managerDLicense.Update(drivingLicense);

                MessageBox.Show("Успешно променена шофьорска книжка");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
              

                managerDLicense.Delete(drivingLicense.Id);

                MessageBox.Show("Успешно изтрита шофьорска книжка");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
