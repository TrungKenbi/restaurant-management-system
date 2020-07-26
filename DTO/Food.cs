using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Food
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public Food(int _Id, String _Name, String _Description)
        {
            this.Id = _Id;
            this.Name = _Name;
            this.Description = _Description;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString();
            this.Description = row["Description"].ToString();
        }

        public override string ToString()
        {
            return "Food: " + Name;
        }
    }
}
