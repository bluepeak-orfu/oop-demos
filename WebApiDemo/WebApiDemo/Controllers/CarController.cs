using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : ControllerBase
    {
        [HttpGet("get")] // Blir /car/get
        public string GetCar(int age, string model)
        {
            return $"a car with age {age} and model {model}";
        }

        [HttpGet] // Blir /car
        public string GetCar2()
        {
            return "another car";
        }

        [HttpGet("fromcountry/{country}")] // Blir /car/fromcountry/????
        public string ListCar(string country)
        {
            return $"car1 is from {country}";
        }

        [HttpPost("getclass")]
        public string GetCarClass(Car car)
        {
            return car.Name;
        }

        [HttpPost("string-demo")]
        public string StringDemo([FromBody] string value, [FromQuery] int count)
        {
            return $"The value is {value} with count {count}";
        }

        [HttpGet("mycar")]
        public Car MyCar()
        {
            return new Car() {
                Name = "car1",
                Age = 17,
                Home = "qwerty"
            };
        }

        [HttpGet("mycar2")]
        public IActionResult MyCar2(int count)
        {
            if (count < 0)
            {
                return NotFound();
            }
            else
            {
                Car car = new Car()
                {
                    Name = "car1",
                    Age = 17,
                    Home = "qwerty"
                };
                return Ok(car);
            }
        }
    }
}
