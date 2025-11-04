namespace TestLibrary
{
    public class TestClass
    {
        public int x;
        public int y;

        public void PrintInfo()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        public double Power()
        {
            return Math.Pow(x, y);
        }
    }
}
