using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    public partial class Add_Category : KryptonForm
    {
        InventoryContext _db = new InventoryContext();
        string categoryName, categoryDescription;
        public Add_Category()
        {
            InitializeComponent();
        }

        private void catSave_Btn_Click(object sender, EventArgs e)
        {
            categoryName = addCategory_Txt.Text;
            categoryDescription = categoryDescribe_Txt.Text;
            if (string.IsNullOrWhiteSpace(addCategory_Txt.Text) ||
               string.IsNullOrWhiteSpace(categoryDescribe_Txt.Text))
            {

                MessageBox.Show("გთხოვთ, შეავსოთ მოცემული ყველა ველი",
                                "შესავსები ველი ცარიელია",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                AddCategory();
            }

        }

        void AddCategory()
        {

            Category category = new Category()
            {
                Name = categoryName,
                Description = categoryDescription,
                IsDeleted = false
            };

            _db.Categories.Add(category);

            var response = _db.SaveChanges();

            if (response > 0)
            {
                MessageBox.Show("კატეგორია წარმატებით დაემატა!",
                                "წარმატებული შენახვა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("კატეგორიის დამატება ვერ მოხერხდა, თავიდან სცადეთ!",
                                "დამატების წარუმატებელი მცდელობა",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
