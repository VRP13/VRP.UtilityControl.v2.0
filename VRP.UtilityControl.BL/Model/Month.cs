using System;

namespace VRP.UtilityControl.BL.Model
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
