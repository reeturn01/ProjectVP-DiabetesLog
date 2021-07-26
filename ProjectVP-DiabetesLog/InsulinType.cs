using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class InsulinType
    {
        public string[] types{ get; set; }

        public InsulinType()
        {
            types = new string[]
            {
                "Apidra",
                "Lantus",
                "Levemir"
            };
        }
    }
}
