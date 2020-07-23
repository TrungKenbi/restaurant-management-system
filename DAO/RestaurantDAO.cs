using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RestaurantDAO
    {
        private static RestaurantDAO instance;

        public static RestaurantDAO Instance
        {
            get { if (instance == null) instance = new RestaurantDAO(); return instance; }
            private set { instance = value; }
        }

        private RestaurantDAO() { }

        public List<Restaurant> GetList()
        {
            List<Restaurant> list = new List<Restaurant>();
            string QUERY = "SELECT * FROM Restaurent";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(QUERY);
            foreach (DataRow item in data.Rows)
            {
                Restaurant e = new Restaurant(item);
                list.Add(e);
            }
            return list;
        }

        public int Insert(string name, string description, string address, string email, string hotline)
        {
            string query = "INSERT Restaurent (Name, Description, Address, Email, Hotline) OUTPUT INSERTED.ID VALUES ( @name , @description , @address , @email , @hotline )";
            object result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { name, description, address, email, hotline });
            return Convert.ToInt32(result);
        }

        public void Update(Restaurant r)
        {
            string query ="UPDATE Restaurent SET Name = @name , Description = @description , Address = @address , Email = @email , Hotline = @hotline WHERE Id = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { r.Name, r.Description, r.Address, r.Email, r.Hotline, r.Id });
        }

        public void Delete(int RestaurantId)
        {
            string query = "DELETE FROM Restaurent WHERE Id = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { RestaurantId });
        }
    }
}
