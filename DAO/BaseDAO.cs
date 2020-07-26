using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public abstract class BaseDAO<T, V> where T : BaseDAO<T, V>, new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new T();
                return _instance;
            }
        }

        abstract public List<V> GetList();
        abstract public void Update(V r);
        abstract public void Delete(int Id);
    }
}
