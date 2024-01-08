using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
using Krypton.Toolkit;
namespace InventoryManagementApp;

public partial class Login : KryptonForm
{
    private InventoryContext _db = new InventoryContext();
    public static Login instance;
    public static int userId;

    public Login()
    {
        InitializeComponent();
        instance = this;
    }

    private void showPass_CheckedChanged(object sender, EventArgs e)
    {
        if (showPass.Checked)
        {
            UPass_Text.PasswordChar = '\0';

        }
        else
        {
            UPass_Text.PasswordChar = '•';
        }
    }

    private void Sign_Button_Click(object sender, EventArgs e)
    {
        string userName, password;

        userName = UName_Text.Text;
        password = UPass_Text.Text;

        User user = _db.Users.FirstOrDefault(u => u.UserName == userName);

        //bool isValidPassword = BCrypt.Net.BCrypt.EnhancedVerify(password, user.UserPassword);

        if (user != null && BCrypt.Net.BCrypt.EnhancedVerify(password, user.UserPassword))
        {
            userId = user.Id;
            this.Hide();
            AdminUI adminUI = new AdminUI();
            adminUI.Show();
        }
        else
        {
            MessageBox.Show("მომხმარებლის სახელი ან პაროლი არასწორია, თავიდან სცადეთ",
                            "შესვლა ვერ მოხერხდა",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            userName = "";
            password = "";
        }

    }
}
