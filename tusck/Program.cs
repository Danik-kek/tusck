namespace tusck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задайте размер массива");
            int n = int.Parse( Console.ReadLine());
            int[] a = new int [n];
            Console.WriteLine("Массив");
            for (int i = 0; i < a.Length; i++)
            {
                Random rand = new Random();
                
                
                

                a[i] = rand.Next(-127, 128);
                Console.Write(a[i] + " ");
            }
            
            
            
        }
    }
}
