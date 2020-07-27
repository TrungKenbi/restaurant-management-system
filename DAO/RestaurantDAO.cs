using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RestaurantDAO : BaseDAO<RestaurantDAO, Restaurant>
    {
        public override List<Restaurant> GetList()
        {
            return this.GetList(null);
        }

        public List<Restaurant> GetList(String keyword)
        {
            string QUERY;
            DataTable data;
            List<Restaurant> list = new List<Restaurant>();
            if (keyword != null) {
                QUERY = "SELECT * FROM Restaurant LEFT JOIN RestaurantInfo ON RestaurantInfo.RestaurantId = Restaurant.Id WHERE Restaurant.Name LIKE @keyword";
                data = DataProvider.GetInstance.ExecuteQuery(QUERY, new object[] { "%" + keyword + "%" });
            } else {
                QUERY = "SELECT * FROM Restaurant LEFT JOIN RestaurantInfo ON RestaurantInfo.RestaurantId = Restaurant.Id";
                data = DataProvider.GetInstance.ExecuteQuery(QUERY);
            }
            foreach (DataRow item in data.Rows)
            {
                Restaurant e = new Restaurant(item);
                list.Add(e);
            }
            return list;
        }

        public int Insert(string name, string description, string address, string email, string hotline, double lat, double lng, int acreage, int capacity, int star, double rating)
        {
            string query = "INSERT Restaurant (Name, Description, Address, Email, Hotline, Lat, Lng) OUTPUT INSERTED.ID VALUES ( @name , @description , @address , @email , @hotline , @Lat , @Lng )";
            object result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { name, description, address, email, hotline, lat, lng });
            int rId = Convert.ToInt32(result);

            query = "INSERT RestaurantInfo (RestaurantId, Acreage, Capacity, Star, Rating) VALUES ( @restaurant_id , @acreage , @capacity , @star , @rating )";
            result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { rId, acreage, capacity, star, rating });

            return rId;
        }

        public override void Update(Restaurant r)
        {
            string query = "UPDATE Restaurant SET Name = @name , Description = @description , Address = @address , Email = @email , Hotline = @hotline , Lat = @lat , Lng = @lng WHERE Id = @id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { r.Name, r.Description, r.Address, r.Email, r.Hotline, r.Lat, r.Lng, r.Id });

            query = "UPDATE RestaurantInfo SET Acreage = @acreage , Capacity = @capacity , Star = @start , Rating = @rating WHERE RestaurantId = @id ";
            result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { r.Acreage, r.Capacity, r.Star, r.Rating, r.Id });
        }

        public override void Delete(int RestaurantId)
        {
            string query = "DELETE FROM RestaurantInfo WHERE RestaurantId = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { RestaurantId });

            query = "DELETE FROM Restaurant WHERE Id = @Id ";
            result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { RestaurantId });
        }
    }
}
