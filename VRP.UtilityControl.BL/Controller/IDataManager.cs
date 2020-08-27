using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public interface IDataManager
    {
        void Save<T>(List<T> item) where T : class;
        List<T> Load<T>() where T : class;
    }
}
