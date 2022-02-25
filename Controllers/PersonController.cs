using Microsoft.AspNetCore.Mvc;

namespace Skimerke.Controllers;

using Skimerke.Models;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Person> Get()
    {
        var person1 = new Person(1, "Terje Topland", "12.12.12", "12345678","@terje");
        
        var person2 = new Person(2, "Bjarte Skaar", "13.12.12", "876543231", "@bjarte");

        var persons = new List<Person>();
        
        persons.Add(person1);
        persons.Add(person2);

        return persons;
    }
}