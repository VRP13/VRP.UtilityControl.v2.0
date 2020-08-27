using System;
using System.Collections;
using System.Collections.Generic;

namespace VRP.UtilityControl.BL.Model
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public Month() { }
        public Month(string name)
        {
            Name = name ?? throw new ArgumentNullException("Название месяца не может быть пустым.", nameof(name));
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
