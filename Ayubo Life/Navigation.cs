using System.Windows.Forms;

namespace Ayubo_Life
{
    public class Navigation
    {


        internal static void LoadHome(Form form)
        {
            form.Close();      
            Home home = new Home();
            home.Show();
        }

        internal static void LoadRegistration(Form form)
        {
            form.Close();
            Registration registration = new Registration();
            registration.Show();
        }
        internal static void LoadRent(Form form)
        {
            form.Close();
            Rent rent = new Rent();
            rent.Show();
        }
        internal static void LoadHire(Form form)
        {
            form.Close();
            Hire hire = new Hire();
            hire.Show();
        }
        internal static void LoadPayment(Form form)
        {
            form.Close();
            Paymnet paymnet = new Paymnet();
            paymnet.Show();
        }
    }
}
