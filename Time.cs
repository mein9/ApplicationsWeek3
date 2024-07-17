
namespace ApplicationsWeek3
{
    internal class Time
    {
        public int hour, minute;
        public double second;

        public Time()
        {
            hour = 1;
            minute = 2;
            second = 3.0;
        }
        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            
        }
        public Time(int hour, int minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public override string ToString()
        {
            return this.hour + ":" + this.minute + ":" + this.second;
        }

        public void WriteTime()
        {
            Console.WriteLine(hour + ":" + minute + ":" + second);
            
        }
        public static void WriteTime(Time t)
        {
            Console.WriteLine(t.hour + ":" + t.minute + ":" + t.second);

        }
    }
}
