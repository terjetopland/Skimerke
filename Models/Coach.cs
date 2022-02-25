using Skimerke.Models;

namespace Skimerke;

public class Coach 
{
    public int Id { get; set; }
    
    public string? Phone { get; set; }

    public string? Email { get; set; }
    
    
    //Relationship between person and coach
    public int PersonId { get; set; }

    public Person Person { get; set; } 
    
}