namespace Tutorial4.Models;

public class Visit
{
    public Visit(DateTime date, int animalId, string description, int price)
    {
        this.date = date;
        this.animalId = animalId;
        this.description = description;
        this.price = price;
    }

    public DateTime date { get; set; }
    public int animalId { get; set; }
    public string description { get; set; }
    public int price { get; set; }
}