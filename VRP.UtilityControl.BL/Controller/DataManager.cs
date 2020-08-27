using System.Collections.Generic;
using System.Linq;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public class DataManager : IDataManager
    {
        public List<T> Load<T>() where T : class
        {
            using (var db = new MyDbContext())
            {
                var result = db.Set<T>().Where(T => true).ToList();
                return result;
            }
        }
        public void Save<T>(List<T> item) where T : class
        {
            using (var db = new MyDbContext())
            {
                db.Set<T>().AddRange(item);
                db.SaveChanges();
            }
        }
    }
}
