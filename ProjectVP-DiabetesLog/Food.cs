using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class Food
    {
        public string name { get; private set; }
        public string brand { get; private set; }
        public double carbs { get; private set; }

        public Food(string name, string manufacturer, double carbs)
        {
            this.name = name;
            this.brand = manufacturer;
            this.carbs = carbs;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Equals(this.GetType()))
            {
                Food tmp = (Food)obj;
                if (tmp.name.Equals(this.name)
                    && tmp.brand.Equals(this.brand)
                    && tmp.carbs.Equals(this.carbs))
                {
                    return true;
                }
            }
            return false;
        }
        public string[] ToArray()
        {
            return new string[] { name, brand, carbs.ToString() };
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + name.GetHashCode();
            hash = hash * 31 + brand.GetHashCode();
            hash = hash * 31 + carbs.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return name + ", " + brand;
        }
    }
}
