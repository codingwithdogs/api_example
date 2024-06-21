namespace interview.Models;

public class Inventory
{
    public int Id { get; set; }
    public string Manufacturer { get; set; }
    public List<Item> Items { get; set; }
}