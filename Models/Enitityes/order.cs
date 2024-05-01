using System.ComponentModel.DataAnnotations;

public class order
{

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    
}