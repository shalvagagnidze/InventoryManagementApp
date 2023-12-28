using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI;

public partial class Registration : KryptonForm
{
    InventoryContext _db = new InventoryContext();

    public Registration()
    {
        InitializeComponent();

    }

    Role role;
    private void Registration_Load(object sender, EventArgs e)
    {

    }

    private void Regist_Button_Click(object sender, EventArgs e)
    {
        this.Hide();
        FirstName_Txt.Text = "";
        LastName_Txt.Text = "";
        mail_Txt.Text = "";
        UName_Txt.Text = "";
        UPass_Txt.Text = "";
        PassConf_Txt.Text = "";
        checkAdmin.Checked = false;
        checkModerator.Checked = false;
        BDate_Txt.Value = DateTime.Now;
        Login login = new Login();
        login.Show();
    }

    private void Registration_Btn_Click(object sender, EventArgs e)
    {
        string firstName, lastName, email, userName, userPass, confPass, passHash;
        DateTime birthDate;


        firstName = FirstName_Txt.Text;
        lastName = LastName_Txt.Text;
        email = mail_Txt.Text;
        userName = UName_Txt.Text;
        userPass = UPass_Txt.Text;
        confPass = PassConf_Txt.Text;
        birthDate = BDate_Txt.Value;


        if (string.IsNullOrWhiteSpace(firstName) ||
            string.IsNullOrWhiteSpace(lastName) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(userName) ||
            string.IsNullOrWhiteSpace(userPass) ||
            string.IsNullOrWhiteSpace(confPass))
        {
            MessageBox.Show("გთხოვთ,შეავსოთ მოცემული ყველა ველი",
                            "აუცილებელი ველი არის ცარიელი",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        bool isUserExists = _db.Users.Any(u => u.UserName == userName);

        if (isUserExists)
        {
            MessageBox.Show("მომხარებლის სახელი უკვე არსებობს, სცადეთ განსხვავებული სახელი",
                            "მომხარებლის სახელი დაკავებულია",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (!userPass.Any(char.IsUpper) || !userPass.Any(Char.IsNumber))
        {
            MessageBox.Show("მომხმარებლის პაროლი აუცილებლად უნდა შეიცავდეს " +
                            "მინიმუმ 1 დიდ ლათინურ ასოს და ასევე 1 ციფრს",
                            "პაროლი უარყოფილია",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (userPass.Length < 8)
        {
            MessageBox.Show("მომხმარებლის პაროლი უნდა შედგებოდეს" +
                            "მინუმუმ 8 სიმბოლოსგან",
                            "პაროლი უარყოფილია",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            SignUp();
        }

        void SignUp()
        {
            if (userPass == confPass)
            {
                passHash = BCrypt.Net.BCrypt.EnhancedHashPassword(userPass, 13);

                User user = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    BirthDate = birthDate,
                    UserName = userName,
                    UserPassword = passHash,
                    Role = role,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                MessageBox.Show("გილოცავთ! თქვენი ანგარიში წარმატებით შეიქმნა",
                                "წარმატებული რეგისტრაცია",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("თქვენი პაროლები ერთმანეთს არ ემთხვევა, თავიდან სცადეთ",
                                "რეგისტრაცია უარყოფილია",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                UPass_Txt.Text = "";
                PassConf_Txt.Text = "";
                UPass_Txt.Focus();
            }

        }
    }

    private void checkAdmin_CheckedChanged(object sender, EventArgs e)
    {
        if (checkAdmin.Checked)
        {
            role = Role.Admin;
            checkModerator.Checked = false;
        }
    }

    private void checkModerator_CheckedChanged(object sender, EventArgs e)
    {
        if (checkModerator.Checked)
        {
            role = Role.Moderator;
            checkAdmin.Checked = false;
        }
    }

    private void UPass_Txt_TextChanged(object sender, EventArgs e)
    {
        var checkUpper = UPass_Txt.Text.Any(Char.IsUpper);
        var checkLower = UPass_Txt.Text.Any(Char.IsLower);
        var checkLength = UPass_Txt.Text.Length;
        var checkNumber = UPass_Txt.Text.Any(Char.IsNumber);

        if (checkUpper == false || checkLower == false)
        {
            checkUpLow.ForeColor = Color.Red;
        }
        else
        {
            checkUpLow.ForeColor = Color.Green;
            checkUpLow.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        if (checkLength < 8)
        {
            checkLen.ForeColor = Color.Red;
        }
        else
        {
            checkLen.ForeColor = Color.Green;
            checkLen.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        if (checkNumber == false)
        {
            checkNum.ForeColor = Color.Red;
        }
        else
        {
            checkNum.ForeColor = Color.Green;
            checkNum.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }


    }

    private void showPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (showPassword.Checked)
        {
            UPass_Txt.PasswordChar = '\0';
            PassConf_Txt.PasswordChar = '\0';
        }
        else
        {
            UPass_Txt.PasswordChar = '•';
            PassConf_Txt.PasswordChar = '•';
        }
    }
}
