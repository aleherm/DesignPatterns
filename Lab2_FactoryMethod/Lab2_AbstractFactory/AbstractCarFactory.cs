namespace Lab2_AbstractFactory
{
    abstract class AbstractCarFactory
    {
        public static int LastId = 0;
        public abstract Car GetAutomobile(string color, int price);
        public abstract Car GetTruck(string color, int price);
    }
}
