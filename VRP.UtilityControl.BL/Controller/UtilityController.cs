using System;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public class UtilityController : BaseController
    {
        public Utility Utility { get; set; }
        public UtilityController(Utility utility)
        {
            Utility = utility ?? throw new ArgumentNullException("Услуга не может быть равна Null.", nameof(utility));
        }
    }
}
