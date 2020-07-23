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
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public List<Account> GetList()
        {
            List<Account> list = new List<Account>();
            string QUERY = "SELECT * FROM Account";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(QUERY);
            foreach (DataRow item in data.Rows)
            {
                Account e = new Account(item);
                list.Add(e);
            }
            return list;
        }

        public bool CheckLogin(string Username, string Password)
        {
            string QUERY = "SELECT * FROM Account WHERE Username = @Username AND Password = @Password";
            DataTable result = DataProvider.GetInstance.ExecuteQuery(QUERY, new object[] { Username, Password });
            return result.Rows.Count > 0;
        }

        public Account GetAccount(string Username, string Password)
        {
            string QUERY = "SELECT * FROM Account WHERE Username = @Username AND Password = @Password";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(QUERY, new object[] { Username, Password });
            foreach (DataRow e in data.Rows)
                return new Account(e);
            return null;
        }

        public int Insert(string Username, string Password, Account.RoleType Role)
        {
            string query = "INSERT Account (Username, Password, Role) OUTPUT INSERTED.ID VALUES ( @username , @password , @role )";
            object result = DataProvider.GetInstance.ExecuteScalar(query, new object[] { Username, Password, (int)Role });
            return Convert.ToInt32(result);
        }

        public void Update(Account r)
        {
            string query = "UPDATE Account SET Password = @password , Role = @role WHERE Id = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { r.Password, r.Role, r.Id });
        }

        public void Delete(int AccountId)
        {
            string query = "DELETE FROM Account WHERE Id = @Id ";
            int result = DataProvider.GetInstance.ExecuteNonQuery(query, new object[] { AccountId });
        }
    }
}
