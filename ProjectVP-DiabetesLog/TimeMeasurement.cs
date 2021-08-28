using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVP_DiabetesLog
{
    public class TimeMeasurement
    {
        public double measurement { get; private set; }
        public InsulinAdded insulinAdded { get; private set; }
        public List<Meal> meals { get; private set; }

        public TimeMeasurement() {
            measurement = 0;
            insulinAdded = new InsulinAdded();
            meals = new List<Meal>();
        }

        public TimeMeasurement(double measurement, InsulinAdded insulinAdded, List<Meal> meals) {
            this.measurement = measurement;
            this.insulinAdded = insulinAdded;
            this.meals = meals;
        }

        public void addMeal(Meal mealToAdd) {
            meals.Add(mealToAdd);
        }
    }
}
