namespace ProjectVP_DiabetesLog
{
    public class Meal
    {
        public Food food { get; }
        public int amount { get; }

        public Meal(Food food, int amount)
        {
            this.food = food;
            this.amount = amount;
        }

    }
}