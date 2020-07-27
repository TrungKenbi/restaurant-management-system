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
    public class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get { if (instance == null) instance = new FoodBUS(); return instance; }
            private set { instance = value; }
        }

        private FoodBUS() { }

        public List<Food> GetList()
        {
            return FoodDAO.Instance.GetList();
        }

        public int Insert(string Name, string Description)
        {
            return FoodDAO.Instance.Insert(Name, Description);
        }

        public void Update(Food r)
        {
            FoodDAO.Instance.Update(r);
        }

        public void Delete(int FoodId)
        {
            FoodDAO.Instance.Delete(FoodId);
        }

        public void InsertToRestaurant(int RestaurantId, int FoodId, int Price)
        {
            FoodDAO.Instance.InsertToRestaurant(RestaurantId, FoodId, Price);
        }

        public int GetNumFoodInRestaurant(int resId)
        {
            return FoodDAO.Instance.GetNumFoodInRestaurant(resId);
        }
    }
}
