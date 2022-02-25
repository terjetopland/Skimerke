using Skimerke.Models;

namespace Skimerke;

public class Member
{
    public int Id { get; set; }
    
    public Member(int id)
    {
        this.Id = id;
    }
    
    //Relationship between Person and Member
    public int PersonId { get; set; }
    public Person Person { get; set; }
    
    //Relationship between Member and SKiClub
    public int SkiClubId { get; set; }



}

