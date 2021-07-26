using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class InsulinType
    {
        public string[] Types{ get; set; }

        public InsulinType()
        {
            Types = new string[]
            {
                "Apidra",
                "Lantus",
                "Levemir"
            };
        }
    }
}
