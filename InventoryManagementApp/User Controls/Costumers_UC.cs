using InventoryManagementApp.Common.Enums;
using InventoryManagementApp.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System.Data;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace InventoryManagementApp.User_Controls;

public partial class Costumers_UC : UserControl
{
    InventoryContext _db = new InventoryContext();
    public Costumers_UC()
    {
        InitializeComponent();

        costumersData.DataSource = _db.Sales.Select(c => new
        {
            კოდი = c.Customer.Id,
            სახელი = c.Customer.FirstName,
            გვარი = c.Customer.LastName,
            ტელეფონი = c.Customer.PhoneNumber,
            ლოკაცია = c.Location

        }).ToList();

        var locations = Enum.GetValues(typeof(Location)).Cast<Location>().ToList();
        var stringLocations = locations.Select(l => l.ToString()).ToList();
        List<string> finalLocations = new List<string>();
        finalLocations.Add("ყველა ლოკაცია");
        finalLocations.AddRange(stringLocations);
        location.DataSource = finalLocations;
    }

    private void Search_Txt_TextChanged(object sender, EventArgs e)
    {
        var searchText = Search_Txt.Text;

        if (Search_Txt.Text.Length > 0)
        {


            var search = _db.Sales.Where(c => c.IsDeleted == false).Where(c => c.Customer.FirstName.Contains(searchText) ||
                                              c.Customer.LastName.Contains(searchText) ||
                                              c.Customer.PhoneNumber.Contains(searchText) ||
                                              c.Customer.Id.ToString().Contains(searchText))
                                   .Select(c => new
                                   {
                                       კოდი = c.Customer.Id,
                                       სახელი = c.Customer.FirstName,
                                       გვარი = c.Customer.LastName,
                                       ტელეფონი = c.Customer.PhoneNumber,
                                       ლოკაცია = c.Location

                                   }).ToList();

            costumersData.DataSource = search;
        }
        else
        {
            costumersData.DataSource = _db.Sales.Select(c => new
            {
                კოდი = c.Customer.Id,
                სახელი = c.Customer.FirstName,
                გვარი = c.Customer.LastName,
                ტელეფონი = c.Customer.PhoneNumber,
                ლოკაცია = c.Location

            }).ToList();
        }
    }

    private void location_SelectedIndexChanged(object sender, EventArgs e)
    {
        var index = location.SelectedIndex;

        switch (index)
        {
            case 0:
                costumersData.DataSource = _db.Sales.Select(c => new
                {
                    კოდი = c.Customer.Id,
                    სახელი = c.Customer.FirstName,
                    გვარი = c.Customer.LastName,
                    ტელეფონი = c.Customer.PhoneNumber,
                    ლოკაცია = c.Location

                }).ToList();
                break;
            case 1:
                locationRange("თბილისი");
                break;
            case 2:
                locationRange("შიდა_ქართლი");
                break;
            case 3:
                locationRange("ქვემო_ქართლი");
                break;
            case 4:
                locationRange("კახეთი");
                break;
            case 5:
                locationRange("ჯავახეთი");
                break;
            case 6:
                locationRange("იმერეთი");
                break;
            case 7:
                locationRange("გურია");
                break;
            case 8:
                locationRange("სამეგრელო");
                break;
            case 9:
                locationRange("რაჭა");
                break;
            case 10:
                locationRange("სვანეთი");
                break;
            case 11:
                locationRange("აჭარა");
                break;
            case 12:
                locationRange("ლეჩხუმი");
                break;
            case 13:
                locationRange("აფხაზეთი");
                break;
        }
    }

    void locationRange(string location)
    {
        var enumLocation = (Location)Enum.Parse(typeof(Location), location);
        costumersData.DataSource = _db.Sales.Where(c => c.Location == enumLocation).Select(c => new
        {
            კოდი = c.Customer.Id,
            სახელი = c.Customer.FirstName,
            გვარი = c.Customer.LastName,
            ტელეფონი = c.Customer.PhoneNumber,
            ლოკაცია = c.Location

        }).ToList();
    }

    private void downloadExel_Click(object sender, EventArgs e)
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
            workSheet.Cells[1, 2].Value = "სახელი";
            workSheet.Cells[1, 3].Value = "გვარი";
            workSheet.Cells[1, 4].Value = "ტელეფონის ნომერი";
            workSheet.Cells[1, 5].Value = "ლოკაცია";

            int recordIndex = 2;

            var index = location.SelectedIndex;

            switch (index)
            {
                case 0:
                    var custData = _db.Sales.Select(c => new
                    {
                        კოდი = c.Customer.Id,
                        სახელი = c.Customer.FirstName,
                        გვარი = c.Customer.LastName,
                        ტელეფონი = c.Customer.PhoneNumber,
                        ლოკაცია = c.Location

                    }).ToList();
                    break;
                case 1:
                    tableLoad(workSheet, "თბილისი", ref recordIndex);
                    break;
                case 2:
                    tableLoad(workSheet, "შიდა_ქართლი", ref recordIndex);
                    break;
                case 3:
                    tableLoad(workSheet, "ქვემო_ქართლი", ref recordIndex);
                    break;
                case 4:
                    tableLoad(workSheet, "კახეთი", ref recordIndex);
                    break;
                case 5:
                    tableLoad(workSheet, "ჯავახეთი", ref recordIndex);
                    break;
                case 6:
                    tableLoad(workSheet, "იმერეთი", ref recordIndex);
                    break;
                case 7:
                    tableLoad(workSheet, "გურია", ref recordIndex);
                    break;
                case 8:
                    tableLoad(workSheet, "სამეგრელო", ref recordIndex);
                    break;
                case 9:
                    tableLoad(workSheet, "რაჭა", ref recordIndex);
                    break;
                case 10:
                    tableLoad(workSheet, "სვანეთი", ref recordIndex);
                    break;
                case 11:
                    tableLoad(workSheet, "აჭარა", ref recordIndex);
                    break;
                case 12:
                    tableLoad(workSheet, "ლეჩხუმი", ref recordIndex);
                    break;
                case 13:
                    tableLoad(workSheet, "აფხაზეთი", ref recordIndex);
                    break;
            }

            var range = workSheet.Cells[1, 1, recordIndex - 1, 5];
            var table = workSheet.Tables.Add(range, "მომხმარებლები");

            // Set the table style
            table.TableStyle = TableStyles.Medium2;
            table.ShowFilter = false;

            workSheet.Column(1).AutoFit();
            workSheet.Column(2).AutoFit();
            workSheet.Column(3).AutoFit();
            workSheet.Column(4).AutoFit();
            workSheet.Column(5).AutoFit();

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

    void tableLoad(ExcelWorksheet workSheet, string location, ref int recordIndex)
    {
        var enumLocation = (Location)Enum.Parse(typeof(Location), location);
        var custData = _db.Sales.Where(c => c.Location == enumLocation).Select(c => new
        {
            კოდი = c.Customer.Id,
            სახელი = c.Customer.FirstName,
            გვარი = c.Customer.LastName,
            ტელეფონი = c.Customer.PhoneNumber,
            ლოკაცია = c.Location

        }).ToList();

        foreach (var article in custData)
        {
            workSheet.Cells[recordIndex, 1].Value = article.კოდი;
            workSheet.Cells[recordIndex, 2].Value = article.სახელი;
            workSheet.Cells[recordIndex, 3].Value = article.გვარი;
            workSheet.Cells[recordIndex, 4].Value = article.ტელეფონი;
            workSheet.Cells[recordIndex, 5].Value = article.ლოკაცია;
            recordIndex++;
        }
    }

}
