using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get {
                if (instance == null)
                {
                    instance = new AccountBUS();

                }
                return instance;
            }
            private set { instance = value; }
        }

        public List<Account> GetList()
        {
            return AccountDAO.Instance.GetList();
        }

        public bool CheckLogin(string Username, string Password)
        {
            return AccountDAO.Instance.CheckLogin(Username, Password);
        }

        public Account GetAccount(string username, string password)
        {
            return AccountDAO.Instance.GetAccount(username, password);
        }

        public int Insert(string Username, string Password, Account.RoleType Role)
        {
            return AccountDAO.Instance.Insert(Username, Password, Role);
        }

        public void Update(Account r)
        {
            AccountDAO.Instance.Update(r);
        }

        public void Delete(int AccountId)
        {
            AccountDAO.Instance.Delete(AccountId);
        }
    }
}
