using System;

namespace VRP.UtilityControl.BL.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public int UtilityId { get; set; }
        public int MonthId { get; set; }
        public virtual Utility Utility { get; set; }
        public virtual Month Month { get; set; }
        public int Volume { get; set; }
        public decimal Cost { get; set; }
        public Bill() { }
        public Bill(Utility utility, Month month, int volume, decimal cost)
        {
            Utility = utility;
            Month = month;
            if (volume < 0)
            {
                throw new ArgumentOutOfRangeException("Объем услуги не может быть отрицательным.", nameof(volume));
            }
            Volume = volume;
            if (cost < 0)
            {
                throw new ArgumentOutOfRangeException("Стоимость услуги не может быть отрицательной.", nameof(volume));
            }
            Cost = cost;
        }

    }
}
