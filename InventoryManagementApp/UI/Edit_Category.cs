using InventoryManagementApp.Data;
using InventoryManagementApp.User_Controls;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    public partial class Edit_Category : KryptonForm
    {
        public static Edit_Category instance;

        InventoryContext _db = new InventoryContext();

        string categoryName, categoryDescription;
        public Edit_Category()
        {
            InitializeComponent();
            var category = Products_UC.transferCategory;
            addCategory_Txt.Text = category.Name;
            categoryDescribe_Txt.Text = category.Description;
        }

        private void catSave_Btn_Click(object sender, EventArgs e)
        {
            var category = Products_UC.transferCategory;

            categoryName = addCategory_Txt.Text;
            categoryDescription = categoryDescribe_Txt.Text;

            if (addCategory_Txt.Modified)
            {
                category.Name = categoryName;
            }

            if (categoryDescribe_Txt.Modified)
            {
                category.Description = categoryDescription;
            }

            _db.Update(category);

            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("კატეგორია წარმატებით განახლდა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("კატეგორიის განახლება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
