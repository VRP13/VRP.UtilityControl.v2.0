using System;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public class MonthController : BaseController
    {
        public Month Month { get; set; }
        public MonthController(Month month)
        {
            Month = month ?? throw new ArgumentNullException("Месяц не может быть равен Null.", nameof(month));
        }
    }
}
