using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController
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
    }
}
