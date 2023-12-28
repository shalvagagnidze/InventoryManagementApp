﻿using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using InventoryManagementApp.UI;
using Krypton.Toolkit;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System.Data;

namespace InventoryManagementApp.User_Controls;

public partial class Products_UC : UserControl
{
    public static Products_UC instance;
    public static Product transferProduct;
    public static Category transferCategory;
    public static Brand transferBrand;
    int userID;
    InventoryContext _db = new InventoryContext();

    public Products_UC()
    {
        InitializeComponent();
        instance = this;
        panel2.BringToFront();
        sortCat_Btn.Visible = false;
        sortBrand_Btn.Visible = false;
        productData.RowPrePaint += productData_RowPrePaint;
        userID = Login.userId;
    }

    private void Products_UC_Load(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            var sell = createSellButton();
            productData.CellContentClick += new DataGridViewCellEventHandler(ProductData_CellContentClick);

            productData.DataSource = _db.Products.Where(s => !s.IsDeleted).Select(s => new
            {
                კოდი = s.Code,
                დასახელება = s.Name,
                ბრენდი = s.Brand.Name,
                ფასი = s.Price,
                თვითღირებულება = s.NetCost,
                კატეგორია = s.Category.Name,
                რაოდენობა = s.Storage.TotalAmount,
                ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                დამატების_თარიღი = s.CreateDate,
                სტატუსი = s.Status,
                აღწერა = s.Description,
                გაყიდვა = "გაყიდვა"
            }).ToList();

            productData.Columns["გაყიდვა"].DefaultCellStyle.ForeColor = Color.Green;
        }
        else
        {
            productData.DataSource = _db.Products.Where(s => !s.IsDeleted).Select(s => new
            {
                კოდი = s.Code,
                დასახელება = s.Name,
                ბრენდი = s.Brand.Name,
                ფასი = s.Price,
                თვითღირებულება = s.NetCost,
                კატეგორია = s.Category.Name,
                რაოდენობა = s.Storage.TotalAmount,
                ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                დამატების_თარიღი = s.CreateDate,
                სტატუსი = s.Status,
                აღწერა = s.Description,
            }).ToList();
        }

    }

    private void addProduct_Btn_Click(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            Add_Product addProduct = new Add_Product();
            addProduct.Show();
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ პროდუქტის დამატების უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }


    }

    private void addCategory_Btn_Click(object sender, EventArgs e)
    {

        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            Add_Category addCategory = new Add_Category();
            addCategory.Show();
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ კატეგორიის დამატების უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }
    }

    private void addBrand_Btn_Click(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            Add_Brand addBrand = new Add_Brand();
            addBrand.Show();
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ ბრენდის დამატების უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }
    }

    private void Search_Txt_TextChanged(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
        {
            if (Search_Txt.Text.Length > 0)
            {
                string searchText = Search_Txt.Text;

                SearchProduct(searchText);
            }
            else
            {
                var sell = createSellButton();
                productData.DataSource = _db.Products.Where(p => !p.IsDeleted).Select(s => new
                {
                    კოდი = s.Code,
                    დასახელება = s.Name,
                    ბრენდი = s.Brand.Name,
                    ფასი = s.Price,
                    თვითღირებულება = s.NetCost,
                    კატეგორია = s.Category.Name,
                    რაოდენობა = s.Storage.TotalAmount,
                    ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                    დამატების_თარიღი = s.CreateDate,
                    სტატუსი = s.Status,
                    აღწერა = s.Description,
                    გაყიდვა = "გაყიდვა"
                }).ToList();
            }
        }
        else if (sortCat_Btn.Location == new System.Drawing.Point(350, 8))
        {
            if (Search_Txt.Text.Length > 0)
            {
                string searchText = Search_Txt.Text;
                SearchCategory(searchText);
            }
            else
            {
                productData.DataSource = _db.Categories.Select(c => new
                {
                    დასახელება = c.Name,
                    აღწერა = c.Description
                }).ToList();
            }
        }
        else if (sortBrand_Btn.Location == new System.Drawing.Point(350, 8))
        {
            if (Search_Txt.Text.Length > 0)
            {
                string searchText = Search_Txt.Text;
                SearchBrand(searchText);
            }
            else
            {
                productData.DataSource = _db.Brands.Select(b => new
                {
                    დასახელება = b.Name,
                    მწარმოებელი = b.Origin,
                    აღწერა = b.Description
                }).ToList();
            }
        }

    }

    public void SearchProduct(string searchText)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            var sell = createSellButton();


            var search = _db.Products.Where(s => !s.IsDeleted && (s.Name.Contains(searchText) ||
                                            s.Code.ToString().Contains(searchText) ||
                                            s.Category.Name.Contains(searchText) ||
                                            s.Brand.Name.Contains(searchText)))
                                     .Select(s => new
                                     {
                                         კოდი = s.Code,
                                         დასახელება = s.Name,
                                         ბრენდი = s.Brand.Name,
                                         ფასი = s.Price,
                                         თვითღირებულება = s.NetCost,
                                         კატეგორია = s.Category.Name,
                                         რაოდენობა = s.Storage.TotalAmount,
                                         ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                                         დამატების_თარიღი = s.CreateDate,
                                         სტატუსი = s.Status,
                                         აღწერა = s.Description,
                                         გაყიდვა = "გაყიდვა"
                                     }).ToList();

            productData.DataSource = search;
        }
        else
        {
            var search = _db.Products.Where(s => !s.IsDeleted && (s.Name.Contains(searchText) ||
                                            s.Code.ToString().Contains(searchText) ||
                                            s.Category.Name.Contains(searchText) ||
                                            s.Brand.Name.Contains(searchText)))
                                     .Select(s => new
                                     {
                                         კოდი = s.Code,
                                         დასახელება = s.Name,
                                         ბრენდი = s.Brand.Name,
                                         ფასი = s.Price,
                                         თვითღირებულება = s.NetCost,
                                         კატეგორია = s.Category.Name,
                                         რაოდენობა = s.Storage.TotalAmount,
                                         ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                                         დამატების_თარიღი = s.CreateDate,
                                         სტატუსი = s.Status,
                                         აღწერა = s.Description,
                                     }).ToList();

            productData.DataSource = search;
        }


    }

    public void SearchCategory(string searchText)
    {
        var search = _db.Categories.Where(c => c.Name.Contains(searchText))
                                   .Select(c => new
                                   {
                                       დასახელება = c.Name,
                                       აღწერა = c.Description
                                   }).ToList();

        productData.DataSource = search;
    }

    public void SearchBrand(string searchText)
    {
        var search = _db.Brands.Where(b => b.Name.Contains(searchText) ||
                                      b.Origin.Contains(searchText))
                               .Select(b => new
                               {
                                   დასახელება = b.Name,
                                   მწარმოებელი = b.Origin,
                                   აღწერა = b.Description
                               }).ToList();

        productData.DataSource = search;
    }

    private void Search_Txt_Click(object sender, EventArgs e)
    {
        Search_Txt.Text = String.Empty;
    }

    private void sortProd_Btn_Click(object sender, EventArgs e)
    {
    }

    private void sortCat_Btn_Click(object sender, EventArgs e)
    {
        sortProd_Btn.Visible = false;
        sortBrand_Btn.Visible = false;

        sortCat_Btn.Location = new System.Drawing.Point(350, 8);
        sortProd_Btn.Location = new System.Drawing.Point(179, 8);
        sortBrand_Btn.Location = new System.Drawing.Point(8, 8);



        productData.DataSource = _db.Categories.Select(c => new
        {
            დასახელება = c.Name,
            აღწერა = c.Description
        }).ToList();
    }

    private void sortBrand_Btn_Click(object sender, EventArgs e)
    {
        sortProd_Btn.Visible = false;
        sortCat_Btn.Visible = false;

        sortBrand_Btn.Location = new System.Drawing.Point(350, 8);
        sortProd_Btn.Location = new System.Drawing.Point(179, 8);
        sortCat_Btn.Location = new System.Drawing.Point(8, 8);



        productData.DataSource = _db.Brands.Select(c => new
        {
            დასახელება = c.Name,
            მწარმოებელი = c.Origin,
            აღწერა = c.Description
        }).ToList();
    }

    private void sortProd_Btn_Click_1(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        sortCat_Btn.Visible = false;
        sortBrand_Btn.Visible = false;

        sortProd_Btn.Location = new System.Drawing.Point(350, 8);
        sortCat_Btn.Location = new System.Drawing.Point(179, 8);
        sortBrand_Btn.Location = new System.Drawing.Point(8, 8);


        panel2.SendToBack();
        if (user.Role.ToString() == "Admin")
        {
            var sell = createSellButton();
            productData.DataSource = _db.Products.Where(s => !s.IsDeleted).Select(s => new
            {
                კოდი = s.Code,
                დასახელება = s.Name,
                ბრენდი = s.Brand.Name,
                ფასი = s.Price,
                თვითღირებულება = s.NetCost,
                კატეგორია = s.Category.Name,
                რაოდენობა = s.Storage.TotalAmount,
                ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                დამატების_თარიღი = s.CreateDate,
                სტატუსი = s.Status,
                აღწერა = s.Description,
                გაყიდვა = "გაყიდვა"
            }).ToList();
        }
        else
        {
            productData.DataSource = _db.Products.Where(s => !s.IsDeleted).Select(s => new
            {
                კოდი = s.Code,
                დასახელება = s.Name,
                ბრენდი = s.Brand.Name,
                ფასი = s.Price,
                თვითღირებულება = s.NetCost,
                კატეგორია = s.Category.Name,
                რაოდენობა = s.Storage.TotalAmount,
                ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                დამატების_თარიღი = s.CreateDate,
                სტატუსი = s.Status,
                აღწერა = s.Description,
            }).ToList();
        }

    }

    private void sort_Btn_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
        sortProd_Btn.Visible = true;
        sortCat_Btn.Visible = true;
        sortBrand_Btn.Visible = true;
    }

    private void delete_Btn_Click(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            if (MessageBox.Show("დარწმუნებული ხართ, რომ გსურთ წაშლა?", "ფრთხილად წაშლამდე!"
                           , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
                {
                    var row = productData.CurrentRow;
                    var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
                    var prodId = prodIndex;
                    var product = _db.Products.FirstOrDefault(p => p.Code == prodId);

                    product.DeleteProduct();
                    product.DeleteTime = DateTime.Now;

                    var result = _db.SaveChanges();

                    if (result > 0)
                    {

                        MessageBox.Show("პროდუქტი წარმატებით წაიშალა!",
                                       "პროდუქტის წაშლა",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                        var sell = createSellButton();
                        productData.DataSource = _db.Products.Where(s => !s.IsDeleted).Select(s => new
                        {
                            კოდი = s.Code,
                            დასახელება = s.Name,
                            ბრენდი = s.Brand.Name,
                            ფასი = s.Price,
                            თვითღირებულება = s.NetCost,
                            კატეგორია = s.Category.Name,
                            რაოდენობა = s.Storage.TotalAmount,
                            ჯამური_გაყიდვა = s.TotalSold.TotalSoldAmount,
                            დამატების_თარიღი = s.CreateDate,
                            სტატუსი = s.Status,
                            აღწერა = s.Description,
                            გაყიდვა = "გაყიდვა"
                        }).ToList();

                    }
                    else
                    {
                        MessageBox.Show("პროდუქტის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                                       "შეცდომა წაშლისას",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                    }
                }

                if (sortCat_Btn.Location == new System.Drawing.Point(350, 8))
                {
                    var row = productData.CurrentRow;
                    var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
                    var category = _db.Categories.FirstOrDefault(p => p.Name == catBrandName);

                    category.DeleteCategory();
                    var result = _db.SaveChanges();

                    if (result > 0)
                    {

                        MessageBox.Show("კატეგორია წარმატებით წაიშალა!",
                                       "კატეგორიის წაშლა",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                        productData.DataSource = _db.Categories.Select(c => new
                        {
                            დასახელება = c.Name,
                            აღწერა = c.Description

                        }).ToList();

                    }
                    else
                    {
                        MessageBox.Show("კატეგორიის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                                       "შეცდომა წაშლისას",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                    }

                }

                if (sortBrand_Btn.Location == new System.Drawing.Point(350, 8))
                {
                    var row = productData.CurrentRow;
                    var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
                    var brand = _db.Brands.FirstOrDefault(p => p.Name == catBrandName);

                    brand.DeleteBrand();

                    var result = _db.SaveChanges();

                    if (result > 0)
                    {

                        MessageBox.Show("ბრენდი წარმატებით წაიშალა!",
                                       "ბრენდის წაშლა",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);

                        productData.DataSource = _db.Brands.Select(c => new
                        {
                            დასახელება = c.Name,
                            აღწერა = c.Description

                        }).ToList();

                    }
                    else
                    {
                        MessageBox.Show("ბრენდის წაშლა ვერ მოხერხდა, თავიდან სცადეთ!",
                                       "შეცდომა წაშლისას",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ  წაშლის უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }

    }

    private void edit_Btn_Click(object sender, EventArgs e)
    {
        var user = _db.Users.FirstOrDefault(o => o.Id == userID);

        if (user.Role.ToString() == "Admin")
        {
            if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
            {
                var row = productData.CurrentRow;
                var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
                var product = _db.Products.FirstOrDefault(p => p.Code == prodIndex);
                transferProduct = product;
                Edit_Product edit_Product = new Edit_Product();
                edit_Product.Show();
            }
            else if (sortCat_Btn.Location == new System.Drawing.Point(350, 8))
            {
                var row = productData.CurrentRow;
                var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
                var category = _db.Categories.FirstOrDefault(p => p.Name == catBrandName);
                transferCategory = category;
                Edit_Category edit_Category = new Edit_Category();
                edit_Category.Show();
            }
            else if (sortBrand_Btn.Location == new System.Drawing.Point(350, 8))
            {
                var row = productData.CurrentRow;
                var catBrandName = productData.CurrentRow.Cells["დასახელება"].Value.ToString();
                var brand = _db.Brands.FirstOrDefault(p => p.Name == catBrandName);
                transferBrand = brand;
                Edit_Brand edit_Brand = new Edit_Brand();
                edit_Brand.Show();
            }
        }
        else
        {
            MessageBox.Show("თქვენ არ გაქვთ  რედაქტირების უფლება",
                                   "შეზღუდული უფლებები",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
        }

    }

    private void ProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView grid = (DataGridView)sender;

        if (grid.Columns[e.ColumnIndex].Name == "გაყიდვა" && e.RowIndex >= 0)
        {
            var row = productData.CurrentRow;
            var prodIndex = productData.CurrentRow.Cells["კოდი"].Value.ToString();
            var product = _db.Products.FirstOrDefault(p => p.Code == prodIndex);
            transferProduct = product;
            Sell_Product sellProduct = new Sell_Product();
            sellProduct.Show();
        }
    }

    KryptonDataGridViewButtonColumn createSellButton()
    {

        var sell = new KryptonDataGridViewButtonColumn
        {
            Name = "Sell",
            HeaderText = "Buttons",
            Text = "გაყიდვა",
            UseColumnTextForButtonValue = true
        };

        return sell;
    }

    private void productData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (sortProd_Btn.Location == new System.Drawing.Point(350, 8))
        {
            DataGridViewRow row = productData.Rows[e.RowIndex];

            if (row.Cells["სტატუსი"] is DataGridViewTextBoxCell cell)
            {
                string state = cell.Value.ToString();

                if (state == "მარაგშია")
                {
                    cell.Style.ForeColor = Color.DarkGreen;
                }
                else if (state == "ამოიწურა")
                {
                    cell.Style.ForeColor = Color.Red;
                }
            }
        }

    }

    private void download_Btn_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        var random = new Random();
        var letters = "";
        for (int i = 0; i < 15; i++)
        {
            int number = random.Next(65, 91);

            char letter = Convert.ToChar(number);

            letters += letter;
        }

        var fileName = letters.ToString();

        folderBrowserDialog.Description = "აირჩიეთ ფოლდერი სადაც შეინახავთ ფაილს";
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            // get the folder path
            string folderPath = folderBrowserDialog.SelectedPath;

            string filePaths = Path.Combine(folderPath, fileName + ".xlsx");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();

            var workSheet = excel.Workbook.Worksheets.Add("მომხმარებლები");

            workSheet.TabColor = System.Drawing.Color.Blue;
            workSheet.DefaultRowHeight = 12;

            workSheet.Row(1).Height = 20;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;


            workSheet.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Column(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Column(5).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            workSheet.Cells[1, 1].Value = "კოდი";
            workSheet.Cells[1, 2].Value = "პროდუქტი";
            workSheet.Cells[1, 3].Value = "რაოდენობა";

            int recordIndex = 2;
            int total = 0;

            var custData = _db.Products.Select(c => new
            {
                კოდი = c.Code,
                პროდუქტი = c.Name,
                რაოდენობა = c.Storage.TotalAmount
            }).ToList();

            foreach (var article in custData)
            {
                workSheet.Cells[recordIndex, 1].Value = article.კოდი;
                workSheet.Cells[recordIndex, 2].Value = article.პროდუქტი;
                workSheet.Cells[recordIndex, 3].Value = article.რაოდენობა;
                total += article.რაოდენობა;
                recordIndex++;
            }
            workSheet.Cells[recordIndex, 3].Value = $"ჯამი: {total}";
            workSheet.Cells[recordIndex, 3].Style.Font.Color.SetColor(Color.Blue);
            workSheet.Cells[recordIndex, 3].Style.Font.Bold = true;
            var range = workSheet.Cells[1, 1, recordIndex - 1, 3];
            var table = workSheet.Tables.Add(range, "მარაგი");

            // Set the table style
            table.TableStyle = TableStyles.Medium2;
            table.ShowFilter = false;

            workSheet.Column(1).AutoFit();
            workSheet.Column(2).AutoFit();
            workSheet.Column(3).AutoFit();

            try
            {

                FileStream objFileStrm = File.Create(filePaths);
                objFileStrm.Close();

                // Write content to excel file  
                File.WriteAllBytes(filePaths, excel.GetAsByteArray());
                //Close Excel package 
                excel.Dispose();

                MessageBox.Show("ფაილი წარმატებით შეინახა!",
                               "ფაილი შენახულია",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("ფაილის შენახვა ვერ მოხერხდა,სცადეთ თავიდან",
                               "ხარვეზი შენახვისას",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }

        }
    }
}
