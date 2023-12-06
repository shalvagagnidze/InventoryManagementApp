using InventoryManagementApp.Data;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp.UI
{
    public partial class Edit_Brand : KryptonForm
    {
        public static Edit_Brand instance;

        InventoryContext _db = new InventoryContext();

        string name, origin, description;
        public Edit_Brand()
        {
            InitializeComponent();
            var brand = Products_UC.transferBrand;
            addBrand_Txt.Text = brand.Name;
            addOrigin_Txt.Text = brand.Origin;
            brandDescribe_Txt.Text = brand.Description;
        }
       

        private void brandSave_Btn_Click(object sender, EventArgs e)
        {
            var brand = Products_UC.transferBrand;

            name = addBrand_Txt.Text;
            origin = addOrigin_Txt.Text;
            description = addBrand_Txt.Text;

            if (addBrand_Txt.Modified)
            {
                brand.Name = name;
            }

            if(addOrigin_Txt.Modified)
            {
                brand.Origin = origin;
            }

            if(brandDescribe_Txt.Modified)
            {
                brand.Description = description;
            }

            _db.Update(brand);

            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("ბრენდი წარმატებით განახლდა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("ბრენდის განახლება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
