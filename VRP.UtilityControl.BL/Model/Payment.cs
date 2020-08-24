using System;

namespace VRP.UtilityControl.BL.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
        public Payment() { }
        public Payment(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentOutOfRangeException("Платеж не может быть меньше или равен нулю.", nameof(money));
            }
            Money = money;
        }
    }
}
