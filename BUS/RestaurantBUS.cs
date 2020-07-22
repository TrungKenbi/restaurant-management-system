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

        public List<Restaurant> GetList()
        {
            return RestaurantDAO.Instance.GetList();
        }

        public int Insert(string name, string description, string address, string email, string hotline)
        {
            return RestaurantDAO.Instance.Insert(name, description, address, email, hotline);
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
