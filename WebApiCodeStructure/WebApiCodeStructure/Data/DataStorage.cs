using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCodeStructure.Models;

namespace WebApiCodeStructure.Data
{
    public class DataStorage
    {
        private static DataStorage _instance = null;

        public static DataStorage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataStorage();
                }
                return _instance;
            }
        }

        private Restaurant _restaurant;

        private DataStorage()
        {
            _restaurant = new Restaurant()
            {
                MaxCapacity = 3
            };
        }

        public Restaurant GetRestaurant()
        {
            return _restaurant;
        }

        public void SaveRestaurant(Restaurant restaurant)
        {
            _restaurant = restaurant;
        }
    }
}
