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
        public string brand { get; private set; }

        public InsulinType(string name, string brand)
        {
            this.name = name;
            this.brand = brand;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Equals(this.GetType()))
            {
                InsulinType tmp = (InsulinType)obj;
                if (this.name.Equals(tmp.name)
                    && this.brand.Equals(tmp.brand))
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
            hash = 31 * hash + brand.GetHashCode();
            return hash;

        }
        public override string ToString()
        {
            //Prikazuva ime na Insulin
            return name;
        }
        
    }
}
