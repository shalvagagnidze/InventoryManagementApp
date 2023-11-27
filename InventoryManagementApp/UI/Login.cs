using InventoryManagementApp.UI;
using Krypton.Toolkit;
namespace InventoryManagementApp
{
    public partial class Login : KryptonForm
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Regist_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
