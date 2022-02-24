using Skimerke.Models;

namespace Skimerke;

public class Coach 
{
    public int Id { get; set; }
    
    public string? Phone { get; set; }

    public string? Email { get; set; }
    
    public int PersonId { get; set; }

    public Person Person { get; set; } 
    
}