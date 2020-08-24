using System;
using VRP.UtilityControl.BL.Model;

namespace VRP.UtilityControl.BL.Controller
{
    public class PaymentController : BaseController
    {
        public Payment Payment { get; set; }
        public PaymentController(Payment payment)
        {
            Payment = payment ?? throw new ArgumentNullException("Платеж не может быть равен Null.", nameof(payment));
        }
    }
}
