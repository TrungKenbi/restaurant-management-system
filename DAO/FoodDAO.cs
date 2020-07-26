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

        public int Insert(string Name, string Đescription)
        {
            string query = "INSERT Food (Name, Description) OUTPUT INSERTED.ID VALUES ( @name , @description )";
            object result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { Name, Đescription });
            return Convert.ToInt32(result);
        }

        public override void Update(Food r)
        {
            //string query = "UPDATE Food SET Password = @password , Role = @role WHERE Id = @Id ";
            //int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { r.Password, r.Role, r.Id });
        }

        public override void Delete(int FoodId)
        {
            //string query = "DELETE FROM Food WHERE Id = @Id ";
            //int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { FoodId });
        }
    }
}
