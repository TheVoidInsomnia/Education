namespace Migrainebot
{
    /// <summary>
    /// Составить программу вывода любого числа любое заданное число раз в виде, аналогичном показанному в предыдущей задаче.
    /// </summary>
    internal class ExC1_2
    {
        public static void Run()
        {
            
            var count = 100;
            Console.WriteLine("Введите число");
            int outNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{outNum} ");
            }
        }
    }
}
