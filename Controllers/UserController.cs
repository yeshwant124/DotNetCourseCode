using DotNetAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController(IConfiguration config)
        {
            Console.WriteLine(config.GetConnectionString("DefaultConnection"));

        }

        [HttpGet("GetUsers/{testValue}")]
        //public IEnumerable<Users> GetUsers()
        public string[] GetUsers(string testValue)
        {
            return new string[] { "user1", "user2", "user3", "user4", testValue };
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}