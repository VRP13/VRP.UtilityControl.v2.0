using System.Collections.Generic;

namespace VRP.UtilityControl.BL.Controller
{
    public abstract class BaseController
    {
        private readonly IDataManager dataManager = new DataManager();
        protected void Save<T>(List<T> item) where T : class
        {
            dataManager.Save(item);
        }
        protected List<T> Load<T>() where T : class
        {
            return dataManager.Load<T>();
        }
    }
}
