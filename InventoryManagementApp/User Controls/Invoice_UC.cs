using InventoryManagementApp.Data;
using InventoryManagementApp.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System.Collections.Immutable;
using System.ComponentModel;
using Document = QuestPDF.Fluent.Document;

namespace InventoryManagementApp.User_Controls;

public partial class Invoice_UC : UserControl
{
    InventoryContext _db = new InventoryContext();
    BindingList<object> dataList = new BindingList<object>();
    List<(string Name, decimal Amount, decimal Price, decimal Total)> datas = new List<(string Name, decimal Amount, decimal Price, decimal Total)>();
    public Invoice_UC()
    {
        InitializeComponent();       
        dataList.Clear();
        invoiceData.Rows.Clear();
    }

    private void addProd_btn_Click(object sender, EventArgs e)
    {
        
        if (!string.IsNullOrEmpty(prodName_Txt.Text) ||
           !string.IsNullOrEmpty(amount_Txt.Text) ||
           !string.IsNullOrEmpty(price_Txt.Text))
        {


            string prodName = prodName_Txt.Text;
            decimal amount = decimal.Parse(amount_Txt.Text);
            decimal price = decimal.Parse(price_Txt.Text);
            decimal total = price * amount;

            var data = new
            {
                პროდუქტი = prodName,
                რაოდენობა = amount,
                ფასი = price,
                ჯამი = total
            };
            dataList.Add(data);
            datas.Add((prodName, amount, price, total));
            invoiceData.DataSource = dataList;           
        }
        else
        {
            MessageBox.Show("გთხოვთ, შეავსოთ მოცემული ყველა ველი",
                        "შესავსები ველი ცარიელია",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }
    }

    private void save_Btn_Click(object sender, EventArgs e)
    {
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
        var invoice = _db.InvoiceIDs.FirstOrDefault(i => i.ID == 4);
        InvoiceID invoices = new InvoiceID();
        var invoiceList = _db.InvoiceIDs.Where(i => i.ID == 4).Select(i => i.Number).ToList();
        var invoiceInt = invoiceList[0];
        var invoiceString = "";

        if (invoiceInt < 9)
        {
            invoiceString = $"№ 000{invoiceInt + 1}";
        }
        else if(invoiceInt >= 9 && invoiceInt < 99)
        {
            invoiceString = $"№ 00{invoiceInt + 1}";
        }
        else if(invoiceInt >= 99 && invoiceInt  < 999)
        {
            invoiceString = $"№ 0{invoiceInt + 1}";
        }
        else
        {
            invoiceString = $"№ {invoiceInt + 1}";
        }
        
        string costName = costumerName_Txt.Text;
        string costId = costumerId_Txt.Text;
        string adress = adress_Txt.Text;
        string phoneNum = phoneNum_Txt.Text;
        string email = email_Txt.Text;
        string prodName = prodName_Txt.Text;
        decimal amount = decimal.Parse(amount_Txt.Text);
        decimal price = decimal.Parse(price_Txt.Text);
        decimal total = price * amount;
        decimal finalTotal = 0;
        string fileName = (invoiceInt + 1).ToString();

        if (!string.IsNullOrEmpty(costumerName_Txt.Text) ||
           !string.IsNullOrEmpty(costumerId_Txt.Text) ||
           !string.IsNullOrEmpty(adress_Txt.Text) ||
           !string.IsNullOrEmpty(phoneNum_Txt.Text) ||
           !string.IsNullOrEmpty(email_Txt.Text) ||
           !string.IsNullOrEmpty(prodName_Txt.Text) ||
           !string.IsNullOrEmpty(amount_Txt.Text) ||
           !string.IsNullOrEmpty(price_Txt.Text))
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // set the description
            folderBrowserDialog.Description = "აირჩიეთ ფოლდერი სადაც შეინახავთ ინვოისს";

            // show the dialog and check the result
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // get the folder path
                string folderPath = folderBrowserDialog.SelectedPath;

                string filePaths = Path.Combine(folderPath, fileName + ".pdf");

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);

                        page.Margin(3, QuestPDF.Infrastructure.Unit.Millimetre);

                        page.Header().Inlined(inline =>
                        {
                            byte[] imageData = File.ReadAllBytes("C:\\Users\\salva\\Desktop\\Jani\\Icons\\Jani_newLogo.png");

                            inline.Item().Element(Block);

                            inline.Item().PaddingLeft(20)
                                         .PaddingVertical(25)
                                         .Text("ინვოისი")
                                         .FontFamily(Fonts.SegoeUI)
                                         .FontSize(35)
                                         .Bold()
                                         .FontColor("#4674A5");

                            inline.Item().Width(285)
                                         .TranslateX(90)
                                         .TranslateY(-17)
                                         .PaddingVertical(25)
                                         .Image(imageData);
                        });

                        page.Content().Column(column =>
                        {

                            column.Item().PaddingVertical(-5).LineHorizontal(1).LineColor(Colors.Grey.Medium);
                            column.Item().Row(row =>
                            {
                                row.Spacing(70);

                                row.RelativeItem().Column(column =>
                                {
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("მიმღები:")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(15)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Company Name
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text(costName)
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Company Code
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text(costId)
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Address
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text(adress)
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Email
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text(email)
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Phone Number
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text(phoneNum)
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                });

                                row.RelativeItem().Column(column =>
                                {
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("გამგზავნი:")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(15)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Company Name
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("შ.პ.ს ჯანი 2022")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Company Code
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("ს/ნ 405574659")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Address
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("მის: თბილისი, ვ.დოლიძის ქუჩა, 25-ე კორპუსი.")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Email
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("jani2022business@gmail.com")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Phone Number
                                    column.Item().TranslateX(10)
                                                 .TranslateY(10)
                                                 .Text("ტელ: +995 550050025")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                });

                                row.RelativeItem().Column(column =>
                                {
                                    column.Spacing(5);
                                    //Invoice Number
                                    column.Item().TranslateX(70)
                                                 .TranslateY(10)
                                                 .Text(invoiceString)
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(15)
                                                 .Bold()
                                                 .FontColor("#4674A5");
                                    //Date
                                    if (dateCheckBox.Checked)
                                    {
                                        column.Item().TranslateX(70)
                                                     .TranslateY(10)
                                                     .Text("თარიღი :" + "\n" + DateTime.Now.ToString("dd-MM-yyyy"))
                                                     .FontFamily(Fonts.SegoeUI)
                                                     .FontSize(12)
                                                     .Bold()
                                                     .FontColor("#4674A5");
                                    }
                                    else
                                    {
                                        column.Item().TranslateX(70)
                                                     .TranslateY(10)
                                                     .Text("თარიღი :" + "\n" + date_Txt.Value.Date.ToString("dd-MM-yyyy"))
                                                     .FontFamily(Fonts.SegoeUI)
                                                     .FontSize(12)
                                                     .Bold()
                                                     .FontColor("#4674A5");
                                    }

                                });
                            });
                            column.Item().TranslateY(37).MinimalBox().Table(table =>
                            {
                                QuestPDF.Infrastructure.IContainer DefaultCellStyle(QuestPDF.Infrastructure.IContainer container, string backgroundColor)
                                {
                                    return container
                                        .Border(1)
                                        .BorderColor("#4674A5")
                                        .Background(backgroundColor)
                                        .PaddingVertical(5)
                                        .PaddingHorizontal(10)
                                        .AlignCenter()
                                        .AlignMiddle();
                                }

                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });

                                QuestPDF.Infrastructure.IContainer CellStyle(QuestPDF.Infrastructure.IContainer container) => (QuestPDF.Infrastructure.IContainer)DefaultCellStyle(container, "#4674A5");

                                table.Header(header =>
                                {
                                    header.Cell().RowSpan(1).Element(CellStyle).AlignLeft()
                                                                               .Text("პროდუქტი")
                                                                               .FontFamily(Fonts.SegoeUI)
                                                                               .FontSize(13)
                                                                               .Bold()
                                                                               .FontColor(Colors.White);

                                    header.Cell().RowSpan(1).Element(CellStyle).AlignLeft()
                                                                               .Text("რაოდენობა")
                                                                               .FontFamily(Fonts.SegoeUI)
                                                                               .FontSize(13)
                                                                               .Bold()
                                                                               .FontColor(Colors.White);

                                    header.Cell().RowSpan(1).Element(CellStyle).AlignLeft()
                                                                               .Text("ფასი")
                                                                               .FontFamily(Fonts.SegoeUI)
                                                                               .FontSize(13)
                                                                               .Bold()
                                                                               .FontColor(Colors.White);

                                    header.Cell().RowSpan(1).Element(CellStyle).AlignLeft()
                                                                               .Text("ჯამი")
                                                                               .FontFamily(Fonts.SegoeUI)
                                                                               .FontSize(13)
                                                                               .Bold()
                                                                               .FontColor(Colors.White);
                                });

                                QuestPDF.Infrastructure.IContainer NormalCellStyle(QuestPDF.Infrastructure.IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);

                                foreach (var d in datas)
                                {
                                    table.Cell().Element(NormalCellStyle).Text(d.Name)
                                                                     .FontFamily(Fonts.SegoeUI)
                                                                     .FontSize(10)
                                                                     .Bold()
                                                                     .FontColor("#4674A5");

                                    table.Cell().Element(NormalCellStyle).Text(d.Amount)
                                                                     .FontFamily(Fonts.SegoeUI)
                                                                     .FontSize(10)
                                                                     .Bold()
                                                                     .FontColor("#4674A5");

                                    table.Cell().Element(NormalCellStyle).Text(d.Price + " ₾")
                                                                     .FontFamily(Fonts.SegoeUI)
                                                                     .FontSize(10)
                                                                     .Bold()
                                                                     .FontColor("#4674A5");

                                    table.Cell().Element(NormalCellStyle).Text(d.Total + " ₾")
                                                                     .FontFamily(Fonts.SegoeUI)
                                                                     .FontSize(10)
                                                                     .Bold()
                                                                     .FontColor("#4674A5");

                                    finalTotal += d.Total;
                                }
                            });

                        });

                        page.Footer().Column(column =>
                        {
                            column.Item().Element(FooterRect);
                            column.Item().Row(row =>
                            {
                                row.RelativeItem().Column(column =>
                                {
                                    column.Item().TranslateX(5)
                                                 .TranslateY(-40)
                                                 .Text("საბანკო რეკვიზიტები: ")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(13)
                                                 .Bold()
                                                 .FontColor("#4674A5");

                                    column.Item().TranslateX(5)
                                                 .TranslateY(-40)
                                                 .Text("მიმღები: შ.პ.ს ჯანი 2022")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .FontColor("#4674A5");

                                    column.Item().TranslateX(5)
                                                 .TranslateY(-40)
                                                 .Text("ბანკი: საქართველოს ბანკი")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .FontColor("#4674A5");

                                    column.Item().TranslateX(5)
                                                 .TranslateY(-40)
                                                 .Text("ანგარიში: GE48BG0000000549618803")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .FontColor("#4674A5");

                                    column.Item().TranslateX(5)
                                                 .TranslateY(-40)
                                                 .Text("ბანკის კოდი: BAGAGE22")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .FontColor("#4674A5");
                                });

                                row.RelativeItem().Column(column =>
                                {
                                    column.Item().TranslateX(150)
                                                 .TranslateY(-40)
                                                 .Text($"{finalTotal} ₾")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(20)
                                                 .Bold()
                                                 .FontColor("#4674A5");

                                    column.Item().PaddingVertical(10).LineHorizontal(3).LineColor(Colors.Grey.Medium);

                                    column.Item().TranslateX(10)
                                                 .TranslateY(-37)
                                                 .Text("რატი გაგნიძე - ")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(13)
                                                 .Bold()
                                                 .FontColor("#4674A5");

                                    column.Item().TranslateX(110)
                                                 .TranslateY(-30)
                                                 .Text("დირექტორი")
                                                 .FontFamily(Fonts.SegoeUI)
                                                 .FontSize(12)
                                                 .FontColor("#4674A5");
                                });
                            });
                        });
                        void Block(QuestPDF.Infrastructure.IContainer container)
                        {
                            container
                                .Width(60)
                                .Height(30)
                                .TranslateX(-1)
                                .TranslateY(40)
                                .Border(31)
                                .BorderColor("#4674A5");

                        }

                        void FooterRect(QuestPDF.Infrastructure.IContainer container)
                        {
                            container
                                .Width(575)
                                .Height(5)
                                .TranslateX(0)
                                .TranslateY(100)
                                .Border(31)
                                .BorderColor("#4674A5");

                        }

                    });

                }).GeneratePdf(filePaths);

            }

            

            datas.Clear();
            invoiceData.Rows.Clear();
            invoice.Number += 1;
            _db.Update(invoice);
            var response = _db.SaveChanges();
            if(response > 0)
            {
                MessageBox.Show("პროდუქტი წარმატებით დაემატა!",
                        "წარმატებული შენახვა",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ინვოისის ჩამოტვირთვა ვერ მოხერხდა,სცადეთ თავიდან",
                        "შეცდომა შენახვისას",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }

        }
        else
        {
            MessageBox.Show("გთხოვთ, შეავსოთ მოცემული ყველა ველი",
                        "შესავსები ველი ცარიელია",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

    }

}
