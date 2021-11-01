using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCodeStructure.Data;
using WebApiCodeStructure.Models;

namespace WebApiCodeStructure.Managers
{
    public class BookingManager
    {
        public bool MakeBooking(Booking booking)
        {
            Restaurant restaurant = DataStorage.Instance.GetRestaurant();
            if (booking.Day == "Saturday" && restaurant.Saturday + booking.Count <= restaurant.MaxCapacity)
            {
                restaurant.Saturday += booking.Count;
                DataStorage.Instance.SaveRestaurant(restaurant);
                return true;
            }
            else if (booking.Day == "Sunday" && restaurant.Sunday + booking.Count <= restaurant.MaxCapacity)
            {
                restaurant.Sunday += booking.Count;
                DataStorage.Instance.SaveRestaurant(restaurant);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Restaurant GetRestaurant()
        {
            return DataStorage.Instance.GetRestaurant();
        }
    }
}
