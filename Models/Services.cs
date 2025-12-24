namespace asp.Models;

public class Services
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Services(int id, String name)
    {
        this.Id = id;
        this.Name = name;
    }
}