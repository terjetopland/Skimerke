namespace Skimerke.Models;

public class Person
{
    public int Id { get; set; }

    public string? Name { get; set; } 
    
    public string Birth { get; set; }

    public string Phone { get; set; }
    
    public string Email { get; set; }
    
    public Person(int id, string name, string birth, string phone, string email)
    {
        this.Id = id;
        this.Name = name;
        this.Birth = birth;
        this.Phone = phone;
        this.Email = email;
    }
    
    public List<Coach>? Coaches { get; set; }



}

