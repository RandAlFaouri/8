internal class Program
{
    static void Main(string[] args)
    {
        Date d1 = new Date(32, 02, 2000);
        //  d1.setValues(01, 01, 0001);

        Console.WriteLine(d1.GetDate());
    }
    public class Date
    {
        /* private int dayInMonth; //or
         private int _dayInMonth;*/
        private int day;
          private int month;
        private int year;
        private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Date(int day, int month, int year)
        {
            var isLeap=year%4==0 && (year%100 !=0 || year%400==0);
            if(year>=1 && year <=9999 && month>=1 && month <= 12)
            {
                int[] days = isLeap ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year; }
                else
                {
                    this.day = 01;
                    this.month = 01;
                    this.year = 01;
                }
                }
            else
            {
                this.day = 01;
                this.month = 01;
                this.year = 01;
            }
            }
           
        
        /* public void setValues(int day,int month , int year)
         {
             Day = day;
             Month = month;
             Year = year;
         }*/
        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4,  '0')}";
        }

    }
}