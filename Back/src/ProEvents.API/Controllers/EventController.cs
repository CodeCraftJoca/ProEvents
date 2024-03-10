using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private IEnumerable<Event> _event = new Event[] {
       new Event() {
                EventId = 1,
                Theme = ".net Core 8",
                Local = "Santa Monica",
                Lot = "1",
                NumberOfPeople = 250,
                EventDate = DateTime.Now.AddDays(10).ToString(),
                ImgUrl = "netcore8.png"
        },
         new Event() {
                EventId = 2,
                Theme = "Angular 17",
                Local = "Time Square",
                Lot = "2",
                NumberOfPeople = 250,
                EventDate = DateTime.Now.AddDays(25).ToString(),
                ImgUrl = "Angular.png"
        }
    };

    public EventController()
    {
    }

    [HttpGet]
    public IEnumerable<Event> Get()
    {
        return _event;
    }

    [HttpGet("{id}")]
    public IEnumerable<Event> GetById(int id)
    {
        return _event.Where(e => e.EventId == id);
    }

    [HttpPost]
    public string Post()
    {
        string value = "0";
        return value;
    }

    [HttpPut]
    public string Put()
    {
        string value = "0";
        return value;
    }

    [HttpDelete]
    public string Delete()
    {
        string value = "0";
        return value;
    }
}
