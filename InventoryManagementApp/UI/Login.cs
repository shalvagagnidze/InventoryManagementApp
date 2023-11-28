﻿using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace InventoryManagementApp
{
    public partial class Login : KryptonForm
    {
        private InventoryContext _db = new InventoryContext();
        
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

            User user = _db.Users.FirstOrDefault(u => u.UserName == userName && u.UserPassword == password);

            if (user != null)
            {
                this.Hide();
                switch (user.RoleID)
                {
                    case 1:
                        AdminUI adminUI = new AdminUI();
                        adminUI.Show();
                        break;
                    case 2:
                        ModeratorUI moderatorUI = new ModeratorUI();
                        moderatorUI.Show();
                        break;
                }
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
}
