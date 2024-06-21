using Microsoft.EntityFrameworkCore;
using interview.Models;

namespace interview.Data;

public class InventoryRepository : IInventoryRepository
{
    public InventoryRepository()
    {
        using (var context = new ApiContext())
        {
            var inventory = new List<Inventory>
            {
                new Inventory
                {
                    Manufacturer = "Ford",
                    Items = new List<Item>()
                    {
                        new Item { 
                            Sku = "1000",
                            Model = "Mustang",
                            Year = 2021,
                            Color = "Red",
                            Cost = 15343.00M,
                            Status = "Sold"
                        },
                        new Item { 
                            Sku = "1001",
                            Model = "Mustang",
                            Year = 2018,
                            Color = "Blue",
                            Cost = 13499.00M,
                            Status = "Unsold"
                        },
                        new Item { 
                            Sku = "1301",
                            Model = "Ranger",
                            Year = 2014,
                            Color = "Blue",
                            Cost = 12499.00M,
                            Status = "Unsold"
                        },
                    }
                },
                new Inventory
                {
                    Manufacturer = "Fiat",
                    Items = new List<Item>()
                    {
                        new Item { 
                            Sku = "2000",
                            Model = "Urbana",
                            Year = 2020,
                            Color = "Red",
                            Cost = 15343.00M,
                            Status = "Sold"
                        },
                        new Item { 
                            Sku = "2001",
                            Model = "Pop",
                            Year = 2018,
                            Color = "Blue",
                            Cost = 13499.00M,
                            Status = "Preparing"
                        },
                        new Item { 
                            Sku = "2031",
                            Model = "Pop",
                            Year = 2019,
                            Color = "White",
                            Cost = 10999.00M,
                            Status = "Unsold"
                        },
                        new Item { 
                            Sku = "Lounge",
                            Model = "Ranger",
                            Year = 2016,
                            Color = "Silver",
                            Cost = 11499.00M,
                            Status = "Unsold"
                        },
                    },
                },
                new Inventory
                {
                    Manufacturer = "Volkswagon",
                    Items = new List<Item>()
                    {
                        new Item { 
                            Sku = "3031",
                            Model = "Tiguan",
                            Year = 2019,
                            Color = "Silver",
                            Cost = 19999.00M,
                            Status = "Unsold"
                        },
                        new Item { 
                            Sku = "3423",
                            Model = "Jetta",
                            Year = 2024,
                            Color = "Blue",
                            Cost = 21499.00M,
                            Status = "Sale Pending"
                        },
                    },
                },
            };
            
            context.Inventory.AddRange(inventory);
            context.SaveChanges();
        }
    }
    public List<Inventory> GetInventory()
    {
        using (var context = new ApiContext())
        {
            var list = context.Inventory
                .Include(a => a.Items)
                .ToList();
            return list;
        }
    }
}
