
namespace ApplicationsWeek3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time();
            Console.WriteLine(t1.ToString());

            Time t2 = new Time(1, 19);
            Console.WriteLine(t2);

            Time t3 = new(3, 50, 23);
            t3.WriteTime();
            Time.WriteTime(t3);
        }

        
            
        


       
    }
}
