using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class Food
    {
        public string type { get; private set; }
        public string manufacturer { get; private set; }
        public float carbs { get; private set; }

        public Food(string type, string manufacturer, float carbs)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.carbs = carbs;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Equals(this.GetType()))
            {
                Food tmp = (Food)obj;
                if (tmp.type.Equals(this.type)
                    && tmp.manufacturer.Equals(this.manufacturer)
                    && tmp.carbs.Equals(this.carbs))
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + type.GetHashCode();
            hash = hash * 31 + manufacturer.GetHashCode();
            hash = hash * 31 + carbs.GetHashCode();
            return hash;
        }
    }
}
