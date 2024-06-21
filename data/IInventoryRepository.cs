using interview.Models;

namespace interview.Data;

public interface IInventoryRepository
{
    public List<Inventory> GetInventory();
}