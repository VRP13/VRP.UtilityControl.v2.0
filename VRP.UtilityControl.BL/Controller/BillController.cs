using System;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public class BillController : BaseController
    {
        public Bill Bill { get; set; }
        public BillController(Bill bill)
        {
            Bill = bill ?? throw new ArgumentNullException("Счет не может быть равен Null.", nameof(bill));
        }
    }
}
