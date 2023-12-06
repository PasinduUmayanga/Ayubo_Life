using System;
using System.Windows.Forms;

namespace Ayubo_Life
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();           
        }
        #region Navigation
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Navigation.LoadRegistration(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Navigation.LoadHome(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Navigation.LoadHire(this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Navigation.LoadRent(this);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Navigation.LoadPayment(this);
        }
        #endregion
    }
}
