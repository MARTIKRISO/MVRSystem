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
    public partial class PassportCreator : Form
    {
        PassportManager managerPassport = new PassportManager(MVRSystemDBManager.GetContext());
      
        CardManager managerCard = new CardManager(MVRSystemDBManager.GetContext());
        string IdCard = "000000001";
        public PassportCreator()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            try
            {
                IdCard = $"{(Convert.ToInt32(managerCard.ReadAll().Last().Id) + 1):d9}";

            }
            catch (Exception)
            {
                IdCard = "000000001";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Card card = managerCard.ReadAll().Where(x => x.EGN == textBox1.Text).First();
                Passport passport = new Passport(IdCard, card, textBox2.Text);

                managerPassport.Create(passport);

                MessageBox.Show("Успешно създаден паспорт");

                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
          
        }
    }
}
