using System;
using System.Collections.Generic;

namespace VRP.UtilityControl.BL.Model
{
    public class Utility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Tariff { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public Utility() { }
        public Utility(string name, double tariff)
        {
            Name = name ?? throw new ArgumentNullException("Название услуги не может быть пустым.", nameof(name));
            if(tariff <= 0)
            {
                throw new ArgumentOutOfRangeException("Тариф услуги не может быть меньше или равен нулю.", nameof(tariff));
            }
            Tariff = tariff;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
