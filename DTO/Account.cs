using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public RoleType Role { get; set; }
        public DateTime TimeCreated { get; set; }

        public enum RoleType {
            Member = 0,
            Modder = 1,
            Administrator = 2
        }

        public Account(String _Username, String _Password, RoleType _Role, DateTime _TimeCreated) 
        {
            this.Username = _Username;
            this.Password = _Password;
            this.Role = _Role;
            this.TimeCreated = _TimeCreated;
        }

        public Account(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            switch ((int)row["Role"])
            {
                case 00:
                    this.Role = RoleType.Member;
                    break;
                case 01:
                    this.Role = RoleType.Modder;
                    break;
                case 02:
                    this.Role = RoleType.Administrator;
                    break;
            }
            this.TimeCreated = Convert.ToDateTime(row["TimeCreated"].ToString());
        }

        public override string ToString()
        {
            return "Account: " + Username + " " + Password;
        }
    }
}
