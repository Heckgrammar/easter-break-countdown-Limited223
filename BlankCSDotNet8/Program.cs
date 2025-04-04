namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
				DateTime current = DateTime.Now;
                Console.WriteLine("what is target year");
                int year = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("what is target month");
				int month = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("what is target day");
				int day = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("what is target hour");
				int hour = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("what is target year");
				int min = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("what is target secs");
				int secs = Convert.ToInt32(Console.ReadLine());
				DateTime target = new DateTime(year, month, day, hour, min, secs);
                TimeSpan difference = target - current;
                Console.WriteLine(difference);
				Thread.Sleep(1000);
                Console.Clear();
			}
           
        }
    }
}
