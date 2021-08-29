namespace ProjectVP_DiabetesLog
{
    public class Meal
    {
        public Food food { get; }
        public double amount { get; }

        public Meal(Food food, double? amount)
        {
            this.food = food;
            this.amount = amount.HasValue ? amount.Value : 0;
        }
    }
}