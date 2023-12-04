using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    public partial class Add_Brand : KryptonForm
    {
        InventoryContext _db = new InventoryContext();

        string brandName, brandOrigin, brandDescription;
        public Add_Brand()
        {
            InitializeComponent();
        }

        private void brandSave_Btn_Click(object sender, EventArgs e)
        {
            brandName = addBrand_Txt.Text;
            brandOrigin = addOrigin_Txt.Text;
            brandDescription = brandDescribe_Txt.Text;

            if (string.IsNullOrWhiteSpace(addBrand_Txt.Text) ||
               string.IsNullOrWhiteSpace(addOrigin_Txt.Text) ||
               string.IsNullOrWhiteSpace(brandDescribe_Txt.Text))
            {

                MessageBox.Show("გთხოვთ, შეავსოთ მოცემული ყველა ველი",
                                "შესავსები ველი ცარიელია",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                AddBrand();
            }

        }

        void AddBrand()
        {
            Brand brand = new Brand()
            {
                Name = brandName,
                Origin = brandOrigin,
                Description = brandDescription,
                IsDeleted = false
            };

            _db.Brands.Add(brand);

            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("ბრენდი წარმატებით დაემატა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("ბრენდის დამატება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }

}
