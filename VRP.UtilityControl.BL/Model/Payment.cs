using System;

namespace VRP.UtilityControl.BL.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public int UtilityId { get; set; }
        public int MonthId { get; set; }
        public virtual Utility Utility { get; set; }
        public virtual Month Month { get; set; }
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
