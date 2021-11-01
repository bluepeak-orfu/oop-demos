using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCodeStructure.DTO;
using WebApiCodeStructure.Managers;
using WebApiCodeStructure.Models;

namespace WebApiCodeStructure.Controllers
{
    [Route("booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingManager _bookingManager;

        public BookingController()
        {
            _bookingManager = new BookingManager();
        }

        [HttpPost]
        public string MakeBooking(Booking booking)
        {
            bool success = _bookingManager.MakeBooking(booking);
            if (success)
            {
                return "Booking made";
            }
            else
            {
                return "Unable to make booking";
            }
        }

        [HttpGet("restaurant")]
        public RestaurantDTO GetRestaurant()
        {
            Restaurant restaurant = _bookingManager.GetRestaurant();
            RestaurantDTO dto = new RestaurantDTO()
            {
                Saturday = restaurant.Saturday < restaurant.MaxCapacity,
                Sunday = restaurant.Sunday < restaurant.MaxCapacity
            };
            return dto;
        }
    }
}
