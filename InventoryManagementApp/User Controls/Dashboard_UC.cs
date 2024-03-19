using InventoryManagementApp.Data;
using System.Globalization;

namespace InventoryManagementApp.User_Controls;

public partial class Dashboard_UC : UserControl
{
    InventoryContext _db = new InventoryContext();
    public Dashboard_UC()
    {
        InitializeComponent();
        int packedCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.მზადდება);
        int shippedCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.გზაშია);
        int deliveredCount = _db.Sales.Count(sale => sale.Activity == Common.Enums.Activity.მიწოდებულია);
        
        packText.Text = packedCount.ToString();
        shippingText.Text = shippedCount.ToString();
        deliveryText.Text = deliveredCount.ToString();
        fromDate.Value = DateTime.Now.Date;
        toDate.Value = DateTime.Now.Date;
        fromDate.Enabled = false;
        toDate.Enabled = false;
        fromProfit.Visible = false;
        toProfit.Visible = false;
        dash.Visible = false;

        var totalSold = _db.Sales.Where(s => s.IsDeleted == false).ToList().Sum(s => s.Amount);

        var storage = _db.Storages.Where(s => s.Product.IsDeleted == false)
                                  .ToList()
                                  .Sum(s => s.TotalAmount);

        storage_Text.Text = storage.ToString();
        totalSold_Text.Text = totalSold.ToString();
        var productNames = _db.Products.Where(s => !s.IsDeleted).Select(s => s.Name).ToList();
        productNames.Insert(0, "ყველა პროდუქტი");
        productCombo.DataSource = productNames;

        SevenDays();
        TopSales();
        AllProfitLoss();
    }

    public void TopSales()
    {
        topChart.Title.Text = "Top 3 გაყიდვადი პროდუქტი";
        var topProducts = _db.Products
                                      .Where(s => !s.IsDeleted)
                                      .Where(p => !p.IsDeleted && p.Sales
                                      .Any(s => !s.IsDeleted))
                                      .GroupBy(p => p, (key, group) => new
                                      {
                                          Product = group.First().Name.ToString(),
                                          TotalAmount = group.SelectMany(s => s.Sales
                                                             .Where(s => !s.IsDeleted)
                                                             .Select(s => s.Amount)).Sum()
                                      })
                                      .OrderBy(result => result.TotalAmount)
                                      .ToList();
        int i = 0;
        foreach (var product in topProducts)
        {
            if (i == 0)
            {
                MiddePie.DataPoints.Add(product.Product, product.TotalAmount);
                MiddePie.Label = product.Product;

            }
            else if (i == 1)
            {
                MinPie.DataPoints.Add(product.Product, product.TotalAmount);
                MinPie.Label = product.Product;
            }
            else if (i == 2)
            {
                MaxPie.DataPoints.Add(product.Product, product.TotalAmount);
                MaxPie.Label = product.Product;
            }

            if (i > 2)
            {
                break;
            }
            i++;
        }
    }
    public void ThreeMonth()
    {
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        startDate = startDate.AddMonths(-((startDate.Month - 1) % 3));
        DateTime endDate = startDate.AddMonths(3).AddDays(-1);

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();


        var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                      .Select(offset => startDate.AddDays(offset).ToString("MMM"))
                                      .Distinct()
                                      .OrderBy(m => DateTime.ParseExact(m, "MMM", null))
                                      .ToList();

        var chartData = monthsInRange.GroupJoin(sales,
                                        month => month,
                                        sale => sale.Date?.ToString("MMM"),
                                        (month, monthSales) => new
                                        {
                                            Month = month,
                                            TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                                        })
                                    .OrderBy(g => g.Month)
                                    .Reverse()
                                    .ToList();

        saleChart.DataPoints.Clear();
        foreach (var dataPoint in chartData)
        {

            saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);

        }

        saleChart.Invalidate();
    }

    public void ThreeMonthDetailed(string name)
    {
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        startDate = startDate.AddMonths(-((startDate.Month - 1) % 3));
        DateTime endDate = startDate.AddMonths(3).AddDays(-1);

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Product.Name == name)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                      .Select(offset => startDate.AddDays(offset).ToString("MMM"))
                                      .Distinct()
                                      .OrderBy(m => DateTime.ParseExact(m, "MMM", null))
                                      .ToList();

        var chartData = monthsInRange.GroupJoin(sales,
                                        month => month,
                                        sale => sale.Date?.ToString("MMM"),
                                        (month, monthSales) => new
                                        {
                                            Month = month,
                                            TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                                        })
                                    .OrderBy(g => g.Month)
                                    .Reverse()
                                    .ToList();

        saleChart.DataPoints.Clear();
        foreach (var dataPoint in chartData)
        {

            saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);

        }
        saleChart.Invalidate();
    }
    public void SevenDays()
    {
        DateTime startDate = DateTime.Now.Date.AddDays(-6);
        DateTime endDate = DateTime.Now.Date;

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var daysInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
            .Select(offset => startDate.AddDays(offset).ToString("dddd"))
            .Distinct()
            .ToList();

        saleChart.DataPoints.Clear();

        foreach (var day in daysInRange)
        {
            var totalAmount = sales
                .Where(s => s.Date?.ToString("dddd") == day)
                .Sum(s => s?.Amount ?? 0);

            saleChart.DataPoints.Add(day, totalAmount);
        }
        saleChart.Invalidate();
    }

    public void SevenDaysDetailed(string name)
    {
        DateTime startDate = DateTime.Now.Date.AddDays(-6);
        DateTime endDate = DateTime.Now.Date;

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Product.Name == name)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var daysInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
            .Select(offset => startDate.AddDays(offset).ToString("dddd"))
            .Distinct()
            .ToList();

        saleChart.DataPoints.Clear();

        foreach (var day in daysInRange)
        {
            var totalAmount = sales
                .Where(s => s.Date?.ToString("dddd") == day)
                .Sum(s => s?.Amount ?? 0);

            saleChart.DataPoints.Add(day, totalAmount);
        }
        saleChart.Invalidate();
    }

    public void OneMonth()
    {
        DateTime startDate = DateTime.Now.AddMonths(-1);
        DateTime endDate = DateTime.Now;

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var daysInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                        .Select(offset => startDate.AddDays(offset))
                                        .Distinct()
                                        .Select(day => day.ToString("MMM-dd"))
                                        .ToList();

        saleChart.DataPoints.Clear();

        foreach (var day in daysInRange)
        {
            var totalAmount = sales
                .Where(s => s.Date?.ToString("MMM-dd") == day)
                .Sum(s => s?.Amount ?? 0);

            saleChart.DataPoints.Add(day, totalAmount);
        }
        saleChart.Invalidate();
    }

    public void OneMonthDetailed(string name)
    {
        DateTime startDate = DateTime.Now.AddMonths(-1);
        DateTime endDate = DateTime.Now;

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Product.Name == name)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var daysInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                        .Select(offset => startDate.AddDays(offset))
                                        .Distinct()
                                        .Select(day => day.ToString("MMM-dd"))
                                        .ToList();

        saleChart.DataPoints.Clear();

        foreach (var day in daysInRange)
        {
            var totalAmount = sales
                .Where(s => s.Date?.ToString("MMM-dd") == day)
                .Sum(s => s?.Amount ?? 0);

            saleChart.DataPoints.Add(day, totalAmount);
        }
        saleChart.Invalidate();
    }

    public void SixMonths()
    {
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        int startMonth = ((startDate.Month - 1) / 6) * 6 + 1;
        startDate = new DateTime(startDate.Year, startMonth, 1);

        DateTime endDate = startDate.AddMonths(6).AddDays(-1);

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                      .Select(offset => startDate.AddDays(offset).ToString("MMM"))
                                      .Distinct()
                                      .OrderBy(m => DateTime.ParseExact(m, "MMM", null))
                                      .ToList();

        var chartData = monthsInRange.GroupJoin(sales,
                                        month => month,
                                        sale => sale.Date?.ToString("MMM"),
                                        (month, monthSales) => new
                                        {
                                            Month = month,
                                            TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                                        })
                                    .OrderBy(g => DateTime.ParseExact(g.Month, "MMM", CultureInfo.InvariantCulture).Month)
                                    .ToList();

        saleChart.DataPoints.Clear();
        foreach (var dataPoint in chartData)
        {

            saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);

        }
        saleChart.Invalidate();
    }

    public void SixMonthsDetailed(string name)
    {

        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        int startMonth = ((startDate.Month - 1) / 6) * 6 + 1;
        startDate = new DateTime(startDate.Year, startMonth, 1);

        DateTime endDate = startDate.AddMonths(6).AddDays(-1);

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Product.Name == name)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
            .Select(offset => startDate.AddMonths(offset).ToString("MMM"))
            .Distinct()
            .Where(month => DateTime.ParseExact(month, "MMM", CultureInfo.InvariantCulture).Date >= startDate.Date && DateTime.ParseExact(month, "MMM", CultureInfo.InvariantCulture).Date <= endDate.Date)
            .OrderBy(m => DateTime.ParseExact(m, "MMM", CultureInfo.InvariantCulture).Month)
            .ToList();

        var chartData = monthsInRange
            .GroupJoin(sales,
                month => month,
                sale => sale.Date?.ToString("MMM"),
                (month, monthSales) => new
                {
                    Month = month,
                    TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                })
            .OrderBy(g => DateTime.ParseExact(g.Month, "MMM", CultureInfo.InvariantCulture).Month)
            .ToList();

        saleChart.DataPoints.Clear();
        foreach (var dataPoint in chartData)
        {
            saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);
        }
        saleChart.Invalidate();
    }

    public void OneYear()
    {
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        startDate = startDate.AddMonths(-((startDate.Month - 1) % 12));
        DateTime endDate = startDate.AddMonths(12).AddDays(-1);

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
            .Select(offset => startDate.AddMonths(offset).ToString("MMM"))
            .Distinct()
            .OrderBy(m => DateTime.ParseExact(m, "MMM", CultureInfo.InvariantCulture).Month)
            .ToList();

        var chartData = monthsInRange
            .GroupJoin(sales,
                month => month,
                sale => sale.Date?.ToString("MMM"),
                (month, monthSales) => new
                {
                    Month = month,
                    TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                })
            .OrderBy(g => DateTime.ParseExact(g.Month, "MMM", CultureInfo.InvariantCulture).Month)
            .ToList();

        saleChart.DataPoints.Clear();
        foreach (var dataPoint in chartData)
        {
            saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);
        }
        saleChart.Invalidate();
    }

    public void OneYearDetailed(string name)
    {
        DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        startDate = startDate.AddMonths(-((startDate.Month - 1) % 12));
        DateTime endDate = startDate.AddMonths(12).AddDays(-1);

        var sales = _db.Sales
            .Where(s => s.IsDeleted == false)
            .Where(s => s.Product.Name == name)
            .Where(s => s.Date >= startDate && s.Date <= endDate)
            .OrderBy(s => s.Date)
            .ToList();

        var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
            .Select(offset => startDate.AddMonths(offset).ToString("MMM"))
            .Distinct()
            .OrderBy(m => DateTime.ParseExact(m, "MMM", CultureInfo.InvariantCulture).Month)
            .ToList();

        var chartData = monthsInRange
            .GroupJoin(sales,
                month => month,
                sale => sale.Date?.ToString("MMM"),
                (month, monthSales) => new
                {
                    Month = month,
                    TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                })
            .OrderBy(g => DateTime.ParseExact(g.Month, "MMM", CultureInfo.InvariantCulture).Month)
            .ToList();

        saleChart.DataPoints.Clear();
        foreach (var dataPoint in chartData)
        {
            saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);
        }
        saleChart.Invalidate();
    }

    private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedDateRange = dateCombo.SelectedIndex;
        var selectedBox = productCombo.Text;
        var selectedBoxIndex = productCombo.SelectedIndex;
        if (selectedBoxIndex != 0)
        {
            var product = _db.Products.FirstOrDefault(p => p.Name == selectedBox && !p.IsDeleted);

            if (selectedBox == product.Name)
            {
                switch (selectedDateRange)
                {
                    case 0:
                        SevenDaysDetailed(selectedBox);
                        break;
                    case 1:
                        OneMonthDetailed(selectedBox);
                        break;
                    case 2:
                        ThreeMonthDetailed(selectedBox);
                        break;
                    case 3:
                        SixMonthsDetailed(selectedBox);
                        break;
                    case 4:
                        OneYearDetailed(selectedBox);
                        break;
                }
            }
        }
        else
        {
            switch (selectedDateRange)
            {
                case 0:
                    SevenDays();
                    break;
                case 1:
                    OneMonth();
                    break;
                case 2:
                    ThreeMonth();
                    break;
                case 3:
                    SixMonths();
                    break;
                case 4:
                    OneYear();
                    break;
            }
        }
    }

    private void dateCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedDateRange = dateCombo.SelectedIndex;
        var selectedBox = productCombo.Text;
        var product = _db.Products.FirstOrDefault(p => p.Name == selectedBox && !p.IsDeleted);
        if (selectedBox != "ყველა პროდუქტი")
        {
            if (selectedBox == product.Name)
            {
                switch (selectedDateRange)
                {
                    case 0:
                        SevenDaysDetailed(selectedBox);
                        fromDate.Enabled = false;
                        toDate.Enabled = false;
                        break;
                    case 1:
                        OneMonthDetailed(selectedBox);
                        fromDate.Enabled = false;
                        toDate.Enabled = false;
                        break;
                    case 2:
                        ThreeMonthDetailed(selectedBox);
                        fromDate.Enabled = false;
                        toDate.Enabled = false;
                        break;
                    case 3:
                        SixMonthsDetailed(selectedBox);
                        fromDate.Enabled = false;
                        toDate.Enabled = false;
                        break;
                    case 4:
                        OneYearDetailed(selectedBox);
                        fromDate.Enabled = false;
                        toDate.Enabled = false;
                        break;
                    case 5:
                        fromDate.Enabled = true;
                        toDate.Enabled = true;
                        break;
                }
            }
        }
        else
        {
            switch (selectedDateRange)
            {
                case 0:
                    SevenDays();
                    fromDate.Enabled = false;
                    toDate.Enabled = false;
                    break;
                case 1:
                    OneMonth();
                    fromDate.Enabled = false;
                    toDate.Enabled = false;
                    break;
                case 2:
                    ThreeMonth();
                    fromDate.Enabled = false;
                    toDate.Enabled = false;
                    break;
                case 3:
                    SixMonths();
                    fromDate.Enabled = false;
                    toDate.Enabled = false;
                    break;
                case 4:
                    OneYear();
                    fromDate.Enabled = false;
                    toDate.Enabled = false;
                    break;
                case 5:
                    fromDate.Enabled = true;
                    toDate.Enabled = true;
                    break;
            }
        }
    }

    private void fromDate_ValueChanged(object sender, EventArgs e)
    {
        var selectedBox = productCombo.Text;
        var product = _db.Products.FirstOrDefault(p => p.Name == selectedBox && !p.IsDeleted);

        if (selectedBox == product?.Name)
        {
            CustomDateDetailed(selectedBox);
        }
        else
        {
            CustomDate();
        }
    }

    private void toDate_ValueChanged(object sender, EventArgs e)
    {
        var selectedBox = productCombo.Text;
        var product = _db.Products.FirstOrDefault(p => p.Name == selectedBox && !p.IsDeleted);

        if (selectedBox == product?.Name)
        {
            CustomDateDetailed(selectedBox);
        }
        else
        {
            CustomDate();
        }
    }

    public void CustomDate()
    {
        var startDate = fromDate.Value.Date;
        var endDate = toDate.Value.Date.AddDays(1);
        TimeSpan differenceInDays = endDate - startDate;
        int daysDifference = differenceInDays.Days;
        int monthsDifference = (endDate.Month - startDate.Month) + 12 * (endDate.Year - startDate.Year);

        var sales = _db.Sales
                            .Where(s => s.IsDeleted == false)
                            .Where(s => s.Date >= startDate && s.Date <= endDate)
                            .OrderBy(s => s.Date)
                            .ToList();
        if (startDate <= endDate)
        {
            if (daysDifference <= 7)
            {
                var daysInRange = Enumerable.Range(0, daysDifference + 1)
                                            .Select(offset => startDate.AddDays(offset))
                                            .Distinct()
                                            .Select(day => day.ToString("dddd"))
                                            .ToList();

                saleChart.DataPoints.Clear();

                foreach (var day in daysInRange)
                {
                    var totalAmount = sales
                        .Where(s => s.Date?.ToString("dddd") == day)
                        .Sum(s => s?.Amount ?? 0);

                    saleChart.DataPoints.Add(day, totalAmount);
                }
                saleChart.Invalidate();
            }

            if (daysDifference > 7 && daysDifference <= 31)
            {
                var daysInRange = Enumerable.Range(0, daysDifference + 1)
                                            .Select(offset => startDate.AddDays(offset))
                                            .Distinct()
                                            .Select(day => day.ToString("MMM-dd"))
                                            .ToList();

                saleChart.DataPoints.Clear();

                foreach (var day in daysInRange)
                {
                    var totalAmount = sales
                        .Where(s => s.Date?.ToString("MMM-dd") == day)
                        .Sum(s => s?.Amount ?? 0);

                    saleChart.DataPoints.Add(day, totalAmount);
                }
                saleChart.Invalidate();
            }

            if (daysDifference > 31 && daysDifference <= 93)
            {
               var weeksAndMonthsData = sales
                                            .Where(s => s.Date.HasValue && s.Date.Value >= startDate && s.Date.Value <= endDate)
                                            .GroupBy(s => new { Year = s.Date.Value.Year, Month = s.Date.Value.Month })
                                            .OrderBy(group => group.Key.Year)
                                            .ThenBy(group => group.Key.Month)
                                            .Select(group => new
                                            {
                                                Year = group.Key.Year,
                                                Month = group.Key.Month,
                                                WeekData = GetWeeksInDateRange(startDate, endDate, DayOfWeek.Sunday)
                                                    .GroupJoin(
                                                        group,
                                                        week => week,
                                                        sale => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(sale.Date.Value, CalendarWeekRule.FirstDay, DayOfWeek.Sunday),
                                                        (week, sales) => new
                                                        {
                                                            WeekNumber = week,
                                                            TotalAmount = sales.Sum(s => s.Amount)
                                                        })
                                                    .ToList()
                                            })
                                            .ToList();

                List<int> GetWeeksInDateRange(DateTime startDate, DateTime endDate, DayOfWeek startOfWeek)
                {
                    var weeks = new List<int>();

                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        if (date.DayOfWeek == startOfWeek)
                        {
                            weeks.Add(CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday));
                        }
                    }

                    return weeks.Distinct().ToList();
                }

                saleChart.DataPoints.Clear();
                foreach (var monthData in weeksAndMonthsData)
                {
                    saleChart.DataPoints.Add($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthData.Month)} {monthData.Year}", 0);

                    foreach (var weekData in monthData.WeekData)
                    {
                        saleChart.DataPoints.Add($"Week {weekData.WeekNumber}", weekData.TotalAmount);
                    }
                }
                saleChart.Invalidate();

            }

            if (daysDifference > 93 && daysDifference <= 365)
            {
                var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                              .Select(offset => startDate.AddDays(offset).ToString("MMM"))
                                              .Distinct()
                                              .OrderBy(m => DateTime.ParseExact(m, "MMM", null))
                                              .ToList();

                var chartData = monthsInRange.GroupJoin(sales,
                                                month => month,
                                                sale => sale.Date?.ToString("MMM"),
                                                (month, monthSales) => new
                                                {
                                                    Month = month,
                                                    TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                                                })
                                            .OrderBy(g => DateTime.ParseExact(g.Month, "MMM", CultureInfo.InvariantCulture).Month)
                                            .ToList();

                saleChart.DataPoints.Clear();
                foreach (var dataPoint in chartData)
                {

                    saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);

                }
                saleChart.Invalidate();
            }
        }
        else
        {
            saleChart.DataPoints.Clear();
        }
    }

    public void CustomDateDetailed(string name)
    {
        var startDate = fromDate.Value.Date;
        var endDate = toDate.Value.Date.AddDays(1);
        TimeSpan differenceInDays = endDate - startDate;
        int daysDifference = differenceInDays.Days;
        int monthsDifference = (endDate.Month - startDate.Month) + 12 * (endDate.Year - startDate.Year);

        var sales = _db.Sales
                            .Where(s => s.IsDeleted == false)
                            .Where(s => s.Product.Name == name)
                            .Where(s => s.Date >= startDate && s.Date <= endDate)
                            .OrderBy(s => s.Date)
                            .ToList();
        if (startDate <= endDate)
        {
            if (daysDifference <= 7)
            {
                var daysInRange = Enumerable.Range(0, daysDifference + 1)
                                            .Select(offset => startDate.AddDays(offset))
                                            .Distinct()
                                            .Select(day => day.ToString("dddd"))
                                            .ToList();

                saleChart.DataPoints.Clear();

                foreach (var day in daysInRange)
                {
                    var totalAmount = sales
                        .Where(s => s.Date?.ToString("dddd") == day)
                        .Sum(s => s?.Amount ?? 0);

                    saleChart.DataPoints.Add(day, totalAmount);
                }
                saleChart.Invalidate();
            }

            if (daysDifference > 7 && daysDifference <= 31)
            {
                var daysInRange = Enumerable.Range(0, daysDifference + 1)
                                            .Select(offset => startDate.AddDays(offset))
                                            .Distinct()
                                            .Select(day => day.ToString("MMM-dd"))
                                            .ToList();

                saleChart.DataPoints.Clear();

                foreach (var day in daysInRange)
                {
                    var totalAmount = sales
                        .Where(s => s.Date?.ToString("MMM-dd") == day)
                        .Sum(s => s?.Amount ?? 0);

                    saleChart.DataPoints.Add(day, totalAmount);
                }

                saleChart.Invalidate();
            }

            if (daysDifference > 31 && daysDifference <= 93)
            {
               var weeksAndMonthsData = sales
                                            .Where(s => s.Date.HasValue && s.Date.Value >= startDate && s.Date.Value <= endDate)
                                            .GroupBy(s => new { Year = s.Date.Value.Year, Month = s.Date.Value.Month })
                                            .OrderBy(group => group.Key.Year)
                                            .ThenBy(group => group.Key.Month)
                                            .Select(group => new
                                            {
                                                Year = group.Key.Year,
                                                Month = group.Key.Month,
                                                WeekData = GetWeeksInDateRange(startDate, endDate, DayOfWeek.Sunday)
                                                    .GroupJoin(
                                                        group,
                                                        week => week,
                                                        sale => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(sale.Date.Value, CalendarWeekRule.FirstDay, DayOfWeek.Sunday),
                                                        (week, sales) => new
                                                        {
                                                            WeekNumber = week,
                                                            TotalAmount = sales.Sum(s => s.Amount)
                                                        })
                                                    .ToList()
                                            })
                                            .ToList();

                List<int> GetWeeksInDateRange(DateTime startDate, DateTime endDate, DayOfWeek startOfWeek)
                {
                    var weeks = new List<int>();

                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        if (date.DayOfWeek == startOfWeek)
                        {
                            weeks.Add(CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday));
                        }
                    }

                    return weeks.Distinct().ToList();
                }

                saleChart.DataPoints.Clear();
                foreach (var monthData in weeksAndMonthsData)
                {
                    saleChart.DataPoints.Add($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthData.Month)} {monthData.Year}", 0);

                    foreach (var weekData in monthData.WeekData)
                    {
                        saleChart.DataPoints.Add($"Week {weekData.WeekNumber}", weekData.TotalAmount);
                    }
                }
                saleChart.Invalidate();

            }

            if (daysDifference > 93 && daysDifference <= 365)
            {
                var monthsInRange = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                              .Select(offset => startDate.AddDays(offset).ToString("MMM"))
                                              .Distinct()
                                              .OrderBy(m => DateTime.ParseExact(m, "MMM", null))
                                              .ToList();

                var chartData = monthsInRange.GroupJoin(sales,
                                                month => month,
                                                sale => sale.Date?.ToString("MMM"),
                                                (month, monthSales) => new
                                                {
                                                    Month = month,
                                                    TotalAmount = monthSales.Sum(s => s?.Amount ?? 0)
                                                })
                                            .OrderBy(g => DateTime.ParseExact(g.Month, "MMM", CultureInfo.InvariantCulture).Month)
                                            .ToList();

                saleChart.DataPoints.Clear();
                foreach (var dataPoint in chartData)
                {
                    saleChart.DataPoints.Add(dataPoint.Month, dataPoint.TotalAmount);
                }
                saleChart.Invalidate();
            }
        }
        else
        {
            saleChart.DataPoints.Clear();
        }
    }

    private void incomeDateRange_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedComboIndex = incomeDataRange.SelectedIndex;

        switch (selectedComboIndex)
        {
            case 0:
                AllProfitLoss();
                fromProfit.Visible = false;
                toProfit.Visible = false;
                dash.Visible = false;
                break;
            case 1:
                WeekProfitLoss();
                fromProfit.Visible = false;
                toProfit.Visible = false;
                dash.Visible = false;
                break;
            case 2:
                MonthProfitLoss(1);
                fromProfit.Visible = false;
                toProfit.Visible = false;
                dash.Visible = false;
                break;
            case 3:
                MonthProfitLoss(3);
                fromProfit.Visible = false;
                toProfit.Visible = false;
                dash.Visible = false;
                break;
            case 4:
                MonthProfitLoss(6);
                fromProfit.Visible = false;
                toProfit.Visible = false;
                dash.Visible = false;
                break;
            case 5:
                MonthProfitLoss(12);
                fromProfit.Visible = false;
                toProfit.Visible = false;
                dash.Visible = false;
                break;
            case 6:
                CustomProfitLoss();
                fromProfit.Visible = true;
                toProfit.Visible = true;
                dash.Visible = true;
                break;
        }
    }



    public void AllProfitLoss()
    {
        var income = _db.Sales.Where(s => s.IsDeleted == false).Select(s => s.DynamicPrice * s.Amount).ToList().Sum();
        var expense = _db.Products.Where(p => !p.IsDeleted).Select(s => s.NetCost * s.Storage.TotalAmount).ToList().Sum();
        var profit = income - expense;

        income_Txt.Text = income.ToString("F2") + " ₾";
        exp_Text.Text = expense.ToString("F2") + " ₾";
        profit_Txt.Text = profit.ToString("F2") + " ₾";

        if (profit < 0)
        {
            profit_Txt.ForeColor = Color.FromArgb(167, 23, 26);
        }
        else
        {
            profit_Txt.ForeColor = Color.LawnGreen;
        }
    }

    public void WeekProfitLoss()
    {
        DateTime startDate = DateTime.Now.Date.AddDays(-6);
        DateTime endDate = DateTime.Now.Date.AddDays(1);
        var product = _db.Products.Where(p => !p.IsDeleted).Select(p => p.Name).ToList();

        var income = _db.Sales.Where(s => s.IsDeleted == false)
                              .Where(s => s.Date.Value >= startDate && s.Date.Value <= endDate)
                              .Select(s => s.DynamicPrice * s.Amount)
                              .ToList()
                              .Sum();

        var expenseAddAmount = _db.AddAmounts.Where(a => a.Product.IsDeleted == false)
                                              .Where(a => a.AdditionCreateDate >= startDate
                                                     && a.AdditionCreateDate <= endDate)
                                              .Select(a => a.Amount * a.Product.NetCost)
                                              .ToList()
                                              .Sum();

        var expenseFirst = _db.Products.Where(p => p.IsDeleted == false)
                                        .Select(p => p.Storage.TotalAmount * p.NetCost).ToList().Sum();

        var expenseCreate = expenseFirst - expenseAddAmount;
        var expense = expenseCreate + expenseAddAmount;
        var profit = income - expense;

        income_Txt.Text = income.ToString("F2") + " ₾";
        exp_Text.Text = expense.ToString("F2") + " ₾";
        profit_Txt.Text = profit.ToString("F2") + " ₾";

        if (profit < 0)
        {
            profit_Txt.ForeColor = Color.FromArgb(167, 23, 26);
        }
        else
        {
            profit_Txt.ForeColor = Color.LawnGreen;
        }
    }

    public void MonthProfitLoss(int monthRange)
    {
        DateTime startDate = DateTime.Now.Date.AddMonths(-monthRange);
        DateTime endDate = DateTime.Now.Date.AddDays(1);
        var product = _db.Products.Where(p => !p.IsDeleted).Select(p => p.Name).ToList();

        var income = _db.Sales.Where(s => s.IsDeleted == false)
                              .Where(s => s.Date.Value >= startDate && s.Date.Value <= endDate)
                              .Select(s => s.DynamicPrice * s.Amount)
                              .ToList()
                              .Sum();

        var expenseAddAmount = _db.AddAmounts.Where(a => a.Product.IsDeleted == false)
                                             .Where(a => a.AdditionCreateDate >= startDate
                                                    && a.AdditionCreateDate <= endDate)
                                             .Select(a => a.Amount * a.Product.NetCost)
                                             .ToList()
                                             .Sum();

        var expenseFirst = _db.Products.Where(p => p.IsDeleted == false)
                                        .Select(p => p.Storage.TotalAmount * p.NetCost).ToList().Sum();

        var expenseCreate = expenseFirst - expenseAddAmount;
        var expense = expenseCreate + expenseAddAmount;
        var profit = income - expense;

        income_Txt.Text = income.ToString("F2") + " ₾";
        exp_Text.Text = expense.ToString("F2") + " ₾";
        profit_Txt.Text = profit.ToString("F2") + " ₾";

        if (profit < 0)
        {
            profit_Txt.ForeColor = Color.FromArgb(167, 23, 26);
        }
        else
        {
            profit_Txt.ForeColor = Color.LawnGreen;
        }
    }

    public void CustomProfitLoss()
    {
        DateTime startDate = fromProfit.Value.Date;
        DateTime endDate = toProfit.Value.Date.AddDays(1); ;
        var product = _db.Products.Where(p => !p.IsDeleted).Select(p => p.Name).ToList();

        var income = _db.Sales.Where(s => s.IsDeleted == false)
                              .Where(s => s.Date.Value >= startDate && s.Date.Value <= endDate)
                              .Select(s => s.DynamicPrice * s.Amount)
                              .ToList()
                              .Sum();

        var expenseCreate = _db.Products.Where(p => p.IsDeleted == false)
                                  .Where(p => p.CreateDate >= startDate && p.CreateDate <= endDate)
                                  .Select(s => s.NetCost * s.Storage.TotalAmount)
                                  .ToList()
                                  .Sum();

        var expenseAddAmount = _db.AddAmounts.Where(a => a.Product.IsDeleted == false)
                                             .Where(a => a.AdditionCreateDate >= startDate
                                                    && a.AdditionCreateDate <= endDate)
                                             .Select(a => a.Amount * a.Product.NetCost)
                                             .ToList()
                                             .Sum();

        var expense = expenseCreate + expenseAddAmount;
        var profit = income - expense;

        income_Txt.Text = income.ToString("F2") + " ₾";
        exp_Text.Text = expense.ToString("F2") + " ₾";
        profit_Txt.Text = profit.ToString("F2") + " ₾";

        if (profit < 0)
        {
            profit_Txt.ForeColor = Color.FromArgb(167, 23, 26);
        }
        else
        {
            profit_Txt.ForeColor = Color.LawnGreen;
        }
    }

    private void fromProfit_ValueChanged(object sender, EventArgs e)
    {
        CustomProfitLoss();
    }

    private void toProfit_ValueChanged(object sender, EventArgs e)
    {
        CustomProfitLoss();
    }
}
