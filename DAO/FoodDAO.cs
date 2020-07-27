using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FoodDAO : BaseDAO<FoodDAO, Food>
    {
        public override List<Food> GetList()
        {
            List<Food> list = new List<Food>();
            string QUERY = "SELECT * FROM Food";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(QUERY);
            foreach (DataRow item in data.Rows)
            {
                Food e = new Food(item);
                list.Add(e);
            }
            return list;
        }

        public int Insert(string Name, string Description)
        {
            string query = "INSERT Food (Name, Description) OUTPUT INSERTED.Id VALUES ( @name , @description )";
            object result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { Name, Description });
            return Convert.ToInt32(result);
        }

        public override void Update(Food r)
        {
            string query = "UPDATE Food SET Name = @name , Description = @desc WHERE Id = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { r.Name, r.Description, r.Id });
        }

        public override void Delete(int FoodId)
        {
            string query = "DELETE FROM Food WHERE Id = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { FoodId });
        }

        public void InsertToRestaurant(int RestaurantId, int FoodId, int Price)
        {
            string query = "INSERT RestaurantFood (RestaurantId, FoodId, Price) VALUES ( @resId , @fId , @price )";
            object result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { RestaurantId, FoodId, Price });
        }

        public int GetNumFoodInRestaurant(int resId)
        {
            string QUERY = "SELECT * FROM RestaurantFood WHERE RestaurantId = " + resId;
            DataTable data = DataProvider.GetInstance.ExecuteQuery(QUERY);
            return data.Rows.Count;
        }
    }
}
