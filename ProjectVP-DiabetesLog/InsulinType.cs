using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class InsulinType
    {
        public List<string> types{ get; private set; }

        public InsulinType()
        {
            types = new string[]
            {
                "Apidra",
                "Lantus",
                "Levemir"
            }.ToList();
        }
        public bool ContainsType(string name) => types.Contains(name);

        public bool addType(string name)
        {
            if (ContainsType(name))
                return false;
            types.Add(name);
            return true;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            types.ForEach(e => builder.Append(e));
            return builder.ToString();
        }
    }
}
