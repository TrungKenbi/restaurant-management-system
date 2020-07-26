using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RestaurantBUS
    {
        private static RestaurantBUS instance;

        public static RestaurantBUS Instance
        {
            get { if (instance == null) instance = new RestaurantBUS(); return instance; }
            private set { instance = value; }
        }

        private RestaurantBUS() { }

        public List<Restaurant> GetList(String keyword = null)
        {
            return RestaurantDAO.Instance.GetList(keyword);
        }

        public int Insert(string name, string description, string address, string email, string hotline, double lat = 10.9806545, double lng = 106.672259)
        {
            return RestaurantDAO.Instance.Insert(name, description, address, email, hotline, lat, lng);
        }

        public void Update(Restaurant r)
        {
            RestaurantDAO.Instance.Update(r);
        }

        public void Delete(int RestaurantId)
        {
            RestaurantDAO.Instance.Delete(RestaurantId);
        }
    }
}
