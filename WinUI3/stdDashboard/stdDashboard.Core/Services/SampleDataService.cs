using stdDashboard.Core.Contracts.Services;
using stdDashboard.Core.Models;

namespace stdDashboard.Core.Services;

// This class holds sample data used by some generated pages to show how they can be used.
// TODO: The following classes have been created to display sample data. Delete these files once your app is using real data.
// 1. Contracts/Services/ISampleDataService.cs
// 2. Services/SampleDataService.cs
// 3. Models/SampleCompany.cs
// 4. Models/SampleOrder.cs
// 5. Models/SampleOrderDetail.cs
public class SampleDataService : ISampleDataService
{
    private List<SampleOrder> _allOrders;

    public SampleDataService()
    {
    }

    private static IEnumerable<SampleOrder> AllOrders()
    {
        // The following is order summary data
        var companies = AllCompanies();
        return companies.SelectMany(c => c.Orders);
    }

    private static IEnumerable<SampleCompany> AllCompanies()
    {
        return new List<SampleCompany>()
        {
            new SampleCompany()
            {
                CompanyID = "",
                CompanyName = "开发中",
                ContactName = "",
                ContactTitle = "",
                Address = "",
                City = "",
                PostalCode = "",
                Country = "",
                Phone = "",
                Fax = string.Empty,
                Orders = new List<SampleOrder>()
                {
                    new SampleOrder()
                    {
                        OrderID = 10682, // Symbol Home
                        OrderDate = new DateTime(2023, 2, 7),
                        RequiredDate = new DateTime(2023, 2, 7),
                        ShippedDate = new DateTime(2023, 2, 7),
                        ShipperName = "U",
                        ShipperPhone = "",
                        Freight = 36.13,
                        Company = "WinUI3应用",
                        ShipTo = "",
                        OrderTotal = 375.50,
                        Status = "学习中 & 开发中",
                        SymbolCode = 57615,
                        SymbolName = "Home",
                        Details = new List<SampleOrderDetail>()
                        {
                            new SampleOrderDetail()
                            {
                                ProductID = 75,
                                ProductName = "Rhönbräu Klosterbier",
                                Quantity = 30,
                                Discount = 0,
                                QuantityPerUnit = "24 - 0.5 l bottles",
                                UnitPrice = 7.75,
                                CategoryName = "Beverages",
                                CategoryDescription = "Soft drinks, coffees, teas, beers, and ales",
                                Total = 232.50
                            }
                        }
                    }
                }
            }
        };
    }

    public async Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync()
    {
        if (_allOrders == null)
        {
            _allOrders = new List<SampleOrder>(AllOrders());
        }

        await Task.CompletedTask;
        return _allOrders;
    }
}
