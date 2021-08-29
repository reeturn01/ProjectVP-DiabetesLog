using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class TimeMeasurement
    {
        public DateTime time { get; private set; }
        public double measurement { get; set; }
        public InsulinAdded insulinAdded { get; set; }
        public List<Meal> meals { get; set; }

        public TimeMeasurement(DateTime time) {
            this.time = time;
            measurement = 0;
            insulinAdded = new InsulinAdded();
            meals = new List<Meal>();
        }

        public TimeMeasurement(DateTime time, double? measurement, InsulinAdded insulinAdded, List<Meal> meals) {
            this.time = time;
            this.measurement = measurement.HasValue ? measurement.Value : 0;
            this.insulinAdded = insulinAdded;
            this.meals = meals;
        }
        public TimeMeasurement(DateTime time, double? measurement, InsulinAdded insulinAdded)
        {
            this.time = time;
            this.measurement = measurement.HasValue ? measurement.Value : 0;
            this.insulinAdded = insulinAdded;
            this.meals = new List<Meal>();
        }

        public void addMeal(Meal mealToAdd) {
            meals.Add(mealToAdd);
        }
        public bool matchingTime(string timeVal) {
            return time.ToString("HH:mm").Equals(timeVal);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(time.ToString("HH:mm")).Append(" ").Append(measurement).Append(" ").Append(insulinAdded);
            return sb.ToString();
        }
    }
}
