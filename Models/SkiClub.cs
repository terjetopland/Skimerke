namespace Skimerke.Models;

public class SkiClub
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public SkiClub(int id, string name, string phone, string email)
    {
        this.Id = id;
        this.Name = name;
        this.Phone = phone;
        this.Email = email;
    }
    
    public List<Member> Members { get; set; }
    
    public List<Coach> Coaches { get; set; }
}