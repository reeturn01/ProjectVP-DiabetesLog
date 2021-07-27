using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class InsulinType
    {
        public string name { get; private set; }
        public string manufacturer { get; private set; }

        public InsulinType(string name, string manufacturer)
        {
            this.name = name;
            this.manufacturer = manufacturer;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Equals(this.GetType()))
            {
                InsulinType tmp = (InsulinType)obj;
                if (this.name.Equals(tmp.name)
                    && this.manufacturer.Equals(tmp.manufacturer))
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = 31 * hash + name.GetHashCode();
            hash = 31 * hash + manufacturer.GetHashCode();
            return hash;

        }
        public override string ToString()
        {
            //Prikazuva ime na Insulin
            return name;
        }
        
    }
}
