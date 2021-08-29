using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class InsulinAdded
    {
        public InsulinType insulin { get; private set; }
        public int amount { get; private set; }

        public InsulinAdded(InsulinType insulin, int? amount) {
            this.insulin = insulin;
            this.amount = amount.HasValue ? amount.Value : 0; 
        }

        public InsulinAdded()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(insulin).Append(" ").Append(amount);
            return sb.ToString();
        }
    }
}
