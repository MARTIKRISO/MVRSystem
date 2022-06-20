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
    public partial class DrivingLicenseCreator : Form
    {
        CardManager managerCard = new CardManager(MVRSystemDBManager.GetContext());
        DrivingLicenseManager managerDLicense = new DrivingLicenseManager(MVRSystemDBManager.GetContext());

        string id = "000000001";
        public DrivingLicenseCreator()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            try
            {
                id = $"{(Convert.ToInt32(managerDLicense.ReadAll().Last().Id) + 1):d9}";
            }
            catch (Exception)
            {
                
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Card card = managerCard.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                DrivingLicense drivingLicense = new DrivingLicense(card, Convert.ToInt32(numericUpDown1.Value), textBox2.Text);
                drivingLicense.Id = id;
                managerDLicense.Create(drivingLicense);
                MessageBox.Show("Успешно създадена книжка");
                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = 39;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
